using UnityEngine;
using System.Collections;

public class ObjectSpawner : MonoBehaviour {

	
	public bool isSameDelay;
	public bool isRandomObject;
	public bool isRight;
	public GameObject ObjectToSpawn;
	public GameObject[] ObjectsToSpawn;
	public float timeBeforSpawn;
	public float spawnDelay;
	public float MinDelay;
	public float MaxDelay;
	

	void Start () {
		if(isSameDelay)
		{
			InvokeRepeating("Spawn",timeBeforSpawn,spawnDelay);
		}
		else
		{
		StartCoroutine(Spawner());
		}
	}
	
	IEnumerator Spawner()
	{
		yield return new WaitForSeconds(Random.Range(MinDelay,MaxDelay));
		Spawn();
	}
	
	void Spawn () 
	{
		
		if(!isRandomObject){
		//GameObject obj = Instantiate(ObjectToSpawn,transform.position,transform.rotation) as GameObject;
		GameObject obj = Instantiate(ObjectToSpawn,transform.position,transform.rotation) as GameObject;
		}

		if(isRandomObject){
		GameObject obj = Instantiate(ObjectsToSpawn[Random.Range(0,ObjectsToSpawn.Length)],transform.position,transform.rotation) as GameObject;
		}
		if(!isSameDelay){
		StartCoroutine(Spawner());
		}
		
	}
}
