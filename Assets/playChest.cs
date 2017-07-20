using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playChest : MonoBehaviour {	
	public Animator anim;

	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, 100)) {
				if (null != anim) {
					if (anim.GetBool ("chest_status")) {
						anim.SetTrigger ("open");
						anim.SetBool ("chest_status", false);
					} else {
						anim.SetTrigger ("close");
						anim.SetBool ("chest_status", true);
					}
				}
			}
		}
	}
}

	