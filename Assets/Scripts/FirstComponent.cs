using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstComponent : MonoBehaviour
{
    public float rotationSpeed;
    public bool reverse;

    public Vector3 rotationAxis;
    public string myString;

    public char[] myArray;

    public List<int> MyList;

    
    void Start() {
        Debug.Log("inside the start method");
    }
    void Update() {
        float rotation = rotationSpeed * Time.deltaTime;
        //Debug.Log("into the update");
        if (reverse) {
            rotation *=-1;
        }

        // rotationAxis = new Vector3(0,1,0);

        transform.Rotate(rotation * rotationAxis, Space.World); 
    } 
}
