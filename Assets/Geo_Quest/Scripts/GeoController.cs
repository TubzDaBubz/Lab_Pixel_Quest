using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeoController : MonoBehaviour
{ 
    string variable2 = "Hello ";
    private int firstNum = 3;
    // Start is called before the first frame update
    void Start()
    {
        string variable1 = "World";
        Debug.Log(variable2 + variable1);


    }

    // Update is called once per frame
    private void Update()
    {
        Debug.Log(firstNum++);

        if (Input.GetKeyDown(KeyCode.W)) ;
        transform.position+= new Vector3(0, 5, 0);
    }
}