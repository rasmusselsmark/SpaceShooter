using UnityEngine;
using System.Collections;

public class CurvedAsteroid : MonoBehaviour
{
	public float speed = 0.2f;

	void Update ()
	{
		// transform.Translate(0.0f, 0.0f, speed);
		transform.position = new Vector3(
			transform.position.x,
			transform.position.y,
			transform.position.z + speed);
	}
}
