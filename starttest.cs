using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starttest : MonoBehaviour
{
    public GameObject camtostart;
    public GameObject test;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") {


            camtostart.SetActive(true);
            test.SetActive(true);
            other.gameObject.SetActive(false);
        }
    }
}
