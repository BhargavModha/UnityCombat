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

    int gamePoints = 10;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("HealthLoss", 1f, 1f);
        InvokeRepeating("SpecialGain", 0.5f, 0.5f);

        scoreText.text = gamePoints + " Boxes Left";
        healthSlider.value = playerHealth;
    }

    // Update is called once per frame
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
        else
        {
            Debug.Log("END GAME");
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
            Debug.Log("Next Level");
            Invoke("NextLevel", 2);
        }

        //Debug.Log("increased");
    }

    public void BoxHit()
    {
        if (playerSpecial <= 90)
        {
            playerSpecial += 10;
        }
        else if (playerSpecial>90 && playerSpecial <= 100)
        {
            playerSpecial = 100;
        }

        specialSlider.value = playerSpecial;
    }

    void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
