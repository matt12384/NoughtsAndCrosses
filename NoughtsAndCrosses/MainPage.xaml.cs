using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace NoughtsAndCrosses
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int goCounter = 1;
        string currentPlayer = "O";
        public int boardSize = 3;
        string[,] board;

        public MainPage()
        {
            this.InitializeComponent();
            board = new string[boardSize, boardSize];
        }

        public void GoChecker()
        {
            if (goCounter % 2 == 0)
            {
                currentPlayer = "X";
                playerTurn.Text = "O's turn";
            }
            else
            {
                currentPlayer = "O";
                playerTurn.Text = "X's turn";
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            button1.IsEnabled = false;
            GoChecker();
            board[0, 0] = currentPlayer;
            button1.Content = currentPlayer;
            goCounter++;
            CheckWinner();
            WinningMove();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            button2.IsEnabled = false;
            GoChecker();
            board[0, 1] = currentPlayer;
            button2.Content = currentPlayer;
            goCounter++;
            CheckWinner();
            WinningMove();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            button3.IsEnabled = false;
            GoChecker();
            board[0, 2] = currentPlayer;
            button3.Content = currentPlayer;
            goCounter++;
            CheckWinner();
            WinningMove();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            button4.IsEnabled = false;
            GoChecker();
            board[1, 0] = currentPlayer;
            button4.Content = currentPlayer;
            goCounter++;
            CheckWinner();
            WinningMove();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            button5.IsEnabled = false;
            GoChecker();
            board[1, 1] = currentPlayer;
            button5.Content = currentPlayer;
            goCounter++;
            CheckWinner();
            WinningMove();
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            button6.IsEnabled = false;
            GoChecker();
            board[1, 2] = currentPlayer;
            button6.Content = currentPlayer;
            goCounter++;
            CheckWinner();
            WinningMove();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            button7.IsEnabled = false;
            GoChecker();
            board[2, 0] = currentPlayer;
            button7.Content = currentPlayer;
            goCounter++;
            CheckWinner();
            WinningMove();
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            button8.IsEnabled = false;
            GoChecker();
            board[2, 1] = currentPlayer;
            button8.Content = currentPlayer;
            goCounter++;
            CheckWinner();
            WinningMove();
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {

            button9.IsEnabled = false;
            GoChecker();
            board[2, 2] = currentPlayer;
            button9.Content = currentPlayer;
            goCounter++;
            CheckWinner();
            WinningMove();
        }

        //public void AddColourToWinningSquares()
        //{
        //    if (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2] && board[0, 0] != null && board[0, 1] != null && board[0, 2] != null)
        //    {
        //        button1.Background = new SolidColorBrush(Color.FromArgb(255, 48, 179, 221));
        //        button2.Background = new SolidColorBrush(Color.FromArgb(255, 48, 179, 221));
        //        button3.Background = new SolidColorBrush(Color.FromArgb(255, 48, 179, 221));
        //    }
        //}

        public bool CheckWinner()
        {
            //Rows
            if (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2] && board[0, 0] != null && board[0, 1] != null && board[0, 2] != null)
            {
                button1.Background = new SolidColorBrush(Color.FromArgb(255, 48, 179, 221));
                button2.Background = new SolidColorBrush(Color.FromArgb(255, 48, 179, 221));
                button3.Background = new SolidColorBrush(Color.FromArgb(255, 48, 179, 221));
                displayWinner.Text = board[0, 0] + " wins!";
                return true;
            }


            if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2] && board[1, 0] != null && board[1, 1] != null && board[1, 2] != null)
            {
                button4.Background = new SolidColorBrush(Color.FromArgb(255, 48, 179, 221));
                button5.Background = new SolidColorBrush(Color.FromArgb(255, 48, 179, 221));
                button6.Background = new SolidColorBrush(Color.FromArgb(255, 48, 179, 221));
                displayWinner.Text = board[1, 0] + " wins!";
                return true;
            }


            if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2] && board[2, 0] != null && board[2, 1] != null && board[2, 2] != null)
            {
                button7.Background = new SolidColorBrush(Color.FromArgb(255, 48, 179, 221));
                button8.Background = new SolidColorBrush(Color.FromArgb(255, 48, 179, 221));
                button9.Background = new SolidColorBrush(Color.FromArgb(255, 48, 179, 221));
                displayWinner.Text = board[2, 0] + " wins!";
                return true;
            }


            //Columns
            if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0] && board[0, 0] != null && board[1, 0] != null && board[2, 0] != null)
            {
                button1.Background = new SolidColorBrush(Color.FromArgb(255, 48, 179, 221));
                button4.Background = new SolidColorBrush(Color.FromArgb(255, 48, 179, 221));
                button7.Background = new SolidColorBrush(Color.FromArgb(255, 48, 179, 221));
                displayWinner.Text = board[0, 0] + " wins!";
                return true;
            }


            if (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1] && board[0, 1] != null && board[1, 1] != null && board[2, 1] != null)
            {
                button2.Background = new SolidColorBrush(Color.FromArgb(255, 48, 179, 221));
                button5.Background = new SolidColorBrush(Color.FromArgb(255, 48, 179, 221));
                button8.Background = new SolidColorBrush(Color.FromArgb(255, 48, 179, 221));
                displayWinner.Text = board[0, 1] + " wins!";
                return true;
            }


            if (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2] && board[0, 2] != null && board[1, 2] != null && board[2, 2] != null)
            {
                button3.Background = new SolidColorBrush(Color.FromArgb(255, 48, 179, 221));
                button6.Background = new SolidColorBrush(Color.FromArgb(255, 48, 179, 221));
                button9.Background = new SolidColorBrush(Color.FromArgb(255, 48, 179, 221));
                displayWinner.Text = board[0, 2] + " wins!";
                return true;
            }


            //Diagonals
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != null && board[1, 1] != null && board[2, 2] != null)
            {
                button1.Background = new SolidColorBrush(Color.FromArgb(255, 48, 179, 221));
                button5.Background = new SolidColorBrush(Color.FromArgb(255, 48, 179, 221));
                button9.Background = new SolidColorBrush(Color.FromArgb(255, 48, 179, 221));
                displayWinner.Text = board[0, 0] + " wins!";
                return true;
            }
                

            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != null && board[1, 1] != null && board[2, 0] != null)
            {
                button3.Background = new SolidColorBrush(Color.FromArgb(255, 48, 179, 221));
                button5.Background = new SolidColorBrush(Color.FromArgb(255, 48, 179, 221));
                button7.Background = new SolidColorBrush(Color.FromArgb(255, 48, 179, 221));
                displayWinner.Text = board[0, 2] + " wins!";
                return true;
            }

            //Draw
            if (goCounter >= 10)
            {
                displayWinner.Text = "Draw";
                return false;
            }

            return false;
        }

        public void WinningMove()
        {
            if (CheckWinner())
            {
                button1.IsEnabled = false;
                button2.IsEnabled = false;
                button3.IsEnabled = false;
                button4.IsEnabled = false;
                button5.IsEnabled = false;
                button6.IsEnabled = false;
                button7.IsEnabled = false;
                button8.IsEnabled = false;
                button9.IsEnabled = false;

                playerTurn.Text = "";
            }
        }

        private void replayButton_Click(object sender, RoutedEventArgs e)
        {
            board = new string[boardSize, boardSize];

            displayWinner.Text = "";

            button1.Content = "Click me!";
            button2.Content = "Click me!";
            button3.Content = "Click me!";
            button4.Content = "Click me!";
            button5.Content = "Click me!";
            button6.Content = "Click me!";
            button7.Content = "Click me!";
            button8.Content = "Click me!";
            button9.Content = "Click me!";

            button1.IsEnabled = true;
            button2.IsEnabled = true;
            button3.IsEnabled = true;
            button4.IsEnabled = true;
            button5.IsEnabled = true;
            button6.IsEnabled = true;
            button7.IsEnabled = true;
            button8.IsEnabled = true;
            button9.IsEnabled = true;

            button1.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            button2.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            button3.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            button4.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            button5.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            button6.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            button7.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            button8.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            button9.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));

            currentPlayer = "O";
            goCounter = 1;
            playerTurn.Text = "O's turn";
        }
    }
}
