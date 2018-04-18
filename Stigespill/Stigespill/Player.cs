namespace Stigespill
{
    public class Player
    {
        public char PlayerSymbol;
        public int PlayerPos;

        public Player()
        {
            PlayerPos = 0;
        }

        public void SetSymbol(int i)
        {
            if (i == 0) PlayerSymbol = '♥';
            if (i == 1) PlayerSymbol = '♠';
            if (i == 2) PlayerSymbol = '♦';
            if (i == 3) PlayerSymbol = '♣';
        }
    }
}
