using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health;
    private int damagetotake;
    public int damagetoplayer;
    public LayerMask target;
    public GameObject range;
    public GameObject enemyBullet;
    public GameObject enemyGun;
    public float bulletInterval;
    private bool readyToShoot = true;
    private GameObject player;
    public int rewardscore;
    public Score scoreonenemy;

    void Update()
    {
        Debug.DrawLine(enemyGun.transform.position, range.transform.position, Color.white, 2.5f);
        if (Physics2D.Linecast(enemyGun.transform.position, range.transform.position,target) && readyToShoot == true)
        {
            StartCoroutine("Shooting");
        }
    }

    IEnumerator Shooting()
    {
        readyToShoot = false;
        Instantiate(enemyBullet, enemyGun.transform.position, enemyGun.transform.rotation);
        yield return new WaitForSeconds(bulletInterval);
        readyToShoot = true;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            damagetotake = collision.gameObject.GetComponent<Bullet>().damage;
            health -= damagetotake;
            Destroy(collision.gameObject);
            if (health <= 0)
            {
                scoreonenemy.dropscore = rewardscore;
                scoreonenemy.ScoreCall();
                Destroy(gameObject);
            }
        }
    }
}
