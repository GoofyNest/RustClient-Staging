public class Alert // TypeDefIndex: 1736
{	// Fields
	private AlertLevel level; // 0x10
	private AlertDescription description; // 0x11

	// Properties
	public AlertLevel Level { get; }
	public AlertDescription Description { get; }

	// Methods

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public AlertLevel get_Level() { }

	// RVA: 0xF8C110 Offset: 0xF8A710 VA: 0x180F8C110
	public AlertDescription get_Description() { }

	// RVA: 0x1AAF210 Offset: 0x1AAD810 VA: 0x181AAF210
	public void .ctor(AlertDescription description) { }

	// RVA: 0x1AAF2B0 Offset: 0x1AAD8B0 VA: 0x181AAF2B0
	private void inferAlertLevel() { }

	// RVA: 0x1AAF190 Offset: 0x1AAD790 VA: 0x181AAF190 Slot: 3
	public override string ToString() { }

}

