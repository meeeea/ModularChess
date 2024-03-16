class Board {
    private List<List<Piece>> _board = new List<List<Piece>>();

    public Piece this[int x, int y] {
        get {return _board[x][y];}
        set {_board[x][y] = value;}
    }

    public Board(int x = 8, int y = 8) {
        for (int i = 0; i < x; i++) {
            _board.Add(new List<Piece>());
            for (int k = 0; k < y; k++) {
                _board[i].Add(new Piece());
            }
        }
    }
}