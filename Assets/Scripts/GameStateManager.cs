using UnityEngine;
using System.Collections;

public class GameStateManager : MonoBehaviour
{
	public static GameObjectPool ObjectPool = new GameObjectPool();
	public static float MinX = -5, MaxX = 5;
	public GameObject asteroid;

	// Update is called once per frame
	void Update ()
	{
		if (Random.value > 0.99f)
		{
			GameObject newAsteroid = ObjectPool.GetOrInstantiate<CurvedAsteroid>(asteroid);
			newAsteroid.transform.position = new Vector3(
				Random.Range(GameStateManager.MinX, GameStateManager.MaxX),
				newAsteroid.transform.position.y,
				-20);

			Debug.Log(string.Format("asteroid created - {0}", newAsteroid.name));
		}
	}
}
