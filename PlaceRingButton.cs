using System;
using UnityEngine;
using UnityEngine.UI;

public class PlaceRingButton : MonoBehaviour
{
    public event Action PlaceButtonPressed;

    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            PlaceButtonPressed?.Invoke();
            GetComponent<Button>().gameObject.SetActive(false);
        });
    }
}
