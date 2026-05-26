using UnityEngine;

public class EnemyWalkingState : EnemyBaseState
{
    public override void EnterState(EnemyStateManager enemy)
    {
        if (enemy.PlayerTarget != null)
        {
            enemy.NavAgent.SetDestination(enemy.PlayerTarget.position);
        }
    }

    public override void UpdateState(EnemyStateManager enemy)
    {
        if (enemy.PlayerTarget == null)
        {
            return;
        }

        if (enemy.NavAgent.isOnOffMeshLink)
        {
            enemy.SwitchState(enemy.climbingState);
            return;
        }

        enemy.NavAgent.SetDestination(enemy.PlayerTarget.position);

        float distanceToTarget = Vector3.Distance(enemy.transform.position, enemy.PlayerTarget.position);

        if (distanceToTarget <= enemy.LethalDistance)
        {
            enemy.ExecutePlayer();
        }
    }

    public override void OnCollisionEnter(EnemyStateManager enemy)
    {
    }
}