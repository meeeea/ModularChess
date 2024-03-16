class Piece {
    // what is display's as. still not sure how this is going to work.
    private string _displayName = "";

    // move will be described as in Betza's funny notation for fairy chess.
    private string _move = "";
    public string move {get => _move;}

    // i intend on adding support for help info to say what a piece does.
    private string _helpInfo = "";

    public Piece(string name = "") {
        _displayName = name;
    }

    public string Display() {
        return _displayName;
    }
}