public class RepairCostIndicator : SingletonComponent<RepairCostIndicator>, IClientComponent // TypeDefIndex: 11214
{	// Fields
	public RepairCostIndicatorRow[] Rows; // 0x18
	public CanvasGroup Fader; // 0x20
	private TimeSince showTime; // 0x28

	// Methods

	// RVA: 0x953630 Offset: 0x951C30 VA: 0x180953630 Slot: 6
	protected override void Awake() { }

	// RVA: 0x953660 Offset: 0x951C60 VA: 0x180953660
	public void ShowCostIndicator(List<ItemAmount> costs, BasePlayer player) { }

	// RVA: 0x9539E0 Offset: 0x951FE0 VA: 0x1809539E0
	private void UpdateFade() { }

	// RVA: 0x953DA0 Offset: 0x9523A0 VA: 0x180953DA0
	public void .ctor() { }

}

