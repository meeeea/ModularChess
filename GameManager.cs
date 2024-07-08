class GameManager {
    public static Board _board;
    public static Board Board => _board;
    
    public static void RunGame(Board board) {
        _board = board;
        while (true) {
            foreach (Team team in _board.Teams) {
                Turn(team);
            }
        }
    }

    public static void Turn(Team team) {
        _board.ConsoleDisplay();
    }
}