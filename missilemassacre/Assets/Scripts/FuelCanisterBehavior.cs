using UnityEngine;
using System.Collections;

public class FuelCanisterBehavior : MonoBehaviour 
{
	public float FallRate;
	public Vector3 StartPosition;
	public float EnergyLevel;
	public Sprite Sprite;

	public FuelCanisterBehavior (float speed, Vector3 start, float level, Sprite sprite)
	{
		this.FallRate = speed;
		this.StartPosition = start;
		this.EnergyLevel = level;
		this.Sprite = sprite;
	}

	public void DropItLikeItsHot() 
	{
		gameObject.transform.position = this.StartPosition;
		gameObject.rigidbody2D.velocity = new Vector2(0f, -this.FallRate);
	}
	
	private void OnTriggerEnter2D (Collider2D hitBox)
	{
		if (hitBox.name.Equals("PlayerShip"))
		{
			Debug.Log("Ship energy +" + this.EnergyLevel.ToString () + "!");
		}
	}
}
