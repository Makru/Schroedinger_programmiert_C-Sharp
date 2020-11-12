using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD;

namespace TDDTests {
	[TestClass]
	public class DriveValidatorTests {
		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void ValidatePersonNull() {
			DriveValidator validator = new DriveValidator();
			validator.IsDriveAllowed(null);
		}

		[TestMethod]
		public void ValidateDriverLicense() {
			DriveValidator validator = new DriveValidator();
			Person schroedinger = new Person();
			schroedinger.HasDrivingLicense = true;
			bool result = validator.IsDriveAllowed(schroedinger);
			Assert.IsTrue(result);
			schroedinger.HasDrivingLicense = false;
			result = validator.IsDriveAllowed(schroedinger);
			Assert.IsFalse(result);
		}
	}
}
