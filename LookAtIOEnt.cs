public class LookAtIOEnt : MonoBehaviour // TypeDefIndex: 11078
{	// Fields
	public Text objectTitle; // 0x18
	public RectTransform slotToolTip; // 0x20
	public Text slotTitle; // 0x28
	public Text slotConnection; // 0x30
	public Text slotPower; // 0x38
	public Text powerText; // 0x40
	public Text passthroughText; // 0x48
	public Text chargeLeftText; // 0x50
	public Text capacityText; // 0x58
	public Text maxOutputText; // 0x60
	public Text activeOutputText; // 0x68
	public IOEntityUISlotEntry[] inputEntries; // 0x70
	public IOEntityUISlotEntry[] outputEntries; // 0x78
	public Color NoPowerColor; // 0x80
	public GameObject GravityWarning; // 0x90
	public CanvasGroup group; // 0x98
	public LookAtIOEnt.HandleSet[] handleSets; // 0xA0
	public RectTransform clearNotification; // 0xA8
	public CanvasGroup wireInfoGroup; // 0xB0
	public Text wireLengthText; // 0xB8
	public Text wireClipsText; // 0xC0
	public Text errorReasonTextTooFar; // 0xC8
	public Text errorReasonTextNoSurface; // 0xD0
	public Text errorShortCircuit; // 0xD8
	public RawImage ConnectionTypeIcon; // 0xE0
	public Texture ElectricSprite; // 0xE8
	public Texture FluidSprite; // 0xF0
	private IOEntity lastLooking; // 0xF8
	private float nextUpdatetime; // 0x100
	public GameObject activeHandle; // 0x108
	private MaterialSwap activeHandleMaterialSwap; // 0x110
	public GameObject pluggedHandle; // 0x118
	public List<GameObject> inputHandles; // 0x120
	public List<GameObject> outputHandles; // 0x128
	private static int selectedIndex; // 0x0
	private static bool selectedWasInput; // 0x4
	private bool wiretoolWasPendingInput; // 0x130
	private bool wiretoolWasPendingOutput; // 0x131
	private bool wireToolWasPendingRoot; // 0x132
	private IOEntity.IOType wireToolWasType; // 0x134

	// Methods

	// RVA: 0x503CA0 Offset: 0x5022A0 VA: 0x180503CA0
	private void Update() { }

	// RVA: 0x500290 Offset: 0x4FE890 VA: 0x180500290
	public void ClearHandles() { }

	// RVA: 0x500750 Offset: 0x4FED50 VA: 0x180500750
	public void SetupHandles(IOEntity ent, bool showInputs = True, bool showOutputs = True) { }

	// RVA: 0x500630 Offset: 0x4FEC30 VA: 0x180500630
	public static int GetSelectedIndex() { }

	// RVA: 0x500690 Offset: 0x4FEC90 VA: 0x180500690
	public static bool SelectedIsInput() { }

	// RVA: 0x501450 Offset: 0x4FFA50 VA: 0x180501450
	public void UpdateClearing() { }

	// RVA: 0x503950 Offset: 0x501F50 VA: 0x180503950
	public void UpdateWireInfo() { }

	// RVA: 0x502800 Offset: 0x500E00 VA: 0x180502800
	public void UpdateLookingHandle(bool includeInputs, bool includeOutputs) { }

	// RVA: 0x500460 Offset: 0x4FEA60 VA: 0x180500460
	public Vector3 GetSelectedHandleWorldPosition() { }

	// RVA: 0x500350 Offset: 0x4FE950 VA: 0x180500350
	public IOEntity.IOType GetSelectedHandleType() { }

	// RVA: 0x502E40 Offset: 0x501440 VA: 0x180502E40
	public void UpdateLookingUI() { }

	// RVA: 0x5016F0 Offset: 0x4FFCF0 VA: 0x1805016F0
	public bool UpdateLookingAtIOEnt() { }

	// RVA: 0x5002B0 Offset: 0x4FE8B0 VA: 0x1805002B0
	private LookAtIOEnt.HandleSet GetHandles(IOEntity.IOType forType) { }

	// RVA: 0x503F60 Offset: 0x502560 VA: 0x180503F60
	public void .ctor() { }

	// RVA: 0x503F10 Offset: 0x502510 VA: 0x180503F10
	private static void .cctor() { }

}

public struct LookAtIOEnt.HandleSet // TypeDefIndex: 11079
{	// Fields
	public IOEntity.IOType ForIO; // 0x0
	public GameObjectRef handlePrefab; // 0x8
	public GameObjectRef handleOccupiedPrefab; // 0x10
	public GameObjectRef selectedHandlePrefab; // 0x18
	public GameObjectRef pluggedHandlePrefab; // 0x20

}

