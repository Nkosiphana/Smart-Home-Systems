namespace Moyo_Vincent_PracticalAssignment
{
    partial class Developers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Developers));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MoveLast = new System.Windows.Forms.Button();
            this.MoveNext = new System.Windows.Forms.Button();
            this.MovePrevious = new System.Windows.Forms.Button();
            this.MoveFirst = new System.Windows.Forms.Button();
            this.BackLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.firstNameLBL = new System.Windows.Forms.Label();
            this.contactInfoLBL = new System.Windows.Forms.Label();
            this.lastNameLBL = new System.Windows.Forms.Label();
            this.IDLBL = new System.Windows.Forms.Label();
            this.descriptionLBL = new System.Windows.Forms.Label();
            this.specilizeLBL = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EmailLBL = new System.Windows.Forms.Label();
            this.ContactBTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(731, 73);
            this.label1.TabIndex = 24;
            this.label1.Text = "Developers Department";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 166);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectionChanged);
            // 
            // MoveLast
            // 
            this.MoveLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(94)))), ((int)(((byte)(140)))));
            this.MoveLast.ForeColor = System.Drawing.Color.White;
            this.MoveLast.Location = new System.Drawing.Point(636, 273);
            this.MoveLast.Name = "MoveLast";
            this.MoveLast.Size = new System.Drawing.Size(93, 23);
            this.MoveLast.TabIndex = 29;
            this.MoveLast.Text = ">|";
            this.MoveLast.UseVisualStyleBackColor = false;
            this.MoveLast.Click += new System.EventHandler(this.MoveLast_Click);
            // 
            // MoveNext
            // 
            this.MoveNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(94)))), ((int)(((byte)(140)))));
            this.MoveNext.ForeColor = System.Drawing.Color.White;
            this.MoveNext.Location = new System.Drawing.Point(461, 273);
            this.MoveNext.Name = "MoveNext";
            this.MoveNext.Size = new System.Drawing.Size(93, 23);
            this.MoveNext.TabIndex = 28;
            this.MoveNext.Text = ">";
            this.MoveNext.UseVisualStyleBackColor = false;
            this.MoveNext.Click += new System.EventHandler(this.MoveNext_Click);
            // 
            // MovePrevious
            // 
            this.MovePrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(94)))), ((int)(((byte)(140)))));
            this.MovePrevious.ForeColor = System.Drawing.Color.White;
            this.MovePrevious.Location = new System.Drawing.Point(268, 273);
            this.MovePrevious.Name = "MovePrevious";
            this.MovePrevious.Size = new System.Drawing.Size(93, 23);
            this.MovePrevious.TabIndex = 27;
            this.MovePrevious.Text = "<";
            this.MovePrevious.UseVisualStyleBackColor = false;
            this.MovePrevious.Click += new System.EventHandler(this.MovePrevious_Click);
            // 
            // MoveFirst
            // 
            this.MoveFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(94)))), ((int)(((byte)(140)))));
            this.MoveFirst.ForeColor = System.Drawing.Color.White;
            this.MoveFirst.Location = new System.Drawing.Point(89, 273);
            this.MoveFirst.Name = "MoveFirst";
            this.MoveFirst.Size = new System.Drawing.Size(93, 23);
            this.MoveFirst.TabIndex = 26;
            this.MoveFirst.Text = "|<";
            this.MoveFirst.UseVisualStyleBackColor = false;
            this.MoveFirst.Click += new System.EventHandler(this.MoveFirst_Click);
            // 
            // BackLbl
            // 
            this.BackLbl.AutoSize = true;
            this.BackLbl.BackColor = System.Drawing.Color.Transparent;
            this.BackLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackLbl.ForeColor = System.Drawing.Color.White;
            this.BackLbl.Location = new System.Drawing.Point(6, 9);
            this.BackLbl.Name = "BackLbl";
            this.BackLbl.Size = new System.Drawing.Size(18, 13);
            this.BackLbl.TabIndex = 30;
            this.BackLbl.Text = "<-";
            this.BackLbl.Click += new System.EventHandler(this.BackLbl_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.firstNameLBL);
            this.groupBox1.Controls.Add(this.contactInfoLBL);
            this.groupBox1.Controls.Add(this.lastNameLBL);
            this.groupBox1.Controls.Add(this.IDLBL);
            this.groupBox1.Controls.Add(this.descriptionLBL);
            this.groupBox1.Controls.Add(this.specilizeLBL);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.EmailLBL);
            this.groupBox1.Controls.Add(this.ContactBTN);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 317);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 170);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Developer Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(357, 52);
            this.label6.TabIndex = 23;
            this.label6.Text = "View information on the developers that are responsible developing your \r\nproduct" +
    "s you have purchased. These developers are here to help you and\r\n you can contac" +
    "t them at anytime of the day\r\n\r\n";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(599, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "EMAIL NOW!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // firstNameLBL
            // 
            this.firstNameLBL.AutoSize = true;
            this.firstNameLBL.Location = new System.Drawing.Point(177, 54);
            this.firstNameLBL.Name = "firstNameLBL";
            this.firstNameLBL.Size = new System.Drawing.Size(0, 13);
            this.firstNameLBL.TabIndex = 21;
            // 
            // contactInfoLBL
            // 
            this.contactInfoLBL.AutoSize = true;
            this.contactInfoLBL.Location = new System.Drawing.Point(489, 116);
            this.contactInfoLBL.Name = "contactInfoLBL";
            this.contactInfoLBL.Size = new System.Drawing.Size(0, 13);
            this.contactInfoLBL.TabIndex = 20;
            // 
            // lastNameLBL
            // 
            this.lastNameLBL.AutoSize = true;
            this.lastNameLBL.Location = new System.Drawing.Point(177, 80);
            this.lastNameLBL.Name = "lastNameLBL";
            this.lastNameLBL.Size = new System.Drawing.Size(0, 13);
            this.lastNameLBL.TabIndex = 19;
            // 
            // IDLBL
            // 
            this.IDLBL.AutoSize = true;
            this.IDLBL.Location = new System.Drawing.Point(177, 28);
            this.IDLBL.Name = "IDLBL";
            this.IDLBL.Size = new System.Drawing.Size(0, 13);
            this.IDLBL.TabIndex = 18;
            // 
            // descriptionLBL
            // 
            this.descriptionLBL.AutoSize = true;
            this.descriptionLBL.Location = new System.Drawing.Point(181, 131);
            this.descriptionLBL.Name = "descriptionLBL";
            this.descriptionLBL.Size = new System.Drawing.Size(0, 13);
            this.descriptionLBL.TabIndex = 17;
            // 
            // specilizeLBL
            // 
            this.specilizeLBL.AutoSize = true;
            this.specilizeLBL.Location = new System.Drawing.Point(181, 106);
            this.specilizeLBL.Name = "specilizeLBL";
            this.specilizeLBL.Size = new System.Drawing.Size(0, 13);
            this.specilizeLBL.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Techician Description:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "This technician specializes in:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(606, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Email:";
            // 
            // EmailLBL
            // 
            this.EmailLBL.AutoSize = true;
            this.EmailLBL.Location = new System.Drawing.Point(641, 116);
            this.EmailLBL.Name = "EmailLBL";
            this.EmailLBL.Size = new System.Drawing.Size(0, 13);
            this.EmailLBL.TabIndex = 12;
            // 
            // ContactBTN
            // 
            this.ContactBTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.ContactBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactBTN.ForeColor = System.Drawing.Color.White;
            this.ContactBTN.Location = new System.Drawing.Point(385, 141);
            this.ContactBTN.Name = "ContactBTN";
            this.ContactBTN.Size = new System.Drawing.Size(168, 23);
            this.ContactBTN.TabIndex = 11;
            this.ContactBTN.Text = "CALL NOW!";
            this.ContactBTN.UseVisualStyleBackColor = false;
            this.ContactBTN.Click += new System.EventHandler(this.ContactBTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 116);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Contact Information:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 80);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 54);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 28);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "ID:";
            // 
            // Developers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BackLbl);
            this.Controls.Add(this.MoveLast);
            this.Controls.Add(this.MoveNext);
            this.Controls.Add(this.MovePrevious);
            this.Controls.Add(this.MoveFirst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Developers";
            this.Text = "Developers";
            this.Load += new System.EventHandler(this.Developers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button MoveLast;
        private System.Windows.Forms.Button MoveNext;
        private System.Windows.Forms.Button MovePrevious;
        private System.Windows.Forms.Button MoveFirst;
        private System.Windows.Forms.Label BackLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label firstNameLBL;
        private System.Windows.Forms.Label contactInfoLBL;
        private System.Windows.Forms.Label lastNameLBL;
        private System.Windows.Forms.Label IDLBL;
        private System.Windows.Forms.Label descriptionLBL;
        private System.Windows.Forms.Label specilizeLBL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label EmailLBL;
        private System.Windows.Forms.Button ContactBTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}