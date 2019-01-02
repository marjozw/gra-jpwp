namespace GraMatematycznyDeszcz
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.resetButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.timerLoop = new System.Windows.Forms.Timer(this.components);
            this.score = new System.Windows.Forms.Label();
            this.waterPanel = new System.Windows.Forms.Panel();
            this.bug = new System.Windows.Forms.PictureBox();
            this.kropla1 = new GraMatematycznyDeszcz.Kropla();
            this.equation1 = new GraMatematycznyDeszcz.Equation();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kropla6 = new GraMatematycznyDeszcz.Kropla();
            this.equation6 = new GraMatematycznyDeszcz.Equation();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.kropla5 = new GraMatematycznyDeszcz.Kropla();
            this.equation5 = new GraMatematycznyDeszcz.Equation();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.kropla4 = new GraMatematycznyDeszcz.Kropla();
            this.equation4 = new GraMatematycznyDeszcz.Equation();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.kropla3 = new GraMatematycznyDeszcz.Kropla();
            this.equation3 = new GraMatematycznyDeszcz.Equation();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.kropla2 = new GraMatematycznyDeszcz.Kropla();
            this.equation2 = new GraMatematycznyDeszcz.Equation();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bug)).BeginInit();
            this.kropla1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.kropla6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.kropla5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.kropla4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.kropla3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.kropla2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Peru;
            this.panelMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMenu.BackgroundImage")));
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.resetButton);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Location = new System.Drawing.Point(63, 134);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(319, 316);
            this.panelMenu.TabIndex = 0;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.SeaShell;
            this.resetButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(118)))), ((int)(((byte)(82)))));
            this.resetButton.FlatAppearance.BorderSize = 3;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Lucida Handwriting", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(74)))), ((int)(((byte)(68)))));
            this.resetButton.Location = new System.Drawing.Point(56, 194);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(207, 77);
            this.resetButton.TabIndex = 1;
            this.resetButton.TabStop = false;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaShell;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(118)))), ((int)(((byte)(82)))));
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Handwriting", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(74)))), ((int)(((byte)(68)))));
            this.button1.Location = new System.Drawing.Point(56, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 77);
            this.button1.TabIndex = 0;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultBox
            // 
            this.resultBox.BackColor = System.Drawing.Color.Honeydew;
            this.resultBox.Font = new System.Drawing.Font("Swis721 BlkCn BT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.resultBox.Location = new System.Drawing.Point(636, 550);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(137, 52);
            this.resultBox.TabIndex = 1;
            this.resultBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resultBox_KeyPress);
            // 
            // timerLoop
            // 
            this.timerLoop.Interval = 500;
            this.timerLoop.Tick += new System.EventHandler(this.timerLoop_Tick);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.SeaShell;
            this.score.Font = new System.Drawing.Font("Lucida Handwriting", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(74)))), ((int)(((byte)(68)))));
            this.score.Location = new System.Drawing.Point(62, 550);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(183, 45);
            this.score.TabIndex = 2;
            this.score.Text = "Wynik 0";
            // 
            // waterPanel
            // 
            this.waterPanel.BackColor = System.Drawing.Color.Transparent;
            this.waterPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("waterPanel.BackgroundImage")));
            this.waterPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.waterPanel.Location = new System.Drawing.Point(-9, 608);
            this.waterPanel.Name = "waterPanel";
            this.waterPanel.Size = new System.Drawing.Size(1023, 505);
            this.waterPanel.TabIndex = 8;
            // 
            // bug
            // 
            this.bug.BackColor = System.Drawing.Color.Transparent;
            this.bug.Image = ((System.Drawing.Image)(resources.GetObject("bug.Image")));
            this.bug.Location = new System.Drawing.Point(333, 14);
            this.bug.Name = "bug";
            this.bug.Size = new System.Drawing.Size(49, 52);
            this.bug.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bug.TabIndex = 9;
            this.bug.TabStop = false;
            this.bug.Visible = false;
            this.bug.Click += new System.EventHandler(this.bug_Click);
            // 
            // kropla1
            // 
            this.kropla1.BackColor = System.Drawing.Color.Transparent;
            this.kropla1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.kropla1.Controls.Add(this.equation1);
            this.kropla1.Controls.Add(this.pictureBox1);
            this.kropla1.Location = new System.Drawing.Point(504, 31);
            this.kropla1.Name = "kropla1";
            this.kropla1.Size = new System.Drawing.Size(137, 152);
            this.kropla1.TabIndex = 6;
            this.kropla1.Visible = false;
            // 
            // equation1
            // 
            this.equation1.AutoSize = true;
            this.equation1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.equation1.Font = new System.Drawing.Font("Swis721 BlkCn BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equation1.ForeColor = System.Drawing.Color.Azure;
            this.equation1.Location = new System.Drawing.Point(30, 64);
            this.equation1.Name = "equation1";
            this.equation1.Size = new System.Drawing.Size(137, 35);
            this.equation1.TabIndex = 8;
            this.equation1.Text = "equation1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GraMatematycznyDeszcz.Properties.Resources.kropla;
            this.pictureBox1.Location = new System.Drawing.Point(7, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Raindrop";
            // 
            // kropla6
            // 
            this.kropla6.BackColor = System.Drawing.Color.Transparent;
            this.kropla6.Controls.Add(this.equation6);
            this.kropla6.Controls.Add(this.pictureBox6);
            this.kropla6.Location = new System.Drawing.Point(859, -150);
            this.kropla6.Name = "kropla6";
            this.kropla6.Size = new System.Drawing.Size(137, 152);
            this.kropla6.TabIndex = 7;
            this.kropla6.Visible = false;
            // 
            // equation6
            // 
            this.equation6.AutoSize = true;
            this.equation6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.equation6.Font = new System.Drawing.Font("Swis721 BlkCn BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equation6.ForeColor = System.Drawing.Color.Azure;
            this.equation6.Location = new System.Drawing.Point(30, 64);
            this.equation6.Name = "equation6";
            this.equation6.Size = new System.Drawing.Size(137, 35);
            this.equation6.TabIndex = 4;
            this.equation6.Text = "equation6";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::GraMatematycznyDeszcz.Properties.Resources.kropla;
            this.pictureBox6.Location = new System.Drawing.Point(7, 18);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(127, 131);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "Raindrop";
            // 
            // kropla5
            // 
            this.kropla5.BackColor = System.Drawing.Color.Transparent;
            this.kropla5.Controls.Add(this.equation5);
            this.kropla5.Controls.Add(this.pictureBox5);
            this.kropla5.Location = new System.Drawing.Point(683, -150);
            this.kropla5.Name = "kropla5";
            this.kropla5.Size = new System.Drawing.Size(137, 152);
            this.kropla5.TabIndex = 7;
            this.kropla5.Visible = false;
            // 
            // equation5
            // 
            this.equation5.AutoSize = true;
            this.equation5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.equation5.Font = new System.Drawing.Font("Swis721 BlkCn BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equation5.ForeColor = System.Drawing.Color.Azure;
            this.equation5.Location = new System.Drawing.Point(30, 64);
            this.equation5.Name = "equation5";
            this.equation5.Size = new System.Drawing.Size(137, 35);
            this.equation5.TabIndex = 4;
            this.equation5.Text = "equation5";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::GraMatematycznyDeszcz.Properties.Resources.kropla;
            this.pictureBox5.Location = new System.Drawing.Point(7, 18);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(127, 131);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "Raindrop";
            // 
            // kropla4
            // 
            this.kropla4.BackColor = System.Drawing.Color.Transparent;
            this.kropla4.Controls.Add(this.equation4);
            this.kropla4.Controls.Add(this.pictureBox4);
            this.kropla4.Location = new System.Drawing.Point(504, -150);
            this.kropla4.Name = "kropla4";
            this.kropla4.Size = new System.Drawing.Size(137, 152);
            this.kropla4.TabIndex = 7;
            this.kropla4.Visible = false;
            // 
            // equation4
            // 
            this.equation4.AutoSize = true;
            this.equation4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.equation4.Font = new System.Drawing.Font("Swis721 BlkCn BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equation4.ForeColor = System.Drawing.Color.Azure;
            this.equation4.Location = new System.Drawing.Point(30, 64);
            this.equation4.Name = "equation4";
            this.equation4.Size = new System.Drawing.Size(137, 35);
            this.equation4.TabIndex = 4;
            this.equation4.Text = "equation4";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::GraMatematycznyDeszcz.Properties.Resources.kropla;
            this.pictureBox4.Location = new System.Drawing.Point(7, 18);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(127, 131);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "Raindrop";
            // 
            // kropla3
            // 
            this.kropla3.BackColor = System.Drawing.Color.Transparent;
            this.kropla3.Controls.Add(this.equation3);
            this.kropla3.Controls.Add(this.pictureBox3);
            this.kropla3.Location = new System.Drawing.Point(859, 31);
            this.kropla3.Name = "kropla3";
            this.kropla3.Size = new System.Drawing.Size(137, 152);
            this.kropla3.TabIndex = 7;
            this.kropla3.Visible = false;
            // 
            // equation3
            // 
            this.equation3.AutoSize = true;
            this.equation3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.equation3.Font = new System.Drawing.Font("Swis721 BlkCn BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equation3.ForeColor = System.Drawing.Color.Azure;
            this.equation3.Location = new System.Drawing.Point(30, 64);
            this.equation3.Name = "equation3";
            this.equation3.Size = new System.Drawing.Size(137, 35);
            this.equation3.TabIndex = 4;
            this.equation3.Text = "equation3";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::GraMatematycznyDeszcz.Properties.Resources.kropla;
            this.pictureBox3.Location = new System.Drawing.Point(7, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(127, 131);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "Raindrop";
            // 
            // kropla2
            // 
            this.kropla2.BackColor = System.Drawing.Color.Transparent;
            this.kropla2.Controls.Add(this.equation2);
            this.kropla2.Controls.Add(this.pictureBox2);
            this.kropla2.Location = new System.Drawing.Point(683, 31);
            this.kropla2.Name = "kropla2";
            this.kropla2.Size = new System.Drawing.Size(137, 152);
            this.kropla2.TabIndex = 7;
            this.kropla2.Visible = false;
            // 
            // equation2
            // 
            this.equation2.AutoSize = true;
            this.equation2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.equation2.Font = new System.Drawing.Font("Swis721 BlkCn BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equation2.ForeColor = System.Drawing.Color.Azure;
            this.equation2.Location = new System.Drawing.Point(30, 64);
            this.equation2.Name = "equation2";
            this.equation2.Size = new System.Drawing.Size(137, 35);
            this.equation2.TabIndex = 4;
            this.equation2.Text = "equation2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::GraMatematycznyDeszcz.Properties.Resources.kropla;
            this.pictureBox2.Location = new System.Drawing.Point(7, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 131);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Raindrop";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GraMatematycznyDeszcz.Properties.Resources.tlo;
            this.ClientSize = new System.Drawing.Size(1008, 622);
            this.Controls.Add(this.kropla1);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.kropla6);
            this.Controls.Add(this.kropla5);
            this.Controls.Add(this.kropla4);
            this.Controls.Add(this.kropla3);
            this.Controls.Add(this.kropla2);
            this.Controls.Add(this.score);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.waterPanel);
            this.Controls.Add(this.bug);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1024, 660);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Raindrops";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GameForm_KeyPress);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bug)).EndInit();
            this.kropla1.ResumeLayout(false);
            this.kropla1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.kropla6.ResumeLayout(false);
            this.kropla6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.kropla5.ResumeLayout(false);
            this.kropla5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.kropla4.ResumeLayout(false);
            this.kropla4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.kropla3.ResumeLayout(false);
            this.kropla3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.kropla2.ResumeLayout(false);
            this.kropla2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timerLoop;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Kropla kropla1;
        private Kropla kropla2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Kropla kropla3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Kropla kropla4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Kropla kropla5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Kropla kropla6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private Equation equation6;
        private Equation equation5;
        private Equation equation4;
        private Equation equation3;
        private Equation equation1;
        private Equation equation2;
        private System.Windows.Forms.Panel waterPanel;
        private System.Windows.Forms.PictureBox bug;
    }
}

