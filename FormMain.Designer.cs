namespace OCModRec
{
    partial class FormMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.commandInputLabel = new System.Windows.Forms.Label();
            this.formTitleLabel = new System.Windows.Forms.Label();
            this.commandInputTextBox = new System.Windows.Forms.TextBox();
            this.violationInputButton = new System.Windows.Forms.Button();
            this.clearRecordsButton = new System.Windows.Forms.Button();
            this.recMoveProgressBar = new System.Windows.Forms.ProgressBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.lockFormLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // commandInputLabel
            // 
            this.commandInputLabel.AutoSize = true;
            this.commandInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandInputLabel.Location = new System.Drawing.Point(28, 148);
            this.commandInputLabel.Name = "commandInputLabel";
            this.commandInputLabel.Size = new System.Drawing.Size(121, 25);
            this.commandInputLabel.TabIndex = 0;
            this.commandInputLabel.Text = "Commande";
            // 
            // formTitleLabel
            // 
            this.formTitleLabel.AutoSize = true;
            this.formTitleLabel.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitleLabel.Location = new System.Drawing.Point(113, 44);
            this.formTitleLabel.Name = "formTitleLabel";
            this.formTitleLabel.Size = new System.Drawing.Size(228, 64);
            this.formTitleLabel.TabIndex = 1;
            this.formTitleLabel.Text = "OCModRec";
            // 
            // commandInputTextBox
            // 
            this.commandInputTextBox.Location = new System.Drawing.Point(150, 152);
            this.commandInputTextBox.Name = "commandInputTextBox";
            this.commandInputTextBox.Size = new System.Drawing.Size(247, 20);
            this.commandInputTextBox.TabIndex = 2;
            // 
            // violationInputButton
            // 
            this.violationInputButton.Location = new System.Drawing.Point(322, 192);
            this.violationInputButton.Name = "violationInputButton";
            this.violationInputButton.Size = new System.Drawing.Size(75, 23);
            this.violationInputButton.TabIndex = 3;
            this.violationInputButton.Text = "Insérer";
            this.violationInputButton.UseVisualStyleBackColor = true;
            this.violationInputButton.Click += new System.EventHandler(this.violationInputButton_Click);
            // 
            // clearRecordsButton
            // 
            this.clearRecordsButton.Location = new System.Drawing.Point(33, 250);
            this.clearRecordsButton.Name = "clearRecordsButton";
            this.clearRecordsButton.Size = new System.Drawing.Size(105, 23);
            this.clearRecordsButton.TabIndex = 4;
            this.clearRecordsButton.Text = "Effacer les recs";
            this.clearRecordsButton.UseVisualStyleBackColor = true;
            this.clearRecordsButton.Click += new System.EventHandler(this.clearRecordsButton_Click);
            // 
            // recMoveProgressBar
            // 
            this.recMoveProgressBar.Location = new System.Drawing.Point(202, 250);
            this.recMoveProgressBar.Name = "recMoveProgressBar";
            this.recMoveProgressBar.Size = new System.Drawing.Size(195, 23);
            this.recMoveProgressBar.TabIndex = 5;
            this.recMoveProgressBar.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(459, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(86, 22);
            this.toolStripButton1.Text = "Paramètres";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // lockFormLabel
            // 
            this.lockFormLabel.AutoSize = true;
            this.lockFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lockFormLabel.ForeColor = System.Drawing.Color.Red;
            this.lockFormLabel.Location = new System.Drawing.Point(117, 116);
            this.lockFormLabel.Name = "lockFormLabel";
            this.lockFormLabel.Size = new System.Drawing.Size(218, 16);
            this.lockFormLabel.TabIndex = 7;
            this.lockFormLabel.Text = "/!\\ Veuillez définir vos paramètres /!\\";
            this.lockFormLabel.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 285);
            this.Controls.Add(this.lockFormLabel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.recMoveProgressBar);
            this.Controls.Add(this.clearRecordsButton);
            this.Controls.Add(this.violationInputButton);
            this.Controls.Add(this.commandInputTextBox);
            this.Controls.Add(this.formTitleLabel);
            this.Controls.Add(this.commandInputLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "OCModRec";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label commandInputLabel;
        private System.Windows.Forms.Label formTitleLabel;
        private System.Windows.Forms.TextBox commandInputTextBox;
        private System.Windows.Forms.Button violationInputButton;
        private System.Windows.Forms.Button clearRecordsButton;
        private System.Windows.Forms.ProgressBar recMoveProgressBar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label lockFormLabel;
    }
}

