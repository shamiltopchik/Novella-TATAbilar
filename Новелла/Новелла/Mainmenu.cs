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
            this.Size = new Size(1024, 728);
            Play.Size = new Size(120, 30);
            Setings.Size = new Size(120, 30);

            button1.Size = new Size(120, 30);
            button1.Location = new Point(900, 660);

            button2.Size = new Size(120, 30);
            button2.Location = new Point(900, 660);

            button3.Size = new Size(120, 30);
            button3.Location = new Point(900, 660);

            button4.Size = new Size(120, 30);
            button4.Location = new Point(900, 660);

            Play.Location = new Point(452, 364);
            Setings.Location = new Point(452, 410);

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;


            text.Size = new Size(900, 50);
            text.Location = new Point(0, 620);
            text.Font = new Font("Times New Roman", 13, FontStyle.Regular);
            //Text.BackColor = System.Drawing.Color.Transparent;
            text.Text = "Лето 2026 Радостный Альмир сидит дома после защиты диплома, " +
                "только учеба отпустила и без того его нелегкую жизнь, только он " +
                "начал задумываться о будущем как вдруг...";
            text.Visible = false;

            text2.AutoSize = true;
            text2.Location = new Point(0, 620);
            text2.Font = new Font("Times New Roman", 13, FontStyle.Regular);
            //Text.BackColor = System.Drawing.Color.Transparent;
            text2.Text = "Стук в дверь";
            text2.Visible = false;

            text3.AutoSize = true;
            text3.Location = new Point(0, 620);
            text3.Font = new Font("Times New Roman", 13, FontStyle.Regular);
            text3.Text = "он спокойно встает и идет к двери";
            text3.Visible = false;

            //text4.AutoSize = true;
            //text4.Location = new Point(0, 620);
            //text4.Font = new Font("Times New Roman", 13, FontStyle.Regular);
            //text4.Text = "он спокойно встает и идет к двери";
            //text4.Visible = false;
        }

        public void Play_Click(object sender, EventArgs e)
        {
            Setings.Visible = false;
            Play.Visible = false;
            button1.Visible = true;
            this.BackgroundImage = Image.FromFile("C:\\Users\\student\\Desktop\\reprizitori\\Novella-TATAbilar\\Новелла\\Новелла\\fon1.png");
            text.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            text.Visible = false;
            this.BackgroundImage = Image.FromFile("C:\\Users\\student\\Desktop\\reprizitori\\Novella-TATAbilar\\Новелла\\Новелла\\fon2.jpg");
            button1.Visible = false;
            button2.Visible = true;
            text2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            text2.Visible = false;
            this.BackgroundImage = Image.FromFile("C:\\Users\\student\\Desktop\\reprizitori\\Novella-TATAbilar\\Новелла\\Новелла\\fon3.png");
            text3.Visible = true;
            button2.Visible = false;
            button3.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            text3.Text = "смотрит в глазок и видит...";
            this.BackgroundImage = Image.FromFile("C:\\Users\\student\\Desktop\\reprizitori\\Novella-TATAbilar\\Новелла\\Новелла\\fon4.png");
            button3.Visible = false;
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            text3.Visible= false;
            this.BackgroundImage = Image.FromFile("C:\\Users\\student\\Desktop\\reprizitori\\Novella-TATAbilar\\Новелла\\Новелла\\fon5.jpg");

        }
    }
}
