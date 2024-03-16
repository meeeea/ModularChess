class Piece {
    private string _displayName = "";

    public Piece(string name = "") {
        _displayName = name;
    }

    public string Display() {
        return _displayName;
    }
}