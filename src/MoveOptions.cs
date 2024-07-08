class MoveOptions {
    private List<List<int>> ints = new();

    public int this[int x, int y] => ints[x][y];

    public MoveOptions(int BoardWidth, int BoardHeight, Position PiecePos, string MovePattern) {
        for (int i = 0; i < BoardWidth; i++) {
            ints.Add(new());
            for (int k = 0; k < BoardHeight; k++) {
                ints[i].Add(0);
            }
        }
    }
}