public class MallardDuck : Duck
{
   public MallardDuck()
    {
        flyBehaviour = new FlyWIthWIngs();
        quackBehaviour = new Squeak();
    }
}
