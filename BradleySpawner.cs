public class BradleySpawner : MonoBehaviour, IServerComponent // TypeDefIndex: 8861
{
	public BasePath path; 
	public GameObjectRef bradleyPrefab; 
	public BradleyAPC spawned; 
	public bool initialSpawn; 
	public float minRespawnTimeMinutes; 
	public float maxRespawnTimeMinutes; 
	public static BradleySpawner singleton; 


public void .ctor() { }

}

