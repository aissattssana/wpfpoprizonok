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

namespace wpfpoprizonok
{
    /// <summary>
    /// Логика взаимодействия для Update.xaml
    /// </summary>
    public partial class Update : Window
    {
        public User22Context us = new User22Context();

        public Update()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, RoutedEventArgs e)
        {
            TextBox[] textBoxes = { agent_kpp, agent_name, agent_inn, agent_index, agent_email, agent_dir, agent_house, agent_phone, agent_type,agent_street, agent_reg,agent_prioritet };
            foreach (var textBox in textBoxes)
            {
                if (String.IsNullOrEmpty(textBox.Text))
                {
                    MessageBox.Show("Введите текст!");
                    return;
                }
            }

            var newAgent = new Agent()
            {
                Name = agent_name.Text,
                Type = agent_type.Text,
                Email = agent_email.Text,
                Phone = agent_phone.Text,
                AgentIndex = agent_index.Text,
                Region = agent_reg.Text,
                Street = agent_street.Text,
                HouseNumber = agent_house.Text,
                Prioritet = Convert.ToInt16(agent_prioritet.Text),
                Director = agent_dir.Text,
                Inn = agent_inn.Text,
                Kpp = agent_kpp.Text,
                Logo = "NULL"
            };

            us.Agents.Add(newAgent);
            us.SaveChanges();
            MessageBox.Show("Агент успешно добавлен");
        }

        private void dekete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.ShowDialog();

        }
    }
}
