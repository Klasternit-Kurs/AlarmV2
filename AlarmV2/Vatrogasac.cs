using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmV2
{
	public class Vatrogasac : INotifyPropertyChanged
	{
		public Vatrogasac(Alarm a)
		{
			a.USlucajuPozara += Reakcija;
		}

		private string status = "Kuliram";
		public string Status
		{
			get => status;
			set
			{
				status = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Status"));
			}
		}

		public void Reakcija(Alarm koZvoni)
		{
			Status = koZvoni.Tip;
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
