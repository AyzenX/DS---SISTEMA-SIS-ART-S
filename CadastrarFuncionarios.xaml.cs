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

namespace projetoSISARTS
{
    /// <summary>
    /// Lógica interna para CadastrarFuncionarios.xaml
    /// </summary>
    public partial class CadastrarFuncionarios : Window
    {
        public CadastrarFuncionarios()
        {
            InitializeComponent();
        }

        private void Salvar(object sender, RoutedEventArgs e)
        {
            String Nome = txNome.Text;
            String DataNasc = txDataNasc.Text;
            int CPF = Convert.ToInt32(txCPF.Text);
            int RG = Convert.ToInt32(txRG.Text);
            int Telefone = Convert.ToInt32(txTelefone.Text);
            String Rua = txRua.Text;
            String Bairro = txBairro.Text;
            int Numero = Convert.ToInt32(txCPF.Text);
            String Complemento = txComplemento.Text;

            MessageBox.Show("Funcionário Cadastrado com sucesso!");

            MessageBox.Show("Aplicação sem integração a um banco de dados no momento");
            LimparCampos();
        }

        private void Editar(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Aplicação sem integração a um banco de dados no momento");
            LimparCampos();
        }
        private void Excluir(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Funcionário excluído com sucesso");
            MessageBox.Show("Aplicação sem integração a um banco de dados no momento");
            LimparCampos();
        }
        private void LimparCampos()
        {
            txNome.Text = "";
            txDataNasc.Text = "";
            txCPF.Text = "";
            txRG.Text = "";
            txTelefone.Text = "";
            txRua.Text = "";
            txBairro.Text = "";
            txCPF.Text = "";
            txComplemento.Text = "";
        }
    }
}
