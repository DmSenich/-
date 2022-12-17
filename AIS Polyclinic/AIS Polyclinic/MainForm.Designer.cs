namespace AIS_Polyclinic
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.bAddDoctor = new System.Windows.Forms.Button();
            this.bCreateDoc = new System.Windows.Forms.Button();
            this.bAddPatient = new System.Windows.Forms.Button();
            this.bListDoctor = new System.Windows.Forms.Button();
            this.bListPatient = new System.Windows.Forms.Button();
            this.bSwitchVisitings = new System.Windows.Forms.Button();
            this.bAdminUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bAddDoctor
            // 
            this.bAddDoctor.Location = new System.Drawing.Point(191, 16);
            this.bAddDoctor.Name = "bAddDoctor";
            this.bAddDoctor.Size = new System.Drawing.Size(134, 58);
            this.bAddDoctor.TabIndex = 0;
            this.bAddDoctor.Text = "Добавить врача";
            this.bAddDoctor.UseVisualStyleBackColor = true;
            this.bAddDoctor.Click += new System.EventHandler(this.bAddDoctor_Click);
            // 
            // bCreateDoc
            // 
            this.bCreateDoc.Location = new System.Drawing.Point(29, 17);
            this.bCreateDoc.Name = "bCreateDoc";
            this.bCreateDoc.Size = new System.Drawing.Size(130, 57);
            this.bCreateDoc.TabIndex = 2;
            this.bCreateDoc.Text = "Сгенерировать документы";
            this.bCreateDoc.UseVisualStyleBackColor = true;
            this.bCreateDoc.Click += new System.EventHandler(this.bCreateDoc_Click);
            // 
            // bAddPatient
            // 
            this.bAddPatient.Location = new System.Drawing.Point(348, 16);
            this.bAddPatient.Name = "bAddPatient";
            this.bAddPatient.Size = new System.Drawing.Size(157, 58);
            this.bAddPatient.TabIndex = 3;
            this.bAddPatient.Text = "Добавить пациента";
            this.bAddPatient.UseVisualStyleBackColor = true;
            this.bAddPatient.Click += new System.EventHandler(this.bAddPatient_Click);
            // 
            // bListDoctor
            // 
            this.bListDoctor.Location = new System.Drawing.Point(191, 95);
            this.bListDoctor.Name = "bListDoctor";
            this.bListDoctor.Size = new System.Drawing.Size(134, 58);
            this.bListDoctor.TabIndex = 5;
            this.bListDoctor.Text = "Список врачей";
            this.bListDoctor.UseVisualStyleBackColor = true;
            this.bListDoctor.Click += new System.EventHandler(this.bListDoctor_Click);
            // 
            // bListPatient
            // 
            this.bListPatient.Location = new System.Drawing.Point(348, 95);
            this.bListPatient.Name = "bListPatient";
            this.bListPatient.Size = new System.Drawing.Size(157, 58);
            this.bListPatient.TabIndex = 6;
            this.bListPatient.Text = "Список пациентов";
            this.bListPatient.UseVisualStyleBackColor = true;
            this.bListPatient.Click += new System.EventHandler(this.bListPatient_Click);
            // 
            // bSwitchVisitings
            // 
            this.bSwitchVisitings.Location = new System.Drawing.Point(29, 95);
            this.bSwitchVisitings.Name = "bSwitchVisitings";
            this.bSwitchVisitings.Size = new System.Drawing.Size(130, 55);
            this.bSwitchVisitings.TabIndex = 9;
            this.bSwitchVisitings.Text = "Визиты и диагнозы";
            this.bSwitchVisitings.UseVisualStyleBackColor = true;
            this.bSwitchVisitings.Click += new System.EventHandler(this.bSwitchVisitings_Click);
            // 
            // bAdminUp
            // 
            this.bAdminUp.Location = new System.Drawing.Point(313, 170);
            this.bAdminUp.Name = "bAdminUp";
            this.bAdminUp.Size = new System.Drawing.Size(192, 40);
            this.bAdminUp.TabIndex = 10;
            this.bAdminUp.Text = "Администрирование";
            this.bAdminUp.UseVisualStyleBackColor = true;
            this.bAdminUp.Click += new System.EventHandler(this.bAdminUp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 230);
            this.Controls.Add(this.bAdminUp);
            this.Controls.Add(this.bSwitchVisitings);
            this.Controls.Add(this.bListPatient);
            this.Controls.Add(this.bListDoctor);
            this.Controls.Add(this.bAddPatient);
            this.Controls.Add(this.bCreateDoc);
            this.Controls.Add(this.bAddDoctor);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAddDoctor;
        private System.Windows.Forms.Button bCreateDoc;
        private System.Windows.Forms.Button bAddPatient;
        private System.Windows.Forms.Button bListDoctor;
        private System.Windows.Forms.Button bListPatient;
        private System.Windows.Forms.Button bSwitchVisitings;
        private System.Windows.Forms.Button bAdminUp;
    }
}

