
namespace ControlSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SignUpButton = new System.Windows.Forms.Button();
            this.LogInButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MainWindomPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // SignUpButton
            // 
            this.SignUpButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SignUpButton.Location = new System.Drawing.Point(12, 128);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(153, 36);
            this.SignUpButton.TabIndex = 1;
            this.SignUpButton.Text = "Sign up";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // LogInButton
            // 
            this.LogInButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogInButton.Location = new System.Drawing.Point(12, 86);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(153, 36);
            this.LogInButton.TabIndex = 2;
            this.LogInButton.Text = "Log in";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome";
            // 
            // MainWindomPanel
            // 
            this.MainWindomPanel.Location = new System.Drawing.Point(219, 12);
            this.MainWindomPanel.Name = "MainWindomPanel";
            this.MainWindomPanel.Size = new System.Drawing.Size(341, 209);
            this.MainWindomPanel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 233);
            this.Controls.Add(this.MainWindomPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.SignUpButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel MainWindomPanel;
    }
}

