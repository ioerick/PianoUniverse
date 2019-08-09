using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pianoKey : MonoBehaviour{
    public Sprite keyIddle, keyPressed;
    SpriteRenderer spriteRenderer;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start(){
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetMouseButtonDown(0)) {
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos = new Vector2(wp.x, wp.y);
            if (GetComponent<BoxCollider2D>() == Physics2D.OverlapPoint(mousePos)) {
                spriteRenderer.sprite = keyPressed;
                audioSource.Play();
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            spriteRenderer.sprite = keyIddle;
        }
    }
}
