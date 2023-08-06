using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fisher : MonoBehaviour
{
    float speed = 15f;
    Vector3 vv;
    public bool set = false;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (set==true)
        {
            float horiz = Input.GetAxis("Horizontal");
            float ver = Input.GetAxis("Vertical");


            // transform.Translate(Vector3.forward * ver * speed * Time.deltaTime);
            transform.Translate(Vector3.left * ver * speed * Time.deltaTime);
            if (horiz < 0)
            {
                transform.rotation = Quaternion.Euler(0, 270, 0);
            }
            else if (horiz > 0)
            {
                transform.rotation = Quaternion.Euler(0, 90, 0);
            }
            boundary();
            
        }
       
    }
    void boundary()
    {

        if (transform.position.x > 50)
        {
            transform.position = new Vector3(50, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -5.5)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -5.5f);

        }
        if (transform.position.z > 13.9)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 13.9f);

        }
    }
    
}
