﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilBehavior2 : MonoBehaviour 
{
	public GameObject[] ParticlesToSpawn;
	public float BlastRadius = 5f;



	private void OnCollisionEnter(Collision other) 
		{
			
			if (other.transform.tag =="WaterSplash") 
			{
				GameObject.Find("Player1_Kart").GetComponent<CanonShootP1>().isDestroyed=true;
				Instantiate(ParticlesToSpawn[4], transform.position, transform.rotation);
				Destroy(gameObject);
			}
			else if (other.transform.tag =="TerrainTag")
			{
				GameObject.Find("Player1_Kart").GetComponent<CanonShootP1>().isDestroyed=true;
				Instantiate(ParticlesToSpawn[0], transform.position, transform.rotation);
				Destroy(gameObject);
			}
			else if (other.transform.tag =="PlayerTag")
			{
				GameObject.Find("Player1_Kart").GetComponent<CanonShootP1>().isDestroyed=true;
				Instantiate(ParticlesToSpawn[1], transform.position, transform.rotation);
				Destroy(gameObject);
			}
			else if (other.transform.tag == "TreeTag")
			{
				GameObject.Find("Player1_Kart").GetComponent<CanonShootP1>().isDestroyed=true;
				Instantiate(ParticlesToSpawn[2], transform.position, transform.rotation);
				Destroy(gameObject);
			}
			else if (other.transform.tag == "RockTag")
			{

				GameObject.Find("Player1_Kart").GetComponent<CanonShootP1>().isDestroyed=true;
				Instantiate(ParticlesToSpawn[3], transform.position, transform.rotation);
				Destroy(gameObject);
			}else{
				print(other.transform.name);
			}
	
		}	
		
}
