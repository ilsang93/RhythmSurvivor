using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NotesManager : MonoBehaviour
{
    public GameObject rightPos;
    public GameObject leftPos;
    public GameObject centerPos;
    public GameObject notePrefab;
    public float noteSpeed = 5f;
    public float noteTime = 0f;
    public float noteDuration = 1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        noteTime += Time.deltaTime;
        if (noteTime > noteDuration)
        {
            CreateNote();
            noteTime = 0f;
        }
    }

    private void CreateNote()
    {
        // 좌우 포지션에 하나씩 생성한다
        GameObject rightNote = Instantiate(notePrefab, rightPos.transform.position, Quaternion.identity, transform);
        GameObject leftNote = Instantiate(notePrefab, leftPos.transform.position, Quaternion.identity, transform);
        
        // 좌우 노트의 위치를 사전 정의된 속도에 따라 중심으로 이동시킨다.
        rightNote.transform.DOLocalMoveX(0, 1/noteSpeed).SetEase(Ease.Linear).OnComplete(() => Destroy(rightNote));
        leftNote.transform.DOLocalMoveX(0, 1/noteSpeed).SetEase(Ease.Linear).OnComplete(() => Destroy(leftNote));
    }
}
