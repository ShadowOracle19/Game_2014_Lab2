using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestButtonBehaviour : MonoBehaviour
{
    public TMP_Text LivesLabel;
    public TMP_Text ScoreLabel;
    //public TMP_Text SceneLabel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Event Handler for the StartButton_Pressed Event
    public void OnTestButtonPressed()
    {
        Debug.Log("TestButton Pressed");
        //SceneLabel.text = "Test";
        LivesLabel.rectTransform.anchoredPosition = new Vector2(416.0f, -128.0f);
        ScoreLabel.rectTransform.anchoredPosition = new Vector2(-360.0f, -128.0f);
    }
}
