class Board {
    private List<List<Piece>> _board = new List<List<Piece>>();

    // how other classes will access the actual board.
    public Piece this[int x, int y] {
        get {return _board[x][y];}
        set {_board[x][y] = value;}
    }

    private int _width;
    public int width {get => _width;}
    private int _height;
    public int height {get => _height;}

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

    // displays the board (what else)
    public void ConsoleDisplay() {
        for (int i = 0; i < _height; i++) {
            Console.WriteLine("+" + string.Concat(Enumerable.Repeat("---+", _width)));
            Console.Write("|");
            for (int k = 0; k < _width; k++) {
                Console.Write($" {_board[k][i].Display()} |");
            }
            Console.WriteLine();
        }
        Console.WriteLine("+" + string.Concat(Enumerable.Repeat("---+", _width)));
    }
}