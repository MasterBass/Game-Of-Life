// //===============================================================================
// // gol.core project.
// //
// // SquareCellCollection.cs
// //
// // Square cells collection.
// // Implement a simple collection of square cells without bias, like
// // Chessboard
// //==============================================================================
// // Created 18.12.2013 by Vasya Suddya.
// //==============================================================================


using System.Collections.Generic;
using gol.core.Field.Collection.Cell;

namespace gol.core.Field.Collection
{
	public class ChessBoardCellCollection : CellCollection<CellBase>
	{
		private readonly int _width;
		public ChessBoardCellCollection(int width)
		{
			_width = width;
		}

		public override IEnumerable<CellBase> Adjoined(int index)
		{
			if (index % _width != 0)
			{
				yield return Items[index - 1];
			}

			if ((index + 1) % _width != 0 && index + 1 < Items.Count)
			{
				yield return Items[index + 1];
			}

			if (index >= _width)
			{
				yield return Items[index - _width];
			}

			if (index >= _width && (index + 1) % _width != 0 && index + 1 < Items.Count)
			{
				yield return Items[index - _width + 1];
			}

			if (index >= _width && index % _width != 0)
			{
				yield return Items[index - _width - 1];
			}

			if (index < Items.Count - _width)
			{
				yield return Items[index + _width];
			}

			if (index < Items.Count - _width && (index + 1) % _width != 0)
			{
				yield return Items[index + _width + 1];
			}

			if (index < Items.Count - _width && index % _width != 0)
			{
				yield return Items[index + _width - 1];
			}


		}
	}
}
