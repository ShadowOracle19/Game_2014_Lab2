using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameControlle : MonoBehaviour
{
    //public TMP_Text SceneLabel;
    public TMP_Text LivesLabel;
    public TMP_Text ScoreLabel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(Input.deviceOrientation)
        {
            case DeviceOrientation.Portrait:
                //SceneLabel.text = "Potrait";
                LivesLabel.rectTransform.anchoredPosition = new Vector2(256.0f, -212.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-332.0f, -212.0f);
                break;

            case DeviceOrientation.LandscapeLeft:
                //SceneLabel.text = "LandscapeLeft";
                LivesLabel.rectTransform.anchoredPosition = new Vector2(416.0f, -128.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-360.0f, -128.0f);
                break;

            case DeviceOrientation.LandscapeRight:
                LivesLabel.rectTransform.anchoredPosition = new Vector2(315.0f, -128.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-476.0f, -128.0f);
                break;

            case DeviceOrientation.Unknown:
                //SceneLabel.text = "Unknown";
                break;
            default:
                //SceneLabel.text = "some other orientation"; 
                break;
        }
            
    }
}
