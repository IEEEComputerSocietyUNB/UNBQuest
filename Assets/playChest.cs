using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playChest : MonoBehaviour {	
	public GameObject card_image;
	public Image image;

	void Start(){
		card_image = GameObject.Find("canvas_card");
		card_image.SetActive (false);
	}

	void Update () {
		Animator anim = GetComponent<Animator> ();
		if (Input.GetMouseButtonDown (0)) {
			if (null != anim) {
				if (anim.GetBool ("chest_status")) {
					anim.SetTrigger ("openchest");
					card_image.SetActive (true);
					anim.SetTrigger ("showimage");
					anim.SetBool ("chest_status", false);
				} else {
					anim.SetTrigger ("closechest");
					anim.SetBool ("chest_status", true);
					card_image.SetActive (false);
				}
			}
		}
	}
}

	