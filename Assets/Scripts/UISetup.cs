using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UISetup : MonoBehaviour
{
    void Start()
    {
        GameObject jump = GameObject.Find("Jump");
        GameObject left = GameObject.Find("Left");
        GameObject right = GameObject.Find("Right");

        // Size
        Vector2 buttonSize = new Vector2(Screen.width / 10f, Screen.width / 10f);
        jump.GetComponent<RectTransform>().sizeDelta = buttonSize;
        left.GetComponent<RectTransform>().sizeDelta = buttonSize;
        right.GetComponent<RectTransform>().sizeDelta = buttonSize;

        // Position
        float verticalOffset = Screen.height / 4;
        jump.GetComponent<Transform>().position = new Vector3(Screen.width * 0.9f, verticalOffset, 0);
        right.GetComponent<Transform>().position = new Vector3((Screen.width * 0.2f) + (buttonSize.x / 3.5f), verticalOffset, 0);
        left.GetComponent<Transform>().position = new Vector3(Screen.width * 0.1f, verticalOffset, 0);

        // Font size
        float fontSize = buttonSize.x / 3.5f;
        jump.GetComponentInChildren<TextMeshProUGUI>().fontSize = fontSize;
        left.GetComponentInChildren<TextMeshProUGUI>().fontSize = fontSize;
        right.GetComponentInChildren<TextMeshProUGUI>().fontSize = fontSize;
    }
}
