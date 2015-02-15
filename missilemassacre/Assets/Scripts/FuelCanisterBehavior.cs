using UnityEngine;
using System.Collections;

public class FuelCanisterBehavior : MonoBehaviour 
{
	public float FallRate;
	public float EnergyLevel;

	public void DropItLikeItsHot() 
	{
		gameObject.rigidbody2D.velocity = new Vector2(0f, -this.FallRate);
	}
	
	private void OnTriggerEnter2D (Collider2D hitBox)
	{
		if (hitBox.name.Equals("PlayerShip"))
		{
			Debug.Log("Ship energy +" + this.EnergyLevel.ToString () + "!");
			Destroy(this.transform);
		}
	}
}
