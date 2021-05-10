using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public TextMeshPro mText;
    public float timeRemaining = 2;
    public void BtnPressed(string btnName)
    {
        Debug.Log(btnName);
    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            mText.text = timeRemaining.ToString();
        }
    }
}
