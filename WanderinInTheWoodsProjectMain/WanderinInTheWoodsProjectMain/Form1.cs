using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WanderinInTheWoodsProjectMain
{
    public partial class frmMain : Form
    {
        //int speed = 8;
        int movementPosition = 5;
        const int faces = 2;

        List<PictureBox> characters = new List<PictureBox>();
        
        public frmMain()
        {
            InitializeComponent();
            characters.Add(character1);
            characters.Add(character2);
            characters.Add(character3);
            characters.Add(character4);
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            foreach(PictureBox character in characters)
            {
                Random rnd = new Random();
                movementPosition = rnd.Next(-5, 5);

                int updownodd = rnd.Next(faces);

                if (updownodd == 1)
                {
                    character.Left += movementPosition;
                }
                else
                {
                    character.Top += movementPosition;
                }


                if (character.Top < 20)
                {
                    movementPosition = 20;
                    character.Top += movementPosition;
                }
                if (character.Top > gameGrid.Height - 10)
                {
                    movementPosition = -20;
                    character.Top += movementPosition;
                }
                if (character.Left < 0)
                {
                    movementPosition = 20;
                    character.Left += movementPosition;
                }
                if (character.Left > gameGrid.Width - 10)
                {
                    movementPosition = -20;
                    character.Left += movementPosition;
                }

                //if (character.Bounds.IntersectsWith(characters[0].Bounds))
                //{
                //    lblFound.Visible = true;
                //}


                //for(int i = 0; i < characters.Count; i++)
                //{
                //    if (character.Bounds.IntersectsWith(characters[i].Bounds))
                //    {
                //        lblFound.Visible = true;
                //    }
                //}

            }

            //for (int i = 0; i < characters.Count; i++)
            //{
            //    if (characters[i].Bounds.IntersectsWith(characters[].Bounds))
            //    {
            //        lblFound.Visible = true;
            //    }
            //}

            if (characters[0].Bounds.IntersectsWith(characters[1].Bounds))
            {
                lblFound.Visible = true;
            }
            if (characters[1].Bounds.IntersectsWith(characters[2].Bounds))
            {
                lblFound.Visible = true;
            }
            if (characters[2].Bounds.IntersectsWith(characters[3].Bounds))
            {
                lblFound.Visible = true;
            }

        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                movementPosition = -1;
            }
        }

        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                movementPosition = 1;
            }
        }

    }
}
