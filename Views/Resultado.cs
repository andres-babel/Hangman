using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ahorcado.Models;

namespace Ahorcado
{
    public partial class Resultado : Form
    {
        public Resultado()
        {
            InitializeComponent();
        }

        private void Resultado_Load(object sender, EventArgs e)
        {
            if (Player.won)
                label1.Text = Player.playerName + " Ha Ganado!!";
            else
                label1.Text = Player.playerName + " Ha Perdido";

        }
    }
}
