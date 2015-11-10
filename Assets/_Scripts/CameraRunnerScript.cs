using UnityEngine;
using System.Collections;

public class CameraRunnerScript : MonoBehaviour {

	public Transform player;

	void Update()
	{
		float newX = player.position.x + 1.42f;
		if(newX > transform.position.x)
			transform.position = new Vector3 (newX, 0, -10);
	}
}
