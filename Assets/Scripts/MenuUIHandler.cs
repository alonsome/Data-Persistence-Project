using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine.UI;

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public NameReader NameReader;
    // Start is called before the first frame update
    void Start()
    {
        NameReader = new NameReader();
        NameReader.SubmitName(MainManager.Instance.PlayerName);
        //playerInput.onEndEdit += 
        //NameReader.SubmitName += PlayerNameInput;
    }
    public void PlayerNameInput(string name)
    {

    }
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
       
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
    Application.Quit();
#endif
    }
   
}
