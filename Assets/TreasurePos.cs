using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Vuforia;

public class TreasurePos : MonoBehaviour {	
	private ImageTargetBehaviour imageTarget = null;

	void Start () {
		imageTarget = GetComponent<ImageTargetBehaviour>();
	}

	public List<float> GetTreasurePosition() {
		Vector2 targetSize = imageTarget.GetSize();
		float targetAspect = targetSize.x / targetSize.y;
		List<float> originPositions = new List<float> ();

		Vector3 pointOnTarget = new Vector3(-0.5f, 0, -0.5f/targetAspect); 
		Vector3 targetPointInWorldRef = transform.TransformPoint(pointOnTarget);
		Vector3 screenPoint = Camera.main.WorldToScreenPoint(targetPointInWorldRef);

		originPositions.Add (screenPoint.x);
		originPositions.Add (screenPoint.y);
		originPositions.Add (screenPoint.z);

		return originPositions;
	}
}