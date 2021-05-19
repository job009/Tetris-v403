using System;
using System.Drawing;
using System.Windows.Forms;

namespace NewTetris_Lib
{
    /// <summary>
    /// Oracle game class controling the entire game
    /// </summary>
    public class Game
    {
        /// <summary>
        /// Current level the player is on - currently unused
        /// </summary>
        public static int level = 1;


        private static int totalLines = 0;


        /// <summary>
        /// Flag to see if player is currently playing the level
        /// and therefore level code should be running - currently unused
        /// </summary>
        private bool isPlaying;

        /// <summary>
        /// Current player score - currently unused
        /// </summary>
        public static int score = 0;

        /// <summary>
        /// Random object used to randomly select next shape
        /// to appear in level
        /// </summary>
        private Random random;

        /// <summary>
        /// Current shape dropping onto the playing field
        /// </summary>
        public static Shape curShape;


        /// <summary>
        /// Next shape to be displayed in the side field
        /// and played after the current piece is placed
        /// </summary>
        public static Shape nextShape;

        /// <summary>
        /// Link to widget displaying the playing field. 
        /// Used to place pieces and shapes inside of it.
        /// </summary>
        public static Control field;


        /// <summary>
        /// Link to widget displaying the playing field. 
        /// Used to place pieces and shapes inside of it.
        /// </summary>
        public static Control next;

        /// <summary>
        /// Holds the image for a piece that is used to 
        /// compose a shape. This is used so the New Tetris Library
        /// can retrieve the image for a shape.
        /// </summary>
        public static Image imgPiece;

        /// <summary>
        /// Default constructor initializing random field and setting
        /// curShape to null
        /// </summary>
        public Game()
        {
            random = new Random();
            curShape = null;
            nextShape = null;
        }

        public static void increaseScore(int linesCleared)
        {

            totalLines += linesCleared;
            if (linesCleared == 1)
            {
                score += 10 * level;

            }
            else if (linesCleared == 2)
            {
                score += 30 * level;
            }
            else if (linesCleared == 3)
            {
                score += 60 * level;
            }
            else if (linesCleared == 4)
            {
                score += 100 * level;
            }

            if (totalLines % 10 == 0 && totalLines != 0)
            {
                level++;
            }
        }

        /// <summary>
        /// Generates the next shape to be put into the playing field
        /// </summary>
        public void NextShape()
        {
            int shapeNum = random.Next(7);
            ShapeType shapeType = (ShapeType)shapeNum;
            curShape = ShapeFactory.MakeShape(shapeType, true);
            Game.next.Controls.Clear();

        }
    }
}
