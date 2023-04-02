using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T04Elephant
{
    public partial class Form1 : Form
    {
        Elephant Dumbo;
        Elephant Eli;

        public Form1()
        {
            InitializeComponent();
            Dumbo= new Elephant() {Name="Dumbo", TamOreja=33};
            Eli= new Elephant() { Name="Eli", TamOreja=40};
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dumbo.WhoAmI();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Dumbo.TellMe("Hola", Eli);
            Dumbo.SpeakTo(Eli, "Hola");
            Dumbo = Eli;
            Dumbo.TamOreja = 4321;
            Dumbo.WhoAmI();
        }

        private void btnEli_Click(object sender, EventArgs e)
        {
            Eli.WhoAmI();
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            Elephant auxElephant;
            auxElephant=Dumbo;
            Dumbo=Eli;
            Eli=auxElephant;
            MessageBox.Show("Objetos intercambiados");
        }
    }
}
