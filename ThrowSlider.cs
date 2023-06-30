using UnityEngine;
using UnityEngine.UI;

public class ThrowSlider : MonoBehaviour
{
    [SerializeField] private Launcher _launcher;
    [SerializeField] private Slider _slider;

    private void Awake()
    {
        _slider.onValueChanged.AddListener(OnValueChanged);
    }

    private void OnValueChanged(float newValue)
    {
        _launcher.SetSpeed(newValue);
    }
}
