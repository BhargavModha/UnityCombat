using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public float playerHealth = 100f;
    public int playerSpecial = 100;

    public Text healthText;
    public Text specialText;
    public Text scoreText;

    public Slider healthSlider;
    public Slider specialSlider;

    public GameObject myManager;

    int gamePoints = 10;

    void Start()
    {
        InvokeRepeating("HealthLoss", 1f, 1f);
        InvokeRepeating("SpecialGain", 0.5f, 0.5f);

        scoreText.text = gamePoints + " Boxes Left";
        healthSlider.value = playerHealth;
    }

    void Update()
    {
        healthText.text = "" + playerHealth;
        specialText.text = "" + playerSpecial;

    }

    void HealthLoss()
    {
        if (playerHealth>0)
        {
            playerHealth -= 1f;
            healthSlider.value = playerHealth;
        }
        
        if(playerHealth<=0)
        {
            myManager.GetComponent<GameManage>().LostLevel();
        }

    }

    void SpecialGain()
    {
        if (playerSpecial<100) { 
            playerSpecial += 1;
            specialSlider.value = playerSpecial;
        }
    }

    public void IncreasePoints()
    {

        gamePoints -= 1;
        scoreText.text = gamePoints + " ";

        if (gamePoints == 1)
        {
            scoreText.text = gamePoints + " ";
        }

        if (gamePoints == 0)
        {
            Invoke("NextLevel", 2);
        }

    }

    public void BoxHit()
    {
        if (playerSpecial <= 85)
        {
            playerSpecial += 15;
        }
        else if (playerSpecial> 85 && playerSpecial <= 100)
        {
            playerSpecial = 100;
        }
        

        if (playerHealth <=95)
        {
            playerHealth += 5;
        }
        else if (playerHealth > 95 && playerHealth <= 100)
        {
            playerHealth = 100;
        }

        specialSlider.value = playerSpecial;
        healthSlider.value = playerHealth;
    }

    void NextLevel()
    {
        myManager.GetComponent<GameManage>().WinLevel();
    }
}
