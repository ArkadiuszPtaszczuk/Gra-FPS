using UnityEngine;
using System.Collections;

public class Strzal : MonoBehaviour
{

    public float zasieg = 100.0f;
    public float czekaj = 2f;
    public float odliczanieDoStrzalu = 0f;
    public GameObject pociskPrefab;
    public GameObject pociskPrefab2;
    public float obrazenia = 50.0f;

    public AudioSource m_AudioSource;
    public AudioClip strzal;
    // Use this for initialization
    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (odliczanieDoStrzalu < czekaj)
        {
            odliczanieDoStrzalu += Time.deltaTime;
        }

        if (Input.GetMouseButton(0) && odliczanieDoStrzalu >= czekaj)
        {
            odliczanieDoStrzalu = 0;
            PlayStrzal();
            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

            RaycastHit hitInfo;


            if (Physics.Raycast(ray, out hitInfo, zasieg))
            {
                Vector3 hitPoint = hitInfo.point;
                GameObject go = hitInfo.collider.gameObject;
                hit(go);

                if (pociskPrefab != null)
                {

                    Instantiate(pociskPrefab, hitPoint, Quaternion.identity);

                }

            }
        }

        if (Input.GetMouseButton(1))
        {


        }
    }


    void hit(GameObject go)
    {

        Zdrowie zdrowie = go.GetComponent<Zdrowie>();

        if (zdrowie != null)
        {

            zdrowie.otrzymaneObrazenia(obrazenia);
        }
    }



    private void PlayStrzal()
    {
        m_AudioSource.clip = strzal;
        m_AudioSource.Play();
    }
}
