using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;
[RequireComponent(typeof(AudioSource))]
public class Boss : MonoBehaviour
{
    public AudioClip impact;
    AudioSource audiosource;
    public Animator animator;
    bool isAttackedKeyPressed = false;
    public Text AttackTime;
    public Text BossLose;
    public int bossAttackTime = 25;
    public GameObject weapon;
    public GameObject weapon1;
    public GameObject weapon2;
    public GameObject weapon3;
    const string BOSSH = "bossh1";
    const string BOSSV = "bossv1";
    public float _speed;// Start is called before the first frame update

    public float beat = (60 / 130) * 2;

    Vector2 movement;



    private float timer;

    public bool AttackKey
    {
        get
        {
            return Input.GetKeyDown(KeyCode.Space);

        }
    }

    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        _speed = 4;
        weapon.SetActive(false);
        weapon1.SetActive(false);
        weapon2.SetActive(false);
        weapon3.SetActive(false);

    }

    void MovementX()
    {
        movement.x = Input.GetAxisRaw(BOSSH);
        movement.y = Input.GetAxisRaw(BOSSV);
        transform.Translate(_speed * Input.GetAxis(BOSSH) * Time.deltaTime, _speed * Input.GetAxis(BOSSV) * Time.deltaTime, 0);
        animator.SetFloat("horizontal", movement.x);
        animator.SetFloat("vertical", movement.y);
        animator.SetFloat("speed", movement.sqrMagnitude);
    }


    void BossAttack()
    {
        if (AttackKey)
            isAttackedKeyPressed = true;
        if (isAttackedKeyPressed && Input.GetAxis(BOSSH) < 0)
        {
            weapon.SetActive(true);
            audiosource.PlayOneShot(impact);
            timer += Time.deltaTime;
            if (timer >= beat)
            {
                weapon.SetActive(false);
                bossAttackTime--;
                AttackTime.text = bossAttackTime + "";
                Debug.Log(bossAttackTime);
                timer = 0;
                isAttackedKeyPressed = false;
            }
        }

        if (isAttackedKeyPressed && Input.GetAxis(BOSSH) > 0)
        {
            weapon1.SetActive(true);
            audiosource.PlayOneShot(impact);
            timer += Time.deltaTime;
            if (timer >= beat)
            {
                weapon1.SetActive(false);
                bossAttackTime--;
                AttackTime.text = bossAttackTime + "";
                Debug.Log(bossAttackTime);
                timer = 0;
                isAttackedKeyPressed = false;
            }
        }

        if (isAttackedKeyPressed && Input.GetAxis(BOSSV) > 0)
        {
            weapon2.SetActive(true);
            audiosource.PlayOneShot(impact);
            timer += Time.deltaTime;
            if (timer >= beat)
            {
                weapon2.SetActive(false);
                bossAttackTime--;
                AttackTime.text = bossAttackTime + "";
                Debug.Log(bossAttackTime);
                timer = 0;
                isAttackedKeyPressed = false;
            }
        }

        if (isAttackedKeyPressed && Input.GetAxis(BOSSV) < 0)
        {
            weapon3.SetActive(true);
            audiosource.PlayOneShot(impact);
            timer += Time.deltaTime;
            if (timer >= beat)
            {
                weapon3.SetActive(false);
                bossAttackTime--;
                AttackTime.text = bossAttackTime + "";
                Debug.Log(bossAttackTime);
                timer = 0;
                isAttackedKeyPressed = false;
            }
        }
    }

    void Attack()
    {
        if (bossAttackTime <= 0)
        {
            BossLose.text = "Chanllengers Win!";
        }
    }

    void Update()
    {
        Attack();
        MovementX();
        BossAttack();
        // weapon.SetActive(false);
    }
}
