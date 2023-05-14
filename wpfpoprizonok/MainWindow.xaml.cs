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

namespace wpfpoprizonok
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public User22Context us = new User22Context();
        Agent ag = new Agent();
        public MainWindow()
        {
            InitializeComponent();
            AgentView.ItemsSource = us.Agents.ToList();
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            AgentView.ItemsSource = us.Agents.Where(x => x.Type == "ООО").ToList();

        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            AgentView.ItemsSource = us.Agents.Where(x => x.Type == "ОАО").ToList();

        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            AgentView.ItemsSource = us.Agents.Where(x => x.Type == "ЗАО").ToList();

        }

        private void ComboBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            AgentView.ItemsSource = us.Agents.Where(x => x.Type == "МКК").ToList();

        }

        private void ComboBoxItem_Selected_4(object sender, RoutedEventArgs e)
        {
            AgentView.ItemsSource = us.Agents.Where(x => x.Type == "ПАО").ToList();

        }

        private void ComboBoxItem_Selected_5(object sender, RoutedEventArgs e)
        {
            AgentView.ItemsSource = us.Agents.Where(x => x.Type == "МФО").ToList();

        }

        private void ComboBoxItem_Selected_6(object sender, RoutedEventArgs e)
        {
            AgentView.ItemsSource = us.Agents.OrderBy(x => x.Prioritet).ToList();
        }

        private void ComboBoxItem_Selected_7(object sender, RoutedEventArgs e)
        {
            AgentView.ItemsSource = us.Agents.OrderByDescending(x => x.Prioritet).ToList();
        }

        private void ComboBoxItem_Selected_8(object sender, RoutedEventArgs e)
        {
            AgentView.ItemsSource = us.Agents.ToList();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            us.Agents.Remove(ag);
            us.SaveChanges();
            AgentView.ItemsSource = us.Agents.ToList();
            MessageBox.Show("Агент удален");
        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            AgentView.ItemsSource = us.Agents.Where(x => x.Name == search.Text).ToList();
            if(search.Text == "")
            {
                AgentView.ItemsSource = us.Agents.ToList();
            }
        }

        private void create_Click(object sender, RoutedEventArgs e)
        {
            Update up = new Update();
            up.ShowDialog();
        }
    }
}
