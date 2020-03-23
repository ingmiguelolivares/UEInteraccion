using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterControl : MonoBehaviour
{
    public GameObject HUD;
    // Start is called before the first frame update
    void Start()
    {
        HUD = GameObject.Find("HUD");
    }

    public void SetValue() {
        HUD.GetComponent<HUDtexto>().countervalue += 1;
    }
}
