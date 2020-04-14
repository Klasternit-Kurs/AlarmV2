using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmV2
{
	public class Alarm
	{
		public string Tip { get; set; } = "Pozarni";
		public delegate void AlarmDelegat(Alarm koZvoni);

		public event AlarmDelegat USlucajuPozara;

		public void OglasiSe()
		{
			//if (USlucajuPozara != null)
			//{
			//	USlucajuPozara();
			//} isto kao ovo dole :) 

			USlucajuPozara?.Invoke(this);
		}


	}
}
