using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playChest : MonoBehaviour {	
	public GameObject card_image;
	public Image image;
	public Animator anim;

	void Start(){
		anim = GetComponent<Animator> ();
		anim.Play ("hide_card", -1, 0f);
	}

	void Update () {
		
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, 100)) {
				if (null != anim) {
					if (anim.GetBool ("chest_status")) {
						card_image.SetActive (true);
						anim.Play ("box_open", -1, 0f);
						anim.Play ("show_image", -1, 0f);
						anim.SetBool ("chest_status", false);
					} else {
						anim.Play ("box_close", -1, 0f);
						anim.Play ("card_to_bag", -1, 0f);
						anim.SetBool ("chest_status", true);
					}
				}
			}
		}
	}
}

	