using System.Windows.Forms;

namespace game2048
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGame = new System.Windows.Forms.ToolStripMenuItem();
            this.dễToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb9 = new System.Windows.Forms.Label();
            this.lb13 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb6 = new System.Windows.Forms.Label();
            this.lb10 = new System.Windows.Forms.Label();
            this.lb14 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb7 = new System.Windows.Forms.Label();
            this.lb11 = new System.Windows.Forms.Label();
            this.lb15 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb8 = new System.Windows.Forms.Label();
            this.lb12 = new System.Windows.Forms.Label();
            this.lb16 = new System.Windows.Forms.Label();
            this.btRight = new System.Windows.Forms.Button();
            this.btDown = new System.Windows.Forms.Button();
            this.btLeft = new System.Windows.Forms.Button();
            this.btUp = new System.Windows.Forms.Button();
            this.lsvScore = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.HighScore = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(202, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Score:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbScore
            // 
            this.lbScore.BackColor = System.Drawing.Color.White;
            this.lbScore.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbScore.Location = new System.Drawing.Point(310, 41);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(61, 24);
            this.lbScore.TabIndex = 2;
            this.lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(617, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGame,
            this.howToPlay,
            this.exit});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGame
            // 
            this.newGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dễToolStripMenuItem,
            this.khóToolStripMenuItem});
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(139, 22);
            this.newGame.Text = "New Game";
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // dễToolStripMenuItem
            // 
            this.dễToolStripMenuItem.Name = "dễToolStripMenuItem";
            this.dễToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.dễToolStripMenuItem.Text = "Dễ";
            this.dễToolStripMenuItem.Click += new System.EventHandler(this.dễToolStripMenuItem_Click);
            // 
            // khóToolStripMenuItem
            // 
            this.khóToolStripMenuItem.Name = "khóToolStripMenuItem";
            this.khóToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.khóToolStripMenuItem.Text = "Khó";
            this.khóToolStripMenuItem.Click += new System.EventHandler(this.khóToolStripMenuItem_Click);
            // 
            // howToPlay
            // 
            this.howToPlay.Name = "howToPlay";
            this.howToPlay.Size = new System.Drawing.Size(139, 22);
            this.howToPlay.Text = "How To Play";
            this.howToPlay.Click += new System.EventHandler(this.howToPlay_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(139, 22);
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lb1
            // 
            this.lb1.BackColor = System.Drawing.Color.GreenYellow;
            this.lb1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.GreenYellow;
            this.lb1.Location = new System.Drawing.Point(52, 158);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(65, 64);
            this.lb1.TabIndex = 5;
            this.lb1.Text = "0";
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb5
            // 
            this.lb5.BackColor = System.Drawing.Color.GreenYellow;
            this.lb5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb5.ForeColor = System.Drawing.Color.GreenYellow;
            this.lb5.Location = new System.Drawing.Point(52, 230);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(65, 64);
            this.lb5.TabIndex = 5;
            this.lb5.Text = "0";
            this.lb5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb9
            // 
            this.lb9.BackColor = System.Drawing.Color.GreenYellow;
            this.lb9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb9.ForeColor = System.Drawing.Color.GreenYellow;
            this.lb9.Location = new System.Drawing.Point(52, 302);
            this.lb9.Name = "lb9";
            this.lb9.Size = new System.Drawing.Size(65, 64);
            this.lb9.TabIndex = 5;
            this.lb9.Text = "0";
            this.lb9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb13
            // 
            this.lb13.BackColor = System.Drawing.Color.GreenYellow;
            this.lb13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb13.ForeColor = System.Drawing.Color.GreenYellow;
            this.lb13.Location = new System.Drawing.Point(52, 374);
            this.lb13.Name = "lb13";
            this.lb13.Size = new System.Drawing.Size(65, 64);
            this.lb13.TabIndex = 6;
            this.lb13.Text = "0";
            this.lb13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb2
            // 
            this.lb2.BackColor = System.Drawing.Color.GreenYellow;
            this.lb2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.ForeColor = System.Drawing.Color.GreenYellow;
            this.lb2.Location = new System.Drawing.Point(123, 158);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(65, 64);
            this.lb2.TabIndex = 5;
            this.lb2.Text = "0";
            this.lb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb6
            // 
            this.lb6.BackColor = System.Drawing.Color.GreenYellow;
            this.lb6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb6.ForeColor = System.Drawing.Color.GreenYellow;
            this.lb6.Location = new System.Drawing.Point(123, 230);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(65, 64);
            this.lb6.TabIndex = 5;
            this.lb6.Text = "0";
            this.lb6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb10
            // 
            this.lb10.BackColor = System.Drawing.Color.GreenYellow;
            this.lb10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb10.ForeColor = System.Drawing.Color.GreenYellow;
            this.lb10.Location = new System.Drawing.Point(123, 302);
            this.lb10.Name = "lb10";
            this.lb10.Size = new System.Drawing.Size(65, 64);
            this.lb10.TabIndex = 5;
            this.lb10.Text = "0";
            this.lb10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb14
            // 
            this.lb14.BackColor = System.Drawing.Color.GreenYellow;
            this.lb14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb14.ForeColor = System.Drawing.Color.GreenYellow;
            this.lb14.Location = new System.Drawing.Point(123, 374);
            this.lb14.Name = "lb14";
            this.lb14.Size = new System.Drawing.Size(65, 64);
            this.lb14.TabIndex = 6;
            this.lb14.Text = "0";
            this.lb14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb3
            // 
            this.lb3.BackColor = System.Drawing.Color.GreenYellow;
            this.lb3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.ForeColor = System.Drawing.Color.GreenYellow;
            this.lb3.Location = new System.Drawing.Point(194, 158);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(65, 64);
            this.lb3.TabIndex = 5;
            this.lb3.Text = "0";
            this.lb3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb7
            // 
            this.lb7.BackColor = System.Drawing.Color.GreenYellow;
            this.lb7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb7.ForeColor = System.Drawing.Color.GreenYellow;
            this.lb7.Location = new System.Drawing.Point(194, 230);
            this.lb7.Name = "lb7";
            this.lb7.Size = new System.Drawing.Size(65, 64);
            this.lb7.TabIndex = 5;
            this.lb7.Text = "0";
            this.lb7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb11
            // 
            this.lb11.BackColor = System.Drawing.Color.GreenYellow;
            this.lb11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb11.ForeColor = System.Drawing.Color.GreenYellow;
            this.lb11.Location = new System.Drawing.Point(194, 302);
            this.lb11.Name = "lb11";
            this.lb11.Size = new System.Drawing.Size(65, 64);
            this.lb11.TabIndex = 5;
            this.lb11.Text = "0";
            this.lb11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb15
            // 
            this.lb15.BackColor = System.Drawing.Color.GreenYellow;
            this.lb15.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb15.ForeColor = System.Drawing.Color.GreenYellow;
            this.lb15.Location = new System.Drawing.Point(194, 374);
            this.lb15.Name = "lb15";
            this.lb15.Size = new System.Drawing.Size(65, 64);
            this.lb15.TabIndex = 6;
            this.lb15.Text = "0";
            this.lb15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb4
            // 
            this.lb4.BackColor = System.Drawing.Color.GreenYellow;
            this.lb4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4.ForeColor = System.Drawing.Color.GreenYellow;
            this.lb4.Location = new System.Drawing.Point(265, 158);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(65, 64);
            this.lb4.TabIndex = 5;
            this.lb4.Text = "0";
            this.lb4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb8
            // 
            this.lb8.BackColor = System.Drawing.Color.GreenYellow;
            this.lb8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb8.ForeColor = System.Drawing.Color.GreenYellow;
            this.lb8.Location = new System.Drawing.Point(265, 230);
            this.lb8.Name = "lb8";
            this.lb8.Size = new System.Drawing.Size(65, 64);
            this.lb8.TabIndex = 5;
            this.lb8.Text = "0";
            this.lb8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb12
            // 
            this.lb12.BackColor = System.Drawing.Color.GreenYellow;
            this.lb12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb12.ForeColor = System.Drawing.Color.GreenYellow;
            this.lb12.Location = new System.Drawing.Point(265, 302);
            this.lb12.Name = "lb12";
            this.lb12.Size = new System.Drawing.Size(65, 64);
            this.lb12.TabIndex = 5;
            this.lb12.Text = "0";
            this.lb12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb16
            // 
            this.lb16.BackColor = System.Drawing.Color.GreenYellow;
            this.lb16.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb16.ForeColor = System.Drawing.Color.GreenYellow;
            this.lb16.Location = new System.Drawing.Point(265, 374);
            this.lb16.Name = "lb16";
            this.lb16.Size = new System.Drawing.Size(65, 64);
            this.lb16.TabIndex = 6;
            this.lb16.Text = "0";
            this.lb16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btRight
            // 
            this.btRight.BackgroundImage = global::game2048.Properties.Resources.icons8_right_90;
            this.btRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btRight.Location = new System.Drawing.Point(112, 87);
            this.btRight.Name = "btRight";
            this.btRight.Size = new System.Drawing.Size(50, 40);
            this.btRight.TabIndex = 3;
            this.btRight.UseVisualStyleBackColor = true;
            this.btRight.Click += new System.EventHandler(this.btRight_Click);
            // 
            // btDown
            // 
            this.btDown.BackgroundImage = global::game2048.Properties.Resources.icons8_down_arrow_90;
            this.btDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btDown.Location = new System.Drawing.Point(56, 87);
            this.btDown.Name = "btDown";
            this.btDown.Size = new System.Drawing.Size(50, 40);
            this.btDown.TabIndex = 3;
            this.btDown.UseVisualStyleBackColor = true;
            this.btDown.Click += new System.EventHandler(this.btDown_Click);
            // 
            // btLeft
            // 
            this.btLeft.BackgroundImage = global::game2048.Properties.Resources.icons8_left_90;
            this.btLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btLeft.Location = new System.Drawing.Point(0, 87);
            this.btLeft.Name = "btLeft";
            this.btLeft.Size = new System.Drawing.Size(50, 40);
            this.btLeft.TabIndex = 3;
            this.btLeft.UseVisualStyleBackColor = true;
            this.btLeft.Click += new System.EventHandler(this.btLeft_Click);
            // 
            // btUp
            // 
            this.btUp.BackgroundImage = global::game2048.Properties.Resources.icons8_up_90;
            this.btUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btUp.Location = new System.Drawing.Point(56, 41);
            this.btUp.Name = "btUp";
            this.btUp.Size = new System.Drawing.Size(50, 40);
            this.btUp.TabIndex = 3;
            this.btUp.UseVisualStyleBackColor = true;
            this.btUp.Click += new System.EventHandler(this.btUp_Click);
            // 
            // lsvScore
            // 
            this.lsvScore.BackColor = System.Drawing.Color.Black;
            this.lsvScore.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvScore.ForeColor = System.Drawing.SystemColors.Window;
            this.lsvScore.Location = new System.Drawing.Point(376, 41);
            this.lsvScore.Name = "lsvScore";
            this.lsvScore.Size = new System.Drawing.Size(235, 397);
            this.lsvScore.TabIndex = 7;
            this.lsvScore.UseCompatibleStateImageBehavior = false;
            this.lsvScore.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(202, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "HighScore:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HighScore
            // 
            this.HighScore.BackColor = System.Drawing.Color.White;
            this.HighScore.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HighScore.Location = new System.Drawing.Point(310, 104);
            this.HighScore.Name = "HighScore";
            this.HighScore.Size = new System.Drawing.Size(61, 24);
            this.HighScore.TabIndex = 2;
            this.HighScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.BackgroundImage = global::game2048.Properties.Resources.pngtree_watercolor_dark_series_starry_sky_background_illustration_purple_greendark_colorsimple_image_72580;
            this.ClientSize = new System.Drawing.Size(617, 464);
            this.Controls.Add(this.lsvScore);
            this.Controls.Add(this.lb16);
            this.Controls.Add(this.lb15);
            this.Controls.Add(this.lb14);
            this.Controls.Add(this.lb13);
            this.Controls.Add(this.lb12);
            this.Controls.Add(this.lb11);
            this.Controls.Add(this.lb10);
            this.Controls.Add(this.lb9);
            this.Controls.Add(this.lb8);
            this.Controls.Add(this.lb7);
            this.Controls.Add(this.lb6);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btRight);
            this.Controls.Add(this.btDown);
            this.Controls.Add(this.btLeft);
            this.Controls.Add(this.btUp);
            this.Controls.Add(this.HighScore);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Game2048";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Button btUp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGame;
        private System.Windows.Forms.ToolStripMenuItem howToPlay;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btLeft;
        private System.Windows.Forms.Button btDown;
        private System.Windows.Forms.Button btRight;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb9;
        private System.Windows.Forms.Label lb13;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Label lb10;
        private System.Windows.Forms.Label lb14;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb7;
        private System.Windows.Forms.Label lb11;
        private System.Windows.Forms.Label lb15;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb8;
        private System.Windows.Forms.Label lb12;
        private System.Windows.Forms.Label lb16;
        private ListView lsvScore;
        private Label label1;
        private Label HighScore;
        private ToolStripMenuItem dễToolStripMenuItem;
        private ToolStripMenuItem khóToolStripMenuItem;
    }
}

