public class TechTreeData : ScriptableObject // TypeDefIndex: 10014
{	// Fields
	public string shortname; // 0x18
	public int nextID; // 0x20
	private Dictionary<int, TechTreeData.NodeInstance> _idToNode; // 0x28
	private TechTreeData.NodeInstance _entryNode; // 0x30
	public List<TechTreeData.NodeInstance> nodes; // 0x38

	// Methods

	// RVA: 0x7C8A50 Offset: 0x7C7050 VA: 0x1807C8A50
	public TechTreeData.NodeInstance GetByID(int id) { }

	// RVA: 0x7C8D90 Offset: 0x7C7390 VA: 0x1807C8D90
	public TechTreeData.NodeInstance GetEntryNode() { }

	// RVA: 0x7C8900 Offset: 0x7C6F00 VA: 0x1807C8900
	public void ClearInputs(TechTreeData.NodeInstance node) { }

	// RVA: 0x7C9680 Offset: 0x7C7C80 VA: 0x1807C9680
	public void SetupInputs(TechTreeData.NodeInstance node) { }

	// RVA: 0x7C9620 Offset: 0x7C7C20 VA: 0x1807C9620
	public bool PlayerHasPathForUnlock(BasePlayer player, TechTreeData.NodeInstance node) { }

	// RVA: 0x7C85A0 Offset: 0x7C6BA0 VA: 0x1807C85A0
	public bool CheckChainRecursive(BasePlayer player, TechTreeData.NodeInstance start, TechTreeData.NodeInstance target) { }

	// RVA: 0x7C95A0 Offset: 0x7C7BA0 VA: 0x1807C95A0
	public bool PlayerCanUnlock(BasePlayer player, TechTreeData.NodeInstance node) { }

	// RVA: 0x7C9400 Offset: 0x7C7A00 VA: 0x1807C9400
	public bool HasPlayerUnlocked(BasePlayer player, TechTreeData.NodeInstance node) { }

	// RVA: 0x7C8F80 Offset: 0x7C7580 VA: 0x1807C8F80
	public void GetNodesRequiredToUnlock(BasePlayer player, TechTreeData.NodeInstance node, List<TechTreeData.NodeInstance> foundNodes) { }

	// RVA: 0x7C9800 Offset: 0x7C7E00 VA: 0x1807C9800
	public void .ctor() { }

}

public class TechTreeData.NodeInstance // TypeDefIndex: 10015
{	// Fields
	public int id; // 0x10
	public ItemDefinition itemDef; // 0x18
	public Vector2 graphPosition; // 0x20
	public List<int> outputs; // 0x28
	public List<int> inputs; // 0x30
	public string groupName; // 0x38
	public int costOverride; // 0x40

	// Methods

	// RVA: 0x7BA220 Offset: 0x7B8820 VA: 0x1807BA220
	public bool IsGroup() { }

	// RVA: 0x7BA2C0 Offset: 0x7B88C0 VA: 0x1807BA2C0
	public void .ctor() { }

}

private sealed class TechTreeData.<>c // TypeDefIndex: 10016
{	// Fields
	public static readonly TechTreeData.<>c <>9; // 0x0
	public static Func<TechTreeData.NodeInstance, int> <>9__5_0; // 0x8
	public static Func<TechTreeData.NodeInstance, TechTreeData.NodeInstance> <>9__5_1; // 0x10

	// Methods

	// RVA: 0x7D36B0 Offset: 0x7D1CB0 VA: 0x1807D36B0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7D3360 Offset: 0x7D1960 VA: 0x1807D3360
	internal int <GetByID>b__5_0(TechTreeData.NodeInstance n) { }

	// RVA: 0x7D3380 Offset: 0x7D1980 VA: 0x1807D3380
	internal TechTreeData.NodeInstance <GetByID>b__5_1(TechTreeData.NodeInstance n) { }

}

