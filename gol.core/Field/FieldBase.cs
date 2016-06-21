// //===============================================================================
// // gol.core project.
// //
// // Field.cs
// //
// // Parent class for all type of fields.
// //==============================================================================
// // Created 18.12.2013 by Vasya Suddya.
// //==============================================================================


using System.Linq;
using gol.core.Field.Collection;
using gol.core.Field.Collection.Cell;
using gol.core.Field.Strategy;

namespace gol.core.Field
{
	public abstract class FieldBase
	{
		public CellCollection<CellBase> CellCollection { get; set; }
		private readonly StrategyBase _strategy;

		protected FieldBase(CellCollection<CellBase> cells, StrategyBase strategy)
		{
			CellCollection = cells;
			_strategy = strategy;
		}

		public void SwitchToNextState()
		{
			for (int i = 0; i < CellCollection.Count(); i++)
			{
				CellCollection.ElementAt(i).CalculatedState =
					_strategy.GetNewState(CellCollection.Adjoined(i), CellCollection.ElementAt(i).CurentState);
			}

			foreach (var cell in CellCollection)
			{
				cell.SwitchToCalculatedState();
			}

		}
	}
}
