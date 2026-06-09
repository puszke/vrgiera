using UnityEngine;

public class Toster : MonoBehaviour
{
    public GameObject tost;
    public void TosterSpawn()
    {
        GameObject bbbb = Instantiate(tost);
        bbbb.transform.position = transform.position;
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
