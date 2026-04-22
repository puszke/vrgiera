using UnityEngine;

public class EnemyWalkingState : EnemyBaseState
{
    public override void EnterState(EnemyStateManager enemy)
    {
        Debug.Log("Walking!...");
    }

    public override void UpdateState(EnemyStateManager enemy)
    {
    }

    public override void OnCollisionEnter(EnemyStateManager enemy)
    {
    }
}
