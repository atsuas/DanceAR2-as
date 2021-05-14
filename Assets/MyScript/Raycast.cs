using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class Raycast : MonoBehaviour
{
    private ARRaycastManager m_RaycastManager;

    private List<ARRaycastHit> hitResults = new List<ARRaycastHit>();

    [SerializeField]
    private GameObject playerPrefab;
    
    void Start()
    {
        m_RaycastManager = GetComponent<ARRaycastManager>();
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            //指を動かした時
            if (touch.phase == TouchPhase.Began)
            {
                if (m_RaycastManager.Raycast(touch.position, hitResults, TrackableType.PlaneWithinPolygon))
                {
                    Pose hitPose = hitResults[0].pose;
                    GameObject player = Instantiate(playerPrefab, hitPose.position, hitPose.rotation);
                }
            }
        }
    }
}
