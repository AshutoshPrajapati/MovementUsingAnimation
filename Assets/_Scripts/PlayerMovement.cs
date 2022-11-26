using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Animator anim;
    [SerializeField] private float speed;
    [SerializeField] private float turnSpeed;

    private void Update()
    {
        Movement();
    }
    #region Player Movement
    void Movement()
    {
        Vector3 velocity = Vector3.forward * Input.GetAxis("Vertical") * speed;
        transform.Translate(velocity * Time.deltaTime);
        transform.Rotate(Vector3.up, Input.GetAxis("Horizontal") * Time.deltaTime * turnSpeed);
        anim.SetFloat("Speed", velocity.z);
    }
    #endregion
}
