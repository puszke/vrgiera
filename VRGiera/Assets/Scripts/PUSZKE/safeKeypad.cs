using TMPro;
using UnityEngine;

public class safeKeypad : MonoBehaviour
{
    [Header("Code")]
    [SerializeField] private string correctCode = "1234";

    [Header("Display")]
    [SerializeField] private TMP_Text displayText;

    [Header("Safe")]
    [SerializeField] private GameObject door;

    private string currentInput = "";

    private bool unlocked;

    private void Start()
    {
        UpdateDisplay();
    }

    public void PressNumber(string number)
    {
        if (unlocked)
            return;

        currentInput += number;

        if (currentInput.Length > correctCode.Length)
            currentInput = currentInput.Substring(1);

        UpdateDisplay();

        if (currentInput == correctCode)
        {
            Unlock();
        }
    }

    public void Clear()
    {
        currentInput = "";
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        displayText.text = currentInput.PadLeft(correctCode.Length, '0');
    }

    private void Unlock()
    {
        unlocked = true;

        displayText.text = "OPEN";

        if (door != null)
        {
            door.SetActive(false);
        }
    }
}