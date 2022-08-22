public sealed class TypeInitializationException : SystemException // TypeDefIndex: 324
{	// Fields
	private string _typeName; // 0x88

	// Properties
	public string TypeName { get; }

	// Methods

	// RVA: 0x213D8D0 Offset: 0x213BED0 VA: 0x18213D8D0
	private void .ctor() { }

	// RVA: 0x213D7C0 Offset: 0x213BDC0 VA: 0x18213D7C0
	public void .ctor(string fullTypeName, Exception innerException) { }

	// RVA: 0x213D930 Offset: 0x213BF30 VA: 0x18213D930
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x213D9C0 Offset: 0x213BFC0 VA: 0x18213D9C0
	public string get_TypeName() { }

	// RVA: 0x213D680 Offset: 0x213BC80 VA: 0x18213D680 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

