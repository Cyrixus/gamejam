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
		if (Input.GetKey (moveRight)) {
			gameObject.rigidbody2D.velocity = Vector3.right * speed;
		} 
		// move the ship down if moveDown is pressed
		else if (Input.GetKey (moveLeft)) {
			gameObject.rigidbody2D.velocity = Vector3.left * speed;		
		} else {
			gameObject.rigidbody2D.velocity = Vector3.zero;
		}
	}
}

