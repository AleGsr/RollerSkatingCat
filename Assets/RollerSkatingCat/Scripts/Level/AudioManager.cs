using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource sfxAudioSource, musicAudioSource;

    public static AudioManager Instance { get; private set; } //La instancia actúa como una referencia, {} solo puede ser leida en otros scripts y seteada en este script y no en otro


    private void Awake()
    {
        //Se asegura que solo haya un AudioManager, en caso de haber otro se va a destruir
        if(Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this); //Solo si necesita para cambios de escena
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M)) ToggleMusic();
    }


    public void PlaySound(AudioClip clip)
    {
        sfxAudioSource.PlayOneShot(clip);
    }

    private void ToggleMusic()
    {
        musicAudioSource.mute = !musicAudioSource.mute;
    }
    
}
