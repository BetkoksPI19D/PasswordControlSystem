
namespace ControlSystem
{
    partial class NewPassControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UsrnameBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.URLBox = new System.Windows.Forms.TextBox();
            this.CommentBox = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.RandomPassButton = new System.Windows.Forms.Button();
            this.ShowPassButton = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(252, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "New password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "URL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Comment: ";
            // 
            // UsrnameBox
            // 
            this.UsrnameBox.Location = new System.Drawing.Point(202, 88);
            this.UsrnameBox.Name = "UsrnameBox";
            this.UsrnameBox.Size = new System.Drawing.Size(232, 27);
            this.UsrnameBox.TabIndex = 5;
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(202, 121);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(232, 27);
            this.PassBox.TabIndex = 6;
            // 
            // URLBox
            // 
            this.URLBox.Location = new System.Drawing.Point(202, 190);
            this.URLBox.Name = "URLBox";
            this.URLBox.Size = new System.Drawing.Size(232, 27);
            this.URLBox.TabIndex = 7;
            // 
            // CommentBox
            // 
            this.CommentBox.Location = new System.Drawing.Point(202, 223);
            this.CommentBox.Name = "CommentBox";
            this.CommentBox.Size = new System.Drawing.Size(232, 27);
            this.CommentBox.TabIndex = 8;
            // 
            // CreateButton
            // 
            this.CreateButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateButton.Location = new System.Drawing.Point(350, 291);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(113, 32);
            this.CreateButton.TabIndex = 9;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // RandomPassButton
            // 
            this.RandomPassButton.Location = new System.Drawing.Point(440, 119);
            this.RandomPassButton.Name = "RandomPassButton";
            this.RandomPassButton.Size = new System.Drawing.Size(46, 29);
            this.RandomPassButton.TabIndex = 10;
            this.RandomPassButton.Text = "🎲";
            this.RandomPassButton.UseVisualStyleBackColor = true;
            this.RandomPassButton.Click += new System.EventHandler(this.RandomPassButton_Click);
            // 
            // ShowPassButton
            // 
            this.ShowPassButton.AutoSize = true;
            this.ShowPassButton.Location = new System.Drawing.Point(367, 154);
            this.ShowPassButton.Name = "ShowPassButton";
            this.ShowPassButton.Size = new System.Drawing.Size(67, 24);
            this.ShowPassButton.TabIndex = 11;
            this.ShowPassButton.Text = "Show";
            this.ShowPassButton.UseVisualStyleBackColor = true;
            this.ShowPassButton.CheckedChanged += new System.EventHandler(this.ShowPassButton_CheckedChanged);
            // 
            // NewPassControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ShowPassButton);
            this.Controls.Add(this.RandomPassButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.CommentBox);
            this.Controls.Add(this.URLBox);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.UsrnameBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewPassControl";
            this.Size = new System.Drawing.Size(590, 426);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UsrnameBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.TextBox URLBox;
        private System.Windows.Forms.TextBox CommentBox;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button RandomPassButton;
        private System.Windows.Forms.CheckBox ShowPassButton;
    }
}
