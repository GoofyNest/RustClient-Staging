public sealed class TypeInitializationException : SystemException // TypeDefIndex: 324
{	// Fields
	private string _typeName; // 0x88

	// Properties
	public string TypeName { get; }

	// Methods

	// RVA: 0x213D7D0 Offset: 0x213BDD0 VA: 0x18213D7D0
	private void .ctor() { }

	// RVA: 0x213D6C0 Offset: 0x213BCC0 VA: 0x18213D6C0
	public void .ctor(string fullTypeName, Exception innerException) { }

	// RVA: 0x213D830 Offset: 0x213BE30 VA: 0x18213D830
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x213D8C0 Offset: 0x213BEC0 VA: 0x18213D8C0
	public string get_TypeName() { }

	// RVA: 0x213D580 Offset: 0x213BB80 VA: 0x18213D580 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

