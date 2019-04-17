using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroCam : MonoBehaviour
{
    public float amplitude = 15;
    public float frequency = 0.25f;

    float initialAngle;

    void Start()
    {
        initialAngle = transform.eulerAngles.y;
        Screen.SetResolution(96, 72, FullScreenMode.FullScreenWindow);
    }

    void Update()
    {
        float delta = Mathf.Sin(frequency * Time.time) * amplitude;
        Vector3 euler = new Vector3(0, initialAngle + delta, 0);
        transform.eulerAngles = euler;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartGame();
        }
    }

    void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
