namespace AIS_Polyclinic
{
    partial class FormAddDisease
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
            this.cCategories = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richDescription = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bOk = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cCategories
            // 
            this.cCategories.FormattingEnabled = true;
            this.cCategories.Location = new System.Drawing.Point(111, 74);
            this.cCategories.Name = "cCategories";
            this.cCategories.Size = new System.Drawing.Size(199, 24);
            this.cCategories.TabIndex = 0;
            this.cCategories.SelectedIndexChanged += new System.EventHandler(this.cCategories_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Категория:";
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(111, 117);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(199, 22);
            this.tName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название:";
            // 
            // richDescription
            // 
            this.richDescription.Location = new System.Drawing.Point(348, 74);
            this.richDescription.Name = "richDescription";
            this.richDescription.Size = new System.Drawing.Size(426, 285);
            this.richDescription.TabIndex = 4;
            this.richDescription.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Описание:";
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(680, 381);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(94, 36);
            this.bOk.TabIndex = 6;
            this.bOk.Text = "ОК";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(30, 381);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(94, 36);
            this.bCancel.TabIndex = 7;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // FormAddDisease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cCategories);
            this.Name = "FormAddDisease";
            this.Text = "Поставить диагноз";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Button bCancel;
    }
}