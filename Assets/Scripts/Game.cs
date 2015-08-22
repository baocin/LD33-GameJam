using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Game : MonoBehaviour {
	//List<GameObject> grid = GameObject.Find("Grid").GetComponent<HexSphereGrid> ().grid;
	// Use this for initialization
	void Start () {
		GameObject.Find ("Grid").GetComponent<HexSphereGrid> ().generateGrid ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
