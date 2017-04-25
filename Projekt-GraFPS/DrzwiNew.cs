using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DrzwiNew : MonoBehaviour
{

    private Animator animator;
    bool doorIsOpen = false;
    public Text otworz;
    public Canvas komunikaty;
    // Use this for initialization
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        doorIsOpen = false;
        obsluzKomunikat(false);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player Enter");
        if (other.tag == "Player")
        {
            obsluzKomunikat(true);
            if (doorIsOpen == false)
            {

                ustawKomunikat(false);
            }
            else
            {

                ustawKomunikat(true);
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log("Player Exit");
        if (other.tag == "Player")
        {
            obsluzKomunikat(false);
        }
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("Player Stay");
        animator = gameObject.GetComponent<Animator>();
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E");

            if (doorIsOpen == false)
            {
                animator.SetTrigger("Otworz");
                doorIsOpen = true;
            }
            else
            {
                animator.SetTrigger("Zamknij");
                doorIsOpen = false;
            }

        }

    }
    private void obsluzKomunikat(bool val)
    {
        komunikaty.enabled = val;

    }

    private void ustawKomunikat(bool val)
    {
        if (otworz != null)
        {
            if (doorIsOpen == false)
            {
                otworz.text = "E aby otworzyć";
            }
            else
            {
                otworz.text = "E aby zamknąć";
            }
        }
    }




}
