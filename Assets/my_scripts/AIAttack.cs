using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIAttack : MonoBehaviour
{
    public ParticleSystem light;
    public ParticleSystem angry;
    public P1 p1;
    private float attack = 10.0f;

    private float time1 = 0;
    private float time2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time1 += Time.deltaTime;
        time2 += Time.deltaTime;
        if (time1 > 5.0f)
        {
            time1 = 0;
            light.Play();
            if(p1.isDefend == 0)
                p1.hp -= attack * 10;
        }
        if (time2 > 10.0f)
        {
            time2 = 0;
            angry.Play();
            attack *= 1.2f;
        }
    }
}
