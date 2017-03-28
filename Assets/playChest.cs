using UnityEngine;
using System.Collections;

public class playChest : MonoBehaviour {
	void Update () {
		if(Input.GetMouseButtonDown(0))
		{
			Animator anim = GetComponent<Animator>();
			if (null != anim)
			{
				Debug.Log("Playing anim");
				anim.SetTrigger("openchest");
			}
		}
	}
}
	