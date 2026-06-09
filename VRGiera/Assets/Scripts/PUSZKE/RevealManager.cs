using UnityEngine;

public class RevealManager : MonoBehaviour
{
    public static RevealManager Instance;

    public Transform RevealSphere;

    private void Awake()
    {
        Instance = this;
    }
}