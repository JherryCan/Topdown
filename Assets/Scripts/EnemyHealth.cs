using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {
	public float healh = 100f;



	public void RemoveHealth(float amount)
	{
		print (healh);
		healh -= amount;
		if (healh <= 0) {
			Destroy (gameObject);
		}	
	}
}