using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterMovement : MonoBehaviour {

    
    public float hiz = 200f;
    public float ziplamaYuksekligi = 100f;
    public float sifirlamaYuksekligi = -15f;

    public bool isGround = false;

    Rigidbody2D rg;

    public Vector2 resetNoktasi;

	void Start () {
        rg = GetComponent<Rigidbody2D>();
        resetNoktasi = transform.position;
	}

    private void FixedUpdate()
    {
        float ziplama = rg.velocity.y;

        if(Input.GetButton("Jump") && isGround)
        {
            ziplama = ziplamaYuksekligi;
        }

        rg.velocity = new Vector2(Input.GetAxis("Horizontal") * hiz * Time.deltaTime, ziplama);
        if (transform.position.y < sifirlamaYuksekligi)
        {
            transform.position = resetNoktasi;
        }

        if (rg.velocity.x > 0f)
        {
            transform.localEulerAngles = new Vector3(0, 0, 0);
        }
        else if (rg.velocity.x < 0f)
        {
            transform.localEulerAngles = new Vector3(0, 180, 0);
        }
    }
}