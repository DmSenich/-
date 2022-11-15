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
        SqlManager myDB;
        DataTable dtSpecDoc;
        DataTable dtSpec;
        DataTable dtSpecs;
        DataTable dtDoc;
        string sSql = "";
        int numTable;
        int id;
        private InfoForm()
        {
            InitializeComponent();
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
            sSql = $"select * from \"SPECIALTY_TABLE\"";
            dtSpec = myDB.iExecuteReader(sSql);
            dtSpec.Rows.Clear();
            for (int i = 0; i < dtSpecDoc.Rows.Count; i++)
            {
                sSql = $"select * from \"SPECIALTY_TABLE\" where ID_SPECIALTY = {dtSpecDoc.Rows[i][1]}";
                DataTable sp = myDB.iExecuteReader(sSql);
                DataRow dr = dtSpec.NewRow();
                dr[0] = sp.Rows[0][0];
                dr[1] = sp.Rows[0][1];
                dtSpec.Rows.Add(dr);
                specs += $"{sp.Rows[0][1]}\n";
            }

            return specs;
            //string sql = "select * from SPECIALTY_TABLE";
            //dtSpec = myDB.iExecuteReader(sql);
            //DataTable table = new DataTable();
            //table.Columns.Add("id");
            //table.Columns.Add("Specialty");
            //table.Columns.Add("Having");
            //table.Columns[2].DataType = typeof(bool);
            //table.Columns[2].DefaultValue = false;

            //for (int i = 0; i < dtSpec.Rows.Count; i++)
            //{
            //    DataRow dr = table.NewRow();
            //    dr[0] = dtSpec.Rows[i][0];
            //    dr[1] = dtSpec.Rows[i][1];
            //    if (oldDoc && idSpec.Contains(i + 1))
            //    {
            //        dr[2] = true;
            //    }
            //    table.Rows.Add(dr);
            //}
            //dataSpecialty.DataSource = table;
            //dataSpecialty.Columns[0].Visible = false;
        }
        private void CreateTable()
        {
            DataTable dt = new DataTable();
            switch (numTable) 
            {
                case 0:
                    dt.Columns.Add("FIO");
                    dt.Columns.Add("WorkExp");
                    dt.Columns.Add("Spec");

                    DataRow dr = dt.NewRow();
                    dr[0] = dtDoc.Rows[0][1] + " " + dtDoc.Rows[0][2] + " " + dtDoc.Rows[0][3];
                    dr[1] = dtDoc.Rows[0][4];
                    dr[2] = StringSpecBuild();
                    dt.Rows.Add(dr);

                    
                    break;
                case 1:
                    break;
            }
            
            dataInfo.DataSource = dt;

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
            switch(numTable)
            {
                case 0:
                    sSql = "select * from \"SPECIALTY_TABLE\"";
                    dtSpecs = myDB.iExecuteReader(sSql);
                    FormAddDoctor upDoctor = new FormAddDoctor(dtDoc, dtSpec, dtSpecs);
                    Hide();
                    if(upDoctor.ShowDialog() == DialogResult.OK)
                    {
                        DataTable newSpec = upDoctor.DTSpec; //id and name
                        string[] fio = upDoctor.FIO;
                        int workExp = upDoctor.WorkExp;

                        DataTable newSpecDoc = dtSpecDoc.Clone();
                        newSpecDoc.Rows.Clear();
                        foreach(DataRow dr in newSpec.Rows)
                        {
                            DataRow xdr = newSpecDoc.NewRow();
                            xdr[1] = dr[0];
                            xdr[0] = dtDoc.Rows[0][0];
                            newSpecDoc.Rows.Add(xdr);
                        }

                        int[] idSpec = new int[dtSpecDoc.Rows.Count];
                        for(int i = 0; i < idSpec.Length; i++)
                        {
                            idSpec[i] = Convert.ToInt32(dtSpecDoc.Rows[i][1]);
                        }
                        int[] idSpecNew = new int[newSpec.Rows.Count];
                        for (int i = 0; i < idSpecNew.Length; i++)
                        {
                            idSpecNew[i] = Convert.ToInt32(newSpec.Rows[i][0]);
                        }

                        foreach(int id in idSpec)
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
                                sSql = $"insert into \"DOCTOR-SPECIALTY_TABLE\" (id_doctor, id_specialty) values({dtDoc.Rows[0][0]}, {id}) ";
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
                        //        sSql = $"insert into \"DOCTOR-SPECIALTY_TABLE\" (id_doctor, id_specialty) values({dtDoc.Rows[0][0]}, {row[0]}) ";
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
                        //        sSql = $"insert into \"DOCTOR-SPECIALTY_TABLE\" (id_doctor, id_specialty) values({dtDoc.Rows[0][0]}, {newSpec.Rows[i][0]}) ";
                        //        myDB.iExeecuteNonQuery(sSql);
                        //    }
                        //}
                        
                        sSql = $"update \"DOCTOR_TABLE\" set last_name = {fio[0]}, first_name = {fio[1]}, PATRONYMIC = {fio[2]}, WORK_EXPERIENCE = {workExp} where id_doctor = {dtDoc.Rows[0][0]}) ";
                        myDB.iExeecuteNonQuery(sSql);
                    }
                    break;
                case 1:
                    break;
            }
            Show();
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
            
            switch (numTable)
            {
                case 0:
                    sSql = $"select * from doctor_table where id_doctor = {id}";
                    break;
                case 1:
                    break;
            }

            dtDoc = myDB.iExecuteReader(sSql);
            CreateTable();
        }
    }
}
