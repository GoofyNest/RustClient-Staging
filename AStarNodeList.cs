public class AStarNodeList : List<AStarNode> // TypeDefIndex: 12147
{	// Fields
	private readonly AStarNodeList.AStarNodeComparer comparer; // 0x28

	// Methods

	// RVA: 0x4BA3A0 Offset: 0x4B89A0 VA: 0x1804BA3A0
	public bool Contains(BasePathNode n) { }

	// RVA: 0x4BA450 Offset: 0x4B8A50 VA: 0x1804BA450
	public AStarNode GetAStarNodeOf(BasePathNode n) { }

	// RVA: 0x4BA360 Offset: 0x4B8960 VA: 0x1804BA360
	public void AStarNodeSort() { }

	// RVA: 0x4BA510 Offset: 0x4B8B10 VA: 0x1804BA510
	public void .ctor() { }

}

private class AStarNodeList.AStarNodeComparer : IComparer<AStarNode> // TypeDefIndex: 12148
{	// Methods

	// RVA: 0x4BA310 Offset: 0x4B8910 VA: 0x1804BA310 Slot: 4
	private int System.Collections.Generic.IComparer<Rust.AI.AStarNode>.Compare(AStarNode lhs, AStarNode rhs) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

