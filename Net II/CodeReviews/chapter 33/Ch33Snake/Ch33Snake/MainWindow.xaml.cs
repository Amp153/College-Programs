//Mitchell Moua
//Chapter 33, Exercise 6 - Snake Drawer

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Ch33Snake
{

    public partial class MainWindow : Window
    {
        private PointCollection pts = new PointCollection();    //store points for the polyline that represents the snake body (solidSnake)
        private Random rng = new Random();      //for use with random colors
        private int mouseClicks = 0;    //tracks # of clicks

        public MainWindow()
        {
            InitializeComponent();

            solidSnake.Points = pts;
        }

        //on mouse moving
        private void myCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            pts.Add(e.GetPosition(myCanvas));
            Canvas.SetLeft(snakeHead, (e.GetPosition(myCanvas).X - 12));
            Canvas.SetTop(snakeHead, (e.GetPosition(myCanvas).Y - 12));
        }

        //on mouse click
        private void myCanvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mouseClicks++;
            Brush rngColor = new SolidColorBrush(Color.FromRgb((byte)rng.Next(255), (byte)rng.Next(255), (byte)rng.Next(255)));
                //random color, used by both snake head and body to ensure same colors
            solidSnake.Fill = rngColor;
            snakeHead.Fill = rngColor;

            //checks for every 5th click to change the canvas background color
            if (mouseClicks % 5 == 0)
                myCanvas.Background = new SolidColorBrush(Color.FromRgb((byte)rng.Next(255), (byte)rng.Next(255), (byte)rng.Next(255)));
        }
    }
}
