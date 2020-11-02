using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Events {
public class Bar {
	// Das Ereignis definieren
	public event EventHandler EsWirdEineRundeAusgegeben;
	public event EventHandler<DrinkEventArgs> EsWirdEineRundeAusgegeben2;

	public void RundeAusgeben() {
		if (this.EsWirdEineRundeAusgegeben != null)
			// Das Ereignis auslösen
			this.EsWirdEineRundeAusgegeben(this, EventArgs.Empty);
	}
	public void RundeAusgeben2() {
		if (this.EsWirdEineRundeAusgegeben2 != null)
			this.EsWirdEineRundeAusgegeben2(this, new DrinkEventArgs(DrinkType.Alcoholic));
	}
}
}
