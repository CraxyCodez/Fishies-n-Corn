using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : MonoBehaviour
{
    public string direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        GameObject thing = GameObject.Find("Dancing Plant Lady");
        thing.GetComponent<MovementController>().selectedPlanter = "tomato";
    }
}
