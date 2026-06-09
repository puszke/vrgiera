using UnityEngine;

public class WateringCan : MonoBehaviour
{
    [Header("State")]
    public bool filled;

    [Header("Visuals")]
    [SerializeField] private GameObject waterParticles;

    [Header("Pouring")]
    [SerializeField] private float pourAngle = 45f;

    private void Update()
    {
        bool tiltedEnough =
            Vector3.Angle(transform.up, Vector3.up) > pourAngle;

        waterParticles.SetActive(filled && tiltedEnough);
    }
}