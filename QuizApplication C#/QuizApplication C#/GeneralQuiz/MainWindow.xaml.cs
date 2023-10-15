using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GeneralQuiz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Quiz q = new Quiz();
        private List<int> lst = new List<int>();
        private string ans;
        private int score = 0;
        private int number = 1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            start.Visibility = Visibility.Hidden;
            quest.Visibility = Visibility.Visible;
            ans1.Visibility = Visibility.Visible;
            ans2.Visibility = Visibility.Visible;
            ans3.Visibility = Visibility.Visible;
            ans4.Visibility = Visibility.Visible;
            scoreLbl.Visibility = Visibility.Visible;
            //
            int i = this.getRandom();
            quest.Content = q.getQuestion(i);
            //
            ans1.Content = q.getAnswer(i, 1);
            ans2.Content = q.getAnswer(i, 2);
            ans3.Content = q.getAnswer(i, 3);
            ans4.Content = q.getAnswer(i, 4);
            if (Convert.ToString(ans1.Content).StartsWith("*"))
            {
                this.ans = Convert.ToString(ans1.Content).Substring(1, Convert.ToString(ans1.Content).Length - 1);
                ans1.Content = Convert.ToString(ans1.Content).Substring(1, Convert.ToString(ans1.Content).Length - 1);
            }
            else
            {
                if (Convert.ToString(ans2.Content).StartsWith("*"))
                {
                    this.ans = Convert.ToString(ans2.Content).Substring(1, Convert.ToString(ans2.Content).Length - 1);
                    ans2.Content = Convert.ToString(ans2.Content).Substring(1, Convert.ToString(ans2.Content).Length - 1);
                }
                else
                {
                    if (Convert.ToString(ans3.Content).StartsWith("*"))
                    {
                        this.ans = Convert.ToString(ans3.Content).Substring(1, Convert.ToString(ans3.Content).Length - 1);
                        ans3.Content = Convert.ToString(ans3.Content).Substring(1, Convert.ToString(ans3.Content).Length - 1);
                    }
                    else
                    {
                        this.ans = Convert.ToString(ans4.Content).Substring(1, Convert.ToString(ans4.Content).Length - 1);
                        ans4.Content = Convert.ToString(ans4.Content).Substring(1, Convert.ToString(ans4.Content).Length - 1);
                    }
                }
            }


            lst.Add(i);
        }
        public int getRandom()
        {
            Random rnd = new Random();
            int i = rnd.Next(11);
            if(lst.Contains(i) && lst.Count()<11)
                while(lst.Contains(i))
                    i = rnd.Next(0,11);
            return i;
        }

        private void ans1_Click(object sender, RoutedEventArgs e)
        {
            if (this.number < 11)
            {
                this.number++;
                if (Convert.ToString(ans1.Content) == this.ans)
                    this.score++;
                int i = this.getRandom();
                quest.Content = q.getQuestion(i);
                //
                ans1.Content = q.getAnswer(i, 1);
                ans2.Content = q.getAnswer(i, 2);
                ans3.Content = q.getAnswer(i, 3);
                ans4.Content = q.getAnswer(i, 4);
                if (Convert.ToString(ans1.Content).StartsWith("*"))
                {
                    this.ans = Convert.ToString(ans1.Content).Substring(1, Convert.ToString(ans1.Content).Length - 1);
                    ans1.Content = Convert.ToString(ans1.Content).Substring(1, Convert.ToString(ans1.Content).Length - 1);
                }
                else
                {
                    if (Convert.ToString(ans2.Content).StartsWith("*"))
                    {
                        this.ans = Convert.ToString(ans2.Content).Substring(1, Convert.ToString(ans2.Content).Length - 1);
                        ans2.Content = Convert.ToString(ans2.Content).Substring(1, Convert.ToString(ans2.Content).Length - 1);
                    }
                    else
                    {
                        if (Convert.ToString(ans3.Content).StartsWith("*"))
                        {
                            this.ans = Convert.ToString(ans3.Content).Substring(1, Convert.ToString(ans3.Content).Length - 1);
                            ans3.Content = Convert.ToString(ans3.Content).Substring(1, Convert.ToString(ans3.Content).Length - 1);
                        }
                        else
                        {
                            this.ans = Convert.ToString(ans4.Content).Substring(1, Convert.ToString(ans4.Content).Length - 1);
                            ans4.Content = Convert.ToString(ans4.Content).Substring(1, Convert.ToString(ans4.Content).Length - 1);
                        }
                    }
                }
                lst.Add(i);
                scoreLbl.Content = "Score : "+this.score;
            }
            else
            {
                quest.Visibility = Visibility.Hidden;
                ans1.Visibility = Visibility.Hidden;
                ans2.Visibility = Visibility.Hidden;
                ans3.Visibility = Visibility.Hidden;
                ans4.Visibility = Visibility.Hidden;
                final.Visibility = Visibility.Visible;
                final.Content ="         Congratulations" + "\n          Your score is " + this.score;
                restart.Visibility = Visibility.Visible;
            }
        }

        private void ans2_Click(object sender, RoutedEventArgs e)
        {
            if (this.number < 11)
            {
                this.number++;
                if (Convert.ToString(ans2.Content) == this.ans)
                    this.score++;
                int i = this.getRandom();
                quest.Content = q.getQuestion(i);
                //
                ans1.Content = q.getAnswer(i, 1);
                ans2.Content = q.getAnswer(i, 2);
                ans3.Content = q.getAnswer(i, 3);
                ans4.Content = q.getAnswer(i, 4);
                if (Convert.ToString(ans1.Content).StartsWith("*"))
                {
                    this.ans = Convert.ToString(ans1.Content).Substring(1, Convert.ToString(ans1.Content).Length - 1);
                    ans1.Content = Convert.ToString(ans1.Content).Substring(1, Convert.ToString(ans1.Content).Length - 1);
                }
                else
                {
                    if (Convert.ToString(ans2.Content).StartsWith("*"))
                    {
                        this.ans = Convert.ToString(ans2.Content).Substring(1, Convert.ToString(ans2.Content).Length - 1);
                        ans2.Content = Convert.ToString(ans2.Content).Substring(1, Convert.ToString(ans2.Content).Length - 1);
                    }
                    else
                    {
                        if (Convert.ToString(ans3.Content).StartsWith("*"))
                        {
                            this.ans = Convert.ToString(ans3.Content).Substring(1, Convert.ToString(ans3.Content).Length - 1);
                            ans3.Content = Convert.ToString(ans3.Content).Substring(1, Convert.ToString(ans3.Content).Length - 1);
                        }
                        else
                        {
                            this.ans = Convert.ToString(ans4.Content).Substring(1, Convert.ToString(ans4.Content).Length - 1);
                            ans4.Content = Convert.ToString(ans4.Content).Substring(1, Convert.ToString(ans4.Content).Length - 1);
                        }
                    }
                }
                lst.Add(i);
                scoreLbl.Content = "Score : " + this.score;
            }
            else
            {
                quest.Visibility = Visibility.Hidden;
                ans1.Visibility = Visibility.Hidden;
                ans2.Visibility = Visibility.Hidden;
                ans3.Visibility = Visibility.Hidden;
                ans4.Visibility = Visibility.Hidden;
                final.Visibility = Visibility.Visible;
                final.Content = "         Congratulations"+"\n          Your score is " + this.score;
                restart.Visibility = Visibility.Visible;
            }
        }

        private void ans3_Click(object sender, RoutedEventArgs e)
        {
            if (this.number < 11)
            {
                this.number++;
                if (Convert.ToString(ans3.Content) == this.ans)
                    this.score++;
                int i = this.getRandom();
                quest.Content = q.getQuestion(i);
                //
                ans1.Content = q.getAnswer(i, 1);
                ans2.Content = q.getAnswer(i, 2);
                ans3.Content = q.getAnswer(i, 3);
                ans4.Content = q.getAnswer(i, 4);
                if (Convert.ToString(ans1.Content).StartsWith("*"))
                {
                    this.ans = Convert.ToString(ans1.Content).Substring(1, Convert.ToString(ans1.Content).Length - 1);
                    ans1.Content = Convert.ToString(ans1.Content).Substring(1, Convert.ToString(ans1.Content).Length - 1);
                }
                else
                {
                    if (Convert.ToString(ans2.Content).StartsWith("*"))
                    {
                        this.ans = Convert.ToString(ans2.Content).Substring(1, Convert.ToString(ans2.Content).Length - 1);
                        ans2.Content = Convert.ToString(ans2.Content).Substring(1, Convert.ToString(ans2.Content).Length - 1);
                    }
                    else
                    {
                        if (Convert.ToString(ans3.Content).StartsWith("*"))
                        {
                            this.ans = Convert.ToString(ans3.Content).Substring(1, Convert.ToString(ans3.Content).Length - 1);
                            ans3.Content = Convert.ToString(ans3.Content).Substring(1, Convert.ToString(ans3.Content).Length - 1);
                        }
                        else
                        {
                            this.ans = Convert.ToString(ans4.Content).Substring(1, Convert.ToString(ans4.Content).Length - 1);
                            ans4.Content = Convert.ToString(ans4.Content).Substring(1, Convert.ToString(ans4.Content).Length - 1);
                        }
                    }
                }
                lst.Add(i);
                scoreLbl.Content = "Score : " + this.score;
            }
            else
            {
                quest.Visibility = Visibility.Hidden;
                ans1.Visibility = Visibility.Hidden;
                ans2.Visibility = Visibility.Hidden;
                ans3.Visibility = Visibility.Hidden;
                ans4.Visibility = Visibility.Hidden;
                final.Visibility = Visibility.Visible;
                final.Content = "         Congratulations"+"\n          Your score is " + this.score;
                restart.Visibility = Visibility.Visible;
            }
        }

        private void ans4_Click(object sender, RoutedEventArgs e)
        {
            if (this.number <11)
            {
                this.number++;
                if (Convert.ToString(ans4.Content) == this.ans)
                    this.score++;
                int i = this.getRandom();
                quest.Content = q.getQuestion(i);
                //
                ans1.Content = q.getAnswer(i, 1);
                ans2.Content = q.getAnswer(i, 2);
                ans3.Content = q.getAnswer(i, 3);
                ans4.Content = q.getAnswer(i, 4);
                if (Convert.ToString(ans1.Content).StartsWith("*"))
                {
                    this.ans = Convert.ToString(ans1.Content).Substring(1, Convert.ToString(ans1.Content).Length - 1);
                    ans1.Content = Convert.ToString(ans1.Content).Substring(1, Convert.ToString(ans1.Content).Length - 1);
                }
                else
                {
                    if (Convert.ToString(ans2.Content).StartsWith("*"))
                    {
                        this.ans = Convert.ToString(ans2.Content).Substring(1, Convert.ToString(ans2.Content).Length - 1);
                        ans2.Content = Convert.ToString(ans2.Content).Substring(1, Convert.ToString(ans2.Content).Length - 1);
                    }
                    else
                    {
                        if (Convert.ToString(ans3.Content).StartsWith("*"))
                        {
                            this.ans = Convert.ToString(ans3.Content).Substring(1, Convert.ToString(ans3.Content).Length - 1);
                            ans3.Content = Convert.ToString(ans3.Content).Substring(1, Convert.ToString(ans3.Content).Length - 1);
                        }
                        else
                        {
                            this.ans = Convert.ToString(ans4.Content).Substring(1, Convert.ToString(ans4.Content).Length - 1);
                            ans4.Content = Convert.ToString(ans4.Content).Substring(1, Convert.ToString(ans4.Content).Length - 1);
                        }
                    }
                }
                lst.Add(i);
                scoreLbl.Content = "Score : " + this.score;
            }
            else
            {
                quest.Visibility = Visibility.Hidden;
                ans1.Visibility = Visibility.Hidden;
                ans2.Visibility = Visibility.Hidden;
                ans3.Visibility = Visibility.Hidden;
                ans4.Visibility = Visibility.Hidden;
                final.Visibility = Visibility.Visible;
                final.Content = "         Congratulations" + "\n          Your score is " + this.score;
                restart.Visibility = Visibility.Visible;
               
            }
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            this.score = 0;
            scoreLbl.Content = "Score : "+this.score;
            this.number = 1;
            final.Visibility = Visibility.Hidden;
            lst.Clear();
            restart.Visibility = Visibility.Hidden;
            quest.Visibility = Visibility.Visible;
            ans1.Visibility = Visibility.Visible;
            ans2.Visibility = Visibility.Visible;
            ans3.Visibility = Visibility.Visible;
            ans4.Visibility = Visibility.Visible;
            scoreLbl.Visibility = Visibility.Visible;
            //
            int i = this.getRandom();
            quest.Content = q.getQuestion(i);
            //
            ans1.Content = q.getAnswer(i, 1);
            ans2.Content = q.getAnswer(i, 2);
            ans3.Content = q.getAnswer(i, 3);
            ans4.Content = q.getAnswer(i, 4);
            if (Convert.ToString(ans1.Content).StartsWith("*"))
            {
                this.ans = Convert.ToString(ans1.Content).Substring(1, Convert.ToString(ans1.Content).Length - 1);
                ans1.Content = Convert.ToString(ans1.Content).Substring(1, Convert.ToString(ans1.Content).Length - 1);
            }
            else
            {
                if (Convert.ToString(ans2.Content).StartsWith("*"))
                {
                    this.ans = Convert.ToString(ans2.Content).Substring(1, Convert.ToString(ans2.Content).Length - 1);
                    ans2.Content = Convert.ToString(ans2.Content).Substring(1, Convert.ToString(ans2.Content).Length - 1);
                }
                else
                {
                    if (Convert.ToString(ans3.Content).StartsWith("*"))
                    {
                        this.ans = Convert.ToString(ans3.Content).Substring(1, Convert.ToString(ans3.Content).Length - 1);
                        ans3.Content = Convert.ToString(ans3.Content).Substring(1, Convert.ToString(ans3.Content).Length - 1);
                    }
                    else
                    {
                        this.ans = Convert.ToString(ans4.Content).Substring(1, Convert.ToString(ans4.Content).Length - 1);
                        ans4.Content = Convert.ToString(ans4.Content).Substring(1, Convert.ToString(ans4.Content).Length - 1);
                    }
                }
            }
            lst.Add(i);
        }
    }
}
