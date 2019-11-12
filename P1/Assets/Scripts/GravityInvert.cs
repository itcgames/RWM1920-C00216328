using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityInvert : MonoBehaviour {
    public Rigidbody Rb;
    public static double invertVal=1;
    int rounded;
    void OnTriggerStay(Collider other)
    {
        rounded = Mathf.RoundToInt((float)invertVal);
        Rb = other.gameObject.GetComponent<Rigidbody>();
        Rb.AddForce(-rounded*(Physics.gravity) * Rb.mass);
        Debug.Log(invertVal);
    }
}
