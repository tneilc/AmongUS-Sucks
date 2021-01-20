
namespace AmongusCS
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.noclipcheck = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Ytext = new System.Windows.Forms.TextBox();
            this.Xtext = new System.Windows.Forms.TextBox();
            this.Teleportbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Speedbtn = new System.Windows.Forms.Button();
            this.Speedtext = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.MaxPlayerbtn = new System.Windows.Forms.Button();
            this.Count = new System.Windows.Forms.Label();
            this.maxbar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.KillcdGO = new System.Windows.Forms.Button();
            this.KillCDText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxbar)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.noclipcheck);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 57);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ON/OFF";
            // 
            // noclipcheck
            // 
            this.noclipcheck.AutoSize = true;
            this.noclipcheck.Location = new System.Drawing.Point(97, 21);
            this.noclipcheck.Name = "noclipcheck";
            this.noclipcheck.Size = new System.Drawing.Size(71, 21);
            this.noclipcheck.TabIndex = 1;
            this.noclipcheck.Text = "NoClip";
            this.noclipcheck.UseVisualStyleBackColor = true;
            this.noclipcheck.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Impostor";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.Ytext);
            this.groupBox3.Controls.Add(this.Xtext);
            this.groupBox3.Controls.Add(this.Teleportbtn);
            this.groupBox3.Location = new System.Drawing.Point(257, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(154, 109);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Teleport";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // Ytext
            // 
            this.Ytext.Location = new System.Drawing.Point(25, 49);
            this.Ytext.Name = "Ytext";
            this.Ytext.Size = new System.Drawing.Size(100, 22);
            this.Ytext.TabIndex = 2;
            // 
            // Xtext
            // 
            this.Xtext.Location = new System.Drawing.Point(25, 21);
            this.Xtext.Name = "Xtext";
            this.Xtext.Size = new System.Drawing.Size(100, 22);
            this.Xtext.TabIndex = 1;
            // 
            // Teleportbtn
            // 
            this.Teleportbtn.BackColor = System.Drawing.Color.LimeGreen;
            this.Teleportbtn.Location = new System.Drawing.Point(50, 77);
            this.Teleportbtn.Name = "Teleportbtn";
            this.Teleportbtn.Size = new System.Drawing.Size(75, 23);
            this.Teleportbtn.TabIndex = 0;
            this.Teleportbtn.UseVisualStyleBackColor = false;
            this.Teleportbtn.Click += new System.EventHandler(this.Teleportbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Speedbtn);
            this.groupBox1.Controls.Add(this.Speedtext);
            this.groupBox1.Location = new System.Drawing.Point(212, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 57);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Speed";
            // 
            // Speedbtn
            // 
            this.Speedbtn.BackColor = System.Drawing.Color.LimeGreen;
            this.Speedbtn.Location = new System.Drawing.Point(113, 20);
            this.Speedbtn.Name = "Speedbtn";
            this.Speedbtn.Size = new System.Drawing.Size(75, 23);
            this.Speedbtn.TabIndex = 2;
            this.Speedbtn.UseVisualStyleBackColor = false;
            this.Speedbtn.Click += new System.EventHandler(this.Speedbtn_Click);
            // 
            // Speedtext
            // 
            this.Speedtext.Location = new System.Drawing.Point(6, 21);
            this.Speedtext.Name = "Speedtext";
            this.Speedtext.Size = new System.Drawing.Size(100, 22);
            this.Speedtext.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.MaxPlayerbtn);
            this.groupBox4.Controls.Add(this.Count);
            this.groupBox4.Controls.Add(this.maxbar);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.KillcdGO);
            this.groupBox4.Controls.Add(this.KillCDText);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Location = new System.Drawing.Point(12, 75);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(239, 276);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Others";
            // 
            // MaxPlayerbtn
            // 
            this.MaxPlayerbtn.BackColor = System.Drawing.Color.LimeGreen;
            this.MaxPlayerbtn.Location = new System.Drawing.Point(154, 205);
            this.MaxPlayerbtn.Name = "MaxPlayerbtn";
            this.MaxPlayerbtn.Size = new System.Drawing.Size(75, 23);
            this.MaxPlayerbtn.TabIndex = 12;
            this.MaxPlayerbtn.UseVisualStyleBackColor = false;
            this.MaxPlayerbtn.Click += new System.EventHandler(this.MaxPlayerbtn_Click);
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Location = new System.Drawing.Point(116, 161);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(0, 17);
            this.Count.TabIndex = 11;
            // 
            // maxbar
            // 
            this.maxbar.Location = new System.Drawing.Point(6, 196);
            this.maxbar.Maximum = 99;
            this.maxbar.Minimum = 1;
            this.maxbar.Name = "maxbar";
            this.maxbar.Size = new System.Drawing.Size(142, 56);
            this.maxbar.TabIndex = 7;
            this.maxbar.Value = 1;
            this.maxbar.Scroll += new System.EventHandler(this.maxbar_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Max Player    = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kill CD";
            // 
            // KillcdGO
            // 
            this.KillcdGO.BackColor = System.Drawing.Color.LimeGreen;
            this.KillcdGO.Location = new System.Drawing.Point(119, 114);
            this.KillcdGO.Name = "KillcdGO";
            this.KillcdGO.Size = new System.Drawing.Size(75, 23);
            this.KillcdGO.TabIndex = 8;
            this.KillcdGO.UseVisualStyleBackColor = false;
            this.KillcdGO.Click += new System.EventHandler(this.KillcdGO_Click);
            // 
            // KillCDText
            // 
            this.KillCDText.Location = new System.Drawing.Point(9, 115);
            this.KillCDText.Name = "KillCDText";
            this.KillCDText.Size = new System.Drawing.Size(94, 22);
            this.KillCDText.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kill Distance";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Short",
            "Medium",
            "Long"});
            this.comboBox1.Location = new System.Drawing.Point(9, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(7, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 136);
            this.label6.TabIndex = 7;
            this.label6.Text = "Impostor = None\r\nNoclip = None\r\nSpeed = None\r\nKill Distance = None\r\nKill Cooldown" +
    " = None\r\nMax Player = None\r\nPlayerX = None\r\nPlayerY = None";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(257, 190);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(154, 161);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Config";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(453, 363);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "AmongUS Sucks";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxbar)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox noclipcheck;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Ytext;
        private System.Windows.Forms.TextBox Xtext;
        private System.Windows.Forms.Button Teleportbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Speedbtn;
        private System.Windows.Forms.TextBox Speedtext;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button MaxPlayerbtn;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.TrackBar maxbar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button KillcdGO;
        private System.Windows.Forms.TextBox KillCDText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

