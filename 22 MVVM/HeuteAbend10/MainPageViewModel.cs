using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeuteAbend10 {
	public class MainPageViewModel : ModelBase {
		Random rnd = new Random(DateTime.Now.Millisecond);
		string text;

		public string Text {
			get { return text; }
			set {
				if (text != value) {
					text = value;
					this.OnPropertyChanged();
				}
			}
		}

		public MainPageViewModel() {
			this.Spielen = new DelegateCommand<string>(
					(prob) => Evaluate(int.Parse(prob), "Heute wird WoW gespielt!", "Nein, mit dem spielen wird es heute nichts."),
					(prob) => CheckCanExecute(prob)
				);
			this.Freundin = new DelegateCommand<string>(
				(prob) => Evaluate(int.Parse(prob), "Freundin sucht aus!", "Ich überleg nochmal"),
				CheckCanExecute
				);
			this.Fortgehen = new DelegateCommand<string>(
				(prob) => Evaluate(int.Parse(prob), "Wir gehen aus!", "Nein, ausgehen wird nichts."),
				null
			);
		}

		public DelegateCommand<string> Freundin { get; set; }
		public DelegateCommand<string> Fortgehen { get; set; }
		public DelegateCommand<string> Spielen { get; set; }

		bool CheckCanExecute(string prob) {
			return true;
		}

		void Evaluate(int probability, string okText, string nOkText) {
			int rndNumber = rnd.Next(1, probability + 1);
			if (rndNumber == probability)
				this.Text = okText;
			else
				this.Text = nOkText;

			this.Freundin.RaiseCanExecuteChanged();
			this.Fortgehen.RaiseCanExecuteChanged();
			this.Spielen.RaiseCanExecuteChanged();
		}
	}
}
