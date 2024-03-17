class Pawn : Piece {
    public Pawn(Team theTeam) : base("P", theTeam) {
        _move = "1+fm,2+fmj,1/fc";
    }
}