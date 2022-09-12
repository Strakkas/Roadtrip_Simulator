using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheStaticThingy : MonoBehaviour
{

    public static TheStaticThingy instance;

    public float musicValue;
    public float soundValue;

    // ENCAPSULATION
    [SerializeField]
    public float musicVolume { get; private set; } = 0.5f;
    public float m_musicVolume
    {
        get { return musicVolume; }
        set
        {
            if (value < 0)
            {
                Debug.Log("Value must not be lower than 0");
            }
            else if (value > 1)
            {
                Debug.Log("Value must not be higher than 1");
            }
            else
            {
                musicVolume = value;
            }
        }
    }

    [SerializeField]
    public float soundEffectVolume { get; private set; } = 0.5f;
    public float m_soundEffectVolume
    {
        get { return soundEffectVolume; }
        set
        {
            if (value < 0)
            {
                Debug.Log("Value must not be lower than 0");
            }
            else if (value > 1)
            {
                Debug.Log("Value must not be higher than 1");
            }
            else
            {
                soundEffectVolume = value;
            }
        }
    }

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);

        Debug.Log("Volume in this scene is set to: " + musicVolume + soundEffectVolume);
    }

    private void Update()
    {
        musicValue = musicVolume;
        soundValue = soundEffectVolume;
    }


}