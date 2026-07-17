using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonOpenURL : MonoBehaviour
{
    public string url = "http://unity3d.com/";

    private Button button;


    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();

        button.onClick.AddListener(OpenURL);
    }


    public void OpenURL()
    {
        Application.OpenURL(url);
    }
}
