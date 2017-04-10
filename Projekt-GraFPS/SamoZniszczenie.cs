using UnityEngine;
using System.Collections;

public class SamoZniszczenie : MonoBehaviour
{
    public float czasZycia = 1f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        czasZycia -= Time.deltaTime;
        if (czasZycia <= 0)
        {
            Destroy(gameObject);
        }
    }
}
