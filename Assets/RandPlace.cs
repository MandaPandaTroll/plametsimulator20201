using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandPlace : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float randX = Random.Range(-250,250);
        float randY = Random.Range(-250,250);
        float randZ = Random.Range(-250,250);
        transform.Translate(new Vector3(randX,randY,randZ));
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
