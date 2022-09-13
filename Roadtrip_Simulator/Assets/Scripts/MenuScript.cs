using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    private GameObject theStaticThingy;
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
    }

    public void LoadGameScene()
    {
        clickSource.PlayOneShot(buttonClick);
        StartCoroutine(LoadingGameScene());
    }

    IEnumerator LoadingGameScene()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(2);
    }
    public void LoadSettingsScene()
    {
        clickSource.PlayOneShot(buttonClick);
        StartCoroutine(LoadingSettingsScene());
    }

    IEnumerator LoadingSettingsScene()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(1);
    }
}
