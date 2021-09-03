//Based upon Brackeys Gravity-Simulation-Tutorial

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Attractor : MonoBehaviour {



  

	Vector3 uniCenter = new Vector3(0,0,0);
	public float c = 128.0f;
	public float G = 0.67f;
	public static List<Attractor> Attractors;

	public Rigidbody rb;


	void Start(){
		RandNudge();

	}

	void FixedUpdate ()
	{
		foreach (Attractor attractor in Attractors)
		{
			if (attractor != this)
				Attract(attractor);

				// GravConst Tweak
		}
		if(Input.GetKey(KeyCode.I)){
			G = G - 0.01f;
	}

		if(Input.GetKey(KeyCode.O)){
			G = G + 0.01f;
		}

		//Manual random nudge

		if(Input.GetKey(KeyCode.Space)){
			RandNudge();
		}
	}

	void OnEnable ()
	{
		if (Attractors == null)
			Attractors = new List<Attractor>();

		Attractors.Add(this);

    
	}

	void OnDisable ()
	{
		Attractors.Remove(this);
	}

	public void Attract (Attractor objToAttract)
	{
		Rigidbody rbToAttract = objToAttract.rb;

		Vector3 direction = rb.position - rbToAttract.position;
		float distance = direction.magnitude;

		float v = rb.velocity.magnitude;
		float m = rb.mass;
		float v2 = Mathf.Pow(v,2);
		float c2 = Mathf.Pow(c,2);
		float rDiv = Mathf.Pow(1-(v2/c2),1/2);


		
		//pseudorelativism
		if (v > (c/2) && v < c){

			//Relativistic mass
			m = (m + (m/rDiv));


			// Time dilation	
			float dtprime = 1/rDiv;
			v = v - dtprime/2;
			

			
		}
		
	

		
		if (distance == 0f)
			return;
        

		float forceMagnitude = G * (rb.mass * rbToAttract.mass) / Mathf.Pow(distance, 2);
		Vector3 force = direction.normalized * forceMagnitude;


		rbToAttract.AddForce(force);

        



		//Stop escape
       if(distance > 3000){
	   	
		   rb.velocity = -(rb.velocity/10);
	   }

	}

	void RandNudge(){
 float fX = Random.Range(-30f, 30f);
  float fY = Random.Range(-30f, 30f);
 float fZ = Random.Range(-30f, 30);
        Vector3 ranForce = new Vector3(fX, fY, fZ);
		rb.AddForce(ranForce);
	}


}
