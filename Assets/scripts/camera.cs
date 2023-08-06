using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class camera : MonoBehaviour
{
   // public Vector3 v;
    Player a;
    fisher b;

    // Start is called before the first frame update
    void Start()
    {
        a = GameObject.Find("fisherman").GetComponent<Player>();
        b = GameObject.Find("fisherman2").GetComponent<fisher>();
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        Vector3 v;
        if (a.set == true)
        {
            v = new Vector3(40.95f, 9.3f, a.transform.position.z);
            transform.position = v;
            
            transform.rotation=a.transform.rotation;

        }
        if (b.set == true)
        {
            v = new Vector3(40.95f, 9.3f, b.transform.position.z);
            transform.position = v;
            transform.rotation=b.transform.rotation;    
        }

    }
}
