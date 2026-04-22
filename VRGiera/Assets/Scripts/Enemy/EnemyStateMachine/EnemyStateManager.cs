using UnityEngine;

public class EnemyStateManager : MonoBehaviour
{
    EnemyBaseState currentState;
    public EnemyIdleState idleState = new EnemyIdleState();
    public EnemyWalkingState walkingState = new EnemyWalkingState();
    public EnemyClimbingState climbingState = new EnemyClimbingState();


    private void Start()
    {
        currentState = idleState;

        currentState.EnterState(this);
    }

    private void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(EnemyBaseState state)
    {
        currentState = state;
        currentState.EnterState(this);
    }
}
