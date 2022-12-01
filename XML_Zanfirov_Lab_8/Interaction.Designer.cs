namespace XML_Zanfirov_Lab_8
{
    partial class Interaction
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
            this.InputInteractionTextbox = new System.Windows.Forms.TextBox();
            this.OkInteractionButton = new System.Windows.Forms.Button();
            this.TitleInteractionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputInteractionTextbox
            // 
            this.InputInteractionTextbox.Location = new System.Drawing.Point(46, 67);
            this.InputInteractionTextbox.Name = "InputInteractionTextbox";
            this.InputInteractionTextbox.Size = new System.Drawing.Size(208, 23);
            this.InputInteractionTextbox.TabIndex = 0;
            // 
            // OkInteractionButton
            // 
            this.OkInteractionButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkInteractionButton.Location = new System.Drawing.Point(46, 110);
            this.OkInteractionButton.Name = "OkInteractionButton";
            this.OkInteractionButton.Size = new System.Drawing.Size(208, 49);
            this.OkInteractionButton.TabIndex = 1;
            this.OkInteractionButton.Text = "button1";
            this.OkInteractionButton.UseVisualStyleBackColor = true;
            // 
            // TitleInteractionLabel
            // 
            this.TitleInteractionLabel.AutoSize = true;
            this.TitleInteractionLabel.Location = new System.Drawing.Point(46, 32);
            this.TitleInteractionLabel.Name = "TitleInteractionLabel";
            this.TitleInteractionLabel.Size = new System.Drawing.Size(38, 15);
            this.TitleInteractionLabel.TabIndex = 2;
            this.TitleInteractionLabel.Text = "label1";
            // 
            // Interaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 171);
            this.Controls.Add(this.TitleInteractionLabel);
            this.Controls.Add(this.OkInteractionButton);
            this.Controls.Add(this.InputInteractionTextbox);
            this.Name = "Interaction";
            this.Text = "Interaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button OkInteractionButton;
        private Label TitleInteractionLabel;
        public TextBox InputInteractionTextbox;
    }
}