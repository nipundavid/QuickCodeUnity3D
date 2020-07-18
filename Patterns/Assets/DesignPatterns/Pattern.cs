using UnityEngine;

public class Pattern : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowStrategyPattern()
    {
        Duck duck1 = new MallardDuck();
        duck1.PerformFly();
        duck1.PerformQuack();

        Duck duck2 = new PlasticDuck();
        duck2.PerformFly();
        duck2.PerformQuack();
    }

    public void ShowAdapterPattern()
    {
        ITurkeyInterface turkey = new Turkey();
        Duck turkeyAdapter = new TurkeyAdaptor(turkey);
        turkeyAdapter.PerformFly();
        turkeyAdapter.PerformQuack();
    }

    public void ShowObserverPatter()
    {
        ConcreteSubject concreteSubject = new ConcreteSubject();
        ConcreteObserver concreteObserver = new ConcreteObserver(concreteSubject);

        concreteSubject.SetValue(80);
    }
}
