using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P2 : MonoBehaviour
{
    public float hp = 1000;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        slider.value = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = hp;
    }
}
