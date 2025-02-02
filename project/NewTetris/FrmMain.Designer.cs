﻿namespace NewTetris {
  partial class FrmMain {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.lblPlayingField = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tmrCurrentPieceFall = new System.Windows.Forms.Timer(this.components);
            this.nextShapelbl = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreIntlbl = new System.Windows.Forms.Label();
            this.tetrislbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlayingField
            // 
            this.lblPlayingField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPlayingField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayingField.Location = new System.Drawing.Point(396, 119);
            this.lblPlayingField.Name = "lblPlayingField";
            this.lblPlayingField.Size = new System.Drawing.Size(450, 660);
            this.lblPlayingField.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(64, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Level:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.White;
            this.lblLevel.Location = new System.Drawing.Point(141, 224);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(34, 37);
            this.lblLevel.TabIndex = 10;
            this.lblLevel.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(64, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Next Block:";
            // 
            // tmrCurrentPieceFall
            // 
            this.tmrCurrentPieceFall.Enabled = true;
            this.tmrCurrentPieceFall.Interval = 500;
            this.tmrCurrentPieceFall.Tick += new System.EventHandler(this.tmrCurrentPieceFall_Tick);
            // 
            // nextShapelbl
            // 
            this.nextShapelbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nextShapelbl.AutoSize = true;
            this.nextShapelbl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.nextShapelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nextShapelbl.Location = new System.Drawing.Point(208, 292);
            this.nextShapelbl.MinimumSize = new System.Drawing.Size(120, 120);
            this.nextShapelbl.Name = "nextShapelbl";
            this.nextShapelbl.Size = new System.Drawing.Size(120, 120);
            this.nextShapelbl.TabIndex = 12;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.title.Location = new System.Drawing.Point(442, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(360, 73);
            this.title.TabIndex = 13;
            this.title.Text = "Tetris v403";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(141, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Score";
            // 
            // scoreIntlbl
            // 
            this.scoreIntlbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.scoreIntlbl.BackColor = System.Drawing.Color.Transparent;
            this.scoreIntlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreIntlbl.ForeColor = System.Drawing.Color.White;
            this.scoreIntlbl.Location = new System.Drawing.Point(148, 79);
            this.scoreIntlbl.Name = "scoreIntlbl";
            this.scoreIntlbl.Size = new System.Drawing.Size(89, 55);
            this.scoreIntlbl.TabIndex = 15;
            this.scoreIntlbl.Text = "0";
            this.scoreIntlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tetrislbl
            // 
            this.tetrislbl.AutoSize = true;
            this.tetrislbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tetrislbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tetrislbl.ForeColor = System.Drawing.Color.Red;
            this.tetrislbl.Location = new System.Drawing.Point(409, 264);
            this.tetrislbl.Name = "tetrislbl";
            this.tetrislbl.Size = new System.Drawing.Size(421, 108);
            this.tetrislbl.TabIndex = 16;
            this.tetrislbl.Text = "TETRIS!";
            this.tetrislbl.Visible = false;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(567, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 39);
            this.button1.TabIndex = 17;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::NewTetris.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1183, 803);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tetrislbl);
            this.Controls.Add(this.scoreIntlbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.nextShapelbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPlayingField);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Tetris";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPlayingField;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblLevel;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Timer tmrCurrentPieceFall;
        private System.Windows.Forms.Label nextShapelbl;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoreIntlbl;
        private System.Windows.Forms.Label tetrislbl;
        
    }
}

