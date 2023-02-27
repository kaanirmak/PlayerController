using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    Rigidbody2D playerRB;
    public float moveSpeed = 1f;

    bool facingRight = true;
    void Awake()
    {
        print("awake");
    }

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    //frame odaklý(görüntü yenileme)
    //her bir frameiçin bir kez çalýþ fps
    void Update()
    {
        HorizontalMove();
    }

    //zaman odaklý çalýþ 50/sn
    //fizik hesabý
    void FixedUpdate()
    {

    }

    void HorizontalMove()
    {
        playerRB.velocity = new Vector2(Input.GetAxis("Horizonal") * moveSpeed, playerRB.velocity.y);

        if (playerRB.velocity.x < 0 && facingRight)
        {
            //yüzünü çevir
            FlipFace();
        }
        else if (playerRB.velocity.x > 0 && facingRight)
        {
            //yüzünü çevir
            FlipFace();
        }
    }

    void FlipFace()
    {
        facingRight = !facingRight;
        Vector3 templocalScale = transform.localScale;
        templocalScale.x *= -1;
        transform.localScale = templocalScale;
    }
}
