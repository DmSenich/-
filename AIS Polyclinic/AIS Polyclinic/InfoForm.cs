using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS_Polyclinic
{
    public partial class InfoForm : Form
    {
        static private string pathImPhoto = "materials\\defaultPhoto.jpeg";
        static private Image defaultPhoto;
        SqlManager myDB;
        DataTable dtSpecDoc;
        DataTable dtSpec;
        DataTable dtSpecs;
        DataTable dtPerson;
        Image photo;
        string sSql = "";
        int numTable;
        int id;
        private InfoForm()
        {
            InitializeComponent();
            try
            {
                defaultPhoto = Image.FromFile(pathImPhoto);
            }
            catch
            {
                Close();
                MessageBox.Show("Отсутствует файл defaultPhoto.jpeg в папке materials");

            }
        }
        public InfoForm(int id, int num, SqlManager myDB) : this()       //добавить класс-sql
        {
            numTable = num;
            this.id = id;
            this.myDB = myDB;
            
        }

        private string StringSpecBuild() // + создает таблицу принадлежащих доктору специальностей
        {
            string specs = "";
            sSql = $"select * from \"DOCTOR-SPECIALTY_TABLE\" where id_doctor = {id}";
            dtSpecDoc = myDB.iExecuteReader(sSql);


            sSql = $"select list (name_specialty , ', ') from \"SPECIALTY_TABLE\" where id_specialty in (select id_specialty from \"DOCTOR-SPECIALTY_TABLE\" where id_doctor = {id})";
            specs = myDB.iExecuteReader(sSql).Rows[0][0].ToString();

            return specs;
        }
        private void CreateTable()
        {
            //DataTable dt = new DataTable();
            switch (numTable) 
            {
                case 0:
                    string fio = String.Join(" ", dtPerson.Rows[0][1], dtPerson.Rows[0][2], dtPerson.Rows[0][3]);
                    richTextBoxInfo.Text = $"ФИО: {fio}\n";
                    richTextBoxInfo.Text += $"Опыт работы (в годах): {dtPerson.Rows[0][4]}\n";
                    richTextBoxInfo.Text += $"Перечень специальностей: {StringSpecBuild()}";
                    try
                    {
                        photo = ToImage((byte[])dtPerson.Rows[0][5]);
                    }
                    catch
                    {
                        photo = defaultPhoto;
                    }
                    
                    break;
                case 1:
                    //dt.Columns.Add("FIO");
                    //dt.Columns.Add("DateBirth");
                    //dt.Columns.Add("Adress");

                    //DataRow xdr = dt.NewRow();
                    //xdr[0] = dtPerson.Rows[0][1] + " " + dtPerson.Rows[0][2] + " " + dtPerson.Rows[0][3];
                    //xdr[1] = Convert.ToDateTime(dtPerson.Rows[0][8].ToString()).ToString("dd.MM.yyyy");

                    //xdr[2] = String.Join(", ", dtPerson.Rows[0][4], dtPerson.Rows[0][5], dtPerson.Rows[0][6], dtPerson.Rows[0][7]);
                    //dt.Rows.Add(xdr);

                    fio = String.Join(" ", dtPerson.Rows[0][1], dtPerson.Rows[0][2], dtPerson.Rows[0][3]);
                    richTextBoxInfo.Text = $"ФИО: {fio}\n";
                    richTextBoxInfo.Text += $"Дата рождения: {Convert.ToDateTime(dtPerson.Rows[0][8].ToString()).ToString("dd.MM.yyyy")}\n";
                    richTextBoxInfo.Text += $"Адрес: {String.Join(", ", dtPerson.Rows[0][4], dtPerson.Rows[0][5], dtPerson.Rows[0][6])}";
                    if(dtPerson.Rows[0][7] != null)
                    {
                        richTextBoxInfo.Text += ", " + dtPerson.Rows[0][7];
                    }
                    photo = defaultPhoto;

                    break;
            }
            
            //dataInfo.DataSource = dt;
            pPhoto.Image = photo;
        }
        static public Image ToImage(byte[] data)
        {
            if (data == null)
            {
                return null;
            }
            Image img;
            using (MemoryStream memory = new MemoryStream(data))
            {
                using (Image temp = Image.FromStream(memory))
                {
                    img = new Bitmap(temp);
                }
            }
            return img;
        }
        static public byte[] ToByte(Image img)
        {
            Byte[] blob;
            try
            {
                MemoryStream memory = new MemoryStream();
                img.Save(memory, ImageFormat.Jpeg);
                blob = new byte[memory.Length];
                memory.Position = 0;
                memory.Read(blob, 0, Convert.ToInt32(memory.Length));
                return blob;
            }
            catch
            {
                return null;
            }
        }
        private void bUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                switch (numTable)
                {
                    case 0:
                        sSql = "select * from \"SPECIALTY_TABLE\"";
                        dtSpecs = myDB.iExecuteReader(sSql);
                        sSql = $"execute procedure LISTING_SPEC_ID_OF_DOC({id})";

                        DataTable listSp = myDB.iExecuteReader(sSql);
                        string[] sp = listSp.Rows[0][0].ToString().Split(',');
                        int[] idSpecOld = new int[sp.Length];
                        for (int i = 0; i < sp.Length; i++)
                        {
                            idSpecOld[i] = Convert.ToInt32(sp[i]);
                        }
                        //FormAddDoctor upDoctor = new FormAddDoctor(dtPerson, dtSpec, dtSpecs);
                        FormAddDoctor upDoctor = new FormAddDoctor(dtPerson, idSpecOld, dtSpecs);
                        Hide();
                        if (upDoctor.ShowDialog() == DialogResult.OK)
                        {
                            DataTable newSpec = upDoctor.DTSpec; //id and name
                            string[] fio = upDoctor.FIO;
                            int workExp = upDoctor.WorkExp;

                            Image image = upDoctor.GetPHOTO;

                            byte[] blob = ToByte(image);

                            DataTable newSpecDoc = dtSpecDoc.Clone();
                            newSpecDoc.Rows.Clear();
                            foreach (DataRow dr in newSpec.Rows)
                            {
                                DataRow xdr = newSpecDoc.NewRow();
                                xdr[1] = dr[0];
                                xdr[0] = dtPerson.Rows[0][0];
                                newSpecDoc.Rows.Add(xdr);
                            }

                            int[] idSpec = new int[dtSpecDoc.Rows.Count];
                            for (int i = 0; i < idSpec.Length; i++)
                            {
                                idSpec[i] = Convert.ToInt32(dtSpecDoc.Rows[i][1]);
                            }
                            int[] idSpecNew = new int[newSpec.Rows.Count];
                            for (int i = 0; i < idSpecNew.Length; i++)
                            {
                                idSpecNew[i] = Convert.ToInt32(newSpec.Rows[i][0]);
                            }

                            foreach (int id in idSpec)
                            {
                                if (!idSpecNew.Contains(id))
                                {
                                    sSql = $"delete from \"DOCTOR-SPECIALTY_TABLE\" where id_specialty = {id}";
                                    myDB.iExeecuteNonQuery(sSql);
                                }
                            }
                            foreach (int id in idSpecNew)
                            {
                                if (!idSpec.Contains(id))
                                {
                                    sSql = $"execute procedure add_doc_spec({dtPerson.Rows[0][0]}, {id}) ";
                                    myDB.iExeecuteNonQuery(sSql);
                                }
                            }


                            //foreach (DataRow row in dtSpecDoc.Rows)
                            //{
                            //    if (!newSpecDoc.Rows.Contains(row))
                            //    {
                            //        sSql = $"delete from \"DOCTOR-SPECIALTY_TABLE\" where id_specialty = {row[0]}";
                            //        myDB.iExeecuteNonQuery(sSql);
                            //    }
                            //}
                            //foreach (DataRow row in newSpecDoc.Rows)
                            //{
                            //    if (!dtSpecDoc.Rows.Contains(row))
                            //    {
                            //        sSql = $"insert into \"DOCTOR-SPECIALTY_TABLE\" (id_doctor, id_specialty) values({dtPerson.Rows[0][0]}, {row[0]}) ";
                            //        myDB.iExeecuteNonQuery(sSql);
                            //    }
                            //}

                            //for (int i = 0; i < dtSpecDoc.Rows.Count; i++)
                            //{
                            //    //if(newSpec.Columns[0].ExtendedProperties.Contains(fio[i]))

                            //    if (!newSpec.Columns[0].ExtendedProperties.Contains(dtSpecDoc.Rows[i][0].ToString()))
                            //    {
                            //        sSql = $"delete from \"DOCTOR-SPECIALTY_TABLE\" where id_specialty = {dtSpecDoc.Rows[i][0]}";
                            //        myDB.iExeecuteNonQuery(sSql);
                            //    }
                            //}
                            //for(int i = 0; i < newSpec.Rows.Count; i++)
                            //{
                            //    if (!dtSpecDoc.Columns[0].ExtendedProperties.Contains(newSpec.Rows[i][0].ToString()))
                            //    {
                            //        sSql = $"insert into \"DOCTOR-SPECIALTY_TABLE\" (id_doctor, id_specialty) values({dtPerson.Rows[0][0]}, {newSpec.Rows[i][0]}) ";
                            //        myDB.iExeecuteNonQuery(sSql);
                            //    }
                            //}

                            myDB.iExeecuteUpDoctor(Convert.ToInt32(dtPerson.Rows[0][0]), fio[0], fio[1], fio[2], workExp, blob);
                        }
                        break;
                    case 1:
                        FormAddPatient upPatient = new FormAddPatient(dtPerson);
                        Hide();
                        if (upPatient.ShowDialog() == DialogResult.OK)
                        {
                            string[] fio = upPatient.FIO;
                            string[] adress = upPatient.Adress;
                            DateTime birth = upPatient.DateBirth;

                            sSql = $"update patient_table set last_name = '{fio[0]}', first_name = '{fio[1]}', PATRONYMIC = '{fio[2]}', area = '{adress[0]}', city = '{adress[1]}', house = '{adress[2]}', apartment = {adress[3]} where id_patient = {dtPerson.Rows[0][0]}";
                            myDB.iExeecuteNonQuery(sSql);
                        }
                        break;
                }
                updateDataView();
                Show();
            }catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void InfoForm_Activated(object sender, EventArgs e)
        {
            //switch (numTable)
            //{
            //    case 0:
            //        break;
            //    case 1:
            //        break;
            //}
        }

        private void InfoForm_Shown(object sender, EventArgs e)
        {
            
            updateDataView();
        }

        private void updateDataView()
        {
            switch (numTable)
            {
                case 0:
                    sSql = $"select * from doctor_table where id_doctor = {id}";
                    Text = "Информация о докторе";
                    break;
                case 1:
                    sSql = $"select * from patient_table where id_patient = {id}";
                    Text = "Информация о пациенте";
                    break;
            }

            dtPerson = myDB.iExecuteReader(sSql);
            CreateTable();
        }
        public void ToBlockUpdate()
        {
            bUpdate.Enabled = false;
            //bUpdate.Visible = false;
        }

        private void dataInfo_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
