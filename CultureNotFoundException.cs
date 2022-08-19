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

	// RVA: 0x16DE630 Offset: 0x16DCC30 VA: 0x1816DE630
	public void .ctor() { }

	// RVA: 0x16DE7E0 Offset: 0x16DCDE0 VA: 0x1816DE7E0
	public void .ctor(string paramName, string message) { }

	// RVA: 0x16DE5F0 Offset: 0x16DCBF0 VA: 0x1816DE5F0
	public void .ctor(string paramName, string invalidCultureName, string message) { }

	// RVA: 0x16DE680 Offset: 0x16DCC80 VA: 0x1816DE680
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16DE4A0 Offset: 0x16DCAA0 VA: 0x1816DE4A0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380 Slot: 12
	public virtual Nullable<int> get_InvalidCultureId() { }

	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050 Slot: 13
	public virtual string get_InvalidCultureName() { }

	// RVA: 0x16DE800 Offset: 0x16DCE00 VA: 0x1816DE800
	private static string get_DefaultMessage() { }

	// RVA: 0x16DE840 Offset: 0x16DCE40 VA: 0x1816DE840
	private string get_FormatedInvalidCultureId() { }

	// RVA: 0x16DE940 Offset: 0x16DCF40 VA: 0x1816DE940 Slot: 5
	public override string get_Message() { }

}

