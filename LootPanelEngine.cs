public class LootPanelEngine : LootPanel // TypeDefIndex: 11034
{	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Image engineImage; // 0x38
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private ItemIcon[] icons; // 0x40
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private GameObject warning; // 0x48
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private RustText hp; // 0x50
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private RustText power; // 0x58
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private RustText acceleration; // 0x60
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private RustText topSpeed; // 0x68
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private RustText fuelEconomy; // 0x70


	protected void OnEnable() { }

	public override void Update() { }

	public EngineStorage GetEngineStorage() { }

	private void RefreshStats(EngineStorage engineBayStorage) { }

	public void OnDroppedOnEngine(BaseEventData data) { }

	public void .ctor() { }

}

