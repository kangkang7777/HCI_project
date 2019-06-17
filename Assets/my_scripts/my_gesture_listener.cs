using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class my_gesture_listener : MonoBehaviour, VisualGestureListenerInterface
{
    public ParticleSystem angry;
    public ParticleSystem damage;
    public ParticleSystem light;
    public ParticleSystem lightBackgroung;
    public ParticleSystem defend;
    public ParticleSystem red;
    public ParticleSystem orange;
    public ParticleSystem yellow;
    public ParticleSystem green;
    public ParticleSystem grey;
    public ParticleSystem blue;
    public ParticleSystem purple;
    public ParticleSystem rainbowBackground;
    public ParticleSystem bo;

    public ParticleSystem emeryDamage;

    public P1 p1;
    public AudioSource attack1;
    public AudioSource attack2;
    public AudioSource attack3;
    public AudioSource shield;
    public AudioSource buff;

    private float timer1 = 0;
    private float timer2 = -20;

    //动作姿态完成
    public bool GestureCompleted(long userId, int userIndex, string gesture, float confidence)
	{

        //相同gesture识别时间需要有间隔
        ////////////交互////////////
        //或许需要加一个flag，让其只在开始界面能识别，防止误判
        //确认，握手
        if (gesture == "interact_click")
        {
            print("测试." + userId);

        }
        //手左滑
        if (gesture == "interact_left")
        {
            print("左." + userId);
        }
        //手右滑
        if (gesture == "interact_right")
        {
            print("右." + userId);
        }
        ////////////交互////////////

        //爆气，加buff
        if (gesture == "powerup")
        {
            angry.Play();
            buff.Play();
            p1.Buff();
        }
        //防御
        if (gesture == "defend")
        {
            defend.Play();
            shield.Play();
            timer2 = timer1;
        }
        //小技能：激光
        if (gesture == "attack_1")
        {
            light.Play();
            lightBackgroung.Play();
            attack1.Play();
            p1.Attack1();
            emeryDamage.Play();
        }
        //小技能：龟派气功
        if (gesture == "attack_2")
        {
            print("龟派气功" + userId);
            bo.Play();
            attack2.Play();
            p1.Attack2();
            emeryDamage.Play();
        }
        //大技能
        if (gesture == "attack_3")
        {
            red.Play();
            yellow.Play();
            orange.Play();
            green.Play();
            grey.Play();
            blue.Play();
            purple.Play();
            rainbowBackground.Play();
            attack3.Play();
            p1.Attack3();
            emeryDamage.Play();
        }
        return true;
		//throw new System.NotImplementedException();
	}
	//检测动作姿态过程
	public void GestureInProgress(long userId, int userIndex, string gesture, float progress)
	{

	}
	void Start () {
        defend.Pause();
        red.Pause();
        yellow.Pause();
        orange.Pause();
        green.Pause();
        grey.Pause();
        blue.Pause();
        purple.Pause();
        rainbowBackground.Pause();
        light.Pause();
        lightBackgroung.Pause();
    }
	void Update () {
        timer1 += Time.deltaTime;
        if ((timer1 - 1) <= timer2)
            p1.isDefend = 1;
        else p1.isDefend = 0;

    }
}
