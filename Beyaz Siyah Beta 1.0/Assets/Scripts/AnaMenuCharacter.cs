using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnaMenuCharacter : MonoBehaviour {
    
    public float hiz = 200f;
    Rigidbody2D rg;

    void Start () {
        rg = GetComponent<Rigidbody2D>();
        Time.timeScale = 1f;
    }

	void Update ()
    {
        Vector2 velocity = new Vector2(hiz * Time.deltaTime, rg.velocity.y);
        rg.velocity = velocity;

        transform.eulerAngles = new Vector3(0, hiz > 0f ? 0 : -180, 0);
    }
}
