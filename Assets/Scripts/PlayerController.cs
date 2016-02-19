using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public float tilt;
	public float maxAngleRot;
	public float distanceVPMax = 150;
	public float distanceVPMin = 30;
	public Transform planete;

	private float rotX = 0;
	private float moveHPrec = 0;

	void FixedUpdate ()
	{
		//Recuperation des inputs du joueur
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		//Deplacement du joueur
		transform.position = Vector3.MoveTowards(transform.position, planete.position, moveVertical * speed * Time.deltaTime);
		transform.RotateAround(planete.position, Vector3.up, -moveHorizontal * speed * Time.deltaTime);

		//Rotation du joueur
		if (moveHorizontal < 0 && moveHorizontal <= moveHPrec)
		{
			rotX = maxAngleRot;
			transform.localEulerAngles = new Vector3(Mathf.LerpAngle(transform.localEulerAngles.x, rotX, Time.deltaTime * tilt), transform.localEulerAngles.y, transform.localEulerAngles.z);	
		}
		else if (moveHorizontal > 0 && moveHorizontal >= moveHPrec)
		{
			rotX = -maxAngleRot - 360;
			transform.localEulerAngles = new Vector3(Mathf.LerpAngle(transform.localEulerAngles.x, rotX, Time.deltaTime * tilt), transform.localEulerAngles.y, transform.localEulerAngles.z);	
		}
		else 
		{
			rotX = 0;
			transform.localEulerAngles = new Vector3(Mathf.LerpAngle(transform.localEulerAngles.x, rotX, Time.deltaTime * tilt / 2), transform.localEulerAngles.y, transform.localEulerAngles.z);	
		}
		moveHPrec = moveHorizontal;

		//Empeche le joueur de trop s'éloigner de la planete
		if (Vector3.Distance(transform.position, planete.position) > distanceVPMax)
		{
			transform.position = (transform.position - planete.position).normalized * distanceVPMax + planete.position;	
		}
		//Empeche le joueur de trop se rapprocher de la planete
		if (Vector3.Distance(transform.position, planete.position) < distanceVPMin)
		{
			transform.position = (transform.position - planete.position).normalized * distanceVPMin + planete.position;	
		}
	}
}
