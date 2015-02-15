using UnityEngine;
using System.Collections;

public class MissileWobble : MonoBehaviour {
	public float wobbleDegree = 6.0f; // How far from side to side the missile should wobble.
	public float frequency = 0.4f;

	private float elapsed;
	private float lastRotation;

	// Use this for initialization
	void Start () {
		elapsed = 0.0f;
		lastRotation = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		elapsed += Time.deltaTime;

		float currentRotation = 0.0f;
		if (wobbleDegree != 0.0f) {
			currentRotation = Mathf.Sin (elapsed / frequency) * wobbleDegree;
		}

		transform.Rotate (0, 0, currentRotation - lastRotation);
		lastRotation = currentRotation;
	}
}
