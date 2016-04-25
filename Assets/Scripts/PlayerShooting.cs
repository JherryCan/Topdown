using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {
	
	public float bulletSpeed;
	public Transform muzzle;
	public Projectile projectile;
	public float shootRate;
	private AudioSource audioSource;
	public AudioClip destroysound;
	public float damagePerShot = 20f;




	private float nextFireTime;

	void Start()
	{
		nextFireTime = 0;
		audioSource = GetComponent<AudioSource>();
	}

	void Update()
	{
		if (Input.GetMouseButton (0) && (Time.time >= nextFireTime)) {
			Shoot ();
		}


	}
	private void Shoot()
	{
		Projectile bullet = Instantiate (projectile, muzzle.position, muzzle.rotation) as Projectile;
		bullet.SetSpeed (bulletSpeed);
		nextFireTime = Time.time + shootRate;

			audioSource.Play();


	}

}





