using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDtexto : MonoBehaviour
{
    public Text counter;

    public int countervalue;


    // Update is called once per frame
    void Update()
    {
        counter.text = "Clicks: " + countervalue.ToString();
    }
}
