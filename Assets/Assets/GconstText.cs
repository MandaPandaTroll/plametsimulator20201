         using UnityEngine;
         using UnityEngine.UI;
        
         public class GconstText : MonoBehaviour
         {
             Text m_Text;
             RectTransform m_RectTransform;
            Attractor m_Attractor;
                
             

             
             void Start()
             {
                 //Fetch the Text, ArrowCam and RectTransform components from the GameObject
                 m_Text = GetComponent<Text>();
                 m_RectTransform = GetComponent<RectTransform>();
                m_Attractor = GameObject.Find("Plamete").GetComponent<Attractor>();
                

             }
        
             void Update()
             {
                 
                 float gravConst = m_Attractor.G;
                
                
               string stringGravConst = gravConst.ToString();
        
                 //Change the m_Text text to the message below
                 m_Text.text = "G = " + stringGravConst;
                 
                 
                    
                 
             }
        
            
         }