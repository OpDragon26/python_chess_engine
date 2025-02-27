namespace Piece
{

    public enum PieceType
    {
        Empty,
        Pawn,
        Knight,
        Bishop,
        Rook,
        Queen,
        King
    }

    public class Piece
    {
        public PieceType Role = PieceType.Empty;
        public bool Color = false; // false = white (or empty), true = black
        public int Value = 0;
        public int LocalValue = 0;

        static Dictionary<PieceType, int> Values = new Dictionary<PieceType, int>{
            {PieceType.Pawn, 1},
            {PieceType.Rook, 5},
            {PieceType.Knight, 3},
            {PieceType.Bishop, 3},
            {PieceType.Queen, 9},
            {PieceType.King, 0},
            {PieceType.Empty, 0},
        };

        static Dictionary<bool, int> Multipliers = new Dictionary<bool, int>{
            {false, 1},
            {true, -1},
        };

        public static Piece Constructor(PieceType role, bool color)
        {
            Piece NewPiece = new Piece();

            NewPiece.Color = color;
            NewPiece.Role = role;
            NewPiece.LocalValue = Values[role];
            NewPiece.Value = Values[role] * 100;
            if (role == PieceType.King)
            {
                NewPiece.Value = 1000;
            }
            NewPiece.Value *= Multipliers[color];

            return NewPiece;
        }

    }

    public static class Presets
    {
        public static Piece Empty = Piece.Constructor(PieceType.Empty, false);
        public static Piece W_Pawn = Piece.Constructor(PieceType.Pawn, false);
        public static Piece W_Rook = Piece.Constructor(PieceType.Rook, false);
        public static Piece W_Knight = Piece.Constructor(PieceType.Knight, false);
        public static Piece W_Bishop = Piece.Constructor(PieceType.Bishop, false);
        public static Piece W_Queen = Piece.Constructor(PieceType.Queen, false);
        public static Piece W_King = Piece.Constructor(PieceType.King, false);
        public static Piece B_Pawn = Piece.Constructor(PieceType.Pawn, true);
        public static Piece B_Rook = Piece.Constructor(PieceType.Rook, true);
        public static Piece B_Knight = Piece.Constructor(PieceType.Knight, true);
        public static Piece B_Bishop = Piece.Constructor(PieceType.Bishop, true);
        public static Piece B_Queen = Piece.Constructor(PieceType.Queen, true);
        public static Piece B_King = Piece.Constructor(PieceType.King, true);

        public static Dictionary<Piece, string> PieceString = new Dictionary<Piece, string>{
            {Empty, " "},
            {W_Pawn, "♟"},
            {W_Rook, "♜"},
            {W_Knight, "♞"},
            {W_Bishop, "♝"},
            {W_Queen, "♛"},
            {W_King, "♚"},
            {B_Pawn, "♙"},
            {B_Rook, "♖"},
            {B_Knight, "♘"},
            {B_Bishop, "♗"},
            {B_Queen, "♕"},
            {B_King, "♔"},
        };

        public static Dictionary<Piece, Piece> Clone = new Dictionary<Piece, Piece>{
            {Empty, Empty},
            {W_Pawn, W_Pawn},
            {W_Rook, W_Rook},
            {W_Knight, W_Knight},
            {W_Bishop, W_Bishop},
            {W_Queen, W_Queen},
            {W_King, W_King},
            {B_Pawn, B_Pawn},
            {B_Rook, B_Rook},
            {B_Knight, B_Knight},
            {B_Bishop, B_Bishop},
            {B_Queen, B_Queen},
            {B_King, B_King},
        };
    }
}