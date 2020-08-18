using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagazineUI : MonoBehaviour
{

	public GameObject gun;
	Gun gunScript;

	int capacity;
	int loaded;
	public GameObject bullet;
	public GameObject bulletAnim;
	GameObject[] bullets;
	float dif;
	Vector2 bulletSize;
	RectTransform rectTransform;
	float top;
	VerticalLayoutGroup spacing;

	void Start()
	{
		spacing = GetComponent<VerticalLayoutGroup>();
		gunScript = gun.GetComponentInParent<Gun>();
		capacity = gunScript.MagCap;
		loaded = gunScript.BulletsLoaded;

		bulletSize = bullet.GetComponent<RectTransform>().rect.size;

		rectTransform = GetComponent<RectTransform>();
		rectTransform.sizeDelta = new Vector2(bulletSize.x + spacing.padding.left + spacing.padding.right, (bulletSize.y * capacity) + (spacing.spacing * (capacity - 1)) + spacing.padding.top + spacing.padding.bottom);

		dif = rectTransform.rect.height;
		top = (dif / 2) - (bulletSize.y / 2);

		//save incase of change to nondynamic mag size
		// float bulletSpace = bulletSize.y * capacity;
		// print (bulletSpace);

		// float extraSpace = dif - bulletSpace;
		// print (extraSpace);

		bullets = new GameObject[capacity];
		for (int i = 0; i < bullets.Length; i++)
		{
			bullets[i] = Instantiate(bullet, transform);
			bullets[i].GetComponent<RectTransform>().localPosition = new Vector3(0, top - (i * (bulletSize.y)), 1);
		}
	}

	void Update() { }

	public void UpdateMag()
	{
		//Destroy (bullets[playerShooting.BulletsLoaded]);
		GameObject bAnim;
		bAnim = (GameObject) Instantiate(bulletAnim, transform);
		bAnim.transform.localPosition = new Vector3(0, top, 1);
		bullets[gunScript.BulletsLoaded].GetComponent<Image>().enabled = false;
	}

	public void ReloadMag()
	{
		foreach (GameObject bullet in bullets)
		{
			bullet.GetComponent<Image>().enabled = true;
		}
	}

}