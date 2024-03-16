class Empty : Piece {

    public Empty() {
        _displayName = " ";
        _move = "";
        _team = new Team(" ", new StepVector(0, 0));
    }
}