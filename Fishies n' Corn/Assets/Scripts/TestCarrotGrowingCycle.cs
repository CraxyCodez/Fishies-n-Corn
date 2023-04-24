using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCarrotGrowingCycle : MonoBehaviour
{
    public int timeAtPlantation;
    public float timeOfGrowth = 1.0f;
    public float numOfStages = 1.0f;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        timeAtPlantation = (int) (Time.time);
        //Debug.Log("Time test plant started: " + timeAtPlantation);
    }

    void Update()
    {
        //if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.D))
        //{
        //    animator.SetInteger("AnimState", (animator.GetInteger("AnimState") + 1) % 3);
        //}

        //if ((Time.time + timeAtPlantation) == 20.0)
        //{
        //    animator.SetInteger("AnimState", (animator.GetInteger("AnimState") + 1));
        //}
        //else if ((Time.time + timeAtPlantation) == 40.0)
        //{
        //    animator.SetInteger("AnimState", (animator.GetInteger("AnimState") + 1) % 3);
        //}
        //else if((Time.time + timeAtPlantation) == 60.0)
        //Debug.Log((int)(Time.time) + ", Time at planted: " + timeAtPlantation);

        //if((int) (Time.time + timeAtPlantation) % (timeOfGrowth/numOfStages) == 20)
        //{
        //    Debug.Log("HEROIHS");
        //    while ((int)(Time.time + timeAtPlantation) % (timeOfGrowth / numOfStages) == 0) { }
        //    animator.SetInteger("AnimState", (animator.GetInteger("AnimState") + 1));
        //    Debug.Log("Plant grew one stage at time: " + Time.time);
        //}
        //animator.SetInteger("AnimState", (int)((Time.time + timeAtPlantation) % (timeOfGrowth / numOfStages)));
        if (animator.GetInteger("AnimState") != (numOfStages-1))
        {
            animator.SetInteger("AnimState", (int)((Time.time + timeAtPlantation) / (timeOfGrowth / numOfStages)));
        }
    }
}
