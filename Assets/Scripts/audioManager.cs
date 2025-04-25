using UnityEngine;

public class audioManager : MonoBehaviour
{
    public AudioClip birds;
    public AudioClip music;
    public AudioClip storm;
    public AudioClip tense;

    private void Start()
    {
        int soundChoice = PlayerPrefs.GetInt("soundChoice", 0);
        AudioSource audio = GetComponent<AudioSource>();

        switch (soundChoice)
        {
            case 0: audio.clip = birds; break;
            case 1: audio.clip = music; break;
            case 2: audio.clip = storm; break;
            case 3: audio.clip = tense; break;
            default: audio.clip = birds; break;
        }

        audio.loop = true;
        audio.Play();
    }
}
