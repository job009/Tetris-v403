using System;
using System.Diagnostics;

namespace NewTetris_Lib {
  /// <summary>
  /// Encodes information about the playing
  /// field of the game. Uses a grid of rows
  /// and cols storing 1 for occupied and 0
  /// for vacant
  /// </summary>
  public class PlayingField {
    /// <summary>
    /// Singleton pattern instance
    /// </summary>
    private static PlayingField instance = null;

    /// <summary>
    /// Grid holding 1 for occupied, 0 for vacant
    /// </summary>
    public int[,] field;

    /// <summary>
    /// Observer pattern event for when a row is 
    /// cleared - currently unused
    /// </summary>
    public event Action OnRowClear;

    /// <summary>
    /// Default constructor initializing the field
    /// to 22 rows and 15 columns
    /// </summary>
    private PlayingField() {
      field = new int[22, 15];
    }

    /// <summary>
    /// Retrieves the Singleton pattern instance
    /// </summary>
    /// <returns>The Singleton instance</returns>
    public static PlayingField GetInstance() {
      if (instance == null) {
        instance = new PlayingField();
      }
      return instance;
    }

    /// <summary>
    /// Checks if a location in the field is empty (i.e. vacant)
    /// </summary>
    /// <param name="r">Row</param>
    /// <param name="c">Column</param>
    /// <returns>True if empty, False otherwise</returns>
    public bool IsEmpty(int r, int c) {
      if (r < 0 || r >= field.GetLength(0) || c < 0 || c >= field.GetLength(1)) {
        return false;
      }
      return field[r, c] == 0;
    }


    public void DropAboveRows(int r) { 
        for (int r2 = r-1; r2 >= 1; r2--) { 
        
            for (int c = 0; c <= 14; c++) { 

                if (IsEmpty(r2,c) == false) {
                    GetInstance().field[r2,c] = 0;
                    GetInstance().field[r2+1,c] = 1;
                }
            }
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public void CheckClearAllRows(){

        bool fullRow = true;
        for (int r = 21; r >= 1; r--){

            fullRow = true;
            for (int c = 0; c <= 14; c++){

                if (IsEmpty(r, c) == true)
                {
                    fullRow = false;
                }
            }
            if (fullRow == true)
            {
                Piece.RemoveRowImg(r);
                for (int c = 0; c <= 14; c++){

                    GetInstance().field[r, c] = 0;
                      
                }
                DropAboveRows(r);
                
            }
        }
    }
  }
}
