using UnityEngine;

public class WaterSource : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        WateringCan can = other.GetComponentInParent<WateringCan>();

        if (can != null)
        {
            can.filled = true;
        }
    }
}