using UnityEngine;

public class Toaster : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Toast toast))
        {
            SceneSystemManager.Instance.LoadScene("Gameplay");
            Debug.Log("Works");
        }
    }
}
