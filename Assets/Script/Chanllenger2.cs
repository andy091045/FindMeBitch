using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(AudioSource))]
public class Chanllenger2 : MonoBehaviour
{
    public AudioClip impact;
    AudioSource audiosource;
    public deadcount count;
    public GameObject a;
    public Text hp2;
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
            Debug.Log("hp2 lose");
            hp--;
            audiosource.PlayOneShot(impact);
            hp2.text = hp + "";
            if (hp == 0) { count.dead++; }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {


            Debug.Log("hp2 dead");

            Destroy(gameObject);


        }
    }
}
