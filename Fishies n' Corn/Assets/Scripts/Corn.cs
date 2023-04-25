using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corn : MonoBehaviour
{
    public Sprite seed;
    public Sprite smallSeedling;
    public Sprite bigSeedling;
    public Sprite fullGrown;
    public GameObject player;
    public GameObject fatherPlot;
    private int timeAtPlantation;
    private bool harvestable;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        timeAtPlantation = (int)(Time.time);
    }

    // Update is called once per frame
    void Update()
    {
        harvestable = false;
        int timeAlive = (int)(Time.time) - timeAtPlantation;
        if (timeAlive < 5)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = seed;
        }
        else if (timeAlive < 10)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = smallSeedling;
        }
        else if (timeAlive < 15)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = bigSeedling;
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = fullGrown;
            harvestable = true;
        }

        if (harvestable && (Vector3.Distance(this.transform.position, player.transform.position) < 5))
        {
            //GameObject.Find("Dancing Plant Lady").GetComponent<MovementController>().corns++;
            MovementController.corns++;
            fatherPlot.GetComponent<Plot>().haveThing = false;
            Destroy(gameObject);
        }
    }
}
