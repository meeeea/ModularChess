abstract class Board {
    protected List<List<Piece>> _board = new List<List<Piece>>();

    public abstract List<Team> Teams {
        get;
    }

    // how other classes will access the actual board.
    public Piece this[int x, int y] {
        get {return _board[x][y];}
        set {_board[x][y] = value;}
    }

    public Piece this[Position position] {
        get {return _board[position.X][position.Y];}
        set {_board[position.X][position.Y] = value;}
    }

    protected int _width;
    public int Width {get => _width;}
    protected int _height;
    public int Height {get => _height;}

    public Board(int x = 8, int y = 8) {
        _width = x;
        _height = y;
        for (int i = 0; i < x; i++) {
            _board.Add(new List<Piece>());
            for (int k = 0; k < y; k++) {
                _board[i].Add(new Empty());
            }
        }
    }

    public void Move(int[] first, int[] second) {
        _board[second[0]][second[1]] = _board[first[0]][first[1]];
        _board[first[0]][first[1]] = new Empty();
    }

    // displays the board (what else)
    public void ConsoleDisplay() {
        Console.WriteLine("+" + string.Concat(Enumerable.Repeat("---+", _width + 2)));
        Console.Write("|   |");
        for (int i = 0; i < _width; i++) {
            Console.Write($" {i + 1} |");
        }
        Console.WriteLine("   |");
        for (int i = _height - 1; i >= 0; i--) {
            Console.WriteLine("+" + string.Concat(Enumerable.Repeat("---+", _width + 2)));
            Console.Write($"| {i + 1} | ");
            for (int k = 0; k < _width; k++) {
                _board[k][i].Display();
                Console.Write(" | ");
            }
            Console.WriteLine($"{i + 1} |");
        }
        Console.WriteLine("+" + string.Concat(Enumerable.Repeat("---+", _width + 2)));
        Console.Write("|   |");
        for (int i = 0; i < _width; i++) {
            Console.Write($" {i + 1} |");
        }
        Console.WriteLine("   |");
        Console.WriteLine("+" + string.Concat(Enumerable.Repeat("---+", _width + 2)));
    }

    public void ConsoleDisplay(MoveOptions moveOptions) {
        for (int i = _height - 1; i >= 0; i--) {
            Console.WriteLine("+" + string.Concat(Enumerable.Repeat("---+", _width)));
            Console.Write("|");
            for (int k = 0; k < _width; k++) {
                int move = moveOptions[i, k];
                if (move == 0) {
                    Console.Write(' ');
                    _board[k][i].Display();
                    Console.Write(' ');
                }
                else if (move == 1) {
                    Console.Write('<');
                    _board[k][i].Display();
                    Console.Write('>');
                }
                else if (move == 2) {
                    Console.Write('[');
                    _board[k][i].Display();
                    Console.Write(']');
                }
                Console.Write("|");
            }
            Console.WriteLine();
        }
        Console.WriteLine("+" + string.Concat(Enumerable.Repeat("---+", _width)));
    }
}