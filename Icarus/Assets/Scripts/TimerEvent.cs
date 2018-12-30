using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimerEvent : MonoBehaviour {

    // TODO - Assign the amount of times the spawner will spawn
    public float amountofspawns = 5;
    public float time = 1;
    public bool repeat = false;
    public UnityEvent onTimerComplete;

    private void Start ()
    {
        if (repeat)
        {
            InvokeRepeating("OnTimerComplete", 0, time);
        }
        else
        {
            Invoke("OnTimerComplete", time);
        }
    }

    private void OnTimerComplete ()
    {
        onTimerComplete.Invoke();
    }
}
