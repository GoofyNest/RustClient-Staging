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

	// RVA: 0x7AD5A0 Offset: 0x7ABBA0 VA: 0x1807AD5A0 Slot: 8
	public override void OpenDialog() { }

	// RVA: 0x7AC9A0 Offset: 0x7AAFA0 VA: 0x1807AC9A0 Slot: 9
	public override void CloseDialog() { }

	// RVA: 0x7ADDC0 Offset: 0x7AC3C0 VA: 0x1807ADDC0
	public void SetScalerEnabled(bool wants) { }

	// RVA: 0x7AC6B0 Offset: 0x7AACB0 VA: 0x1807AC6B0
	public Vector2 CalculateContentSize() { }

	// RVA: 0x7ACCA0 Offset: 0x7AB2A0 VA: 0x1807ACCA0
	public void GetFarthestExtents(TechTreeData.NodeInstance node, ref Vector2 mins, ref Vector2 maxs) { }

	// RVA: 0x7ACA20 Offset: 0x7AB020 VA: 0x1807ACA20
	public Vector2 GetColumnRowIndexForPosition(Vector2 position) { }

	// RVA: 0x7ADE20 Offset: 0x7AC420 VA: 0x1807ADE20
	public void SetWidgetSelected(int id, bool wantsSelected) { }

	// RVA: 0x7AC950 Offset: 0x7AAF50 VA: 0x1807AC950
	public void ClearSelection() { }

	// RVA: 0x7AE350 Offset: 0x7AC950 VA: 0x1807AE350
	public void UpdateSelectedNode(int newSelectedNodeID) { }

	// RVA: 0x7ACAE0 Offset: 0x7AB0E0 VA: 0x1807ACAE0
	public BaseEntity GetContainerEntity() { }

	// RVA: 0x7ADF50 Offset: 0x7AC550 VA: 0x1807ADF50
	public void SetWorkbench(Workbench wb) { }

	// RVA: 0x7ACF70 Offset: 0x7AB570 VA: 0x1807ACF70
	private Workbench GetWorkbench() { }

	// RVA: 0x7ADFA0 Offset: 0x7AC5A0 VA: 0x1807ADFA0
	public void UnlockPressed() { }

	// RVA: 0x7ACF10 Offset: 0x7AB510 VA: 0x1807ACF10
	public Vector2 GetNodeStartPoint() { }

	// RVA: 0x7ADCC0 Offset: 0x7AC2C0 VA: 0x1807ADCC0
	public bool PlayerHasPathForUnlock(TechTreeData.NodeInstance node) { }

	// RVA: 0x7ADB20 Offset: 0x7AC120 VA: 0x1807ADB20
	public bool PlayerCanUnlock(TechTreeData.NodeInstance node) { }

	// RVA: 0x7AD0F0 Offset: 0x7AB6F0 VA: 0x1807AD0F0
	public bool HasPlayerUnlocked(TechTreeData.NodeInstance node) { }

	// RVA: 0x7ACF40 Offset: 0x7AB540 VA: 0x1807ACF40
	public void GetNodesRequiredToUnlock(BasePlayer player, TechTreeData.NodeInstance node, List<TechTreeData.NodeInstance> foundNodes) { }

	// RVA: 0x7ABDB0 Offset: 0x7AA3B0 VA: 0x1807ABDB0
	public void AddSingleNode(TechTreeData.NodeInstance node) { }

	// RVA: 0x7ACF80 Offset: 0x7AB580 VA: 0x1807ACF80
	public bool HasLine(int from, int to) { }

	// RVA: 0x7AB360 Offset: 0x7A9960 VA: 0x1807AB360
	public void AddNodesRecursive(TechTreeData.NodeInstance startNode) { }

	// RVA: 0x7AE050 Offset: 0x7AC650 VA: 0x1807AE050
	public void UpdateLines() { }

	// RVA: 0x7AD1C0 Offset: 0x7AB7C0 VA: 0x1807AD1C0 Slot: 10
	public void OnInventoryChanged() { }

	// RVA: 0x7AE200 Offset: 0x7AC800 VA: 0x1807AE200
	private void UpdateScrapCount() { }

	// RVA: 0x7AE3C0 Offset: 0x7AC9C0 VA: 0x1807AE3C0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7AC950 Offset: 0x7AAF50 VA: 0x1807AC950
	private void <OpenDialog>b__17_0() { }

}

private sealed class TechTreeDialog.<>c__DisplayClass37_0 // TypeDefIndex: 10913
{	// Fields
	public TechTreeDialog <>4__this; // 0x10
	public TechTreeData.NodeInstance node; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7B50D0 Offset: 0x7B36D0 VA: 0x1807B50D0
	internal void <AddSingleNode>b__0() { }

}

