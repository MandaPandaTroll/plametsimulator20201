         using UnityEngine;
         using UnityEngine.UI;
        
         public class customText : MonoBehaviour
         {
             Text m_Text;
             RectTransform m_RectTransform;
            ArrowCam m_ArrowCam;
                MassTweak m_MassTweak;
             

             
             void Start()
             {
                 //Fetch the Text, ArrowCam and RectTransform components from the GameObject
                 m_Text = GetComponent<Text>();
                 m_RectTransform = GetComponent<RectTransform>();
                m_ArrowCam = GameObject.Find("Freecam").GetComponent<ArrowCam>();
                m_MassTweak = GameObject.Find("Singularity").GetComponent<MassTweak>();
                

             }
        
             void Update()
             {
                 
                 float varSpeed = m_ArrowCam.speed;
                float displayMass = m_MassTweak.varMass;
                string stringMass = displayMass.ToString();
               string stringSpeed = varSpeed.ToString();
        
                 //Change the m_Text text to the message below
                 m_Text.text = "Speed = " + stringSpeed + "\n" + "Singularity mass = " + stringMass;
                 
                 
                    
                 
             }
        
            
         }