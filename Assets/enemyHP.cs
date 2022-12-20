using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHP : MonoBehaviour
{
    public static float Health = 100;
    public void Update()
    {
        if(Health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
