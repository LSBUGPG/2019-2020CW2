using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject gun;
    public GameObject bullet;
    private bool readyToShoot = true;
    public float bulletInterval;
    public float AtkSpeedBoostDur;
    public float AtkSpeedBoostAmount;



    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && readyToShoot == true)
        {
            StartCoroutine("PlayerShooting");
        }
    }

    IEnumerator PlayerShooting()
    {
        readyToShoot = false;
        Instantiate(bullet, gun.transform.position, gun.transform.rotation);
        yield return new WaitForSeconds(bulletInterval);
        readyToShoot = true;
    }
    public IEnumerator IncreaseShootSpeed()
    {
        bulletInterval = bulletInterval / AtkSpeedBoostAmount;
        yield return new WaitForSeconds(AtkSpeedBoostDur);
        bulletInterval = bulletInterval * AtkSpeedBoostAmount;
    }
}
