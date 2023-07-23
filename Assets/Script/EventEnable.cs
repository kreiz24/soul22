using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventEnable : MonoBehaviour
{
    public  UnityEvent Selected;
    public bool Start;

    private void Update()
    {
        if (Start)
        {
            Selected.Invoke();
            Start = false;
        }
        
    }
    
}
