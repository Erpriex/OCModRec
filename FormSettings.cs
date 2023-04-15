using System;
using System.Windows.Forms;

namespace OCModRec {
    public partial class FormSettings : Form {

        private FormMain main;

        public FormSettings(FormMain main) {
            this.main = main;
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e) {
            sourceDirectoryTextbox.Text = Properties.Settings.Default.sourceDirectory;
            targetDirectoryTextbox.Text = Properties.Settings.Default.targetDirectory;
        }

        private void submitButton_Click(object sender, EventArgs e) {
            string sourceDirectoryInput = sourceDirectoryTextbox.Text.Trim();
            string targetDirectoryInput = targetDirectoryTextbox.Text.Trim();

            if(sourceDirectoryInput.Length == 0 || targetDirectoryInput.Length == 0) {
                MessageBox.Show("Merci de remplir les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Properties.Settings.Default.sourceDirectory = sourceDirectoryTextbox.Text.Trim();
            Properties.Settings.Default.targetDirectory = targetDirectoryTextbox.Text.Trim();
            Properties.Settings.Default.Save();
            MessageBox.Show("Les paramètres ont été enregistrés avec succès !", "Paramètres enregistrés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            main.unlockForm();
            this.Close();
        }
    }
}
