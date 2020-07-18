using UnityEngine;
public class CannotFly : IFlyBehaviour
{
    public void Fly()
    {
        Debug.Log("I cannot fly");
    }
}
