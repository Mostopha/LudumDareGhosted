using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rigidbody;
    
    // Start is called before the first frame update

    public void moveTowards(Vector3 dir, float speed)
    {

        rigidbody.velocity = dir * speed;

    }


}
