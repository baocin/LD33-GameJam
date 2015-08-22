using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HexSphereGrid : MonoBehaviour {
	public GameObject prefab;
	public GameObject centerPoint;
	public int count = 10;
	public float size = 20;

	List<List<GameObject>> grid = new List<List<GameObject>>();

	// Use this for initialization
	void Start () {
		generateGrid ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	[ContextMenu("Create Points")]
	void generateGrid(){
		List<Vector3> points = UniformPointsOnSphere (count, size);
		for(var i=0; i<count; i++) {
			var g = Instantiate(prefab, transform.position+points[i], Quaternion.identity) as GameObject;
			g.transform.parent = transform;
			g.transform.LookAt(centerPoint.transform);
			g.GetComponent<HexTile>().hexID = count;

			grid.Add(g);
		}
	}

	List<Vector3> UniformPointsOnSphere(float N, float scale){
		List<Vector3> points = new List<Vector3> ();
		float i = Mathf.PI * (3 - Mathf.Sqrt (5));
		float o = 2 / N;
		for (int k = 0; k < N; k++) {
			var y = k * o - 1 + (o / 2);
			var r = Mathf.Sqrt(1 - y*y);
			var phi = k * i;
			points.Add(new Vector3(Mathf.Cos(phi)*r, y, Mathf.Sin(phi)*r) * scale);
		}
		return points;
	}
}
