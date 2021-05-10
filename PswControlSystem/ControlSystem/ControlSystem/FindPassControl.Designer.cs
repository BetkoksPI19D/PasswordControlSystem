
namespace ControlSystem
{
    partial class FindPassControl
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
            this.FindPswView = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowAllPassButton = new System.Windows.Forms.Button();
            this.ShowByNameButton = new System.Windows.Forms.Button();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FindPswView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(242, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Find password";
            // 
            // FindPswView
            // 
            this.FindPswView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FindPswView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Password,
            this.URL,
            this.Comment});
            this.FindPswView.Location = new System.Drawing.Point(17, 115);
            this.FindPswView.Name = "FindPswView";
            this.FindPswView.RowHeadersWidth = 51;
            this.FindPswView.RowTemplate.Height = 29;
            this.FindPswView.Size = new System.Drawing.Size(554, 219);
            this.FindPswView.TabIndex = 3;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.Width = 125;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.Width = 125;
            // 
            // URL
            // 
            this.URL.HeaderText = "URL";
            this.URL.MinimumWidth = 6;
            this.URL.Name = "URL";
            this.URL.Width = 125;
            // 
            // Comment
            // 
            this.Comment.HeaderText = "Comment";
            this.Comment.MinimumWidth = 6;
            this.Comment.Name = "Comment";
            this.Comment.Width = 125;
            // 
            // ShowAllPassButton
            // 
            this.ShowAllPassButton.Location = new System.Drawing.Point(17, 43);
            this.ShowAllPassButton.Name = "ShowAllPassButton";
            this.ShowAllPassButton.Size = new System.Drawing.Size(103, 29);
            this.ShowAllPassButton.TabIndex = 4;
            this.ShowAllPassButton.Text = "Show all";
            this.ShowAllPassButton.UseVisualStyleBackColor = true;
            this.ShowAllPassButton.Click += new System.EventHandler(this.ShowAllPassButton_Click);
            // 
            // ShowByNameButton
            // 
            this.ShowByNameButton.Location = new System.Drawing.Point(17, 80);
            this.ShowByNameButton.Name = "ShowByNameButton";
            this.ShowByNameButton.Size = new System.Drawing.Size(103, 29);
            this.ShowByNameButton.TabIndex = 5;
            this.ShowByNameButton.Text = "By username";
            this.ShowByNameButton.UseVisualStyleBackColor = true;
            this.ShowByNameButton.Click += new System.EventHandler(this.ShowByNameButton_Click);
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(126, 82);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(133, 27);
            this.UsernameBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Copy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FindPassControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.ShowByNameButton);
            this.Controls.Add(this.ShowAllPassButton);
            this.Controls.Add(this.FindPswView);
            this.Controls.Add(this.label1);
            this.Name = "FindPassControl";
            this.Size = new System.Drawing.Size(590, 426);
            ((System.ComponentModel.ISupportInitialize)(this.FindPswView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView FindPswView;
        private System.Windows.Forms.Button ShowAllPassButton;
        private System.Windows.Forms.Button ShowByNameButton;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
    }
}
