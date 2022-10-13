using UnityEngine;
using UnityEngine.UI;

public class EndGamePanel : MonoBehaviour
{
    [SerializeField] private Text _mainText;
    [SerializeField] private Text _rewardsText;
    [SerializeField] private Text _clicksText;

    private void Start()
    {
        gameObject.SetActive(false);
    }
    public void Show(int rewards, int clicks, bool win = true)
    {
        if (win == true)
            _mainText.text = "You win!";
        else
            _mainText.text = "You lose!";
        _rewardsText.text += " " + rewards.ToString();
        _clicksText.text += " " + clicks.ToString();


        gameObject.SetActive(true);
    }
}
