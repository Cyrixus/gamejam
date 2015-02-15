using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MissileDeath : MonoBehaviour {
	/** Public GUI Variables **/
	public int initialMissiles = 10;
	public int idealMissileCount = 50;
	public float missileFrequency = 0.33f;

	public Transform missilePrefab;

	/** Private State **/
	private List<Transform> missiles = new List<Transform> ();

	private float elapsed = 0.0f;


	/** Lifecycle Methods **/
	// Use this for initialization
	void Start () {
		elapsed = Random.value;

		while (missiles.Count < initialMissiles) {
			buildMissile();
		}
	}
	
	// Update is called once per frame
	void Update () {
		elapsed += Time.deltaTime;

		if (elapsed > missileFrequency && missiles.Count < idealMissileCount) {
			buildMissile();
			elapsed %= missileFrequency;
		}
	}

	/** Missile builder **/
	Transform buildMissile() {
		Vector3 position = transform.position;
		position.x += (Random.value * transform.localScale.x) - (transform.localScale.x / 2.0f);
		position.y += (Random.value * transform.localScale.y) - (transform.localScale.y / 2.0f);
		
		// Create a new missile prefab and add it to the array of missiles
		Transform missile = Instantiate(missilePrefab, position, Quaternion.identity) as Transform;

		// Scale Randomly between 1.0f and 2.0f
		float scalar = Random.value;
		missile.transform.localScale = new Vector3(1.0f + scalar, 1.0f + scalar, 1.0f);

		missiles.Add(missile);
		return missile;
	}
}
