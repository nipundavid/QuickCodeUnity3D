using UnityEngine;

public class Turkey : ITurkeyInterface
{
    public void Fly()
    {
        Debug.Log("I fly like a turkey");
    }

    public void Gobble()
    {
        Debug.Log("This is me gobbling....gobble gobble");
    }
}
