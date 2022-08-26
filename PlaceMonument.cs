public class PlaceMonument : ProceduralComponent // TypeDefIndex: 10545
{
	public SpawnFilter Filter; 
	public GameObjectRef Monument; 
	private const int Attempts = 10000;


	public override void Process(uint seed) { }

	public void .ctor() { }

}

private struct PlaceMonument.SpawnInfo // TypeDefIndex: 10546
{
	public Prefab prefab; 
	public Vector3 position; 
	public Quaternion rotation; 
	public Vector3 scale; 

}

