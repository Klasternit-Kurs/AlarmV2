using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmV2
{
	public class Alarm
	{
		public delegate void AlarmDelegat();

		public event AlarmDelegat USlucajuPozara;

		public void OglasiSe()
		{
			USlucajuPozara?.Invoke();
		}
	}
}
