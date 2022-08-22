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
	// RVA: 0xF8B670 Offset: 0xF89C70 VA: 0x180F8B670
	public bool get_AllowIntegerValues() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF8B680 Offset: 0xF89C80 VA: 0x180F8B680
	public void set_AllowIntegerValues(bool value) { }

	// RVA: 0xF9D680 Offset: 0xF9BC80 VA: 0x180F9D680
	public void .ctor() { }

	// RVA: 0xF9D4C0 Offset: 0xF9BAC0 VA: 0x180F9D4C0 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xF9D0D0 Offset: 0xF9B6D0 VA: 0x180F9D0D0 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xF9D060 Offset: 0xF9B660 VA: 0x180F9D060 Slot: 6
	public override bool CanConvert(Type objectType) { }

}

