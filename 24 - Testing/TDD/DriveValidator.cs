using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD {
	public class DriveValidator {
		public bool IsDriveAllowed(Person person) {
			if (person == null)
				throw new ArgumentNullException("person");
			bool isAllowed = person.HasDrivingLicense;
			return isAllowed;
		}
	}
}
