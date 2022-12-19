namespace AIS_Polyclinic
{
    partial class FormCountDiseases
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
            this.label1 = new System.Windows.Forms.Label();
            this.cCategories = new System.Windows.Forms.ComboBox();
            this.buCreateDocument = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Категория:";
            // 
            // cCategories
            // 
            this.cCategories.FormattingEnabled = true;
            this.cCategories.Location = new System.Drawing.Point(129, 44);
            this.cCategories.Name = "cCategories";
            this.cCategories.Size = new System.Drawing.Size(199, 24);
            this.cCategories.TabIndex = 2;
            // 
            // buCreateDocument
            // 
            this.buCreateDocument.Location = new System.Drawing.Point(143, 149);
            this.buCreateDocument.Name = "buCreateDocument";
            this.buCreateDocument.Size = new System.Drawing.Size(123, 56);
            this.buCreateDocument.TabIndex = 4;
            this.buCreateDocument.Text = "Создать документ";
            this.buCreateDocument.UseVisualStyleBackColor = true;
            this.buCreateDocument.Click += new System.EventHandler(this.buCreateDocument_Click);
            // 
            // FormCountDiseases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 241);
            this.Controls.Add(this.buCreateDocument);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cCategories);
            this.Name = "FormCountDiseases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет о заболевании";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cCategories;
        private System.Windows.Forms.Button buCreateDocument;
    }
}