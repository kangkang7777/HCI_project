using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class P1 : MonoBehaviour
{
    public float hp = 1000;
    public Slider slider;
    public float attack = 10.0f;
    public int isDefend = 0;
    public P2 p2;

    // Start is called before the first frame update
    void Start()
    {
        slider.value = 1000;
    }


    // 激光攻击
    public void Attack1()
    {
        p2.hp -= attack;
    }

    public void Attack2()
    {
        p2.hp -= attack;
    }

    public void Attack3()
    {
        p2.hp -= attack * 5;
    }

    public void Buff()
    {
        attack *= 1.2f;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = hp;

        if (hp <= 0)
        {
            SceneManager.LoadScene("LoseScene");
        }
    }
}