public class GroundWatch : BaseMonoBehaviour, IServerComponent // TypeDefIndex: 11624
{
	public Vector3 groundPosition; 
	public LayerMask layers; 
	public float radius; 
	[HeaderAttribute] 
	public BaseEntity[] whitelist; 


	public void .ctor() { }

}

