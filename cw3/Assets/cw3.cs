using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw3 : MonoBehaviour


     //hero
    string heroName = "maryam";
    int heroPower = 5000;

    //villain
    string villainName = "maryam";
    int villainPower = 100;

    //speed
    float playerSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (villainPower > heroPower)
        {
            print("villain is stronger");
        }
        else if (villainPower < heroPower)
        {
            print("hero is stonger");
        }
        else
        {
            print("poth are strong");
        }
        SetSpeed(2.5f);
    }

    void SetSpeed(float speed)
    {
        print(playerSpeed);
        playerSpeed = speed;
        print(playerSpeed);
    }
      {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
