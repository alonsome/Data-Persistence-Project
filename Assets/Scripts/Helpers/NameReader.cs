using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NameReader : MonoBehaviour
{
    public TMP_InputField playerInput;
    // Start is called before the first frame update
    void Start()
    {
        playerInput.onEndEdit.AddListener(SubmitName);
    }

    public void SubmitName(string inputText)
    {
        Debug.Log("Player Name : "+inputText);
    }
}
