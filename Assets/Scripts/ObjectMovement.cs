using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    // public float speed;
    // public Vector3 direction;
    //public bool isRotation;
    public enum MovementType {
        Rotation,
        Translation
    }
    //public ObjectMovement.MovementType type;
    //public MovementType movementType;
    [System.Serializable]
    public struct Movement {
        public MovementType type;
        public float speed;
        public Vector3 direction;
        public Space space;
    }
   
    public List<Movement> movements;
    //public Movement mov;


    // Start is called before the first frame update
    void Start()
    {
        // 
    }

    // Update is called once per frame
    void Update()
    {   
        foreach(Movement mov in movements) {

            

            if (mov.type == MovementType.Rotation) {
                transform.Rotate(mov.direction.normalized *mov.speed*Time.deltaTime, mov.space );
            } else if (mov.type == MovementType.Translation) {
                transform.Translate(mov.direction.normalized*mov.speed*Time.deltaTime, mov.space);
            }
    

        // // switch(mov.Type) {
        // //     cases MovementType.Rotation:
        // //         tranform.Rotate(mov.direction.normalized* mov.speed * Time.deltaTime,Space.World)
        // //         break;
        // //     Case MovementTiype.Translation:
        // //         Translate(mov.direction.normalized* mov.speed * Time.deltaTime,Space.World)
        // //         break;
        // // }
    }   
    }
}
