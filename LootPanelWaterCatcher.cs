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

	// RVA: 0x551690 Offset: 0x54FC90 VA: 0x180551690 Slot: 6
	protected override void OnDisable() { }

	// RVA: 0x550B60 Offset: 0x54F160 VA: 0x180550B60
	public bool CanCopyFrom() { }

	// RVA: 0x551030 Offset: 0x54F630 VA: 0x180551030
	public void CopyFrom() { }

	// RVA: 0x550D90 Offset: 0x54F390 VA: 0x180550D90
	public bool CanCopyTo() { }

	// RVA: 0x551190 Offset: 0x54F790 VA: 0x180551190
	public void CopyTo() { }

	// RVA: 0x551530 Offset: 0x54FB30 VA: 0x180551530
	public void OnCopyFromDown() { }

	// RVA: 0x551560 Offset: 0x54FB60 VA: 0x180551560
	public void OnCopyFromUp() { }

	// RVA: 0x5515E0 Offset: 0x54FBE0 VA: 0x1805515E0
	public void OnCopyToDown() { }

	// RVA: 0x551610 Offset: 0x54FC10 VA: 0x180551610
	public void OnCopyToUp() { }

	// RVA: 0x551710 Offset: 0x54FD10 VA: 0x180551710
	public void OnDrinkDown() { }

	// RVA: 0x551740 Offset: 0x54FD40 VA: 0x180551740
	public void OnDrinkUp() { }

	// RVA: 0x551490 Offset: 0x54FA90 VA: 0x180551490
	private void InitAutoTransfer(LootPanelWaterCatcher.TransferMode mode, float interval, float delay) { }

	// RVA: 0x550B30 Offset: 0x54F130 VA: 0x180550B30
	private void AutoTransfer() { }

	// RVA: 0x551860 Offset: 0x54FE60 VA: 0x180551860
	private void StopAutoTransfer() { }

	// RVA: 0x5518D0 Offset: 0x54FED0 VA: 0x1805518D0 Slot: 5
	public override void Update() { }

	// RVA: 0x5517C0 Offset: 0x54FDC0 VA: 0x1805517C0
	public bool SelectedValidTarget() { }

	// RVA: 0x551400 Offset: 0x54FA00 VA: 0x180551400
	public LiquidContainer GetLiquidContainer() { }

	// RVA: 0x550F10 Offset: 0x54F510 VA: 0x180550F10
	public bool CanDrink() { }

	// RVA: 0x5512F0 Offset: 0x54F8F0 VA: 0x1805512F0
	public void Drink() { }

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
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

