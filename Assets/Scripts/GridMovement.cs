using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMovement : MonoBehaviour
{

    //we assign these to be equivalent in each direction, so fwd = (x = 0, y = 0, z = 1) and bwd = (x = 0, y = 0, z = -1)
    public Vector3 Fwd, Bwd, Left, Right, Up, Down;
    public Transform hazard, Key;
    Vector3 startPos;
    public bool hasKey;
    
    // Start is called before the first frame update
    void Start() //like setup
    {
        startPos = transform.position; 
        hasKey = false; 
    }

    // Update is called once per frame
    void Update()
    {

        //access the Input class method called GetKeyDown, which takes a KeyCode parameter
        //This will return true when this specific key is pressed down and false when it isn't
        if (Input.GetKeyDown(KeyCode.W)) { 

            
            //this is similar to print or println in processing
            Debug.Log("you pressed w :)");


            //modify the position of the transform of whatever gameobject this is attached to
            //offset it by fwd (move from the current position to the current position plus the value of fwd)
            transform.position += Fwd; 
        }
        
        if (Input.GetKeyDown(KeyCode.Q)) { 
        Debug.Log("you pressed q :)");
        transform.position += Down;
        }
        
        if (Input.GetKeyDown(KeyCode.E)) { 
        Debug.Log("you pressed e :)");
        transform.position += Up;
        }
        
        if (Input.GetKeyDown(KeyCode.A)) { 
        Debug.Log("you pressed a :)");
        transform.position += Left;
        }
        
        if (Input.GetKeyDown(KeyCode.S)) { 
        Debug.Log("you pressed s :)");
        transform.position += Bwd;
        }
        
        if (Input.GetKeyDown(KeyCode.D)) { 
        Debug.Log("you pressed d :)");
        transform.position += Right;
        }
        
        if (hazard.position == transform.position)
            transform.position = startPos;
            
        if (Key.position == transform.position)
            hasKey = true;
        

    }
}

