using MasterMind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasterMind.BusinessLogic
{
    public class GetHints
    {
        //Used to obtain the number of colors in their respective right positions- AJ Raaths
        public int CorrectPositionsCorrectColors(ColorSelection colorSelection , GameColors gameColors)
        {
            int result = 0;
            if (colorSelection.PlayerColor1 == gameColors.GameColor1)
            {
                result++;
            }
            if (colorSelection.PlayerColor2 == gameColors.GameColor2)
            {
                result++;
            }
            if (colorSelection.PlayerColor3 == gameColors.GameColor3)
            {
                result++;
            }
            if (colorSelection.PlayerColor4 == gameColors.GameColor4)
            {
                result++;
            }

            return result;
        }
        //Used to obtain the number of colors that are correct but situated in a wrong position - AJ Raaths
        public int WrongPositionCorrectColors(ColorSelection colorSelection, GameColors gameColors)
        {
            int result = 0;
            string[] array = new string[4];
            
            if (colorSelection.PlayerColor1 == gameColors.GameColor2 || colorSelection.PlayerColor1 == gameColors.GameColor3 || colorSelection.PlayerColor1 == gameColors.GameColor4)
            {
                result++;
            }
            if (colorSelection.PlayerColor2 == gameColors.GameColor1 || colorSelection.PlayerColor2 == gameColors.GameColor3 || colorSelection.PlayerColor2 == gameColors.GameColor4)
            {
                result++;
            }
            if (colorSelection.PlayerColor3 == gameColors.GameColor1 || colorSelection.PlayerColor3 == gameColors.GameColor2 || colorSelection.PlayerColor3 == gameColors.GameColor4)
            {
                result++;
            }
            if (colorSelection.PlayerColor4 == gameColors.GameColor1 || colorSelection.PlayerColor4 == gameColors.GameColor2 || colorSelection.PlayerColor4 == gameColors.GameColor3)
            {
                result++;
            }

            return result;
        }


    }
}
