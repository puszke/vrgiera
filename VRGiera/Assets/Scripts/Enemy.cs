using UnityEngine;
using UnityEngine.AI;
public class Enemy : MonoBehaviour
{
    [SerializeField] private NavMeshAgent enemy;
    [SerializeField] private Transform player;

    private void Update()
    {
        enemy.SetDestination(player.position);
    }

}
