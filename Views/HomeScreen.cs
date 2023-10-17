using Ahorcado.Models;

namespace Ahorcado
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Player.playerName = textBox1.Text;
            HangMan hangMan = new HangMan();
            hangMan.Show();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {

        }
    }
}