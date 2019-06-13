using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;

public class ClickOptionButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //找到按钮，并且获取按钮的Button组件
        Button btn = GameObject.Find("OptionButton").GetComponent<Button>();
        //注册按钮的点击事件
        btn.onClick.AddListener(delegate () {
            OnClick();
        });

    }

    private void OnClick()
    {
        SceneManager.LoadScene("OptionScene");
    }
    // Update is called once per frame
    void Update()
    {

    }
}