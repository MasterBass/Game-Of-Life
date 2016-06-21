// //===============================================================================
// // gol.core project.
// //
// // CellCollection.cs
// //
// // Parent class for all kind of cell collections.
// // The collection shows how the cells are posted.
// // For example, square cells may be stacked like on chessboard
// // but it also can be posted with displacement. 
// //==============================================================================
// // Created 18.12.2013 by Vasya Suddya.
// //==============================================================================


using System.Collections;
using System.Collections.Generic;

namespace gol.core.Field.Collection
{
	public abstract class CellCollection<T> : IEnumerable<T>
	{
		protected readonly List<T> Items = new List<T>();

		public void Add(T t)
		{
			Items.Add(t);
		}

		public IEnumerator<T> GetEnumerator()
		{
			return ((IEnumerable<T>)Items).GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public abstract IEnumerable<T> Adjoined(int index);

	}
}

