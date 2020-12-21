using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class lettercount : MonoBehaviour
{
    string abc;
    public Text inputtext;

    public Text wordcount;
    string fetch;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        fetch = inputtext.text;
       Debug.Log(fetch.Length);
       
        wordcount.text = fetch.Length.ToString();
    }
}
