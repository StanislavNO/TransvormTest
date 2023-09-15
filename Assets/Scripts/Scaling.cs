using UnityEngine;

public class Scaling : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _startScale;
    private Vector3 _endScale;
    private bool _isGrowing = true;

    private void Start()
    {
        _startScale = transform.localScale;
        _endScale = _startScale * 2;
    }

    private void Update()
    {
        if (_isGrowing)
        {
            transform.localScale += Vector3.one * _speed * Time.deltaTime;

            if (transform.localScale.magnitude >= _endScale.magnitude)
                _isGrowing = false;
        }
        else
        {
            transform.localScale -= Vector3.one * _speed * Time.deltaTime;

            if (transform.localScale.magnitude <= _startScale.magnitude)
                _isGrowing = true;
        }
    }
}