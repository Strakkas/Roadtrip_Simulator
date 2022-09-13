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

    [SerializeField]
    private AudioClip buttonClick;
    private AudioSource clickSource;

    [SerializeField]
    private AudioSource musicSource;

    private void Start()
    {
        theStaticThingy = GameObject.Find("The Static Thingy");

        clickSource = GetComponent<AudioSource>();

        musicSource.volume = theStaticThingy.GetComponent<TheStaticThingy>().musicVolume;
        clickSource.volume = theStaticThingy.GetComponent<TheStaticThingy>().soundEffectVolume;


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
        ChangeMusicVolume();
        ChangeSoundVolume();
        clickSource.PlayOneShot(buttonClick);
        StartCoroutine(LoadingMenuScene());
    }
    IEnumerator LoadingMenuScene()
    {
        yield return new WaitForSeconds(0.1f);
        theStaticThingy.GetComponent<TheStaticThingy>().m_musicVolume = musicVolume;
        theStaticThingy.GetComponent<TheStaticThingy>().m_soundEffectVolume = soundEffectVolume;
        Debug.Log("Volume was saved with values of " + musicVolume + soundEffectVolume);
        SceneManager.LoadScene(0);
    }

}
