public class TechTreeData : ScriptableObject // TypeDefIndex: 10014
{	// Fields
	public string shortname; // 0x18
	public int nextID; // 0x20
	private Dictionary<int, TechTreeData.NodeInstance> _idToNode; // 0x28
	private TechTreeData.NodeInstance _entryNode; // 0x30
	public List<TechTreeData.NodeInstance> nodes; // 0x38

	// Methods

	// RVA: 0x7AA650 Offset: 0x7A8C50 VA: 0x1807AA650
	public TechTreeData.NodeInstance GetByID(int id) { }

	// RVA: 0x7AA990 Offset: 0x7A8F90 VA: 0x1807AA990
	public TechTreeData.NodeInstance GetEntryNode() { }

	// RVA: 0x7AA500 Offset: 0x7A8B00 VA: 0x1807AA500
	public void ClearInputs(TechTreeData.NodeInstance node) { }

	// RVA: 0x7AB280 Offset: 0x7A9880 VA: 0x1807AB280
	public void SetupInputs(TechTreeData.NodeInstance node) { }

	// RVA: 0x7AB220 Offset: 0x7A9820 VA: 0x1807AB220
	public bool PlayerHasPathForUnlock(BasePlayer player, TechTreeData.NodeInstance node) { }

	// RVA: 0x7AA1A0 Offset: 0x7A87A0 VA: 0x1807AA1A0
	public bool CheckChainRecursive(BasePlayer player, TechTreeData.NodeInstance start, TechTreeData.NodeInstance target) { }

	// RVA: 0x7AB1A0 Offset: 0x7A97A0 VA: 0x1807AB1A0
	public bool PlayerCanUnlock(BasePlayer player, TechTreeData.NodeInstance node) { }

	// RVA: 0x7AB000 Offset: 0x7A9600 VA: 0x1807AB000
	public bool HasPlayerUnlocked(BasePlayer player, TechTreeData.NodeInstance node) { }

	// RVA: 0x7AAB80 Offset: 0x7A9180 VA: 0x1807AAB80
	public void GetNodesRequiredToUnlock(BasePlayer player, TechTreeData.NodeInstance node, List<TechTreeData.NodeInstance> foundNodes) { }

	// RVA: 0x7AB400 Offset: 0x7A9A00 VA: 0x1807AB400
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

	// RVA: 0x79BE20 Offset: 0x79A420 VA: 0x18079BE20
	public bool IsGroup() { }

	// RVA: 0x79BEC0 Offset: 0x79A4C0 VA: 0x18079BEC0
	public void .ctor() { }

}

private sealed class TechTreeData.<>c // TypeDefIndex: 10016
{	// Fields
	public static readonly TechTreeData.<>c <>9; // 0x0
	public static Func<TechTreeData.NodeInstance, int> <>9__5_0; // 0x8
	public static Func<TechTreeData.NodeInstance, TechTreeData.NodeInstance> <>9__5_1; // 0x10

	// Methods

	// RVA: 0x7B52C0 Offset: 0x7B38C0 VA: 0x1807B52C0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7B4F70 Offset: 0x7B3570 VA: 0x1807B4F70
	internal int <GetByID>b__5_0(TechTreeData.NodeInstance n) { }

	// RVA: 0x7B4F90 Offset: 0x7B3590 VA: 0x1807B4F90
	internal TechTreeData.NodeInstance <GetByID>b__5_1(TechTreeData.NodeInstance n) { }

}

