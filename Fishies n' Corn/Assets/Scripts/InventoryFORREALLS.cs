using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryFORREALLS : MonoBehaviour
{
    public GameObject panel;
    public bool togle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("e"))
        {
            togle = !togle;
            panel.gameObject.SetActive(togle);
            Debug.Log(togle);
        }
    }
}
