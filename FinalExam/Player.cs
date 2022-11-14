//Programmer: Emmaleigh Stone
//Due Date: 05/13/2022

namespace FinalGame
{
    //Player class: class that allows a degree of seperation for each new player1Turn variable
    class Player
    {

        //Player() constructor: constructor that sets UI class variable as a Player class variable
        public Player(bool player1Turn)
        {
            Player1Turn = player1Turn;
        }

        //Player1Turn() property: property that collects Player class variable by grabbing it from the Player() method
        public bool Player1Turn { get; set; }
    }
}
