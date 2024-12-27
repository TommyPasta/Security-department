namespace Security_department.Forms
{
    partial class ObjectForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFloor = new System.Windows.Forms.TextBox();
            this.txtEntranceCode = new System.Windows.Forms.TextBox();
            this.txtHouseType = new System.Windows.Forms.TextBox();
            this.txtTotalFloors = new System.Windows.Forms.TextBox();
            this.txtDoorType = new System.Windows.Forms.TextBox();
            this.txtBalconyType = new System.Windows.Forms.TextBox();
            this.txtApartmentPlan = new System.Windows.Forms.TextBox();
            this.chkHasEntranceCode = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(418, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(673, 26);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(673, 62);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 2;
            // 
            // txtFloor
            // 
            this.txtFloor.Location = new System.Drawing.Point(673, 98);
            this.txtFloor.Name = "txtFloor";
            this.txtFloor.Size = new System.Drawing.Size(100, 20);
            this.txtFloor.TabIndex = 3;
            // 
            // txtEntranceCode
            // 
            this.txtEntranceCode.Location = new System.Drawing.Point(673, 134);
            this.txtEntranceCode.Name = "txtEntranceCode";
            this.txtEntranceCode.Size = new System.Drawing.Size(100, 20);
            this.txtEntranceCode.TabIndex = 4;
            // 
            // txtHouseType
            // 
            this.txtHouseType.Location = new System.Drawing.Point(673, 170);
            this.txtHouseType.Name = "txtHouseType";
            this.txtHouseType.Size = new System.Drawing.Size(100, 20);
            this.txtHouseType.TabIndex = 5;
            // 
            // txtTotalFloors
            // 
            this.txtTotalFloors.Location = new System.Drawing.Point(673, 205);
            this.txtTotalFloors.Name = "txtTotalFloors";
            this.txtTotalFloors.Size = new System.Drawing.Size(100, 20);
            this.txtTotalFloors.TabIndex = 6;
            // 
            // txtDoorType
            // 
            this.txtDoorType.Location = new System.Drawing.Point(673, 239);
            this.txtDoorType.Name = "txtDoorType";
            this.txtDoorType.Size = new System.Drawing.Size(100, 20);
            this.txtDoorType.TabIndex = 7;
            // 
            // txtBalconyType
            // 
            this.txtBalconyType.Location = new System.Drawing.Point(673, 277);
            this.txtBalconyType.Name = "txtBalconyType";
            this.txtBalconyType.Size = new System.Drawing.Size(100, 20);
            this.txtBalconyType.TabIndex = 8;
            // 
            // txtApartmentPlan
            // 
            this.txtApartmentPlan.Location = new System.Drawing.Point(673, 313);
            this.txtApartmentPlan.Name = "txtApartmentPlan";
            this.txtApartmentPlan.Size = new System.Drawing.Size(100, 20);
            this.txtApartmentPlan.TabIndex = 9;
            // 
            // chkHasEntranceCode
            // 
            this.chkHasEntranceCode.AutoSize = true;
            this.chkHasEntranceCode.Location = new System.Drawing.Point(468, 136);
            this.chkHasEntranceCode.Name = "chkHasEntranceCode";
            this.chkHasEntranceCode.Size = new System.Drawing.Size(106, 17);
            this.chkHasEntranceCode.TabIndex = 10;
            this.chkHasEntranceCode.Text = "Кодовый замок";
            this.chkHasEntranceCode.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(536, 402);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(617, 402);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 26;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(698, 402);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(604, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "ID объекта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "План квартиры";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(612, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Тип дома";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(596, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Тип балкона";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Тип входной двери";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(596, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Тип балкона";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(580, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Кодовый замок";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(634, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Этаж";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(629, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Адрес";
            // 
            // ObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chkHasEntranceCode);
            this.Controls.Add(this.txtApartmentPlan);
            this.Controls.Add(this.txtBalconyType);
            this.Controls.Add(this.txtDoorType);
            this.Controls.Add(this.txtTotalFloors);
            this.Controls.Add(this.txtHouseType);
            this.Controls.Add(this.txtEntranceCode);
            this.Controls.Add(this.txtFloor);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ObjectForm";
            this.Text = "ObjectForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFloor;
        private System.Windows.Forms.TextBox txtEntranceCode;
        private System.Windows.Forms.TextBox txtHouseType;
        private System.Windows.Forms.TextBox txtTotalFloors;
        private System.Windows.Forms.TextBox txtDoorType;
        private System.Windows.Forms.TextBox txtBalconyType;
        private System.Windows.Forms.TextBox txtApartmentPlan;
        private System.Windows.Forms.CheckBox chkHasEntranceCode;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}