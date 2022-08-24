public class SpawnGroup : BaseMonoBehaviour, IServerComponent // TypeDefIndex: 10008
{
	[InspectorFlagsAttribute] 
	public MonumentTier Tier; 
	public List<SpawnGroup.SpawnEntry> prefabs; 
	public int maxPopulation; 
	public int numToSpawnPerTickMin; 
	public int numToSpawnPerTickMax; 
	public float respawnDelayMin; 
	public float respawnDelayMax; 
	public bool wantsInitialSpawn; 
	public bool temporary; 
	public bool forceInitialSpawn; 
	public bool preventDuplicates; 
	public BoxCollider setFreeIfMovedBeyond; 


public void .ctor() { }

}

public class SpawnGroup.SpawnEntry // TypeDefIndex: 10009
{
	public GameObjectRef prefab; 
	public int weight; 
	public bool mobile; 


public void .ctor() { }

}

