using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurkeyAdaptor : Duck
{
    private ITurkeyInterface turkey;
    public TurkeyAdaptor (ITurkeyInterface turkey)
    {
        this.turkey = turkey;
    }

    public override void PerformFly()
    {
        turkey.Fly();
    }

    public override void PerformQuack()
    {
        turkey.Gobble();
    }
}
