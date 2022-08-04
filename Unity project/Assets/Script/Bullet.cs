using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   
    public int Damage;

    
    void Update()
    {
        transform.Translate(Vector3.forward * 0.1f);
        
    }


   
    void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Cube")
        {          
            Destroy(gameObject);                    
        }
        else if(other.tag == "Wall")
        {
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject, 1.0f);
        }
    }
   
}
