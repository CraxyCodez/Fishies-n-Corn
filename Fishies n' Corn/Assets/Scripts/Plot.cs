using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Plot : MonoBehaviour
{
    public GameObject player;
    public GameObject targetPrefab;
    private GameObject thing;
    public bool haveThing = false;

    private void Awake()
    {
        player = GameObject.Find("Dancing Plant Lady");
    }

    private void OnMouseDown()
    {
        if(player.GetComponent<MovementController>().selectedPlanter == "corn" && !haveThing)
        {
            Vector3 pos = new Vector3(transform.position.x, transform.position.y, -2);
            thing = Instantiate(targetPrefab, pos, Quaternion.identity);
            thing.GetComponent<Corn>().player = player;
            thing.GetComponent<Corn>().fatherPlot = this.gameObject;
            DontDestroyOnLoad(thing);
            
            haveThing = true;

        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
