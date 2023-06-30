using UnityEngine;

public class PlacePointer : MonoBehaviour
{
    public Pose LastPose { get; private set; }

    [SerializeField] private ARRaycaster _raycaster;
    [SerializeField] private GameObject _pointerPrefab;
    [SerializeField] private PlaceRingButton _placeRingButton;

    private Transform _pointerTransform;
    private bool _showPointer;

    private void Start()
    {
        _pointerTransform = Instantiate(_pointerPrefab).transform;
        _showPointer = true;

        _placeRingButton.PlaceButtonPressed += () => _showPointer = false;
    }

    private void Update()
    {
        if(_showPointer && _raycaster.Raycast(out Pose hitPose))
        {
            _pointerTransform.position = hitPose.position;
            _pointerTransform.rotation = hitPose.rotation;

            LastPose = hitPose;
        }
    }
}
