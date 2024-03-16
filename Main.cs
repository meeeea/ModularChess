class Project {
    public static Board board = new Board(3,5);

    public static void Main() {
        board[0, 0] = new Piece("b");
        board.ConsoleDisplay();
        Console.WriteLine(board.width);
        Console.WriteLine(board.height);
    }
}