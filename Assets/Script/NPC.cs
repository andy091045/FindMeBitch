using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



public class NPC : MonoBehaviour
{
    public Animator animator;
    float speed;
    public Transform npc;
    float step;
    public GameObject a;
    public float beat;

    public float x;
    public float y;
    Vector2 movement;

    float timer;
    [SerializeField] Vector2 range = new Vector2(5, 5);

    void Start()
    {
        speed = Random.Range(1, 5);
        movement = a.transform.position;
        movement = new Vector2(Random.Range(-9, 7), Random.Range(-3, 3));
        a.transform.position = movement;
        movement.x = Random.Range(-1, 2);//(-1,1)包含-1但不包含1
        movement.y = Random.Range(-1, 2);
    }

    void Update()
    {
        speed = Random.Range(1, 5);
        moveTo();
    }

    void moveTo()
    {
        if (timer < beat)
        {

            transform.Translate(speed * Time.deltaTime * movement.x, speed * Time.deltaTime * movement.y, 0);
            animator.SetFloat("horizontal", movement.x);
            animator.SetFloat("vertical", movement.y);
            animator.SetFloat("speed", movement.sqrMagnitude);
            if (Mathf.Abs(transform.position.x) > range.x)
            {
                movement.x = -movement.x;
            }

            if (Mathf.Abs(transform.position.y) > range.y)
            {
                movement.y = -movement.y;
            }
            timer += Time.deltaTime;
        }
        else
        {
            movement.x = Random.Range(-1, 2);
            movement.y = Random.Range(-1, 2);
            // y = Random.Range(-1, 2);
            timer = 0;
            Debug.Log("t0");
        }



        // step = speed * Time.deltaTime;
        // npc.position = Vector3.MoveTowards(npc.position, new Vector3(Random.Range(-8, 8), Random.Range(-5, 5), 0), 10);

        // npc.position = new Vector3(Random.Range(-8, 8), Random.Range(-5, 5), -1);     
        // transform.LookAt(npc.position);
        // transform.Translate(Vector3.forward * speed);

        // Invoke("moveTo", 5);
    }
}
