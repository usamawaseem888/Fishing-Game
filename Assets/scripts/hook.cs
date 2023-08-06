using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hook : MonoBehaviour
{
    Vector3 newPosition;
    private AudioSource comp;
    public AudioClip cat, anch;
    Player a;
    fisher b;
    // Start is called before the first frame update
    void Start()
    {
        comp=GetComponent<AudioSource>();
        a = GameObject.Find("fisherman").GetComponent<Player>();
        b = GameObject.Find("fisherman2").GetComponent<fisher>();
        newPosition =transform.position;
       
    }

    // Update is called once per frame
    void Update()
    {
        /*Vector3 v;
        if (a.set == true)
        {
            v = new Vector3(70, 0, a.transform.position.z); 
            transform.position = v;
        }
        if (b.set == true)
        {
            v = new Vector3(70, 0, b.transform.position.z);
            transform.position = v;
        }*/
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                newPosition = hit.point;
                transform.position = newPosition;
            }
       

         
    }
   
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("fish")){
            comp.PlayOneShot(cat, 1.0f);

            //collision.transform.position = newPosition;
            //Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("anchovy"))
        {
            comp.PlayOneShot(anch, 1.0f);
        }
    }
}
