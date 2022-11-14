using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

//Program: FinalGame: Connect Four
//Purpose: to allow two players to play Connect Four on an app
//Programmer: Emmaleigh Stone
//Due Date: 05/13/2022

namespace FinalGame
{
   //User Experience (UI) class: class used to code actions for the controls in connect four game
    public partial class MainWindow : Window
    {
        private int[] results;
        private readonly Player a = new Player(true);
        private readonly Game b = new Game(false);

        //MainWindow method: method that opens connect four app window
        public MainWindow()
        {
            InitializeComponent();
            results = new int[43];
            for (var i = 0; i < results.Length; i++)
            {
                results[i] = 3;
                Container.Children.Cast<Button>().ToList().ForEach(button =>
                {
                    button.Content = string.Empty;
                    button.Background = Brushes.White;
                });
                b.GameOver = false;
                play.Content = "Welcome to Connect Four! Click here to start your game!";
                play.Background = Brushes.MistyRose;
            }
        }

        //play_Click() method: method to set up new connect four game at end
        private void play_Click(object sender, RoutedEventArgs e)
        {
            StartGame();
        }

        //StartGame() method: method to set up a connect four game
        private void StartGame()
        {
            results = new int[43];
            for (var i = 0; i < results.Length; i++)
            {
                results[i] = 0;
                Container.Children.Cast<Button>().ToList().ForEach(button =>
                {
                    button.Content = string.Empty;
                    button.Background = Brushes.White;
                });
                b.GameOver = false;
                a.Player1Turn = true;
                play.Content = "Player One's Turn";
                play.Foreground = Brushes.ForestGreen;
            }
        }

