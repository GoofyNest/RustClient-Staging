public class ObjectDisposedException : InvalidOperationException // TypeDefIndex: 280
{	// Fields
	private string objectName; // 0x88

	// Properties
	public override string Message { get; }
	public string ObjectName { get; }

	// Methods

	// RVA: 0x1681250 Offset: 0x167F850 VA: 0x181681250
	private void .ctor() { }

	// RVA: 0x1681360 Offset: 0x167F960 VA: 0x181681360
	public void .ctor(string objectName) { }

	// RVA: 0x16811F0 Offset: 0x167F7F0 VA: 0x1816811F0
	public void .ctor(string objectName, string message) { }

	// RVA: 0x16813F0 Offset: 0x167F9F0 VA: 0x1816813F0 Slot: 5
	public override string get_Message() { }

	// RVA: 0x1681550 Offset: 0x167FB50 VA: 0x181681550
	public string get_ObjectName() { }

	// RVA: 0x16812D0 Offset: 0x167F8D0 VA: 0x1816812D0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16810E0 Offset: 0x167F6E0 VA: 0x1816810E0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

