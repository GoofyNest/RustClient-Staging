public class LootPanelEngine : LootPanel // TypeDefIndex: 11030
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Image engineImage; // 0x38
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ItemIcon[] icons; // 0x40
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObject warning; // 0x48
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RustText hp; // 0x50
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RustText power; // 0x58
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RustText acceleration; // 0x60
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RustText topSpeed; // 0x68
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RustText fuelEconomy; // 0x70

	// Methods

	// RVA: 0x507A70 Offset: 0x506070 VA: 0x180507A70
	protected void OnEnable() { }

	// RVA: 0x507F10 Offset: 0x506510 VA: 0x180507F10 Slot: 5
	public override void Update() { }

	// RVA: 0x507540 Offset: 0x505B40 VA: 0x180507540
	public EngineStorage GetEngineStorage() { }

	// RVA: 0x507BB0 Offset: 0x5061B0 VA: 0x180507BB0
	private void RefreshStats(EngineStorage engineBayStorage) { }

	// RVA: 0x5075D0 Offset: 0x505BD0 VA: 0x1805075D0
	public void OnDroppedOnEngine(BaseEventData data) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

