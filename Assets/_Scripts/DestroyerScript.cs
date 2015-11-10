using UnityEngine;
using System.Collections;

public class DestroyerScript : MonoBehaviour {

	public GameObject spawn;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "GroundCheck") {
			//ignore
			return;
		}

		if (other.tag == "Player") 
		{
			other.gameObject.GetComponentInParent<PlayerControl>().Die();
			return;
		}

		if (other.gameObject.transform.parent) {
			Destroy (other.gameObject.transform.parent.gameObject);
		} else {
			Destroy(other.gameObject);
		}

		if(spawn)
		spawn.GetComponent<SpawnScript>().Spawn ();
	}
}
