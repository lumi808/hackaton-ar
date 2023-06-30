using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARRaycaster : MonoBehaviour
{
    [SerializeField] private ARRaycastManager _raycastManager;

    private Vector2 _screenCenter;

    private void Start()
    {
        _screenCenter = new Vector2(Screen.width * 0.5f, Screen.height * 0.5f);        
    }

    public bool Raycast(out Pose hitPose)
    {
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        if (_raycastManager.Raycast(_screenCenter, hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
        {
            hitPose = hits[0].pose;
            return true;
        }

        hitPose = default;
        return false;
    }
}