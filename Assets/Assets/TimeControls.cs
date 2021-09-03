using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeControls : MonoBehaviour
{
   public float tScale = 1.0f;
    private float fixedDeltaTime;

void Awake(){
    this.fixedDeltaTime = Time.fixedDeltaTime;
}

    // Update is called once per frame
    void Update()
    {

        if(tScale < 0f){tScale = 0f;}

        if(Input.GetKey(KeyCode.K)){
            tScale = tScale - 0.1f;}

       if(Input.GetKey(KeyCode.L)){
            tScale = tScale + 0.1f;}

        Time.timeScale = tScale;
        Time.fixedDeltaTime = this.fixedDeltaTime * Time.timeScale;
        
    }
}
