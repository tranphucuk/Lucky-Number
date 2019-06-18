namespace LuckyNumber
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblPlayerNumber = new System.Windows.Forms.Label();
            this.lblMoneyBet = new System.Windows.Forms.Label();
            this.lblPlayerCashes = new System.Windows.Forms.Label();
            this.lblComputerCashes = new System.Windows.Forms.Label();
            this.txtPlayerNumber = new System.Windows.Forms.TextBox();
            this.txtMoneyBet = new System.Windows.Forms.TextBox();
            this.txtPlayerCashes = new System.Windows.Forms.TextBox();
            this.txtComputerCashes = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSpin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.lblNumber3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrLuckyNumber = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlayerNumber
            // 
            this.lblPlayerNumber.AutoSize = true;
            this.lblPlayerNumber.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerNumber.Location = new System.Drawing.Point(13, 164);
            this.lblPlayerNumber.Name = "lblPlayerNumber";
            this.lblPlayerNumber.Size = new System.Drawing.Size(117, 19);
            this.lblPlayerNumber.TabIndex = 0;
            this.lblPlayerNumber.Text = "Player\'s Number";
            // 
            // lblMoneyBet
            // 
            this.lblMoneyBet.AutoSize = true;
            this.lblMoneyBet.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneyBet.Location = new System.Drawing.Point(13, 208);
            this.lblMoneyBet.Name = "lblMoneyBet";
            this.lblMoneyBet.Size = new System.Drawing.Size(78, 19);
            this.lblMoneyBet.TabIndex = 0;
            this.lblMoneyBet.Text = "Money Bet";
            // 
            // lblPlayerCashes
            // 
            this.lblPlayerCashes.AutoSize = true;
            this.lblPlayerCashes.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCashes.Location = new System.Drawing.Point(11, 393);
            this.lblPlayerCashes.Name = "lblPlayerCashes";
            this.lblPlayerCashes.Size = new System.Drawing.Size(82, 19);
            this.lblPlayerCashes.TabIndex = 0;
            this.lblPlayerCashes.Text = "Player Cash";
            // 
            // lblComputerCashes
            // 
            this.lblComputerCashes.AutoSize = true;
            this.lblComputerCashes.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerCashes.Location = new System.Drawing.Point(11, 432);
            this.lblComputerCashes.Name = "lblComputerCashes";
            this.lblComputerCashes.Size = new System.Drawing.Size(104, 19);
            this.lblComputerCashes.TabIndex = 0;
            this.lblComputerCashes.Text = "Computer Cash";
            // 
            // txtPlayerNumber
            // 
            this.txtPlayerNumber.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerNumber.Location = new System.Drawing.Point(132, 164);
            this.txtPlayerNumber.Name = "txtPlayerNumber";
            this.txtPlayerNumber.Size = new System.Drawing.Size(240, 26);
            this.txtPlayerNumber.TabIndex = 1;
            this.txtPlayerNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlayerNumber_KeyPress);
            // 
            // txtMoneyBet
            // 
            this.txtMoneyBet.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoneyBet.Location = new System.Drawing.Point(132, 203);
            this.txtMoneyBet.Name = "txtMoneyBet";
            this.txtMoneyBet.Size = new System.Drawing.Size(240, 26);
            this.txtMoneyBet.TabIndex = 1;
            this.txtMoneyBet.TextChanged += new System.EventHandler(this.txtMoneyBet_TextChanged);
            // 
            // txtPlayerCashes
            // 
            this.txtPlayerCashes.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerCashes.Location = new System.Drawing.Point(132, 388);
            this.txtPlayerCashes.Name = "txtPlayerCashes";
            this.txtPlayerCashes.ReadOnly = true;
            this.txtPlayerCashes.Size = new System.Drawing.Size(240, 26);
            this.txtPlayerCashes.TabIndex = 1;
            this.txtPlayerCashes.Text = "100";
            // 
            // txtComputerCashes
            // 
            this.txtComputerCashes.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComputerCashes.Location = new System.Drawing.Point(132, 427);
            this.txtComputerCashes.Name = "txtComputerCashes";
            this.txtComputerCashes.ReadOnly = true;
            this.txtComputerCashes.Size = new System.Drawing.Size(240, 26);
            this.txtComputerCashes.TabIndex = 1;
            this.txtComputerCashes.Text = "1000";
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(12, 481);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(91, 34);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSpin
            // 
            this.btnSpin.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpin.Location = new System.Drawing.Point(110, 481);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(169, 34);
            this.btnSpin.TabIndex = 2;
            this.btnSpin.Text = "Spin";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(285, 481);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 34);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblNumber1
            // 
            this.lblNumber1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblNumber1.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber1.Location = new System.Drawing.Point(13, 247);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(113, 126);
            this.lblNumber1.TabIndex = 0;
            this.lblNumber1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumber2
            // 
            this.lblNumber2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblNumber2.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber2.Location = new System.Drawing.Point(135, 247);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(113, 126);
            this.lblNumber2.TabIndex = 0;
            this.lblNumber2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumber3
            // 
            this.lblNumber3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblNumber3.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber3.Location = new System.Drawing.Point(259, 247);
            this.lblNumber3.Name = "lblNumber3";
            this.lblNumber3.Size = new System.Drawing.Size(113, 126);
            this.lblNumber3.TabIndex = 0;
            this.lblNumber3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::LuckyNumber.Properties.Resources.lucky_numbers_logo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 141);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "copyright © Tran Phuc";
            // 
            // tmrLuckyNumber
            // 
            this.tmrLuckyNumber.Tick += new System.EventHandler(this.tmrLuckyNumber_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 545);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtComputerCashes);
            this.Controls.Add(this.txtPlayerCashes);
            this.Controls.Add(this.txtMoneyBet);
            this.Controls.Add(this.txtPlayerNumber);
            this.Controls.Add(this.lblComputerCashes);
            this.Controls.Add(this.lblPlayerCashes);
            this.Controls.Add(this.lblNumber3);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.lblNumber1);
            this.Controls.Add(this.lblMoneyBet);
            this.Controls.Add(this.lblPlayerNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Lucky Number - Tran Phuc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerNumber;
        private System.Windows.Forms.Label lblMoneyBet;
        private System.Windows.Forms.Label lblPlayerCashes;
        private System.Windows.Forms.Label lblComputerCashes;
        private System.Windows.Forms.TextBox txtPlayerNumber;
        private System.Windows.Forms.TextBox txtMoneyBet;
        private System.Windows.Forms.TextBox txtPlayerCashes;
        private System.Windows.Forms.TextBox txtComputerCashes;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Label lblNumber3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer tmrLuckyNumber;
        private System.Windows.Forms.Label label1;
    }
}

