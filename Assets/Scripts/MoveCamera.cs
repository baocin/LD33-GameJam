using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {
	Vector3 mouseOrigin;
	bool isRotating = false;
	bool isZooming = false;
	public GameObject centerPoint;
	float moveSensitivity = 4;
	float zoomSensitivity = 4;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Camera.main.transform.LookAt (centerPoint.transform);

		if (Input.GetButton("Horizontal")){
			Camera.main.transform.localPosition += Camera.main.transform.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSensitivity;
		}
		if (Input.GetButton("Vertical")){
			Camera.main.transform.localPosition += Camera.main.transform.up * Time.deltaTime * Input.GetAxis("Vertical") * moveSensitivity;
		}
		if (Input.GetButton ("Mouse ScrollWheel")) {
			Camera.main.transform.localPosition += Camera.main.transform.forward * Time.deltaTime * Input.GetAxis ("Mouse ScrollWheel") * zoomSensitivity;
		}


	}
}
