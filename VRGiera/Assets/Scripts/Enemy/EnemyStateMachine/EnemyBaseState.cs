using UnityEngine;

public abstract class EnemyBaseState
{
    public abstract void EnterState(EnemyStateManager enemy);
    public abstract void UpdateState(EnemyStateManager enemy);
<<<<<<< HEAD
<<<<<<< HEAD
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
=======
    public abstract void OnCollisionEnter(EnemyStateManager enemy, col);
}
>>>>>>> 2c12e68 (Enemy State Machine in progress)
=======
    public abstract void OnCollisionEnter(EnemyStateManager enemy, col);
}
>>>>>>> 65a7485 (Enemy State Machine in progress)
