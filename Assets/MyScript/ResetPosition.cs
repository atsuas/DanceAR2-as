using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    Vector3 originalPos;
    
    void Start()
    {
        originalPos = transform.localPosition;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("AEROPLANEWALL"))
        {
            transform.localPosition = originalPos;
        }
        else if (other.gameObject.CompareTag("CLOUDWALL"))
        {
            transform.localPosition = originalPos;
        }
        
    }
}
