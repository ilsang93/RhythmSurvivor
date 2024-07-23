using System;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public Action OnPressedA;
    public Action OnPressedS;
    public Action OnPressedD;
    public Action OnPressedW;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            OnPressedA?.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            OnPressedS?.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            OnPressedD?.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            OnPressedW?.Invoke();
        }
    }
}
