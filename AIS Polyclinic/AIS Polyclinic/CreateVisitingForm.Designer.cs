namespace AIS_Polyclinic
{
    partial class CreateVisitingForm
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
            this.bOK = new System.Windows.Forms.Button();
            this.dataDoctor = new System.Windows.Forms.DataGridView();
            this.FIODoctorCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPatient = new System.Windows.Forms.DataGridView();
            this.FIOPatientCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(681, 299);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(95, 40);
            this.bOK.TabIndex = 0;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // dataDoctor
            // 
            this.dataDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDoctor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIODoctorCol});
            this.dataDoctor.Location = new System.Drawing.Point(12, 12);
            this.dataDoctor.Name = "dataDoctor";
            this.dataDoctor.RowHeadersWidth = 51;
            this.dataDoctor.RowTemplate.Height = 24;
            this.dataDoctor.Size = new System.Drawing.Size(380, 186);
            this.dataDoctor.TabIndex = 1;
            // 
            // FIODoctorCol
            // 
            this.FIODoctorCol.HeaderText = "ФИО Врача";
            this.FIODoctorCol.MinimumWidth = 6;
            this.FIODoctorCol.Name = "FIODoctorCol";
            this.FIODoctorCol.Width = 125;
            // 
            // dataPatient
            // 
            this.dataPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIOPatientCol});
            this.dataPatient.Location = new System.Drawing.Point(409, 12);
            this.dataPatient.Name = "dataPatient";
            this.dataPatient.RowHeadersWidth = 51;
            this.dataPatient.RowTemplate.Height = 24;
            this.dataPatient.Size = new System.Drawing.Size(379, 186);
            this.dataPatient.TabIndex = 2;
            // 
            // FIOPatientCol
            // 
            this.FIOPatientCol.HeaderText = "ФИО Пациента";
            this.FIOPatientCol.MinimumWidth = 6;
            this.FIOPatientCol.Name = "FIOPatientCol";
            this.FIOPatientCol.Width = 125;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 218);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(565, 299);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(95, 40);
            this.bCancel.TabIndex = 4;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "На данный день у этого врача назначено визитов: 0";
            // 
            // CreateVisitingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 358);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataPatient);
            this.Controls.Add(this.dataDoctor);
            this.Controls.Add(this.bOK);
            this.Name = "CreateVisitingForm";
            this.Text = "CreateVisitingForm";
            this.Activated += new System.EventHandler(this.CreateVisitingForm_Activated);
            this.Shown += new System.EventHandler(this.CreateVisitingForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.DataGridView dataDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIODoctorCol;
        private System.Windows.Forms.DataGridView dataPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIOPatientCol;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label label1;
    }
}