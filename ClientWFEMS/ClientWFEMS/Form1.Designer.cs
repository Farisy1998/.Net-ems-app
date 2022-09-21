namespace ClientWFEMS
{
    partial class Form1
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
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bexit = new System.Windows.Forms.Button();
            this.binsert = new System.Windows.Forms.Button();
            this.tsal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tdes = new System.Windows.Forms.TextBox();
            this.tname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tid = new System.Windows.Forms.TextBox();
            this.bupdate = new System.Windows.Forms.Button();
            this.bexit2 = new System.Windows.Forms.Button();
            this.fieldbox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tval = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtid = new System.Windows.Forms.TextBox();
            this.bdelete = new System.Windows.Forms.Button();
            this.bexit3 = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.bview = new System.Windows.Forms.Button();
            this.bexit4 = new System.Windows.Forms.Button();
            this.tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabPage1);
            this.tab.Controls.Add(this.tabPage2);
            this.tab.Controls.Add(this.tabPage3);
            this.tab.Controls.Add(this.tabPage4);
            this.tab.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab.Location = new System.Drawing.Point(313, 173);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(755, 395);
            this.tab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPage1.Controls.Add(this.bexit);
            this.tabPage1.Controls.Add(this.binsert);
            this.tabPage1.Controls.Add(this.tsal);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tdes);
            this.tabPage1.Controls.Add(this.tname);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(747, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Insert Tab";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // bexit
            // 
            this.bexit.BackColor = System.Drawing.Color.Red;
            this.bexit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bexit.Location = new System.Drawing.Point(259, 297);
            this.bexit.Name = "bexit";
            this.bexit.Size = new System.Drawing.Size(176, 37);
            this.bexit.TabIndex = 7;
            this.bexit.Text = "Exit";
            this.bexit.UseVisualStyleBackColor = false;
            this.bexit.Click += new System.EventHandler(this.bexit_Click);
            // 
            // binsert
            // 
            this.binsert.BackColor = System.Drawing.Color.CornflowerBlue;
            this.binsert.Location = new System.Drawing.Point(259, 243);
            this.binsert.Name = "binsert";
            this.binsert.Size = new System.Drawing.Size(176, 37);
            this.binsert.TabIndex = 6;
            this.binsert.Text = "Insert";
            this.binsert.UseVisualStyleBackColor = false;
            this.binsert.Click += new System.EventHandler(this.binsert_Click);
            // 
            // tsal
            // 
            this.tsal.Location = new System.Drawing.Point(259, 187);
            this.tsal.Name = "tsal";
            this.tsal.Size = new System.Drawing.Size(176, 26);
            this.tsal.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Employee Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employee Designation";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tdes
            // 
            this.tdes.Location = new System.Drawing.Point(259, 132);
            this.tdes.Name = "tdes";
            this.tdes.Size = new System.Drawing.Size(176, 26);
            this.tdes.TabIndex = 2;
            this.tdes.TextChanged += new System.EventHandler(this.tdes_TextChanged);
            // 
            // tname
            // 
            this.tname.Location = new System.Drawing.Point(259, 80);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(176, 26);
            this.tname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPage2.Controls.Add(this.tval);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.fieldbox);
            this.tabPage2.Controls.Add(this.bexit2);
            this.tabPage2.Controls.Add(this.bupdate);
            this.tabPage2.Controls.Add(this.tid);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(747, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update Tab";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPage3.Controls.Add(this.bexit3);
            this.tabPage3.Controls.Add(this.bdelete);
            this.tabPage3.Controls.Add(this.dtid);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(747, 364);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete Tab";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPage4.Controls.Add(this.bexit4);
            this.tabPage4.Controls.Add(this.bview);
            this.tabPage4.Controls.Add(this.dgv1);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(747, 364);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "View Tab";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(454, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(524, 39);
            this.label4.TabIndex = 1;
            this.label4.Text = "Employee Management System";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Employee Id";
            // 
            // tid
            // 
            this.tid.Location = new System.Drawing.Point(227, 66);
            this.tid.Name = "tid";
            this.tid.Size = new System.Drawing.Size(275, 26);
            this.tid.TabIndex = 1;
            this.tid.TextChanged += new System.EventHandler(this.tid_TextChanged);
            // 
            // bupdate
            // 
            this.bupdate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bupdate.Location = new System.Drawing.Point(269, 251);
            this.bupdate.Name = "bupdate";
            this.bupdate.Size = new System.Drawing.Size(188, 39);
            this.bupdate.TabIndex = 2;
            this.bupdate.Text = "Update";
            this.bupdate.UseVisualStyleBackColor = false;
            this.bupdate.Click += new System.EventHandler(this.bupdate_Click);
            // 
            // bexit2
            // 
            this.bexit2.BackColor = System.Drawing.Color.Red;
            this.bexit2.Location = new System.Drawing.Point(269, 307);
            this.bexit2.Name = "bexit2";
            this.bexit2.Size = new System.Drawing.Size(188, 39);
            this.bexit2.TabIndex = 3;
            this.bexit2.Text = "Exit";
            this.bexit2.UseVisualStyleBackColor = false;
            this.bexit2.Click += new System.EventHandler(this.bexit2_Click);
            // 
            // fieldbox
            // 
            this.fieldbox.FormattingEnabled = true;
            this.fieldbox.Items.AddRange(new object[] {
            "emp_name",
            "emp_des",
            "emp_sal"});
            this.fieldbox.Location = new System.Drawing.Point(227, 130);
            this.fieldbox.Name = "fieldbox";
            this.fieldbox.Size = new System.Drawing.Size(275, 26);
            this.fieldbox.TabIndex = 4;
            this.fieldbox.Text = "Select the field";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fields";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Value";
            // 
            // tval
            // 
            this.tval.Location = new System.Drawing.Point(227, 197);
            this.tval.Name = "tval";
            this.tval.Size = new System.Drawing.Size(275, 26);
            this.tval.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Employee Id";
            // 
            // dtid
            // 
            this.dtid.Location = new System.Drawing.Point(234, 105);
            this.dtid.Name = "dtid";
            this.dtid.Size = new System.Drawing.Size(239, 26);
            this.dtid.TabIndex = 1;
            // 
            // bdelete
            // 
            this.bdelete.BackColor = System.Drawing.Color.Crimson;
            this.bdelete.Location = new System.Drawing.Point(276, 170);
            this.bdelete.Name = "bdelete";
            this.bdelete.Size = new System.Drawing.Size(149, 42);
            this.bdelete.TabIndex = 2;
            this.bdelete.Text = "Delete";
            this.bdelete.UseVisualStyleBackColor = false;
            this.bdelete.Click += new System.EventHandler(this.bdelete_Click);
            // 
            // bexit3
            // 
            this.bexit3.BackColor = System.Drawing.Color.Red;
            this.bexit3.Location = new System.Drawing.Point(276, 234);
            this.bexit3.Name = "bexit3";
            this.bexit3.Size = new System.Drawing.Size(149, 42);
            this.bexit3.TabIndex = 3;
            this.bexit3.Text = "Exit";
            this.bexit3.UseVisualStyleBackColor = false;
            this.bexit3.Click += new System.EventHandler(this.bexit3_Click);
            // 
            // dgv1
            // 
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(102, 26);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(539, 259);
            this.dgv1.TabIndex = 0;
            // 
            // bview
            // 
            this.bview.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bview.Location = new System.Drawing.Point(225, 303);
            this.bview.Name = "bview";
            this.bview.Size = new System.Drawing.Size(136, 42);
            this.bview.TabIndex = 1;
            this.bview.Text = "View Records";
            this.bview.UseVisualStyleBackColor = false;
            this.bview.Click += new System.EventHandler(this.bview_Click);
            // 
            // bexit4
            // 
            this.bexit4.BackColor = System.Drawing.Color.Red;
            this.bexit4.Location = new System.Drawing.Point(401, 303);
            this.bexit4.Name = "bexit4";
            this.bexit4.Size = new System.Drawing.Size(136, 42);
            this.bexit4.TabIndex = 2;
            this.bexit4.Text = "Exit";
            this.bexit4.UseVisualStyleBackColor = false;
            this.bexit4.Click += new System.EventHandler(this.bexit4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1142, 652);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button bexit;
        private System.Windows.Forms.Button binsert;
        private System.Windows.Forms.TextBox tsal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tdes;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bexit2;
        private System.Windows.Forms.Button bupdate;
        private System.Windows.Forms.TextBox tid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tval;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox fieldbox;
        private System.Windows.Forms.Button bexit3;
        private System.Windows.Forms.Button bdelete;
        private System.Windows.Forms.TextBox dtid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bexit4;
        private System.Windows.Forms.Button bview;
        private System.Windows.Forms.DataGridView dgv1;
    }
}

