namespace Madelinette.Common
{
    public abstract class GameObject
    {
        public int[] Position { get; set; }

        public abstract char Sprite { get; }

        public abstract void Update();
    }
}
