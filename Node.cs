using System.Collections;
using Board;

namespace Node
{
    public class Node
    {
        public Board.Board board = new Board.Board();
        public Node[] ChildNodes = new Node[] {};
        public int Eval;

        public Node(Board.Board newBoard)
        {
            board = newBoard;
        }

        public void GenerateChildren()
        {
            ArrayList NodeList = new ArrayList();

            Move.Move[] MoveList = MoveFinder.Search(board, board.Side);

            for (int i = 0; i < MoveList.Length; i++)
            {
                Board.Board MoveBoard = board.DeepCopy();
                MoveBoard.MakeMove(MoveList[i], false);

                NodeList.Add(new Node(MoveBoard));
            }

            this.ChildNodes = (Node[])NodeList.ToArray(typeof(Node));
        }
    }    
}