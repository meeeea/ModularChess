class Queen : Piece {
    public Queen(Team theTeam) : base("Q", theTeam) {
        _move = "x+,x/";
    }
}