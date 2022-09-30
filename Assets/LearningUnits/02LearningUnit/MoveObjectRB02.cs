using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectRB02 : MonoBehaviour
{
    Rigidbody rigidbody;
    [SerializeField] Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        // Where does one find a rigidbody these days anyway?

	    rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.AddForce(moveDirection, ForceMode.Force);
        //i was basing this off of the tutorial you gave in class, which i took pics of
        //i legitimately have no idea why this isnt working
        //the red cube doesn't seem to "have" rigidbody, even tho it does
        //it should be kinematic and responding to gravity
        //but it just isn't
    }
}
