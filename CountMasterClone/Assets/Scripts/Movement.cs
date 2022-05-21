using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float swerveSpeed;
    public Vector3 forwardMove;
    SwerveInputSystem swerveInput;

    private void Start()
    {
        swerveInput = GetComponent<SwerveInputSystem>();
        forwardMove = new Vector3(0f, 0f, 0f);
    }

    //private void OnTriggerStay(Collider other)
    //{
    //    if (other.gameObject.tag == "TowerArea")
    //    {
    //        Debug.Log("Main Tower area triggered");
    //        forwardMove = new Vector3(0f, 0f, 0f);
    //    }
    //    else if (other.gameObject.tag == "Boss")
    //    {
    //        Debug.Log("Main Boss area triggered");
    //        forwardMove = new Vector3(0f, 0f, 0f);
    //    }
    //}
    void Update()
    {
        transform.position = transform.position + forwardMove;
        Vector3 sideMove = transform.right * swerveSpeed * swerveInput.MoveFactorX * Time.deltaTime;
        transform.position = transform.position + sideMove;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -12f, 12f), transform.position.y, transform.position.z);
    }
}
