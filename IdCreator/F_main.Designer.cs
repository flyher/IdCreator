namespace WindowsFormsApplication1
{
    partial class F_main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.cbplace = new System.Windows.Forms.ComboBox();
            this.cbpro = new System.Windows.Forms.ComboBox();
            this.cbyear = new System.Windows.Forms.ComboBox();
            this.cbmonth = new System.Windows.Forms.ComboBox();
            this.cbday = new System.Windows.Forms.ComboBox();
            this.cbsex = new System.Windows.Forms.ComboBox();
            this.lbresult = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsdel = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnout = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(193, 74);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(193, 161);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // cbplace
            // 
            this.cbplace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbplace.FormattingEnabled = true;
            this.cbplace.Location = new System.Drawing.Point(90, 22);
            this.cbplace.Name = "cbplace";
            this.cbplace.Size = new System.Drawing.Size(178, 20);
            this.cbplace.TabIndex = 3;
            // 
            // cbpro
            // 
            this.cbpro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbpro.FormattingEnabled = true;
            this.cbpro.Location = new System.Drawing.Point(12, 22);
            this.cbpro.Name = "cbpro";
            this.cbpro.Size = new System.Drawing.Size(72, 20);
            this.cbpro.TabIndex = 3;
            this.cbpro.SelectedValueChanged += new System.EventHandler(this.cbpro_SelectedValueChanged);
            // 
            // cbyear
            // 
            this.cbyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbyear.FormattingEnabled = true;
            this.cbyear.Location = new System.Drawing.Point(12, 48);
            this.cbyear.Name = "cbyear";
            this.cbyear.Size = new System.Drawing.Size(49, 20);
            this.cbyear.TabIndex = 4;
            this.cbyear.SelectedIndexChanged += new System.EventHandler(this.cbyear_SelectedIndexChanged);
            // 
            // cbmonth
            // 
            this.cbmonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmonth.FormattingEnabled = true;
            this.cbmonth.Location = new System.Drawing.Point(80, 48);
            this.cbmonth.Name = "cbmonth";
            this.cbmonth.Size = new System.Drawing.Size(40, 20);
            this.cbmonth.TabIndex = 4;
            this.cbmonth.SelectedIndexChanged += new System.EventHandler(this.cbmonth_SelectedIndexChanged);
            // 
            // cbday
            // 
            this.cbday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbday.FormattingEnabled = true;
            this.cbday.Location = new System.Drawing.Point(137, 48);
            this.cbday.Name = "cbday";
            this.cbday.Size = new System.Drawing.Size(40, 20);
            this.cbday.TabIndex = 4;
            // 
            // cbsex
            // 
            this.cbsex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsex.FormattingEnabled = true;
            this.cbsex.Location = new System.Drawing.Point(204, 48);
            this.cbsex.Name = "cbsex";
            this.cbsex.Size = new System.Drawing.Size(40, 20);
            this.cbsex.TabIndex = 4;
            // 
            // lbresult
            // 
            this.lbresult.ContextMenuStrip = this.contextMenuStrip1;
            this.lbresult.FormattingEnabled = true;
            this.lbresult.ItemHeight = 12;
            this.lbresult.Location = new System.Drawing.Point(12, 74);
            this.lbresult.Name = "lbresult";
            this.lbresult.Size = new System.Drawing.Size(165, 148);
            this.lbresult.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.cmsdel});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 92);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // cmsdel
            // 
            this.cmsdel.Name = "cmsdel";
            this.cmsdel.Size = new System.Drawing.Size(152, 22);
            this.cmsdel.Text = "Delete";
            this.cmsdel.Click += new System.EventHandler(this.cmsdel_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(193, 132);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(193, 103);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnout
            // 
            this.btnout.Location = new System.Drawing.Point(193, 197);
            this.btnout.Name = "btnout";
            this.btnout.Size = new System.Drawing.Size(75, 23);
            this.btnout.TabIndex = 2;
            this.btnout.Text = "OutPut";
            this.btnout.UseVisualStyleBackColor = true;
            this.btnout.Click += new System.EventHandler(this.btnout_Click);
            // 
            // F_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 232);
            this.Controls.Add(this.cbpro);
            this.Controls.Add(this.lbresult);
            this.Controls.Add(this.cbsex);
            this.Controls.Add(this.cbday);
            this.Controls.Add(this.cbmonth);
            this.Controls.Add(this.cbyear);
            this.Controls.Add(this.cbplace);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnout);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnGet);
            this.MaximizeBox = false;
            this.Name = "F_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "身份证号码生成工具";
            this.Load += new System.EventHandler(this.frmidentity_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ComboBox cbplace;
        private System.Windows.Forms.ComboBox cbpro;
        private System.Windows.Forms.ComboBox cbyear;
        private System.Windows.Forms.ComboBox cbmonth;
        private System.Windows.Forms.ComboBox cbday;
        private System.Windows.Forms.ComboBox cbsex;
        private System.Windows.Forms.ListBox lbresult;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmsdel;
        private System.Windows.Forms.Button btnout;
    }
}

