using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour {
    public AudioClip[] footstepSounds;
    public float stepInterval;

    private AudioSource audioSource;

    private float lastStepTime;

    void Start () {
        audioSource = GetComponent<AudioSource>();
    }

    void Update () {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0) {
            if (Time.time > lastStepTime + stepInterval) {
                PlayFootstepSound();
                lastStepTime = Time.time;
            }
        }
    }

    void PlayFootstepSound () {
        int randomIndex = Random.Range(0, footstepSounds.Length);
        audioSource.clip = footstepSounds[randomIndex];
        audioSource.Play();
    }
}
