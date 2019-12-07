using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_test : MonoBehaviour
{
    public Transform cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(new Vector3(0f,1f,0f),new Vector3(0f,1f,0f),3f);
    }
}
