public sealed class TypeInitializationException : SystemException // TypeDefIndex: 324
{	// Fields
	private string _typeName; // 0x88

	// Properties
	public string TypeName { get; }

	// Methods

	// RVA: 0x213D610 Offset: 0x213BC10 VA: 0x18213D610
	private void .ctor() { }

	// RVA: 0x213D500 Offset: 0x213BB00 VA: 0x18213D500
	public void .ctor(string fullTypeName, Exception innerException) { }

	// RVA: 0x213D670 Offset: 0x213BC70 VA: 0x18213D670
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x213D700 Offset: 0x213BD00 VA: 0x18213D700
	public string get_TypeName() { }

	// RVA: 0x213D3C0 Offset: 0x213B9C0 VA: 0x18213D3C0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

