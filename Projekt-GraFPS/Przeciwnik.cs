using UnityEngine;
using System.Collections;

public class Przeciwnik : MonoBehaviour
{

    public float PredkoscObrotu;
    public float PredkoscRuchu;
    public float PoleWidzenia;
    public float OdlegloscOdGracza;
    public Transform Player;
    float dystans;
    public Animator AnimatorZombie;
    float Timer;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Timer += Time.deltaTime;
        dystans = Vector3.Distance(Player.position, transform.position);

        if (dystans <= PoleWidzenia && !isDead())
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(transform.position - Player.position), PredkoscObrotu = Time.deltaTime);
            if (dystans >= OdlegloscOdGracza && !isDead())
            {
                AnimatorZombie.SetBool("Idzie", true);
                transform.position += -transform.forward * PredkoscRuchu * Time.deltaTime;
            }

        }
        else
        {
            AnimatorZombie.SetBool("Idzie", false);
        }


    }

    bool isDead()
    {
        Zdrowie h = gameObject.GetComponent<Zdrowie>();
        if (h != null)
        {
            return h.czyMartwy();
        }
        return false;
    }

}
