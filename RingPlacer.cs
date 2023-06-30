using UnityEngine;

public class RingPlacer : MonoBehaviour
{
    [SerializeField] private GameObject _ringPrefab;
    [SerializeField] private PlacePointer _placePointer;
    [SerializeField] private PlaceRingButton _placeRingButton;
    [SerializeField] private ScoreUI _scoreUI;
    private GameObject _ringInstance;

    private void Awake()
    {
        _placeRingButton.PlaceButtonPressed += OnPlaceButtonPressed;
    }

    private void OnPlaceButtonPressed()
    {
        _ringInstance = Instantiate(_ringPrefab);

        _ringInstance.transform.position = _placePointer.LastPose.position;

        Vector3 toPlayer = Camera.main.transform.position - _ringInstance.transform.position;
        toPlayer.y = 0;

        _ringInstance.transform.forward = toPlayer;

        _scoreUI.SetRing(_ringInstance.GetComponent<BasketRing>());
    }
}
