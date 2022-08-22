public class LootPanelWaterCatcher : LootPanel // TypeDefIndex: 11038
{	// Fields
	public ItemIcon sourceItem; // 0x38
	public Image capacityImage; // 0x40
	public CanvasGroup helpCanvas; // 0x48
	public CanvasGroup buttonsCanvas; // 0x50
	public Button fromButton; // 0x58
	public Button toButton; // 0x60
	public Button drinkButton; // 0x68
	private LootPanelWaterCatcher.TransferMode transferMode; // 0x70

	// Methods

	// RVA: 0x551620 Offset: 0x54FC20 VA: 0x180551620 Slot: 6
	protected override void OnDisable() { }

	// RVA: 0x550AF0 Offset: 0x54F0F0 VA: 0x180550AF0
	public bool CanCopyFrom() { }

	// RVA: 0x550FC0 Offset: 0x54F5C0 VA: 0x180550FC0
	public void CopyFrom() { }

	// RVA: 0x550D20 Offset: 0x54F320 VA: 0x180550D20
	public bool CanCopyTo() { }

	// RVA: 0x551120 Offset: 0x54F720 VA: 0x180551120
	public void CopyTo() { }

	// RVA: 0x5514C0 Offset: 0x54FAC0 VA: 0x1805514C0
	public void OnCopyFromDown() { }

	// RVA: 0x5514F0 Offset: 0x54FAF0 VA: 0x1805514F0
	public void OnCopyFromUp() { }

	// RVA: 0x551570 Offset: 0x54FB70 VA: 0x180551570
	public void OnCopyToDown() { }

	// RVA: 0x5515A0 Offset: 0x54FBA0 VA: 0x1805515A0
	public void OnCopyToUp() { }

	// RVA: 0x5516A0 Offset: 0x54FCA0 VA: 0x1805516A0
	public void OnDrinkDown() { }

	// RVA: 0x5516D0 Offset: 0x54FCD0 VA: 0x1805516D0
	public void OnDrinkUp() { }

	// RVA: 0x551420 Offset: 0x54FA20 VA: 0x180551420
	private void InitAutoTransfer(LootPanelWaterCatcher.TransferMode mode, float interval, float delay) { }

	// RVA: 0x550AC0 Offset: 0x54F0C0 VA: 0x180550AC0
	private void AutoTransfer() { }

	// RVA: 0x5517F0 Offset: 0x54FDF0 VA: 0x1805517F0
	private void StopAutoTransfer() { }

	// RVA: 0x551860 Offset: 0x54FE60 VA: 0x180551860 Slot: 5
	public override void Update() { }

	// RVA: 0x551750 Offset: 0x54FD50 VA: 0x180551750
	public bool SelectedValidTarget() { }

	// RVA: 0x551390 Offset: 0x54F990 VA: 0x180551390
	public LiquidContainer GetLiquidContainer() { }

	// RVA: 0x550EA0 Offset: 0x54F4A0 VA: 0x180550EA0
	public bool CanDrink() { }

	// RVA: 0x551280 Offset: 0x54F880 VA: 0x180551280
	public void Drink() { }

	// RVA: 0x4BAE40 Offset: 0x4B9440 VA: 0x1804BAE40
	public void .ctor() { }

}

private enum LootPanelWaterCatcher.TransferMode // TypeDefIndex: 11039
{	// Fields
	public int value__; // 0x0
	public const LootPanelWaterCatcher.TransferMode None = 0;
	public const LootPanelWaterCatcher.TransferMode From = 1;
	public const LootPanelWaterCatcher.TransferMode To = 2;
	public const LootPanelWaterCatcher.TransferMode Drink = 3;

}

