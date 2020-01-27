using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvertToggle : MonoBehaviour {

    Vector2 centrePoint;
    public GameObject Go;
    RotateObj grav;
    

    void Start()
    {
        centrePoint = GetComponent<Renderer>().bounds.center;
       
        grav = Go.GetComponent<RotateObj>();
        



    }
    
    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.tag==("Finish"))
        {
            Debug.Log("col detected");
			if (other.gameObject.transform.position.x < centrePoint.x) {
				grav.speed = (other.gameObject.transform.position.x - centrePoint.x)*10;
			} else if (other.gameObject.transform.position.x > centrePoint.x) {
				grav.speed = ((other.gameObject.transform.position.x - centrePoint.x))*10;
			} else 
			{
				grav.speed = 0;
			}
            grav.rotate();
        }
    }
}
