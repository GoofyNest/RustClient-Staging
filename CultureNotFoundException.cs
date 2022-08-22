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

	// RVA: 0x16DE8F0 Offset: 0x16DCEF0 VA: 0x1816DE8F0
	public void .ctor() { }

	// RVA: 0x16DEAA0 Offset: 0x16DD0A0 VA: 0x1816DEAA0
	public void .ctor(string paramName, string message) { }

	// RVA: 0x16DE8B0 Offset: 0x16DCEB0 VA: 0x1816DE8B0
	public void .ctor(string paramName, string invalidCultureName, string message) { }

	// RVA: 0x16DE940 Offset: 0x16DCF40 VA: 0x1816DE940
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16DE760 Offset: 0x16DCD60 VA: 0x1816DE760 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380 Slot: 12
	public virtual Nullable<int> get_InvalidCultureId() { }

	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050 Slot: 13
	public virtual string get_InvalidCultureName() { }

	// RVA: 0x16DEAC0 Offset: 0x16DD0C0 VA: 0x1816DEAC0
	private static string get_DefaultMessage() { }

	// RVA: 0x16DEB00 Offset: 0x16DD100 VA: 0x1816DEB00
	private string get_FormatedInvalidCultureId() { }

	// RVA: 0x16DEC00 Offset: 0x16DD200 VA: 0x1816DEC00 Slot: 5
	public override string get_Message() { }

}

