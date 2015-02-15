using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour {

	/** Singleton Instance **/
	public static GameState instance { get; private set; }
	void Awake() {
		instance = this;
	}

	/** Player Reference **/
	public GameObject playerShipPrefab;
	public GameObject playerShip { get; private set; }

	// Use this for initialization
	void Start () {
		if (playerShip != null) {
			Destroy (playerShip);
		}

		playerShip = Instantiate (playerShipPrefab, Vector3.zero, Quaternion.identity) as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
