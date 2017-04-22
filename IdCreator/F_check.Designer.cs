namespace WindowsFormsApplication1
{
    partial class F_check
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lbplace = new System.Windows.Forms.Label();
            this.lbdate = new System.Windows.Forms.Label();
            this.lbturn = new System.Windows.Forms.Label();
            this.lbsex = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(27, 36);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(138, 21);
            this.txtid.TabIndex = 0;
            this.txtid.Text = "150100195001012099";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(180, 34);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(60, 23);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lbplace
            // 
            this.lbplace.AutoSize = true;
            this.lbplace.Location = new System.Drawing.Point(25, 72);
            this.lbplace.Name = "lbplace";
            this.lbplace.Size = new System.Drawing.Size(35, 12);
            this.lbplace.TabIndex = 2;
            this.lbplace.Text = "place";
            // 
            // lbdate
            // 
            this.lbdate.AutoSize = true;
            this.lbdate.Location = new System.Drawing.Point(25, 101);
            this.lbdate.Name = "lbdate";
            this.lbdate.Size = new System.Drawing.Size(29, 12);
            this.lbdate.TabIndex = 3;
            this.lbdate.Text = "date";
            // 
            // lbturn
            // 
            this.lbturn.AutoSize = true;
            this.lbturn.Location = new System.Drawing.Point(25, 156);
            this.lbturn.Name = "lbturn";
            this.lbturn.Size = new System.Drawing.Size(29, 12);
            this.lbturn.TabIndex = 4;
            this.lbturn.Text = "turn";
            // 
            // lbsex
            // 
            this.lbsex.AutoSize = true;
            this.lbsex.Location = new System.Drawing.Point(25, 132);
            this.lbsex.Name = "lbsex";
            this.lbsex.Size = new System.Drawing.Size(23, 12);
            this.lbsex.TabIndex = 4;
            this.lbsex.Text = "sex";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(255, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // F_check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 179);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbsex);
            this.Controls.Add(this.lbturn);
            this.Controls.Add(this.lbdate);
            this.Controls.Add(this.lbplace);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtid);
            this.MaximizeBox = false;
            this.Name = "F_check";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lbplace;
        private System.Windows.Forms.Label lbdate;
        private System.Windows.Forms.Label lbturn;
        private System.Windows.Forms.Label lbsex;
        private System.Windows.Forms.Button btnAdd;
    }
}