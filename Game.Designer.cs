namespace Ecosia_Game
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.fly = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.ev = new System.Windows.Forms.PictureBox();
            this.tree = new System.Windows.Forms.PictureBox();
            this.ground2 = new System.Windows.Forms.PictureBox();
            this.ev2 = new System.Windows.Forms.PictureBox();
            this.tohum = new System.Windows.Forms.PictureBox();
            this.tree2 = new System.Windows.Forms.PictureBox();
            this.tree3 = new System.Windows.Forms.PictureBox();
            this.tree4 = new System.Windows.Forms.PictureBox();
            this.tohum_timer1 = new System.Windows.Forms.Timer(this.components);
            this.tohum_timer2 = new System.Windows.Forms.Timer(this.components);
            this.tohum_timer3 = new System.Windows.Forms.Timer(this.components);
            this.tohum_timer4 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ev2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tohum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree4)).BeginInit();
            this.SuspendLayout();
            // 
            // fly
            // 
            this.fly.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fly.BackgroundImage")));
            this.fly.Location = new System.Drawing.Point(0, 45);
            this.fly.Name = "fly";
            this.fly.Size = new System.Drawing.Size(100, 76);
            this.fly.TabIndex = 2;
            this.fly.TabStop = false;
            // 
            // ground
            // 
            this.ground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ground.BackgroundImage")));
            this.ground.Location = new System.Drawing.Point(0, 395);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(199, 33);
            this.ground.TabIndex = 9;
            this.ground.TabStop = false;
            // 
            // ev
            // 
            this.ev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ev.BackgroundImage")));
            this.ev.Location = new System.Drawing.Point(192, 257);
            this.ev.Name = "ev";
            this.ev.Size = new System.Drawing.Size(192, 171);
            this.ev.TabIndex = 10;
            this.ev.TabStop = false;
            // 
            // tree
            // 
            this.tree.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tree.BackgroundImage")));
            this.tree.Location = new System.Drawing.Point(0, 321);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(84, 75);
            this.tree.TabIndex = 13;
            this.tree.TabStop = false;
            this.tree.Visible = false;
            // 
            // ground2
            // 
            this.ground2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ground2.BackgroundImage")));
            this.ground2.Location = new System.Drawing.Point(384, 395);
            this.ground2.Name = "ground2";
            this.ground2.Size = new System.Drawing.Size(195, 33);
            this.ground2.TabIndex = 12;
            this.ground2.TabStop = false;
            // 
            // ev2
            // 
            this.ev2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ev2.BackgroundImage")));
            this.ev2.Location = new System.Drawing.Point(577, 257);
            this.ev2.Name = "ev2";
            this.ev2.Size = new System.Drawing.Size(382, 172);
            this.ev2.TabIndex = 11;
            this.ev2.TabStop = false;
            // 
            // tohum
            // 
            this.tohum.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tohum.BackgroundImage")));
            this.tohum.Location = new System.Drawing.Point(58, 114);
            this.tohum.Name = "tohum";
            this.tohum.Size = new System.Drawing.Size(13, 22);
            this.tohum.TabIndex = 14;
            this.tohum.TabStop = false;
            this.tohum.Visible = false;
            // 
            // tree2
            // 
            this.tree2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tree2.BackgroundImage")));
            this.tree2.Location = new System.Drawing.Point(102, 321);
            this.tree2.Name = "tree2";
            this.tree2.Size = new System.Drawing.Size(84, 75);
            this.tree2.TabIndex = 15;
            this.tree2.TabStop = false;
            this.tree2.Visible = false;
            // 
            // tree3
            // 
            this.tree3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tree3.BackgroundImage")));
            this.tree3.Location = new System.Drawing.Point(393, 320);
            this.tree3.Name = "tree3";
            this.tree3.Size = new System.Drawing.Size(84, 75);
            this.tree3.TabIndex = 16;
            this.tree3.TabStop = false;
            this.tree3.Visible = false;
            // 
            // tree4
            // 
            this.tree4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tree4.BackgroundImage")));
            this.tree4.Location = new System.Drawing.Point(487, 319);
            this.tree4.Name = "tree4";
            this.tree4.Size = new System.Drawing.Size(84, 75);
            this.tree4.TabIndex = 17;
            this.tree4.TabStop = false;
            this.tree4.Visible = false;
            // 
            // tohum_timer1
            // 
            this.tohum_timer1.Tick += new System.EventHandler(this.tohum_timer1_Tick);
            // 
            // tohum_timer2
            // 
            this.tohum_timer2.Tick += new System.EventHandler(this.tohum_timer2_Tick);
            // 
            // tohum_timer3
            // 
            this.tohum_timer3.Tick += new System.EventHandler(this.tohum_timer3_Tick);
            // 
            // tohum_timer4
            // 
            this.tohum_timer4.Tick += new System.EventHandler(this.tohum_timer4_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("vtks distress", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Kalan Tohum Sayisi : ";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(178, 8);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(23, 24);
            this.score.TabIndex = 20;
            this.score.Text = "4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1051, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "_____________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("vtks distress", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(892, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "LEVEL 1";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(959, 427);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tree4);
            this.Controls.Add(this.tree3);
            this.Controls.Add(this.tree2);
            this.Controls.Add(this.tohum);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.ground2);
            this.Controls.Add(this.ev2);
            this.Controls.Add(this.ev);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.fly);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.fly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ev2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tohum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox fly;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox ev;
        private System.Windows.Forms.PictureBox tree;
        private System.Windows.Forms.PictureBox ground2;
        private System.Windows.Forms.PictureBox ev2;
        private System.Windows.Forms.PictureBox tohum;
        private System.Windows.Forms.PictureBox tree2;
        private System.Windows.Forms.PictureBox tree3;
        private System.Windows.Forms.PictureBox tree4;
        private System.Windows.Forms.Timer tohum_timer1;
        private System.Windows.Forms.Timer tohum_timer2;
        private System.Windows.Forms.Timer tohum_timer3;
        private System.Windows.Forms.Timer tohum_timer4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}