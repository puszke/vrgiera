using UnityEngine;

public class EnemyIdleState : EnemyBaseState
{
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> origin/Dorians
    private float elapsedTime;

    public override void EnterState(EnemyStateManager enemy)
    {
        elapsedTime = 0f;
<<<<<<< HEAD
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
=======
    private float elapsedTime;

    public override void EnterState(EnemyStateManager enemy)
    {
        elapsedTime = 0f;
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
=======
        elapsedTime += Time.deltaTime;

        if (elapsedTime > enemy.StateChangeDelay)
>>>>>>> 2e19f19 (EnemyClimbing)
=======
        elapsedTime += Time.deltaTime;

        if (elapsedTime > enemy.StateChangeDelay)
>>>>>>> origin/Dorians
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
=======
      
>>>>>>> 323881f (fix)
    }
}
>>>>>>> 2c12e68 (Enemy State Machine in progress)
=======
        if()
    }
}
>>>>>>> 65a7485 (Enemy State Machine in progress)
=======
    }
}
>>>>>>> 2e19f19 (EnemyClimbing)
=======
    }
}
>>>>>>> origin/Dorians
