using System.Text.RegularExpressions;

class Project {
    public static Board board = new Chess();

    public static void Main() {
        //RunGame();
        new MoveOptions(board, new Position(4, 2));
    }

    public static void RunGame() {
        board.ConsoleDisplay();
        while (true) {
            for (int i = 0; i < board.Teams.Count; i++) {
                Turn(i);
            }
        }
    }

    public static void Turn(int team) {
        board.ConsoleDisplay();
        
    }
}