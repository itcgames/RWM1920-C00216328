using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObj : MonoBehaviour
{
    public float speed = 10;
    

    // Update is called once per frame
    void Update()
    {  
        if (Input.GetKey("d"))
        {
            rotate();
        } 
        
    }

    public void rotate()
    {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }

    public void rotate90()
    {
        transform.Rotate(0, 0, 180);
    }
    public void setSpeed(float t_speed)
    {
        speed = t_speed;
    }
}