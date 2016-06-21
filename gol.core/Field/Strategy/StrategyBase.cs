// //===============================================================================
// // gol.core project.
// //
// // Strategy.cs
// //
// // Parent class for all type of strategy.
// // Strategy. The rules according to whth we will determine what state
// // Will have the cell in the next generation.
// //==============================================================================
// // Created 18.12.2013 by Vasya Suddya.
// //==============================================================================


using System.Collections.Generic;
using gol.core.Field.Collection.Cell;

namespace gol.core.Field.Strategy
{
	public abstract class StrategyBase
	{
		public abstract CellState GetNewState(IEnumerable<CellBase> adjoinedCells, CellState currentState);
	}
}
