using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
    Animator anim;
    public Image healthBar;

    public float bossHP;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Stickman")
        {
            bossHP--;
            anim.SetTrigger("isAttacking");
            healthBar.fillAmount -= 0.05f;
            if (bossHP == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
