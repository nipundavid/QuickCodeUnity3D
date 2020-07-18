using UnityEngine;

public class MuteSqueak : IQuackBehaviour
{
    public void Quack()
    {
        Debug.Log("I cannot quack");
    }
}
