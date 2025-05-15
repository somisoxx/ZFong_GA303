using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public static SFXManager instance;

    [SerializeField] private AudioSource sFXObject;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;

        }
 
    }

    public void PlaySFXClip(AudioClip audioclip, Transform spawntTransform,float volume)
    {
        AudioSource audioSource = Instantiate(sFXObject, spawntTransform.position, Quaternion.identity);
        audioSource.clip = audioclip;
        audioSource.volume = volume;
        audioSource.Play();
        float clipLength = audioSource.clip.length;
        Destroy(audioSource.gameObject,clipLength);
    }
    
}
