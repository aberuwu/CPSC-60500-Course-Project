using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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
        int character1Count = 0, character2Count = 0,
            character3Count = 0, character4Count = 0;
        
        int shortestRun = 0;
        int longestRun = 0;
        int averageRunCount = 0;

        int gridHeight = 501;
        int gridWidth = 663;
        int characterSpeedLeft = -5;
        int characterSpeedRight = 5;

        Point character1Location = Point.Empty;
        bool character1Moved = false;
        Point character2Location = Point.Empty;
        bool character2Moved = false;
        Point character3Location = Point.Empty;
        bool character3Moved = false;
        Point character4Location = Point.Empty;
        bool character4Moved = false;


        bool character1Found = false, character2Found = false, character3Found = false, character4Found = false;
        bool simulationStart = false;
        bool initialCountvalue = true;
        bool initialCountvalueLongest = true;


        //Audio  Assets
        List<PictureBox> characters = new List<PictureBox>();
        static string pathBackground = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"AudioAssets\background-music.wav");
        System.Media.SoundPlayer playerBackground = new System.Media.SoundPlayer(pathBackground);
        static string pathFoundBackground = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"AudioAssets\character-found-sound.wav");
        System.Media.SoundPlayer playerFoundBackground = new System.Media.SoundPlayer(pathFoundBackground);

        public frmMain()
        {
            InitializeComponent();
            ddlGameMode.SelectedIndex = 0;

        }

        private void btnSimStart_Click(object sender, EventArgs e)
        {
            if (!simulationStart)
            {

                if(tckCharacterNumb.Value == 2)
                {
                    characters.Clear();
                    characters.Add(character1);
                    characters.Add(character2);
                }
                else if (tckCharacterNumb.Value == 3)
                {
                    characters.Clear();
                    characters.Add(character1);
                    characters.Add(character2); 
                    characters.Add(character3);
                    lblCharacter3Steps.Visible = true;
                    lblCharacter3StepsOut.Visible = true;
                }
                else if (tckCharacterNumb.Value == 4)
                {
                    characters.Clear();
                    characters.Add(character1);
                    characters.Add(character2);
                    characters.Add(character3);
                    characters.Add(character4);
                    lblCharacter3Steps.Visible = true;
                    lblCharacter4Steps.Visible = true;
                    lblCharacter4StepsOut.Visible = true;
                    lblCharacter4StepsOut.Visible = true;
                }

                //resetSimulation();
                simulationStart = true;
                gameTimer.Enabled = true;
                btnSimStart.Text = "Stop Simulation";
                ddlGameMode.Enabled = false;
                playerBackground.Play();
            }
            else
            {
                simulationStart = false;
                gameTimer.Enabled = false;
                btnSimStart.Text = "Start Simulation";
                ddlGameMode.Enabled = true;
                playerBackground.Stop();
            }

        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            resetSimulation();
        }

        private void ddlGameMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlGameMode.SelectedIndex == 0)
            {
                gbxSimParams.Enabled = false;
                lblLongestRun.Visible = false;
                lblLongestRunOut.Visible = false;
                lblShortestRun.Visible = false;
                lblShortestRunOut.Visible = false;
                lblAvgRun.Visible = false;
                lblAvgRunOut.Visible = false;


                tckCharacterSpeed.Enabled = false;
                numCustomSeed.Enabled = false;

            }
            if (ddlGameMode.SelectedIndex == 1)
            {
                gbxSimParams.Enabled = true;
                lblLongestRun.Visible = true;
                lblLongestRunOut.Visible = true;
                lblShortestRun.Visible = true;
                lblShortestRunOut.Visible = true;
                lblAvgRun.Visible = true;
                lblAvgRunOut.Visible = true;

                tckCharacterSpeed.Enabled = false;
                numCustomSeed.Enabled = false;
            }
            if (ddlGameMode.SelectedIndex == 2)
            {
                gbxSimParams.Enabled = true;
                lblLongestRun.Visible = true;
                lblLongestRunOut.Visible = true;
                lblShortestRun.Visible = true;
                lblShortestRunOut.Visible = true;
                lblAvgRun.Visible = true;
                lblAvgRunOut.Visible = true;

                tckCharacterSpeed.Enabled = true;
                numCustomSeed.Enabled = true;
            }
        }

        private void resetSimulation()
        {
            character1Count = 0;
            character2Count = 0;
            character3Count = 0;
            character4Count = 0;
            shortestRun = 0;
            longestRun = 0;
            movementPosition = 5;
            character1Found = false;
            character2Found = false;
            character3Found = false;
            character4Found = false;
            confetiImage.Visible = false;
            lblFound.Visible = false;
            initialCountvalue = true;
            lblShortestRunOut.Text = "###";
            lblLongestRunOut.Text = "###";
            character1.BackColor = Color.DarkOliveGreen;
            character2.BackColor = Color.DarkOliveGreen;
            character3.BackColor = Color.DarkOliveGreen;
            character4.BackColor = Color.DarkOliveGreen;

            //Character Positions
            if (character1Moved)
            {
                character1.Location = new Point(28, 36);
                character1Moved = false;
            }
            if (character2Moved)
            {
                character2.Location = new Point(591, 431);
                character2Moved = false;
            }
            if (character3Moved)
            {
                character3.Location = new Point(591, 36);
                character3Moved = false;
            }
            if (character4Moved)
            {
                character4.Location = new Point(28, 431);
                character4Moved = false;
            }

        }


        private void gameTimerEvent(object sender, EventArgs e)
        {
            foreach(PictureBox character in characters)
            {
                Random rnd;

                if(numCustomSeed.Enabled == true && numCustomSeed.Value != 0)
                {
                    int customSeed = (int)numCustomSeed.Value;
                     rnd = new Random((Guid.NewGuid().GetHashCode()) * customSeed);
                }
                else
                {
                     rnd = new Random(Guid.NewGuid().GetHashCode());
                }

                

                //int randomHpts = rnd.Next(0, 5);

                //Random rnd = new Random();
                movementPosition = rnd.Next(characterSpeedLeft, characterSpeedRight);

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


                if (character.Name == "character1")
                {
                    if (!character1Found)
                    {
                        averageRunCount += character1Count;
                    }
                    character1Count += Math.Abs(movementPosition);
                    lblCharacter1StepsOut.Text = character1Count.ToString();
                }
                else if(character.Name == "character2")
                {
                    if (!character2Found)
                    {
                        averageRunCount += character2Count;
                    }
                    character2Count += Math.Abs(movementPosition);
                    lblCharacter2StepsOut.Text = character2Count.ToString();
                }
                else if (character.Name == "character3")
                {
                    if (!character3Found)
                    {
                        averageRunCount += character3Count;
                    }
                    character3Count += Math.Abs(movementPosition);
                    lblCharacter3StepsOut.Text = character3Count.ToString();
                }
                else if (character.Name == "character4")
                {
                    if (!character4Found)
                    {
                        averageRunCount += character4Count;
                    }
                    character4Count += Math.Abs(movementPosition);
                    lblCharacter4StepsOut.Text = character4Count.ToString();
                }

                averageRunCount = (character2Count + character1Count + character3Count + character4Count)/characters.Count();
                lblAvgRunOut.Text = averageRunCount.ToString();

            }

      
            if(characters.Count == 2)
            {

                if (characters[0].Bounds.IntersectsWith(characters[1].Bounds))
                {
                    character1Found = true;
                    character2Found = true;


                    if (initialCountvalue)
                    {
                        shortestRun = Math.Min(character1Count, character2Count);
                        longestRun = Math.Max(character1Count, character2Count);
                        lblShortestRunOut.Text = shortestRun.ToString();
                        lblLongestRunOut.Text = longestRun.ToString();
                        
                        initialCountvalue = false;
                    }
                    
                }
                if (character1Found && character2Found)
                {
                    //Set character color when found
                    character1.BackColor = Color.Red;
                    character2.BackColor = Color.Red;
                    confetiImage.Visible = true;
                    lblFound.Visible = true;
                    gameTimer.Enabled = false;
                    playerBackground.Stop();
                    playerFoundBackground.Play();
                }
            }
            else if (characters.Count == 3)
            {
                if (characters[0].Bounds.IntersectsWith(characters[1].Bounds))
                {

                    character1Found = true;
                    character2Found = true;

                    if (shortestRun == 0)
                    {
                        shortestRun = character1Count;
                    }
                    if (character1Count < shortestRun)
                    {
                        lblShortestRunOut.Text = character1Count.ToString();
                    }
                    if (character2Count < shortestRun)
                    {
                        lblShortestRunOut.Text = character2Count.ToString();
                    }

                    //Set character color when found
                    character1.BackColor = Color.Purple;
                    character2.BackColor = Color.Purple;
                    //if (initialCountvalue)
                    //{
                    //    shortestRun = Math.Min(character1Count, character2Count);
                    //    lblShortestRunOut.Text = shortestRun.ToString();
                    //    initialCountvalue = false;
                    //}
                    //else
                    //{
                    //    if(character1Count < shortestRun)
                    //    {
                    //        shortestRun = character1Count;
                    //        lblShortestRunOut.Text = character1Count.ToString();
                    //    }
                    //    if(character2Count < shortestRun)
                    //    {
                    //        shortestRun = character2Count;
                    //        lblShortestRunOut.Text = character2Count.ToString();
                    //    }
                    //}


                }   
                if (characters[1].Bounds.IntersectsWith(characters[2].Bounds))
                {
                    character2Found = true;
                    character3Found = true;


                    if (shortestRun == 0)
                    {
                        shortestRun = character1Count;
                    }
                    if (character2Count < shortestRun)
                    {
                        lblShortestRunOut.Text = character2Count.ToString();
                    }
                    if (character3Count < shortestRun)
                    {
                        lblShortestRunOut.Text = character3Count.ToString();
                    }

                    //Set character color when found
                    character2.BackColor = Color.Purple;
                    character3.BackColor = Color.Purple;
                    //if (initialCountvalue)
                    //{
                    //    shortestRun = Math.Min(character2Count, character3Count);
                    //    lblShortestRunOut.Text = shortestRun.ToString();
                    //    initialCountvalue = false;
                    //}
                    //else
                    //{
                    //    if (character2Count < shortestRun)
                    //    {
                    //        shortestRun = character2Count;
                    //        lblShortestRunOut.Text = character2Count.ToString();
                    //    }
                    //    if (character3Count < shortestRun)
                    //    {
                    //        shortestRun = character3Count;
                    //        lblShortestRunOut.Text = character3Count.ToString();
                    //    }
                    //}

                }
                if (characters[2].Bounds.IntersectsWith(characters[0].Bounds))
                {
                    character3Found = true;
                    character1Found = true;

                    if (shortestRun == 0)
                    {
                        shortestRun = character1Count;
                    }
                    if (character3Count < shortestRun)
                    {
                        lblShortestRunOut.Text = character3Count.ToString();
                    }
                    if (character1Count < shortestRun)
                    {
                        lblShortestRunOut.Text = character1Count.ToString();
                    }

                    //Set character color when found
                    character3.BackColor = Color.Purple;
                    character1.BackColor = Color.Purple;

                    //if (initialCountvalue)
                    //{
                    //    shortestRun = Math.Min(character3Count, character1Count);
                    //    lblShortestRunOut.Text = shortestRun.ToString();
                    //    initialCountvalue = false;
                    //}
                    //else
                    //{
                    //    if (character3Count < shortestRun)
                    //    {
                    //        shortestRun = character3Count;
                    //        lblShortestRunOut.Text = character3Count.ToString();
                    //    }
                    //    if (character1Count < shortestRun)
                    //    {
                    //        shortestRun = character1Count;
                    //        lblShortestRunOut.Text = character1Count.ToString();
                    //    }
                    //}

                }
                if (character1Found && character2Found && character3Found)
                {
                    //Set character color when found
                    character1.BackColor = Color.Red;
                    character2.BackColor = Color.Red;
                    character3.BackColor = Color.Red;

                    confetiImage.Visible = true;
                    lblFound.Visible = true;
                    gameTimer.Enabled = false;
                    playerBackground.Stop();
                    playerFoundBackground.Play();


                    int longestRunInitial = Math.Max(character1Count, character2Count);
                    longestRun = Math.Max(character3Count, longestRunInitial);
                    lblLongestRunOut.Text = longestRun.ToString();
                    initialCountvalueLongest = false;

                    //if (initialCountvalueLongest)
                    //{
                    //    int longestRunInitial = Math.Max(character1Count, character2Count);
                    //    longestRun = Math.Max(character3Count, longestRunInitial);
                    //    lblLongestRunOut.Text = longestRun.ToString();
                    //    initialCountvalueLongest = false;
                    //}

                }
            }
            else if (characters.Count == 4)
            {
                if (characters[0].Bounds.IntersectsWith(characters[1].Bounds))
                {

                    character1Found = true;
                    character2Found = true;


                    if(shortestRun == 0)
                    {
                        shortestRun = character1Count;
                    }
                    if(character1Count < shortestRun)
                    {
                        lblShortestRunOut.Text = character1Count.ToString();
                    }
                    if(character2Count < shortestRun)
                    {
                        lblShortestRunOut.Text = character2Count.ToString();
                    }

                    //Set character color when found
                    character1.BackColor = Color.Purple;
                    character2.BackColor = Color.Purple;

                    //if (character1Count < character2Count)
                    //{
                    //    lblShortestRunOut.Text = character1Count.ToString();
                    //}
                    //else
                    //{
                    //    lblShortestRunOut.Text = character2Count.ToString();
                    //}



                }
                if (characters[1].Bounds.IntersectsWith(characters[2].Bounds))
                {
                    character2Found = true;
                    character3Found = true;

                    if (shortestRun == 0)
                    {
                        shortestRun = character1Count;
                    }
                    if (character2Count < shortestRun)
                    {
                        lblShortestRunOut.Text = character2Count.ToString();
                    }
                    if (character3Count < shortestRun)
                    {
                        lblShortestRunOut.Text = character3Count.ToString();
                    }

                    //Set character color when found
                    character2.BackColor = Color.Purple;
                    character3.BackColor = Color.Purple;

                    //if (character2Count < character3Count)
                    //{
                    //    lblShortestRunOut.Text = character1Count.ToString();
                    //}
                    //else
                    //{
                    //    lblShortestRunOut.Text = character2Count.ToString();
                    //}
                }
                if (characters[2].Bounds.IntersectsWith(characters[3].Bounds))
                {
                    character3Found = true;
                    character4Found = true;

                    if (shortestRun == 0)
                    {
                        shortestRun = character1Count;
                    }
                    if (character3Count < shortestRun)
                    {
                        lblShortestRunOut.Text = character3Count.ToString();
                    }
                    if (character4Count < shortestRun)
                    {
                        lblShortestRunOut.Text = character4Count.ToString();
                    }

                    //Set character color when found
                    character3.BackColor = Color.Purple;
                    character4.BackColor = Color.Purple;

                    //if (character1Count < character2Count)
                    //{
                    //    lblShortestRunOut.Text = character1Count.ToString();
                    //}
                    //else
                    //{
                    //    lblShortestRunOut.Text = character2Count.ToString();
                    //}
                }
                if (characters[0].Bounds.IntersectsWith(characters[3].Bounds))
                {
                    character1Found = true;
                    character4Found = true;

                    if (shortestRun == 0)
                    {
                        shortestRun = character1Count;
                    }
                    if (character1Count < shortestRun)
                    {
                        lblShortestRunOut.Text = character1Count.ToString();
                    }
                    if (character4Count < shortestRun)
                    {
                        lblShortestRunOut.Text = character4Count.ToString();
                    }

                    //Set character color when found
                    character1.BackColor = Color.Purple;
                    character4.BackColor = Color.Purple;

                    //if (character1Count < character2Count)
                    //{
                    //    lblShortestRunOut.Text = character1Count.ToString();
                    //}
                    //else
                    //{
                    //    lblShortestRunOut.Text = character2Count.ToString();
                    //}
                }
                if (characters[3].Bounds.IntersectsWith(characters[1].Bounds))
                {
                    character2Found = true;
                    character4Found = true;

                    if (shortestRun == 0)
                    {
                        shortestRun = character1Count;
                    }
                    if (character2Count < shortestRun)
                    {
                        lblShortestRunOut.Text = character2Count.ToString();
                    }
                    if (character4Count < shortestRun)
                    {
                        lblShortestRunOut.Text = character4Count.ToString();
                    }

                    //Set character color when found
                    character2.BackColor = Color.Purple;
                    character4.BackColor = Color.Purple;

                    //if (character1Count < character2Count)
                    //{
                    //    lblShortestRunOut.Text = character1Count.ToString();
                    //}
                    //else
                    //{
                    //    lblShortestRunOut.Text = character2Count.ToString();
                    //}
                }
                if (characters[2].Bounds.IntersectsWith(characters[0].Bounds))
                {
                    character1Found = true;
                    character3Found = true;

                    if (shortestRun == 0)
                    {
                        shortestRun = character1Count;
                    }
                    if (character1Count < shortestRun)
                    {
                        lblShortestRunOut.Text = character1Count.ToString();
                    }
                    if (character3Count < shortestRun)
                    {
                        lblShortestRunOut.Text = character3Count.ToString();
                    }

                    //Set character color when found
                    character1.BackColor = Color.Purple;
                    character3.BackColor = Color.Purple;

                    //if (character1Count < character2Count)
                    //{
                    //    lblShortestRunOut.Text = character1Count.ToString();
                    //}
                    //else
                    //{
                    //    lblShortestRunOut.Text = character2Count.ToString();
                    //}
                }



                if (character1Found && character2Found && character3Found && character4Found)
                {

                    //Set character color when found
                    character1.BackColor = Color.Red;
                    character2.BackColor = Color.Red;
                    character3.BackColor = Color.Red;
                    character4.BackColor = Color.Red;

                    confetiImage.Visible = true;
                    lblFound.Visible = true;
                    gameTimer.Enabled = false;
                    playerBackground.Stop();
                    playerFoundBackground.Play();

                    int longestRunInitial = Math.Max(character1Count, character2Count);
                    int longestRunSecondary = Math.Max(character2Count, character3Count);
                    longestRun = Math.Max(longestRunSecondary, longestRunInitial);
                    lblLongestRunOut.Text = longestRun.ToString();
                    initialCountvalueLongest = false;

                    //if (initialCountvalueLongest)
                    //{
                    //    int longestRunInitial = Math.Max(character1Count, character2Count);
                    //    int longestRunSecondary = Math.Max(character2Count, character3Count);
                    //    longestRun = Math.Max(longestRunSecondary, longestRunInitial);
                    //    lblLongestRunOut.Text = longestRun.ToString();
                    //    initialCountvalueLongest = false;
                    //}
                }
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

        private void tckCharacterNumb_Scroll(object sender, EventArgs e)
        {
            lbllCurrentCharacterValue.Text = tckCharacterNumb.Value.ToString();
            if (tckCharacterNumb.Value == 3)
            {
                character3.Visible = true;
                character4.Visible = false;
                lblCharacter3Steps.Visible = true;
                lblCharacter3StepsOut.Visible = true;
                lblCharacter4Steps.Visible = false;
                lblCharacter4StepsOut.Visible = false;
            }    
            else if (tckCharacterNumb.Value == 4)
            {
                character4.Visible = true;
                lblCharacter4Steps.Visible = true;
                lblCharacter4StepsOut.Visible = true;
            }     
            else if (tckCharacterNumb.Value == 2)
            {
                character3.Visible = false;
                character4.Visible = false;
                lblCharacter3Steps.Visible = false;
                lblCharacter4Steps.Visible = false;
                lblCharacter4StepsOut.Visible = false;
                lblCharacter3StepsOut.Visible = false;
            }
        }

        private void tckGridWidth_Scroll(object sender, EventArgs e)
        {
            lblWidthValue.Text = tckGridWidth.Value.ToString();

            if (tckGridWidth.Value == 1)
            {
                gridWidth = 550;
                gameGrid.Size = new Size(gridWidth, gridHeight);

               
            }
            if (tckGridWidth.Value == 2)
            {
                gridWidth = 600;
                gameGrid.Size = new Size(gridWidth, gridHeight);
            }
            if (tckGridWidth.Value == 3)
            {
                gridWidth = 663;
                gameGrid.Size = new Size(gridWidth, gridHeight);
            }
        }

        private void tckGridHeight_Scroll(object sender, EventArgs e)
        {
            lblHeightValue.Text = tckGridHeight.Value.ToString();

            if(tckGridHeight.Value == 1)
            {
                gridHeight = 400;
                gameGrid.Size = new Size(gridWidth, gridHeight);

                if (tckCharacterNumb.Value == 2)
                {
                    character2.Location = new Point(591, 320);
                }
                if(tckCharacterNumb.Value == 4)
                {
                    character3.Location = new Point(28, 320);
                }
            }
            if(tckGridHeight.Value == 2)
            {
                gridHeight = 451;
                gameGrid.Size = new Size(gridWidth, gridHeight);
            }
            if(tckGridHeight.Value == 3)
            {
                gridHeight = 501;
                gameGrid.Size = new Size(gridWidth, gridHeight);
            }
        }

        private void tckCharacterSpeed_Scroll(object sender, EventArgs e)
        {
            lblCharacterSpeedValue.Text = tckCharacterSpeed.Value.ToString();

            if(tckCharacterSpeed.Value == 1)
            {
                characterSpeedLeft = -2;
                characterSpeedRight = 2;
            }
            if(tckCharacterSpeed.Value == 2)
            {
                characterSpeedLeft = -5;
                characterSpeedRight = 5;
            }
            if(tckCharacterSpeed.Value == 3)
            {
                characterSpeedLeft = -8;
                characterSpeedRight = 8;
            }

        }


        //MOVE CHARACTERS
        private void character1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                character1Location = new Point(e.X, e.Y);
            }
        }

        private void character1_MouseMove(object sender, MouseEventArgs e)
        {
            if (character1Location != Point.Empty)
            {
                character1Moved = true;
                Point newlocation = this.character1.Location;
                newlocation.X += e.X - character1Location.X;
                newlocation.Y += e.Y - character1Location.Y;
                this.character1.Location = newlocation;
            }
        }

        private void character1_MouseUp(object sender, MouseEventArgs e)
        {
            character1Location = Point.Empty;
        }


        private void character2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                character2Location = new Point(e.X, e.Y);
            }
        }

        private void character2_MouseMove(object sender, MouseEventArgs e)
        {
            if (character2Location != Point.Empty)
            {
                character2Moved = true;
                Point newlocation = this.character2.Location;
                newlocation.X += e.X - character2Location.X;
                newlocation.Y += e.Y - character2Location.Y;
                this.character2.Location = newlocation;
            }
        }

        private void character2_MouseUp(object sender, MouseEventArgs e)
        {
            character2Location = Point.Empty;
        }

       

        private void character3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                character3Location = new Point(e.X, e.Y);
            }

        }

        private void character3_MouseMove(object sender, MouseEventArgs e)
        {
            if (character3Location != Point.Empty)
            {
                character3Moved = true;
                Point newlocation = this.character3.Location;
                newlocation.X += e.X - character3Location.X;
                newlocation.Y += e.Y - character3Location.Y;
                this.character3.Location = newlocation;
            }
        }

        private void character3_MouseUp(object sender, MouseEventArgs e)
        {
            character3Location = Point.Empty;
        }

        private void character4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                character4Location = new Point(e.X, e.Y);
            }
        }

        private void character4_MouseMove(object sender, MouseEventArgs e)
        {
            if (character4Location != Point.Empty)
            {
                character4Moved = true;
                Point newlocation = this.character4.Location;
                newlocation.X += e.X - character4Location.X;
                newlocation.Y += e.Y - character4Location.Y;
                this.character4.Location = newlocation;
            }
        }

        private void character4_MouseUp(object sender, MouseEventArgs e)
        {
            character4Location = Point.Empty;
        }
    }
}
