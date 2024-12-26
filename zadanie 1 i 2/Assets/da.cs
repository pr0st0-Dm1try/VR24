using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class da : MonoBehaviour
{
    public Button button;
    public Text text;
    private int clickCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (button != null)
        {
            button.onClick.AddListener(OnButtonClick);
        }

        UpdateText(clickCount);
    }

    void OnButtonClick()
    {
        if (clickCount < 10)
            clickCount++;
        if (clickCount == 10)
        {
            BreakButton();
        }
        if (clickCount % 5 == 0)
        {
            RickRoll(clickCount);
        }
        else
        {
            UpdateText(clickCount);
        }
    }

    void UpdateText(int clickCount)
    {
        if (text != null)
        {
            text.text = "" + clickCount;
        }
    }

    void RickRoll(int clickCount)
    {

        if (text != null && clickCount == 5)
        {
            text.text = "Который час?\nУже обед";
        }
        else if (text != null)
        {
            text.text = "Хотел добавить рикролл, но было впадлу\nделать это в 5 утра =)";
        }

    }

    void BreakButton()
    {
        string currentTime = System.DateTime.Now.ToString("HH:mm");

        if (button != null && button.GetComponentInChildren<Text>() != null)
        {
            button.GetComponentInChildren<Text>().text = $"На часах {currentTime},\nкнопка сломалась xd)))";
        }

        if (button != null)
        {
            button.interactable = false;
        }
    }
}
