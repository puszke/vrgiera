using UnityEngine;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
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
=======
>>>>>>> 2c12e68 (Enemy State Machine in progress)
=======
>>>>>>> 65a7485 (Enemy State Machine in progress)
=======
using UnityEngine.AI;
>>>>>>> 2e19f19 (EnemyClimbing)

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyStateManager : MonoBehaviour
{
    private EnemyBaseState currentState;

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 0d21830 (Enemy State Machine in progress)
=======
>>>>>>> 2c12e68 (Enemy State Machine in progress)
=======
>>>>>>> 65a7485 (Enemy State Machine in progress)
=======
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
>>>>>>> 2e19f19 (EnemyClimbing)

    private void Start()
    {
        currentState = idleState;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======

>>>>>>> 0d21830 (Enemy State Machine in progress)
=======

>>>>>>> 2c12e68 (Enemy State Machine in progress)
=======

>>>>>>> 65a7485 (Enemy State Machine in progress)
=======
>>>>>>> 2e19f19 (EnemyClimbing)
        currentState.EnterState(this);
    }

    private void Update()
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        currentState?.UpdateState(this);
=======
        currentState.UpdateState(this);
>>>>>>> 0d21830 (Enemy State Machine in progress)
=======
        currentState.UpdateState(this);
>>>>>>> 2c12e68 (Enemy State Machine in progress)
=======
        currentState.UpdateState(this);
>>>>>>> 65a7485 (Enemy State Machine in progress)
=======
        currentState?.UpdateState(this);
>>>>>>> 2e19f19 (EnemyClimbing)
    }

    public void SwitchState(EnemyBaseState state)
    {
        currentState = state;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        currentState?.EnterState(this);
    }

    public void ExecutePlayer()
    {
        Destroy(gameObject);
    }
}
=======
        currentState.EnterState(this);
    }
}
>>>>>>> 0d21830 (Enemy State Machine in progress)
=======
        currentState.EnterState(this);
    }
}
>>>>>>> 2c12e68 (Enemy State Machine in progress)
=======
        currentState.EnterState(this);
    }
}
>>>>>>> 65a7485 (Enemy State Machine in progress)
=======
        currentState?.EnterState(this);
    }

    public void ExecutePlayer()
    {
        gameObject.SetActive(false);
    }
}
>>>>>>> 2e19f19 (EnemyClimbing)
