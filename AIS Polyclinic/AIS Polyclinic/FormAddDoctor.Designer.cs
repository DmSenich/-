namespace AIS_Polyclinic
{
    partial class FormAddDoctor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lLastName = new System.Windows.Forms.Label();
            this.lFirstName = new System.Windows.Forms.Label();
            this.lPatronymic = new System.Windows.Forms.Label();
            this.lWorkExperience = new System.Windows.Forms.Label();
            this.tLastName = new System.Windows.Forms.TextBox();
            this.tFirstName = new System.Windows.Forms.TextBox();
            this.tPatronymic = new System.Windows.Forms.TextBox();
            this.nWorkExperience = new System.Windows.Forms.NumericUpDown();
            this.pPhoto = new System.Windows.Forms.PictureBox();
            this.bAddPhoto = new System.Windows.Forms.Button();
            this.bOk = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.dataSpecialty = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nWorkExperience)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSpecialty)).BeginInit();
            this.SuspendLayout();
            // 
            // lLastName
            // 
            this.lLastName.AutoSize = true;
            this.lLastName.Location = new System.Drawing.Point(18, 51);
            this.lLastName.Name = "lLastName";
            this.lLastName.Size = new System.Drawing.Size(72, 16);
            this.lLastName.TabIndex = 0;
            this.lLastName.Text = "Фамилия: ";
            // 
            // lFirstName
            // 
            this.lFirstName.AutoSize = true;
            this.lFirstName.Location = new System.Drawing.Point(18, 86);
            this.lFirstName.Name = "lFirstName";
            this.lFirstName.Size = new System.Drawing.Size(39, 16);
            this.lFirstName.TabIndex = 1;
            this.lFirstName.Text = "Имя: ";
            // 
            // lPatronymic
            // 
            this.lPatronymic.AutoSize = true;
            this.lPatronymic.Location = new System.Drawing.Point(18, 126);
            this.lPatronymic.Name = "lPatronymic";
            this.lPatronymic.Size = new System.Drawing.Size(76, 16);
            this.lPatronymic.TabIndex = 2;
            this.lPatronymic.Text = "Отчество: ";
            // 
            // lWorkExperience
            // 
            this.lWorkExperience.AutoSize = true;
            this.lWorkExperience.Location = new System.Drawing.Point(18, 167);
            this.lWorkExperience.Name = "lWorkExperience";
            this.lWorkExperience.Size = new System.Drawing.Size(94, 16);
            this.lWorkExperience.TabIndex = 3;
            this.lWorkExperience.Text = "Стаж работы:";
            // 
            // tLastName
            // 
            this.tLastName.Location = new System.Drawing.Point(130, 45);
            this.tLastName.Name = "tLastName";
            this.tLastName.Size = new System.Drawing.Size(241, 22);
            this.tLastName.TabIndex = 5;
            // 
            // tFirstName
            // 
            this.tFirstName.Location = new System.Drawing.Point(130, 86);
            this.tFirstName.Name = "tFirstName";
            this.tFirstName.Size = new System.Drawing.Size(241, 22);
            this.tFirstName.TabIndex = 6;
            // 
            // tPatronymic
            // 
            this.tPatronymic.Location = new System.Drawing.Point(130, 126);
            this.tPatronymic.Name = "tPatronymic";
            this.tPatronymic.Size = new System.Drawing.Size(241, 22);
            this.tPatronymic.TabIndex = 7;
            // 
            // nWorkExperience
            // 
            this.nWorkExperience.Location = new System.Drawing.Point(130, 165);
            this.nWorkExperience.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.nWorkExperience.Name = "nWorkExperience";
            this.nWorkExperience.Size = new System.Drawing.Size(120, 22);
            this.nWorkExperience.TabIndex = 8;
            // 
            // pPhoto
            // 
            this.pPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPhoto.Location = new System.Drawing.Point(468, 53);
            this.pPhoto.Name = "pPhoto";
            this.pPhoto.Size = new System.Drawing.Size(300, 300);
            this.pPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pPhoto.TabIndex = 9;
            this.pPhoto.TabStop = false;
            // 
            // bAddPhoto
            // 
            this.bAddPhoto.Location = new System.Drawing.Point(468, 391);
            this.bAddPhoto.Name = "bAddPhoto";
            this.bAddPhoto.Size = new System.Drawing.Size(164, 30);
            this.bAddPhoto.TabIndex = 10;
            this.bAddPhoto.Text = "Добавить фото";
            this.bAddPhoto.UseVisualStyleBackColor = true;
            this.bAddPhoto.Click += new System.EventHandler(this.bAddPhoto_Click);
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(643, 389);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(125, 32);
            this.bOk.TabIndex = 11;
            this.bOk.Text = "OK";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(66, 389);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(125, 32);
            this.bCancel.TabIndex = 12;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // dataSpecialty
            // 
            this.dataSpecialty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSpecialty.Location = new System.Drawing.Point(130, 214);
            this.dataSpecialty.Name = "dataSpecialty";
            this.dataSpecialty.RowHeadersWidth = 51;
            this.dataSpecialty.RowTemplate.Height = 24;
            this.dataSpecialty.Size = new System.Drawing.Size(317, 139);
            this.dataSpecialty.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Специальности:";
            // 
            // FormAddDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataSpecialty);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.bAddPhoto);
            this.Controls.Add(this.pPhoto);
            this.Controls.Add(this.nWorkExperience);
            this.Controls.Add(this.tPatronymic);
            this.Controls.Add(this.tFirstName);
            this.Controls.Add(this.tLastName);
            this.Controls.Add(this.lWorkExperience);
            this.Controls.Add(this.lPatronymic);
            this.Controls.Add(this.lFirstName);
            this.Controls.Add(this.lLastName);
            this.Name = "FormAddDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить доктора";
            ((System.ComponentModel.ISupportInitialize)(this.nWorkExperience)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSpecialty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lLastName;
        private System.Windows.Forms.Label lFirstName;
        private System.Windows.Forms.Label lPatronymic;
        private System.Windows.Forms.Label lWorkExperience;
        private System.Windows.Forms.TextBox tLastName;
        private System.Windows.Forms.TextBox tFirstName;
        private System.Windows.Forms.TextBox tPatronymic;
        private System.Windows.Forms.NumericUpDown nWorkExperience;
        private System.Windows.Forms.PictureBox pPhoto;
        private System.Windows.Forms.Button bAddPhoto;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.DataGridView dataSpecialty;
        private System.Windows.Forms.Label label1;
    }
}