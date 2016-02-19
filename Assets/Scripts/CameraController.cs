using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public Transform target;
	public float zoomSpeed = 3;

	private float fovMin = 60, fovMax = 80;
	private float camRotX = 65, camRotY = 270, camRotZ = 180;

	void Update () 
	{
		//Rotation camera lorsque le vaisseau penche
		if (target.localEulerAngles.x < 180) 
			transform.localEulerAngles = new Vector3(camRotX - target.localEulerAngles.x / 14f, camRotY + target.localEulerAngles.x * 1.5f, camRotZ + target.localEulerAngles.x / 1.5f);
		else
			transform.localEulerAngles = new Vector3(camRotX + (target.localEulerAngles.x - 360) / 14f, camRotY + (target.localEulerAngles.x - 360) * 1.5f, camRotZ + (target.localEulerAngles.x - 360) / 1.5f);


		//Zoom in et out lorsqu'on avance/recule
		float moveVertical = Input.GetAxis ("Vertical");

		GetComponent<Camera>().fieldOfView += moveVertical * zoomSpeed;

		if (GetComponent<Camera>().fieldOfView < fovMin)
			GetComponent<Camera>().fieldOfView = fovMin;
		if (GetComponent<Camera>().fieldOfView > fovMax)
			GetComponent<Camera>().fieldOfView = fovMax;

		if (moveVertical == 0)
			GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, fovMin + (fovMax - fovMin) / 2, Time.deltaTime * zoomSpeed);
	}
}
