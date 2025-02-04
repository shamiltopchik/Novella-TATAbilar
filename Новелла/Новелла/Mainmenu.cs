using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Новелла
{
    public partial class Mainmenu : Form
    {
        public Mainmenu()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void Play_Click(object sender, EventArgs e)
        {
            var form2 = new Play();
            form2.Show();
        }
    }
}
