using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;

    Vector2 movement;

    void Start(){
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

    }

    // Update is called once per frame
    void Update()
    {
        //input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //testes barra de vida
        if(Input.GetKeyDown(KeyCode.Space)){

            TakeDamage(20);
        }

        void TakeDamage(int damage){
            currentHealth -= damage;
            healthBar.SetHealth(currentHealth);
        }
    }

    void FixedUpdate(){
        //movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime );

    }

}
