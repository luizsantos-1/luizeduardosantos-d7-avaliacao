using ControleDeAcesso.Data;
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


namespace ControleDeAcesso
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Context context;
        private User loginAttempt = new();

        public MainWindow(Context context)
        {
            this.context = context;
            InitializeComponent();
  
            LoginGrid.DataContext = loginAttempt;
        }

        private void CheckUser(object sender, RoutedEventArgs e)
        {
            var UserList = context.Users.ToList();
            foreach (User user in UserList)
            {
                if (user.Username == loginAttempt.Username & user.Password == loginAttempt.Password)
                {
                    MessageBox.Show("Usuario autenticado");
                    return;
                }

            }
            MessageBox.Show("Credenciais invalidas");
        }
    }
}
