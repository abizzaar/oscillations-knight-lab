using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updateRoot : StateMachineBehaviour
{

	private updateRootPos script;
	private GameObject ethan;

	private bool doneOnce = false;
	
	void onEnable()
	{
		
	}
	
	// OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		/*
		if(script == null)
			script = animator.gameObject.GetComponent<updateRootPos>();

		if (!doneOnce)
		{
			Vector3 hipsDiff = script.currHipsPos - script.ethanHips.transform.localPosition;
			Vector3 newPos = new Vector3(hipsDiff.x, script.ethan.transform.position.y, hipsDiff.z);
			Vector3 ran = new Vector3(5, 0, 0);
			GameObject ethanHips = GameObject.Find("EthanHips");
			//script.ethan.transform.position = newPos;
			doneOnce = true;
		}
		*/
	}

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	//override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		
	}

	// OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
	
	override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		if (stateInfo.normalizedTime > .97f && !animator.IsInTransition(layerIndex))
		if(script == null)
			script = animator.gameObject.GetComponent<updateRootPos>();
		//script.animation_finished = true;
		Debug.Log("Im an idiot");

	}

	// OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
	//override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}
}
