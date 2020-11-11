using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ButtonBinding10 {
	public class DelegateCommand<T> : ICommand {
		Predicate<T> canExecuteHdl { get; set; }
		Action<T> executeHdl { get; set; }

		public DelegateCommand(Action<T> executeHdl, Predicate<T> canExecuteHdl) {
			this.canExecuteHdl = canExecuteHdl;
			if (executeHdl == null)
				throw new ArgumentNullException("executeHdl", "Please specifiy the command.");
			this.executeHdl = executeHdl;
		}

		public void RaiseCanExecuteChanged() {
			if (this.CanExecuteChanged != null)
				this.CanExecuteChanged(this, null);
		}

		public bool CanExecute(object parameter) {
			return canExecuteHdl == null || canExecuteHdl((T)parameter) == true;
		}

		public event EventHandler CanExecuteChanged;

		public void Execute(object parameter) {
			executeHdl((T)parameter);
		}
	}
}
