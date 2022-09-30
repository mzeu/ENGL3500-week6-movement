using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgitatorMvmt : MonoBehaviour
{
    Rigidbody rigidbody;
    Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        rigidbody = GetComponent<Rigidbody>();

        //Set the angular velocity of the Rigidbody (rotating around the Y axis, 100 deg/sec)
        moveDirection = new Vector3(20, 0, 300);

    }

    // Update is called once per frame
    void Update()
    {
        Quaternion deltaRotation = Quaternion.Euler(moveDirection * Time.fixedDeltaTime);
        rigidbody.MoveRotation(rigidbody.rotation * deltaRotation);
    }
}
