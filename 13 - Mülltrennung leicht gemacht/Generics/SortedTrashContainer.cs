namespace Generics {
	using System;
	using System.Collections.Generic;

	public class SortedTrashContainer<T> : IEnumerable<T> where T : IComparable<T> {
		T[] trash;
		int idx = 0;
		public SortedTrashContainer(int size) {
			this.trash = new T[size];
		}

		public void Push(T item) {
			// Insert sorted
			int insertIndex = 0;
			for (int i = this.idx - 1; i >= 0; i--)
				if (this.trash[i].CompareTo(item) > 0)
					this.trash[i + 1] = this.trash[i];
				else {
					insertIndex = i + 1;
					break;
				}
			this.trash[insertIndex] = item;
			this.idx++;
		}

		public T Pop() {
			this.idx--;
			return this.trash[this.idx];
		}

		public IEnumerator<T> GetEnumerator() {
			return ((IEnumerable<T>)trash).GetEnumerator();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
			return trash.GetEnumerator();
		}
	}
}
