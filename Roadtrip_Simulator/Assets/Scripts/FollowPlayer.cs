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

    void LateUpdate()
    {
        if (playerController.GetComponent<PlayerController>().gameOver == false)
        {
            transform.position = playerCar.transform.position + offset;
        }
        
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(2);
    }
}
