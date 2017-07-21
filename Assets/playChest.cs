using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayChest : MonoBehaviour {	
	public Animator anim, cardAnimator;
	private TreasurePos imageTargetScript;
	public GameObject card;

	void Start(){
		imageTargetScript = GameObject.Find("ImageTarget").GetComponent<TreasurePos>();
	}

	void SetOrigin(float x, float y, float z) {
		List<float> originPositions = new List<float> ();
		originPositions =  imageTargetScript.GetTreasurePosition ();
		Debug.Log (x + " " + y + " " + z);
		Debug.Log (originPositions[0] + " " + originPositions[1] + " " + originPositions[2]);
		card.transform.position = new Vector3 (50, 100 , 0);
//		card.transform.position = new Vector3 (originPositions[0], originPositions[1] , originPositions[2]);
		Debug.Log ("card: " + card.transform.position.x + " " + card.transform.position.y + " " + card.transform.position.z);

	}

	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, 100)) {
				if (anim != null) {
					if (!anim.GetBool ("chest_status")) {
						SetOrigin (ray.direction.x, ray.direction.y, ray.direction.z);
						anim.SetTrigger ("open");
						cardAnimator.SetTrigger ("show");
						anim.SetBool ("chest_status", true);
					} else {
						anim.SetTrigger ("close");
						cardAnimator.SetTrigger ("hide");
						anim.SetBool ("chest_status", false);
					}
				}
			}
		}
	}
}

	