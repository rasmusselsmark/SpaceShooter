using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class GameObjectPool
{
	private List<GameObject> _objects = new List<GameObject>();

	public GameObject GetOrInstantiate<T>(GameObject original) where T : MonoBehaviour
	{
		foreach (GameObject o in _objects)
		{
			if (!o.activeSelf && (o.GetComponent<T>() != null))
			{
				o.SetActive(true);
				Debug.Log(string.Format("Returned pooled object {0}", o.name));
				return o;
			}
		}

		GameObject obj = GameObject.Instantiate(original, Vector3.zero, Quaternion.identity) as GameObject;
		_objects.Add(obj);
		obj.SetActive(true);
		Debug.Log(string.Format("Returned new object {0}", obj.name));
		return obj;
	}

	public void ReturnToPoolOrDestroy(GameObject obj)
	{
		// if we don't have this object in pool, simply destroy it, otherwise deactivate it
		if (!_objects.Contains(obj))
		{
			Debug.Log(string.Format("Destroyed non-pooled object {0}", obj.name));
			GameObject.Destroy(obj);
		}

		obj.SetActive(false);
	}
}
