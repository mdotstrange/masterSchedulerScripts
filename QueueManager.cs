using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueManager : MonoBehaviour
{
    [Header("Create Queues on Awake")]
    public NewQueue[] QueuesToCreate;

	// Use this for initialization
	void Awake ()
    {
        for (int index = 0; index < QueuesToCreate.Length; index++)
        {
            var i = QueuesToCreate[index];
            QueueHub.CreateQueue(i.QueueName, i.JobsPerFrame, i.IsLooping);
        }
	}
	
	
}

[System.Serializable]
public class NewQueue
{
    public string QueueName;
    public int JobsPerFrame;
    public bool IsLooping;
}
