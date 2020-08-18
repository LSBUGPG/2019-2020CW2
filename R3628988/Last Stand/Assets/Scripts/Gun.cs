using System.Collections;
using UnityEngine;

public class Gun : MonoBehaviour
{
	public int damage; 
	public float timeBetweenBullets; 
	public float range = 100f; 

	float timer; 
	Ray shootRay; 
	RaycastHit shootHit; 
	public LayerMask raycastMask;
	public ParticleSystem gunParticles; 
	public LineRenderer gunLine; 
	public AudioSource gunAudio;
	public Light gunLight; 

	public Transform barrelExit;

	[Range(0, 0.1f)]
	public float effectsDisplayTime; 
	public int magCap;
	[HideInInspector]
	public int bulletsLoaded;
	EnemyManager enemyManager;

	public GameObject magazineUI;

	public int rpm;

	bool canShoot;

	public bool fullAuto;

	void Start()
	{
		bulletsLoaded = magCap;

		enemyManager = GameObject.Find("EnemyManager").GetComponent<EnemyManager>();
		canShoot = true;

		timeBetweenBullets = 60f / rpm;
	}

	void Update()
	{
		if (bulletsLoaded > 0)
		{
			if (canShoot)
			{
				if (fullAuto)
				{
					if (Input.GetMouseButton(0))
					{
						Shoot();
					}
				}
				else
				{
					if (Input.GetMouseButtonDown(0))
					{
						Shoot();
					}
				}
			}

		}
	}

	IEnumerator ShootWaiter()
	{
		yield return new WaitForSeconds(timeBetweenBullets);
		canShoot = true;
	}

	IEnumerator EffectsWaiter()
	{
		yield return new WaitForSeconds(effectsDisplayTime);
		gunLine.enabled = false;
		gunLight.enabled = false;
	}

	public int BulletsLoaded
	{
		get { return bulletsLoaded; }
		set { bulletsLoaded = value; }
	}

	public int MagCap
	{
		get { return magCap; }
		set { magCap = value; }
	}

	void Reload()
	{
		bulletsLoaded = magCap;
		magazineUI.GetComponent<MagazineUI>().ReloadMag();
	}

	void Shoot()
	{
		bulletsLoaded -= 1;
		magazineUI.GetComponent<MagazineUI>().UpdateMag();

		canShoot = false;

		if (bulletsLoaded == 0)
		{
			Invoke("Reload", 1);
		}

		StartCoroutine(ShootWaiter());
		StartCoroutine(EffectsWaiter());

		gunAudio.Play();
		gunLight.enabled = true;

		gunParticles.Stop();
		gunParticles.Play();


		gunLine.enabled = true;
		gunLine.SetPosition(0, barrelExit.position);

	
		shootRay.origin = barrelExit.position;
		shootRay.direction = barrelExit.right;
		if (Physics.Raycast(shootRay, out shootHit, range, raycastMask))
		{
	
			EnemyHealth enemyHealth = shootHit.collider.GetComponent<EnemyHealth>();

			if (enemyHealth != null)
			{
				
				if (shootHit.collider.GetType() == typeof(BoxCollider))
				{
					
					enemyHealth.TakeDamage(100, shootHit.point);
				}
				else
				{
					enemyHealth.TakeDamage(damage, shootHit.point);
				}
			}
			
			gunLine.SetPosition(1, shootHit.point);
			//print (shootHit.point);
		}
		
		else
		{
			
			gunLine.SetPosition(1, shootRay.origin + shootRay.direction * range);
		}

		
		if (Random.Range(1, 10) == 1)
		{
			enemyManager.SpawnOneMore();
		}

	}
}