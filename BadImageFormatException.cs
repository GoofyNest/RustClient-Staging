public class BadImageFormatException : SystemException // TypeDefIndex: 177
{	// Fields
	private string _fileName; // 0x88
	private string _fusionLog; // 0x90

	// Properties
	public override string Message { get; }
	public string FusionLog { get; }

	// Methods

	// RVA: 0x155DC60 Offset: 0x155C260 VA: 0x18155DC60
	public void .ctor() { }

	// RVA: 0x155DDB0 Offset: 0x155C3B0 VA: 0x18155DDB0
	public void .ctor(string message) { }

	// RVA: 0x155DC30 Offset: 0x155C230 VA: 0x18155DC30
	public void .ctor(string message, Exception inner) { }

	// RVA: 0x155DBE0 Offset: 0x155C1E0 VA: 0x18155DBE0
	public void .ctor(string message, string fileName) { }

	// RVA: 0x155DDE0 Offset: 0x155C3E0 VA: 0x18155DDE0 Slot: 5
	public override string get_Message() { }

	// RVA: 0x155D8E0 Offset: 0x155BEE0 VA: 0x18155D8E0
	private void SetMessageField() { }

	// RVA: 0x155D960 Offset: 0x155BF60 VA: 0x18155D960 Slot: 3
	public override string ToString() { }

	// RVA: 0x155DCC0 Offset: 0x155C2C0 VA: 0x18155DCC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x4E3FE0 Offset: 0x4E25E0 VA: 0x1804E3FE0
	public string get_FusionLog() { }

	// RVA: 0x155D7A0 Offset: 0x155BDA0 VA: 0x18155D7A0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

