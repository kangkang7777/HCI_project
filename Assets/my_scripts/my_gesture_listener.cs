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
        if (gesture == "hands_over_head")
        {
            print("手举过了头..." + userId);
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
