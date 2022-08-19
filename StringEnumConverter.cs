public class StringEnumConverter : JsonConverter // TypeDefIndex: 6106
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <CamelCaseText>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <AllowIntegerValues>k__BackingField; // 0x11

	// Properties
	public bool CamelCaseText { get; }
	public bool AllowIntegerValues { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_CamelCaseText() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF8B3B0 Offset: 0xF899B0 VA: 0x180F8B3B0
	public bool get_AllowIntegerValues() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF8B3C0 Offset: 0xF899C0 VA: 0x180F8B3C0
	public void set_AllowIntegerValues(bool value) { }

	// RVA: 0xF9D3C0 Offset: 0xF9B9C0 VA: 0x180F9D3C0
	public void .ctor() { }

	// RVA: 0xF9D200 Offset: 0xF9B800 VA: 0x180F9D200 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xF9CE10 Offset: 0xF9B410 VA: 0x180F9CE10 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xF9CDA0 Offset: 0xF9B3A0 VA: 0x180F9CDA0 Slot: 6
	public override bool CanConvert(Type objectType) { }

}

