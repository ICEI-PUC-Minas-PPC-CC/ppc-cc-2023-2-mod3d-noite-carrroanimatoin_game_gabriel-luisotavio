using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody r;
    [SerializeField] float MoveSpeed=5f;
    [SerializeField] float JumpSpeed = 5f;
    [SerializeField] int JumpNum = 0;
    [SerializeField] int MaxJumpNum = 2;
    [SerializeField] Transform gCheck;
    [SerializeField] LayerMask ground;
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
         float HorizontalInpt = Input.GetAxis("Horizontal");
        float VerticalInpt = Input.GetAxis("Vertical");

        r.velocity = new Vector3(HorizontalInpt* MoveSpeed, r.velocity.y, VerticalInpt* MoveSpeed);
        if (GroundChecking())
        {
            JumpNum = 0;
        }
        if (Input.GetButtonDown("Jump"))
        {
            if (JumpNum < MaxJumpNum)
            {
                Jump();
                JumpNum++;
            }

        }
    }
    void Jump()
    {
        r.velocity = new Vector3(r.velocity.x, JumpSpeed, r.velocity.z);
        //JumpNum++;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EnemyHead"))
        {
            Destroy(collision.transform.parent.gameObject);
            Jump();
        }
    }
    bool GroundChecking()
    {
       return Physics.CheckSphere(gCheck.position, .3f, ground);
    }
}
