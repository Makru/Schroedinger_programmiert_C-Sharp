namespace Generics {

	public static class ObjectCreator<T> where T : class, new() {
		static T myT = default(T);
		public static T CreateSingleton() {
			if (myT == default(T))
				myT = new T();
			return myT;
		}
	}

	public class MyCreator {
		public static T CreateObject<T>() where T : new() {
			// probably do some logging here... ;-)
			return new T();
		}
	}
}
