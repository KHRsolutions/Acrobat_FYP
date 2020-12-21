using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class raycasting : MonoBehaviour
{
    public GameObject prefab;
    public GameObject player;
    public Text workshopnumber;
    int posters = 5;
    void Start()
    {
        workshopnumber.text = posters.ToString();
    }

    void Update()
    {
        // Move this object to the position clicked by the mouse.

        if (Input.GetButtonDown("Fire1"))
        {

            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit,40.0f))
            {
                Debug.Log("work");
                posters--;
                workshopnumber.text = posters.ToString();

                GameObject ourprefab=   Instantiate(prefab, hit.point+new Vector3(0,0,0),hit.collider.gameObject.transform.rotation) as GameObject;

                ourprefab.transform.Rotate(0, 0, 0);
              //  if (hit.collider.tag.Equals("cube")) { Debug.Log("Hit"); }

            }
        }
    }
}