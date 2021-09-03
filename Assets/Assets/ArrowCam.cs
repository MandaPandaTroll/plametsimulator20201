using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowCam : MonoBehaviour
{



  public float speed = 10f;  

 void Update()
 {



     if(speed <= 0f){
         speed = 0f;
     }

     if(Input.GetKey(KeyCode.Plus))
     {
         speed = (speed + 10f);
     }

      if(Input.GetKey(KeyCode.Minus))
     {
         speed = (speed - 10f);
     }

     
     
     if(Input.GetKey(KeyCode.D))
     {
         transform.Translate(new Vector3(speed * Time.deltaTime,0,0));
     }
     if(Input.GetKey(KeyCode.A))
     {
         transform.Translate(new Vector3(-speed * Time.deltaTime,0,0));
     }
     if(Input.GetKey(KeyCode.Period))
     {
         transform.Translate(new Vector3(0,-speed * Time.deltaTime,0));
     }
     if(Input.GetKey(KeyCode.Comma))
     {
         transform.Translate(new Vector3(0,speed * Time.deltaTime,0));
     }
        if(Input.GetKey(KeyCode.S))
     {
         transform.Translate(new Vector3(0,0,-speed * Time.deltaTime));
     }
     if(Input.GetKey(KeyCode.W))
     {
         transform.Translate(new Vector3(0,0,speed * Time.deltaTime));
     }
     if(Input.GetKey(KeyCode.LeftArrow))
     {
         transform.Rotate(new Vector3(0,-speed * Time.deltaTime,0));
     }
         if(Input.GetKey(KeyCode.RightArrow))
     {
         transform.Rotate(new Vector3(0,speed * Time.deltaTime,0));
     }
        if(Input.GetKey(KeyCode.UpArrow))
     {
         transform.Rotate(new Vector3(-speed * Time.deltaTime,0,0));
     }
         if(Input.GetKey(KeyCode.DownArrow))
     {
         transform.Rotate(new Vector3(speed * Time.deltaTime,0,0));
     }
             if(Input.GetKey(KeyCode.E))
     {
         transform.Rotate(new Vector3(0,0,-speed * Time.deltaTime));
     }
         if(Input.GetKey(KeyCode.Q))
     {
         transform.Rotate(new Vector3(0,0,speed * Time.deltaTime));
     }
     
             if(Input.GetKey(KeyCode.R)){
             transform.position = transform.position - transform.position;
        }

 }
}
