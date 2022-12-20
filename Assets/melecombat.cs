using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class melecombat : MonoBehaviour
{
    
    public GameObject attackprefab;
    

    bool firstattack = false;
    bool secondattack = false;
    bool thirdattack = false;

    public float timer;
    public void Update()
    {
        timer -= Time.deltaTime;
        if (Input.GetMouseButtonUp(0))
        {
            Instantiate(attackprefab, transform.position + (transform.forward * 0.9f), transform.rotation);
            secondattack = true;
            timer = 1;
            if (timer <= 0);
        }
        if(secondattack == true && Input.GetMouseButtonUp(0))
        {
            Instantiate(attackprefab, transform.position + (transform.forward * 0.9f), transform.rotation);
            thirdattack = true;
        }
        if (thirdattack == true && Input.GetMouseButtonUp(0))
        {
            Instantiate(attackprefab, transform.position + (transform.forward * 0.9f), transform.rotation);
            firstattack = true;
        }
    }
}
