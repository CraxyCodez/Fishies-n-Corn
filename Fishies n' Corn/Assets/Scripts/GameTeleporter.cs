using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameTeleporter : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("2nd level");

        if(Vector3.Distance(this.transform.position, player.transform.position) < 2)
        {
            Debug.Log("3rd level");
            GoInventory();
        }
    }

    void GoInventory()
    {
        SceneManager.LoadScene("Inventory");
    }
    
}
