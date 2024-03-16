using System.Numerics;

class Team {
    private string _team = "";
    public string team {get => _team;}
    private StepVector _forward = new StepVector(0, 0);
    public StepVector forward {get => _forward;}

    public Team(string displayName, StepVector front) {
        _team = displayName;
        _forward = front;
    }
}