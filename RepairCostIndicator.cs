public class RepairCostIndicator : SingletonComponent<RepairCostIndicator>, IClientComponent // TypeDefIndex: 11214
{	// Fields
	public RepairCostIndicatorRow[] Rows; // 0x18
	public CanvasGroup Fader; // 0x20
	private TimeSince showTime; // 0x28

	// Methods

	// RVA: 0x953520 Offset: 0x951B20 VA: 0x180953520 Slot: 6
	protected override void Awake() { }

	// RVA: 0x953550 Offset: 0x951B50 VA: 0x180953550
	public void ShowCostIndicator(List<ItemAmount> costs, BasePlayer player) { }

	// RVA: 0x9538D0 Offset: 0x951ED0 VA: 0x1809538D0
	private void UpdateFade() { }

	// RVA: 0x953C90 Offset: 0x952290 VA: 0x180953C90
	public void .ctor() { }

}

