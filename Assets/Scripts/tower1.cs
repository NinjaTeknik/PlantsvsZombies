using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tower1 : towermaster
{
  

    private void Awake()
    {
        Dmg =1 ;
        Name = "t1";
        Hp = 5;
        Cost=15;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }

   

    private void OnTriggerStay2D(Collider2D other)
    {
Attack();
        Dead();
        Debug.Log("hit toower");
    }

}
