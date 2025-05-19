using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tick_Tack_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] spielbrett = new string[9];

        int werIstAmZug = 0;

        public String returnSymbole(int turn) 
        {
            if (turn % 2 == 0)
            {
                return "0";
            }
            else 
            {
                return "x";
            }

        }

        public System.Drawing.Color determineColor (string symbole)
        {
            if (symbole.Equals("x"))
            {
                return System.Drawing.Color.Lime;
            }
            else 
            {
                return System.Drawing.Color.Aqua;
            }
        }

        public void checkForWinner ()
        {
            for(int i=0; i < 8; i++)
            {
                string combination = "";

                switch(i) //hier werden die einzelnen Spielkombinatonen festgehalten
                {
                    case 0:
                        combination = spielbrett[0] + spielbrett[4] + spielbrett[8];
                        break;
                    case 1:
                        combination = spielbrett[2] + spielbrett[4] + spielbrett[6];
                        break;
                    case 2:
                        combination = spielbrett[0] + spielbrett[1] + spielbrett[2];
                        break;
                    case 3:
                        combination = spielbrett[3] + spielbrett[4] + spielbrett[5];
                        break;
                    case 4:
                        combination = spielbrett[6] + spielbrett[7] + spielbrett[8];
                        break;
                    case 5:
                        combination = spielbrett[0] + spielbrett[3] + spielbrett[6];
                        break;
                    case 6:
                        combination = spielbrett[1] + spielbrett[4] + spielbrett[7];
                        break;
                    case 7:
                        combination = spielbrett[2] + spielbrett[5] + spielbrett[8];
                        break;
                         
                 
                }
                

                if(combination.Equals("000"))
                {
                   
                    MessageBox.Show("0 hat das spiel gewonnen", "Wir haben einen Gewinner", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                else if (combination.Equals("xxx"))
                {
                   
                    MessageBox.Show("X hat das spiel gewonnen", "Wir haben einen Gewinner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                checkDraw();
            }
        }

        public void checkDraw() 
        {
            int counter = 0;
            for (int i = 0; i < spielbrett.Length; i++)
            {
                if (spielbrett[i] != null) { counter++; }

                if (counter==9)
                {
                    reset();
                    MessageBox.Show("Das ist ein Unenschieden", "Es gibt keinen Gewinner heute", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }


        public void reset()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            spielbrett = new string[9];
            werIstAmZug = 0;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            werIstAmZug++;
            spielbrett[0] = returnSymbole(werIstAmZug); //speicherung im Array spielbrett
            Color buttonColor = determineColor(spielbrett[0]);
            button1.BackColor = buttonColor;
            button1.Text = spielbrett [0];
            checkForWinner(); 
        }
        private void button2_Click(object sender, EventArgs e)
        {
            werIstAmZug++;
            spielbrett[1] = returnSymbole(werIstAmZug); //speicherung im Array spielbrett
            Color buttonColor = determineColor(spielbrett[1]);
            button2.BackColor = buttonColor;
            button2.Text = spielbrett[1];
            checkForWinner();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            werIstAmZug++;
            spielbrett[2] = returnSymbole(werIstAmZug); //speicherung im Array spielbret
            Color buttonColor = determineColor(spielbrett[2]);
            button3.BackColor = buttonColor;
            button3.Text = spielbrett[2];
            checkForWinner();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            werIstAmZug++;
            spielbrett[3] = returnSymbole(werIstAmZug); //speicherung im Array spielbrett
            Color buttonColor = determineColor(spielbrett[3]);
            button4.BackColor = buttonColor;
            button4.Text = spielbrett[3];
            checkForWinner();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            werIstAmZug++;
            spielbrett[4] = returnSymbole(werIstAmZug); //speicherung im Array spielbrett
            Color buttonColor = determineColor(spielbrett[4]);
            button5.BackColor = buttonColor;
            button5.Text = spielbrett[4];
            checkForWinner();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            werIstAmZug++;
            spielbrett[5] = returnSymbole(werIstAmZug); //speicherung im Array spielbrett
            Color buttonColor = determineColor(spielbrett[5]);
            button6.BackColor = buttonColor;
            button6.Text = spielbrett[5];
            checkForWinner();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            werIstAmZug++;
            spielbrett[6] = returnSymbole(werIstAmZug); //speicherung im Array spielbrett
            Color buttonColor = determineColor(spielbrett[6]);
            button7.BackColor = buttonColor;
            button7.Text = spielbrett[6];
            checkForWinner();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            werIstAmZug++;
            spielbrett[7] = returnSymbole(werIstAmZug); //speicherung im Array spielbrett
            Color buttonColor = determineColor(spielbrett[7]);
            button8.BackColor = buttonColor;
            button8.Text = spielbrett[7];
            checkForWinner();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            werIstAmZug++;
            spielbrett[8] = returnSymbole(werIstAmZug); //speicherung im Array spielbrett
            Color buttonColor = determineColor(spielbrett[8]);
            button9.BackColor = buttonColor;
            button9.Text = spielbrett[8];
            checkForWinner();
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
