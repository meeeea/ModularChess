class Piece {
    // what is display's as. still not sure how this is going to work.
    protected string _displayName = "";

    // move will be described as in Betza's funny notation for fairy chess.
    protected string _move = "";
    public string move {get => _move;}

    // i intend on adding support for help info to say what a piece does.
    protected string _helpInfo = "";

    protected int _teamID;
    public int team {get => _teamID;}

    public Piece(string name, int theTeam) {
        _displayName = name;
        _teamID = theTeam;
    }

    protected Piece() {
        
    }

    public void Display() {
        if (team == -1) {
            Console.Write(_displayName);
        }
        else {
            Console.ForegroundColor = Project.board.Teams[team].color;
            Console.Write(_displayName);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}