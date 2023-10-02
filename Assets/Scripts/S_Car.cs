using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S_Car : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    [SerializeField] private float _speedGainPerSecond = 0.01f;
    [SerializeField] private float _turnSpeed = 200f;

    private int _steerValue;
    private Camera _camera;

    void Update()
    {
        _speed += _speedGainPerSecond * Time.deltaTime;

        transform.Rotate(0f, _steerValue * _turnSpeed * Time.deltaTime, 0f);

        transform.Translate(Vector3.forward * _speed * Time.deltaTime);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void Steer(int value)
    {
        _steerValue = value;
    }
}
