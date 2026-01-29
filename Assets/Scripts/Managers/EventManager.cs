using UnityEngine.Events;

public static class EventManager
{
    public static event UnityAction<float> TimerUpdate;
    public static event UnityAction TimerStart;
    public static event UnityAction TimerStop;

    public static event UnityAction TimerStartRoulette;
    public static event UnityAction TimerStopRoulette;
    public static event UnityAction<float> TimerUpdateRoulette;

    public static event UnityAction petActivate;
    public static event UnityAction<int> deathEnemy;
    public static event UnityAction shootEnemy;

    public static event UnityAction touchPlatformOn;
    public static event UnityAction touchPlatformOff;

    public static event UnityAction<string> skin0;

    public static event UnityAction treeRemove;

    public static void OnTimerUpdate(float value) => TimerUpdate?.Invoke(value);
    public static void OnTimerStart() => TimerStart?.Invoke();
    public static void OnTimerStop() => TimerStop?.Invoke();


    public static void OnTimerStartRoulette() => TimerStartRoulette?.Invoke();
    public static void OnTimerStopRoulette() => TimerStopRoulette?.Invoke();
    public static void OnTimerUpdateRoulette(float value) => TimerUpdateRoulette?.Invoke(value);

    public static void OnDeathEnemy(int value) => deathEnemy?.Invoke(value);
    public static void OnShootEnemy() => shootEnemy?.Invoke();

    public static void OntouchPlatform() => touchPlatformOn?.Invoke();
    public static void OfftouchPlatform() => touchPlatformOff?.Invoke();

    public static void ByuSkin0(string id) => skin0?.Invoke(id);

    public static void OnTreeRemove() => treeRemove?.Invoke();
}
