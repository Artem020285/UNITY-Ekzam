
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TMP_Text _timeText;

    private float _time;

    private void Update()
    {
        _time = Time.time;
        _timeText.text = _time.ToString("0.0");
    }
}
