using UnityEngine;	
using System.Collections;
using System.Collections.Generic;

public class HexGrid : MonoBehaviour {
	public GameObject spawnPrefab;
	public float distanceBetweenTiles = 4;
	public int rowSize = 5;
	public int columnSize = 5;

	public float offsetX = 0;
	public float offsetZ = 0;
	
	List<List<GameObject>> grid = new List<List<GameObject>>();

	// Use this for initialization
	void Start () {
		generateGrid ();
	}

	void generateGrid(){
		destroyGrid ();
		for (int y = 0; y < columnSize; y++){
			offsetZ += distanceBetweenTiles * .9f;
			if (y % 2 == 0){
				offsetX += distanceBetweenTiles/2;
			}
			List<GameObject> row = new List<GameObject>();
			for (int x = 0; x < rowSize; x++) {
				offsetX += distanceBetweenTiles;
				GameObject newClone = Instantiate(spawnPrefab) as GameObject;


				newClone.transform.position = new Vector3(
					newClone.transform.position.x + offsetX,
					newClone.transform.position.y,
					newClone.transform.position.z + offsetZ
				);

//				newClone.transform.LookAt(GameObject.Find("GridCenterPoint").transform.position);
//				newClone.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 5 * x);

				row.Add(newClone);
				
			}
			grid.Add(row);
			offsetX = 0;
		}
		offsetZ = 0;
	}

	void destroyGrid(){
		for (int x = 0; x < grid.Count; x++) {
			for (int y = 0; y < grid[x].Count; y++) {
				GameObject.Destroy(grid[x][y]);
				//grid[x][y].destroyTile();
			}
		}
		grid = new List<List<GameObject>>();
	}

	void OnGUI() {
		GUI.contentColor = Color.blue;
		for (int x = 0; x < rowSize; x++) {
			for(int y = 0; y < columnSize; y++){
//				Vector3 screenPoint = Camera.main.ScreenToWorldPoint(grid[x][y].transform.position);
//				GUI.Label(new Rect( screenPoint.x, screenPoint.y, 50 , 20), "[" + x + ", " + y + "]");

			}
		}
	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.Space)) {
			generateGrid ();
		}
		if (Input.GetKeyDown (KeyCode.Delete)) {
			destroyGrid();
		}
//		for (int x = 0; x < grid.Count; x++) {
//			for(int y = 0; y < grid[x].Count; y++){
//				if(grid[x][y].GetComponent<Renderer>().isVisible){
//				grid[x][y].transform.LookAt(GameObject.Find("GridCenterPoint").transform.position);
//				}
//			}
//		}

		if (Input.GetKeyDown (KeyCode.LeftShift)) {

		}
	}

	void MovePlayerToFirstHex(int row, int col){

	}

}
