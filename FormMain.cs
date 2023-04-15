using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCModRec {
    public partial class FormMain : Form {
        public FormMain() {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e) {
            if (Properties.Settings.Default.sourceDirectory == "" || Properties.Settings.Default.targetDirectory == "") {
                lockForm();
                MessageBox.Show("Veuillez définir vos paramètres pour utiliser l'application", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void lockForm() {
            commandInputTextBox.Enabled = false;
            violationInputButton.Enabled = false;
            clearRecordsButton.Enabled = false;
            lockFormLabel.Visible = true;
        }
        public void unlockForm() {
            commandInputTextBox.Enabled = true;
            violationInputButton.Enabled = true;
            clearRecordsButton.Enabled = true;
            lockFormLabel.Visible = false;
        }

        private async void violationInputButton_Click(object sender, EventArgs e) {
            String commandInput = commandInputTextBox.Text;
            if(commandInput == "") {
                MessageBox.Show("Aucune commande de sanction saisie !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (commandInput.StartsWith("/")) {
                commandInput = commandInput.Substring(1);
            }

            commandInput = commandInput.Trim();

            String[] commandInputArgs = commandInput.Split(' ');

            if(commandInputArgs.Length < 4) {
                MessageBox.Show("Tous les arguments de la commande n'ont pas été saisis", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!commandInputArgs[0].StartsWith("zban")) {
                MessageBox.Show("La sanction doit être un ban !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String playerName = commandInputArgs[1];
            String duration = commandInputArgs[2];
            String reason = "";

            for(int i = 3; i < commandInputArgs.Length; i++) {
                reason += commandInputArgs[i] + ' ';
            }
            reason = reason.Trim();


            DateTime currentDate = DateTime.Now;

            String finalTargetDirectory = Properties.Settings.Default.targetDirectory + @"\" + currentDate.Year + @"\" + currentDate.Month + @"\" + currentDate.Day + @"\" + playerName + "_" + reason.Replace(' ', '-').Trim() + @"\";
            Directory.CreateDirectory(Path.GetDirectoryName(finalTargetDirectory));

            DirectoryInfo sourceDirectory = new DirectoryInfo(Properties.Settings.Default.sourceDirectory);

            FileInfo[] files = sourceDirectory.GetFiles();
            if(files.Length > 0) {
                recMoveProgressBar.Value = 0;
                recMoveProgressBar.Visible = true;
                recMoveProgressBar.Maximum = files.Length;
            }
            violationInputButton.Enabled = false;
            commandInputTextBox.Enabled = false;
            clearRecordsButton.Enabled = false;

            foreach (FileInfo file in files) {
                await Task.Run(() => {
                    string destinationFilePath = Path.Combine(finalTargetDirectory, file.Name);
                    file.MoveTo(destinationFilePath);
                    recMoveProgressBar.Invoke((MethodInvoker)delegate { recMoveProgressBar.Value++; });
                });
            }
            
            recMoveProgressBar.Visible = false;
            violationInputButton.Enabled = true;
            commandInputTextBox.Enabled = true;
            clearRecordsButton.Enabled = true;

            MessageBox.Show("Infraction enregistrée !" + (files.Length > 0 ? "\n" + files.Length + " rec(s) enregistré(s)" : ""), "Infraction enregistrée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            commandInputTextBox.Text = "";
        }

        private void clearRecordsButton_Click(object sender, EventArgs e) {
            string[] files = Directory.GetFiles(Properties.Settings.Default.sourceDirectory);
            foreach (string file in files) {
                File.Delete(file);
            }
            MessageBox.Show("Les recs ont été supprimés !", "Enregistrements supprimés", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButton1_Click(object sender, EventArgs e) {
            FormSettings formSettings = new FormSettings(this);
            formSettings.Show();
        }
    }
}
