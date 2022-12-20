using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerquestbordback : MonoBehaviour
{ 
    public GameObject questBord;
    public GameObject plaYer;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("questbord"))
        {
            if (Input.GetKeyUp(KeyCode.Escape))
            {
                questBord.SetActive(false);
                plaYer.SetActive(true);
            }
        }
            
    }
}

