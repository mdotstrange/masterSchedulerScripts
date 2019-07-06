# masterSchedulerScripts
A few scripts to allow MasterScheduler to control Playmaker and Behavior Designer update ticks

**REQUIREMENTS**
//MasterScheduler https://assetstore.unity.com/packages/tools/ai/master-scheduler-100283

//Behavior Designer (If you want to update that)

//Playmaker (If you want to update that)

**Notes on useage:

QueueManager - use this to create your master scheduler queues- this runs on Awake- this needs to run BEFORE any of the other scripts

SetManualTickUpdateOnStart - use this to make it so behavior designer will manually update all BT's using the Queue you choose

ManuallyUpdateFsm - use these to manually update the FSM's you add to "FsmsToUpdate" using the Queue you choose

**Setup images**
![Example usage](/images/exampleUse.png)

![Playmaker setup1](/images/pmSetup1.png)

![Playmaker setup2](/images/pmSetup2.png)
