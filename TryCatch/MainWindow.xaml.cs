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

namespace TryCatch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int ingave;
        public MainWindow()
        {
            InitializeComponent();
        }
        
        // werkt hier thuis verder aan
         
        private void btnOef1_Click(object sender, RoutedEventArgs e)
        {
            try
            { int tekst = int.Parse(txtIngave.Text);
                if (tekst < 10 || tekst > 1000)
            }

            int intingave = txtIngave.Text;
            if(txtIngave.Text )
            { }

            else
            { }
        }

        private void btnLijstLeegmaken_Click(object sender, RoutedEventArgs e)
        {
            txtIngave.Clear();
        }
    }
}
