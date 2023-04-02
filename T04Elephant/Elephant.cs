using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T04Elephant
{
    class Elephant
    {
        public int TamOreja;
        public string Name;

        public void WhoAmI() {
            MessageBox.Show(" Mis orejas miden: " + TamOreja + " cm. ", Name + " dice...");
        }
        public void TellMe(string message, Elephant whoSaidIt)
        {
            MessageBox.Show(whoSaidIt.Name + " dice: " + message);
        }

        public void SpeakTo(Elephant whoToTalkTo, string message)
        {
            whoToTalkTo.TellMe(message, this); // este metodo de la clase Elephant llama al metodo Talkto
            //de otro elephant. Esto permite que un objeto se comunique con otro.
        }
    }
}
