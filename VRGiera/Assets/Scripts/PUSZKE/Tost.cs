using UnityEngine;

public class Tost : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up*2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
