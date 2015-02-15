using UnityEngine;
using System.Collections;

public class FuelManager : MonoBehaviour {
	public GameObject energyPrefab;
	public Transform node;

	// Use this for initialization
	void Start () {
		Instantiate (energyPrefab, node.transform.position, node.transform.rotation);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
