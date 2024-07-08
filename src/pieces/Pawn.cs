class Pawn : Piece {
    public Pawn(int theTeam) : base("P", theTeam) {
        _move = "1+fm,2+fmj,1/fc";
    }
}