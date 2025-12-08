namespace Security_department.Forms
{
    partial class SecurityPatrolForm
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
            this.dataGridViewPatrols = new System.Windows.Forms.DataGridView();
            this.txtCrewNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCommanderName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCallReason = new System.Windows.Forms.TextBox();
            this.dtpDepartureDateTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStolenItemName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStolenItemValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDocumentNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIssuingAuthority = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDateOfIssue = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatrols)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPatrols
            // 
            this.dataGridViewPatrols.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatrols.Location = new System.Drawing.Point(16, 15);
            this.dataGridViewPatrols.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewPatrols.Name = "dataGridViewPatrols";
            this.dataGridViewPatrols.RowHeadersWidth = 51;
            this.dataGridViewPatrols.Size = new System.Drawing.Size(424, 524);
            this.dataGridViewPatrols.TabIndex = 0;
            // 
            // txtCrewNumber
            // 
            this.txtCrewNumber.Location = new System.Drawing.Point(611, 26);
            this.txtCrewNumber.Name = "txtCrewNumber";
            this.txtCrewNumber.Size = new System.Drawing.Size(100, 22);
            this.txtCrewNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номер экипажа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя командира";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCommanderName
            // 
            this.txtCommanderName.Location = new System.Drawing.Point(611, 69);
            this.txtCommanderName.Name = "txtCommanderName";
            this.txtCommanderName.Size = new System.Drawing.Size(100, 22);
            this.txtCommanderName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Причина вызова";
            // 
            // txtCallReason
            // 
            this.txtCallReason.Location = new System.Drawing.Point(611, 112);
            this.txtCallReason.Name = "txtCallReason";
            this.txtCallReason.Size = new System.Drawing.Size(100, 22);
            this.txtCallReason.TabIndex = 5;
            // 
            // dtpDepartureDateTime
            // 
            this.dtpDepartureDateTime.Location = new System.Drawing.Point(638, 158);
            this.dtpDepartureDateTime.Name = "dtpDepartureDateTime";
            this.dtpDepartureDateTime.Size = new System.Drawing.Size(200, 22);
            this.dtpDepartureDateTime.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата и время выезда";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(487, 219);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(121, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Украденная вещь";
            // 
            // txtStolenItemName
            // 
            this.txtStolenItemName.Location = new System.Drawing.Point(611, 213);
            this.txtStolenItemName.Name = "txtStolenItemName";
            this.txtStolenItemName.Size = new System.Drawing.Size(100, 22);
            this.txtStolenItemName.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(487, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Количество вещей";
            // 
            // txtStolenItemValue
            // 
            this.txtStolenItemValue.Location = new System.Drawing.Point(611, 251);
            this.txtStolenItemValue.Name = "txtStolenItemValue";
            this.txtStolenItemValue.Size = new System.Drawing.Size(100, 22);
            this.txtStolenItemValue.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(487, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Номер документа";
            // 
            // txtDocumentNumber
            // 
            this.txtDocumentNumber.Location = new System.Drawing.Point(681, 315);
            this.txtDocumentNumber.Name = "txtDocumentNumber";
            this.txtDocumentNumber.Size = new System.Drawing.Size(100, 22);
            this.txtDocumentNumber.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(487, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Орган выдавший документ";
            // 
            // txtIssuingAuthority
            // 
            this.txtIssuingAuthority.Location = new System.Drawing.Point(681, 340);
            this.txtIssuingAuthority.Name = "txtIssuingAuthority";
            this.txtIssuingAuthority.Size = new System.Drawing.Size(100, 22);
            this.txtIssuingAuthority.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(487, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Дата выдачи";
            // 
            // dtpDateOfIssue
            // 
            this.dtpDateOfIssue.Location = new System.Drawing.Point(584, 366);
            this.dtpDateOfIssue.Name = "dtpDateOfIssue";
            this.dtpDateOfIssue.Size = new System.Drawing.Size(200, 22);
            this.dtpDateOfIssue.TabIndex = 19;
            // 
            // SecurityPatrolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dtpDateOfIssue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIssuingAuthority);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDocumentNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStolenItemValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStolenItemName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDepartureDateTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCallReason);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCommanderName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCrewNumber);
            this.Controls.Add(this.dataGridViewPatrols);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SecurityPatrolForm";
            this.Text = "SecurityPatrol";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatrols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPatrols;
        private System.Windows.Forms.TextBox txtCrewNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCommanderName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCallReason;
        private System.Windows.Forms.DateTimePicker dtpDepartureDateTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStolenItemName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStolenItemValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDocumentNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIssuingAuthority;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDateOfIssue;
    }
}