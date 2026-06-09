using UnityEngine;

public class SafeButton : MonoBehaviour
{
    [SerializeField] private string digit;
    [SerializeField] private safeKeypad keypad;

    public void Press()
    {
        keypad.PressNumber(digit);
    }
}