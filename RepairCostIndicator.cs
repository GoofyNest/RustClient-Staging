public class RepairCostIndicator : SingletonComponent<RepairCostIndicator>, IClientComponent // TypeDefIndex: 11214
{	// Fields
	public RepairCostIndicatorRow[] Rows; // 0x18
	public CanvasGroup Fader; // 0x20
	private TimeSince showTime; // 0x28

	// Methods

	// RVA: 0x953B30 Offset: 0x952130 VA: 0x180953B30 Slot: 6
	protected override void Awake() { }

	// RVA: 0x953B60 Offset: 0x952160 VA: 0x180953B60
	public void ShowCostIndicator(List<ItemAmount> costs, BasePlayer player) { }

	// RVA: 0x953EE0 Offset: 0x9524E0 VA: 0x180953EE0
	private void UpdateFade() { }

	// RVA: 0x9542A0 Offset: 0x9528A0 VA: 0x1809542A0
	public void .ctor() { }

}

