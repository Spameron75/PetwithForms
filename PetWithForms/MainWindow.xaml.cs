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

namespace PetWithForms
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
        private void game_start(object sender, RoutedEventArgs e)
        {
            if (name_input.Text != "") // Checks that a name has been entered
            {
                Pet Pet = new Pet();
                Pet.setName(name_input.Text);
                display_name.Text = Pet.getName();
                updateHealth(false, Pet.getHealth());
                updateHappiness(false, Pet.getHappiness());
                updateBoredom(false, Pet.getBoredom());
                updateHunger(false, Pet.getHunger());
                updateMental(false, Pet.getMental());
                // Create an instance of Pet(), and updates the displayed values to the values created by the constructor
                Start.Visibility = Visibility.Collapsed;
                Play.Visibility = Visibility.Visible;
                // The layouts are switched
            }
            
        }
        // Events for buttons, adjusting stats accordingly, and sending the display message
        private void interact_pet(object sender, RoutedEventArgs e)
        {
            msgBox.Text = ("You pet " + Pet.getName() + ", they appreciate your care");
            updateHappiness(true, 20);
            updateBoredom(true, 10);
            updateHunger(true, 10);
            
        }
        private void interact_feed(object sender, RoutedEventArgs e)
        {
            msgBox.Text = ("You feed " + Pet.getName() + ", they gobble it down");
            updateBoredom(true, 10);
            updateHunger(true, -30);
        }
        private void interact_play(object sender, RoutedEventArgs e)
        {
            msgBox.Text = ("This doesn't exist yet, but there'll be a word game here soon");
        }
        private void interact_sleep(object sender, RoutedEventArgs e)
        {
            msgBox.Text = ("You put " + Pet.getName() + " to bed, and go to sleep until the morning");
            updateHealth(true, 50);
            updateHunger(true, 40);
            updateHappiness(true, -40);
        }

        // Functions to update the stats, with option to set or add, with validation so that they don't exeed 0-100
        public void updateHealth(bool add, int val)
        {
            int var;
            if (add == true)
            {
                var = (Pet.getHealth() + val);
            }
            else
            {
                var = val;
            }
            if (var > 100)
            {
                var = 100;
            }
            else if (var < 0)
            {
                var = 0;
            }
            Pet.setHealth(var);
            health.Text = ("Health : " + var + "/100");
        }
        public void updateHappiness(bool add, int val)
        {
            int var;
            if (add == true)
            {
                var = (Pet.getHappiness() + val);
            }
            else
            {
                var = val;
            }
            if (var > 100)
            {
                var = 100;
            }
            else if (var < 0)
            {
                var = 0;
            }
            Pet.setHappiness(var);
            happiness.Text = ("Happiness : " + var + "/100");
        }
        public void updateBoredom(bool add, int val)
        {
            int var;
            if (add == true)
            {
                var = (Pet.getBoredom() + val);
            }
            else
            {
                var = val;
            }
            if (var > 100)
            {
                var = 100;
            }
            else if (var < 0)
            {
                var = 0;
            }
            Pet.setBoredom(var);
            boredom.Text = ("Boredom : " + var + "/100");
        }
        public void updateHunger(bool add, int val)
        {
            int var;
            if (add == true)
            {
                var = (Pet.getHunger() + val);
            }
            else
            {
                var = val;
            }
            if (var > 100)
            {
                updateHealth(true, -10);
                var = 100;
            }
            else if (var < 0)
            {
                var = 0;
                updateHealth(true, -5);
            }
            Pet.setHunger(var);
            hunger.Text = ("Hunger : " + var + "/100");
        }

        /*
        Mental is currently unused, due to the lack of the minigame, 
        the game will revolve around asking for words that begin with the same letter, 
        only accepting new ones, with three strikes
        */
        public void updateMental(bool add, int val)
        {
            int var;
            if (add == true)
            {
                var = (Pet.getMental() + val);
            }
            else
            {
                var = val;
            }
            if (var > 100)
            {
                var = 100;
            }
            else if (var < 0)
            {
                var = 0;
            }
            Pet.setMental(var);
            mental.Text = ("Mental : " + var + "/100");
        }


    }
}