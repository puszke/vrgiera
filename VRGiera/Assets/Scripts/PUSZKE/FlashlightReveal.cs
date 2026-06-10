using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit;

public class FlashlightReveal : MonoBehaviour
{
    [SerializeField] private Transform revealSphere;
    [SerializeField] private float maxDistance = 20f;
    private XRGrabInteractable grab;

    bool balls = false;

    private void Awake()
    {
        grab = GetComponent<XRGrabInteractable>();
    }

    private void OnEnable()
    {
        grab.selectEntered.AddListener(OnGrabbed);
    }

    private void OnDisable()
    {
        grab.selectEntered.RemoveListener(OnGrabbed);
    }

    private void OnGrabbed(SelectEnterEventArgs args)
    {
        Transform hand = args.interactorObject.transform;

        transform.SetParent(hand);

        balls = true;
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;

        RenderSettings.ambientIntensity = 0.3f;

        
        Destroy(grab); // opcjonalnie, ¿eby nie mo¿na by³o ju¿ od³o¿yæ
    }

    void Update()
    {
        revealSphere = GameObject.FindGameObjectWithTag("sph").transform;
        Ray ray = new Ray(transform.position, transform.forward);

        if (Physics.Raycast(ray, out RaycastHit hit, maxDistance))
        {
            revealSphere.position = hit.point;
        }
        else
        {
            revealSphere.position = transform.position + transform.forward * maxDistance;
        }

        GetComponent<Rigidbody>().isKinematic = balls;
    }
}