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
using Model;

namespace WPF
{
    /// <summary>
    /// Interaction logic for GoalWindow.xaml
    /// </summary>
    public partial class GoalWindow : Window
    {
        public GoalWindow()
        {
            InitializeComponent();
            TheGoal = new Goal("", "", DateTime.Now);
            DataContext = TheGoal;
            priorityComboBox.ItemsSource = Enum.GetValues(typeof(Goal.GoalPriority));
        }

        public Goal TheGoal { get; internal set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
