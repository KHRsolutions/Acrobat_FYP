using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mission_start : MonoBehaviour
{
    public GameObject[] itemtoturnon;
    public GameObject[] itemtoturnoff;


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

            Debug.Log("hahahhaa");

            for (int i = 0; i < itemtoturnoff.Length; i++) {

                itemtoturnoff[i].SetActive(true);
            }

            for (int i = 0; i < itemtoturnon.Length; i++)
            {

                itemtoturnon[i].SetActive(false);
            }

        }
    }
}
