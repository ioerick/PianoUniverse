using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piano : MonoBehaviour
{
    public GameObject[] pianoKeys;

    // Start is called before the first frame update
    void Start()
    {
        pianoKeys = GameObject.FindGameObjectsWithTag("pianoKey");
        
        for(int i = 0; i < pianoKeys.Length; i++)
        {
            Debug.Log("key number "+i+" is named "+pianoKeys[i].name);
        }
    }

    void OnMouseDown ()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
