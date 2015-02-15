#pragma strict

var moveRight : KeyCode;
var moveLeft : KeyCode;

var speed : float;

function Update () {

	// move the ship up if the moveUp key is pressed,
	if (Input.GetKey(moveRight))
	{
		rigidbody2D.velocity.x = speed;
	} 
	// move the ship down if moveDown is pressed
	else if (Input.GetKey(moveLeft))
	{
		rigidbody2D.velocity.x = -speed;		
	}
	// slowly push ship back to starting position if nothing is pressed
	else
	{
		rigidbody2D.velocity.x = 0;	
	}
}