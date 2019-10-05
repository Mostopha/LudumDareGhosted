using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementControl : MonoBehaviour
{
    public Movement player;
    public float horizontalVelocity = 1;
    public float verticalVelocity = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            
            Vector3 moveVector = new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical"));
            
            player.moveTowards(moveVector,horizontalVelocity);
            
        }
        else
        {
            player.moveTowards(Vector3.zero,0);
        }
    }
}
