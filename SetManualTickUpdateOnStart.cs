using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime;

public class SetManualTickUpdateOnStart : MonoBehaviour
{
    public BehaviorManager BehaviorManager;
    public string QueueToUse;

    // Use this for initialization
    void Start ()
    {
        QueueHub.AddJobToQueue(QueueToUse, gameObject, TickUpdate);
	}

    void TickUpdate()
    {
        BehaviorManager.instance.Tick();
    }
	
	
}
