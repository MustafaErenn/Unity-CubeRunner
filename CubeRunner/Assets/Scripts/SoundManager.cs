using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip pickupCoin;
    static AudioSource audioSrc;
    void Start()
    {
        pickupCoin = Resources.Load<AudioClip>("pickupCoin");
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "pickupCoin":
                audioSrc.PlayOneShot(pickupCoin);
                break;

        }
    }
}