public class RandomDynamicPrefab : MonoBehaviour, IClientComponent, ILOD // TypeDefIndex: 12064
{
	public uint Seed; 
	public float Distance; 
	public float Probability; 
	public string ResourceFolder; 
	private Prefab prefab; 
	private GameObject instance; 
	private LODCell cell; 


	protected void OnEnable() { }

	protected void OnDisable() { }

	public void RefreshLOD() { }

	public void ChangeLOD() { }

	public void .ctor() { }

}

