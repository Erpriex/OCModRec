namespace OCModRec
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.formTitleLabel = new System.Windows.Forms.Label();
            this.sourceDirectoryTextbox = new System.Windows.Forms.TextBox();
            this.sourceDirectoryLabel = new System.Windows.Forms.Label();
            this.targetDirectoryTextbox = new System.Windows.Forms.TextBox();
            this.targetDirectoryLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.sourceDirectoryExampleLabel = new System.Windows.Forms.Label();
            this.targetDirectoryExampleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // formTitleLabel
            // 
            this.formTitleLabel.AutoSize = true;
            this.formTitleLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.formTitleLabel.Name = "formTitleLabel";
            this.formTitleLabel.Size = new System.Drawing.Size(127, 33);
            this.formTitleLabel.TabIndex = 0;
            this.formTitleLabel.Text = "Paramètres";
            // 
            // sourceDirectoryTextbox
            // 
            this.sourceDirectoryTextbox.Location = new System.Drawing.Point(98, 65);
            this.sourceDirectoryTextbox.Name = "sourceDirectoryTextbox";
            this.sourceDirectoryTextbox.Size = new System.Drawing.Size(230, 20);
            this.sourceDirectoryTextbox.TabIndex = 1;
            // 
            // sourceDirectoryLabel
            // 
            this.sourceDirectoryLabel.AutoSize = true;
            this.sourceDirectoryLabel.Location = new System.Drawing.Point(15, 68);
            this.sourceDirectoryLabel.Name = "sourceDirectoryLabel";
            this.sourceDirectoryLabel.Size = new System.Drawing.Size(77, 13);
            this.sourceDirectoryLabel.TabIndex = 2;
            this.sourceDirectoryLabel.Text = "Dossier source";
            // 
            // targetDirectoryTextbox
            // 
            this.targetDirectoryTextbox.Location = new System.Drawing.Point(98, 116);
            this.targetDirectoryTextbox.Name = "targetDirectoryTextbox";
            this.targetDirectoryTextbox.Size = new System.Drawing.Size(230, 20);
            this.targetDirectoryTextbox.TabIndex = 3;
            // 
            // targetDirectoryLabel
            // 
            this.targetDirectoryLabel.AutoSize = true;
            this.targetDirectoryLabel.Location = new System.Drawing.Point(15, 119);
            this.targetDirectoryLabel.Name = "targetDirectoryLabel";
            this.targetDirectoryLabel.Size = new System.Drawing.Size(67, 13);
            this.targetDirectoryLabel.TabIndex = 4;
            this.targetDirectoryLabel.Text = "Dossier cible";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(253, 169);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Enregistrer";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // sourceDirectoryExampleLabel
            // 
            this.sourceDirectoryExampleLabel.AutoSize = true;
            this.sourceDirectoryExampleLabel.Location = new System.Drawing.Point(95, 88);
            this.sourceDirectoryExampleLabel.Name = "sourceDirectoryExampleLabel";
            this.sourceDirectoryExampleLabel.Size = new System.Drawing.Size(130, 13);
            this.sourceDirectoryExampleLabel.TabIndex = 6;
            this.sourceDirectoryExampleLabel.Text = "Exemple : D:\\Test\\source";
            // 
            // targetDirectoryExampleLabel
            // 
            this.targetDirectoryExampleLabel.AutoSize = true;
            this.targetDirectoryExampleLabel.Location = new System.Drawing.Point(95, 139);
            this.targetDirectoryExampleLabel.Name = "targetDirectoryExampleLabel";
            this.targetDirectoryExampleLabel.Size = new System.Drawing.Size(125, 13);
            this.targetDirectoryExampleLabel.TabIndex = 7;
            this.targetDirectoryExampleLabel.Text = "Exemple : D:\\Test\\target";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 218);
            this.Controls.Add(this.targetDirectoryExampleLabel);
            this.Controls.Add(this.sourceDirectoryExampleLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.targetDirectoryLabel);
            this.Controls.Add(this.targetDirectoryTextbox);
            this.Controls.Add(this.sourceDirectoryLabel);
            this.Controls.Add(this.sourceDirectoryTextbox);
            this.Controls.Add(this.formTitleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.Text = "Paramètres - OCModRec";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label formTitleLabel;
        private System.Windows.Forms.TextBox sourceDirectoryTextbox;
        private System.Windows.Forms.Label sourceDirectoryLabel;
        private System.Windows.Forms.TextBox targetDirectoryTextbox;
        private System.Windows.Forms.Label targetDirectoryLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label sourceDirectoryExampleLabel;
        private System.Windows.Forms.Label targetDirectoryExampleLabel;
    }
}