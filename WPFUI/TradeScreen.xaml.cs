using Engine.Models;
using Engine.ViewModels;
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
using System.Windows.Shapes;

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for TradeScreen.xaml
    /// </summary>
    public partial class TradeScreen : Window
    {
        public GameSession Session => DataContext as GameSession;
        public TradeScreen()
        {
            InitializeComponent();
        }
        private void OnClick_Sell(object sender, RoutedEventArgs e)
        {
            GroupedInventoryItem? item = ((FrameworkElement)sender).DataContext as GroupedInventoryItem;
            if (item != null)
            {
                Session.CurrentPlayer.Gold += item.Item.Price;
                Session.CurrentTrader.AddItemToInventory(item.Item);
                Session.CurrentPlayer.RemoveItemFromInventory(item.Item);
            }
        }
        private void OnClick_Buy(object sender, RoutedEventArgs e)
        {
            GroupedInventoryItem? item = ((FrameworkElement)sender).DataContext as GroupedInventoryItem;
            if (item != null)
            {
                if (Session.CurrentPlayer.Gold >= item.Item.Price)
                {
                    Session.CurrentPlayer.Gold -= item.Item.Price;
                    Session.CurrentTrader.RemoveItemFromInventory(item.Item);
                    Session.CurrentPlayer.AddItemToInventory(item.Item);
                }
                else
                {
                    MessageBox.Show("You do not have enough gold");
                }
            }
        }
        private void OnClick_Close(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
