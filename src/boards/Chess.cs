class Chess : Board {
    private static Dictionary<Position, Piece> BoardInitialization = new Dictionary<Position, Piece>();
    public new List<Team> Teams = new List<Team>() {new Team("Red", new StepVector(1, 0), ConsoleColor.Red),
                                                new Team("Blue", new StepVector(-1, 0), ConsoleColor.Blue)};
    public Chess() : base(8, 8) {
        SetDefaultPieces();
        
        foreach (KeyValuePair<Position, Piece> entry in BoardInitialization) {
            this[entry.Key] = entry.Value;
        }
    }

    private void SetDefaultPieces() {
        // bishops
        BoardInitialization.Add(new Position(0, 0), new Rook(0));
        BoardInitialization.Add(new Position(7, 0), new Rook(0));
        BoardInitialization.Add(new Position(0, 7), new Rook(1));
        BoardInitialization.Add(new Position(7, 7), new Rook(1));

        // bishop
        BoardInitialization.Add(new Position(2, 0), new Bishop(0));
        BoardInitialization.Add(new Position(5, 0), new Bishop(0));
        BoardInitialization.Add(new Position(2, 7), new Bishop(1));
        BoardInitialization.Add(new Position(5, 7), new Bishop(1));

        // knights
        BoardInitialization.Add(new Position(1, 0), new Knight(0));
        BoardInitialization.Add(new Position(6, 0), new Knight(0));
        BoardInitialization.Add(new Position(1, 7), new Knight(1));
        BoardInitialization.Add(new Position(6, 7), new Knight(1));

        // queens
        BoardInitialization.Add(new Position(3, 0), new Queen(0));
        BoardInitialization.Add(new Position(3, 7), new Queen(1));

        // kings
        BoardInitialization.Add(new Position(4, 0), new King(0));
        BoardInitialization.Add(new Position(4, 7), new King(1));

        // pawn
        BoardInitialization.Add(new Position(0, 1), new Pawn(0));
        BoardInitialization.Add(new Position(1, 1), new Pawn(0));
        BoardInitialization.Add(new Position(2, 1), new Pawn(0));
        BoardInitialization.Add(new Position(3, 1), new Pawn(0));
        BoardInitialization.Add(new Position(4, 1), new Pawn(0));
        BoardInitialization.Add(new Position(5, 1), new Pawn(0));
        BoardInitialization.Add(new Position(6, 1), new Pawn(0));
        BoardInitialization.Add(new Position(7, 1), new Pawn(0));
        BoardInitialization.Add(new Position(0, 6), new Pawn(1));
        BoardInitialization.Add(new Position(1, 6), new Pawn(1));
        BoardInitialization.Add(new Position(2, 6), new Pawn(1));
        BoardInitialization.Add(new Position(3, 6), new Pawn(1));
        BoardInitialization.Add(new Position(4, 6), new Pawn(1));
        BoardInitialization.Add(new Position(5, 6), new Pawn(1));
        BoardInitialization.Add(new Position(6, 6), new Pawn(1));
        BoardInitialization.Add(new Position(7, 6), new Pawn(1));
    }
}