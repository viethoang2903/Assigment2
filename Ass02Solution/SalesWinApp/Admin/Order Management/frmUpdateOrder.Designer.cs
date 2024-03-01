﻿namespace SalesWinApp.Admin.Order_Management
{
    partial class frmUpdateOrder
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
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMemberEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtOrderDate = new System.Windows.Forms.DateTimePicker();
            this.txtRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.txtShippedDate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(535, 390);
            this.txtDiscount.MaxLength = 15;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(208, 27);
            this.txtDiscount.TabIndex = 86;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(422, 393);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 20);
            this.label12.TabIndex = 85;
            this.label12.Text = "Discount";
            this.label12.Click += new System.EventHandler(this.label12_Click_1);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(535, 339);
            this.txtQuantity.MaxLength = 15;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(208, 27);
            this.txtQuantity.TabIndex = 84;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(422, 342);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 83;
            this.label11.Text = "Quantity";
            this.label11.Click += new System.EventHandler(this.label11_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(422, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 20);
            this.label10.TabIndex = 82;
            this.label10.Text = "Order Date";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(535, 288);
            this.txtUnitPrice.MaxLength = 15;
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(208, 27);
            this.txtUnitPrice.TabIndex = 81;
            this.txtUnitPrice.TextChanged += new System.EventHandler(this.txtUnitPrice_TextChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 80;
            this.label6.Text = "Unit Price";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(535, 238);
            this.txtFreight.MaxLength = 15;
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(208, 27);
            this.txtFreight.TabIndex = 79;
            this.txtFreight.TextChanged += new System.EventHandler(this.txtFreight_TextChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(422, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 78;
            this.label7.Text = "Freight";
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(422, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 77;
            this.label8.Text = "Shipped Date";
            this.label8.Click += new System.EventHandler(this.label8_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(422, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 20);
            this.label9.TabIndex = 76;
            this.label9.Text = "Required Date";
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(166, 316);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(208, 27);
            this.txtProductName.TabIndex = 75;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 74;
            this.label5.Text = "Product Name";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(166, 266);
            this.txtProductID.MaxLength = 30;
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(208, 27);
            this.txtProductID.TabIndex = 73;
            this.txtProductID.TextChanged += new System.EventHandler(this.txtProductID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 72;
            this.label4.Text = "Product ID";
            this.label4.Click += new System.EventHandler(this.label4_Click_2);
            // 
            // txtMemberEmail
            // 
            this.txtMemberEmail.Location = new System.Drawing.Point(166, 216);
            this.txtMemberEmail.Name = "txtMemberEmail";
            this.txtMemberEmail.ReadOnly = true;
            this.txtMemberEmail.Size = new System.Drawing.Size(208, 27);
            this.txtMemberEmail.TabIndex = 71;
            this.txtMemberEmail.TextChanged += new System.EventHandler(this.txtMemberEmail_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 70;
            this.label3.Text = "Member Email";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(166, 167);
            this.txtMemberID.MaxLength = 30;
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(208, 27);
            this.txtMemberID.TabIndex = 69;
            this.txtMemberID.TextChanged += new System.EventHandler(this.txtMemberID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "Member ID";
            this.label2.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(345, 32);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(208, 27);
            this.txtOrderID.TabIndex = 67;
            this.txtOrderID.TextChanged += new System.EventHandler(this.txtOrderID_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 66;
            this.label1.Text = "Order ID";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(433, 455);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 35);
            this.btnClose.TabIndex = 65;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(535, 89);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(208, 27);
            this.txtOrderDate.TabIndex = 87;
            this.txtOrderDate.ValueChanged += new System.EventHandler(this.txtOrderDate_ValueChanged);
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.Location = new System.Drawing.Point(535, 137);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.Size = new System.Drawing.Size(208, 27);
            this.txtRequiredDate.TabIndex = 88;
            this.txtRequiredDate.ValueChanged += new System.EventHandler(this.txtRequiredDate_ValueChanged_1);
            // 
            // txtShippedDate
            // 
            this.txtShippedDate.Location = new System.Drawing.Point(535, 186);
            this.txtShippedDate.Name = "txtShippedDate";
            this.txtShippedDate.Size = new System.Drawing.Size(208, 27);
            this.txtShippedDate.TabIndex = 89;
            this.txtShippedDate.ValueChanged += new System.EventHandler(this.txtShippedDate_ValueChanged_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(235, 455);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 35);
            this.btnUpdate.TabIndex = 90;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmUpdateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtShippedDate);
            this.Controls.Add(this.txtRequiredDate);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMemberEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Name = "frmUpdateOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUpdateOrder_FormClosing);
            this.Load += new System.EventHandler(this.frmUpdateOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtDiscount;
        private Label label12;
        private TextBox txtQuantity;
        private Label label11;
        private Label label10;
        private TextBox txtUnitPrice;
        private Label label6;
        private TextBox txtFreight;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtProductName;
        private Label label5;
        private TextBox txtProductID;
        private Label label4;
        private TextBox txtMemberEmail;
        private Label label3;
        private TextBox txtMemberID;
        private Label label2;
        private TextBox txtOrderID;
        private Label label1;
        private Button btnClose;
        private DateTimePicker txtOrderDate;
        private DateTimePicker txtRequiredDate;
        private DateTimePicker txtShippedDate;
        private Button btnUpdate;
    }
}