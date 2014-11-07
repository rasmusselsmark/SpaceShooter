using UnityEngine;
using System.Collections;

public class SpaceShipController : MonoBehaviour
{
	public float tilt = 25f;
	public float movement = 0.1f;

	// Update is called once per frame
	void Update ()
	{
		transform.position = new Vector3(
			transform.position.x - Input.GetAxis("Horizontal") * movement,
			transform.position.y,
			transform.position.z);
		transform.rotation = Quaternion.Euler(0f, 180f, -Input.GetAxis("Horizontal") * tilt);
	}
}
