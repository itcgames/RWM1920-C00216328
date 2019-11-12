using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvertToggle : MonoBehaviour {

    Vector2 centrePoint;
    public GameObject Go;
    GravityInvert grav;
    

    void Start()
    {
        centrePoint = GetComponent<Renderer>().bounds.center;
       
        grav = Go.GetComponent<GravityInvert>();
        



    }
    
    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag==("Finish"))
        {
            //Debug.Log("col detected");
            if (other.gameObject.transform.position.x <centrePoint.x)
            {
                GravityInvert.invertVal = (other.gameObject.transform.position.x - centrePoint.x) ;
            }
            else if (other.gameObject.transform.position.x > centrePoint.x)
            {
                GravityInvert.invertVal = ((other.gameObject.transform.position.x - centrePoint.x)) ;
            }
        }
    }
}
