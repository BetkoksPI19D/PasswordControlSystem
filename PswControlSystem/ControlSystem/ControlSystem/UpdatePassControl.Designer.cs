
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
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ShowPassView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.ShowPassBox = new System.Windows.Forms.CheckBox();
            this.ControllerForUpdatePass = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPassView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(228, 10);
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
            this.ShowAllPassButton.Click += new System.EventHandler(this.ShowAllPassButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateButton.Location = new System.Drawing.Point(462, 295);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(113, 32);
            this.UpdateButton.TabIndex = 10;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ShowPassView
            // 
            this.ShowPassView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowPassView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.ShowPassView.Location = new System.Drawing.Point(21, 112);
            this.ShowPassView.Name = "ShowPassView";
            this.ShowPassView.RowHeadersWidth = 51;
            this.ShowPassView.RowTemplate.Height = 29;
            this.ShowPassView.Size = new System.Drawing.Size(554, 177);
            this.ShowPassView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Username";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Password";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "URL";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Comment";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Copy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowPassBox
            // 
            this.ShowPassBox.AutoSize = true;
            this.ShowPassBox.Location = new System.Drawing.Point(508, 82);
            this.ShowPassBox.Name = "ShowPassBox";
            this.ShowPassBox.Size = new System.Drawing.Size(67, 24);
            this.ShowPassBox.TabIndex = 13;
            this.ShowPassBox.Text = "Show";
            this.ShowPassBox.UseVisualStyleBackColor = true;
            // 
            // ControllerForUpdatePass
            // 
            this.ControllerForUpdatePass.Location = new System.Drawing.Point(21, 295);
            this.ControllerForUpdatePass.Name = "ControllerForUpdatePass";
            this.ControllerForUpdatePass.Size = new System.Drawing.Size(338, 119);
            this.ControllerForUpdatePass.TabIndex = 14;
            // 
            // UpdatePassControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ControllerForUpdatePass);
            this.Controls.Add(this.ShowPassBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShowPassView);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.ShowAllPassButton);
            this.Controls.Add(this.label1);
            this.Name = "UpdatePassControl";
            this.Size = new System.Drawing.Size(590, 426);
            ((System.ComponentModel.ISupportInitialize)(this.ShowPassView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowAllPassButton;
        private System.Windows.Forms.Button UpdatePassButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.DataGridView ShowPassView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ShowPassBox;
        private System.Windows.Forms.Panel ControllerForUpdatePass;
    }
}
