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

namespace AlarmV2
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public Alarm a = new Alarm();
		public Alarm a2 = new Alarm();

		public Civil civ1;
		public Civil civ2;
		public Civil civ3;
		public Vatrogasac vat1;

		public MainWindow()
		{
			civ1 = new Civil(a);
			civ2 = new Civil(a);
			civ3 = new Civil(a);
			vat1 = new Vatrogasac(a);
			a2.Tip = "Zemljotres";
			a2.USlucajuPozara += vat1.Reakcija;

			Resources.Add("c1", civ1);
			Resources.Add("c2", civ2);
			Resources.Add("c3", civ3);
			Resources.Add("v1", vat1);
			InitializeComponent();

			dugme.Click += Zvrrr;
			d2.Click += Zvrrr;

		}

		private void Zvrrr(object sender, RoutedEventArgs e)
		{
			Button b = sender as Button;
			if (b.Name == "dugme")
				a.OglasiSe();
			else
				a2.OglasiSe();
		}
	}
}
