using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakBoxScript : MonoBehaviour
{

    public GameObject breakedBox;
    GameObject playerObject;

    void Start()
    {
        playerObject = GameObject.Find("YBot");
    }

    public void Break()
    {
        GameObject breaked = Instantiate(breakedBox, transform.position, transform.rotation);
        Rigidbody[] rbs = breaked.GetComponentsInChildren<Rigidbody>();
        foreach(Rigidbody rb in rbs)
        {
            rb.AddExplosionForce(150, transform.position, 30);
        }
        Destroy(gameObject);

        playerObject.GetComponent<PlayerStats>().IncreasePoints();
        playerObject.GetComponent<PlayerStats>().BoxHit();

    }
}
