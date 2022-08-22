public class TechTreeDialog : UIDialog, IInventoryChanged // TypeDefIndex: 10912
{	// Fields
	public TechTreeData data; // 0x30
	public float graphScale; // 0x38
	public TechTreeEntry entryPrefab; // 0x40
	public TechTreeGroup groupPrefab; // 0x48
	public TechTreeLine linePrefab; // 0x50
	public RectTransform contents; // 0x58
	public RectTransform contentParent; // 0x60
	public TechTreeSelectedNodeUI selectedNodeUI; // 0x68
	public float nodeSize; // 0x70
	public float gridSize; // 0x74
	public GameObjectRef unlockEffect; // 0x78
	public RustText scrapCount; // 0x80
	private Vector2 startPos; // 0x88
	public List<int> processed; // 0x90
	public Dictionary<int, TechTreeWidget> widgets; // 0x98
	public List<TechTreeLine> lines; // 0xA0
	public ScrollRectZoom zoom; // 0xA8
	private int selectedNodeID; // 0xB0
	private Workbench _attachedWorkbench; // 0xB8

	// Methods

	// RVA: 0x7CBAA0 Offset: 0x7CA0A0 VA: 0x1807CBAA0 Slot: 8
	public override void OpenDialog() { }

	// RVA: 0x7CAEB0 Offset: 0x7C94B0 VA: 0x1807CAEB0 Slot: 9
	public override void CloseDialog() { }

	// RVA: 0x7CC2C0 Offset: 0x7CA8C0 VA: 0x1807CC2C0
	public void SetScalerEnabled(bool wants) { }

	// RVA: 0x7CABC0 Offset: 0x7C91C0 VA: 0x1807CABC0
	public Vector2 CalculateContentSize() { }

	// RVA: 0x7CB1B0 Offset: 0x7C97B0 VA: 0x1807CB1B0
	public void GetFarthestExtents(TechTreeData.NodeInstance node, ref Vector2 mins, ref Vector2 maxs) { }

	// RVA: 0x7CAF30 Offset: 0x7C9530 VA: 0x1807CAF30
	public Vector2 GetColumnRowIndexForPosition(Vector2 position) { }

	// RVA: 0x7CC320 Offset: 0x7CA920 VA: 0x1807CC320
	public void SetWidgetSelected(int id, bool wantsSelected) { }

	// RVA: 0x7CAE60 Offset: 0x7C9460 VA: 0x1807CAE60
	public void ClearSelection() { }

	// RVA: 0x7CC850 Offset: 0x7CAE50 VA: 0x1807CC850
	public void UpdateSelectedNode(int newSelectedNodeID) { }

	// RVA: 0x7CAFF0 Offset: 0x7C95F0 VA: 0x1807CAFF0
	public BaseEntity GetContainerEntity() { }

	// RVA: 0x7CC450 Offset: 0x7CAA50 VA: 0x1807CC450
	public void SetWorkbench(Workbench wb) { }

	// RVA: 0x79BDD0 Offset: 0x79A3D0 VA: 0x18079BDD0
	private Workbench GetWorkbench() { }

	// RVA: 0x7CC4A0 Offset: 0x7CAAA0 VA: 0x1807CC4A0
	public void UnlockPressed() { }

	// RVA: 0x7CB420 Offset: 0x7C9A20 VA: 0x1807CB420
	public Vector2 GetNodeStartPoint() { }

	// RVA: 0x7CC1C0 Offset: 0x7CA7C0 VA: 0x1807CC1C0
	public bool PlayerHasPathForUnlock(TechTreeData.NodeInstance node) { }

	// RVA: 0x7CC020 Offset: 0x7CA620 VA: 0x1807CC020
	public bool PlayerCanUnlock(TechTreeData.NodeInstance node) { }

	// RVA: 0x7CB5F0 Offset: 0x7C9BF0 VA: 0x1807CB5F0
	public bool HasPlayerUnlocked(TechTreeData.NodeInstance node) { }

	// RVA: 0x7CB450 Offset: 0x7C9A50 VA: 0x1807CB450
	public void GetNodesRequiredToUnlock(BasePlayer player, TechTreeData.NodeInstance node, List<TechTreeData.NodeInstance> foundNodes) { }

	// RVA: 0x7CA2C0 Offset: 0x7C88C0 VA: 0x1807CA2C0
	public void AddSingleNode(TechTreeData.NodeInstance node) { }

	// RVA: 0x7CB480 Offset: 0x7C9A80 VA: 0x1807CB480
	public bool HasLine(int from, int to) { }

	// RVA: 0x7C9870 Offset: 0x7C7E70 VA: 0x1807C9870
	public void AddNodesRecursive(TechTreeData.NodeInstance startNode) { }

	// RVA: 0x7CC550 Offset: 0x7CAB50 VA: 0x1807CC550
	public void UpdateLines() { }

	// RVA: 0x7CB6C0 Offset: 0x7C9CC0 VA: 0x1807CB6C0 Slot: 10
	public void OnInventoryChanged() { }

	// RVA: 0x7CC700 Offset: 0x7CAD00 VA: 0x1807CC700
	private void UpdateScrapCount() { }

	// RVA: 0x7CC8C0 Offset: 0x7CAEC0 VA: 0x1807CC8C0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7CAE60 Offset: 0x7C9460 VA: 0x1807CAE60
	private void <OpenDialog>b__17_0() { }

}

private sealed class TechTreeDialog.<>c__DisplayClass37_0 // TypeDefIndex: 10913
{	// Fields
	public TechTreeDialog <>4__this; // 0x10
	public TechTreeData.NodeInstance node; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7D35D0 Offset: 0x7D1BD0 VA: 0x1807D35D0
	internal void <AddSingleNode>b__0() { }

}

