using UnityEngine;
using System.Collections;

public class Planet : MonoBehaviour
{
	// Update is called once per frame
	void Update ()
	{
		transform.Rotate(0.2f, 0, 0); // 0.2f, 0.2f);
	}
}
