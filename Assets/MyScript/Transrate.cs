using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transrate : MonoBehaviour
{
    public Vector3 moveObject;
    
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(moveObject * Time.deltaTime);
    }
}
