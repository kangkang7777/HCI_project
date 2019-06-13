using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P1 : MonoBehaviour
{
    public float hp = 1000;
    public Slider slider;

    public P2 p2;

    // Start is called before the first frame update
    void Start()
    {
        slider.value = 1000;
    }

    // 自动减血
    public void Damage()
    {
        hp -= Random.Range(10, 20);
    }

    // 激光攻击
    public void Laser()
    {
        p2.hp -= 100;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = hp;
    }
}