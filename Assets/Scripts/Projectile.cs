using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour 
{
	private float _speed;
	public float damagePerShot = 20f;

	void Start(){
		Destroy(gameObject, 5f);
	}


	void Update() {
		transform.Translate (Vector3.forward * _speed * Time.deltaTime);
	}
	public void SetSpeed(float value)
	{
		_speed = value;
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Enemy")) {
			
			other.gameObject.GetComponent<EnemyHealth>().RemoveHealth(damagePerShot);
			Destroy(gameObject);

		}
		 else if (other.CompareTag ("Obstacle")) {


			Destroy(gameObject);

		}
	}


}
	
