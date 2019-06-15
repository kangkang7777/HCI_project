using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class my_gesture_listener : MonoBehaviour, VisualGestureListenerInterface
{
    public P1 p1;

	//动作姿态完成
	public bool GestureCompleted(long userId, int userIndex, string gesture, float confidence)
	{
		//姿势检测后触发的事件在这里写
		if (gesture == "touch_jj") 
		{
			print("摸鸡鸡..."+userId);
            p1.Laser();
		}

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

        }
        //手右滑
        if (gesture == "interact_right")
        {

        }
        ////////////交互////////////

        //爆气，加buff
        if (gesture == "powerup")
        {

        }
        //防御
        if (gesture == "defend")
        {

        }
        //小技能：激光
        if (gesture == "attack_1")
        {

        }
        //小技能：龟派气功
        if (gesture == "attack_2")
        {

        }
        //大技能
        if (gesture == "attack_3")
        {

        }
        return true;
		//throw new System.NotImplementedException();
	}
	//检测动作姿态过程
	public void GestureInProgress(long userId, int userIndex, string gesture, float progress)
	{

	}
	void Start () {

	}
	void Update () {

	}
}
