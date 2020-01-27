using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityInvert : MonoBehaviour {
    private Rigidbody2D Rb;
    public bool isImploded=false;


    Vector2 vec;
    
    void OnTriggerStay2D(Collider2D other)
    {
		if (!isImploded) {
			
			Vector2 temp = new Vector2 (Mathf.Cos (((transform.rotation.eulerAngles.z + 90) * Mathf.PI) / 180), Mathf.Sin (((transform.rotation.eulerAngles.z + 90) * Mathf.PI) / 180));
			Rb = other.gameObject.GetComponent<Rigidbody2D> ();
			vec = (temp * Rb.mass) * 50;
			Rb.AddForce (vec);
		} else {
            
            Rb = other.gameObject.GetComponent<Rigidbody2D>();
            Rb.velocity = Vector2.zero;
            Rb.transform.position = Vector2.MoveTowards
                 (Rb.transform.position,
                  transform.position,
                  10 * Time.deltaTime);
        }
    }

    void OnMouseDown()
    {
        if(isImploded)
        {
            isImploded = false;
        }
        else
        {
            isImploded = true;
        }
    }
}
