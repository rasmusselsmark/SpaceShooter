using UnityEngine;
using System.Collections;

public class SpaceshipCollision : MonoBehaviour
{
	void OnTriggerEnter(Collider other)
	{
		Debug.Log("OnTriggerEnter: " + other.name);
	}
	
	void OnCollisionEnter(Collision collision)
	{
		Debug.Log("OnCollisionEnter: " + collision.collider.name);
	}
}
