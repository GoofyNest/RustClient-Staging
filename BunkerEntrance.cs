public class BunkerEntrance : BaseEntity, IMissionEntityListener // TypeDefIndex: 10551
{
	public GameObjectRef portalPrefab; 
	public GameObjectRef doorPrefab; 
	public Transform portalSpawnPoint; 
	public Transform doorSpawnPoint; 
	public Door doorInstance; 
	public BasePortal portalInstance; 


	public void .ctor() { }

}
