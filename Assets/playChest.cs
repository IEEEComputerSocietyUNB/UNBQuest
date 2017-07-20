using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playChest : MonoBehaviour {	
	public Animator anim, card_animator;

	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, 100)) {
				if (null != anim) {
					if (!anim.GetBool ("chest_status")) {
						anim.SetTrigger ("open");
						card_animator.SetTrigger ("show");
						anim.SetBool ("chest_status", true);
					} else {
						anim.SetTrigger ("close");
						card_animator.SetTrigger ("hide");
						anim.SetBool ("chest_status", false);
					}
				}

			}
		}


	}
}

	