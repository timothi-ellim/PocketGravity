using System;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour {

	//from Brackeys (it was broken, never mind)

	//public Sound[] sounds;
	public AudioClip[] clips;
	private AudioSource audioPlay;

	// Use this for initialization
	void Awake () {
		/*
		foreach (Sound s in sounds) 
		{
			//s.source = gameObject.AddComponent<AudioSource> ();
			s.source.clip = s.clip;

			s.source.volume = s.volume;
			s.source.pitch = s.pitch;
		}
*/
		audioPlay = gameObject.AddComponent<AudioSource> ();

	}
	
	public void Play(int clipnumber)
	{
		//Sound choice = Array.Find (sounds, sound => sound.name == name);
		//choice.source.Play ();
		audioPlay.PlayOneShot(clips[clipnumber]);
	}
}
