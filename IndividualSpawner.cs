public class IndividualSpawner : BaseMonoBehaviour, IServerComponent // TypeDefIndex: 10007
{
	public GameObjectRef entityPrefab; 
	public float respawnDelayMin; 
	public float respawnDelayMax; 
	public bool useCustomBoundsCheckMask; 
	public LayerMask customBoundsCheckMask; 
	[TooltipAttribute] 
	[SerializeField] 
	private bool oneTimeSpawner; 


	public void .ctor() { }

}

