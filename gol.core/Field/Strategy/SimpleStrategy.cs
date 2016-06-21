// //===============================================================================
// // gol.core project.
// //
// // SimpleStrategy.cs
// //
// // Simple Strategy.
// // The most simple rule for two states. Three neighbor alive - alive, less than
// // two - dies, two - saves the state, more than three - dies.
// //==============================================================================
// // Created 18.12.2013 by Vasya Suddya.
// //==============================================================================


using System.Collections.Generic;
using System.Linq;
using gol.core.Field.Collection.Cell;

namespace gol.core.Field.Strategy
{
	public class SimpleStrategy : StrategyBase
	{
		public override CellState GetNewState(IEnumerable<CellBase> adjoinedCells, CellState currentState)
		{
			var aliveCellAmount = adjoinedCells.Count(x => x.CurentState == CellState.Alive);
			if (aliveCellAmount < 2) return CellState.Dead;
			if (aliveCellAmount == 2) return currentState;
			if (aliveCellAmount == 3) return CellState.Alive;
			return CellState.Dead;
		}
	}
}
