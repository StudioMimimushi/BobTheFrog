using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject obj;
	public float distOffset = 1f;
	public float randDistOffset = 0.2f;

	private static float currentPosX = 0;
	private GameController m_Control;

	// Use this for initialization
	void Start () {
		m_Control = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ();
		currentPosX = transform.position.x;

		Spawn ();
		Spawn ();
		Spawn ();
		Spawn ();
		Spawn ();
	}

	public void Spawn () 
	{
		Instantiate (obj, new Vector3(currentPosX, transform.position.y), Quaternion.identity);
		float dist = (distOffset * m_Control.getGameSpeed ());
		Debug.Log (dist);
		currentPosX += (dist + Random.Range(0, randDistOffset));
	}
}
