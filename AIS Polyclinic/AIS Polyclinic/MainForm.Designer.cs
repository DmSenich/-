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
            this.bCreateDoc = new System.Windows.Forms.Button();
            this.bListDoctor = new System.Windows.Forms.Button();
            this.bListPatient = new System.Windows.Forms.Button();
            this.bSwitchVisitings = new System.Windows.Forms.Button();
            this.bAdminUp = new System.Windows.Forms.Button();
            this.groupPeople = new System.Windows.Forms.GroupBox();
            this.groupAdmin = new System.Windows.Forms.GroupBox();
            this.groupGeneralActive = new System.Windows.Forms.GroupBox();
            this.groupPeople.SuspendLayout();
            this.groupAdmin.SuspendLayout();
            this.groupGeneralActive.SuspendLayout();
            this.SuspendLayout();
            // 
            // bCreateDoc
            // 
            this.bCreateDoc.Location = new System.Drawing.Point(17, 21);
            this.bCreateDoc.Name = "bCreateDoc";
            this.bCreateDoc.Size = new System.Drawing.Size(130, 57);
            this.bCreateDoc.TabIndex = 2;
            this.bCreateDoc.Text = "Сгенерировать документы";
            this.bCreateDoc.UseVisualStyleBackColor = true;
            this.bCreateDoc.Click += new System.EventHandler(this.bCreateDoc_Click);
            // 
            // bListDoctor
            // 
            this.bListDoctor.Location = new System.Drawing.Point(45, 21);
            this.bListDoctor.Name = "bListDoctor";
            this.bListDoctor.Size = new System.Drawing.Size(134, 58);
            this.bListDoctor.TabIndex = 5;
            this.bListDoctor.Text = "Список врачей";
            this.bListDoctor.UseVisualStyleBackColor = true;
            this.bListDoctor.Click += new System.EventHandler(this.bListDoctor_Click);
            // 
            // bListPatient
            // 
            this.bListPatient.Location = new System.Drawing.Point(45, 98);
            this.bListPatient.Name = "bListPatient";
            this.bListPatient.Size = new System.Drawing.Size(134, 58);
            this.bListPatient.TabIndex = 6;
            this.bListPatient.Text = "Список пациентов";
            this.bListPatient.UseVisualStyleBackColor = true;
            this.bListPatient.Click += new System.EventHandler(this.bListPatient_Click);
            // 
            // bSwitchVisitings
            // 
            this.bSwitchVisitings.Location = new System.Drawing.Point(17, 101);
            this.bSwitchVisitings.Name = "bSwitchVisitings";
            this.bSwitchVisitings.Size = new System.Drawing.Size(130, 55);
            this.bSwitchVisitings.TabIndex = 9;
            this.bSwitchVisitings.Text = "Визиты и диагнозы";
            this.bSwitchVisitings.UseVisualStyleBackColor = true;
            this.bSwitchVisitings.Click += new System.EventHandler(this.bSwitchVisitings_Click);
            // 
            // bAdminUp
            // 
            this.bAdminUp.Location = new System.Drawing.Point(2, 64);
            this.bAdminUp.Name = "bAdminUp";
            this.bAdminUp.Size = new System.Drawing.Size(192, 40);
            this.bAdminUp.TabIndex = 10;
            this.bAdminUp.Text = "Администрирование";
            this.bAdminUp.UseVisualStyleBackColor = true;
            this.bAdminUp.Click += new System.EventHandler(this.bAdminUp_Click);
            // 
            // groupPeople
            // 
            this.groupPeople.Controls.Add(this.bListDoctor);
            this.groupPeople.Controls.Add(this.bListPatient);
            this.groupPeople.Location = new System.Drawing.Point(208, 17);
            this.groupPeople.Name = "groupPeople";
            this.groupPeople.Size = new System.Drawing.Size(224, 162);
            this.groupPeople.TabIndex = 11;
            this.groupPeople.TabStop = false;
            this.groupPeople.Text = "Списки по людям";
            // 
            // groupAdmin
            // 
            this.groupAdmin.Controls.Add(this.bAdminUp);
            this.groupAdmin.Location = new System.Drawing.Point(438, 17);
            this.groupAdmin.Name = "groupAdmin";
            this.groupAdmin.Size = new System.Drawing.Size(200, 162);
            this.groupAdmin.TabIndex = 12;
            this.groupAdmin.TabStop = false;
            this.groupAdmin.Text = "Изменение структуры данных";
            // 
            // groupGeneralActive
            // 
            this.groupGeneralActive.Controls.Add(this.bCreateDoc);
            this.groupGeneralActive.Controls.Add(this.bSwitchVisitings);
            this.groupGeneralActive.Location = new System.Drawing.Point(12, 17);
            this.groupGeneralActive.Name = "groupGeneralActive";
            this.groupGeneralActive.Size = new System.Drawing.Size(190, 162);
            this.groupGeneralActive.TabIndex = 7;
            this.groupGeneralActive.TabStop = false;
            this.groupGeneralActive.Text = "Основная активность";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(650, 204);
            this.Controls.Add(this.groupGeneralActive);
            this.Controls.Add(this.groupAdmin);
            this.Controls.Add(this.groupPeople);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.groupPeople.ResumeLayout(false);
            this.groupAdmin.ResumeLayout(false);
            this.groupGeneralActive.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bCreateDoc;
        private System.Windows.Forms.Button bListDoctor;
        private System.Windows.Forms.Button bListPatient;
        private System.Windows.Forms.Button bSwitchVisitings;
        private System.Windows.Forms.Button bAdminUp;
        private System.Windows.Forms.GroupBox groupPeople;
        private System.Windows.Forms.GroupBox groupAdmin;
        private System.Windows.Forms.GroupBox groupGeneralActive;
    }
}

