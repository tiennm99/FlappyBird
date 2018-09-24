using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float flyPower;
    public AudioClip flySound;
    public AudioClip deadSound;
    private GameObject obj;
    private GameObject gameController;
    private AudioSource audioSource;
    private Animator anim;
    void Start()
    {
        obj = gameObject;
        flyPower = 300;
        gameController = GameObject.FindGameObjectWithTag("GameController");
        audioSource = obj.GetComponent<AudioSource>();
        audioSource.clip = flySound;
        anim = obj.GetComponent<Animator>();
        anim.SetBool("isDead", false);
        anim.SetFloat("flyPower", 0);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, flyPower));
            audioSource.Play();
        }
        anim.SetFloat("flyPower", obj.GetComponent<Rigidbody2D>().velocity.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        anim.SetBool("isDead", true);
        audioSource.clip = deadSound;
        audioSource.Play();
        gameController.GetComponent<Control>().EndGame();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameController.GetComponent<Control>().GetPoint();
    }
}
