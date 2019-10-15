namespace DiggersAndFliers
{
    public interface IGroundable
    {
        int NumLegs { get; set; }
        void MoveOnGround();
    }
}