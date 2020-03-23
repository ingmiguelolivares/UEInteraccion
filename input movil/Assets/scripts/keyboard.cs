using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keyboard : MonoBehaviour
{

    public Text kText;


    void Start()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default, false, false, true);
        }

    }
    // Update is called once per frame
    void Update()
    {
        


        foreach (KeyCode vKey in System.Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKey(vKey)) kText.text = "la tecla " + vKey.ToString() + " esta oprimida";


            if (Input.GetKeyUp(vKey)) kText.text = "la tecla " + vKey.ToString() + " se dejó de oprimir";



        }

}
}
