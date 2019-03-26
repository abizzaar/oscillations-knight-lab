using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updateRootPos : MonoBehaviour
{
	public GameObject ethan;
	public Vector3 currHipsPos;
	public Quaternion currHipsRot;
	private Animator anim;
	public GameObject ethanHips;
	public Vector3 check;

	public Vector3 oldRoot;
	// This var will determine if the animation is started
	public bool animation_started = false;
	// This var will determine if the animation is finished
	public bool animation_finished = true;

	private int animChange;
	
 
	// Use this for initialization
	void Start()
	{
		ethan = GameObject.Find("morro_man");
		anim = ethan.GetComponent<Animator>();
		ethanHips = ethan.transform.Find("MHuman_Root").gameObject;
		animation_started = true;
		animation_finished = false;
		oldRoot = ethan.transform.position;
	}

 
	/* This function is trigger at the end of the animation */
	public void animationFinished()
	{
		animation_finished = true;
	}

	public void animationStarted(int intKeyframe)
	{
		
		animation_started = true;
		animChange = intKeyframe;
	}
 
	/*  
	    At the end of the frame if the animation is finished
	    we update the position of the parent to the last position of the child
	    and set the position of the child to zero inside the parent.
	*/
	void LateUpdate () {
		
		check = ethanHips.transform.position;
		
		if (animation_finished)
		{
			currHipsPos = ethanHips.transform.position;
			currHipsRot = ethanHips.transform.rotation;
			animation_finished = false;
			Debug.Log(currHipsPos);
		}
			
		Debug.Log("Im an idiot");
		
		
		if(animation_started)
		{
			animation_started = false;
			//Vector3 hipsDiff = currHipsPos - ethanHips.transform.localPosition;
			//Vector3 newPos = new Vector3(hipsDiff.x, ethan.transform.position.y, hipsDiff.z);
			Vector3 ran = new Vector3(5, 0, 0);
			//Vector3 newPos = currHipsPos;
			Vector3 newPos = currHipsPos;
			newPos = new Vector3(newPos.x, 0f, newPos.z);

			Vector3 eulerRot = currHipsRot.eulerAngles;
			//var lookPos = newPos - ethan.transform.localPosition;
			var lookPos = newPos;
			lookPos.y = 0;
			var rotation = Quaternion.LookRotation(lookPos);

			Vector3 newRot = ethan.transform.rotation.eulerAngles;
			eulerRot = new Vector3(newRot.x, eulerRot.y, newRot.z);
			
			//ethan.transform.position += newPos - ethanHips.transform.localPosition;
			
			
			//ethan.transform.rotation = Quaternion.LookRotation(lookPos);

			switch (animChange)
			{
				case 3:
					//ethan.transform.position += new Vector3(0.1535187f - 0.6198351f, 0f, 0.07261555f + 0.2550304f );
					break;
				case 4:
					ethan.transform.position += new Vector3(+0.001823157f-0.1383394f, 0f, +0.2458937f -1.364185f);
					Debug.Log("reached");
					break;
					// 
					// 
				case 7:
					ethan.transform.position += new Vector3(0.1297451f, 0f, 0.105484f);
					Debug.Log("YYYYE");
					break;
				case 8:
					
					Debug.Log("uh man");
					break;
				case 9:
					
					//-1.324282
				//-0.593114
				
				//-0.2297451
				//-1.405484
				default:
					break;
			}
		
			
			
			//else 
			
			//
		}
	}

	private void OnAnimatorMove()
	{

	}
	
	
}
