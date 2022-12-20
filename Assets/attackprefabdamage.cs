using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackprefabdamage : MonoBehaviour
{
    public float timer = 10;
    public float damage = 10;
    GameObject enemy;
    void Start()
    {
       
    }
    public void Update()
    {
        
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Destroy(this.gameObject);
        }
        
    }
    public void OnCollisionEnter(Collision col)
    {
       
        if (col.gameObject.CompareTag("Enemy"))
        {
            //col.transform.GetComponent<enemyHP>().Health;
           
            enemyHP.Health -= damage;
            Destroy(this.gameObject);

        }
            
    }
   

}
