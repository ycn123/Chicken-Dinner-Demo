using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapons : MonoBehaviour {

    public GameObject[] Weapons;

    GameObject _currentWeapon = null;

    ////碰撞后 打开已放置好的拾取的抢的模型的状态 并销毁碰撞到的other
    private void OnTriggerEnter(Collider other)
    {
        
        Debug.Log(other.name);
        //如果手里有枪则先扔掉
        if (_currentWeapon != null)
        {
            var gun = Instantiate(_currentWeapon);
            gun.transform.position = transform.position + transform.forward*5+new Vector3(0,0.1f,0);
            gun.transform.rotation = Quaternion.identity;

            gun.name = _currentWeapon.name;
            _currentWeapon.SetActive(false);
           
            //Debug.Log(gun.name);
           
            _currentWeapon = null;
        }

        for (int i = 0; i < Weapons.Length; i++)
        {
            Debug.Log(Weapons[i].name);
            if (other.name == Weapons[i].name)
            {
                _currentWeapon = Weapons[i];
                Weapons[i].SetActive(true);
            }
            else
            {
                Weapons[i].SetActive(false);
            }
        }

        Destroy(other.gameObject);
    }

}
