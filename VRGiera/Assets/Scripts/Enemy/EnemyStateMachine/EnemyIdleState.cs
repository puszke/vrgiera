using UnityEngine;

public class EnemyIdleState : EnemyBaseState
{
<<<<<<< HEAD
    private float elapsedTime;

    public override void EnterState(EnemyStateManager enemy)
    {
        elapsedTime = 0f;
=======
    private float timeToTest;
    
    public override void EnterState(EnemyStateManager enemy)
    {
        
>>>>>>> 0d21830 (Enemy State Machine in progress)
    }

    public override void UpdateState(EnemyStateManager enemy)
    {
<<<<<<< HEAD
        elapsedTime += Time.deltaTime;

        if (elapsedTime > enemy.StateChangeDelay)
=======

        timeToTest += Time.deltaTime;
        Debug.Log("Time to test is: " + timeToTest);

        if(timeToTest > 2f)
>>>>>>> 0d21830 (Enemy State Machine in progress)
        {
            enemy.SwitchState(enemy.walkingState);
        }
    }

    public override void OnCollisionEnter(EnemyStateManager enemy)
    {
<<<<<<< HEAD
    }
}
=======
        if()
    }
}
>>>>>>> 0d21830 (Enemy State Machine in progress)
