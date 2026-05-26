using UnityEngine;

public class EnemyIdleState : EnemyBaseState
{
    private float elapsedTime;

    public override void EnterState(EnemyStateManager enemy)
    {
        elapsedTime = 0f;
    }

    public override void UpdateState(EnemyStateManager enemy)
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime > enemy.StateChangeDelay)
        {
            enemy.SwitchState(enemy.walkingState);
        }
    }

    public override void OnCollisionEnter(EnemyStateManager enemy)
    {
    }
}