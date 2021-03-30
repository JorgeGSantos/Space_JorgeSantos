using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invaders : MonoBehaviour
{

    [SerializeField]
    GameObject InvasorA;

    [SerializeField]
    GameObject InvasorB;

    [SerializeField]
    GameObject InvasorC;

    [SerializeField]
    int nInvasores = 7;

    [SerializeField]
    float xMin = -3f;

    [SerializeField]
    float yMin = -0.5f;

    [SerializeField]
    float xInc = 1f;

    [SerializeField]
    float yInc = 0.5f;


    void Awake()
    {
        float y = xMin;

        for (int line = 0; line < 5; line++)
        {
            GameObject invader = null;
            if (line == 0 || line == 1)
            {
                invader = InvasorA;
            }
            else if (line == 2 || line == 3)
            {
                invader = InvasorB;
            }
            else if (line == 4)
            {
                invader = InvasorC;
            }

            float x = xMin;
            for (int i = 1; i <= nInvasores; i++)
            {
                GameObject newInvader = Instantiate(invader, transform);
                newInvader.transform.position = new Vector3(x, y, 0f);
                x += xInc;  
            }
            y += yInc;
        }
    }      

    // Update is called once per frame
    void Update()
    {
        
    }
}
