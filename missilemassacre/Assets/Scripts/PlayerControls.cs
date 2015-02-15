using UnityEngine;

public class PlayerControls : MonoBehaviour
{
	public KeyCode moveRight;
	public KeyCode moveLeft;
	public float speed;

	// Update is called once per frame
	void Update ()
	{
		// move the ship up if the moveUp key is pressed,
		if (Input.GetKey(moveRight))
		{
			gameObject.rigidbody2D.velocity = new Vector3(speed, 0f, 0f);
		} 
		// move the ship down if moveDown is pressed
		else if (Input.GetKey(moveLeft))
		{
			gameObject.rigidbody2D.velocity = new Vector3(-speed, 0f, 0f);		
		}
		// slowly push ship back to starting position if nothing is pressed
		else
		{
			gameObject.rigidbody2D.velocity = new Vector3(0f, 0f, 0f);	
		}
	}
}

