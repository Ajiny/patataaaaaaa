using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potatosackUpdate : MonoBehaviour
{
    public static potatosackUpdate potatosackUpdateInstance;
    public Sprite sp0, sp1, sp2, sp3, sp4;

    void Update()
    {
        if(GlobalBehavior.GlobalBehaviorInstance.count == 5){
            GetComponent<SpriteRenderer>().sprite = sp1;
        }
        if(GlobalBehavior.GlobalBehaviorInstance.count == 10){
            GetComponent<SpriteRenderer>().sprite = sp2;
        }
        if(GlobalBehavior.GlobalBehaviorInstance.count == 15){
            GetComponent<SpriteRenderer>().sprite = sp3;
        }
        if(GlobalBehavior.GlobalBehaviorInstance.count == 20){
            GetComponent<SpriteRenderer>().sprite = sp4;
        }

     
        
    } 
}
