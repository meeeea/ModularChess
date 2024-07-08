class Queen : Piece {
    public Queen(int theTeam) : base("Q", theTeam) {
        _move = "x+,x/";
    }
}