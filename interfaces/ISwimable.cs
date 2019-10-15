namespace DiggersAndFliers
{
    public interface ISwimable
    {
        int MaximumDepth { get; set; }

        void Swim();
    }
}