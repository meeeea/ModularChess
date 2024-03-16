class Board {
    private List<List<Piece>> _board = new List<List<Piece>>();

    private int _width;
    private int _height;

    public Piece this[int x, int y] {
        get {return _board[x][y];}
        set {_board[x][y] = value;}
    }

    public Board(int x = 8, int y = 8) {
        _width = x;
        _height = y;
        for (int i = 0; i < x; i++) {
            _board.Add(new List<Piece>());
            for (int k = 0; k < y; k++) {
                _board[i].Add(new Piece("a"));
            }
        }
    }

    public void Display() {
        for (int i = 0; i < _height; i++) {
            Console.WriteLine("+" + string.Concat(Enumerable.Repeat("---+", _width)));
            Console.Write("|");
            for (int k = 0; k < _width; k++) {
                Console.Write($" {_board[i][k].Display()} |");
            }
            Console.WriteLine();
        }
        Console.WriteLine("+" + string.Concat(Enumerable.Repeat("---+", _width)));
    }
}