namespace Stigespill
{
    class BoardCell
    {
        public Player[] Player;

        public BoardCell()
        {
            Player = new Player[4];
            for (int i = 0; i < Player.Length; i++)
            {
                Player[i] = new Player();
            }

            for (int i = 0; i < Player.Length; i++)
            {
                Player[i].SetSymbol(i);
            }
        }

        public void MovePlayer(int playerNumber, bool moveToCell)
        {
            Player[1].PlayerPos += 1;
        }

        public char CheckContent(int playerNumber, int cellIndex)
        {
            if (Player[playerNumber - 1].PlayerPos == cellIndex) return Player[playerNumber - 1].PlayerSymbol;
            return ' ';
        }
    }
}
