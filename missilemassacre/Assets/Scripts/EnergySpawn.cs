using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnergySpawn : MonoBehaviour {
	/** Public GUI Variables **/

	public Transform lowEnergyPrefab;

	public Transform midEnergyPrefab;
	public float midEnergyChance = 0.3f;

	public Transform highEnergyPrefab;
	public float highEnergyChance = 0.01f;

	public float frequency = 1.0f;

	/** Private State **/
	private float elapsed = 0.0f;
	private Vector3 lastSpawnPosition = Vector3.zero;


	/** Lifecycle Methods **/
	void Start() {
		elapsed = 0.0f;
		lastSpawnPosition = transform.position;
	}

	// Update is called once per frame
	void Update () {
		elapsed += Time.deltaTime;

		// only spawn an energy if there isn't one available already
		if (elapsed > frequency) {		
			// pull a random value and spawn level based on it
			float randomValue = Random.value;
			
			if (randomValue < highEnergyChance) {
				spawnHighEnergy();
			} else if (randomValue < midEnergyChance + highEnergyChance) {
				spawnMediumEnergy();
			} else {
				spawnLowEnergy();
			}

			// Clamp lastSpawnPosition
			lastSpawnPosition.x = Mathf.Clamp(lastSpawnPosition.x, transform.position.x - transform.localScale.x * 0.5f, 
			                                  transform.position.x + transform.localScale.x * 0.5f);
			elapsed %= frequency;
		}
	}

	/** Spawn Energy Methods **/
	private void spawnHighEnergy() {
		Vector3 position = lastSpawnPosition;
		position.x += (Random.value - 0.5f) * 2.0f * (transform.localScale.x / 2.0f);
		position.y = Random.value * transform.localScale.y + transform.localScale.y / 2.0f;

		position = clampToRegion (position);

		Instantiate (highEnergyPrefab, position, Quaternion.identity);
		lastSpawnPosition = position;
	}

	private void spawnMediumEnergy() {
		Vector3 position = lastSpawnPosition;
		position.x += (Random.value - 0.5f) * 1.0f * (transform.localScale.x / 2.0f);
		position.y = Random.value * transform.localScale.y + transform.localScale.y / 2.0f;
		
		position = clampToRegion (position);
		
		Instantiate (midEnergyPrefab, position, Quaternion.identity);
		lastSpawnPosition = position;
	}

	private void spawnLowEnergy() {
		Vector3 position = lastSpawnPosition;
		position.x += (Random.value - 0.5f) * 0.5f * (transform.localScale.x / 2.0f);
		position.y = Random.value * transform.localScale.y + transform.localScale.y / 2.0f;
		
		position = clampToRegion (position);
		
		Instantiate (lowEnergyPrefab, position, Quaternion.identity);
		lastSpawnPosition = position;
	}

	/** Helper Methods **/
	private Vector3 clampToRegion(Vector3 position) {
		Vector3 output = Vector3.zero;
		output.x = Mathf.Clamp (position.x, transform.position.x - transform.localScale.x / 2.0f, transform.position.x + transform.localScale.x / 2.0f);
		output.y = Mathf.Clamp (position.y, transform.position.y - transform.localScale.y / 2.0f, transform.position.y + transform.localScale.y / 2.0f);
		output.z = transform.position.z;

		return output;
	}
}
