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

namespace qwhtaveer
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		List<Ember> lista = new List<Ember>();
		public MainWindow()
		{
			InitializeComponent();
			
			lista.Add(new Ember("valaki", 42));
			lista.Add(new Ember("valaki", 42));
			lista.Add(new Ember("valaki", 42));
			lista.Add(new Ember("valaki", 42));
			lista.Add(new Ember("valaki", 42));
			lista.Add(new Ember("valaki", 42));
			emberek.ItemsSource = lista;
			lista.Add(new Ember("Senki", 1));

		}

		private void btn_hozzaad_Click(object sender, RoutedEventArgs e)
		{
            if (et_nev.Text.Trim() != "" && et_kor.Text.Trim()!="" && Convert.ToInt32(et_kor.Text) > 0 && Convert.ToInt32(et_kor.Text) < 200)
            {
                lista.Add(new Ember(et_nev.Text,Convert.ToInt32(et_kor.Text)));
				emberek.Items.Refresh();
				et_nev.Text = "";
				et_kor.Text = "";
			}
            else
            {
				MessageBox.Show("Hibás adatok!");
				return;
			}
			//&& Convert.ToInt32(et_kor.Text) > 0 && Convert.ToInt32(et_kor.Text) < 200

		}

		private void btn_torol_Click(object sender, RoutedEventArgs e)
		{
			Ember selected = emberek.SelectedItem as Ember;
            if (selected != null)
            {
				lista.Remove(selected);
				emberek.Items.Refresh();
            }
            else
            {
				MessageBox.Show("Nincs kijelölt elem");
				return;
            }
        }
	}
}
