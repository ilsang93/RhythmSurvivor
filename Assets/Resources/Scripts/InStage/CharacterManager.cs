using DG.Tweening;
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
        transform.DOJump(transform.position + Vector3.left, 1, 1, 1);
        PlayerManager.instance.transform.DOLocalMove(PlayerManager.instance.transform.localPosition + Vector3.left, 1);
    }

    private void MoveRight()
    {
        transform.DOJump(transform.position + Vector3.right, 1, 1, 1);
        PlayerManager.instance.transform.DOLocalMove(PlayerManager.instance.transform.localPosition + Vector3.right, 1);
    }

    private void MoveUp()
    {
        transform.DOJump(transform.position + Vector3.up, 1, 1, 1);
        PlayerManager.instance.transform.DOLocalMove(PlayerManager.instance.transform.localPosition + Vector3.up, 1);
    }

    private void MoveDown()
    {
        transform.DOJump(transform.position + Vector3.down, 1, 1, 1);
        PlayerManager.instance.transform.DOLocalMove(PlayerManager.instance.transform.localPosition + Vector3.down, 1);
    }
}
