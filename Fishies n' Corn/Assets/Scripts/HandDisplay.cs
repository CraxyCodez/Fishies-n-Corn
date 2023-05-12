using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandDisplay : MonoBehaviour
{

    public GameObject player;
    public Sprite corn;
    public Sprite tomato;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<MovementController>().selectedPlanter == "blank")
        {
            this.gameObject.SetActive(false);
        }
        else if (player.GetComponent<MovementController>().selectedPlanter == "corn")
        {
            this.gameObject.SetActive(true);
            this.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = corn;
        }
        else if(player.GetComponent<MovementController>().selectedPlanter == "tomato")
        {
            this.gameObject.SetActive(true);
            this.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = tomato;
        }
    }
}
