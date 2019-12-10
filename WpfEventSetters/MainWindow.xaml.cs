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

namespace WpfEventSetters
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

		private void ChangeValue_OnEnter(object sender, RoutedEventArgs e)
		{
			Button btn = (Button)sender;
			int value;
			if (int.TryParse((string)btn.Content, out value)){ //out value . out keyword allow to null value for value type variables
					value++;
					btn.Content=value.ToString();
				}
				}

		

		
	}
				}






