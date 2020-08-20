using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(AudioSource))]

public class Chanllenger : MonoBehaviour
{
    public AudioClip impact;
    AudioSource audiosource;
    public deadcount count;

    public GameObject a;
    public Text hp1;
    int hp = 7;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        Vector3 move = a.transform.position;
        move = new Vector3(Random.Range(-8, 7), Random.Range(-3, 3), 0);
        a.transform.position = move;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "WeaponLeft" || col.name == "WeaponRight" || col.name == "WeaponBottom" || col.name == "WeaponUp")
        {
            Debug.Log("hp1 lose");
            hp--;
            audiosource.PlayOneShot(impact);
            hp1.text = hp + "";
            if (hp == 0) { count.dead++; }
        }


    }
    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {


            Debug.Log("c1 dead");

            Destroy(gameObject);


        }
    }
}
