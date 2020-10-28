namespace Generics {
	public class TrashContainer<T> {
		T[] trash;
		int idx = 0;

		public TrashContainer(int size) {
			this.trash = new T[size];
		}

		public void Push(T item) {
			this.trash[this.idx] = item;
			this.idx++;
		}
		public T Pop() {
			this.idx--;
			return this.trash[this.idx];
		}

		public void Clear() {
			this.idx = 0;
			this.trash = new T[this.trash.Length];
		}
	}
}
