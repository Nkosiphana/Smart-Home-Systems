namespace Moyo_Vincent_PracticalAssignment
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.LoginBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UsernameTxt.Location = new System.Drawing.Point(107, 144);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(163, 20);
            this.UsernameTxt.TabIndex = 25;
            this.UsernameTxt.Text = "Enter Username";
            this.UsernameTxt.Click += new System.EventHandler(this.UsernameTxt_Click);
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PasswordTxt.Location = new System.Drawing.Point(107, 186);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(163, 20);
            this.PasswordTxt.TabIndex = 16;
            this.PasswordTxt.Text = "Enter Password";
            this.PasswordTxt.Click += new System.EventHandler(this.PasswordBTN_Click);
            // 
            // LoginBTN
            // 
            this.LoginBTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.LoginBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBTN.Location = new System.Drawing.Point(107, 265);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(163, 23);
            this.LoginBTN.TabIndex = 20;
            this.LoginBTN.Text = "LOGIN";
            this.LoginBTN.UseVisualStyleBackColor = false;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(80, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 73);
            this.label1.TabIndex = 21;
            this.label1.Text = "LOGIN";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox1.Location = new System.Drawing.Point(107, 224);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(132, 17);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Remember Password?";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(80, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Don\'t have an account? Sign up now";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(263, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Click here";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
         
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(395, 450);
            this.Controls.Add(this.UsernameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginBTN);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Button LoginBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}