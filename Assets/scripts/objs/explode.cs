using UnityEngine;

public class explode : MonoBehaviour
{
    [SerializeField] AudioSource Audio;
    [SerializeField] AudioClip sound;
    private void explosiondone()
    {
        Destroy(gameObject);
    }

    private void Playaudio()
    {
        Audio.PlayOneShot(sound);
    }
}
