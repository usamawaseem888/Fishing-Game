using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject[] fish;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spa", 1f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spa()
    {
        int index = Random.Range(0, fish.Length);
        float xr = Random.Range(70, 110);
        float zr=Random.Range(2.6f,19);
        Vector3 v = new Vector3(xr, 0, zr);
        Instantiate(fish[index], v, fish[index].transform.rotation);
    }
}
