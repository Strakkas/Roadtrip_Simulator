using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsScript : MonoBehaviour
{
    private GameObject theStaticThingy;

    [SerializeField]
    private float musicVolume;
    [SerializeField]
    private float soundEffectVolume;

    [SerializeField]
    private Slider musicVolumeSlider;
    [SerializeField]
    private Slider soundVolumeSlider;

    private void Start()
    {
        theStaticThingy = GameObject.Find("The Static Thingy");

        soundVolumeSlider.value = theStaticThingy.GetComponent<TheStaticThingy>().soundEffectVolume;
        musicVolumeSlider.value = theStaticThingy.GetComponent<TheStaticThingy>().musicVolume;
    }

    public void ChangeSoundVolume()
    {
        soundEffectVolume = soundVolumeSlider.value;
    }

    public void ChangeMusicVolume()
    {
        musicVolume = musicVolumeSlider.value;
    }
    public void LoadMenuScene()
    {
        theStaticThingy.GetComponent<TheStaticThingy>().m_musicVolume = musicVolume;
        theStaticThingy.GetComponent<TheStaticThingy>().m_soundEffectVolume = soundEffectVolume;
        Debug.Log("Volume was saved with values of " + musicVolume + soundEffectVolume);
        SceneManager.LoadScene(0);

    }

}
