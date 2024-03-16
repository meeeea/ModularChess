class Piece {
    // what is display's as. still not sure how this is going to work.
    protected string _displayName = "";

    // move will be described as in Betza's funny notation for fairy chess.
    protected string _move = "";
    public string move {get => _move;}

    // i intend on adding support for help info to say what a piece does.
    protected string _helpInfo = "";

    protected Team _team;
    public Team team {get => _team;}

    public Piece(string name, Team theTeam) {
        _displayName = name;
        _team = theTeam;
    }

    protected Piece() {
        
    }

    public void Display() {
        Console.ForegroundColor = _team.color;
        Console.Write(_displayName);
        Console.ForegroundColor = ConsoleColor.White;
    }
}