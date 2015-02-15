using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnergySpawn : MonoBehaviour {
	/** Public GUI Variables **/

	public Transform lowEnergyPrefab;
	public float lowEnergyChance = 1f;

	public Transform midEnergyPrefab;
	public float midEnergyChance = 0.3f;

	public Transform highEnergyPrefab;
	public float highEnergyChance = 0.01f;

	public float frequency = 1.0f;
	
	private float lowerBound = 0f;
	private float upperBound = 1f;

	private float elapsed = 0.0f;

	void Start() {
		elapsed = 0.0f;
	}

	// Update is called once per frame
	void Update () {
		elapsed += Time.deltaTime;

		// only spawn an energy if there isn't one available already
		if (elapsed > frequency) {		
			// pull a random value and spawn level based on it
			float randomValue = Random.Range (lowerBound, upperBound);
			
			if (randomValue <= this.lowEnergyChance) {
				buildEnergy (this.lowEnergyPrefab);
			} else if (randomValue <= this.midEnergyChance) {
				buildEnergy (this.midEnergyPrefab);
			} else {
				buildEnergy (this.highEnergyPrefab);
			}

			elapsed %= frequency;
		}
	}

	/** Energy builder **/
	void buildEnergy(Transform prefab) {
		Vector3 position = transform.position;
		position.x += (Random.value * transform.localScale.x) - (transform.localScale.x / 2.0f);
		position.y += (Random.value * transform.localScale.y) - (transform.localScale.y / 2.0f);
		
		// Create a new energy prefab
		Instantiate (prefab, position, Quaternion.identity);
	}
}
