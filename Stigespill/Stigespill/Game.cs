namespace Stigespill
{
    class Game
    {
        private static Game _instance;

        public static Game Instance => _instance ?? (_instance = new Game());
    }
}
