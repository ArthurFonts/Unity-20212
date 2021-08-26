using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidade;
    public bool flip;

    private SpriteRenderer spriteRenderer;



    // Start is called before the first frame update
    void Start()
    {
        velocidade = 0;
        flip = false;

        
        
    }

    // Update is called once per frame
    void Update()
    {
        //se tecla for apertada rs 
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            velocidade = 0.1f;
            flip = false;

        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            velocidade = 0;
            flip = false;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            velocidade = -0.2f;
            flip = true;

        }



        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            velocidade = 0;
            flip = true;

        }

        transform.Translate(velocidade, 0, 0);
        spriteRenderer.flipX = flip;



    }
}
