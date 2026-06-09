using UnityEngine;
using TMPro;

public class ObjectReveal : MonoBehaviour
{
    [Header("Reveal")]
    [SerializeField] private float revealRadius = 3f;
    [SerializeField] private float fadeSpeed = 5f;

    private Renderer rend;
    private Material mat;

    private TMP_Text tmpText;

    private float visibility;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        tmpText = GetComponent<TMP_Text>();

        if (rend != null)
        {
            mat = rend.material;
        }

        SetVisibility(0f);
    }

    private void Update()
    {
        if (RevealManager.Instance == null ||
            RevealManager.Instance.RevealSphere == null)
            return;

        Vector3 revealPos =
            RevealManager.Instance.RevealSphere.position;

        float distance;

        Collider col = GetComponent<Collider>();

        if (col != null)
        {
            distance = Vector3.Distance(
                col.ClosestPoint(revealPos),
                revealPos);
        }
        else
        {
            distance = Vector3.Distance(
                transform.position,
                revealPos);
        }

        float targetVisibility =
            Mathf.Clamp01(1f - distance / revealRadius);

        visibility = Mathf.MoveTowards(
            visibility,
            targetVisibility,
            fadeSpeed * Time.deltaTime);

        SetVisibility(visibility);
    }

    private void SetVisibility(float value)
    {
        // Renderer
        if (mat != null)
        {
            Color c = mat.color;
            c.a = value;
            mat.color = c;
        }

        // TextMeshPro
        if (tmpText != null)
        {
            Color c = tmpText.color;
            c.a = value;
            tmpText.color = c;
        }
    }
}