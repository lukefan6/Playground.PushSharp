using System.Windows.Forms;
using Playground.PushSharp.Core;

namespace Playground.PushSharp.WindowsForm
{
    public partial class Main : Form
    {
        private PushMessageManager Manager { get; set; }

        public Main()
        {
            InitializeComponent();
            Manager = PushMessageManager.Create();
        }

        private void ChooseAppleCertificate_Click(object sender, System.EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Manager.AppleCertificateLocation = openFileDialog.SafeFileName;
                    this.appleCertificateLocation.Text = Manager.AppleCertificateLocation;
                }
            }
        }
    }
}
