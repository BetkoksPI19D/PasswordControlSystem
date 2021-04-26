
namespace ControlSystem
{
    partial class SignUpControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SignUpButtonInControl = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordSignUpBox = new System.Windows.Forms.TextBox();
            this.UsernameSignUpBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComfirmPassSignUpBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SignUpButtonInControl
            // 
            this.SignUpButtonInControl.Location = new System.Drawing.Point(204, 162);
            this.SignUpButtonInControl.Name = "SignUpButtonInControl";
            this.SignUpButtonInControl.Size = new System.Drawing.Size(94, 29);
            this.SignUpButtonInControl.TabIndex = 1;
            this.SignUpButtonInControl.Text = "Sign up";
            this.SignUpButtonInControl.UseVisualStyleBackColor = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(63, 79);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(73, 20);
            this.PasswordLabel.TabIndex = 8;
            this.PasswordLabel.Text = "Password:";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(58, 46);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(78, 20);
            this.UsernameLabel.TabIndex = 7;
            this.UsernameLabel.Text = "Username:";
            // 
            // PasswordSignUpBox
            // 
            this.PasswordSignUpBox.Location = new System.Drawing.Point(142, 76);
            this.PasswordSignUpBox.Name = "PasswordSignUpBox";
            this.PasswordSignUpBox.Size = new System.Drawing.Size(156, 27);
            this.PasswordSignUpBox.TabIndex = 6;
            // 
            // UsernameSignUpBox
            // 
            this.UsernameSignUpBox.Location = new System.Drawing.Point(142, 43);
            this.UsernameSignUpBox.Name = "UsernameSignUpBox";
            this.UsernameSignUpBox.Size = new System.Drawing.Size(156, 27);
            this.UsernameSignUpBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Confirm Password:";
            // 
            // ComfirmPassSignUpBox
            // 
            this.ComfirmPassSignUpBox.Location = new System.Drawing.Point(142, 109);
            this.ComfirmPassSignUpBox.Name = "ComfirmPassSignUpBox";
            this.ComfirmPassSignUpBox.Size = new System.Drawing.Size(156, 27);
            this.ComfirmPassSignUpBox.TabIndex = 9;
            // 
            // SignUpControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComfirmPassSignUpBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.PasswordSignUpBox);
            this.Controls.Add(this.UsernameSignUpBox);
            this.Controls.Add(this.SignUpButtonInControl);
            this.Name = "SignUpControl";
            this.Size = new System.Drawing.Size(298, 191);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignUpButtonInControl;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox PasswordSignUpBox;
        private System.Windows.Forms.TextBox UsernameSignUpBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ComfirmPassSignUpBox;
    }
}
