using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public Transform target;
	
	void Update () {
		Vector3 targetPos = target.position;

		transform.position = new Vector3(targetPos.x - 8, targetPos.y + 8, targetPos.z);
	}
}
