using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTreatment : MonoBehaviour {
    public int Hp;
    public int Energy;
    //能量随时间减少的计时器
    float _energyTimer;
    //能量回血的计时器
    float _energyHpTimer;
    // Use this for initialization
    void Start () {
        if (Hp > 100) {
            Hp = 100; 
        }
	}
	
	// Update is called once per frame
	void Update () {
       
        EnergyUpdate();
        BeFight();
        KeyUpdate1();
        KeyUpdate2();
        KeyUpdate3();
        KeyUpdate4();
        KeyUpdate5();
        KeyUpdate6();
    }

    private void KeyUpdate6()
    {
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            UseChemical();
        }
    }

    private void UseChemical()
    {
        Hp += 100;
    }

    private void KeyUpdate5()
    {
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            UseDrug();
        }
    }

    private void UseDrug()
    {
        Hp += 60;
    }

    private void KeyUpdate4()
    {
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            UseRedOx();
        }
    }

    private void UseRedOx()
    {
        Hp += 40;
    }

    private void KeyUpdate3()
    {
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            UseHospital();
        }
    }

    private void UseHospital()
    {
        Hp = 100;
    }

    private void KeyUpdate2()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            UseAid();
        }
    }

    private void UseAid()
    {
        Hp =75;
    }

    private void KeyUpdate1()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            UseBandage();
        }
    }

    void BeFight()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0)) {
            int damage = UnityEngine.Random.Range(0, Hp);
            Hp -= damage;
            Debug.Log("你被打了，现在的血量是：" + Hp);
        }
    } 

    private void UseBandage()
    {
        if (Hp > 75) {
            Debug.Log("无法使用绷带");
                return;
        }
        Hp += 10;
        if (Hp > 75) Hp = 75;
    }

    private void EnergyUpdate()
    {
        //每三秒减少一点能量
        if (Energy > 0)
        {
            _energyTimer = _energyTimer + Time.deltaTime;
            if (_energyTimer >= 3)
            {
                Energy -= 1;
                _energyTimer = 0;
            }
            if (Hp < 100)
            {
                _energyHpTimer += Time.deltaTime;
                //每8秒回血
                if (_energyHpTimer >= 8)
                {
                    //todo根据能量值回血
                    if (Energy <= 20)
                    {
                        Hp += 1;
                    }
                    else if (Energy <= 60)
                    {
                        Hp += 2;
                    }
                    else if (Energy < 90)
                    {
                        Hp += 3;
                    }
                    else
                    {
                        Hp += 4;
                    }
                    if (Hp > 100) Hp = 100;
                    _energyHpTimer = 0;
                    Debug.Log("血量恢复到多少:" + Hp);
                }
            }
        }
    }
}
