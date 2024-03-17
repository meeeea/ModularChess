class Chess : Board {
    private static Dictionary<Position, Piece> boardInitialization = new Dictionary<Position, Piece>();
    private static List<Team> teams = new List<Team>() {new Team("Red", new StepVector(1, 0), ConsoleColor.Red),
                                                new Team("Blue", new StepVector(-1, 0), ConsoleColor.Blue)};
    public Chess() : base(8, 8) {
        AddPieces();
        
        foreach (KeyValuePair<Position, Piece> entry in boardInitialization) {
            this[entry.Key] = entry.Value;
        }
    }

    private void AddPieces() {
        // bishops
        boardInitialization.Add(new Position(0, 0), new Rook(teams[0]));
        boardInitialization.Add(new Position(7, 0), new Rook(teams[0]));
        boardInitialization.Add(new Position(0, 7), new Rook(teams[1]));
        boardInitialization.Add(new Position(7, 7), new Rook(teams[1]));

        // bishop
        boardInitialization.Add(new Position(2, 0), new Bishop(teams[0]));
        boardInitialization.Add(new Position(5, 0), new Bishop(teams[0]));
        boardInitialization.Add(new Position(2, 7), new Bishop(teams[1]));
        boardInitialization.Add(new Position(5, 7), new Bishop(teams[1]));

        // knights
        boardInitialization.Add(new Position(1, 0), new Knight(teams[0]));
        boardInitialization.Add(new Position(6, 0), new Knight(teams[0]));
        boardInitialization.Add(new Position(1, 7), new Knight(teams[1]));
        boardInitialization.Add(new Position(6, 7), new Knight(teams[1]));

        // queens
        boardInitialization.Add(new Position(3, 0), new Queen(teams[0]));
        boardInitialization.Add(new Position(3, 7), new Queen(teams[1]));

        // kings
        boardInitialization.Add(new Position(4, 0), new King(teams[0]));
        boardInitialization.Add(new Position(4, 7), new King(teams[1]));

        // pawn
        boardInitialization.Add(new Position(0, 1), new Pawn(teams[0]));
        boardInitialization.Add(new Position(1, 1), new Pawn(teams[0]));
        boardInitialization.Add(new Position(2, 1), new Pawn(teams[0]));
        boardInitialization.Add(new Position(3, 1), new Pawn(teams[0]));
        boardInitialization.Add(new Position(4, 1), new Pawn(teams[0]));
        boardInitialization.Add(new Position(5, 1), new Pawn(teams[0]));
        boardInitialization.Add(new Position(6, 1), new Pawn(teams[0]));
        boardInitialization.Add(new Position(7, 1), new Pawn(teams[0]));
        boardInitialization.Add(new Position(0, 6), new Pawn(teams[1]));
        boardInitialization.Add(new Position(1, 6), new Pawn(teams[1]));
        boardInitialization.Add(new Position(2, 6), new Pawn(teams[1]));
        boardInitialization.Add(new Position(3, 6), new Pawn(teams[1]));
        boardInitialization.Add(new Position(4, 6), new Pawn(teams[1]));
        boardInitialization.Add(new Position(5, 6), new Pawn(teams[1]));
        boardInitialization.Add(new Position(6, 6), new Pawn(teams[1]));
        boardInitialization.Add(new Position(7, 6), new Pawn(teams[1]));
    }
}