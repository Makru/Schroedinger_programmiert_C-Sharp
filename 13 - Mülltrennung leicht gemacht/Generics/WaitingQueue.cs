namespace Generics {
	public class WaitingQueue<T> {
		T[] list;
		int idx = 0;

		public WaitingQueue(int size) {
			this.list = new T[size];
		}

		public void Push(T item) {
			this.list[this.idx] = item;
			this.idx++;
		}

		public T Pop() {
			this.idx--;
			T result = this.list[0];
			// Move all to the left.
			for (int i = 0; i <= this.idx; i++)
				this.list[i] = this.list[i + 1];
			return result;
		}

		public void Clear() {
			this.idx = 0;
			this.list = new T[this.list.Length];
		}
	}
}
