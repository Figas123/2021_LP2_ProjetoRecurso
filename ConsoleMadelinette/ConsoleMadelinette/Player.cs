namespace ConsoleMadelinette
{
    class Player : GameObject
    {
        public override char Sprite { get; }
        private int[] limits;

        public Player(char sprite, int x, int y)
        {
            Sprite = sprite;
            this.limits = new int[] { x, y };
        }
        public override void Update()
        {

        }
    }
}
