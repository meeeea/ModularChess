using System.Numerics;

class Team {
    private string _team = "";
    public string team {get => _team;}
    private StepVector _forward = new StepVector(0, 0);
    public StepVector forward {get => _forward;}

    private ConsoleColor _color = ConsoleColor.White;
    public ConsoleColor color {get => _color;}

    public Team(string displayName, StepVector front, ConsoleColor color = ConsoleColor.White) {
        _team = displayName;
        _forward = front;
        _color = color;
    }
}