        //C0_Click method: method to identify which button in column 0 has not yet been filled and fill it based on the player's turn
        private void C0_Click(object sender, RoutedEventArgs e)
        {
            if (b.GameOver)
            {
                return;
            }
            else
            {
                if (a.Player1Turn)
                {
                    if (results[36] == 0)
                    {
                        results[36] = 1;
                        b1.Content = "🔵";
                        b1.Foreground = Brushes.ForestGreen;
                    }
                    else if (results[36] != 0 && results[29] == 0)
                    {
                        results[29] = 1;
                        b8.Content = "🔵";
                        b8.Foreground = Brushes.ForestGreen;
                    }
                    else if (results[36] != 0 && results[29] != 0 && results[22] == 0)
                    {
                        results[22] = 1;
                        b15.Content = "🔵";
                        b15.Foreground = Brushes.ForestGreen;
                    }
                    else if (results[36] != 0 && results[29] != 0 && results[22] != 0 && results[15] == 0)
                    {
                        results[15] = 1;
                        b22.Content = "🔵";
                        b22.Foreground = Brushes.ForestGreen;
                    }
                    else if (results[36] != 0 && results[29] != 0 && results[22] != 0 && results[15] != 0 && results[8] == 0)
                    {
                        results[8] = 1;
                        b29.Content = "🔵";
                        b29.Foreground = Brushes.ForestGreen;
                    }
                    else if (results[36] != 0 && results[29] != 0 && results[22] != 0 && results[15] != 0 && results[8] != 0 && results[1] == 0)
                    {
                        results[1] = 1;
                        b36.Content = "🔵";
                        b36.Foreground = Brushes.ForestGreen;
                    }
                    else
                    {
                        return;
                    }
                    CheckForWinner();
                    if (b.GameOver == false)
                    {
                        a.Player1Turn = false;
                        play.Content = "Player Two's Turn";
                        play.Foreground = Brushes.Firebrick;
                    }
                    else
                    {
                        return;
                    }
                    
                }
                else
                {
                    if (results[36] == 0)
                    {
                        results[36] = 2;
                        b1.Content = "🔴";
                        b1.Foreground = Brushes.Firebrick;
                    }
                    else if (results[36] == 0 == false && results[29] == 0)
                    {
                        results[29] = 2;
                        b8.Content = "🔴";
                        b8.Foreground = Brushes.Firebrick;
                    }
                    else if (results[36] == 0 == false && results[29] == 0 == false && results[22] == 0)
                    {
                        results[22] = 2;
                        b15.Content = "🔴";
                        b15.Foreground = Brushes.Firebrick;
                    }
                    else if (results[36] != 0 && results[29] != 0 && results[22] != 0 && results[15] == 0)
                    {
                        results[15] = 2;
                        b22.Content = "🔴";
                        b22.Foreground = Brushes.Firebrick;
                    }
                    else if (results[36] != 0 && results[29] != 0 && results[22] != 0 && results[15] != 0 && results[8] == 0)
                    {
                        results[8] = 2;
                        b29.Content = "🔴";
                        b29.Foreground = Brushes.Firebrick;
                    }
                    else if (results[36] != 0 && results[29] != 0 && results[22] != 0 && results[15] != 0 && results[8] != 0 && results[1] == 0)
                    {
                        results[1] = 2;
                        b36.Content = "🔴";
                        b36.Foreground = Brushes.Firebrick;
                    }
                    else
                    {
                        return;
                    }
                    CheckForWinner();
                    if (b.GameOver == false)
                    {
                        a.Player1Turn = true;
                        play.Content = "Player One's Turn";
                        play.Foreground = Brushes.ForestGreen;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        //C1_Click method: method to identify which button in column 1 has not yet been filled and fill it based on the player's turn
        private void C1_Click(object sender, RoutedEventArgs e)
        {
            if (b.GameOver)
            { 
                return; 
            }
            else
            {
            if (a.Player1Turn)
            {
                if (results[37] == 0)
                {
                    results[37] = 1;
                    b2.Content = "🔵";
                    b2.Foreground = Brushes.ForestGreen;
                }
                else if (results[37] != 0 && results[30] == 0)
                {
                    results[30] = 1;
                    b9.Content = "🔵";
                    b9.Foreground = Brushes.ForestGreen;
                }
                else if (results[37] != 0 && results[30] != 0 && results[23] == 0)
                {
                    results[23] = 1;
                    b16.Content = "🔵";
                    b16.Foreground = Brushes.ForestGreen;
                }
                else if (results[37] != 0 && results[30] != 0 && results[23] != 0 && results[16] == 0)
                {
                    results[16] = 1;
                    b23.Content = "🔵";
                    b23.Foreground = Brushes.ForestGreen;
                }
                else if (results[37] != 0 && results[30] != 0 && results[23] != 0 && results[16] != 0 && results[9] == 0)
                {
                    results[9] = 1;
                    b30.Content = "🔵";
                    b30.Foreground = Brushes.ForestGreen;
                }
                else if (results[37] != 0 && results[30] != 0 && results[23] != 0 && results[16] != 0 && results[9] != 0 && results[2] == 0)
                {
                    results[2] = 1;
                    b37.Content = "🔵";
                    b37.Foreground = Brushes.ForestGreen;
                }
                else
                {
                    return;
                }
                CheckForWinner();
                if (b.GameOver == false)
                {
                    a.Player1Turn = false;
                    play.Content = "Player Two's Turn";
                    play.Foreground = Brushes.Firebrick;
                }
                else
                {
                    return;
                }
            }
            else
            {
                if (results[37] == 0)
                {
                    results[37] = 2;
                    b2.Content = "🔴";
                    b2.Foreground = Brushes.Firebrick;
                }
                else if (results[37] != 0 && results[30] == 0)
                {
                    results[30] = 2;
                    b9.Content = "🔴";
                    b9.Foreground = Brushes.Firebrick;
                }
                else if (results[37] != 0 && results[30] != 0 && results[23] == 0)
                {
                    results[23] = 2;
                    b16.Content = "🔴";
                    b16.Foreground = Brushes.Firebrick;
                }
                else if (results[37] != 0 && results[30] != 0 && results[23] != 0 && results[16] == 0)
                {
                    results[16] = 2;
                    b23.Content = "🔴";
                    b23.Foreground = Brushes.Firebrick;
                }
                else if (results[37] != 0 && results[30] != 0 && results[23] != 0 && results[16] != 0 && results[9] == 0)
                {
                    results[9] = 2;
                    b30.Content = "🔴";
                    b30.Foreground = Brushes.Firebrick;
                }
                else if (results[37] != 0  && results[30] != 0 && results[23] != 0 && results[16] != 0 && results[9] != 0 && results[2] == 0)
                {
                    results[2] = 2;
                    b37.Content = "🔴";
                    b37.Foreground = Brushes.Firebrick;
                }
                else
                {
                    return;
                }
                CheckForWinner();
                if (b.GameOver == false)
                {
                    a.Player1Turn = true;
                    play.Content = "Player One's Turn";
                    play.Foreground = Brushes.ForestGreen;
                }
                else
                {
                    return;
                }
            }
            }
        }

        //C2_Click method: method to identify which button in column 2 has not yet been filled and fill it based on the player's turn
        private void C2_Click(object sender, RoutedEventArgs e)
        {
            if (b.GameOver)
            {
                return;
            }
            else
            {
                if (a.Player1Turn)
                {
                    if (results[38] == 0)
                    {
                        results[38] = 1;
                        b3.Content = "🔵";
                        b3.Foreground = Brushes.ForestGreen;
                    }
                    else if (results[38] != 0 && results[31] == 0)
                    {
                        results[31] = 1;
                        b10.Content = "🔵";
                        b10.Foreground = Brushes.ForestGreen;
                    }
                    else if (results[38] != 0 && results[31] != 0 && results[24] == 0)
                    {
                        results[24] = 1;
                        b17.Content = "🔵";
                        b17.Foreground = Brushes.ForestGreen;
                    }
                    else if (results[38] != 0 && results[31] != 0 && results[24] != 0 && results[17] == 0)
                    {
                        results[17] = 1;
                        b24.Content = "🔵";
                        b24.Foreground = Brushes.ForestGreen;
                    }
                    else if (results[38] != 0 && results[31] != 0 && results[24] != 0 && results[17] != 0 && results[10] == 0)
                    {
                        results[10] = 1;
                        b31.Content = "🔵";
                        b31.Foreground = Brushes.ForestGreen;
                    }
                    else if (results[38] != 0 && results[31] != 0 && results[24] != 0 && results[17] != 0 && results[10] != 0 && results[3] == 0)
                    {
                        results[3] = 1;
                        b38.Content = "🔵";
                        b38.Foreground = Brushes.ForestGreen;
                    }
                    else
                    {
                        return;
                    }
                    CheckForWinner();
                    if (b.GameOver == false)
                    {
                        a.Player1Turn = false;
                        play.Content = "Player Two's Turn";
                        play.Foreground = Brushes.Firebrick;
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    if (results[38] == 0)
                    {
                        results[38] = 2;
                        b3.Content = "🔴";
                        b3.Foreground = Brushes.Firebrick;
                    }
                    else if (results[38] != 0 && results[31] == 0)
                    {
                        results[31] = 2;
                        b10.Content = "🔴";
                        b10.Foreground = Brushes.Firebrick;
                    }
                    else if (results[38] != 0 && results[31] != 0 && results[24] == 0)
                    {
                        results[24] = 2;
                        b17.Content = "🔴";
                        b17.Foreground = Brushes.Firebrick;
                    }
                    else if (results[38] != 0 && results[31] != 0 && results[24] != 0 && results[17] == 0)
                    {
                        results[17] = 2;
                        b24.Content = "🔴";
                        b24.Foreground = Brushes.Firebrick;
                    }
                    else if (results[38] != 0 && results[31] != 0 && results[24] != 0 && results[17] != 0 && results[10] == 0)
                    {
                        results[10] = 2;
                        b31.Content = "🔴";
                        b31.Foreground = Brushes.Firebrick;
                    }
                    else if (results[38] != 0 && results[31] != 0 && results[24] != 0 && results[17] != 0 && results[10] != 0 && results[3] == 0)
                    {
                        results[3] = 2;
                        b38.Content = "🔴";
                        b38.Foreground = Brushes.Firebrick;
                    }
                    else
                    {
                        return;
                    }
                    CheckForWinner();
                    if (b.GameOver == false)
                    {
                        a.Player1Turn = true;
                        play.Content = "Player One's Turn";
                        play.Foreground = Brushes.ForestGreen;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        //C3_Click method: method to identify which button in column 3 has not yet been filled and fill it based on the player's turn
        private void C3_Click(object sender, RoutedEventArgs e)
        {
            if (b.GameOver)
            {
                return;
            }
            else
            {
                if (a.Player1Turn)
                {
                    if (results[39] == 0)
                    {
                        results[39] = 1;
                        b4.Content = "🔵";
                        b4.Foreground = Brushes.ForestGreen;
                    }
                    else if (results[39] != 0 && results[32] == 0)
                    {
                        results[32] = 1;
                        b11.Content = "🔵";
                        b11.Foreground = Brushes.ForestGreen;
                    }
                    else if (results[39] != 0 && results[32] != 0 && results[25] == 0)
                    {
                        results[25] = 1;
                        b18.Content = "🔵";
                        b18.Foreground = Brushes.ForestGreen;
                    }
                    else if (results[39] != 0 && results[32] != 0 && results[25] != 0 && results[18] == 0)
                    {
                        results[18] = 1;
                        b25.Content = "🔵";
                        b25.Foreground = Brushes.ForestGreen;
                    }
                    else if (results[39] != 0 && results[32] != 0 && results[25] != 0 && results[18] != 0 && results[11] == 0)
                    {
                        results[11] = 1;
                        b32.Content = "🔵";
                        b32.Foreground = Brushes.ForestGreen;
                    }
                    else if (results[39] != 0 && results[32] != 0 && results[25] != 0 && results[18] != 0 && results[11] != 0 && results[4] == 0)
                    {
                        results[4] = 1;
                        b39.Content = "🔵";
                        b39.Foreground = Brushes.ForestGreen;
                    }
                    else
                    {
                        return;
                    }
                    CheckForWinner();
                    if (b.GameOver == false)
                    {
                        a.Player1Turn = false;
                        play.Content = "Player Two's Turn";
                        play.Foreground = Brushes.Firebrick;
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    if (results[39] == 0)
                    {
                        results[39] = 2;
                        b4.Content = "🔴";
                        b4.Foreground = Brushes.Firebrick;
                    }
                    else if (results[39] != 0 && results[32] == 0)
                    {
                        results[32] = 2;
                        b11.Content = "🔴";
                        b11.Foreground = Brushes.Firebrick;
                    }
                    else if (results[39] != 0 && results[32] != 0 && results[25] == 0)
                    {
                        results[25] = 2;
                        b18.Content = "🔴";
                        b18.Foreground = Brushes.Firebrick;
                    }
                    else if (results[39] != 0 && results[32] != 0 && results[25] != 0 && results[18] == 0)
                    {
                        results[18] = 2;
                        b25.Content = "🔴";
                        b25.Foreground = Brushes.Firebrick;
                    }
                    else if (results[39] != 0 && results[32] != 0 && results[25] != 0 && results[18] != 0 && results[11] == 0)
                    {
                        results[11] = 2;
                        b32.Content = "🔴";
                        b32.Foreground = Brushes.Firebrick;
                    }
                    else if (results[39] != 0 && results[32] != 0 && results[25] != 0 && results[18] != 0 && results[11] != 0 && results[4] == 0)
                    {
                        results[4] = 2;
                        b39.Content = "🔴";
                        b39.Foreground = Brushes.Firebrick;
                    }
                    else
                    {
                        return;
                    }
                    CheckForWinner();
                    if (b.GameOver == false)
                    {
                        a.Player1Turn = true;
                        play.Content = "Player One's Turn";
                        play.Foreground = Brushes.ForestGreen;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        //C4_Click method: method to identify which button in column 4 has not yet been filled and fill it based on the player's turn
        private void C4_Click(object sender, RoutedEventArgs e)
        {
            if (b.GameOver)
            {
                return;
            }
            else
            {
                if (a.Player1Turn)
                {
                    if (results[40] == 0)
                    {
                        results[40] = 1;
                        b5.Content = "🔵";
                        b5.Foreground = Brushes.ForestGreen;
                    }
                    else if (results[40] != 0 && results[33] == 0)
                    {
                        results[33] = 1;
                        b12.Content = "🔵";
                        b12.Foreground = Brushes.ForestGreen;
                    }
                    else if (results[40] != 0 && results[33] != 0 && results[26] == 0)
                    {
                        results[26] = 1;
                        b19.Content = "🔵";
                        b19.Foreground = Brushes.ForestGreen;
                    }
                    else if (results[40] != 0 && results[33] != 0 && results[26] != 0 && results[19] == 0)
                    {
                        results[19] = 1;
                        b26.Content = "🔵";
                        b26.Foreground = Brushes.ForestGreen;
                    }
                    else if (results[40] != 0 && results[33] != 0 && results[26] != 0 && results[19] != 0 && results[12] == 0)
                    {
                        results[12] = 1;
                        b33.Content = "🔵";
                        b33.Foreground = Brushes.ForestGreen;
                    }
                    else if (results[40] != 0 && results[33] != 0 && results[26] != 0 && results[19] != 0 && results[12] != 0 && results[5] == 0)
                    {
                        results[5] = 1;
                        b40.Content = "🔵";
                        b40.Foreground = Brushes.ForestGreen;
                    }
                    else
                    {
                        return;
                    }
                    CheckForWinner();
                    if (b.GameOver == false)
                    {
                        a.Player1Turn = false;
                        play.Content = "Player Two's Turn";
                        play.Foreground = Brushes.Firebrick;
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    if (results[40] == 0)
                    {
                        results[40] = 2;
                        b5.Content = "🔴";
                        b5.Foreground = Brushes.Firebrick;
                    }
                    else if (results[40] != 0 && results[33] == 0)
                    {
                        results[33] = 2;
                        b12.Content = "🔴";
                        b12.Foreground = Brushes.Firebrick;
                    }
                    else if (results[40] != 0 && results[33] != 0 && results[26] == 0)
                    {
                        results[26] = 2;
                        b19.Content = "🔴";
                        b19.Foreground = Brushes.Firebrick;
                    }
                    else if (results[40] != 0 && results[33] != 0 && results[26] != 0 && results[19] == 0)
                    {
                        results[19] = 2;
                        b26.Content = "🔴";
                        b26.Foreground = Brushes.Firebrick;
                    }
                    else if (results[40] != 0 && results[33] != 0 && results[26] != 0 && results[19] != 0 && results[12] == 0)
                    {
                        results[12] = 2;
                        b33.Content = "🔴";
                        b33.Foreground = Brushes.Firebrick;
                    }
                    else if (results[40] != 0 && results[33] != 0 && results[26] != 0 && results[19] != 0 && results[12] != 0 && results[5] == 0)
                    {
                        results[5] = 2;
                        b40.Content = "🔴";
                        b40.Foreground = Brushes.Firebrick;
                    }
                    else
                    {
                        return;
                    }
                    CheckForWinner();
                    if (b.GameOver == false)
                    {
                        a.Player1Turn = true;
                        play.Content = "Player One's Turn";
                        play.Foreground = Brushes.ForestGreen;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        //C5_Click method: method to identify which button in column 5 has not yet been filled and fill it based on the player's turn
        private void C5_Click(object sender, RoutedEventArgs e)
        {
            if (b.GameOver)
            {
                return;
            }
            else
            {
                if (a.Player1Turn)
                {
                    if (results[41] == 0)
                    {
                        results[41] = 1;
                        b6.Content = "🔵";
                        b6.Foreground = Brushes.ForestGreen;
                    }
                    else if (results[41] != 0 && results[34] == 0)
                    {
                        results[34] = 1;
                        b13.Content = "🔵";
                        b13.Foreground = Brushes.ForestGreen;
                    }
                    else if (results[41] != 0 && results[34] != 0 && results[27] == 0)
                    {
                        results[27] = 1;
                        b20.Content = "🔵";
                        b20.Foreground = Brushes.ForestGreen;
                    }
                    else if (results[41] != 0 && results[34] != 0 && results[27] != 0 && results[20] == 0)
                    {
                        results[20] = 1;
                        b27.Content = "🔵";
                        b27.Foreground = Brushes.ForestGreen;
                    }
                    else if (results[41] != 0 && results[34] != 0 && results[27] != 0 && results[20] != 0 && results[13] == 0)
                    {
                        results[13] = 1;
                        b34.Content = "🔵";
                        b34.Foreground = Brushes.ForestGreen;
                    }
                    else if (results[41] != 0 && results[34] != 0 && results[27] != 0 && results[20] != 0 && results[13] != 0 && results[6] == 0)
                    {
                        results[6] = 1;
                        b41.Content = "🔵";
                        b41.Foreground = Brushes.ForestGreen;
                    }
                    else
                    {
                        return;
                    }
                    CheckForWinner();
                    if (b.GameOver == false)
                    {
                        a.Player1Turn = false;
                        play.Content = "Player Two's Turn";
                        play.Foreground = Brushes.Firebrick;
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    if (results[41] == 0)
                    {
                        results[41] = 2;
                        b6.Content = "🔴";
                        b6.Foreground = Brushes.Firebrick;
                    }
                    else if (results[41] != 0 && results[34] == 0)
                    {
                        results[34] = 2;
                        b13.Content = "🔴";
                        b13.Foreground = Brushes.Firebrick;
                    }
                    else if (results[41] != 0 && results[34] != 0 && results[27] == 0)
                    {
                        results[27] = 2;
                        b20.Content = "🔴";
                        b20.Foreground = Brushes.Firebrick;
                    }
                    else if (results[41] != 0 && results[34] != 0 && results[27] != 0 && results[20] == 0)
                    {
                        results[20] = 2;
                        b27.Content = "🔴";
                        b27.Foreground = Brushes.Firebrick;
                    }
                    else if (results[41] != 0 && results[34] != 0 && results[27] != 0 && results[20] != 0 && results[13] == 0)
                    {
                        results[13] = 2;
                        b34.Content = "🔴";
                        b34.Foreground = Brushes.Firebrick;
                    }
                    else if (results[41] != 0 && results[34] != 0 && results[27] != 0 && results[20] != 0 && results[13] != 0 && results[6] == 0)
                    {
                        results[6] = 2;
                        b41.Content = "🔴";
                        b41.Foreground = Brushes.Firebrick;
                    }
                    else
                    {
                        return;
                    }
                    CheckForWinner();
                    if (b.GameOver == false)
                    {
                        a.Player1Turn = true;
                        play.Content = "Player One's Turn";
                        play.Foreground = Brushes.ForestGreen;
                    }
                    else
                    {
                        return;

                    }
                }
            }
        }

        //C6_Click method: method to identify which button in column 6 has not yet been filled and fill it based on the player's turn
        private void C6_Click(object sender, RoutedEventArgs e)
        {
            if (b.GameOver)
            {
                return;
            }
            else
            {
                if (a.Player1Turn)
                {
                    if (results[42] == 0)
                    {
                        results[42] = 1;
                        b7.Content = "🔵";
                        b7.Foreground = Brushes.ForestGreen;
                    }
                    else if (results[42] != 0 && results[35] == 0)
                    {
                        results[35] = 1;
                        b14.Content = "🔵";
                        b14.Foreground = Brushes.ForestGreen;
                    }
                    else if (results[42] != 0 && results[35] != 0 && results[28] == 0)
                    {
                        results[28] = 1;
                        b21.Content = "🔵";
                        b21.Foreground = Brushes.ForestGreen;
                    }
                    else if (results[42] != 0 && results[35] != 0 && results[28] != 0 && results[21] == 0)
                    {
                        results[21] = 1;
                        b28.Content = "🔵";
                        b28.Foreground = Brushes.ForestGreen;
                    }
                    else if (results[42] != 0 && results[35] != 0 && results[28] != 0 && results[21] != 0 && results[14] == 0)
                    {
                        results[14] = 1;
                        b35.Content = "🔵";
                        b35.Foreground = Brushes.ForestGreen;
                    }
                    else if (results[42] != 0 && results[35] != 0 && results[28] != 0 && results[21] != 0 && results[14] != 0 && results[7] == 0)
                    {
                        results[7] = 1;
                        b42.Content = "🔵";
                        b42.Foreground = Brushes.ForestGreen;
                    }
                    else
                    {
                        return;
                    }
                    CheckForWinner();
                    if (b.GameOver == false)
                    {
                        a.Player1Turn = false;
                        play.Content = "Player Two's Turn";
                        play.Foreground = Brushes.Firebrick;
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    if (results[42] == 0)
                    {
                        results[42] = 2;
                        b7.Content = "🔴";
                        b7.Foreground = Brushes.Firebrick;
                    }
                    else if (results[42] != 0 && results[35] == 0)
                    {
                        results[35] = 2;
                        b14.Content = "🔴";
                        b14.Foreground = Brushes.Firebrick;
                    }
                    else if (results[42] != 0 && results[35] != 0 && results[28] == 0)
                    {
                        results[28] = 2;
                        b21.Content = "🔴";
                        b21.Foreground = Brushes.Firebrick;
                    }
                    else if (results[42] != 0 && results[35] != 0 && results[28] != 0 && results[21] == 0)
                    {
                        results[21] = 2;
                        b28.Content = "🔴";
                        b28.Foreground = Brushes.Firebrick;
                    }
                    else if (results[42] != 0 && results[35] != 0 && results[28] != 0 && results[21] != 0 && results[14] == 0)
                    {
                        results[14] = 2;
                        b35.Content = "🔴";
                        b35.Foreground = Brushes.Firebrick;
                    }
                    else if (results[42] != 0 && results[35] != 0 && results[28] != 0 && results[21] != 0 && results[14] != 0 && results[7] == 0)
                    {
                        results[7] = 2;
                        b42.Content = "🔴";
                        b42.Foreground = Brushes.Firebrick;
                    }
                    else
                    {
                        return;
                    }
                    CheckForWinner();
                    if (b.GameOver == false)
                    {
                        a.Player1Turn = true;
                        play.Content = "Player One's Turn";
                        play.Foreground = Brushes.ForestGreen;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        //CheckForWinner() method: method to check all possible winning runs and decides whether the game has ended based off if a player has won
        private void CheckForWinner()
        {
            if (results[36] != 0 && (results[37] == results[36]) && (results[38] == results[36]) && (results[39] == results[36]))
            {
                b.GameOver = true;
                b1.Background = b2.Background = b3.Background = b4.Background = Brushes.MistyRose;
            }
            else if (results[36] != 0 && (results[29] == results[36]) && (results[22] == results[36]) && (results[15] == results[36]))
            {
                b.GameOver = true;
                b1.Background = b8.Background = b15.Background = b22.Background = Brushes.MistyRose;
            }
            else if (results[36] != 0 && (results[30] == results[36]) && (results[24] == results[36]) && (results[18] == results[36]))
            {
                b.GameOver = true;
                b1.Background = b9.Background = b17.Background = b25.Background = Brushes.MistyRose;
            }
            else if (results[37] != 0 && (results[38] == results[37]) && (results[39] == results[37]) && (results[40] == results[37]))
            {
                b.GameOver = true;
                b2.Background = b3.Background = b4.Background = b5.Background = Brushes.MistyRose;
            }
            else if (results[37] != 0 && (results[30] == results[37]) && (results[23] == results[37]) && (results[16] == results[37]))
            {
                b.GameOver = true;
                b2.Background = b9.Background = b16.Background = b23.Background = Brushes.MistyRose;
            }
            else if (results[37] != 0 && (results[31] == results[37]) && (results[25] == results[37]) && (results[19] == results[37]))
            {
                b.GameOver = true;
                b2.Background = b10.Background = b18.Background = b26.Background = Brushes.MistyRose;
            }
            else if (results[38] != 0 && (results[39] == results[38]) && (results[40] == results[38]) && (results[41] == results[38]))
            {
                b.GameOver = true;
                b3.Background = b4.Background = b5.Background = b6.Background = Brushes.MistyRose;
            }
            else if (results[38] != 0 && (results[31] == results[38]) && (results[24] == results[38]) && (results[17] == results[38]))
            {
                b.GameOver = true;
                b3.Background = b10.Background = b17.Background = b24.Background = Brushes.MistyRose;
            }
            else if (results[38] != 0 && (results[32] == results[38]) && (results[26] == results[38]) && (results[20] == results[38]))
            {
                b.GameOver = true;
                b3.Background = b11.Background = b19.Background = b27.Background = Brushes.MistyRose;
            }
            else if (results[39] != 0 && (results[40] == results[39]) && (results[41] == results[39]) && (results[42] == results[39]))
            {
                b.GameOver = true;
                b4.Background = b5.Background = b6.Background = b7.Background = Brushes.MistyRose;
            }
            else if (results[39] != 0 && (results[32] == results[39]) && (results[25] == results[39]) && (results[18] == results[39]))
            {
                b.GameOver = true;
                b4.Background = b11.Background = b18.Background = b25.Background = Brushes.MistyRose;
            }
            else if (results[39] != 0 && (results[33] == results[39]) && (results[27] == results[39]) && (results[21] == results[39]))
            {
                b.GameOver = true;
                b4.Background = b12.Background = b20.Background = b28.Background = Brushes.MistyRose;
            }
            else if (results[39] != 0 && (results[31] == results[39]) && (results[23] == results[39]) && (results[15] == results[39]))
            {
                b.GameOver = true;
                b4.Background = b10.Background = b16.Background = b22.Background = Brushes.MistyRose;
            }
            else if (results[40] != 0 && (results[33] == results[40]) && (results[26] == results[40]) && (results[19] == results[40]))
            {
                b.GameOver = true;
                b5.Background = b12.Background = b19.Background = b26.Background = Brushes.MistyRose;
            }
            else if (results[40] != 0 && (results[32] == results[40]) && (results[24] == results[40]) && (results[16] == results[40]))
            {
                b.GameOver = true;
                b5.Background = b11.Background = b17.Background = b23.Background = Brushes.MistyRose;
            }
            else if (results[41] != 0 && (results[34] == results[41]) && (results[27] == results[41]) && (results[20] == results[41]))
            {
                b.GameOver = true;
                b6.Background = b13.Background = b20.Background = b27.Background = Brushes.MistyRose;
            }
            else if (results[41] != 0 && (results[33] == results[41]) && (results[25] == results[41]) && (results[17] == results[41]))
            {
                b.GameOver = true;
                b6.Background = b12.Background = b18.Background = b24.Background = Brushes.MistyRose;
            }
            else if (results[42] != 0 && (results[35] == results[42]) && (results[28] == results[42]) && (results[21] == results[42]))
            {
                b.GameOver = true;
                b7.Background = b14.Background = b21.Background = b28.Background = Brushes.MistyRose;
            }
            else if (results[42] != 0 && (results[34] == results[42]) && (results[26] == results[42]) && (results[18] == results[42]))
            {
                b.GameOver = true;
                b7.Background = b13.Background = b19.Background = b25.Background = Brushes.MistyRose;
            }
            else if (results[29] != 0 && (results[30] == results[29]) && (results[31] == results[29]) && (results[32] == results[29]))
            {
                b.GameOver = true;
                b8.Background = b9.Background = b10.Background = b11.Background = Brushes.MistyRose;
            }
            else if (results[29] != 0 && (results[22] == results[29]) && (results[15] == results[29]) && (results[8] == results[29]))
            {
                b.GameOver = true;
                b8.Background = b15.Background = b22.Background = b29.Background = Brushes.MistyRose;
            }
            else if (results[29] != 0 && (results[23] == results[29]) && (results[17] == results[29]) && (results[11] == results[29]))
            {
                b.GameOver = true;
                b8.Background = b16.Background = b24.Background = b32.Background = Brushes.MistyRose;
            }
            else if (results[30] != 0 && (results[31] == results[30]) && (results[32] == results[30]) && (results[33] == results[30]))
            {
                b.GameOver = true;
                b9.Background = b10.Background = b11.Background = b12.Background = Brushes.MistyRose;
            }
            else if (results[30] != 0 && (results[23] == results[30]) && (results[16] == results[30]) && (results[9] == results[30]))
            {
                b.GameOver = true;
                b9.Background = b16.Background = b23.Background = b30.Background = Brushes.MistyRose;
            }
            else if (results[30] != 0 && (results[24] == results[30]) && (results[18] == results[30]) && (results[12] == results[30]))
            {
                b.GameOver = true;
                b9.Background = b17.Background = b25.Background = b33.Background = Brushes.MistyRose;
            }
            else if (results[31] != 0 && (results[32] == results[31]) && (results[33] == results[31]) && (results[34] == results[31]))
            {
                b.GameOver = true;
                b10.Background = b11.Background = b12.Background = b13.Background = Brushes.MistyRose;
            }
            else if (results[31] != 0 && (results[24] == results[31]) && (results[17] == results[31]) && (results[10] == results[31]))
            {
                b.GameOver = true;
                b10.Background = b17.Background = b24.Background = b31.Background = Brushes.MistyRose;
            }
            else if (results[31] != 0 && (results[25] == results[31]) && (results[19] == results[31]) && (results[13] == results[31]))
            {
                b.GameOver = true;
                b10.Background = b18.Background = b26.Background = b34.Background = Brushes.MistyRose;
            }
            else if (results[32] != 0 && (results[33] == results[32]) && (results[34] == results[32]) && (results[35] == results[32]))
            {
                b.GameOver = true;
                b11.Background = b12.Background = b13.Background = b14.Background = Brushes.MistyRose;
            }
            else if (results[32] != 0 && (results[25] == results[32]) && (results[18] == results[32]) && (results[11] == results[32]))
            {
                b.GameOver = true;
                b11.Background = b18.Background = b25.Background = b32.Background = Brushes.MistyRose;
            }
            else if (results[32] != 0 && (results[26] == results[32]) && (results[20] == results[32]) && (results[14] == results[32]))
            {
                b.GameOver = true;
                b11.Background = b19.Background = b27.Background = b35.Background = Brushes.MistyRose;
            }
            else if (results[32] != 0 && (results[24] == results[32]) && (results[16] == results[32]) && (results[8] == results[32]))
            {
                b.GameOver = true;
                b11.Background = b17.Background = b23.Background = b29.Background = Brushes.MistyRose;
            }
            else if (results[33] != 0 && (results[26] == results[33]) && (results[19] == results[33]) && (results[12] == results[33]))
            {
                b.GameOver = true;
                b12.Background = b19.Background = b26.Background = b33.Background = Brushes.MistyRose;
            }
            else if (results[33] != 0 && (results[25] == results[33]) && (results[17] == results[33]) && (results[9] == results[33]))
            {
                b.GameOver = true;
                b12.Background = b18.Background = b24.Background = b30.Background = Brushes.MistyRose;
            }
            else if (results[34] != 0 && (results[27] == results[34]) && (results[20] == results[34]) && (results[13] == results[34]))
            {
                b.GameOver = true;
                b13.Background = b20.Background = b27.Background = b34.Background = Brushes.MistyRose;
            }
            else if (results[34] != 0 && (results[26] == results[34]) && (results[18] == results[34]) && (results[10] == results[34]))
            {
                b.GameOver = true;
                b13.Background = b19.Background = b25.Background = b31.Background = Brushes.MistyRose;
            }
            else if (results[35] != 0 && (results[28] == results[35]) && (results[21] == results[35]) && (results[14] == results[35]))
            {
                b.GameOver = true;
                b14.Background = b21.Background = b28.Background = b35.Background = Brushes.MistyRose;
            }
            else if (results[35] != 0 && (results[27] == results[35]) && (results[19] == results[35]) && (results[11] == results[35]))
            {
                b.GameOver = true;
                b14.Background = b20.Background = b26.Background = b32.Background = Brushes.MistyRose;
            }
            else if (results[22] != 0 && (results[23] == results[22]) && (results[24] == results[22]) && (results[25] == results[22]))
            {
                b.GameOver = true;
                b15.Background = b16.Background = b17.Background = b18.Background = Brushes.MistyRose;
            }
            else if (results[22] != 0 && (results[15] == results[22]) && (results[8] == results[22]) && (results[1] == results[22]))
            {
                b.GameOver = true;
                b15.Background = b22.Background = b29.Background = b36.Background = Brushes.MistyRose;
            }
            else if (results[22] != 0 && (results[16] == results[22]) && (results[10] == results[22]) && (results[4] == results[22]))
            {
                b.GameOver = true;
                b15.Background = b23.Background = b31.Background = b39.Background = Brushes.MistyRose;
            }
            else if (results[23] != 0 && (results[24] == results[23]) && (results[25] == results[23]) && (results[26] == results[23]))
            {
                b.GameOver = true;
                b16.Background = b17.Background = b18.Background = b19.Background = Brushes.MistyRose;
            }
            else if (results[23] != 0 && (results[16] == results[23]) && (results[9] == results[23]) && (results[2] == results[23]))
            {
                b.GameOver = true;
                b16.Background = b23.Background = b30.Background = b37.Background = Brushes.MistyRose;
            }
            else if (results[23] != 0 && (results[17] == results[23]) && (results[11] == results[23]) && (results[5] == results[23]))
            {
                b.GameOver = true;
                b16.Background = b24.Background = b32.Background = b40.Background = Brushes.MistyRose;
            }
            else if (results[24] != 0 && (results[25] == results[24]) && (results[26] == results[24]) && (results[27] == results[24]))
            {
                b.GameOver = true;
                b17.Background = b18.Background = b19.Background = b20.Background = Brushes.MistyRose;
            }
            else if (results[24] != 0 && (results[17] == results[24]) && (results[10] == results[24]) && (results[3] == results[24]))
            {
                b.GameOver = true;
                b17.Background = b24.Background = b31.Background = b38.Background = Brushes.MistyRose;
            }
            else if (results[24] != 0 && (results[18] == results[24]) && (results[12] == results[24]) && (results[6] == results[24]))
            {
                b.GameOver = true;
                b17.Background = b25.Background = b33.Background = b41.Background = Brushes.MistyRose;
            }
            else if (results[25] != 0 && (results[26] == results[25]) && (results[27] == results[25]) && (results[28] == results[25]))
            {
                b.GameOver = true;
                b18.Background = b19.Background = b20.Background = b21.Background = Brushes.MistyRose;
            }
            else if (results[25] != 0 && (results[18] == results[25]) && (results[11] == results[25]) && (results[4] == results[25]))
            {
                b.GameOver = true;
                b18.Background = b25.Background = b32.Background = b39.Background = Brushes.MistyRose;
            }
            else if (results[25] != 0 && (results[19] == results[25]) && (results[13] == results[25]) && (results[7] == results[25]))
            {
                b.GameOver = true;
                b18.Background = b26.Background = b34.Background = b42.Background = Brushes.MistyRose;
            }
            else if (results[25] != 0 && (results[17] == results[25]) && (results[9] == results[25]) && (results[1] == results[25]))
            {
                b.GameOver = true;
                b18.Background = b24.Background = b30.Background = b36.Background = Brushes.MistyRose;
            }
            else if (results[26] != 0 && (results[19] == results[26]) && (results[12] == results[26]) && (results[5] == results[26]))
            {
                b.GameOver = true;
                b19.Background = b26.Background = b33.Background = b40.Background = Brushes.MistyRose;
            }
            else if (results[26] != 0 && (results[18] == results[26]) && (results[10] == results[26]) && (results[2] == results[26]))
            {
                b.GameOver = true;
                b19.Background = b25.Background = b31.Background = b37.Background = Brushes.MistyRose;
            }
            else if (results[27] != 0 && (results[20] == results[27]) && (results[13] == results[27]) && (results[6] == results[27]))
            {
                b.GameOver = true;
                b20.Background = b27.Background = b34.Background = b41.Background = Brushes.MistyRose;
            }
            else if (results[27] != 0 && (results[19] == results[27]) && (results[11] == results[27]) && (results[3] == results[27]))
            {
                b.GameOver = true;
                b20.Background = b26.Background = b32.Background = b38.Background = Brushes.MistyRose;
            }
            else if (results[28] != 0 && (results[21] == results[28]) && (results[14] == results[28]) && (results[7] == results[28]))
            {
                b.GameOver = true;
                b21.Background = b28.Background = b35.Background = b42.Background = Brushes.MistyRose;
            }
            else if (results[28] != 0 && (results[20] == results[28]) && (results[12] == results[28]) && (results[4] == results[28]))
            {
                b.GameOver = true;
                b21.Background = b27.Background = b33.Background = b39.Background = Brushes.MistyRose;
            }
            else if (results[15] != 0 && (results[16] == results[15]) && (results[17] == results[15]) && (results[18] == results[15]))
            {
                b.GameOver = true;
                b22.Background = b23.Background = b24.Background = b25.Background = Brushes.MistyRose;
            }
            else if (results[16] != 0 && (results[17] == results[16]) && (results[18] == results[16]) && (results[19] == results[16]))
            {
                b.GameOver = true;
                b23.Background = b24.Background = b25.Background = b26.Background = Brushes.MistyRose;
            }
            else if (results[17] != 0 && (results[18] == results[17]) && (results[19] == results[17]) && (results[20] == results[17]))
            {
                b.GameOver = true;
                b24.Background = b25.Background = b26.Background = b27.Background = Brushes.MistyRose;
            }
            else if (results[18] != 0 && (results[19] == results[18]) && (results[20] == results[18]) && (results[21] == results[18]))
            {
                b.GameOver = true;
                b25.Background = b26.Background = b27.Background = b28.Background = Brushes.MistyRose;
            }
            else if (results[8] != 0 && (results[9] == results[8]) && (results[10] == results[8]) && (results[11] == results[8]))
            {
                b.GameOver = true;
                b29.Background = b30.Background = b31.Background = b32.Background = Brushes.MistyRose;
            }
            else if (results[9] != 0 && (results[10] == results[9]) && (results[11] == results[9]) && (results[12] == results[9]))
            {
                b.GameOver = true;
                b30.Background = b31.Background = b32.Background = b33.Background = Brushes.MistyRose;
            }
            else if (results[10] != 0 && (results[11] == results[10]) && (results[12] == results[10]) && (results[13] == results[10]))
            {
                b.GameOver = true;
                b31.Background = b32.Background = b33.Background = b34.Background = Brushes.MistyRose;
            }
            else if (results[11] != 0 && (results[12] == results[11]) && (results[13] == results[11]) && (results[14] == results[11]))
            {
                b.GameOver = true;
                b32.Background = b33.Background = b34.Background = b35.Background = Brushes.MistyRose;
            }
            else if (results[1] != 0 && (results[2] == results[1]) && (results[3] == results[1]) && (results[4] == results[1]))
            {
                b.GameOver = true;
                b36.Background = b37.Background = b38.Background = b39.Background = Brushes.MistyRose;
            }
            else if (results[2] != 0 && (results[3] == results[2]) && (results[4] == results[2]) && (results[5] == results[2]))
            {
                b.GameOver = true;
                b37.Background = b38.Background = b39.Background = b40.Background = Brushes.MistyRose;
            }
            else if (results[3] != 0 && (results[4] == results[3]) && (results[5] == results[3]) && (results[6] == results[3]))
            {
                b.GameOver = true;
                b38.Background = b39.Background = b40.Background = b41.Background = Brushes.MistyRose;
            }
            else if (results[4] != 0 && (results[5] == results[4]) && (results[6] == results[4]) && (results[7] == results[4]))
            {
                b.GameOver = true;
                b39.Background = b40.Background = b41.Background = b42.Background = Brushes.MistyRose;
            }
            else
            {
                b.GameOver = false;
            }
            if (b.GameOver)
            {
                if (a.Player1Turn)
                {
                    play.Content = "Player 1 wins! Click here to play again!";
                    play.Foreground = Brushes.Black;
                    play.Background = Brushes.ForestGreen;
                }
                else
                {
                    play.Content = "Player 2 wins! Click here to play again!";
                    play.Foreground = Brushes.White;
                    play.Background = Brushes.Firebrick;
                }
            }
        }
    }
}
