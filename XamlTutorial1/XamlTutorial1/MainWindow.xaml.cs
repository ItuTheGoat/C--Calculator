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

namespace XamlTutorial1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        public static double firstOperation = 0, secondOperation = 0;
        public static string sign = "";
        public static List<string> answerList = new List<string> ();
        

        private void _0_Click(object sender, RoutedEventArgs e)
        {
            if (!txtDisplay.Text.Equals("0"))
            {

                txtDisplay.Text = txtDisplay.Text + "0";

            }
            
        } 

        private void _1_Click(object sender, RoutedEventArgs e)
        {
            if(!txtDisplay.Text.Equals("0"))
            {
                
                txtDisplay.Text = txtDisplay.Text + "1";

            } else
            {
                txtDisplay.Text = "1";
            }
        }

        private void _2_Click(object sender, RoutedEventArgs e)
        {
            

            if (!txtDisplay.Text.Equals("0"))
            {

                txtDisplay.Text = txtDisplay.Text + "2";

            }
            else
            {
                txtDisplay.Text = "2";
            }
        }

        private void _3_Click(object sender, RoutedEventArgs e)
        {
            if (!txtDisplay.Text.Equals("0"))
            {

                txtDisplay.Text = txtDisplay.Text + "3";

            }
            else
            {
                txtDisplay.Text = "3";
            }
        }

        private void _4_Click(object sender, RoutedEventArgs e)
        {
            if (!txtDisplay.Text.Equals("0"))
            {

                txtDisplay.Text = txtDisplay.Text + "4";

            }
            else 
            {
                txtDisplay.Text = "4";
            }
        }

        private void _5_Click(object sender, RoutedEventArgs e)
        {
            if (!txtDisplay.Text.Equals("0"))
            {

                txtDisplay.Text = txtDisplay.Text + "5";

            }
            else
            {
                txtDisplay.Text = "5";
            }
        }

        private void _6_Click(object sender, RoutedEventArgs e)
        {
            if (!txtDisplay.Text.Equals("0"))
            {

                txtDisplay.Text = txtDisplay.Text + "6";

            }
            else 
            {
                txtDisplay.Text = "6";
            }
        }

        private void _7_Click(object sender, RoutedEventArgs e)
        {
            if (!txtDisplay.Text.Equals("0"))
            {

                txtDisplay.Text = txtDisplay.Text + "7";

            }
            else 
            {
                txtDisplay.Text = "7";
            }
        }

        private void _8_Click(object sender, RoutedEventArgs e)
        {
            if (!txtDisplay.Text.Equals("0"))
            {

                txtDisplay.Text = txtDisplay.Text + "8";

            }
            else 
            {
                txtDisplay.Text = "8";
            }
        }

        private void _9_Click(object sender, RoutedEventArgs e)
        {
            if (!txtDisplay.Text.Equals("0"))
            {

                txtDisplay.Text = txtDisplay.Text + "9";

            }
            else 
            {
                txtDisplay.Text = "9";
            }
        }

        private void _decimal_Click(object sender, RoutedEventArgs e)
        {
            if(!txtDisplay.Text.Contains(","))
            {
                txtDisplay.Text = txtDisplay.Text + ",";
            }
        }

        private void equals_Click(object sender, RoutedEventArgs e)
        {
            if(!lblAnswer.Content.Equals(""))
            {
                secondOperation = double.Parse(txtDisplay.Text);
                switch (sign)
                {
                    case "+":
                        firstOperation = firstOperation + secondOperation;
                        sign = "x";
                       
                        break;
                    case "-":
                        firstOperation = firstOperation - secondOperation;
                        sign = "x";
                        
                        break;
                    case "x":
                        firstOperation = firstOperation * secondOperation;
                        sign = "x";
                        
                        break;
                    case "÷":
                        if (secondOperation == 0)
                        {
                            MessageBox.Show("You cannot divide by 0");
                        }
                        else
                        {
                            firstOperation = firstOperation / secondOperation;
                        }
                        break;
                }
                 

                
            }
            string str = "Answer: " + firstOperation;
            answerList.Add(str);

            ListBox1.ItemsSource = null;
            ListBox1.ItemsSource = answerList;


            // Making everything default
            txtDisplay.Text = "0";
            lblAnswer.Content = "";
            firstOperation = 0;
            secondOperation = 0;
            sign = "";
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            if (lblAnswer.Content.Equals(""))
            {
                if (!txtDisplay.Text.Equals("0"))
                {
                    firstOperation = double.Parse(txtDisplay.Text);
                    sign = "x";
                    lblAnswer.Content = txtDisplay.Text + sign;
                    txtDisplay.Text = "0";
                }
            }
            else
            {
                secondOperation = double.Parse(txtDisplay.Text);
                switch (sign)
                {
                    case "+":
                        firstOperation = firstOperation + secondOperation;
                        sign = "x";
                        lblAnswer.Content = firstOperation + sign;
                        break;
                    case "-":
                        firstOperation = firstOperation - secondOperation;
                        sign = "x";
                        lblAnswer.Content = firstOperation + sign;
                        break;
                    case "x":
                        firstOperation = firstOperation * secondOperation;
                        sign = "x";
                        lblAnswer.Content = firstOperation + sign;
                        break;
                    case "÷":
                        if (secondOperation == 0)
                        {
                            MessageBox.Show("You cannot divide by 0");
                            firstOperation = 0;
                            secondOperation = 0;
                            sign = "";

                            lblAnswer.Content = "";

                        }
                        else
                        {
                            firstOperation = firstOperation / secondOperation;
                            sign = "x";
                            lblAnswer.Content = firstOperation + sign;

                        }


                        break;
                }
                txtDisplay.Text = "0";


            }
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            if (lblAnswer.Content.Equals(""))
            {
                if (!txtDisplay.Text.Equals("0"))
                {
                    firstOperation = double.Parse(txtDisplay.Text);
                    sign = "÷";
                    lblAnswer.Content = txtDisplay.Text + sign;
                    txtDisplay.Text = "0";
                }
            }
            else
            {
                secondOperation = double.Parse(txtDisplay.Text);
                switch (sign)
                {
                    case "+":
                        firstOperation = firstOperation + secondOperation;
                        sign = "÷";
                        lblAnswer.Content = firstOperation + sign;
                        break;
                    case "-":
                        firstOperation = firstOperation - secondOperation;
                        sign = "÷";
                        lblAnswer.Content = firstOperation + sign;
                        break;
                    case "x":
                        firstOperation = firstOperation * secondOperation;
                        sign = "÷";
                        lblAnswer.Content = firstOperation + sign;
                        break;
                    case "÷":
                        if (secondOperation == 0)
                        {
                            MessageBox.Show("You cannot divide by 0");
                            firstOperation = 0;
                            secondOperation = 0;
                            sign = "";

                            lblAnswer.Content = "";

                        }
                        else
                        {
                            firstOperation = firstOperation / secondOperation;
                            sign = "÷";
                            lblAnswer.Content = firstOperation + sign;

                        }


                        break;
                }
                txtDisplay.Text = "0";


            }
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            if (lblAnswer.Content.Equals(""))
            {
                if (!txtDisplay.Text.Equals("0"))
                {
                    firstOperation = double.Parse(txtDisplay.Text);
                    sign = "-";
                    lblAnswer.Content = txtDisplay.Text + sign;
                    txtDisplay.Text = "0";
                }
            }
            else
            {
                secondOperation = double.Parse(txtDisplay.Text);
                switch (sign)
                {
                    case "+":
                        firstOperation = firstOperation + secondOperation;
                        sign = "-";
                        lblAnswer.Content = firstOperation + sign;
                        break;
                    case "-":
                        firstOperation = firstOperation - secondOperation;
                        sign = "-";
                        lblAnswer.Content = firstOperation + sign;
                        break;
                    case "x":
                        firstOperation = firstOperation * secondOperation;
                        sign = "-";
                        lblAnswer.Content = firstOperation + sign;
                        break;
                    case "÷":
                        if (secondOperation == 0)
                        {
                            MessageBox.Show("You cannot divide by 0");
                            firstOperation = 0;
                            secondOperation = 0;
                            sign = "";

                            lblAnswer.Content = "";

                        }
                        else
                        {
                            firstOperation = firstOperation / secondOperation;
                            sign = "-";
                            lblAnswer.Content = firstOperation + sign;

                        }


                        break;
                }
                txtDisplay.Text = "0";

               
            }

        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            if(lblAnswer.Content.Equals(""))
            {
                if (!txtDisplay.Text.Equals("0"))
                {
                    firstOperation = double.Parse(txtDisplay.Text);
                    sign = "+";
                    lblAnswer.Content = txtDisplay.Text + sign;
                    txtDisplay.Text = "0";
                }
            } else
            {
                secondOperation = double.Parse(txtDisplay.Text);
                switch(sign)
                {
                    case "+":
                        firstOperation = firstOperation + secondOperation;
                        sign = "+";
                        lblAnswer.Content = firstOperation + sign;
                        
                        break;
                    case "-":
                        firstOperation = firstOperation - secondOperation;
                        sign = "+";
                        lblAnswer.Content = firstOperation + sign;
                        break;
                    case "x":
                        firstOperation = firstOperation * secondOperation;
                        sign = "+";
                        lblAnswer.Content = firstOperation + sign;
                        break;
                    case "÷":
                        if(secondOperation == 0)
                        {
                            MessageBox.Show("You cannot divide by 0");
                            
                            firstOperation = 0;
                            secondOperation = 0;
                            sign = "";

                            lblAnswer.Content = "";

                        } else
                        {
                            firstOperation = firstOperation / secondOperation;
                            sign = "+";
                            lblAnswer.Content = firstOperation + sign;

                        }


                        break;
                }

               
                txtDisplay.Text = "0";
            }
            
            

            
        }

        private void btnClear1_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text.Length > 1)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            } else
            {
                txtDisplay.Text = "0";
            }

            
        }

        private void btnClearAll_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = "0";
            lblAnswer.Content = "";
            firstOperation = 0;
            secondOperation = 0;
            
        }
    }

       
}
