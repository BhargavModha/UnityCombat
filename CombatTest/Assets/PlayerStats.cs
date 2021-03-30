using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public float playerHealth = 100f;
    public int playerSpecial = 100;

    public Text healthText;
    public Text specialText;
    public Text scoreText;

    int gamePoints = 5;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("HealthLoss", 1f, 1f);
        scoreText.text = gamePoints + " Boxes Left";
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health : " + playerHealth;
        specialText.text = "Special : " + playerSpecial;

    }

    void HealthLoss()
    {
        playerHealth -= 1f;
    }

    public void IncreasePoints()
    {
        gamePoints -= 1;
        scoreText.text = gamePoints + " Boxes Left";
        Debug.Log("increased");
    }
}
