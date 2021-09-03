using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassTweak : MonoBehaviour
{
public float varMass;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        varMass = rb.mass;
    }

    // Update is called once per frame
    void Update()
    {
        

        if(Input.GetKey(KeyCode.X))
     {
         varMass = varMass + 1.0f;
     }

            if(Input.GetKey(KeyCode.Z))
     {
         varMass = varMass - 1.0f;
     }
        rb.mass = varMass;
    }
}
