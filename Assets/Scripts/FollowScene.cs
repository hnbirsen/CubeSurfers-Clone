using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScene : MonoBehaviour
{
    public GameObject aimObject;
    public Vector3 distance;

    void Start()
    {
        
    }

    void Update()
    {

    }

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, aimObject.transform.position + distance, Time.deltaTime);
    }
}
