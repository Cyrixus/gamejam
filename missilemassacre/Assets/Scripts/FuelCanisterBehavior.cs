using UnityEngine;
using System.Collections;

public class FuelCanisterBehavior : MonoBehaviour 
{
	public float FallRate;
	public float EnergyLevel;

	public float timeToLive = 5.0f; // By default, live for 5 seconds

	private float elapsed = 0.0f;

	public void Start() {
		elapsed = 0.0f;
		gameObject.rigidbody2D.velocity = new Vector2(0f, -this.FallRate);
	}

	public void Update() {
		elapsed += Time.deltaTime;
		if (elapsed > timeToLive) {
			Destroy (gameObject);
		}
	}
	
	void OnCollisionEnter2D (Collision2D collisionInfo)
	{
		Debug.Log (collisionInfo.collider.tag);
		if (collisionInfo.collider.tag == "Player")
		{
			FuelTracker.instance.gainFuel(EnergyLevel);
			Destroy(gameObject);
		}
	}
}
