using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMovement : MonoBehaviour
{
    public GameObject gameover;
    Rigidbody2D Rb;
    public float jumpForce;
    float score;
    public Text scoreTxt;
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = "Score : " + score;


        if(Input.GetMouseButtonDown(0))
        {
            Rb.velocity = Vector2.up * jumpForce;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="point")
        {
            score += 50;
        }
        if(collision.gameObject.tag =="pipa")
        {
            Destroy(gameObject);
            gameover.gameObject.SetActive(true);
        }
    }
}
