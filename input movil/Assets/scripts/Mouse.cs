using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mouse : MonoBehaviour
{

    public Text kText, MposX, MposY;
    public GameObject particle;
    private Camera cam;


    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {

        MposX.text = Input.mousePosition.x.ToString();
        MposY.text = Input.mousePosition.y.ToString();

        if (Input.GetMouseButton(0)) kText.text = "Botón Izquierdo oprimido";
        if (Input.GetMouseButton(1)) kText.text = "Botón Derecho oprimido";
        if (Input.GetMouseButton(2)) kText.text = "Botón Central oprimido";
        if (Input.GetMouseButtonUp(0)) kText.text = "Botón Izquierdo levantado";
        if (Input.GetMouseButtonUp(1)) kText.text = "Botón Derecho levantado";
        if (Input.GetMouseButtonUp(2)) kText.text = "Botón Central levantado";



        Vector3 point = new Vector3();
        Vector2 mousePos = new Vector2();

        // Get the mouse position from Event.
        // Note that the y position from Event is inverted.
        mousePos.x = Input.mousePosition.x;
        mousePos.y = Input.mousePosition.y;

        point = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane+20));
        Debug.Log(point);

        if (Input.GetMouseButton(0)) Instantiate(particle, point, Quaternion.identity);




    }
}
