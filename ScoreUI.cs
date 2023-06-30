using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    public int Scores;
    private BasketRing _ring;

    [SerializeField] private TextMeshProUGUI _scoreText;

    public void SetRing(BasketRing ring)
    {
        _ring = ring;
        _ring.ProjectileInsideRing += OnProjectileIn;
    }

    private void OnProjectileIn()
    {
        Scores++;
        _scoreText.text = $"Scores: {Scores}";
    }
}
