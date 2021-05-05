
namespace ControlSystem
{
    partial class Logged
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
            this.PasswControlPanel = new System.Windows.Forms.Panel();
            this.NewPassButton = new System.Windows.Forms.Button();
            this.UpdatePassButton = new System.Windows.Forms.Button();
            this.FindPassButton = new System.Windows.Forms.Button();
            this.DeletePassButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PasswControlPanel
            // 
            this.PasswControlPanel.Location = new System.Drawing.Point(216, 12);
            this.PasswControlPanel.Name = "PasswControlPanel";
            this.PasswControlPanel.Size = new System.Drawing.Size(572, 426);
            this.PasswControlPanel.TabIndex = 0;
            // 
            // NewPassButton
            // 
            this.NewPassButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewPassButton.Location = new System.Drawing.Point(12, 53);
            this.NewPassButton.Name = "NewPassButton";
            this.NewPassButton.Size = new System.Drawing.Size(198, 40);
            this.NewPassButton.TabIndex = 1;
            this.NewPassButton.Text = "New password";
            this.NewPassButton.UseVisualStyleBackColor = true;
            this.NewPassButton.Click += new System.EventHandler(this.NewPassButton_Click);
            // 
            // UpdatePassButton
            // 
            this.UpdatePassButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdatePassButton.Location = new System.Drawing.Point(12, 99);
            this.UpdatePassButton.Name = "UpdatePassButton";
            this.UpdatePassButton.Size = new System.Drawing.Size(198, 40);
            this.UpdatePassButton.TabIndex = 2;
            this.UpdatePassButton.Text = "Update password";
            this.UpdatePassButton.UseVisualStyleBackColor = true;
            this.UpdatePassButton.Click += new System.EventHandler(this.UpdatePassButton_Click);
            // 
            // FindPassButton
            // 
            this.FindPassButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FindPassButton.Location = new System.Drawing.Point(12, 145);
            this.FindPassButton.Name = "FindPassButton";
            this.FindPassButton.Size = new System.Drawing.Size(198, 40);
            this.FindPassButton.TabIndex = 3;
            this.FindPassButton.Text = "Find password";
            this.FindPassButton.UseVisualStyleBackColor = true;
            this.FindPassButton.Click += new System.EventHandler(this.FindPassButton_Click);
            // 
            // DeletePassButton
            // 
            this.DeletePassButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeletePassButton.Location = new System.Drawing.Point(12, 191);
            this.DeletePassButton.Name = "DeletePassButton";
            this.DeletePassButton.Size = new System.Drawing.Size(198, 40);
            this.DeletePassButton.TabIndex = 4;
            this.DeletePassButton.Text = "Delete password";
            this.DeletePassButton.UseVisualStyleBackColor = true;
            this.DeletePassButton.Click += new System.EventHandler(this.DeletePassButton_Click);
            // 
            // Logged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeletePassButton);
            this.Controls.Add(this.FindPassButton);
            this.Controls.Add(this.UpdatePassButton);
            this.Controls.Add(this.NewPassButton);
            this.Controls.Add(this.PasswControlPanel);
            this.Name = "Logged";
            this.Text = "Logged";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PasswControlPanel;
        private System.Windows.Forms.Button NewPassButton;
        private System.Windows.Forms.Button UpdatePassButton;
        private System.Windows.Forms.Button FindPassButton;
        private System.Windows.Forms.Button DeletePassButton;
    }
}