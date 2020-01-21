using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailController : MonoBehaviour

    

{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.name == "Knight")
        {
            other.gameObject.GetComponent<Animator>().SetTrigger("Dead");
        }
    }


}
