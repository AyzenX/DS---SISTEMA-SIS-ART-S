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

namespace projetoSISARTS
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void passbox_password_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((txtUsuario.Text == "afavsdirecao") && (passbox_password.Password == "admin"))
            {
                Menu mmenu = new Menu();
                mmenu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha Incorretos !!");
            }

            if ((txtUsuario.Text == "") &&(passbox_password.Password == ""))
            {
                MessageBox.Show("Os campos não podem ficar vazios !!!");
            }
            
        }
    }
}
