using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public bool gameOver = false;
    public bool hasPowerup = false;

    private int powerupDuration = 3;

    public float turnSpeed = 10;
    private float turnAngle;
    private float sideBounds = 14;

    [SerializeField]
    private GameObject newGame;
    [SerializeField]
    private GameObject backToMenu;
    [SerializeField]
    private GameObject powerupIndicator;

    void Update()
    {
        // ABSTRACTION

        MovePlayer();
        ConstrainPlayerPosition();

        if (gameOver == true)
        {
            newGame.gameObject.SetActive(true);
            backToMenu.gameObject.SetActive(true);
        }

    }

    public void PlayerGotPowerup()
    {
        Debug.Log("Player got the powerup");

        turnSpeed = 14;
        StartCoroutine(PowerupDuration());
        powerupIndicator.gameObject.SetActive(true);
    }
    IEnumerator PowerupDuration()
    {
        yield return new WaitForSeconds(powerupDuration);
        powerupIndicator.gameObject.SetActive(false);
        turnSpeed = 10;
        hasPowerup = false;
    }


        // thats for moving the player
        void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        if (gameOver == false)
        {
            transform.Translate(Vector3.right * turnSpeed * horizontalInput * Time.deltaTime);
        }
    
    }

    // this is to not let them crash into bariers
    void ConstrainPlayerPosition()
    {
        if (transform.position.x < -sideBounds)
        {
            transform.position = new Vector3(-sideBounds, transform.position.y, transform.position.z);
        }
        if (transform.position.x > sideBounds)
        {
            transform.position = new Vector3(sideBounds, transform.position.y, transform.position.z);
        }
    }
}
