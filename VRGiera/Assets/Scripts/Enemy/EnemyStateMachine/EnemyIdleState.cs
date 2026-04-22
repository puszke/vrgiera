using UnityEngine;

public class EnemyIdleState : EnemyBaseState
{
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    private float elapsedTime;

    public override void EnterState(EnemyStateManager enemy)
    {
        elapsedTime = 0f;
=======
=======
>>>>>>> 2c12e68 (Enemy State Machine in progress)
=======
>>>>>>> 65a7485 (Enemy State Machine in progress)
    private float timeToTest;
    
    public override void EnterState(EnemyStateManager enemy)
    {
        
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 0d21830 (Enemy State Machine in progress)
=======
>>>>>>> 2c12e68 (Enemy State Machine in progress)
=======
>>>>>>> 65a7485 (Enemy State Machine in progress)
    }

    public override void UpdateState(EnemyStateManager enemy)
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        elapsedTime += Time.deltaTime;

        if (elapsedTime > enemy.StateChangeDelay)
=======
=======
>>>>>>> 2c12e68 (Enemy State Machine in progress)
=======
>>>>>>> 65a7485 (Enemy State Machine in progress)

        timeToTest += Time.deltaTime;
        Debug.Log("Time to test is: " + timeToTest);

        if(timeToTest > 2f)
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 0d21830 (Enemy State Machine in progress)
=======
>>>>>>> 2c12e68 (Enemy State Machine in progress)
=======
>>>>>>> 65a7485 (Enemy State Machine in progress)
        {
            enemy.SwitchState(enemy.walkingState);
        }
    }

    public override void OnCollisionEnter(EnemyStateManager enemy)
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    }
}
=======
        if()
=======
      
>>>>>>> 361b31d (fix)
    }
}
>>>>>>> 0d21830 (Enemy State Machine in progress)
=======
        if()
    }
}
>>>>>>> 2c12e68 (Enemy State Machine in progress)
=======
        if()
    }
}
>>>>>>> 65a7485 (Enemy State Machine in progress)
