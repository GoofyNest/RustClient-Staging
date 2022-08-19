public class SetupAppNotification : UIDialog // TypeDefIndex: 10910
{	// Fields
	public RustInput titleInput; // 0x30
	public RustInput bodyInput; // 0x38
	private SmartAlarm _alarm; // 0x40

	// Methods

	// RVA: 0x5943E0 Offset: 0x5929E0 VA: 0x1805943E0
	public void Initialize(SmartAlarm alarm, string title, string body) { }

	// RVA: 0x5947D0 Offset: 0x592DD0 VA: 0x1805947D0
	public void SelectFirstTextField() { }

	// RVA: 0x594660 Offset: 0x592C60 VA: 0x180594660
	public void MoveToSecondTextField() { }

	// RVA: 0x594310 Offset: 0x592910 VA: 0x180594310
	public void FinishedEditing() { }

	// RVA: 0x594870 Offset: 0x592E70 VA: 0x180594870
	private void SelectTextField(RustInput input) { }

	// RVA: 0x594710 Offset: 0x592D10 VA: 0x180594710
	public void Save() { }

	// RVA: 0x4C1AB0 Offset: 0x4C00B0 VA: 0x1804C1AB0
	public void .ctor() { }

}

