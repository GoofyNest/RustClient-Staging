public class AStarNode // TypeDefIndex: 12146
{	// Fields
	public AStarNode Parent; // 0x10
	public float G; // 0x18
	public float H; // 0x1C
	public BasePathNode Node; // 0x20

	// Properties
	public float F { get; }

	// Methods

	// RVA: 0x4BA6C0 Offset: 0x4B8CC0 VA: 0x1804BA6C0
	public float get_F() { }

	// RVA: 0x4BA650 Offset: 0x4B8C50 VA: 0x1804BA650
	public void .ctor(float g, float h, AStarNode parent, BasePathNode node) { }

	// RVA: 0x4BA610 Offset: 0x4B8C10 VA: 0x1804BA610
	public void Update(float g, float h, AStarNode parent, BasePathNode node) { }

	// RVA: 0x4BA5A0 Offset: 0x4B8BA0 VA: 0x1804BA5A0
	public bool Satisfies(BasePathNode node) { }

	// RVA: 0x4BA710 Offset: 0x4B8D10 VA: 0x1804BA710
	public static bool op_LessThan(AStarNode lhs, AStarNode rhs) { }

	// RVA: 0x4BA6D0 Offset: 0x4B8CD0 VA: 0x1804BA6D0
	public static bool op_GreaterThan(AStarNode lhs, AStarNode rhs) { }

}
