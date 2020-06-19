using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomSound : MonoBehaviour
{
	private AudioSource audioSource;

	[SerializeField]
	private List<AudioClip> SoundClips = new List<AudioClip>();

	[SerializeField]
	private float soundTimerDelay = 3.0f;

	private float soundTimer;
	void Start()
    {
		audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
		soundTimer = soundTimer + Time.deltaTime;

		if(soundTimer >= soundTimerDelay)
		{
			//타이머 초기화
			soundTimer = 0;
			//랜덤사운드 생성
			AudioClip randomSound = SoundClips[Random.Range(0, SoundClips.Count)];

			audioSource.PlayOneShot(randomSound);
		}
    }
}
