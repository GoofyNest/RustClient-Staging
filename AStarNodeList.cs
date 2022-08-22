public class AStarNodeList : List<AStarNode> // TypeDefIndex: 12147
{	// Fields
	private readonly AStarNodeList.AStarNodeComparer comparer; // 0x28

	// Methods

	// RVA: 0x4BA330 Offset: 0x4B8930 VA: 0x1804BA330
	public bool Contains(BasePathNode n) { }

	// RVA: 0x4BA3E0 Offset: 0x4B89E0 VA: 0x1804BA3E0
	public AStarNode GetAStarNodeOf(BasePathNode n) { }

	// RVA: 0x4BA2F0 Offset: 0x4B88F0 VA: 0x1804BA2F0
	public void AStarNodeSort() { }

	// RVA: 0x4BA4A0 Offset: 0x4B8AA0 VA: 0x1804BA4A0
	public void .ctor() { }

}

private class AStarNodeList.AStarNodeComparer : IComparer<AStarNode> // TypeDefIndex: 12148
{	// Methods

	// RVA: 0x4BA2A0 Offset: 0x4B88A0 VA: 0x1804BA2A0 Slot: 4
	private int System.Collections.Generic.IComparer<Rust.AI.AStarNode>.Compare(AStarNode lhs, AStarNode rhs) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

