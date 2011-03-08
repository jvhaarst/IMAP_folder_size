using System.Windows.Forms;
using System;

namespace IMAP_folder_size {
    public partial class FormIMAPFolderSize : Form {
        public FormIMAPFolderSize() {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, System.EventArgs e) {
            // Is er geen databinding ding hiervoor ?
            Configuration config = new Configuration();
            config.Username = textBoxUsername.Text;
            config.Password = textBoxPassword.Text;
            config.Server = textBoxServer.Text;
            config.Port = Convert.ToInt16(textBoxPort.Text);
            // Focus op Output Tab
            // Selects tabPage2 using SelectedTab.
            //this.tabControl1.SelectedTab = tabPage2;
            tabControl1.SelectedTab = tabPageOutput;
            textBoxOutput.Text= String.Format("{0}{1}{2}{3}{4}{5}{6}{7}"
                , config.Username
                , Environment.NewLine
                , config.Password
                , Environment.NewLine
                , config.Server
                , Environment.NewLine
                , config.Port
                , Environment.NewLine                
                );
        }

        private void FormIMAPFolderSize_FormClosing(object sender, FormClosingEventArgs e) {
            System.Console.WriteLine("Closing Form");
            System.Console.WriteLine(textBoxUsername.Text);
            System.Console.WriteLine(textBoxPassword.Text);
            System.Console.WriteLine(textBoxServer.Text);
            System.Console.WriteLine(textBoxPort.Text);

        }

    }
}
