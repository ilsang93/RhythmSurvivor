using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InputManager inputManager = FindObjectOfType<InputManager>();
        inputManager.OnPressedA += MoveLeft;
        inputManager.OnPressedS += MoveDown;
        inputManager.OnPressedD += MoveRight;
        inputManager.OnPressedW += MoveUp;
    }

    private void MoveLeft()
    {
        transform.position += Vector3.left;
    }

    private void MoveRight()
    {
        transform.position += Vector3.right;
    }

    private void MoveUp()
    {
        transform.position += Vector3.up;
    }

    private void MoveDown()
    {
        transform.position += Vector3.down;
    }
}
