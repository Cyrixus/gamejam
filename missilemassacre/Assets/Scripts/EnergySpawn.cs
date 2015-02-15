using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnergySpawn : MonoBehaviour {
	/** Public GUI Variables **/

	public GameObject lowEnergyPrefab;
	public float lowEnergyChance = 1f;

	public GameObject midEnergyPrefab;
	public float midEnergyChance = 0.3f;

	public GameObject highEnergyPrefab;
	public float highEnergyChance = 0.01f;

	public bool isEnergyOnScreen = false;
	
	private float lowerBound = 0f;
	private float upperBound = 1f;

	void Start() {
		spawnEnergies ();
	}

	// Update is called once per frame
	void Update () {
		spawnEnergies ();
	}

	void spawnEnergies() {
		// only spawn an energy if there isn't one available already
		if (!this.isEnergyOnScreen) {		
			// pull a random value and spawn level based on it
			float randomValue = Random.Range (lowerBound, upperBound);

			if (randomValue <= this.lowEnergyChance) {
				buildEnergy (this.lowEnergyPrefab);
			} else if (randomValue <= this.midEnergyChance) {
				buildEnergy (this.midEnergyPrefab);
			} else {
				buildEnergy (this.highEnergyPrefab);
			}
		}
	}

	/** Energy builder **/
	void buildEnergy(GameObject prefab) {
		Vector3 position = transform.position;
		Debug.Log((Random.Range (0f, transform.localScale.x)/2f).ToString());
		position.x = 5.0f;
		position.y -= transform.localScale.y/2f;
		
		// Create a new energy prefab
		Transform energy = Instantiate(prefab, position, Quaternion.identity) as Transform;

		// Drop it likes its hot!
		energy.SendMessage ("DropItLikeItsHot"); 

		isEnergyOnScreen = true;
	}
}
