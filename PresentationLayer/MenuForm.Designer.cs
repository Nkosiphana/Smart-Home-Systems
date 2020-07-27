namespace Moyo_Vincent_PracticalAssignment
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Agetxt = new System.Windows.Forms.TextBox();
            this.LastNametxt = new System.Windows.Forms.TextBox();
            this.FirstNametxt = new System.Windows.Forms.TextBox();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MoveFirst = new System.Windows.Forms.Button();
            this.MovePrevious = new System.Windows.Forms.Button();
            this.MoveNext = new System.Windows.Forms.Button();
            this.MoveLast = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Technicians = new System.Windows.Forms.TabPage();
            this.TechnicalBTN = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Developers = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DeveloperBTN = new System.Windows.Forms.Button();
            this.Products = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.InstallProductBTN = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.MaintainBTN = new System.Windows.Forms.Button();
            this.LogOutBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Technicians.SuspendLayout();
            this.Developers.SuspendLayout();
            this.Products.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 110);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.Updatebtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Agetxt);
            this.groupBox1.Controls.Add(this.LastNametxt);
            this.groupBox1.Controls.Add(this.FirstNametxt);
            this.groupBox1.Controls.Add(this.IDtxt);
            this.groupBox1.Location = new System.Drawing.Point(506, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 170);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Information";
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.Updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.ForeColor = System.Drawing.Color.White;
            this.Updatebtn.Location = new System.Drawing.Point(65, 141);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(168, 23);
            this.Updatebtn.TabIndex = 11;
            this.Updatebtn.Text = "UPDATE";
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 111);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 81);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 55);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 29);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID:";
            // 
            // Agetxt
            // 
            this.Agetxt.Location = new System.Drawing.Point(133, 104);
            this.Agetxt.MaxLength = 2;
            this.Agetxt.Name = "Agetxt";
            this.Agetxt.Size = new System.Drawing.Size(100, 20);
            this.Agetxt.TabIndex = 6;
            // 
            // LastNametxt
            // 
            this.LastNametxt.Location = new System.Drawing.Point(133, 78);
            this.LastNametxt.Name = "LastNametxt";
            this.LastNametxt.Size = new System.Drawing.Size(100, 20);
            this.LastNametxt.TabIndex = 5;
            // 
            // FirstNametxt
            // 
            this.FirstNametxt.Location = new System.Drawing.Point(133, 52);
            this.FirstNametxt.Name = "FirstNametxt";
            this.FirstNametxt.Size = new System.Drawing.Size(100, 20);
            this.FirstNametxt.TabIndex = 4;
            // 
            // IDtxt
            // 
            this.IDtxt.Location = new System.Drawing.Point(133, 26);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.ReadOnly = true;
            this.IDtxt.Size = new System.Drawing.Size(100, 20);
            this.IDtxt.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(59, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(720, 79);
            this.label5.TabIndex = 2;
            this.label5.Text = "Smart Home System";
            // 
            // MoveFirst
            // 
            this.MoveFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(94)))), ((int)(((byte)(140)))));
            this.MoveFirst.ForeColor = System.Drawing.Color.White;
            this.MoveFirst.Location = new System.Drawing.Point(22, 239);
            this.MoveFirst.Name = "MoveFirst";
            this.MoveFirst.Size = new System.Drawing.Size(75, 23);
            this.MoveFirst.TabIndex = 3;
            this.MoveFirst.Text = "|<";
            this.MoveFirst.UseVisualStyleBackColor = false;
            this.MoveFirst.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MovePrevious
            // 
            this.MovePrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(94)))), ((int)(((byte)(140)))));
            this.MovePrevious.ForeColor = System.Drawing.Color.White;
            this.MovePrevious.Location = new System.Drawing.Point(145, 239);
            this.MovePrevious.Name = "MovePrevious";
            this.MovePrevious.Size = new System.Drawing.Size(75, 23);
            this.MovePrevious.TabIndex = 4;
            this.MovePrevious.Text = "<";
            this.MovePrevious.UseVisualStyleBackColor = false;
            this.MovePrevious.Click += new System.EventHandler(this.Button2_Click);
            // 
            // MoveNext
            // 
            this.MoveNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(94)))), ((int)(((byte)(140)))));
            this.MoveNext.ForeColor = System.Drawing.Color.White;
            this.MoveNext.Location = new System.Drawing.Point(271, 239);
            this.MoveNext.Name = "MoveNext";
            this.MoveNext.Size = new System.Drawing.Size(75, 23);
            this.MoveNext.TabIndex = 5;
            this.MoveNext.Text = ">";
            this.MoveNext.UseVisualStyleBackColor = false;
            this.MoveNext.Click += new System.EventHandler(this.Button3_Click);
            // 
            // MoveLast
            // 
            this.MoveLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(94)))), ((int)(((byte)(140)))));
            this.MoveLast.ForeColor = System.Drawing.Color.White;
            this.MoveLast.Location = new System.Drawing.Point(392, 239);
            this.MoveLast.Name = "MoveLast";
            this.MoveLast.Size = new System.Drawing.Size(75, 23);
            this.MoveLast.TabIndex = 6;
            this.MoveLast.Text = ">|";
            this.MoveLast.UseVisualStyleBackColor = false;
            this.MoveLast.Click += new System.EventHandler(this.Button4_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Technicians);
            this.tabControl1.Controls.Add(this.Developers);
            this.tabControl1.Controls.Add(this.Products);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(18, 285);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(786, 173);
            this.tabControl1.TabIndex = 9;
            // 
            // Technicians
            // 
            this.Technicians.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Technicians.Controls.Add(this.TechnicalBTN);
            this.Technicians.Controls.Add(this.label7);
            this.Technicians.Controls.Add(this.label6);
            this.Technicians.Location = new System.Drawing.Point(4, 29);
            this.Technicians.Name = "Technicians";
            this.Technicians.Padding = new System.Windows.Forms.Padding(3);
            this.Technicians.Size = new System.Drawing.Size(778, 140);
            this.Technicians.TabIndex = 0;
            this.Technicians.Text = "Technicians";
            // 
            // TechnicalBTN
            // 
            this.TechnicalBTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.TechnicalBTN.ForeColor = System.Drawing.Color.White;
            this.TechnicalBTN.Location = new System.Drawing.Point(265, 102);
            this.TechnicalBTN.Name = "TechnicalBTN";
            this.TechnicalBTN.Size = new System.Drawing.Size(208, 35);
            this.TechnicalBTN.TabIndex = 11;
            this.TechnicalBTN.Text = "View Technical department";
            this.TechnicalBTN.UseVisualStyleBackColor = false;
            this.TechnicalBTN.Click += new System.EventHandler(this.TechnicalBTN_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 18);
            this.label7.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(757, 108);
            this.label6.TabIndex = 9;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // Developers
            // 
            this.Developers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Developers.Controls.Add(this.label8);
            this.Developers.Controls.Add(this.label9);
            this.Developers.Controls.Add(this.DeveloperBTN);
            this.Developers.Location = new System.Drawing.Point(4, 29);
            this.Developers.Name = "Developers";
            this.Developers.Padding = new System.Windows.Forms.Padding(3);
            this.Developers.Size = new System.Drawing.Size(778, 140);
            this.Developers.TabIndex = 1;
            this.Developers.Text = "Developers";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(742, 36);
            this.label8.TabIndex = 12;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(761, 54);
            this.label9.TabIndex = 11;
            this.label9.Text = resources.GetString("label9.Text");
            // 
            // DeveloperBTN
            // 
            this.DeveloperBTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.DeveloperBTN.ForeColor = System.Drawing.Color.White;
            this.DeveloperBTN.Location = new System.Drawing.Point(245, 102);
            this.DeveloperBTN.Name = "DeveloperBTN";
            this.DeveloperBTN.Size = new System.Drawing.Size(208, 35);
            this.DeveloperBTN.TabIndex = 1;
            this.DeveloperBTN.Text = "View Developers Department";
            this.DeveloperBTN.UseVisualStyleBackColor = false;
            this.DeveloperBTN.Click += new System.EventHandler(this.DeveloperBTN_Click);
            // 
            // Products
            // 
            this.Products.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Products.Controls.Add(this.label10);
            this.Products.Controls.Add(this.button5);
            this.Products.Location = new System.Drawing.Point(4, 29);
            this.Products.Name = "Products";
            this.Products.Padding = new System.Windows.Forms.Padding(3);
            this.Products.Size = new System.Drawing.Size(778, 140);
            this.Products.TabIndex = 2;
            this.Products.Text = "Products";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(542, 54);
            this.label10.TabIndex = 1;
            this.label10.Text = "View all the Products the company has to offer. These products vary in prices and" +
    "\r\ndepending on client membership you could purchase some products at a lower\r\ndi" +
    "scount.\r\n";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(245, 105);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(208, 32);
            this.button5.TabIndex = 0;
            this.button5.Text = "View Products";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click_1);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.InstallProductBTN);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(778, 140);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Installation";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(687, 36);
            this.label11.TabIndex = 2;
            this.label11.Text = "This tab will provide guidance for you on how you can start will the installation" +
    " process for your product. \r\nfollow the following steps and get to experience th" +
    "e product to the fullest\r\n";
            // 
            // InstallProductBTN
            // 
            this.InstallProductBTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.InstallProductBTN.ForeColor = System.Drawing.Color.White;
            this.InstallProductBTN.Location = new System.Drawing.Point(275, 105);
            this.InstallProductBTN.Name = "InstallProductBTN";
            this.InstallProductBTN.Size = new System.Drawing.Size(208, 32);
            this.InstallProductBTN.TabIndex = 1;
            this.InstallProductBTN.Text = "Install Product";
            this.InstallProductBTN.UseVisualStyleBackColor = false;
            this.InstallProductBTN.Click += new System.EventHandler(this.InstallProductBTN_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.MaintainBTN);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(778, 140);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Maintenance";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(702, 36);
            this.label12.TabIndex = 3;
            this.label12.Text = "This tab will provide guidance for you on how you can start will the maintenance " +
    "process for your product. \r\nfollow the following steps and get to experience the" +
    " product to the fullest\r\n";
            // 
            // MaintainBTN
            // 
            this.MaintainBTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.MaintainBTN.ForeColor = System.Drawing.Color.White;
            this.MaintainBTN.Location = new System.Drawing.Point(278, 105);
            this.MaintainBTN.Name = "MaintainBTN";
            this.MaintainBTN.Size = new System.Drawing.Size(208, 32);
            this.MaintainBTN.TabIndex = 1;
            this.MaintainBTN.Text = "Maintain Product";
            this.MaintainBTN.UseVisualStyleBackColor = false;
            this.MaintainBTN.Click += new System.EventHandler(this.MaintainBTN_Click);
            // 
            // LogOutBTN
            // 
            this.LogOutBTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.LogOutBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogOutBTN.Location = new System.Drawing.Point(699, 467);
            this.LogOutBTN.Name = "LogOutBTN";
            this.LogOutBTN.Size = new System.Drawing.Size(105, 26);
            this.LogOutBTN.TabIndex = 10;
            this.LogOutBTN.Text = "LOG OUT";
            this.LogOutBTN.UseVisualStyleBackColor = false;
            this.LogOutBTN.Click += new System.EventHandler(this.LogOutBTN_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(840, 505);
            this.Controls.Add(this.LogOutBTN);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.MoveLast);
            this.Controls.Add(this.MoveNext);
            this.Controls.Add(this.MovePrevious);
            this.Controls.Add(this.MoveFirst);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MenuForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Technicians.ResumeLayout(false);
            this.Technicians.PerformLayout();
            this.Developers.ResumeLayout(false);
            this.Developers.PerformLayout();
            this.Products.ResumeLayout(false);
            this.Products.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Agetxt;
        private System.Windows.Forms.TextBox LastNametxt;
        private System.Windows.Forms.TextBox FirstNametxt;
        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button MoveFirst;
        private System.Windows.Forms.Button MovePrevious;
        private System.Windows.Forms.Button MoveNext;
        private System.Windows.Forms.Button MoveLast;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Technicians;
        private System.Windows.Forms.TabPage Developers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DeveloperBTN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button TechnicalBTN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage Products;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button LogOutBTN;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button InstallProductBTN;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button MaintainBTN;
    }
}

