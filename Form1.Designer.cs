namespace WindowsFormsApplication2
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
            this.loginButton = new System.Windows.Forms.Button();
            this.loginTb = new System.Windows.Forms.TextBox();
            this.loginPb = new System.Windows.Forms.ProgressBar();
            this.passwordPb = new System.Windows.Forms.ProgressBar();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(93, 214);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(79, 25);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginTb
            // 
            this.loginTb.Location = new System.Drawing.Point(84, 12);
            this.loginTb.MaxLength = 15;
            this.loginTb.Name = "loginTb";
            this.loginTb.Size = new System.Drawing.Size(100, 20);
            this.loginTb.TabIndex = 1;
            this.loginTb.TextChanged += new System.EventHandler(this.loginTb_TextChanged);
            // 
            // loginPb
            // 
            this.loginPb.Location = new System.Drawing.Point(84, 39);
            this.loginPb.Maximum = 15;
            this.loginPb.Name = "loginPb";
            this.loginPb.Size = new System.Drawing.Size(100, 14);
            this.loginPb.TabIndex = 2;
            // 
            // passwordPb
            // 
            this.passwordPb.Location = new System.Drawing.Point(84, 102);
            this.passwordPb.Maximum = 16;
            this.passwordPb.Name = "passwordPb";
            this.passwordPb.Size = new System.Drawing.Size(100, 14);
            this.passwordPb.TabIndex = 4;
            // 
            // passwordTb
            // 
            this.passwordTb.Location = new System.Drawing.Point(84, 75);
            this.passwordTb.MaxLength = 16;
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.PasswordChar = '*';
            this.passwordTb.Size = new System.Drawing.Size(100, 20);
            this.passwordTb.TabIndex = 3;
            this.passwordTb.TextChanged += new System.EventHandler(this.passwordTb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Registration";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordPb);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.loginPb);
            this.Controls.Add(this.loginTb);
            this.Controls.Add(this.loginButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "DSADSA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox loginTb;
        private System.Windows.Forms.ProgressBar loginPb;
        private System.Windows.Forms.ProgressBar passwordPb;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

