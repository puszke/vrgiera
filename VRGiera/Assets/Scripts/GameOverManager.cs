using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private GameObject gameoverPanel;

    private void Update()
    {
        if(enemy == null)
        {
            gameoverPanel.SetActive(true);
        }
    }
}
