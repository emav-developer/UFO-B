using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrPlayer : MonoBehaviour
{
    [SerializeField]
    float velocitat=3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x, y; // per llegir gamepad
        x = Input.GetAxis("Horizontal");  // llegim moviment horitzontal
        y = Input.GetAxis("Vertical");    // llegim moviment vertical
        // print("Horitzontal: " + x + " / Vertical: " + y);  // mostrem x e y
        transform.Translate(x *Time.deltaTime * velocitat, y*Time.deltaTime*velocitat, 0);

    }
}
