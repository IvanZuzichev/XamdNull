using System;
using System.Windows;

namespace XamdNullOnline
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void you_win()
        {
            B1.IsEnabled = false;
            B2.IsEnabled = false;
            B3.IsEnabled = false;
            B4.IsEnabled = false;
            B5.IsEnabled = false;
            B6.IsEnabled = false;
            B7.IsEnabled = false;
            B8.IsEnabled = false;
            B9.IsEnabled = false;
            MessageBox.Show("Ты выиграл!");
            
        }
        public void you_lose()
        {
            B1.IsEnabled = false;
            B2.IsEnabled = false;
            B3.IsEnabled = false;
            B4.IsEnabled = false;
            B5.IsEnabled = false;
            B6.IsEnabled = false;
            B7.IsEnabled = false;
            B8.IsEnabled = false;
            B9.IsEnabled = false;
            MessageBox.Show("Ты проиграл, это плохо...");
        }
        public void Bot()
        {
            Random rnd = new Random() ;
            int r = rnd.Next(1, 10);
            if (B1.IsEnabled == true || B2.IsEnabled == true || B3.IsEnabled == true || B4.IsEnabled == true || B5.IsEnabled == true || B6.IsEnabled == true || B7.IsEnabled == true || B8.IsEnabled == true || B9.IsEnabled == true)
            {
                if (r == 1)
                {
                    if (B1.IsEnabled == true)
                    {
                        B1.IsEnabled = false;
                        B1.Content = "O";
                    }
                    else
                    {
                        Bot();
                    }
                }
                else if (r == 2)
                {
                    if (B2.IsEnabled == true)
                    {
                        B2.IsEnabled = false;
                        B2.Content = "O";
                    }
                    else
                    {
                        Bot();
                    }
                }
                else if (r == 3)
                {
                    if (B3.IsEnabled == true)
                    {
                        B3.IsEnabled = false;
                        B3.Content = "O";
                    }
                    else
                    {
                        Bot();
                    }
                }
                else if (r == 4)
                {
                    if (B4.IsEnabled == true)
                    {
                        B4.IsEnabled = false;
                        B4.Content = "O";
                    }
                    else
                    {
                        Bot();
                    }
                }
                else if (r == 5)
                {
                    if (B5.IsEnabled == true)
                    {
                        B5.IsEnabled = false;
                        B5.Content = "O";
                    }
                    else
                    {
                        Bot();
                    }
                }
                else if (r == 6)
                {
                    if (B6.IsEnabled == true)
                    {
                        B6.IsEnabled = false;
                        B6.Content = "O";
                    }
                    else
                    {
                        Bot();
                    }
                }
                else if (r == 7)
                {
                    if (B7.IsEnabled == true)
                    {
                        B7.IsEnabled = false;
                        B7.Content = "O";
                    }
                    else
                    {
                        Bot();
                    }
                }
                else if (r == 8)
                {
                    if (B8.IsEnabled == true)
                    {
                        B8.IsEnabled = false;
                        B8.Content = "O";
                    }
                    else
                    {
                        Bot();
                    }
                }
                else if (r == 9)
                {
                    if (B9.IsEnabled == true)
                    {
                        B9.IsEnabled = false;
                        B9.Content = "O";
                    }
                    else
                    {
                        Bot();
                    }
                }
                else
                {
                    MessageBox.Show("Ничья!");
                }
                Cheak();
            }
            else
            {
                
            }
        }
        public void Cheak()
        {
            if (B1.Content == "X" && B2.Content == "X" && B3.Content == "X")
            {
                you_win();
            }
            else if (B4.Content == "X" && B5.Content == "X" && B6.Content == "X")
            {
                you_win();
            }
            else if (B7.Content == "X" && B8.Content == "X" && B9.Content == "X")
            {
                you_win();
            }
            else if (B1.Content == "X" && B4.Content == "X" && B7.Content == "X")
            {
                you_win();
            }
            else if (B2.Content == "X" && B5.Content == "X" && B8.Content == "X")
            {
                you_win();
            }
            else if (B3.Content == "X" && B6.Content == "X" && B9.Content == "X")
            {
                you_win();
            }
            else if (B1.Content == "X" && B5.Content == "X" && B9.Content == "X")
            {
                you_win();
            }
            else if (B3.Content == "X" && B5.Content == "X" && B7.Content == "X")
            {
                you_win();
            }

            if (B1.Content == "O" && B2.Content == "O" && B3.Content == "O")
            {
                you_lose();
            }
            else if (B4.Content == "O" && B5.Content == "O" && B6.Content == "O")
            {
                you_lose();
            }
            else if (B7.Content == "O" && B8.Content == "O" && B9.Content == "O")
            {
                you_lose();
            }
            else if (B1.Content == "O" && B4.Content == "O" && B7.Content == "O")
            {
                you_lose();
            }
            else if (B2.Content == "O" && B5.Content == "O" && B8.Content == "O")
            {
                you_lose();
            }
            else if (B3.Content == "O" && B6.Content == "O" && B9.Content == "O")
            {
                you_lose();
            }
            else if (B1.Content == "O" && B5.Content == "O" && B9.Content == "O")
            {
                you_lose();
            }
            else if (B3.Content == "O" && B5.Content == "O" && B7.Content == "O")
            {
                you_lose();
            }
            else
            {
             
            }
        }
        private void B1_Click(object sender, RoutedEventArgs e)
        {
                B1.Content = "X";
            B1.IsEnabled = false;
            Cheak();
            Bot();
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            B2.Content = "X";
            B2.IsEnabled = false;
            Cheak();
            Bot();
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            B3.Content = "X";
            B3.IsEnabled = false;
            Cheak();
            Bot();
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            B4.Content = "X";
            B4.IsEnabled = false;
            Cheak();
            Bot();
        }

        private void B5_Click(object sender, RoutedEventArgs e)
        {
            B5.Content = "X";
            B5.IsEnabled = false;
            Cheak();
            Bot();
        }

        private void B6_Click(object sender, RoutedEventArgs e)
        {
            B6.Content = "X";
            B6.IsEnabled = false;
            Cheak();
            Bot();
        }

        private void B7_Click(object sender, RoutedEventArgs e)
        {
            B7.Content = "X";
            B7.IsEnabled = false;
            Cheak();
            Bot();
        }

        private void B8_Click(object sender, RoutedEventArgs e)
        {
            B8.Content = "X";
            B8.IsEnabled = false;
            Cheak();
            Bot();
        }

        private void B9_Click(object sender, RoutedEventArgs e)
        {
            B9.Content = "X";
            B9.IsEnabled = false;
            Cheak();
            Bot();
        }

        private void play_Click(object sender, RoutedEventArgs e)
        {
            if (play.IsEnabled == true)
            {
                B1.Content = " ";
                B2.Content = " ";
                B3.Content = " ";
                B4.Content = " ";
                B5.Content = " ";
                B6.Content = " ";
                B7.Content = " ";
                B8.Content = " ";
                B9.Content = " ";
                B1.IsEnabled = true;
                B2.IsEnabled = true;
                B3.IsEnabled = true;
                B4.IsEnabled = true;
                B5.IsEnabled = true;
                B6.IsEnabled = true;
                B7.IsEnabled = true;
                B8.IsEnabled = true;
                B9.IsEnabled = true;
            }
}
        }
    }
