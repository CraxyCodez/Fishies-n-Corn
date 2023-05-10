using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InventoryReal : MonoBehaviour
{
    public Text cornBox;
    public Text tomatoBox;

    // Start is called before the first frame update
    void Start()
    {
        // considering removing the inventory scene and replacing with inventory UI...

        // ui not working, text and images not appearing
    }

    // Update is called once per frame
    void Update()
    {
        cornBox.text = "" + MovementController.corns;
        tomatoBox.text = "" + MovementController.tomatos;
    }
    public void GoHome()
    {
        SceneManager.LoadScene("Game");
    }
}
