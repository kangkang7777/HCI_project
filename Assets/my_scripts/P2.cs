using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class P2 : MonoBehaviour
{
    public float hp = 2500;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        slider.value = 2500;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = hp;

        if (hp <= 0)
        {
            SceneManager.LoadScene("WinScene");
        }
    }
}
