public class BadImageFormatException : SystemException // TypeDefIndex: 177
{	// Fields
	private string _fileName; // 0x88
	private string _fusionLog; // 0x90

	// Properties
	public override string Message { get; }
	public string FusionLog { get; }

	// Methods

	// RVA: 0x155EB90 Offset: 0x155D190 VA: 0x18155EB90
	public void .ctor() { }

	// RVA: 0x155ECE0 Offset: 0x155D2E0 VA: 0x18155ECE0
	public void .ctor(string message) { }

	// RVA: 0x155EB60 Offset: 0x155D160 VA: 0x18155EB60
	public void .ctor(string message, Exception inner) { }

	// RVA: 0x155EB10 Offset: 0x155D110 VA: 0x18155EB10
	public void .ctor(string message, string fileName) { }

	// RVA: 0x155ED10 Offset: 0x155D310 VA: 0x18155ED10 Slot: 5
	public override string get_Message() { }

	// RVA: 0x155E810 Offset: 0x155CE10 VA: 0x18155E810
	private void SetMessageField() { }

	// RVA: 0x155E890 Offset: 0x155CE90 VA: 0x18155E890 Slot: 3
	public override string ToString() { }

	// RVA: 0x155EBF0 Offset: 0x155D1F0 VA: 0x18155EBF0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050
	public string get_FusionLog() { }

	// RVA: 0x155E6D0 Offset: 0x155CCD0 VA: 0x18155E6D0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

