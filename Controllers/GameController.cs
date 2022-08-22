using MasterMind.BusinessLogic;
using MasterMind.Models;
using MasterMind.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasterMind.Controllers
{
    public class GameController : Controller
    {
        private readonly ColorSelectionDBContext _context;

        public GameController(ColorSelectionDBContext context)
        {
            _context = context;
        }
        //Instantiate Models - AJ Raaths 
        ColorSelection colorSelectionModel = new ColorSelection();
        GameColors gameColorsModel = new GameColors();
        GameViewModel gameViewModel = new GameViewModel();
        public IActionResult Index(ColorSelection colorSelection)
        {
            //Generate 4 random numbers from 6 colors
            if (gameViewModel.GameColors == null)
            {   
                string[] gameColors = new string[] { "red", "yellow", "blue", "green", "black", "white" };
                Random rnd = new Random();

                gameColorsModel.GameColor1 = gameColors.OrderBy(x => rnd.Next()).First();
                gameColorsModel.GameColor2 = gameColors.OrderBy(x => rnd.Next()).First();
                gameColorsModel.GameColor3 = gameColors.OrderBy(x => rnd.Next()).First();
                gameColorsModel.GameColor4 = gameColors.OrderBy(x => rnd.Next()).First();

                gameViewModel.ColorSelection = colorSelectionModel;
                gameViewModel.GameColors = gameColorsModel;
                _context.Add(gameColorsModel);
                _context.SaveChanges();
            }

            gameViewModel.ColorSelection = colorSelection;
            return View(gameViewModel);
        }

     
        [HttpPost]
        public IActionResult GetResults(ColorSelection colorSelection)
        {
            //Get the new random generated numbers from db context - AJ Raaths
            gameColorsModel = _context.GameColors.First();
            //Instantiate the getHints class
            var getHints = new GetHints();
            //Populate the colorSelection model with new chosen colors - AJ Raaths
            colorSelectionModel = colorSelection;
            colorSelectionModel.CorrectColorCorrectPosition = getHints.CorrectPositionsCorrectColors(colorSelection, gameColorsModel);
            colorSelectionModel.CorrectColorWrongPosition = getHints.WrongPositionCorrectColors(colorSelection, gameColorsModel);
            gameViewModel.ColorSelection = colorSelectionModel;
            gameViewModel.GameColors = gameColorsModel;
            _context.Add(colorSelection);
            _context.SaveChanges();
            //Send view model to new Hints partial view - AJ Raaths
            return PartialView("Hints",gameViewModel); 
        }
    }
}
