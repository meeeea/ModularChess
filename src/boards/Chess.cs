class Chess : Board {
    private static Dictionary<Position, Piece> boardInitialization = new Dictionary<Position, Piece>();
    private static List<Team> teams = new List<Team>() {new Team("W", new StepVector(1, 0)),
                                                new Team("B", new StepVector(-1, 0))};
    public Chess() : base(8, 8) {
        boardInitialization.Add(new Position(0, 0), new Rook(teams[0]));
        boardInitialization.Add(new Position(7, 0), new Rook(teams[0]));

        foreach (KeyValuePair<Position, Piece> entry in boardInitialization) {
            this[entry.Key] = entry.Value;
        }
    }
}