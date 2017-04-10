using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Canvas menu;
    //public Button start;
    // Use this for initialization
    void Start()
    {
        //start = start.GetComponents<Button>;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            menu.enabled = !menu.enabled;

        }
    }

    public void PrzyciskStart()
    {
        Application.LoadLevel("Poziom1");
    }

    public void PrzyciskWyjscie()
    {
        Application.Quit();
    }

}
