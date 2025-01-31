using UnityEngine;
using System.Collections;

public class AudioDestructBehaviour : MonoBehaviour
{
	// reference to an AudioSource component
	private AudioSource audioSource;

	//----------------------
	void Start()
	{
		// cache reference to the AudioSource component in parent GameObject
		audioSource = GetComponent<AudioSource>();
	}

	//----------------------
	private void Update()
	{
		// as soon as sound is NOT playing then destoy the parent GameObject
		if( !audioSource.isPlaying )
			Destroy(gameObject);
	}
}
