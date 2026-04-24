namespace Security_department
{
    partial class MainForm
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
            this.btnClients = new System.Windows.Forms.Button();
            this.btnObjects = new System.Windows.Forms.Button();
            this.btnContracts = new System.Windows.Forms.Button();
            this.btnSecurityPatrols = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(50, 80);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(200, 50);
            this.btnClients.TabIndex = 0;
            this.btnClients.Text = "Клиенты";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnObjects
            // 
            this.btnObjects.Location = new System.Drawing.Point(50, 150);
            this.btnObjects.Name = "btnObjects";
            this.btnObjects.Size = new System.Drawing.Size(200, 50);
            this.btnObjects.TabIndex = 1;
            this.btnObjects.Text = "Объекты";
            this.btnObjects.UseVisualStyleBackColor = true;
            this.btnObjects.Click += new System.EventHandler(this.btnObjects_Click);
            // 
            // btnContracts
            // 
            this.btnContracts.Location = new System.Drawing.Point(50, 220);
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.Size = new System.Drawing.Size(200, 50);
            this.btnContracts.TabIndex = 2;
            this.btnContracts.Text = "Договоры";
            this.btnContracts.UseVisualStyleBackColor = true;
            this.btnContracts.Click += new System.EventHandler(this.btnContracts_Click);
            // 
            // btnSecurityPatrols
            // 
            this.btnSecurityPatrols.Location = new System.Drawing.Point(50, 290);
            this.btnSecurityPatrols.Name = "btnSecurityPatrols";
            this.btnSecurityPatrols.Size = new System.Drawing.Size(200, 50);
            this.btnSecurityPatrols.TabIndex = 3;
            this.btnSecurityPatrols.Text = "Патрули";
            this.btnSecurityPatrols.UseVisualStyleBackColor = true;
            this.btnSecurityPatrols.Click += new System.EventHandler(this.btnSecurityPatrols_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(45, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Охранное агенство";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 380);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSecurityPatrols);
            this.Controls.Add(this.btnContracts);
            this.Controls.Add(this.btnObjects);
            this.Controls.Add(this.btnClients);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Охранное агенство";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnObjects;
        private System.Windows.Forms.Button btnContracts;
        private System.Windows.Forms.Button btnSecurityPatrols;
        private System.Windows.Forms.Label label1;
    }
}