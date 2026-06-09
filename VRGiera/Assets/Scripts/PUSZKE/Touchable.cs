using UnityEngine;
using UnityEngine.Events;

public class Touchable : MonoBehaviour
{
    public UnityEvent en,ex;
    private void OnTriggerEnter(Collider other)
    {
        en.Invoke();
    }
    private void OnTriggerExit(Collider other)
    {
        ex.Invoke();
    }
}
