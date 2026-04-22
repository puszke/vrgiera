using UnityEngine;

public class EnemyWalkingState : EnemyBaseState
{
    public override void EnterState(EnemyStateManager enemy)
    {
<<<<<<< HEAD
<<<<<<< HEAD
        if (enemy.PlayerTarget != null)
        {
            enemy.NavAgent.SetDestination(enemy.PlayerTarget.position);
        }
=======
        Debug.Log("Walking!...");
>>>>>>> 0d21830 (Enemy State Machine in progress)
=======
        Debug.Log("Walking!...");
>>>>>>> 2c12e68 (Enemy State Machine in progress)
    }

    public override void UpdateState(EnemyStateManager enemy)
    {
<<<<<<< HEAD
<<<<<<< HEAD
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
=======
>>>>>>> 0d21830 (Enemy State Machine in progress)
=======
>>>>>>> 2c12e68 (Enemy State Machine in progress)
    }

    public override void OnCollisionEnter(EnemyStateManager enemy)
    {
    }
<<<<<<< HEAD
<<<<<<< HEAD
}
=======
}
>>>>>>> 0d21830 (Enemy State Machine in progress)
=======
}
>>>>>>> 2c12e68 (Enemy State Machine in progress)
