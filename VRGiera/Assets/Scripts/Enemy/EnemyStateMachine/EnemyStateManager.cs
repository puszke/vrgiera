using UnityEngine;
<<<<<<< HEAD
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
=======

public class EnemyStateManager : MonoBehaviour
{
    EnemyBaseState currentState;
    public EnemyIdleState idleState = new EnemyIdleState();
    public EnemyWalkingState walkingState = new EnemyWalkingState();
    public EnemyClimbingState climbingState = new EnemyClimbingState();

>>>>>>> 0d21830 (Enemy State Machine in progress)

    private void Start()
    {
        currentState = idleState;
<<<<<<< HEAD
=======

>>>>>>> 0d21830 (Enemy State Machine in progress)
        currentState.EnterState(this);
    }

    private void Update()
    {
<<<<<<< HEAD
        currentState?.UpdateState(this);
=======
        currentState.UpdateState(this);
>>>>>>> 0d21830 (Enemy State Machine in progress)
    }

    public void SwitchState(EnemyBaseState state)
    {
        currentState = state;
<<<<<<< HEAD
        currentState?.EnterState(this);
    }

    public void ExecutePlayer()
    {
        gameObject.SetActive(false);
    }
}
=======
        currentState.EnterState(this);
    }
}
>>>>>>> 0d21830 (Enemy State Machine in progress)
