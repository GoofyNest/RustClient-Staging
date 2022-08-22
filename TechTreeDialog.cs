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

	// RVA: 0x7AD6B0 Offset: 0x7ABCB0 VA: 0x1807AD6B0 Slot: 8
	public override void OpenDialog() { }

	// RVA: 0x7ACAB0 Offset: 0x7AB0B0 VA: 0x1807ACAB0 Slot: 9
	public override void CloseDialog() { }

	// RVA: 0x7ADED0 Offset: 0x7AC4D0 VA: 0x1807ADED0
	public void SetScalerEnabled(bool wants) { }

	// RVA: 0x7AC7C0 Offset: 0x7AADC0 VA: 0x1807AC7C0
	public Vector2 CalculateContentSize() { }

	// RVA: 0x7ACDB0 Offset: 0x7AB3B0 VA: 0x1807ACDB0
	public void GetFarthestExtents(TechTreeData.NodeInstance node, ref Vector2 mins, ref Vector2 maxs) { }

	// RVA: 0x7ACB30 Offset: 0x7AB130 VA: 0x1807ACB30
	public Vector2 GetColumnRowIndexForPosition(Vector2 position) { }

	// RVA: 0x7ADF30 Offset: 0x7AC530 VA: 0x1807ADF30
	public void SetWidgetSelected(int id, bool wantsSelected) { }

	// RVA: 0x7ACA60 Offset: 0x7AB060 VA: 0x1807ACA60
	public void ClearSelection() { }

	// RVA: 0x7AE460 Offset: 0x7ACA60 VA: 0x1807AE460
	public void UpdateSelectedNode(int newSelectedNodeID) { }

	// RVA: 0x7ACBF0 Offset: 0x7AB1F0 VA: 0x1807ACBF0
	public BaseEntity GetContainerEntity() { }

	// RVA: 0x7AE060 Offset: 0x7AC660 VA: 0x1807AE060
	public void SetWorkbench(Workbench wb) { }

	// RVA: 0x7AD080 Offset: 0x7AB680 VA: 0x1807AD080
	private Workbench GetWorkbench() { }

	// RVA: 0x7AE0B0 Offset: 0x7AC6B0 VA: 0x1807AE0B0
	public void UnlockPressed() { }

	// RVA: 0x7AD020 Offset: 0x7AB620 VA: 0x1807AD020
	public Vector2 GetNodeStartPoint() { }

	// RVA: 0x7ADDD0 Offset: 0x7AC3D0 VA: 0x1807ADDD0
	public bool PlayerHasPathForUnlock(TechTreeData.NodeInstance node) { }

	// RVA: 0x7ADC30 Offset: 0x7AC230 VA: 0x1807ADC30
	public bool PlayerCanUnlock(TechTreeData.NodeInstance node) { }

	// RVA: 0x7AD200 Offset: 0x7AB800 VA: 0x1807AD200
	public bool HasPlayerUnlocked(TechTreeData.NodeInstance node) { }

	// RVA: 0x7AD050 Offset: 0x7AB650 VA: 0x1807AD050
	public void GetNodesRequiredToUnlock(BasePlayer player, TechTreeData.NodeInstance node, List<TechTreeData.NodeInstance> foundNodes) { }

	// RVA: 0x7ABEC0 Offset: 0x7AA4C0 VA: 0x1807ABEC0
	public void AddSingleNode(TechTreeData.NodeInstance node) { }

	// RVA: 0x7AD090 Offset: 0x7AB690 VA: 0x1807AD090
	public bool HasLine(int from, int to) { }

	// RVA: 0x7AB470 Offset: 0x7A9A70 VA: 0x1807AB470
	public void AddNodesRecursive(TechTreeData.NodeInstance startNode) { }

	// RVA: 0x7AE160 Offset: 0x7AC760 VA: 0x1807AE160
	public void UpdateLines() { }

	// RVA: 0x7AD2D0 Offset: 0x7AB8D0 VA: 0x1807AD2D0 Slot: 10
	public void OnInventoryChanged() { }

	// RVA: 0x7AE310 Offset: 0x7AC910 VA: 0x1807AE310
	private void UpdateScrapCount() { }

	// RVA: 0x7AE4D0 Offset: 0x7ACAD0 VA: 0x1807AE4D0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7ACA60 Offset: 0x7AB060 VA: 0x1807ACA60
	private void <OpenDialog>b__17_0() { }

}

private sealed class TechTreeDialog.<>c__DisplayClass37_0 // TypeDefIndex: 10913
{	// Fields
	public TechTreeDialog <>4__this; // 0x10
	public TechTreeData.NodeInstance node; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7B51E0 Offset: 0x7B37E0 VA: 0x1807B51E0
	internal void <AddSingleNode>b__0() { }

}

