public class StringEnumConverter : JsonConverter // TypeDefIndex: 6106
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <CamelCaseText>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <AllowIntegerValues>k__BackingField; // 0x11

	// Properties
	public bool CamelCaseText { get; }
	public bool AllowIntegerValues { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_CamelCaseText() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF8C110 Offset: 0xF8A710 VA: 0x180F8C110
	public bool get_AllowIntegerValues() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF8C120 Offset: 0xF8A720 VA: 0x180F8C120
	public void set_AllowIntegerValues(bool value) { }

	// RVA: 0xF9E120 Offset: 0xF9C720 VA: 0x180F9E120
	public void .ctor() { }

	// RVA: 0xF9DF60 Offset: 0xF9C560 VA: 0x180F9DF60 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xF9DB70 Offset: 0xF9C170 VA: 0x180F9DB70 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xF9DB00 Offset: 0xF9C100 VA: 0x180F9DB00 Slot: 6
	public override bool CanConvert(Type objectType) { }

}

