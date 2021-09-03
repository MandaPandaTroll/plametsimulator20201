using UnityEngine;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour
{

    Text m_Text;
    RectTransform m_RectTransform;
    TimeControls m_TimeControls;
    
    // Start is called before the first frame update
    void Start()
    {
        m_Text = GetComponent<Text>();
        m_RectTransform = GetComponent<RectTransform>();
        m_TimeControls = GetComponent<TimeControls>();
        m_TimeControls = GameObject.Find("WorldControlBox").GetComponent<TimeControls>();
    
    }

    // Update is called once per frame
    void Update()
    {
        float timeToDisplay = m_TimeControls.tScale;

                       string tScaleString = timeToDisplay.ToString();
        
                 //Change the m_Text text to the message below
                 m_Text.text = "Timescale = " + tScaleString + "x";
    }
}
