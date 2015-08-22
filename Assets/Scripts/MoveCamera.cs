using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {
	public GameObject centerPoint;
	
	// Update is called once per frame
	void Update () {
		Camera.main.transform.LookAt (centerPoint.transform);
		if (Input.GetButton("Horizontal")){
			Debug.Log (Camera.main.velocity.magnitude);
			Camera.main.transform.localPosition += Camera.main.transform.right * Time.deltaTime * Input.GetAxis("Horizontal") * 10;

		}
		if (Input.GetButton("Vertical")){
			Camera.main.transform.localPosition += Camera.main.transform.up * Time.deltaTime * Input.GetAxis("Vertical") * 10;
		}

		if (Input.GetAxis ("Mouse ScrollWheel") != 0) {

			//Camera.main.transform.localPosition += Camera.main.transform.forward * Time.deltaTime * Input.GetAxis ("Mouse ScrollWheel") * 10;
		}
		
		
	}
}