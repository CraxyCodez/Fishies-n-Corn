using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Corn : MonoBehaviour
{
    /// <summary>
    ///
    ///
    ///
    ///
    ///
    ///
    ///
    ///
    ///
    /// 
    ///                           (never mind this, this is history now)-----NOTE TO SELF ON FRIDAY APRIL 28 ADD THE DICTIONARY CONTAINING ALL THE PLOTS AND THEIR LOCATIONS, SO THAT A CORN CAN FIND IT'S PARENT PLOT--
    ///
    /// 
    ///                           But now, plan is currently to make a pop up ui with plant icon (to save space) and TEXT MESH PRO << needed or it will be blurry.
    ///                           ui will have a backbase, probably covering most of screen, if not all
    ///                           quit button and counting, looking about the same as inventory scene
    ///
    ///
    ///
    ///
    ///
    /// 
    ///
    ///
    ///
    ///
    /// 
    /// </summary>
    public Sprite seed;
    public Sprite smallSeedling;
    public Sprite bigSeedling;
    public Sprite fullGrown;
    public GameObject player;
    public GameObject fatherPlot;
    private GameObject selfSavePlayer;
    private GameObject selfSaveFatherPlot;
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




        // point or aim is to find the Dancing Lady's dictionary, and get the plot associated with the position, so take the corn's position and then find a matching position that leads to the correct plot






        player = GameObject.Find("Dancing Plant Lady");

        
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

        if (harvestable && (Vector3.Distance(this.transform.position, player.transform.position) < 2))
        {
            //GameObject.Find("Dancing Plant Lady").GetComponent<MovementController>().corns++;
            MovementController.corns++;
            player.GetComponent<MovementController>().wealth += 1.0;
            fatherPlot.GetComponent<Plot>().haveThing = false;
            SceneManager.MoveGameObjectToScene(this.gameObject, SceneManager.GetActiveScene());
            Destroy(gameObject);
        }
    }
}
