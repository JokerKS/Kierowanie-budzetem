namespace Kierowanie_budzetem
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usunąćWszystkieDaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaProgramyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startWithWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MinusMoneyPage = new System.Windows.Forms.TabPage();
            this.OKButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SpentTextBox = new System.Windows.Forms.TextBox();
            this.InputDataPage = new System.Windows.Forms.TabPage();
            this.FinishData = new System.Windows.Forms.DateTimePicker();
            this.StartData = new System.Windows.Forms.DateTimePicker();
            this.SaveChangeButton = new System.Windows.Forms.Button();
            this.OtherExpensesTextBox = new System.Windows.Forms.TextBox();
            this.ResidenceTextBox = new System.Windows.Forms.TextBox();
            this.IncomeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.MinusMoneyPage.SuspendLayout();
            this.InputDataPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.ustawieniaProgramyToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(324, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usunąćWszystkieDaneToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // usunąćWszystkieDaneToolStripMenuItem
            // 
            this.usunąćWszystkieDaneToolStripMenuItem.Name = "usunąćWszystkieDaneToolStripMenuItem";
            this.usunąćWszystkieDaneToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.usunąćWszystkieDaneToolStripMenuItem.Text = "Usunąć wszystkie dane";
            this.usunąćWszystkieDaneToolStripMenuItem.Click += new System.EventHandler(this.usunąćWszystkieDaneToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ustawieniaProgramyToolStripMenuItem
            // 
            this.ustawieniaProgramyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startWithWindowsToolStripMenuItem});
            this.ustawieniaProgramyToolStripMenuItem.Name = "ustawieniaProgramyToolStripMenuItem";
            this.ustawieniaProgramyToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.ustawieniaProgramyToolStripMenuItem.Text = "Ustawienia";
            // 
            // startWithWindowsToolStripMenuItem
            // 
            this.startWithWindowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yesToolStripMenuItem,
            this.noToolStripMenuItem});
            this.startWithWindowsToolStripMenuItem.Name = "startWithWindowsToolStripMenuItem";
            this.startWithWindowsToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.startWithWindowsToolStripMenuItem.Text = "Start with Windows";
            // 
            // yesToolStripMenuItem
            // 
            this.yesToolStripMenuItem.Name = "yesToolStripMenuItem";
            this.yesToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.yesToolStripMenuItem.Text = "Yes";
            this.yesToolStripMenuItem.Click += new System.EventHandler(this.yesToolStripMenuItem_Click);
            // 
            // noToolStripMenuItem
            // 
            this.noToolStripMenuItem.Name = "noToolStripMenuItem";
            this.noToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.noToolStripMenuItem.Text = "No";
            this.noToolStripMenuItem.Click += new System.EventHandler(this.noToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Kierowanie własnym budżetem";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripSeparator1,
            this.toolStripMenuItem4});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 54);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem2.Text = "Otworzyć";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem4.Text = "Zamknij";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MinusMoneyPage);
            this.tabControl1.Controls.Add(this.InputDataPage);
            this.tabControl1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(300, 372);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // MinusMoneyPage
            // 
            this.MinusMoneyPage.Controls.Add(this.OKButton);
            this.MinusMoneyPage.Controls.Add(this.label3);
            this.MinusMoneyPage.Controls.Add(this.label2);
            this.MinusMoneyPage.Controls.Add(this.label1);
            this.MinusMoneyPage.Controls.Add(this.SpentTextBox);
            this.MinusMoneyPage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinusMoneyPage.Location = new System.Drawing.Point(4, 38);
            this.MinusMoneyPage.Name = "MinusMoneyPage";
            this.MinusMoneyPage.Padding = new System.Windows.Forms.Padding(3);
            this.MinusMoneyPage.Size = new System.Drawing.Size(292, 330);
            this.MinusMoneyPage.TabIndex = 0;
            this.MinusMoneyPage.Text = "Koszty";
            this.MinusMoneyPage.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(77, 103);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(133, 38);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "Potwierdzić";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Visible = false;
            this.OKButton.Click += new System.EventHandler(this.OK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(27, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Budżet na dziś:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pozostało pieniędzy:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wydane:";
            // 
            // SpentTextBox
            // 
            this.SpentTextBox.Location = new System.Drawing.Point(21, 67);
            this.SpentTextBox.Name = "SpentTextBox";
            this.SpentTextBox.Size = new System.Drawing.Size(251, 29);
            this.SpentTextBox.TabIndex = 1;
            this.SpentTextBox.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.SpentTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_KeyPress);
            // 
            // InputDataPage
            // 
            this.InputDataPage.Controls.Add(this.FinishData);
            this.InputDataPage.Controls.Add(this.StartData);
            this.InputDataPage.Controls.Add(this.SaveChangeButton);
            this.InputDataPage.Controls.Add(this.OtherExpensesTextBox);
            this.InputDataPage.Controls.Add(this.ResidenceTextBox);
            this.InputDataPage.Controls.Add(this.IncomeTextBox);
            this.InputDataPage.Controls.Add(this.label6);
            this.InputDataPage.Controls.Add(this.label5);
            this.InputDataPage.Controls.Add(this.label4);
            this.InputDataPage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputDataPage.Location = new System.Drawing.Point(4, 38);
            this.InputDataPage.Name = "InputDataPage";
            this.InputDataPage.Padding = new System.Windows.Forms.Padding(3);
            this.InputDataPage.Size = new System.Drawing.Size(292, 330);
            this.InputDataPage.TabIndex = 1;
            this.InputDataPage.Text = "Ustawienia";
            this.InputDataPage.UseVisualStyleBackColor = true;
            // 
            // FinishData
            // 
            this.FinishData.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.FinishData.CalendarFont = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FinishData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FinishData.Location = new System.Drawing.Point(161, 28);
            this.FinishData.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.FinishData.Name = "FinishData";
            this.FinishData.Size = new System.Drawing.Size(105, 29);
            this.FinishData.TabIndex = 2;
            // 
            // StartData
            // 
            this.StartData.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.StartData.CalendarFont = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartData.Location = new System.Drawing.Point(27, 28);
            this.StartData.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.StartData.Name = "StartData";
            this.StartData.Size = new System.Drawing.Size(105, 29);
            this.StartData.TabIndex = 1;
            // 
            // SaveChangeButton
            // 
            this.SaveChangeButton.Location = new System.Drawing.Point(67, 272);
            this.SaveChangeButton.Name = "SaveChangeButton";
            this.SaveChangeButton.Size = new System.Drawing.Size(166, 45);
            this.SaveChangeButton.TabIndex = 6;
            this.SaveChangeButton.Text = "Zapisz";
            this.SaveChangeButton.UseVisualStyleBackColor = true;
            this.SaveChangeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // OtherExpensesTextBox
            // 
            this.OtherExpensesTextBox.Location = new System.Drawing.Point(27, 231);
            this.OtherExpensesTextBox.Name = "OtherExpensesTextBox";
            this.OtherExpensesTextBox.Size = new System.Drawing.Size(239, 29);
            this.OtherExpensesTextBox.TabIndex = 5;
            this.OtherExpensesTextBox.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.OtherExpensesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_KeyPress);
            // 
            // ResidenceTextBox
            // 
            this.ResidenceTextBox.Location = new System.Drawing.Point(27, 170);
            this.ResidenceTextBox.Name = "ResidenceTextBox";
            this.ResidenceTextBox.Size = new System.Drawing.Size(239, 29);
            this.ResidenceTextBox.TabIndex = 4;
            this.ResidenceTextBox.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.ResidenceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_KeyPress);
            // 
            // IncomeTextBox
            // 
            this.IncomeTextBox.Location = new System.Drawing.Point(27, 96);
            this.IncomeTextBox.Name = "IncomeTextBox";
            this.IncomeTextBox.Size = new System.Drawing.Size(239, 29);
            this.IncomeTextBox.TabIndex = 3;
            this.IncomeTextBox.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.IncomeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(31, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 26);
            this.label6.TabIndex = 2;
            this.label6.Text = "Inne koszty:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(31, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "Wydatki na noczlegi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(31, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Dochód:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "ver. 0.19";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.toolStripMenuItem1.Text = "O programie";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(324, 441);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kierowanie własnym budżetem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.MinusMoneyPage.ResumeLayout(false);
            this.MinusMoneyPage.PerformLayout();
            this.InputDataPage.ResumeLayout(false);
            this.InputDataPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaProgramyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startWithWindowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MinusMoneyPage;
        private System.Windows.Forms.TabPage InputDataPage;
        private System.Windows.Forms.TextBox SpentTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveChangeButton;
        private System.Windows.Forms.TextBox OtherExpensesTextBox;
        private System.Windows.Forms.TextBox ResidenceTextBox;
        private System.Windows.Forms.TextBox IncomeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.DateTimePicker FinishData;
        private System.Windows.Forms.DateTimePicker StartData;
        private System.Windows.Forms.ToolStripMenuItem usunąćWszystkieDaneToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

