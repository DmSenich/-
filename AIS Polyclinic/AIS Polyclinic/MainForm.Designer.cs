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
            this.bAddVisiting = new System.Windows.Forms.Button();
            this.bCreateDoc = new System.Windows.Forms.Button();
            this.bAddPatient = new System.Windows.Forms.Button();
            this.bListVisiting = new System.Windows.Forms.Button();
            this.bListDoctor = new System.Windows.Forms.Button();
            this.bListPatient = new System.Windows.Forms.Button();
            this.bDisease = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bSwitchVisitings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bAddDoctor
            // 
            this.bAddDoctor.Location = new System.Drawing.Point(336, 56);
            this.bAddDoctor.Name = "bAddDoctor";
            this.bAddDoctor.Size = new System.Drawing.Size(134, 58);
            this.bAddDoctor.TabIndex = 0;
            this.bAddDoctor.Text = "Добавить врача";
            this.bAddDoctor.UseVisualStyleBackColor = true;
            this.bAddDoctor.Click += new System.EventHandler(this.bAddDoctor_Click);
            // 
            // bAddVisiting
            // 
            this.bAddVisiting.Location = new System.Drawing.Point(27, 12);
            this.bAddVisiting.Name = "bAddVisiting";
            this.bAddVisiting.Size = new System.Drawing.Size(109, 58);
            this.bAddVisiting.TabIndex = 1;
            this.bAddVisiting.Text = "Назначить встречу";
            this.bAddVisiting.UseVisualStyleBackColor = true;
            this.bAddVisiting.Click += new System.EventHandler(this.bAddVisiting_Click);
            // 
            // bCreateDoc
            // 
            this.bCreateDoc.Location = new System.Drawing.Point(174, 57);
            this.bCreateDoc.Name = "bCreateDoc";
            this.bCreateDoc.Size = new System.Drawing.Size(130, 57);
            this.bCreateDoc.TabIndex = 2;
            this.bCreateDoc.Text = "Сгенерировать документы";
            this.bCreateDoc.UseVisualStyleBackColor = true;
            this.bCreateDoc.Click += new System.EventHandler(this.bCreateDoc_Click);
            // 
            // bAddPatient
            // 
            this.bAddPatient.Location = new System.Drawing.Point(493, 56);
            this.bAddPatient.Name = "bAddPatient";
            this.bAddPatient.Size = new System.Drawing.Size(157, 58);
            this.bAddPatient.TabIndex = 3;
            this.bAddPatient.Text = "Добавить пациента";
            this.bAddPatient.UseVisualStyleBackColor = true;
            this.bAddPatient.Click += new System.EventHandler(this.bAddPatient_Click);
            // 
            // bListVisiting
            // 
            this.bListVisiting.Location = new System.Drawing.Point(27, 165);
            this.bListVisiting.Name = "bListVisiting";
            this.bListVisiting.Size = new System.Drawing.Size(109, 58);
            this.bListVisiting.TabIndex = 4;
            this.bListVisiting.Text = "Список встреч";
            this.bListVisiting.UseVisualStyleBackColor = true;
            this.bListVisiting.Click += new System.EventHandler(this.bListVisiting_Click);
            // 
            // bListDoctor
            // 
            this.bListDoctor.Location = new System.Drawing.Point(336, 135);
            this.bListDoctor.Name = "bListDoctor";
            this.bListDoctor.Size = new System.Drawing.Size(134, 58);
            this.bListDoctor.TabIndex = 5;
            this.bListDoctor.Text = "Список врачей";
            this.bListDoctor.UseVisualStyleBackColor = true;
            this.bListDoctor.Click += new System.EventHandler(this.bListDoctor_Click);
            // 
            // bListPatient
            // 
            this.bListPatient.Location = new System.Drawing.Point(493, 135);
            this.bListPatient.Name = "bListPatient";
            this.bListPatient.Size = new System.Drawing.Size(157, 58);
            this.bListPatient.TabIndex = 6;
            this.bListPatient.Text = "Список пациентов";
            this.bListPatient.UseVisualStyleBackColor = true;
            this.bListPatient.Click += new System.EventHandler(this.bListPatient_Click);
            // 
            // bDisease
            // 
            this.bDisease.Location = new System.Drawing.Point(27, 91);
            this.bDisease.Name = "bDisease";
            this.bDisease.Size = new System.Drawing.Size(109, 58);
            this.bDisease.TabIndex = 7;
            this.bDisease.Text = "Поставить диагноз";
            this.bDisease.UseVisualStyleBackColor = true;
            this.bDisease.Click += new System.EventHandler(this.bDisease_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bSwitchVisitings
            // 
            this.bSwitchVisitings.Location = new System.Drawing.Point(174, 135);
            this.bSwitchVisitings.Name = "bSwitchVisitings";
            this.bSwitchVisitings.Size = new System.Drawing.Size(130, 55);
            this.bSwitchVisitings.TabIndex = 9;
            this.bSwitchVisitings.Text = "Визиты и диагнозы";
            this.bSwitchVisitings.UseVisualStyleBackColor = true;
            this.bSwitchVisitings.Click += new System.EventHandler(this.bSwitchVisitings_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 262);
            this.Controls.Add(this.bSwitchVisitings);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bDisease);
            this.Controls.Add(this.bListPatient);
            this.Controls.Add(this.bListDoctor);
            this.Controls.Add(this.bListVisiting);
            this.Controls.Add(this.bAddPatient);
            this.Controls.Add(this.bCreateDoc);
            this.Controls.Add(this.bAddVisiting);
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
        private System.Windows.Forms.Button bAddVisiting;
        private System.Windows.Forms.Button bCreateDoc;
        private System.Windows.Forms.Button bAddPatient;
        private System.Windows.Forms.Button bListVisiting;
        private System.Windows.Forms.Button bListDoctor;
        private System.Windows.Forms.Button bListPatient;
        private System.Windows.Forms.Button bDisease;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bSwitchVisitings;
    }
}

