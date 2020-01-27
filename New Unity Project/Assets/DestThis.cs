using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestThis : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
	{
	if (other.tag == "bullet")
	{
        	Destroy(other.gameObject);
        	Destroy(gameObject);
	}
	}
    // Update is called once per frame
    void Update()
    {
        
    }
}
