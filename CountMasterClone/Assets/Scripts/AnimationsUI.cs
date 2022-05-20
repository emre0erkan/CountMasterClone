using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AnimationsUI : MonoBehaviour
{
    [SerializeField] GameObject hand;
    void Start()
    {
        hand.transform.DOMoveX(transform.position.x + 320, 2).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutCubic);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
