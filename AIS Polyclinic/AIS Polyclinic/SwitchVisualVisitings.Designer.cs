namespace AIS_Polyclinic
{
    partial class SwitchVisualVisitings
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
            this.bAddVisiting = new System.Windows.Forms.Button();
            this.bAddDisease = new System.Windows.Forms.Button();
            this.bListDisease = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tFindDoc = new System.Windows.Forms.TextBox();
            this.tFindPat = new System.Windows.Forms.TextBox();
            this.cSpecs = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataVisiting = new System.Windows.Forms.DataGridView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.checkSpecs = new System.Windows.Forms.CheckBox();
            this.checkDate = new System.Windows.Forms.CheckBox();
            this.bDeleteVisiting = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataVisiting)).BeginInit();
            this.SuspendLayout();
            // 
            // bAddVisiting
            // 
            this.bAddVisiting.Location = new System.Drawing.Point(343, 276);
            this.bAddVisiting.Name = "bAddVisiting";
            this.bAddVisiting.Size = new System.Drawing.Size(121, 69);
            this.bAddVisiting.TabIndex = 0;
            this.bAddVisiting.Text = "Добавить встречу";
            this.bAddVisiting.UseVisualStyleBackColor = true;
            this.bAddVisiting.Click += new System.EventHandler(this.bAddVisiting_Click);
            // 
            // bAddDisease
            // 
            this.bAddDisease.Location = new System.Drawing.Point(484, 276);
            this.bAddDisease.Name = "bAddDisease";
            this.bAddDisease.Size = new System.Drawing.Size(109, 69);
            this.bAddDisease.TabIndex = 1;
            this.bAddDisease.Text = "Поставить диагноз";
            this.bAddDisease.UseVisualStyleBackColor = true;
            this.bAddDisease.Click += new System.EventHandler(this.bAddDisease_Click);
            // 
            // bListDisease
            // 
            this.bListDisease.Location = new System.Drawing.Point(484, 365);
            this.bListDisease.Name = "bListDisease";
            this.bListDisease.Size = new System.Drawing.Size(107, 69);
            this.bListDisease.TabIndex = 2;
            this.bListDisease.Text = "Посмотреть диагнозы";
            this.bListDisease.UseVisualStyleBackColor = true;
            this.bListDisease.Click += new System.EventHandler(this.bListDisease_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Найти по дате:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Найти/выбрать доктора:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Найти/выбрать пациента:";
            // 
            // tFindDoc
            // 
            this.tFindDoc.Location = new System.Drawing.Point(15, 37);
            this.tFindDoc.Name = "tFindDoc";
            this.tFindDoc.Size = new System.Drawing.Size(164, 22);
            this.tFindDoc.TabIndex = 9;
            this.tFindDoc.TextChanged += new System.EventHandler(this.tFindDoc_TextChanged);
            this.tFindDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tFindDoc_KeyPress);
            // 
            // tFindPat
            // 
            this.tFindPat.Location = new System.Drawing.Point(14, 100);
            this.tFindPat.Name = "tFindPat";
            this.tFindPat.Size = new System.Drawing.Size(164, 22);
            this.tFindPat.TabIndex = 10;
            this.tFindPat.TextChanged += new System.EventHandler(this.tFindPat_TextChanged);
            this.tFindPat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tFindPat_KeyPress);
            // 
            // cSpecs
            // 
            this.cSpecs.FormattingEnabled = true;
            this.cSpecs.Location = new System.Drawing.Point(15, 164);
            this.cSpecs.Name = "cSpecs";
            this.cSpecs.Size = new System.Drawing.Size(197, 24);
            this.cSpecs.TabIndex = 12;
            this.cSpecs.SelectedIndexChanged += new System.EventHandler(this.cSpecs_SelectedIndexChanged);
            this.cSpecs.SelectionChangeCommitted += new System.EventHandler(this.cSpecs_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Найти/выбрать врача по специальности:";
            // 
            // dataVisiting
            // 
            this.dataVisiting.AllowUserToAddRows = false;
            this.dataVisiting.AllowUserToDeleteRows = false;
            this.dataVisiting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVisiting.Location = new System.Drawing.Point(343, 12);
            this.dataVisiting.Name = "dataVisiting";
            this.dataVisiting.ReadOnly = true;
            this.dataVisiting.RowHeadersWidth = 51;
            this.dataVisiting.RowTemplate.Height = 24;
            this.dataVisiting.Size = new System.Drawing.Size(612, 243);
            this.dataVisiting.TabIndex = 14;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(15, 227);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 15;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // checkSpecs
            // 
            this.checkSpecs.AutoSize = true;
            this.checkSpecs.Location = new System.Drawing.Point(293, 136);
            this.checkSpecs.Name = "checkSpecs";
            this.checkSpecs.Size = new System.Drawing.Size(18, 17);
            this.checkSpecs.TabIndex = 17;
            this.checkSpecs.UseVisualStyleBackColor = true;
            this.checkSpecs.CheckedChanged += new System.EventHandler(this.checkSpecs_CheckedChanged);
            // 
            // checkDate
            // 
            this.checkDate.AutoSize = true;
            this.checkDate.Location = new System.Drawing.Point(122, 202);
            this.checkDate.Name = "checkDate";
            this.checkDate.Size = new System.Drawing.Size(18, 17);
            this.checkDate.TabIndex = 18;
            this.checkDate.UseVisualStyleBackColor = true;
            this.checkDate.CheckedChanged += new System.EventHandler(this.checkDate_CheckedChanged);
            // 
            // bDeleteVisiting
            // 
            this.bDeleteVisiting.Location = new System.Drawing.Point(343, 365);
            this.bDeleteVisiting.Name = "bDeleteVisiting";
            this.bDeleteVisiting.Size = new System.Drawing.Size(121, 69);
            this.bDeleteVisiting.TabIndex = 19;
            this.bDeleteVisiting.Text = "Удалить встречу";
            this.bDeleteVisiting.UseVisualStyleBackColor = true;
            this.bDeleteVisiting.Click += new System.EventHandler(this.bDeleteVisiting_Click);
            // 
            // SwitchVisualVisitings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(967, 466);
            this.Controls.Add(this.bDeleteVisiting);
            this.Controls.Add(this.checkDate);
            this.Controls.Add(this.checkSpecs);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dataVisiting);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cSpecs);
            this.Controls.Add(this.tFindPat);
            this.Controls.Add(this.tFindDoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bListDisease);
            this.Controls.Add(this.bAddDisease);
            this.Controls.Add(this.bAddVisiting);
            this.Name = "SwitchVisualVisitings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Визиты и диагнозы";
            ((System.ComponentModel.ISupportInitialize)(this.dataVisiting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAddVisiting;
        private System.Windows.Forms.Button bAddDisease;
        private System.Windows.Forms.Button bListDisease;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tFindDoc;
        private System.Windows.Forms.TextBox tFindPat;
        private System.Windows.Forms.ComboBox cSpecs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataVisiting;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.CheckBox checkSpecs;
        private System.Windows.Forms.CheckBox checkDate;
        private System.Windows.Forms.Button bDeleteVisiting;
    }
}