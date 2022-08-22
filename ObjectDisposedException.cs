public class ObjectDisposedException : InvalidOperationException // TypeDefIndex: 280
{	// Fields
	private string objectName; // 0x88

	// Properties
	public override string Message { get; }
	public string ObjectName { get; }

	// Methods

	// RVA: 0x1683660 Offset: 0x1681C60 VA: 0x181683660
	private void .ctor() { }

	// RVA: 0x1683770 Offset: 0x1681D70 VA: 0x181683770
	public void .ctor(string objectName) { }

	// RVA: 0x1683600 Offset: 0x1681C00 VA: 0x181683600
	public void .ctor(string objectName, string message) { }

	// RVA: 0x1683800 Offset: 0x1681E00 VA: 0x181683800 Slot: 5
	public override string get_Message() { }

	// RVA: 0x1683960 Offset: 0x1681F60 VA: 0x181683960
	public string get_ObjectName() { }

	// RVA: 0x16836E0 Offset: 0x1681CE0 VA: 0x1816836E0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16834F0 Offset: 0x1681AF0 VA: 0x1816834F0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

