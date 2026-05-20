using UnityEngine;

public abstract class EnemyBaseState
{
    public abstract void EnterState(EnemyStateManager enemy);
    public abstract void UpdateState(EnemyStateManager enemy);
<<<<<<< HEAD
<<<<<<< HEAD
    public abstract void OnCollisionEnter(EnemyStateManager enemy);
}
=======
    public abstract void OnCollisionEnter(EnemyStateManager enemy, col);
=======
    public abstract void OnCollisionEnter(EnemyStateManager enemy);
>>>>>>> 361b31d (fix)
}
>>>>>>> 0d21830 (Enemy State Machine in progress)
