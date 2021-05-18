namespace NewTetris {
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
            this.label2.Location = new System.Drawing.Point(42, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Level:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLevel.Location = new System.Drawing.Point(132, 188);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(42, 25);
            this.lblLevel.TabIndex = 10;
            this.lblLevel.Text = "XX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(42, 247);
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
            this.nextShapelbl.Location = new System.Drawing.Point(206, 231);
            this.nextShapelbl.MinimumSize = new System.Drawing.Size(120, 120);
            this.nextShapelbl.Name = "nextShapelbl";
            this.nextShapelbl.Size = new System.Drawing.Size(120, 120);
            this.nextShapelbl.TabIndex = 12;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("TeXGyreAdventor", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.title.Location = new System.Drawing.Point(442, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(352, 99);
            this.title.TabIndex = 13;
            this.title.Text = "Tetris v403";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::NewTetris.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1183, 803);
            this.Controls.Add(this.title);
            this.Controls.Add(this.nextShapelbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPlayingField);
            this.Name = "FrmMain";
            this.Text = "Tetris";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label lblPlayingField;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblLevel;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Timer tmrCurrentPieceFall;
        private System.Windows.Forms.Label nextShapelbl;
        private System.Windows.Forms.Label title;
    }
}

