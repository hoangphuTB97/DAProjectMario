using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Transform nhanvat;
    // Start is called before the first frame update
    void Start()
    {
         nhanvat = GameObject.Find("Mario").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cam = transform.position;
        cam.x = nhanvat.position.x;
        transform.position = cam;
    }
}
