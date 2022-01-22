//Ben Olson
//Chapter 33
//Exercise 6
//11-23-2017

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

namespace BJOChapter33Exercise6
{

    public partial class MainWindow : Window
    {
        //variables to hold random number for color of snake
        byte sR, sG, sB;

        //variables to hold random number for color of canvas background
        byte cR, cG, cB;

        //variable to count number of clicks
        int clicks = 0;

        //polyline for snake body? tail? the part behind the head
        Polyline snake = new Polyline();
      
        //start up main window
        public MainWindow()
        {
            InitializeComponent();

            //set snake body initial stroke to same as initial head fill            
            snake.Stroke = new SolidColorBrush(Color.FromArgb(255, 65, 143, 53));
            //set width of polyline
            snake.StrokeThickness = 20;
            //add snake polyline to canvas
            Canvas.Children.Add(snake);
        }

        //         ****************mouse movement event handler********************

        private void MouseMoveHandler(object sender, MouseEventArgs e)
        {
            //get the position of the mouse
            System.Windows.Point position = e.GetPosition(this);

            //add points to snake polyline
            snake.Points.Add(position);

            //the faster you move the mouse the longer it will be, because the mouse is able to move further inbetween points being added to the polyline

            //limit the size of the polyline
            if(snake.Points.Count > 110)
            {
                //when longer than 110 points remove the first one
                snake.Points.RemoveAt(0);
            }
            
            //get the coordinates of the mouse and assign to variables
            double mX = position.X;
            double mY = position.Y;

            //use the coordinates to set the location of the snakes head
            Canvas.SetLeft(snakeHead, mX-20);//  minus 20 keeps the cursor inside of the head
            Canvas.SetTop(snakeHead, mY-20);

        }

        //        *******************click event handler*******************

        private void SnakeClick(object sender, MouseEventArgs e)
        {
            //increment click counter
            clicks++;

            //set snakes rgb values by calling method;
            SetSnakeRGB();

            //validate snake will not be same color as background
            // for as long check color returns true, it calls method to assign new values
            while (CheckColors(cR, sR, cG, sG, cB, sB))
            {
                //if values are the same, calls method to set new values
                SetSnakeRGB();
            }

            //when returns false, exits while loop and sets snakes fill color
            snakeHead.Stroke = new SolidColorBrush(Color.FromArgb(255, sR, sG, sB));
            snakeHead.Fill = new SolidColorBrush(Color.FromArgb(255, sR, sG, sB));
            snake.Stroke = new SolidColorBrush(Color.FromArgb(255, sR, sG, sB));

            //check if fifth click
            if (clicks == 5)
            {
                //set canvas rgb values by calling method
                SetCanvasRGB();

                // for as long check color returns true, it calls method to assign new values
                while(CheckColors(cR, sR, cG, sG, cB, sB))
                {
                    //if values are the same, calls method to set new values
                    SetCanvasRGB();
                }

                //when returns false, exits while loop and sets canvas background
                Canvas.Background = new SolidColorBrush(Color.FromArgb(255, cR, cG, cB));

                //then reset counter to 0
                clicks = 0;
            }

            //displaying rgb values to UI to confirm colors that look similar are different while testing
            txtSnake.Text = Convert.ToString("R:" + sR + " G:" + sG + " B:" + sB);
            txtCanvas.Text = Convert.ToString("R:" + cR + " G:" + cG + " B:" + cB);
        }

        //      **********************method to check if colors will be the same***********************

        private Boolean CheckColors(byte cr, byte sr, byte cg, byte sg, byte cb, byte sb)
        {
           
            //I passed in the rgb values for the canvas and the snake, then check if the same
            if (cr == sr && cg == sg && cb == sb)
            {
                //if values are the same returns true
                return true;
            }
            else
            {
                //if values are different returns false
                return false;
            }
        }

        //           ******************method to set canvas rgb values*******************
        private void SetCanvasRGB()
        {
            Random random = new Random();

            cR = Convert.ToByte(random.Next(0, 256));
            cG = Convert.ToByte(random.Next(0, 256));
            cB = Convert.ToByte(random.Next(0, 256));
        }

        //          ***************method to set snake rgb values*************************
        private void SetSnakeRGB()
        {
            Random random = new Random();

            sR = Convert.ToByte(random.Next(0, 256));
            sG = Convert.ToByte(random.Next(0, 256));
            sB = Convert.ToByte(random.Next(0, 256));
        }

    }
}
