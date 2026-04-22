using UnityEngine;

public class EnemyIdleState : EnemyBaseState
{
    private float timeToTest;
    
    public override void EnterState(EnemyStateManager enemy)
    {
        
    }

    public override void UpdateState(EnemyStateManager enemy)
    {

        timeToTest += Time.deltaTime;
        Debug.Log("Time to test is: " + timeToTest);

        if(timeToTest > 2f)
        {
            enemy.SwitchState(enemy.walkingState);
        }
    }

    public override void OnCollisionEnter(EnemyStateManager enemy)
    {
        if()
    }
}
