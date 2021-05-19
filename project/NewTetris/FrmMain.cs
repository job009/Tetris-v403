using NewTetris.Properties;
using NewTetris_Lib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace NewTetris
{
    public partial class FrmMain : Form
    {
        public Game game;

        public static SoundPlayer clearSound = new SoundPlayer(Resources.clear);
        public static SoundPlayer landSound = new SoundPlayer(Resources.fall);
        public static SoundPlayer tetrisSound = new SoundPlayer(Resources.success);


        public FrmMain()
        {
            var images = typeof(Properties.Resources)
               .GetProperties(BindingFlags.Static | BindingFlags.NonPublic |
                                                    BindingFlags.Public)
               .Where(p => p.PropertyType == typeof(Bitmap) & p.Name.Contains("block"))
               .Select(x => new { Name = x.Name, Image = x.GetValue(null, null) })
               .ToList();

            InitializeComponent();
            var random = new Random();
            int index = random.Next(images.Count);

            Game.imgPiece = (Image)images[index].Image;
            Console.WriteLine(images[index]);


            game = new Game();
            Game.field = lblPlayingField;
            Game.next = nextShapelbl;

    }

        private void tmrCurrentPieceFall_Tick(object sender, EventArgs e)
        {
            if (Game.curShape != null)
            {
                if (!Game.curShape.TryMoveDown())
                {
                    landSound.Play();
                    Game.curShape.DissolveIntoField();
                    Game.nextShape.dest = true;
                    Game.curShape = Game.nextShape;
                    Game.nextShape = null;
                    PlayingField.GetInstance().CheckClearAllRows();
                    this.lblLevel.Text = Game.level.ToString();
                    this.scoreIntlbl.Text = Game.score.ToString();

                    var images = typeof(Properties.Resources)
              .GetProperties(BindingFlags.Static | BindingFlags.NonPublic |
                                                   BindingFlags.Public)
              .Where(p => p.PropertyType == typeof(Bitmap) & p.Name.Contains("block"))
              .Select(x => new { Name = x.Name, Image = x.GetValue(null, null) })
              .ToList();

                    var random = new Random();
                    int index = random.Next(images.Count);

                    Game.imgPiece = (Image)images[index].Image;
                    Console.WriteLine(images[index]);

                }
                if (Game.nextShape == null)
                {
                    Random random = new Random();
                    int shapeNum = random.Next(7);
                    ShapeType shapeType = (ShapeType)shapeNum;
                    Console.WriteLine("next shape: " + shapeType);
                    Game.nextShape = ShapeFactory.MakeShape(shapeType, true);
                }
            }
            
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Game.curShape.TryMoveLeft();
            }
            else if (e.KeyCode == Keys.Right)
            {
                Game.curShape.TryMoveRight();
            }
            else if (e.KeyCode == Keys.Up)
            {
                while (Game.curShape.TryMoveDown() == true)
                {
                    Game.curShape.TryMoveDown();
                }
                Game.curShape.DissolveIntoField();
            }

            else if (e.KeyCode == Keys.Down)
            {
                Game.curShape.TryMoveDown();
            }
            else if (e.KeyCode == Keys.Z)
            {
                Game.curShape.RotateCCW();
            }
            else if (e.KeyCode == Keys.X)
            {
                Game.curShape.RotateCW();
            }
            else if (e.KeyCode == Keys.T)
            {
                Console.WriteLine("pressed");
                tetrislbl.Visible = true;
                tetrisSound.Play();
                Thread.Sleep(1000);
                tetrislbl.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game.NextShape();
            button1.Visible = false;
        }
    }
}
