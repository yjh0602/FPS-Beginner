using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    public int Hp;
    public Bullet bullet;

    
    void Start()
    {
        // gameObject.GetComponent<가져올 컴포넌트>();

        gameObject.GetComponent<Transform>().localScale = Vector3.one * 4;
   
    }

    // Update is called once per frame
    void Update()
    {
        Die();
    }
    void Die()
    {
        if (Hp < 0)
        {
            Destroy(gameObject);
        }
        else
            return;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bullet")
        {
            Hp -= bullet.Damage;
        }
    }

}
   
