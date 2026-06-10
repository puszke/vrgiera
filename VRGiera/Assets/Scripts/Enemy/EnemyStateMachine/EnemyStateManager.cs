using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyStateManager : MonoBehaviour
{
    private EnemyBaseState currentState;

    public readonly EnemyIdleState idleState = new EnemyIdleState();
    public readonly EnemyWalkingState walkingState = new EnemyWalkingState();
    public readonly EnemyClimbingState climbingState = new EnemyClimbingState();

    [SerializeField] private Transform playerTarget;
    [SerializeField] private float stateChangeDelay;
    [SerializeField] private float lethalDistance;
    [SerializeField] private float climbSpeed;

    private NavMeshAgent navAgent;

    public Transform PlayerTarget => playerTarget;
    public float StateChangeDelay => stateChangeDelay;
    public float LethalDistance => lethalDistance;
    public float ClimbSpeed => climbSpeed;
    public NavMeshAgent NavAgent => navAgent;

    private void Awake()
    {
        navAgent = GetComponent<NavMeshAgent>();
        navAgent.autoTraverseOffMeshLink = false;
    }

    private void Start()
    {
        currentState = idleState;
        currentState.EnterState(this);
    }

    private void Update()
    {
        currentState?.UpdateState(this);
    }

    public void SwitchState(EnemyBaseState state)
    {
        currentState = state;
        currentState?.EnterState(this);
    }

    public void ExecutePlayer()
    {
        Destroy(gameObject);
    }
}