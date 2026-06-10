using System.Collections;
using UnityEngine;

public class Toster : MonoBehaviour
{
    public GameObject tost;

    bool canspawn = true;

    public Transform bbb;
    public void TosterSpawn()
    {
        if (canspawn)
        {
            canspawn = false;
            StartCoroutine(sp());
        }
    }

    IEnumerator sp()
    {
        GameObject bbbb = Instantiate(tost);
        bbbb.transform.position = bbb.transform.position;
        bbbb.transform.GetComponent<Rigidbody>().AddForce(Vector3.up*10, ForceMode.Impulse);
        yield return new WaitForSeconds(1);
        canspawn = true;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
