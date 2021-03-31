using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRandom : MonoBehaviour
{
    public float cubeSpeed = 20f;

    float directionX;
    float directionY;

    // Start is called before the first frame update
    void Start()
    {
        directionX = Random.Range(-8f, 8f);
        directionY = Random.Range(-4f, 4f);

        /*InvokeRepeating("PrintMag", 1f, 1f);*/

        GetComponent<Rigidbody>().AddForce(new Vector3(directionX, directionY).normalized * cubeSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Rigidbody>().velocity.magnitude < 0.04f)
        {
            /*Debug.Log("FOCED");*/

            directionX = Random.Range(-8f, 8f);
            directionY = Random.Range(-4f, 4f);
            GetComponent<Rigidbody>().AddForce(new Vector3(directionX, directionY).normalized * cubeSpeed);
        }
    }

    void PrintMag()
    {
        Debug.Log("MAG: " + GetComponent<Rigidbody>().velocity.magnitude);
    }
}
