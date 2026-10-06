using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

public float moveSpeed; 
public float jumpHeight; 

public KeyCode Spacebar; 
/

public KeyCode L;
public KeyCode R;
vo1d start () {}
void update () {
    if(Input.GetKeyDown(Spacebar))
    {
        jump();
    }
if (Input.GetKey(L))
{
GetComponent<Rigidbody2D>().velocity=new vector2(-movespeed,GetCcompnent<Rigidbody2D>
}
    
if(GetComponent<SpriteRenderer>() != null)
{


GetComponent<SpriteRenderer>().flipX = true;
}

if(GetComponent<SpriteRenderer>() != null)
{

GetComponent<SpriteRenderer>().flipX = false;
}

