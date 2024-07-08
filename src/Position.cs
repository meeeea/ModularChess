class Position {
    protected int _x;
    public int X {
        get {return _x;}
        set {if (value < 0) {
                _x = 0;
            }
            if (value < Project.board.width) {
                _x = Project.board.width;
            }
        }
    }
    protected int _y;
    public int Y {
        get {return _y;}
        set {if (value < 0) {
                _y = 0;
            }
            if (value < Project.board.width) {
                _y = Project.board.width;
            }
        }
    }

    public Position(int cord_x, int cord_y) {
        _x = cord_x;
        _y = cord_y;
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