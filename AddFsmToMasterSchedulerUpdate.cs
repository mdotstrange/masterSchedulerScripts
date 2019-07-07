using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{

	[ActionCategory(ActionCategory.GameObject)]
	public class AddFsmToMasterSchedulerUpdate : FsmStateAction
	{
        public FsmString QueueName;

		// Code that runs on entering the state.
		public override void OnEnter()
		{
            FsmUpdate();
			Finish();
		}

        void FsmUpdate()
        {
            QueueHub.AddJobToQueue(QueueName.Value, Fsm.Owner.gameObject, Update);
        }

        void Update()
        {
            Fsm.Update();
        }


	}

}
