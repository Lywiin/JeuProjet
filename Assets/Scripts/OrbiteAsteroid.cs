using UnityEngine;
using System.Collections;

public class OrbiteAsteroid : MonoBehaviour {

	public Transform target;
	public int speed = 10;

	void Update () {
		transform.RotateAround(target.position, Vector3.up, speed * Time.deltaTime);
	}
}
