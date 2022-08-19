public class LootPanelEngine : LootPanel // TypeDefIndex: 11030
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Image engineImage; // 0x38
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ItemIcon[] icons; // 0x40
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GameObject warning; // 0x48
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private RustText hp; // 0x50
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private RustText power; // 0x58
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private RustText acceleration; // 0x60
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private RustText topSpeed; // 0x68
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private RustText fuelEconomy; // 0x70

	// Methods

	// RVA: 0x507AE0 Offset: 0x5060E0 VA: 0x180507AE0
	protected void OnEnable() { }

	// RVA: 0x507F80 Offset: 0x506580 VA: 0x180507F80 Slot: 5
	public override void Update() { }

	// RVA: 0x5075B0 Offset: 0x505BB0 VA: 0x1805075B0
	public EngineStorage GetEngineStorage() { }

	// RVA: 0x507C20 Offset: 0x506220 VA: 0x180507C20
	private void RefreshStats(EngineStorage engineBayStorage) { }

	// RVA: 0x507640 Offset: 0x505C40 VA: 0x180507640
	public void OnDroppedOnEngine(BaseEventData data) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

