using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] private Text _coinsText;
    [SerializeField] private Text _clickText;
    [SerializeField] private EndGamePanel _panel;

    private void UpdateText(Text text, int value)
    {
        text.text = value.ToString();
    }

    public void UpdateCoinsText(int coinsCount)
    {
        UpdateText(_coinsText, coinsCount);
    }

    public void UpdateClicksText(int clicksCount)
    {
        UpdateText(_clickText, clicksCount);
    }

    public void ShowPanel(int coins, int clicks, bool win)
    {
        _panel.Show(coins, clicks, win);
    }

}
