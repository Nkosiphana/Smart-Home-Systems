namespace Moyo_Vincent_PracticalAssignment
{
    partial class Maintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maintenance));
            this.MaintainBTN = new System.Windows.Forms.Button();
            this.BackLbl = new System.Windows.Forms.Label();
            this.MoveLast = new System.Windows.Forms.Button();
            this.MoveNext = new System.Windows.Forms.Button();
            this.MovePrevious = new System.Windows.Forms.Button();
            this.MoveFirst = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MaintainBTN
            // 
            this.MaintainBTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.MaintainBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaintainBTN.ForeColor = System.Drawing.Color.White;
            this.MaintainBTN.Location = new System.Drawing.Point(283, 386);
            this.MaintainBTN.Name = "MaintainBTN";
            this.MaintainBTN.Size = new System.Drawing.Size(230, 23);
            this.MaintainBTN.TabIndex = 32;
            this.MaintainBTN.Text = "Maintain selected Product";
            this.MaintainBTN.UseVisualStyleBackColor = false;
            this.MaintainBTN.Click += new System.EventHandler(this.MaintainBTN_Click);
            // 
            // BackLbl
            // 
            this.BackLbl.AutoSize = true;
            this.BackLbl.BackColor = System.Drawing.Color.Transparent;
            this.BackLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackLbl.ForeColor = System.Drawing.Color.White;
            this.BackLbl.Location = new System.Drawing.Point(12, 9);
            this.BackLbl.Name = "BackLbl";
            this.BackLbl.Size = new System.Drawing.Size(18, 13);
            this.BackLbl.TabIndex = 31;
            this.BackLbl.Text = "<-";
            this.BackLbl.Click += new System.EventHandler(this.BackLbl_Click);
            // 
            // MoveLast
            // 
            this.MoveLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(94)))), ((int)(((byte)(140)))));
            this.MoveLast.ForeColor = System.Drawing.Color.White;
            this.MoveLast.Location = new System.Drawing.Point(643, 313);
            this.MoveLast.Name = "MoveLast";
            this.MoveLast.Size = new System.Drawing.Size(102, 23);
            this.MoveLast.TabIndex = 30;
            this.MoveLast.Text = ">|";
            this.MoveLast.UseVisualStyleBackColor = false;
            this.MoveLast.Click += new System.EventHandler(this.MoveLast_Click);
            // 
            // MoveNext
            // 
            this.MoveNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(94)))), ((int)(((byte)(140)))));
            this.MoveNext.ForeColor = System.Drawing.Color.White;
            this.MoveNext.Location = new System.Drawing.Point(456, 313);
            this.MoveNext.Name = "MoveNext";
            this.MoveNext.Size = new System.Drawing.Size(102, 23);
            this.MoveNext.TabIndex = 29;
            this.MoveNext.Text = ">";
            this.MoveNext.UseVisualStyleBackColor = false;
            this.MoveNext.Click += new System.EventHandler(this.MoveNext_Click);
            // 
            // MovePrevious
            // 
            this.MovePrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(94)))), ((int)(((byte)(140)))));
            this.MovePrevious.ForeColor = System.Drawing.Color.White;
            this.MovePrevious.Location = new System.Drawing.Point(260, 313);
            this.MovePrevious.Name = "MovePrevious";
            this.MovePrevious.Size = new System.Drawing.Size(102, 23);
            this.MovePrevious.TabIndex = 28;
            this.MovePrevious.Text = "<";
            this.MovePrevious.UseVisualStyleBackColor = false;
            this.MovePrevious.Click += new System.EventHandler(this.MovePrevious_Click);
            // 
            // MoveFirst
            // 
            this.MoveFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(94)))), ((int)(((byte)(140)))));
            this.MoveFirst.ForeColor = System.Drawing.Color.White;
            this.MoveFirst.Location = new System.Drawing.Point(63, 313);
            this.MoveFirst.Name = "MoveFirst";
            this.MoveFirst.Size = new System.Drawing.Size(102, 23);
            this.MoveFirst.TabIndex = 27;
            this.MoveFirst.Text = "|<";
            this.MoveFirst.UseVisualStyleBackColor = false;
            this.MoveFirst.Click += new System.EventHandler(this.MoveFirst_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(682, 160);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectionChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(49, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(723, 79);
            this.label5.TabIndex = 25;
            this.label5.Text = "Maintenance Process";
            // 
            // Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MaintainBTN);
            this.Controls.Add(this.BackLbl);
            this.Controls.Add(this.MoveLast);
            this.Controls.Add(this.MoveNext);
            this.Controls.Add(this.MovePrevious);
            this.Controls.Add(this.MoveFirst);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Name = "Maintenance";
            this.Text = "Maintenance";
            this.Load += new System.EventHandler(this.Maintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MaintainBTN;
        private System.Windows.Forms.Label BackLbl;
        private System.Windows.Forms.Button MoveLast;
        private System.Windows.Forms.Button MoveNext;
        private System.Windows.Forms.Button MovePrevious;
        private System.Windows.Forms.Button MoveFirst;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
    }
}