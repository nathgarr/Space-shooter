using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSound : MonoBehaviour
{
    [SerializeField]
    private AudioSource source;

    [SerializeField]
    private AudioClip MusicToPlay;

    [SerializeField]
    private AudioClip SoundToPlay;
    // Start is called before the first frame update
    void Start()
    {
        source.clip= MusicToPlay;
        source.loop= true;
        source.volume = 0.1f;
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            source.PlayOneShot(SoundToPlay);
        }
    }
}
