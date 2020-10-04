using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{    
    [SerializeField] private float moveSpeed;    
    private Transform playerArt;

    private void Start()
    {        
        playerArt = this.transform.GetChild(0);
    }

    private void Update()
    {        
        MoveCharacter();
        RotCharater();
    }

    private void MoveCharacter()
    {
        float horMove = (Input.GetAxis("Horizontal") * (moveSpeed/2)) * Time.deltaTime;
        float vertMove = (Input.GetAxis("Vertical") * moveSpeed) * Time.deltaTime;
        /*Vector3 moveVector = new Vector3(horMove, vertMove, 0f);
        rd.velocity = moveVector;*/
        Vector3 horVector = this.transform.right * horMove;
        Vector3 vertVector = this.transform.up * vertMove;
        this.transform.Translate(vertVector + horVector, Space.World);
        //this.transform.Translate(vertVector, Space.World);
    }

    private void RotCharater()
    {
        Vector3 mousePosition = Input.mousePosition;
        if (this.transform.position == mousePosition)
        {
            return;
        }
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        //Vector2 direction = new Vector2(mousePosition.x - playerArt.position.x, mousePosition.y - playerArt.position.y);
        Vector2 direction = new Vector2(mousePosition.x - this.transform.position.x, mousePosition.y - this.transform.position.y);

        //playerArt.up = direction;
        this.transform.up = direction;
    }
}
