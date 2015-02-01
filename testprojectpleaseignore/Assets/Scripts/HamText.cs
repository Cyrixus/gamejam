using UnityEngine;
using System.Collections;

public class HamText : MonoBehaviour {

	public static float TIME_TO_LIVE = 1.0f;
	public static float VELOCITY = 5.0f;

	private float elapsedTime;

	// Use this for initialization
	void Start () {
		elapsedTime = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		elapsedTime += Time.deltaTime;
		if (elapsedTime > TIME_TO_LIVE) {
			Destroy(gameObject);
			return;
		}

		gameObject.transform.Translate (new Vector3 (0, VELOCITY * Time.deltaTime));
	}
}
