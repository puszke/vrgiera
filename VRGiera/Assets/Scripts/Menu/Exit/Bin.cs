using UnityEngine;

public class Bin : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Trash trash))
        {
            SceneSystemManager.Instance.QuitGame();
            Debug.Log("Works");
        }
    }
}
