using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject palyer;
    private Vector3 offset;
    
    void Start()
    {
        offset = transform.position - palyer.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = palyer.transform.position + offset;
    }


    // public Transform target;
    
    // void Update ()
    // {
    //     transform.LookAt(target);
    // }
}
