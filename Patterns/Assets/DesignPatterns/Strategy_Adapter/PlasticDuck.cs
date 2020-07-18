public class PlasticDuck : Duck
{
    public PlasticDuck()
    {
        flyBehaviour = new CannotFly();
        quackBehaviour = new MuteSqueak();
    }
}
