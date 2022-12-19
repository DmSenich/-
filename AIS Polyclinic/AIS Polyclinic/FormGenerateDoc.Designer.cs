namespace AIS_Polyclinic
{
    partial class FormGenerateDoc
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
            this.bListingDoctors = new System.Windows.Forms.Button();
            this.bCountVisiting = new System.Windows.Forms.Button();
            this.bCountDisease = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bListingDoctors
            // 
            this.bListingDoctors.Location = new System.Drawing.Point(63, 56);
            this.bListingDoctors.Name = "bListingDoctors";
            this.bListingDoctors.Size = new System.Drawing.Size(137, 54);
            this.bListingDoctors.TabIndex = 0;
            this.bListingDoctors.Text = "Перечень специалистов";
            this.bListingDoctors.UseVisualStyleBackColor = true;
            this.bListingDoctors.Click += new System.EventHandler(this.bListingDoctors_Click);
            // 
            // bCountVisiting
            // 
            this.bCountVisiting.Location = new System.Drawing.Point(245, 56);
            this.bCountVisiting.Name = "bCountVisiting";
            this.bCountVisiting.Size = new System.Drawing.Size(137, 54);
            this.bCountVisiting.TabIndex = 1;
            this.bCountVisiting.Text = "Количество визитов";
            this.bCountVisiting.UseVisualStyleBackColor = true;
            this.bCountVisiting.Click += new System.EventHandler(this.bCountVisiting_Click);
            // 
            // bCountDisease
            // 
            this.bCountDisease.Location = new System.Drawing.Point(431, 56);
            this.bCountDisease.Name = "bCountDisease";
            this.bCountDisease.Size = new System.Drawing.Size(168, 54);
            this.bCountDisease.TabIndex = 2;
            this.bCountDisease.Text = "Количество случаев заболевания";
            this.bCountDisease.UseVisualStyleBackColor = true;
            this.bCountDisease.Click += new System.EventHandler(this.bCountDisease_Click);
            // 
            // FormGenerateDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 168);
            this.Controls.Add(this.bCountDisease);
            this.Controls.Add(this.bCountVisiting);
            this.Controls.Add(this.bListingDoctors);
            this.Name = "FormGenerateDoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор документа";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bListingDoctors;
        private System.Windows.Forms.Button bCountVisiting;
        private System.Windows.Forms.Button bCountDisease;
    }
}