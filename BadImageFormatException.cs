public class BadImageFormatException : SystemException // TypeDefIndex: 177
{	// Fields
	private string _fileName; // 0x88
	private string _fusionLog; // 0x90

	// Properties
	public override string Message { get; }
	public string FusionLog { get; }

	// Methods

	// RVA: 0x155E8D0 Offset: 0x155CED0 VA: 0x18155E8D0
	public void .ctor() { }

	// RVA: 0x155EA20 Offset: 0x155D020 VA: 0x18155EA20
	public void .ctor(string message) { }

	// RVA: 0x155E8A0 Offset: 0x155CEA0 VA: 0x18155E8A0
	public void .ctor(string message, Exception inner) { }

	// RVA: 0x155E850 Offset: 0x155CE50 VA: 0x18155E850
	public void .ctor(string message, string fileName) { }

	// RVA: 0x155EA50 Offset: 0x155D050 VA: 0x18155EA50 Slot: 5
	public override string get_Message() { }

	// RVA: 0x155E550 Offset: 0x155CB50 VA: 0x18155E550
	private void SetMessageField() { }

	// RVA: 0x155E5D0 Offset: 0x155CBD0 VA: 0x18155E5D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x155E930 Offset: 0x155CF30 VA: 0x18155E930
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050
	public string get_FusionLog() { }

	// RVA: 0x155E410 Offset: 0x155CA10 VA: 0x18155E410 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

