namespace AIS_Polyclinic
{
    partial class FormForAdm
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
            this.bAddCategory = new System.Windows.Forms.Button();
            this.cCategory = new System.Windows.Forms.ComboBox();
            this.bDeleteCategory = new System.Windows.Forms.Button();
            this.dataPerson = new System.Windows.Forms.DataGridView();
            this.radioBDoctor = new System.Windows.Forms.RadioButton();
            this.radioBPatient = new System.Windows.Forms.RadioButton();
            this.bDeletePerson = new System.Windows.Forms.Button();
            this.bDeleteSpec = new System.Windows.Forms.Button();
            this.cSpecialty = new System.Windows.Forms.ComboBox();
            this.bAddSpec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // bAddCategory
            // 
            this.bAddCategory.Location = new System.Drawing.Point(12, 26);
            this.bAddCategory.Name = "bAddCategory";
            this.bAddCategory.Size = new System.Drawing.Size(162, 58);
            this.bAddCategory.TabIndex = 0;
            this.bAddCategory.Text = "Добавить категорию заболеваний";
            this.bAddCategory.UseVisualStyleBackColor = true;
            this.bAddCategory.Click += new System.EventHandler(this.bAddCategory_Click);
            // 
            // cCategory
            // 
            this.cCategory.FormattingEnabled = true;
            this.cCategory.Location = new System.Drawing.Point(205, 26);
            this.cCategory.Name = "cCategory";
            this.cCategory.Size = new System.Drawing.Size(163, 24);
            this.cCategory.TabIndex = 1;
            // 
            // bDeleteCategory
            // 
            this.bDeleteCategory.Location = new System.Drawing.Point(12, 101);
            this.bDeleteCategory.Name = "bDeleteCategory";
            this.bDeleteCategory.Size = new System.Drawing.Size(162, 58);
            this.bDeleteCategory.TabIndex = 2;
            this.bDeleteCategory.Text = "Удалить категорию заболеваний";
            this.bDeleteCategory.UseVisualStyleBackColor = true;
            this.bDeleteCategory.Click += new System.EventHandler(this.bDeleteCategory_Click);
            // 
            // dataPerson
            // 
            this.dataPerson.AllowUserToAddRows = false;
            this.dataPerson.AllowUserToDeleteRows = false;
            this.dataPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPerson.Location = new System.Drawing.Point(389, 59);
            this.dataPerson.Name = "dataPerson";
            this.dataPerson.ReadOnly = true;
            this.dataPerson.RowHeadersWidth = 51;
            this.dataPerson.RowTemplate.Height = 24;
            this.dataPerson.Size = new System.Drawing.Size(399, 297);
            this.dataPerson.TabIndex = 3;
            // 
            // radioBDoctor
            // 
            this.radioBDoctor.AutoSize = true;
            this.radioBDoctor.Checked = true;
            this.radioBDoctor.Location = new System.Drawing.Point(433, 27);
            this.radioBDoctor.Name = "radioBDoctor";
            this.radioBDoctor.Size = new System.Drawing.Size(126, 20);
            this.radioBDoctor.TabIndex = 4;
            this.radioBDoctor.TabStop = true;
            this.radioBDoctor.Text = "Список врачей";
            this.radioBDoctor.UseVisualStyleBackColor = true;
            this.radioBDoctor.CheckedChanged += new System.EventHandler(this.radioBDoctor_CheckedChanged);
            // 
            // radioBPatient
            // 
            this.radioBPatient.AutoSize = true;
            this.radioBPatient.Location = new System.Drawing.Point(609, 27);
            this.radioBPatient.Name = "radioBPatient";
            this.radioBPatient.Size = new System.Drawing.Size(149, 20);
            this.radioBPatient.TabIndex = 5;
            this.radioBPatient.Text = "Список пациентов";
            this.radioBPatient.UseVisualStyleBackColor = true;
            this.radioBPatient.CheckedChanged += new System.EventHandler(this.radioBPatient_CheckedChanged);
            // 
            // bDeletePerson
            // 
            this.bDeletePerson.Location = new System.Drawing.Point(626, 380);
            this.bDeletePerson.Name = "bDeletePerson";
            this.bDeletePerson.Size = new System.Drawing.Size(162, 58);
            this.bDeletePerson.TabIndex = 6;
            this.bDeletePerson.Text = "Удалить человека из списка";
            this.bDeletePerson.UseVisualStyleBackColor = true;
            this.bDeletePerson.Click += new System.EventHandler(this.bDeletePerson_Click);
            // 
            // bDeleteSpec
            // 
            this.bDeleteSpec.Location = new System.Drawing.Point(12, 275);
            this.bDeleteSpec.Name = "bDeleteSpec";
            this.bDeleteSpec.Size = new System.Drawing.Size(162, 58);
            this.bDeleteSpec.TabIndex = 9;
            this.bDeleteSpec.Text = "Удалить специализацию";
            this.bDeleteSpec.UseVisualStyleBackColor = true;
            this.bDeleteSpec.Click += new System.EventHandler(this.bDeleteSpec_Click);
            // 
            // cSpecialty
            // 
            this.cSpecialty.FormattingEnabled = true;
            this.cSpecialty.Location = new System.Drawing.Point(205, 200);
            this.cSpecialty.Name = "cSpecialty";
            this.cSpecialty.Size = new System.Drawing.Size(163, 24);
            this.cSpecialty.TabIndex = 8;
            // 
            // bAddSpec
            // 
            this.bAddSpec.Location = new System.Drawing.Point(12, 200);
            this.bAddSpec.Name = "bAddSpec";
            this.bAddSpec.Size = new System.Drawing.Size(162, 58);
            this.bAddSpec.TabIndex = 7;
            this.bAddSpec.Text = "Добавить специализацию";
            this.bAddSpec.UseVisualStyleBackColor = true;
            this.bAddSpec.Click += new System.EventHandler(this.bAddSpec_Click);
            // 
            // FormForAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bDeleteSpec);
            this.Controls.Add(this.cSpecialty);
            this.Controls.Add(this.bAddSpec);
            this.Controls.Add(this.bDeletePerson);
            this.Controls.Add(this.radioBPatient);
            this.Controls.Add(this.radioBDoctor);
            this.Controls.Add(this.dataPerson);
            this.Controls.Add(this.bDeleteCategory);
            this.Controls.Add(this.cCategory);
            this.Controls.Add(this.bAddCategory);
            this.Name = "FormForAdm";
            this.Text = "Изменение структуры";
            ((System.ComponentModel.ISupportInitialize)(this.dataPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAddCategory;
        private System.Windows.Forms.ComboBox cCategory;
        private System.Windows.Forms.Button bDeleteCategory;
        private System.Windows.Forms.DataGridView dataPerson;
        private System.Windows.Forms.RadioButton radioBDoctor;
        private System.Windows.Forms.RadioButton radioBPatient;
        private System.Windows.Forms.Button bDeletePerson;
        private System.Windows.Forms.Button bDeleteSpec;
        private System.Windows.Forms.ComboBox cSpecialty;
        private System.Windows.Forms.Button bAddSpec;
    }
}