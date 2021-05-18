using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveupPlayer : MonoBehaviour
{
    private float speed = 0.1f;

    void Update()
    {
        if (transform.localPosition.y < 0f)
        {
            transform.localPosition += transform.up * speed * Time.deltaTime;
        }
    }
}
