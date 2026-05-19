using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace sudoku3._2
{

    public partial class Form1 : Form
    {

        readonly Color DISABLED = Color.FromArgb(0x80,182,182,182);
        readonly Color ENABLED = Color.White;
        readonly Color COLLIDED = Color.Red;

        Grid grid = new Grid();
        string stack;
        
        public Form1()
        {
            Initobj();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(sender, e);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int c0;

            if (e.KeyChar < '0' || e.KeyChar > '9')
                return;
            stack = e.KeyChar.ToString();
            c0 = System.Convert.ToInt32(e.KeyChar) - 0x30;
            digit[c0].Focus();
        }

        private void Displaypuzzle()
        {
            for (int c0 = 0; c0 < 9; c0++)
            {
                for (int c1 = 0; c1 < 9; c1++)
                {
                    if (grid.vector[9 * c0 + c1] == 0)
                    {
                        canvas[c0, c1].Text = "";
                        canvas[c0, c1].BackColor = ENABLED;
                    }
                    else
                    {
                        canvas[c0, c1].Text = Convert.ToString(grid.vector[9 * c0 + c1]);
                        canvas[c0, c1].BackColor = DISABLED;
                    }
                }
            }
            Cluelabel.Text = $"Number of Clues: {grid.CountClues()}";
            Puzzleidlabel.Text = $"Puzzle ID: {grid.puzzleid}";
        }

        private void Digit_Click(object sender, EventArgs e)
        {
            Button obj = sender as Button;
            stack = obj.Text;
        }

        private void Canvas_Click(object sender, EventArgs e)
        {
            Button obj = sender as Button;
            string name, s1, s0;
            int c0, c1;

            name = obj.Name;
            s0 = name.Substring(0, 1);
            s1 = name.Substring(2, 1);
            c0 = System.Convert.ToInt32(s0);
            c1 = System.Convert.ToInt32(s1);
            if (canvas[c0, c1].BackColor != DISABLED)
            {
                if (stack == "0")
                    canvas[c0, c1].Text = "";
                else
                    canvas[c0, c1].Text = stack;
            }
            digit[System.Convert.ToInt32(stack)].Focus();

            // check if 

            Check4Collisions();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void solvePuzzleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grid.SolveIt();
            Displaypuzzle();
        }

        private void resetPuzzleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int c0 = 0; c0 < 9; c0++)
            {
                for (int c1 = 0; c1 < 9; c1++)
                {
                    if (canvas[c0, c1].BackColor != DISABLED)
                    {
                        canvas[c0, c1].Text = "";
                        canvas[c0, c1].BackColor = ENABLED;
                    }
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grid.CreateRandomSequence(DateTime.Now.Ticks);
            grid.FillGrid();
            grid.RemoveDigits();
            Displaypuzzle();
        }


        private void Textpuzzleid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                try
                {
                    long a = Convert.ToInt64(Textpuzzleid.Text, 16);
                    grid.CreateRandomSequence(a);
                }
                catch
                {
                    Textpuzzleid.Text = "";
                    return;
                }

                grid.FillGrid();
                grid.RemoveDigits();
                Displaypuzzle();
            }
        }

        private void loadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Stream fs;
            OpenFileDialog ofd = new OpenFileDialog();
            byte[] buffer = new byte[0x60];

            ofd.Filter = "Sudoku files (*.sudoku)|*.sudoku"; 
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fs = ofd.OpenFile();
                fs.Read(buffer, 0, 0x60);
                if (!Puzzleidtoread(buffer))
                {
                    MessageBox.Show("Invalid Sudoku file... \nA new Sudoku puzzle will be generated instead.", "Sudoku",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    
                    grid.CreateRandomSequence(DateTime.Now.Ticks);
                    grid.FillGrid();
                    grid.RemoveDigits();
                    Displaypuzzle();
                }
                else
                    Digitstoread(buffer);
                fs.Close();
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream fs;
            SaveFileDialog sfd = new SaveFileDialog();
            byte[] buffer = new byte[0x60];

            sfd.Filter = "Sudoku files (*.sudoku)|*.sudoku";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Puzzleidtowrite(buffer);
                Digitstowrite(buffer);
                fs = sfd.OpenFile();
                fs.Write(buffer, 0, 0x60);
                fs.Close();
            }

        }

        private bool Puzzleidtoread(byte[] buffer)
        {
            int strlen = Convert.ToInt32(buffer[0]);

            string puzzleid = "";

            try
            {
                for (int c0 = 0; c0 < strlen; c0++)
                {
                    puzzleid += Convert.ToString(buffer[c0 + 1],16);
                }
                grid.CreateRandomSequence(Convert.ToInt64(puzzleid, 16));
            }
            catch
            {
                return false;
            }

            grid.FillGrid();
            grid.RemoveDigits();
            Displaypuzzle();

            return true;
        }

        private void Digitstoread(byte[] buffer)
        {
            // starting position to read from: 15

            for (int c0 = 0; c0 < 9; c0++)
            {
                for (int c1 = 0; c1 < 9; c1++)
                {
                    if (buffer[15 + 9 * c1 + c0] == 0)
                        canvas[c0, c1].Text = "";
                    else
                        canvas[c0, c1].Text = Convert.ToString(buffer[15 + 9 * c1 + c0]);

                }
            }


        }
        private void Puzzleidtowrite(byte[] buffer)
        {
            buffer[0] = Convert.ToByte(grid.puzzleid.Length);
            for(int c0 = 0;c0 < grid.puzzleid.Length; c0++)
            {
                buffer[c0+1] = Convert.ToByte(grid.puzzleid.Substring(c0, 1),16);
            }
        }

        private void Digitstowrite(byte[] buffer)
        {
            // starting position to write to: 15

            for(int c0=0; c0<9; c0++)
            {
                for (int c1 = 0; c1 < 9; c1++)
                {
                    if (canvas[c0, c1].Text == "")
                        buffer[15 + 9 * c1 + c0] = 0;
                    else
                        buffer[15 + 9 * c1 + c0] = Convert.ToByte(canvas[c0, c1].Text);

                }
            }


        }

        private void Check4Collisions()
        {
            bool flag_collision = false;
            int digitsfilled = 81; 
            for (int c0 = 0; c0 < 9; c0++)
            {
                for (int c1 = 0; c1 < 9; c1++)
                {
                    if (canvas[c0, c1].Text == "")
                        digitsfilled--;
                    if (canvas[c0, c1].BackColor == DISABLED)
                        continue;
                    if (Check4Collision(c0, c1))
                    {
                        canvas[c0, c1].BackColor = COLLIDED;
                        flag_collision = true;
                    }
                    else
                        canvas[c0, c1].BackColor = ENABLED;
                }
            }
            if(digitsfilled == 81 && !flag_collision)
                MessageBox.Show("Congratulations!\nPuzzle solved!", "Sudoku", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private bool Check4Collision(int x, int y)
        {
            if (canvas[x, y].Text == "")
                return false;
            if(Check4Collision_h(x, y))
                return true;
            if (Check4Collision_v(x, y))
                return true;
            if (Check4Collision_w(x, y))
                return true;

            return false;
        }
        private bool Check4Collision_h(int x, int y)
        {
            for(int c0=0;c0<9;c0++)
            {

                if (x == c0)
                {
                    continue;
                }
                if (canvas[x,y].Text == canvas[c0,y].Text)
                    return true;
            }

            return false;
        }
        private bool Check4Collision_v(int x, int y)
        {

            for (int c0 = 0; c0 < 9; c0++)
            {

                if (y == c0)
                {
                    continue;
                }
                if (canvas[x, y].Text == canvas[x, c0].Text)
                    return true;
            }

            return false;
        }
        private bool Check4Collision_w(int x, int y)
        {

            int lx = x / 3;
            int ly = y / 3;
            int kx = x % 3;
            int ky = y % 3;

            for (int c0 = 0; c0 < 3; c0++)
            {
                for (int c1 = 0; c1 < 3; c1++)
                {
                    if (kx == c0 && ky == c1)
                    {
                        continue;
                    }
                    if (canvas[x, y].Text == canvas[3*lx + c0, 3*ly + c1].Text)
                        return true;
                }
            }
            return false;
        }


    }

}
