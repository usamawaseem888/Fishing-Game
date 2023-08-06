using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using TMPro;
using UnityEngine;

public class fish : MonoBehaviour
{
  
    Player a;
    fisher b;
    public float speed = 15f;
    float yr;
    float zr = 3.8f;
    bool move=true;
    private Rigidbody rb;
    
  
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
        a = GameObject.Find("fisherman").GetComponent<Player>();
        b = GameObject.Find("fisherman2").GetComponent<fisher>();
        
       
    }
    

    // Update is called once per frame
    void Update()
    {
       
        if (move==true)
        {
            
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            if (transform.position.x < 70)
            {
                transform.position = new Vector3(70, 0, 0);
                yr = 180;
                transform.rotation = Quaternion.Euler(transform.rotation.x, yr, transform.rotation.z);
            }
            if (transform.position.x > 110)
            {
                transform.position = new Vector3(110, 0, 0);
                yr = 0;
                transform.rotation = Quaternion.Euler(transform.rotation.x, yr, transform.rotation.z);
            }

           
        }
       
        //StartCoroutine(po());
    }
    private void OnCollisionEnter(Collision collision)
    {
        Vector3 v = new Vector3(29, 10, zr);
        zr += 1;
        if (collision.gameObject.CompareTag("hook"))
        {
            Debug.Log("fish touched");
            move = false;
            transform.position = v;
            transform.localScale -=new Vector3(3,3,3);
            transform.gameObject.isStatic = true;
            rb.useGravity = true;
            //transform.Translate(Vector3(0,0,0));
            if (transform.CompareTag("anchovy"))
            {

                a.set = false;
                b.set = true;
               
                
            }
        }
       
    }
    
    
    private IEnumerator po()
    {
        yield return new WaitForSeconds(5);  
       // Destroy(gameObject);    
    }
}
