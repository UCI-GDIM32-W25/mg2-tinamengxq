using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]private CoinCountUI coinCountUI;
    [SerializeField]private int playerSpeed = 5;
    [SerializeField]private Rigidbody2D _rigidbody;
    [SerializeField]private SpriteRenderer _spriteRenderer;
    private bool _isGrounded = true;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x,playerSpeed); 
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            _isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            _isGrounded = false;
        }
    }
    

}

