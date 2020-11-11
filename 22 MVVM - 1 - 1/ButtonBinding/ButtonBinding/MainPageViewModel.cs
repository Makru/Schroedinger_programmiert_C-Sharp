using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButtonBinding {
	public class MainPageViewModel : ModelBase {
		string message;
		public string Message {
			get { return message; }
			set {
				if (this.message != value) {
					this.message = value;
					this.OnPropertyChanged();
				}
			}
		}

		string text;
		public string Text {
			get { return this.text; }
			set {
				if (this.text != value) {
					this.text = value;
					this.OnPropertyChanged();
					this.SayHelloCommand.RaiseCanExecuteChanged();
				}
			}
		}

		public MainPageViewModel() {
			this.SayHelloCommand = new DelegateCommand<string>(
				(s) => this.Message = string.Format("Hallo {0}", this.Text),
				(s) => !String.IsNullOrEmpty(this.Text)
				);
		}
		public DelegateCommand<string> SayHelloCommand { get; set; }
	}
}
