using System;

public class Ticker : Singleton<Ticker>
{
    public static event Action UpdateTick;
    public static event Action FixedUpdateTick;
    public static event Action LateUpdateTick;
        
    private void Update()
    {
        UpdateTick?.Invoke();
    }

    private void FixedUpdate()
    {
        FixedUpdateTick?.Invoke();
    }

    private void LateUpdate()
    {
        LateUpdateTick?.Invoke();
    }
}