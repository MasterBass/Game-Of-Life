// //===============================================================================
// // gol.core project.
// //
// // RectangleField.cs
// //
// // The simpliest kind of field (rectangle)
// //==============================================================================
// // Created 18.12.2013 by Vasya Suddya.
// //==============================================================================


using gol.core.Field.Collection;
using gol.core.Field.Collection.Cell;
using gol.core.Field.Strategy;

namespace gol.core.Field
{
	public class RectangleField : FieldBase
	{
		public RectangleField(CellCollection<CellBase> cells, StrategyBase strategy) : base(cells, strategy)
		{
		}
	}
}