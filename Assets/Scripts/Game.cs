using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private StateSwitcher _stateSwitcher;
    [SerializeField] private ClickCatcher _clickCatcher;
    [SerializeField] private CoinsHendler _coinsHendler;
    [SerializeField] private Player _player;
    [SerializeField] private UI _ui;

    private WayCreator _wayCreator;
    private int _coins;
    private int _clicks;

    private void OnEnable()
    {
        _coinsHendler.CoinsChanched += AddCoinReward;
        _coinsHendler.CoinsEnded += GameWin;
        _clickCatcher.OnClick += AddClickCount;
        _player.OnDeath += GameOver;

    }

    private void OnDisable()
    {
        _coinsHendler.CoinsChanched -= AddCoinReward;
        _coinsHendler.CoinsEnded -= GameWin;
        _clickCatcher.OnClick -= AddClickCount;
        _player.OnDeath -= GameOver;
    }

    private void Start()
    {
        _wayCreator = new WayCreator(_clickCatcher);
        _stateSwitcher.Init(_wayCreator);
    }

    private void AddCoinReward(int coins)
    {
        _coins += coins;
        _ui.UpdateCoinsText(_coins);
    }

    private void AddClickCount(Vector2 vector)
    {
        _clicks++;
        _ui.UpdateClicksText(_clicks);
    }

    private void GameOver()
    {
        Destroy(_clickCatcher);
        _ui.ShowPanel(_coins, _clicks, false);
    }

    private void GameWin()
    {
        Destroy(_player);
        Destroy(_clickCatcher);
        _ui.ShowPanel(_coins, _clicks, true);
    }


}
