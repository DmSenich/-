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
            this.SuspendLayout();
            // 
            // bAddDoctor
            // 
            this.bAddDoctor.Location = new System.Drawing.Point(493, 74);
            this.bAddDoctor.Name = "bAddDoctor";
            this.bAddDoctor.Size = new System.Drawing.Size(129, 58);
            this.bAddDoctor.TabIndex = 0;
            this.bAddDoctor.Text = "Добавить врача";
            this.bAddDoctor.UseVisualStyleBackColor = true;
            this.bAddDoctor.Click += new System.EventHandler(this.bAddDoctor_Click);
            // 
            // bAddVisiting
            // 
            this.bAddVisiting.Location = new System.Drawing.Point(89, 74);
            this.bAddVisiting.Name = "bAddVisiting";
            this.bAddVisiting.Size = new System.Drawing.Size(109, 58);
            this.bAddVisiting.TabIndex = 1;
            this.bAddVisiting.Text = "Назначить встречу";
            this.bAddVisiting.UseVisualStyleBackColor = true;
            this.bAddVisiting.Click += new System.EventHandler(this.bAddVisiting_Click);
            // 
            // bCreateDoc
            // 
            this.bCreateDoc.Location = new System.Drawing.Point(282, 74);
            this.bCreateDoc.Name = "bCreateDoc";
            this.bCreateDoc.Size = new System.Drawing.Size(130, 57);
            this.bCreateDoc.TabIndex = 2;
            this.bCreateDoc.Text = "Сгенерировать документы";
            this.bCreateDoc.UseVisualStyleBackColor = true;
            this.bCreateDoc.Click += new System.EventHandler(this.bCreateDoc_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 210);
            this.Controls.Add(this.bCreateDoc);
            this.Controls.Add(this.bAddVisiting);
            this.Controls.Add(this.bAddDoctor);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAddDoctor;
        private System.Windows.Forms.Button bAddVisiting;
        private System.Windows.Forms.Button bCreateDoc;
    }
}

