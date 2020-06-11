using UnityEngine;

public class Gun : MonoBehaviour
{
    public int damage = 10;
    public float range = 100f;
    public float impactForce = 300f;

    public Camera fpsCam;
    public ParticleSystem muzzleFlash;

    public timeManager tm;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        muzzleFlash.Play();

        tm.DoSlowmotion();

        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if(target != null)
            {
                target.TakeDamage(damage);
            }

            if(hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(hit.normal * impactForce);
            }
        }
    }
}
