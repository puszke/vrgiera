using UnityEngine;

public class EnemyWalkingState : EnemyBaseState
{
    public override void EnterState(EnemyStateManager enemy)
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 2e19f19 (EnemyClimbing)
=======
>>>>>>> origin/Dorians
        if (enemy.PlayerTarget != null)
        {
            enemy.NavAgent.SetDestination(enemy.PlayerTarget.position);
        }
<<<<<<< HEAD
<<<<<<< HEAD
=======
        Debug.Log("Walking!...");
>>>>>>> 0d21830 (Enemy State Machine in progress)
=======
        Debug.Log("Walking!...");
>>>>>>> 2c12e68 (Enemy State Machine in progress)
=======
        Debug.Log("Walking!...");
>>>>>>> 65a7485 (Enemy State Machine in progress)
=======
>>>>>>> 2e19f19 (EnemyClimbing)
=======
>>>>>>> origin/Dorians
    }

    public override void UpdateState(EnemyStateManager enemy)
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 2e19f19 (EnemyClimbing)
=======
>>>>>>> origin/Dorians
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
=======
>>>>>>> origin/Dorians
    }

    public override void OnCollisionEnter(EnemyStateManager enemy)
    {
    }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
}
=======
}
>>>>>>> 0d21830 (Enemy State Machine in progress)
=======
}
>>>>>>> 2c12e68 (Enemy State Machine in progress)
=======
}
>>>>>>> 65a7485 (Enemy State Machine in progress)
=======
}
>>>>>>> 2e19f19 (EnemyClimbing)
=======
}
>>>>>>> origin/Dorians
