using UnityEngine;
using UnityEngine.UI;

public class LosePanel : MonoBehaviour
{
    [SerializeField] private Text _rewardsText;
    [SerializeField] private Text _clicksText;
    [SerializeField] private Button _restartButton;

    private void Start()
    {
        gameObject.SetActive(false);
    }
    public void Show(int rewards, int clicks)
    {
        gameObject.SetActive(true);
        _rewardsText.text += " " + rewards.ToString();
        _clicksText.text += " " + clicks.ToString();
    }
}
