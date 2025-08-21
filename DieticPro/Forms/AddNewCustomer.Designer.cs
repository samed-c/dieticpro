namespace DieticPro.Forms
{
    partial class AddNewCustomer
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
            this.TBname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBsurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBcompany = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBaddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBtelephone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TBmobile = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TBbirth = new System.Windows.Forms.TextBox();
            this.GRPcustomer = new System.Windows.Forms.GroupBox();
            this.BTNCustomer = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.GRPcustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBname
            // 
            this.TBname.Location = new System.Drawing.Point(116, 30);
            this.TBname.Name = "TBname";
            this.TBname.Size = new System.Drawing.Size(158, 20);
            this.TBname.TabIndex = 0;
            this.TBname.TextChanged += new System.EventHandler(this.TBname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyad:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TBsurname
            // 
            this.TBsurname.Location = new System.Drawing.Point(116, 56);
            this.TBsurname.Name = "TBsurname";
            this.TBsurname.Size = new System.Drawing.Size(158, 20);
            this.TBsurname.TabIndex = 2;
            this.TBsurname.TextChanged += new System.EventHandler(this.TBsurname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şirket:";
            // 
            // TBcompany
            // 
            this.TBcompany.Location = new System.Drawing.Point(116, 125);
            this.TBcompany.Name = "TBcompany";
            this.TBcompany.Size = new System.Drawing.Size(158, 20);
            this.TBcompany.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adres:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TBaddress
            // 
            this.TBaddress.Location = new System.Drawing.Point(116, 151);
            this.TBaddress.Name = "TBaddress";
            this.TBaddress.Size = new System.Drawing.Size(158, 20);
            this.TBaddress.TabIndex = 6;
            this.TBaddress.TextChanged += new System.EventHandler(this.TBaddress_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefon:";
            // 
            // TBtelephone
            // 
            this.TBtelephone.Location = new System.Drawing.Point(116, 177);
            this.TBtelephone.Name = "TBtelephone";
            this.TBtelephone.Size = new System.Drawing.Size(158, 20);
            this.TBtelephone.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cep:";
            // 
            // TBmobile
            // 
            this.TBmobile.Location = new System.Drawing.Point(116, 203);
            this.TBmobile.Name = "TBmobile";
            this.TBmobile.Size = new System.Drawing.Size(158, 20);
            this.TBmobile.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Doğum Tarihi:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // TBbirth
            // 
            this.TBbirth.Location = new System.Drawing.Point(116, 82);
            this.TBbirth.Name = "TBbirth";
            this.TBbirth.Size = new System.Drawing.Size(158, 20);
            this.TBbirth.TabIndex = 12;
            this.TBbirth.TextChanged += new System.EventHandler(this.TBbirth_TextChanged);
            // 
            // GRPcustomer
            // 
            this.GRPcustomer.Controls.Add(this.label11);
            this.GRPcustomer.Controls.Add(this.label8);
            this.GRPcustomer.Controls.Add(this.BTNCustomer);
            this.GRPcustomer.Controls.Add(this.label7);
            this.GRPcustomer.Controls.Add(this.label6);
            this.GRPcustomer.Controls.Add(this.TBbirth);
            this.GRPcustomer.Controls.Add(this.TBmobile);
            this.GRPcustomer.Controls.Add(this.label4);
            this.GRPcustomer.Controls.Add(this.label5);
            this.GRPcustomer.Controls.Add(this.TBaddress);
            this.GRPcustomer.Controls.Add(this.TBtelephone);
            this.GRPcustomer.Controls.Add(this.label3);
            this.GRPcustomer.Controls.Add(this.TBcompany);
            this.GRPcustomer.Controls.Add(this.label2);
            this.GRPcustomer.Controls.Add(this.TBsurname);
            this.GRPcustomer.Controls.Add(this.label1);
            this.GRPcustomer.Controls.Add(this.TBname);
            this.GRPcustomer.Location = new System.Drawing.Point(12, 12);
            this.GRPcustomer.Name = "GRPcustomer";
            this.GRPcustomer.Size = new System.Drawing.Size(301, 301);
            this.GRPcustomer.TabIndex = 14;
            this.GRPcustomer.TabStop = false;
            this.GRPcustomer.Text = "Müşteri Bilgileri";
            // 
            // BTNCustomer
            // 
            this.BTNCustomer.Location = new System.Drawing.Point(154, 248);
            this.BTNCustomer.Name = "BTNCustomer";
            this.BTNCustomer.Size = new System.Drawing.Size(120, 33);
            this.BTNCustomer.TabIndex = 14;
            this.BTNCustomer.Text = "Müşteri Girişi Yap";
            this.BTNCustomer.UseVisualStyleBackColor = true;
            this.BTNCustomer.Click += new System.EventHandler(this.BTNCustomer_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "(gg.aa.yyyy)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(230, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "nümerik";
            // 
            // AddNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 325);
            this.Controls.Add(this.GRPcustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewCustomer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "     Yeni Müşteri Girişi";
            this.Load += new System.EventHandler(this.AddNewCustomer_Load);
            this.GRPcustomer.ResumeLayout(false);
            this.GRPcustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TBname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBsurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBcompany;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBaddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBtelephone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBmobile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBbirth;
        private System.Windows.Forms.GroupBox GRPcustomer;
        private System.Windows.Forms.Button BTNCustomer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
    }
}