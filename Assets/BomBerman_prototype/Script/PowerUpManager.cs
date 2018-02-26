using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour 
{
	public int BombCount;
	public GameObject _goSpeedUp;
	public static PowerUpManager Instance;


	void Awake()
	{
		if(Instance!=null)
		Instance = this;
	}

	void Start () 
	{
		GeneratePowerup ();
	}
	

	void Update () {
		
	}

	public virtual void ChangeSpeed()
	{
		
	}
	public virtual void UpgaredBombCount()
	{
		
	}
	public virtual void LongBlastingCount()
	{
		
	}
	public static  bool Spawn;
	public static bool mbRegenarate;
	public void GeneratePowerup()
	{
		int x = Random.Range (1, 9);
		int z = Random.Range (1, 8);

		do {
			{
				GameObject obj = Instantiate (_goSpeedUp,
					               new Vector3 (x, _goSpeedUp.transform.position.y, z), _goSpeedUp.transform.rotation);
				//Spawn = true;
			}
			
		} while(mbRegenarate);

	}
}
