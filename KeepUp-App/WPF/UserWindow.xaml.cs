using Model;
using System.Windows;


namespace WPF
{
    /// <summary>
    /// Interaction logic for UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        public UserWindow(Person person)
        {
            InitializeComponent();
            DataContext = person;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GoalWindow goalWindow = new GoalWindow();
            goalWindow.ShowDialog();

            ((Person)DataContext).Goals.Add( goalWindow.TheGoal);
            goalGrid.Items.Refresh();
        }
    }
}
