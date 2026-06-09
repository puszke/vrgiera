using UnityEngine;

public class FlashlightReveal : MonoBehaviour
{
    [SerializeField] private Transform revealSphere;
    [SerializeField] private float maxDistance = 20f;

    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);

        if (Physics.Raycast(ray, out RaycastHit hit, maxDistance))
        {
            revealSphere.position = hit.point;
        }
        else
        {
            revealSphere.position = transform.position + transform.forward * maxDistance;
        }
    }
}