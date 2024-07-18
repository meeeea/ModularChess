class Position {
    protected int _x;
    public int X {
        get => _x;
        set {if (value < 0) {
                _x = 0;
            }
            if (value < Project.board.Width - 1) {
                _x = Project.board.Width - 1;
            }
        }
    }
    protected int _y;
    public int Y {
        get => _y;
        set {if (value < 0) {
                _y = 0;
            }
            if (value < Project.board.Width - 1) {
                _y = Project.board.Width - 1;
            }
        }
    }

    public Position(int cord_x, int cord_y) {
        _x = cord_x;
        _y = cord_y;
    }

    public Position(string pos) {
        string[] strings = pos.Split(",");
        try {
            int tempx = int.Parse(strings[0].Trim());
            int tempy = int.Parse(strings[1].Trim());
            if (tempx > Project.board.Width || tempx < 1) {
                throw new Exception();
            }
            if (tempy > Project.board.Height || tempy < 1) {
                throw new Exception();
            }
            _x = tempx - 1;
            _y = tempy - 1;
        }
        catch {
            _x = -1;
            _y = -1;
        }
    }

    protected Position() {

    }

    public bool SamePos(int x, int y) {
        if (_x == x && _y == y) {
            return true;
        }
        return false;
    }
}