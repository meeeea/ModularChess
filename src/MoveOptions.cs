using System.Text.RegularExpressions;

partial class MoveOptions {
    private List<List<int>> ints = new();

    public int this[int x, int y] => ints[x][y];

    public int this[Position position] {
        get => ints[position.X][position.Y];
        set {ints[position.X][position.Y] = value;}
        }


    public MoveOptions(Board board, Position piecePos) {
        for (int i = 0; i < board.Width; i++) {
            ints.Add(new());
            for (int k = 0; k < board.Height; k++) {
                ints[i].Add(0);
            }
        }
        SeparateMoves(board[piecePos].move);
    }

    private static List<Position> SeparateMoves(string movePattern) {
        MatchCollection matches = Seporator().Matches(movePattern);
        List<Position> positions = new();
        foreach (Match match in matches) {
            foreach (Position position in DecodeMoveGeneral(match.Value.Trim(','))) {
                positions.Add(position);
            }
        }
        return positions;
    }

    private static List<Position> DecodeMoveGeneral(string movePattern) {
        return new();
    }

    [GeneratedRegex("(,|^)[^,\\[]*(?=(,|$))|\\[.*\\]")]
    private static partial Regex Seporator();
}