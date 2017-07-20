using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class showCard : MonoBehaviour {	
	public Animator anim, treasure_anim;
	public GameObject treasure;

	void Update () {
		if (anim != null && treasure_anim != null) {
			if (treasure_anim.GetBool ("chest_status")) {
				anim.SetTrigger ("hide");
			} else {
				anim.SetTrigger ("show");
			}
		}
	}
}

