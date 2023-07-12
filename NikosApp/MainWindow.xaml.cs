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

namespace NikosApp
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}
		private void NewItem_Click(object sender, RoutedEventArgs e)
		{
			MainFrame.NavigationService.Navigate(new Page1());
		}
		private void Frames_Click(object sender, RoutedEventArgs e)
		{
			// Ο κώδικας εδώ θα εκτελεστεί όταν κάνετε κλικ στο στοιχείο του μενού "Σκελετοί"
		}
		private void Lenses_Click(object sender, RoutedEventArgs e)
		{
			// Ο κώδικας εδώ θα εκτελεστεί όταν κάνετε κλικ στο στοιχείο του μενού "Σκελετοί"
		}
		private void ContactLenses_Click(object sender, RoutedEventArgs e)
		{
			// Ο κώδικας εδώ θα εκτελεστεί όταν κάνετε κλικ στο στοιχείο του μενού "Σκελετοί"
		}
		private void LensCleaners_Click(object sender, RoutedEventArgs e)
		{
			// Ο κώδικας εδώ θα εκτελεστεί όταν κάνετε κλικ στο στοιχείο του μενού "Σκελετοί"
		}
		private void OtherProducts_Click(object sender, RoutedEventArgs e)
		{
			// Ο κώδικας εδώ θα εκτελεστεί όταν κάνετε κλικ στο στοιχείο του μενού "Σκελετοί"
		}
		private void Brands_Click(object sender, RoutedEventArgs e)
		{
			// Ο κώδικας εδώ θα εκτελεστεί όταν κάνετε κλικ στο στοιχείο του μενού "Σκελετοί"
		}
	

		

	}
}
