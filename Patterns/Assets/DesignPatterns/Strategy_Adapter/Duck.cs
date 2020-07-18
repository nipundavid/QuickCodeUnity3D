public abstract class Duck 
{
    public IFlyBehaviour flyBehaviour;
    public IQuackBehaviour quackBehaviour;

    public Duck()
    {
    }

    public virtual void PerformFly()
    {
        flyBehaviour.Fly();
    }

    public virtual void PerformQuack()
    {
        quackBehaviour.Quack();
    }
}
