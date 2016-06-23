# Game-Of-Life

https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life

Platform: .net, mono

Example of using


//create a simple collection (location of cells like on chessboard) wide 4-th cell and fill it with square cells


var collection = new ChessBoardCellCollection(4)
    {
        new SquareCell(CellState.Alive), new SquareCell(CellState.Alive), new SquareCell(CellState.Alive), new SquareCell(CellState.Dead),
        new SquareCell(CellState.Dead), new SquareCell(CellState.Dead), new SquareCell(CellState.Dead), new SquareCell(CellState.Alive),
        new SquareCell(CellState.Alive), new SquareCell(CellState.Alive), new SquareCell(CellState.Alive), new SquareCell(CellState.Dead),
        new SquareCell(CellState.Dead), new SquareCell(CellState.Dead), new SquareCell(CellState.Dead), new SquareCell(CellState.Alive),
        new SquareCell(CellState.Alive), new SquareCell(CellState.Alive), new SquareCell(CellState.Alive), new SquareCell(CellState.Alive)
    };


// Create a rectangular field and fill it just only created collection of cells. Set the rules
// to agree with the field will move to the next generation (use SimpleStrategy)


var field = new RectangleField(collection, new SimpleStrategy());

//convert the field into state of the next generation 


field.SwitchToNextState();
