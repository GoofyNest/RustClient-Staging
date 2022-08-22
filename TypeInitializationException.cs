public sealed class TypeInitializationException : SystemException // TypeDefIndex: 324
{	// Fields
	private string _typeName; // 0x88

	// Properties
	public string TypeName { get; }

	// Methods

	// RVA: 0x213E0F0 Offset: 0x213C6F0 VA: 0x18213E0F0
	private void .ctor() { }

	// RVA: 0x213DFE0 Offset: 0x213C5E0 VA: 0x18213DFE0
	public void .ctor(string fullTypeName, Exception innerException) { }

	// RVA: 0x213E150 Offset: 0x213C750 VA: 0x18213E150
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x213E1E0 Offset: 0x213C7E0 VA: 0x18213E1E0
	public string get_TypeName() { }

	// RVA: 0x213DEA0 Offset: 0x213C4A0 VA: 0x18213DEA0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

