public class GroundWatch : BaseMonoBehaviour, IServerComponent // TypeDefIndex: 11641
{
	public Vector3 groundPosition;
	public LayerMask layers;
	public float radius;
	[HeaderAttribute]
	public BaseEntity[] whitelist;


	public void .ctor() { }

}

