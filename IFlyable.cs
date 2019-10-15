namespace DiggersAndFliers
{
    public interface IFlyable
    {
        int MaxSpeed { get; set; }
        void Fly();
    }
}