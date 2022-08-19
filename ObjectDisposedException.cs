public class ObjectDisposedException : InvalidOperationException // TypeDefIndex: 280
{	// Fields
	private string objectName; // 0x88

	// Properties
	public override string Message { get; }
	public string ObjectName { get; }

	// Methods

	// RVA: 0x16833A0 Offset: 0x16819A0 VA: 0x1816833A0
	private void .ctor() { }

	// RVA: 0x16834B0 Offset: 0x1681AB0 VA: 0x1816834B0
	public void .ctor(string objectName) { }

	// RVA: 0x1683340 Offset: 0x1681940 VA: 0x181683340
	public void .ctor(string objectName, string message) { }

	// RVA: 0x1683540 Offset: 0x1681B40 VA: 0x181683540 Slot: 5
	public override string get_Message() { }

	// RVA: 0x16836A0 Offset: 0x1681CA0 VA: 0x1816836A0
	public string get_ObjectName() { }

	// RVA: 0x1683420 Offset: 0x1681A20 VA: 0x181683420
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1683230 Offset: 0x1681830 VA: 0x181683230 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

