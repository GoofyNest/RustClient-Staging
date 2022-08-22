public class SetupAppNotification : UIDialog // TypeDefIndex: 10910
{	// Fields
	public RustInput titleInput; // 0x30
	public RustInput bodyInput; // 0x38
	private SmartAlarm _alarm; // 0x40

	// Methods

	// RVA: 0x594370 Offset: 0x592970 VA: 0x180594370
	public void Initialize(SmartAlarm alarm, string title, string body) { }

	// RVA: 0x594760 Offset: 0x592D60 VA: 0x180594760
	public void SelectFirstTextField() { }

	// RVA: 0x5945F0 Offset: 0x592BF0 VA: 0x1805945F0
	public void MoveToSecondTextField() { }

	// RVA: 0x5942A0 Offset: 0x5928A0 VA: 0x1805942A0
	public void FinishedEditing() { }

	// RVA: 0x594800 Offset: 0x592E00 VA: 0x180594800
	private void SelectTextField(RustInput input) { }

	// RVA: 0x5946A0 Offset: 0x592CA0 VA: 0x1805946A0
	public void Save() { }

	// RVA: 0x4C1A40 Offset: 0x4C0040 VA: 0x1804C1A40
	public void .ctor() { }

}

