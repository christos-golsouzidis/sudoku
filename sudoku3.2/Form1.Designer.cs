
namespace sudoku3._2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Textpuzzleid = new System.Windows.Forms.ToolStripTextBox();
            this.resetPuzzleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solvePuzzleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Cluelabel = new System.Windows.Forms.Label();
            this.Puzzleidlabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(914, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.gameToolStripMenuItem.Text = "&Game";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem1
            // 
            this.loadToolStripMenuItem1.Name = "loadToolStripMenuItem1";
            this.loadToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadToolStripMenuItem1.Size = new System.Drawing.Size(175, 26);
            this.loadToolStripMenuItem1.Text = "&Load";
            this.loadToolStripMenuItem1.Click += new System.EventHandler(this.loadToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.exitToolStripMenuItem.Text = "&Quit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.resetPuzzleToolStripMenuItem,
            this.solvePuzzleToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.optionsToolStripMenuItem.Text = "&Puzzle";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Textpuzzleid});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loadToolStripMenuItem.Text = "&Enter ID";
            // 
            // Textpuzzleid
            // 
            this.Textpuzzleid.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Textpuzzleid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Textpuzzleid.Name = "Textpuzzleid";
            this.Textpuzzleid.Size = new System.Drawing.Size(100, 27);
            this.Textpuzzleid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textpuzzleid_KeyPress);
            // 
            // resetPuzzleToolStripMenuItem
            // 
            this.resetPuzzleToolStripMenuItem.Name = "resetPuzzleToolStripMenuItem";
            this.resetPuzzleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.resetPuzzleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.resetPuzzleToolStripMenuItem.Text = "&Reset";
            this.resetPuzzleToolStripMenuItem.Click += new System.EventHandler(this.resetPuzzleToolStripMenuItem_Click);
            // 
            // solvePuzzleToolStripMenuItem
            // 
            this.solvePuzzleToolStripMenuItem.Name = "solvePuzzleToolStripMenuItem";
            this.solvePuzzleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.solvePuzzleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.solvePuzzleToolStripMenuItem.Text = "&Solve";
            this.solvePuzzleToolStripMenuItem.Click += new System.EventHandler(this.solvePuzzleToolStripMenuItem_Click);
            // 
            // Cluelabel
            // 
            this.Cluelabel.AutoSize = true;
            this.Cluelabel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cluelabel.Location = new System.Drawing.Point(458, 675);
            this.Cluelabel.Name = "Cluelabel";
            this.Cluelabel.Size = new System.Drawing.Size(158, 20);
            this.Cluelabel.TabIndex = 1;
            this.Cluelabel.Text = "Number of clues:";
            // 
            // Puzzleidlabel
            // 
            this.Puzzleidlabel.AutoSize = true;
            this.Puzzleidlabel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puzzleidlabel.Location = new System.Drawing.Point(62, 675);
            this.Puzzleidlabel.Name = "Puzzleidlabel";
            this.Puzzleidlabel.Size = new System.Drawing.Size(98, 20);
            this.Puzzleidlabel.TabIndex = 2;
            this.Puzzleidlabel.Text = "Puzzle ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 730);
            this.Controls.Add(this.Puzzleidlabel);
            this.Controls.Add(this.Cluelabel);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sudoku3.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void Initobj()
        {
            int c0 = 0;
            int c1;

            while (c0 < 10)
            {
                this.digit[c0] = new System.Windows.Forms.Button();
                this.digit[c0].Location = new System.Drawing.Point(750, 64 + c0 * 64);
                this.digit[c0].Name = "digit_" + System.Convert.ToString(c0);
                this.digit[c0].Size = new System.Drawing.Size(64, 64);
                this.digit[c0].TabIndex = 0;
                this.digit[c0].TabStop = false;
                this.digit[c0].Enter += new System.EventHandler(this.Digit_Click);
                this.digit[c0].Text = System.Convert.ToString(c0);
                this.digit[c0].UseVisualStyleBackColor = true;
                this.Controls.Add(this.digit[c0]);
                this.digit[c0].Font = new System.Drawing.Font("Verdana",
                    11.2F, System.Drawing.FontStyle.Regular, 
                    System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                c0++;
            }

            c0 = 0;

            while (c0 < 9)
            {
                c1 = 0;
                while (c1 < 9)
                {

                    this.canvas[c0, c1] = new System.Windows.Forms.Button();
                    this.canvas[c0, c1].Location = new System.Drawing.Point(
                        (c0 / 3) * 8 + 64 + c0 * 64, (c1 / 3) * 8 + 64 + c1 * 64);
                    this.canvas[c0, c1].Name = System.Convert.ToString(c0) +
                        " " + System.Convert.ToString(c1);
                    this.canvas[c0, c1].Size = new System.Drawing.Size(64, 64);
                    this.canvas[c0, c1].TabIndex = 0;
                    this.canvas[c0, c1].TabStop = false;
                    this.canvas[c0, c1].Enter += new System.EventHandler(this.Canvas_Click);
                    this.canvas[c0, c1].Text = "";
                    this.canvas[c0, c1].UseVisualStyleBackColor = true;
                    this.Controls.Add(this.canvas[c0, c1]);
                    this.canvas[c0, c1].Font = new System.Drawing.Font("Verdana",
                        12.2F, System.Drawing.FontStyle.Regular,
                        System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                    c1++;
                }
                c0++;
            }



        }

        private System.Windows.Forms.Button[] digit = new System.Windows.Forms.Button[10];
        private System.Windows.Forms.Button[,] canvas = new System.Windows.Forms.Button[9,9];
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetPuzzleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solvePuzzleToolStripMenuItem;
        private System.Windows.Forms.Label Cluelabel;
        private System.Windows.Forms.Label Puzzleidlabel;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox Textpuzzleid;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

