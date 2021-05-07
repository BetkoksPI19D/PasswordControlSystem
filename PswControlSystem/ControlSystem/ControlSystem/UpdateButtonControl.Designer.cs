
namespace ControlSystem
{
    partial class UpdateButtonControl
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
            this.NewPassBox = new System.Windows.Forms.TextBox();
            this.NewPass = new System.Windows.Forms.Label();
            this.DoneUpdateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NewPassConfirmBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NewPassBox
            // 
            this.NewPassBox.Location = new System.Drawing.Point(138, 17);
            this.NewPassBox.Name = "NewPassBox";
            this.NewPassBox.Size = new System.Drawing.Size(182, 27);
            this.NewPassBox.TabIndex = 0;
            // 
            // NewPass
            // 
            this.NewPass.AutoSize = true;
            this.NewPass.Location = new System.Drawing.Point(23, 20);
            this.NewPass.Name = "NewPass";
            this.NewPass.Size = new System.Drawing.Size(109, 20);
            this.NewPass.TabIndex = 1;
            this.NewPass.Text = "New password:";
            // 
            // DoneUpdateButton
            // 
            this.DoneUpdateButton.Location = new System.Drawing.Point(244, 90);
            this.DoneUpdateButton.Name = "DoneUpdateButton";
            this.DoneUpdateButton.Size = new System.Drawing.Size(94, 29);
            this.DoneUpdateButton.TabIndex = 2;
            this.DoneUpdateButton.Text = "Done";
            this.DoneUpdateButton.UseVisualStyleBackColor = true;
            this.DoneUpdateButton.Click += new System.EventHandler(this.DoneUpdateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Confirm password:";
            // 
            // NewPassConfirmBox
            // 
            this.NewPassConfirmBox.Location = new System.Drawing.Point(138, 50);
            this.NewPassConfirmBox.Name = "NewPassConfirmBox";
            this.NewPassConfirmBox.Size = new System.Drawing.Size(182, 27);
            this.NewPassConfirmBox.TabIndex = 4;
            // 
            // UpdateButtonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NewPassConfirmBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DoneUpdateButton);
            this.Controls.Add(this.NewPass);
            this.Controls.Add(this.NewPassBox);
            this.Name = "UpdateButtonControl";
            this.Size = new System.Drawing.Size(338, 119);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewPassBox;
        private System.Windows.Forms.Label NewPass;
        private System.Windows.Forms.Button DoneUpdateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewPassConfirmBox;
    }
}
