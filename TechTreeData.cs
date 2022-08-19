public class TechTreeData : ScriptableObject // TypeDefIndex: 10014
{	// Fields
	public string shortname; // 0x18
	public int nextID; // 0x20
	private Dictionary<int, TechTreeData.NodeInstance> _idToNode; // 0x28
	private TechTreeData.NodeInstance _entryNode; // 0x30
	public List<TechTreeData.NodeInstance> nodes; // 0x38

	// Methods

	// RVA: 0x7AA540 Offset: 0x7A8B40 VA: 0x1807AA540
	public TechTreeData.NodeInstance GetByID(int id) { }

	// RVA: 0x7AA880 Offset: 0x7A8E80 VA: 0x1807AA880
	public TechTreeData.NodeInstance GetEntryNode() { }

	// RVA: 0x7AA3F0 Offset: 0x7A89F0 VA: 0x1807AA3F0
	public void ClearInputs(TechTreeData.NodeInstance node) { }

	// RVA: 0x7AB170 Offset: 0x7A9770 VA: 0x1807AB170
	public void SetupInputs(TechTreeData.NodeInstance node) { }

	// RVA: 0x7AB110 Offset: 0x7A9710 VA: 0x1807AB110
	public bool PlayerHasPathForUnlock(BasePlayer player, TechTreeData.NodeInstance node) { }

	// RVA: 0x7AA090 Offset: 0x7A8690 VA: 0x1807AA090
	public bool CheckChainRecursive(BasePlayer player, TechTreeData.NodeInstance start, TechTreeData.NodeInstance target) { }

	// RVA: 0x7AB090 Offset: 0x7A9690 VA: 0x1807AB090
	public bool PlayerCanUnlock(BasePlayer player, TechTreeData.NodeInstance node) { }

	// RVA: 0x7AAEF0 Offset: 0x7A94F0 VA: 0x1807AAEF0
	public bool HasPlayerUnlocked(BasePlayer player, TechTreeData.NodeInstance node) { }

	// RVA: 0x7AAA70 Offset: 0x7A9070 VA: 0x1807AAA70
	public void GetNodesRequiredToUnlock(BasePlayer player, TechTreeData.NodeInstance node, List<TechTreeData.NodeInstance> foundNodes) { }

	// RVA: 0x7AB2F0 Offset: 0x7A98F0 VA: 0x1807AB2F0
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

	// RVA: 0x79BD10 Offset: 0x79A310 VA: 0x18079BD10
	public bool IsGroup() { }

	// RVA: 0x79BDB0 Offset: 0x79A3B0 VA: 0x18079BDB0
	public void .ctor() { }

}

private sealed class TechTreeData.<>c // TypeDefIndex: 10016
{	// Fields
	public static readonly TechTreeData.<>c <>9; // 0x0
	public static Func<TechTreeData.NodeInstance, int> <>9__5_0; // 0x8
	public static Func<TechTreeData.NodeInstance, TechTreeData.NodeInstance> <>9__5_1; // 0x10

	// Methods

	// RVA: 0x7B51B0 Offset: 0x7B37B0 VA: 0x1807B51B0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7B4E60 Offset: 0x7B3460 VA: 0x1807B4E60
	internal int <GetByID>b__5_0(TechTreeData.NodeInstance n) { }

	// RVA: 0x7B4E80 Offset: 0x7B3480 VA: 0x1807B4E80
	internal TechTreeData.NodeInstance <GetByID>b__5_1(TechTreeData.NodeInstance n) { }

}

