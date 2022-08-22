public class CultureNotFoundException : ArgumentException, ISerializable // TypeDefIndex: 691
{	// Fields
	private string m_invalidCultureName; // 0x90
	private Nullable<int> m_invalidCultureId; // 0x98

	// Properties
	public virtual Nullable<int> InvalidCultureId { get; }
	public virtual string InvalidCultureName { get; }
	private static string DefaultMessage { get; }
	private string FormatedInvalidCultureId { get; }
	public override string Message { get; }

	// Methods

	// RVA: 0x16DC4E0 Offset: 0x16DAAE0 VA: 0x1816DC4E0
	public void .ctor() { }

	// RVA: 0x16DC690 Offset: 0x16DAC90 VA: 0x1816DC690
	public void .ctor(string paramName, string message) { }

	// RVA: 0x16DC4A0 Offset: 0x16DAAA0 VA: 0x1816DC4A0
	public void .ctor(string paramName, string invalidCultureName, string message) { }

	// RVA: 0x16DC530 Offset: 0x16DAB30 VA: 0x1816DC530
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16DC350 Offset: 0x16DA950 VA: 0x1816DC350 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x574310 Offset: 0x572910 VA: 0x180574310 Slot: 12
	public virtual Nullable<int> get_InvalidCultureId() { }

	// RVA: 0x4E3FE0 Offset: 0x4E25E0 VA: 0x1804E3FE0 Slot: 13
	public virtual string get_InvalidCultureName() { }

	// RVA: 0x16DC6B0 Offset: 0x16DACB0 VA: 0x1816DC6B0
	private static string get_DefaultMessage() { }

	// RVA: 0x16DC6F0 Offset: 0x16DACF0 VA: 0x1816DC6F0
	private string get_FormatedInvalidCultureId() { }

	// RVA: 0x16DC7F0 Offset: 0x16DADF0 VA: 0x1816DC7F0 Slot: 5
	public override string get_Message() { }

}

