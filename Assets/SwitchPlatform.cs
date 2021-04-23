using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPlatform : MonoBehaviour
{
    public GameObject vr;
    public GameObject pc;
    // Start is called before the first frame update
    void Start()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            vr.SetActive(true);
            pc.SetActive(false);
        }
        else
        {
            vr.SetActive(false);
            pc.SetActive(true);
            Debug.Log("In PC mode");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
