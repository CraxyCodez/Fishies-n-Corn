using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InventoryReal : MonoBehaviour
{
    public Text cornBox;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cornBox.text = "" + MovementController.corns;
    }
    public void GoHome()
    {
        SceneManager.LoadScene("Game");
    }
}
