using UnityEngine;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> origin/Dorians
using UnityEngine.AI;

public class EnemyClimbingState : EnemyBaseState
{
    private const float ClimbCompletionThreshold = 1f;
    private const float InitialClimbProgress = 0f;

    private Vector3 startPos;
    private Vector3 endPos;
    private float climbProgress;
    private float journeyLength;

    public override void EnterState(EnemyStateManager enemy)
    {
        OffMeshLinkData data = enemy.NavAgent.currentOffMeshLinkData;
        startPos = enemy.transform.position;
        endPos = data.endPos + Vector3.up * enemy.NavAgent.baseOffset;

        journeyLength = Vector3.Distance(startPos, endPos);
        climbProgress = InitialClimbProgress;
    }

    public override void UpdateState(EnemyStateManager enemy)
    {
        climbProgress += (enemy.ClimbSpeed * Time.deltaTime) / journeyLength;
        enemy.transform.position = Vector3.Lerp(startPos, endPos, climbProgress);

        if (climbProgress >= ClimbCompletionThreshold)
        {
            enemy.NavAgent.CompleteOffMeshLink();
            enemy.SwitchState(enemy.walkingState);
        }
    }

    public override void OnCollisionEnter(EnemyStateManager enemy)
    {
    }
<<<<<<< HEAD
}
=======
=======
>>>>>>> 2c12e68 (Enemy State Machine in progress)
=======
>>>>>>> 65a7485 (Enemy State Machine in progress)
=======
using UnityEngine.AI;
>>>>>>> 2e19f19 (EnemyClimbing)

public class EnemyClimbingState : EnemyBaseState
{
    private const float ClimbCompletionThreshold = 1f;
    private const float InitialClimbProgress = 0f;

    private Vector3 startPos;
    private Vector3 endPos;
    private float climbProgress;
    private float journeyLength;

    public override void EnterState(EnemyStateManager enemy)
    {
        OffMeshLinkData data = enemy.NavAgent.currentOffMeshLinkData;
        startPos = enemy.transform.position;
        endPos = data.endPos + Vector3.up * enemy.NavAgent.baseOffset;

        journeyLength = Vector3.Distance(startPos, endPos);
        climbProgress = InitialClimbProgress;
    }

    public override void UpdateState(EnemyStateManager enemy)
    {
        climbProgress += (enemy.ClimbSpeed * Time.deltaTime) / journeyLength;
        enemy.transform.position = Vector3.Lerp(startPos, endPos, climbProgress);

        if (climbProgress >= ClimbCompletionThreshold)
        {
            enemy.NavAgent.CompleteOffMeshLink();
            enemy.SwitchState(enemy.walkingState);
        }
    }

    public override void OnCollisionEnter(EnemyStateManager enemy)
    {
    }
<<<<<<< HEAD
}
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 0d21830 (Enemy State Machine in progress)
=======
>>>>>>> 2c12e68 (Enemy State Machine in progress)
=======
>>>>>>> 65a7485 (Enemy State Machine in progress)
=======
}
>>>>>>> 2e19f19 (EnemyClimbing)
=======
}
>>>>>>> origin/Dorians
