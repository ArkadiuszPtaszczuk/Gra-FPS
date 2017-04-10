using UnityEngine;
using System.Collections;


public class Zdrowie : MonoBehaviour
{


    public float zdrowie = 100.0f;
    public void otrzymaneObrazenia(float obrazenia)
    {

        zdrowie -= obrazenia;

        if (zdrowie <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }

    public bool czyMartwy()
    {
        if (zdrowie <= 0)
        {
            return true;
        }
        return false;
    }

}
