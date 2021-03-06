using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] ObstacleType obstacleType;
    void Start()
    {
        switch (obstacleType)
        {
            case ObstacleType.groundObstacle:
                gameObject.transform.DOLocalRotate(new Vector3(360f, 0f, 90f), 0.5f, RotateMode.FastBeyond360).SetLoops(-1).SetEase(Ease.Linear);
                break;
            case ObstacleType.saw:
                gameObject.transform.DOLocalRotate(new Vector3(0f, 360f, 0f), 0.5f, RotateMode.FastBeyond360).SetLoops(-1).SetEase(Ease.Linear);
                break;
            case ObstacleType.verticalSaw:
                gameObject.transform.DOLocalRotate(new Vector3(0f, -360f, 0f), 0.4f, RotateMode.FastBeyond360).SetLoops(-1).SetEase(Ease.Linear);
                break;
            case ObstacleType.verticalSawCircle:
                gameObject.transform.DOLocalRotate(new Vector3(0f, 360f, 0f), 4f, RotateMode.FastBeyond360).SetLoops(-1).SetEase(Ease.Linear);
                break;
            case ObstacleType.movingSaw:
                gameObject.transform.DOLocalRotate(new Vector3(0f, 360f, 0f), 0.5f, RotateMode.FastBeyond360).SetLoops(-1).SetEase(Ease.Linear);
                gameObject.transform.DOMoveX(-transform.position.x, 2f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
                break;
        }

    }

    public enum ObstacleType
    {
        saw,
        movingSaw,
        groundObstacle,
        verticalSaw,
        verticalSawCircle,
        movingVerticalSaw,
        tower,
        boss,
    }
}
