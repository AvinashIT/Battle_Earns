using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick_up : MonoBehaviour
{
    public Transform destin;
    // Start is called before the first frame update
    private void Update()
    {
        if (Input.GetKey(KeyCode.E)) // Change "KeyCode.Space" to the key you want to use
        {
           
            transform.Rotate(Vector3.right * 50f * Time.deltaTime);
        }
    }

    private void OnMouseDown()
    {
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = destin.position;
        this.transform.parent = GameObject.Find("Destination").transform;
      
    }
    private void OnMouseUp()
    {
        this.transform.parent = null;
   
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<BoxCollider>().enabled = false;
    }
}
