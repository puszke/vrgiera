using System.Collections;
using UnityEngine;

public class flower : MonoBehaviour
{
    public Vector3 offset;
    public GameObject lightt;

    bool spawned = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<WateringCan>() != null)
        {
            if (other.GetComponent<WateringCan>().filled && !spawned)
            {
                StartCoroutine(co());
            }
        }
    }
    IEnumerator co()
    {
        spawned = true;
        yield return new WaitForSeconds(1);
        GetComponent<Animator>().SetTrigger("open");
        GameObject newLight = Instantiate(lightt);
        newLight.transform.position = transform.position+offset;
    }
}
