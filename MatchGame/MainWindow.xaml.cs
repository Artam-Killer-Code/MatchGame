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

namespace MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetUpGame();
        }

        private void SetUpGame()
        {
            //Make a list of eight pairs of emoji
            List<string> carEmoji = new List<string>(){
                "🚗","🚗",
                "🛺","🛺",
                "🚜","🚜",
                "🚚","🚚",

                "🚒","🚒",
                "🚐","🚐",
                "🚎","🚎",
                "🚅","🚅",
            };

            //Make a new random number generator
            Random random = new Random();

            //  Find every TextBlock in the main grid
            //  and repat the following statement for each of them (code inside curly bracets) 
            foreach(TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                //Pick a random number between 0 and the number of emoji left in the list and call it "index"
                int index = random.Next(carEmoji.Count); 

                // Use random number called "index" to get a random emoji from the list
                string nextEmoji = carEmoji[index];

                //Update the TextBlock with the random emoji from the list
                textBlock.Text = nextEmoji;

                //Remove the random emoji from the list
                carEmoji.RemoveAt(index);
            }
        }
    }
}
