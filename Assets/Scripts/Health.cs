using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int startingHealth = 100;
    public Slider healthSilder;
    public GameObject ty;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (this.gameObject.CompareTag("bullet")) 
        {
            startingHealth -= 10;
            Debug.Log("...");
        }
    }
    void Update()
    {
        healthSilder.value = startingHealth;
    }
}