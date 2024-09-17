using System;

public class GameEvents
{
    public static event Action OnHiderFound;

    public static void HiderFound()
    {
        if (OnHiderFound != null)
            OnHiderFound.Invoke();
        
    }
}