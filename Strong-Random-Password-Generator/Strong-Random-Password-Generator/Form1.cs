using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strong_Random_Password_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            int dlugosc = Convert.ToInt32(numericUpDown1.Value);

            bool duze = false;
            bool male = false;
            bool liczby = false;
            bool znaki = false;

            //gdy nie jest nic zaznacozne

            if (duzelit.Checked == true) duze = true;
            if (malelitery.Checked == true) male = true;
            if (cyfry.Checked == true) liczby = true;
            if (znakispecjal.Checked == true) znaki = true;
            //else znaki = false;
           
            textBox1.Text = generuj(duze,male,liczby, znaki,dlugosc);
       
        }

        public string generuj(bool duze, bool male, bool cyfry, bool znaki, int dlugosc)
        {

            string haslo="";
            char[] alfabetd = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'Q', 'P', 'R', 'S', 'T', 'U', 'W', 'X', 'Y', 'Z' };
            char[] alfabetm = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'q', 'p', 'r', 's', 't', 'u', 'w', 'x', 'y', 'z' };
            char[] liczbytab = { '0','1','2','3','4','5','6','7','8','9'};
            char[] znakitab = {'`','~','!','@','#','$','%','^','&','*','=','+','?' };

            string zbior_losowania = "";
            if (duze == true) for(int i=0;i<alfabetd.Length;i++)zbior_losowania+=alfabetd[i];
            if (male == true) for (int i = 0; i < alfabetm.Length; i++) zbior_losowania += alfabetm[i];
            if (cyfry == true) for (int i = 0; i < liczbytab.Length; i++) zbior_losowania += liczbytab[i];
            if (znaki == true) for (int i = 0; i < znakitab.Length; i++) zbior_losowania += znakitab[i];

            int d = zbior_losowania.Length;
            Random rand = new Random();
            for (int i = 0; i < dlugosc; i++)
            {
                
                haslo +=  zbior_losowania[rand.Next(d)];
            }
            return haslo;
        }

        
    }
}
