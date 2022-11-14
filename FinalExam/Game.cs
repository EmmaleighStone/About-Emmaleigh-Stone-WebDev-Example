//Programmer: Emmaleigh Stone
//Due Date: 05/13/2022

namespace FinalGame
{
    //Game class: class that allows a degree of seperation for each new gameOver variable
    class Game
    {

        //Game() constructor: constructor that sets UI class variable as a Game class variable
        public Game(bool gameOver)
        {
            GameOver = gameOver;
        }

        //GameOver() property: property that collects Game class variable by grabbing it from the Game() method
        public bool GameOver { get; set; }
    }
}
