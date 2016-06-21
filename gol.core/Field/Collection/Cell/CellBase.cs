// //===============================================================================
// // gol.core project.
// //
// // Cell.cs
// //
// // Parent class for all type of cells.
// //==============================================================================
// // Created 18.12.2013 by Vasya Suddya.
// //==============================================================================


namespace gol.core.Field.Collection.Cell
{
	public abstract class CellBase
	{
		public CellState CurentState { get; set; }
		public CellState CalculatedState { get; set; }

		protected CellBase(CellState state)
		{
			CurentState = state;
		}

		public void SwitchToCalculatedState()
		{
			CurentState = CalculatedState;
		}

	}
}

