using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{

    public GameObject Bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            //Instantiate(복사해서 생성할 게임 오브젝트, 그 오브젝트가 나올 위치, 방향);
            Instantiate(Bullet, transform.position, transform.rotation);
        }     
    }
    
}
