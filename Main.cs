using System.Text.RegularExpressions;

class Project {
    public static Board board = new Chess();

    public static void Main() {
        RunGame();
    }

    public static void RunGame() {
        while (true) {
            for (int i = 0; i < board.Teams.Count; i++) {
                Turn(i);
            }
        }
    }

    public static void Turn(int team) {
        board.ConsoleDisplay();
        Console.ForegroundColor = board.Teams[team].color;
        Console.WriteLine($"{board.Teams[team].team}'s turn");
        Console.ForegroundColor = ConsoleColor.White;
        Position targetPiece = SelectPiece(team);
    }

    public static Position SelectPiece(int team) {
        while (true) {
            Console.Write("Select Piece: ");
            string piecePos = Console.ReadLine();
            Position position = new Position(piecePos);
            if (position.X == -1) {
                continue;
            }
            if (team != board[position].team) {
                Console.WriteLine($"{team}, {board[position].team}");
                continue;
            }
            Console.WriteLine($"piece selected {board[position].displayName}");
            return position;
        }
    }
}