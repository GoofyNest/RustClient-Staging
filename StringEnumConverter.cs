public class StringEnumConverter : JsonConverter // TypeDefIndex: 6106
{	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <CamelCaseText>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <AllowIntegerValues>k__BackingField; // 0x11

	public bool CamelCaseText { get; }
	public bool AllowIntegerValues { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool get_CamelCaseText() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool get_AllowIntegerValues() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_AllowIntegerValues(bool value) { }

	public void .ctor() { }

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public override bool CanConvert(Type objectType) { }

}

