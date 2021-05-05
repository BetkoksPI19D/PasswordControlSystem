
namespace ControlSystem
{
    partial class UpdatePassControl
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
            this.ShowAllPassButton = new System.Windows.Forms.Button();
            this.ShowAllPassList = new System.Windows.Forms.ListView();
            this.Username = new System.Windows.Forms.ColumnHeader();
            this.Password = new System.Windows.Forms.ColumnHeader();
            this.URL = new System.Windows.Forms.ColumnHeader();
            this.Comment = new System.Windows.Forms.ColumnHeader();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(198, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Update password";
            // 
            // ShowAllPassButton
            // 
            this.ShowAllPassButton.Location = new System.Drawing.Point(21, 77);
            this.ShowAllPassButton.Name = "ShowAllPassButton";
            this.ShowAllPassButton.Size = new System.Drawing.Size(94, 29);
            this.ShowAllPassButton.TabIndex = 3;
            this.ShowAllPassButton.Text = "Show all";
            this.ShowAllPassButton.UseVisualStyleBackColor = true;
            // 
            // ShowAllPassList
            // 
            this.ShowAllPassList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Username,
            this.Password,
            this.URL,
            this.Comment});
            this.ShowAllPassList.GridLines = true;
            this.ShowAllPassList.HideSelection = false;
            this.ShowAllPassList.Location = new System.Drawing.Point(21, 112);
            this.ShowAllPassList.Name = "ShowAllPassList";
            this.ShowAllPassList.Size = new System.Drawing.Size(530, 104);
            this.ShowAllPassList.TabIndex = 5;
            this.ShowAllPassList.UseCompatibleStateImageBehavior = false;
            this.ShowAllPassList.View = System.Windows.Forms.View.Details;
            // 
            // Username
            // 
            this.Username.Text = "Username";
            this.Username.Width = 100;
            // 
            // Password
            // 
            this.Password.Text = "Password";
            this.Password.Width = 100;
            // 
            // URL
            // 
            this.URL.Text = "URL";
            this.URL.Width = 150;
            // 
            // Comment
            // 
            this.Comment.Text = "Comment";
            this.Comment.Width = 175;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateButton.Location = new System.Drawing.Point(438, 222);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(113, 32);
            this.UpdateButton.TabIndex = 10;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // UpdatePassControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.ShowAllPassList);
            this.Controls.Add(this.ShowAllPassButton);
            this.Controls.Add(this.label1);
            this.Name = "UpdatePassControl";
            this.Size = new System.Drawing.Size(572, 328);
            this.Load += new System.EventHandler(this.UpdatePassControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowAllPassButton;
        private System.Windows.Forms.Button UpdatePassButton;
        private System.Windows.Forms.ListView ShowAllPassList;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.ColumnHeader URL;
        private System.Windows.Forms.ColumnHeader Comment;
        private System.Windows.Forms.Button UpdateButton;
    }
}
