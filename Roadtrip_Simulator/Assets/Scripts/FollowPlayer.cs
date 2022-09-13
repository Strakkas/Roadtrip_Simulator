using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FollowPlayer : MonoBehaviour
{
    public GameObject playerCar;
    private Vector3 offset = new Vector3(0, 4, -10);
    [SerializeField]
    private GameObject playerController;

    private GameObject theStaticThingy;

    [SerializeField]
    private AudioSource musicSource;

    [SerializeField]
    private AudioSource carSource;

    [SerializeField]
    private AudioClip clickSound;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        theStaticThingy = GameObject.Find("The Static Thingy");

        audioSource.volume = theStaticThingy.GetComponent<TheStaticThingy>().soundEffectVolume;
        carSource.volume = theStaticThingy.GetComponent<TheStaticThingy>().soundEffectVolume;
        musicSource.volume = theStaticThingy.GetComponent<TheStaticThingy>().musicVolume;
    }

    void LateUpdate()
    {
        if (playerController.GetComponent<PlayerController>().gameOver == false)
        {
            transform.position = playerCar.transform.position + offset;
        }
        
    }

    public void BackToMenu()
    {
        audioSource.PlayOneShot(clickSound);
        StartCoroutine(LoadingMenuScene());
    }
    IEnumerator LoadingMenuScene()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(0);
    }

    public void RestartGame()
    {
        audioSource.PlayOneShot(clickSound);
        StartCoroutine(RestartingGame());
    }
    IEnumerator RestartingGame()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(2);
    }
}
