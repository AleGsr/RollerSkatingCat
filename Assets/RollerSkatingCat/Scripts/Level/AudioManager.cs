using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class SceneMusic
{
    public string sceneName;
    public AudioClip musicClip;
}

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource sfxAudioSource;
    [SerializeField] private AudioSource musicAudioSource;
    [SerializeField] private SceneMusic[] sceneMusicList;

    public static AudioManager Instance { get; private set; }

    private void Awake()
    {
        // Singleton pattern para que no se duplique
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
            SceneManager.sceneLoaded += OnSceneLoaded; // Escucha cambios de escena
        }
    }

    private void OnDestroy()
    {
        // Evita que quede suscrito si el objeto se destruye
        SceneManager.sceneLoaded -= OnSceneLoaded;
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

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        foreach (var sceneMusic in sceneMusicList)
        {
            if (sceneMusic.sceneName == scene.name)
            {
                musicAudioSource.clip = sceneMusic.musicClip;
                musicAudioSource.loop = true;
                musicAudioSource.Play();
                return;
            }
        }

        // Si no hay música asignada para la escena actual, se detiene
        musicAudioSource.Stop();
    }
}
