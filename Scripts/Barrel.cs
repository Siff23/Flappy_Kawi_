using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    int speed = 10;
   
   //PARA QUE LAS TUBERIAS SE MUEVAN EN HORIZONTAL
    void Update()
    {
        this.transform.Translate(-speed * Time.deltaTime, 0, 0);
    }
}
