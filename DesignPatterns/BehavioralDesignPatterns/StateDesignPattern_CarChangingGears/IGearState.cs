namespace StateDesignPattern_CarChangingGears
{
    public interface IGearState
    {
        void ChangeGear();
        void Accelarate(int speed);
    }
}
