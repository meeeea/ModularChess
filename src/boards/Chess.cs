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
        boardInitialization.Add(new Position(0, 0), new Rook(teams[0]));
        boardInitialization.Add(new Position(7, 0), new Rook(teams[0]));
        boardInitialization.Add(new Position(0, 7), new Rook(teams[1]));
        boardInitialization.Add(new Position(7, 7), new Rook(teams[1]));
    }
}