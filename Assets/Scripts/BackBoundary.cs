using UnityEngine;
using System.Collections;

public class BackBoundary : MonoBehaviour
{
	public void OnTriggerEnter(Collider collider)
	{
		GameStateManager.ObjectPool.ReturnToPoolOrDestroy(collider.gameObject);
	}
}
