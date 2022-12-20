using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questtrigger : MonoBehaviour
{
    public GameObject questBord;
    public GameObject plaYer;
    
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("questbord"))
        {
            if (Input.GetKeyUp(KeyCode.F))
            { 
                questBord.SetActive(true);
                plaYer.SetActive(false);    
            }
        }
        
    }
}
