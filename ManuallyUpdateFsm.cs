using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HutongGames.PlayMaker;

public class ManuallyUpdateFsm : MonoBehaviour
{
    public PlayMakerFSM[] FsmsToUpdate;
    public string QueueToUse;

    // Use this for initialization
    void Start ()
    {
        QueueHub.AddJobToQueue(QueueToUse, gameObject, FsmUpdate);
    }
	
	void FsmUpdate()
    {
        for (int index = 0; index < FsmsToUpdate.Length; index++)
        {
            var i = FsmsToUpdate[index];
            i.Fsm.Update();
        }
    }
}
