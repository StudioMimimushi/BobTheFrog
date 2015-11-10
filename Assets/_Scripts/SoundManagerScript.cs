using UnityEngine;
using System.Collections;

public class SoundManagerScript : MonoBehaviour {

	private static SoundManagerScript soundManagerInstance = null;
	private AudioSource audioSrc;
	public AudioClip BGM_main;
	public AudioClip BGM_leader;
	public AudioClip button;
	public AudioClip jump;
	public AudioClip land;
	public AudioClip splash;
	public AudioClip dead;

	public static SoundManagerScript Instance {
		get { return soundManagerInstance; }
	}

	void Awake () {
		if (soundManagerInstance != null && soundManagerInstance != this) 
		{
			Destroy(this.gameObject);
			return;
		} 
		else 
		{
			soundManagerInstance = this;
		}
		DontDestroyOnLoad(this.gameObject);
	}

	void Start()
	{
		audioSrc = GetComponentInChildren<AudioSource> ();
		audioSrc.clip = BGM_main;
		audioSrc.Play (0);

	}

	public void changeClip(AudioClip clip)
	{
		audioSrc.clip = clip;
		audioSrc.Play (0);
	}

	public void playButtonEffect()
	{
		audioSrc.PlayOneShot (button);
	}

	public void playEffect(AudioClip clip)
	{
		audioSrc.PlayOneShot (clip);
	}
}
