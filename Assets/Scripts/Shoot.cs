using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    int Speed = 20;
    public Rigidbody Bullet;
    public Transform FPonit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {

            Rigidbody clone;

            clone = (Rigidbody)Instantiate(Bullet, FPonit.position, FPonit.rotation);

            clone.velocity = transform.TransformDirection(Vector3.forward * Speed);
        }
}
}
