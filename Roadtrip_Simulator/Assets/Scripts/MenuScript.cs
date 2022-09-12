using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void LoadGameScene()
    {
        SceneManager.LoadScene(2);
    }
    public void LoadSettingsScene()
    {
        SceneManager.LoadScene(1);
    }
}
