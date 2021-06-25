using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float speed;
    public Vector3 direction;

    //public bool isRotation;
    

    public enum MovementType {
        Rotation,
        Translation
    }
    //public ObjectMovement.MovementType type;
    public MovementType movementType;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (movementType == MovementType.Rotation) {
            transform.Rotate(direction*speed*Time.deltaTime, Space.World);
        } else if (movementType == MovementType.Translation) {
            transform.Translate(direction*speed*Time.deltaTime, Space.World);
        }

        // // switch(movementType) {
        // //     cases MovementType.Rotation:
        // //         Rotate
        // //         break;
        // //     Case MovementTiype.Translation:
        // //         Translate
        // //         break;
        // // }
        
    }
}