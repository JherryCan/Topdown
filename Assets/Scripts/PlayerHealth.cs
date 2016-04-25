using UnityEngine; 
using System.Collections; 


public class PlayerHealth : MonoBehaviour { 


	public float maxHealth = 100f; 
	public float curHealth = 100f; 

	public float healthBarLength; 

	// Use this for initialization 
	void Start () { 
		healthBarLength = Screen.width / 2; 
	} 

	// Update is called once per frame 
	void Update () { 
		AdjustCurrentHealth(0); 
	} 

	void OnGUI() { 

		GUI.Box (new Rect (10, 10, healthBarLength, 20), curHealth + "/" + maxHealth); 


	} 


	public void AdjustCurrentHealth(int adj) { 
		curHealth += adj; 

		if(curHealth < 0) 
			curHealth = 0; 

		if (curHealth > maxHealth) 
			curHealth  = maxHealth; 

		if (maxHealth < 1) 
			maxHealth = 1;    

		healthBarLength = (Screen.width / 2) * (curHealth / (float)maxHealth); 


	} 
	public void removeHealth(float amount)
	{
		print (curHealth);
		curHealth -= amount;
		if (curHealth <= 0) {
			Destroy (gameObject);
		}	
	}
} 