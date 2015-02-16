using UnityEngine;
using System.Collections;

public class MissileWobble : MonoBehaviour
{
	public float wobbleDegree = 6.0f; // How far from side to side the missile should wobble.
	public float frequency = 0.4f;
	public float wanderAmount;

	private float elapsed;
	private float lastRotation;
	private float anchorX;

	// Use this for initialization
	void Start ()
	{
		elapsed = 0.0f;
		lastRotation = 0.0f;
		anchorX = transform.position.x;
	}
	
	// Update is called once per frame
	void Update ()
	{
		elapsed += Time.deltaTime;
		
		float currentRotation = 0.0f;
		float currWander = 0;
		if (wobbleDegree != 0.0f) {
			float amount = Mathf.Sin (elapsed / frequency);
			// Will eventually overflow and cause missiles not to wobble as much
			currentRotation = amount * wobbleDegree;
			currWander = amount * wanderAmount;
		}
		transform.Rotate (0, 0, currentRotation - lastRotation);
		transform.position = new Vector3 (anchorX + currWander, transform.position.y, transform.position.z);
		
		lastRotation = currentRotation;
	}
}
