namespace Chess
{
    public partial class Form1 : Form
    {
        private const int BoardSize = 8;
        private const int SquareSize = 50;
        private readonly Color LightSquareColor = Color.Beige;
        private readonly Color DarkSquareColor = Color.SaddleBrown;

        private readonly char[,] InitialBoard =
        {
            {'♜', '♞', '♝', '♛', '♚', '♝', '♞', '♜'},
            {'♟', '♟', '♟', '♟', '♟', '♟', '♟', '♟'},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {'♙', '♙', '♙', '♙', '♙', '♙', '♙', '♙'},
            {'♖', '♘', '♗', '♕', '♔', '♗', '♘', '♖'}
        };

        public Form1()
        {
            InitializeComponent();
            this.Paint += MainForm_Paint;
        }

        private void MainForm_Paint(object? sender, PaintEventArgs e)
        {
            DrawChessBoard(e.Graphics);
            DrawChessPieces(e.Graphics);
        }

        private void DrawChessBoard(Graphics g)
        {
            for (int row = 0; row < BoardSize; row++)
            {
                for (int col = 0; col < BoardSize; col++)
                {
                    Color squareColor = (row + col) % 2 == 0 ? LightSquareColor : DarkSquareColor;
                    Brush brush = new SolidBrush(squareColor);
                    g.FillRectangle(brush, col * SquareSize, row * SquareSize, SquareSize, SquareSize);
                }
            }
        }

        private void DrawChessPieces(Graphics g)
        {
            for (int row = 0; row < BoardSize; row++)
            {
                for (int col = 0; col < BoardSize; col++)
                {
                    char piece = InitialBoard[row, col];
                    if (piece != ' ')
                    {
                        Brush brush = piece == Char.ToUpper(piece) ? Brushes.Black : Brushes.White;
                        Font font = new Font("Arial", 24, FontStyle.Regular);
                        g.DrawString(piece.ToString(), font, brush, col * SquareSize - 10, row * SquareSize);
                    }
                }
            }
        }
    }




}









