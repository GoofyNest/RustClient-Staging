public class VectorConverter : JsonConverter // TypeDefIndex: 6107
{	// Fields
	private static readonly Type V2; // 0x0
	private static readonly Type V3; // 0x8
	private static readonly Type V4; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <EnableVector2>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <EnableVector3>k__BackingField; // 0x11
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <EnableVector4>k__BackingField; // 0x12

	// Properties
	public bool EnableVector2 { get; set; }
	public bool EnableVector3 { get; set; }
	public bool EnableVector4 { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_EnableVector2() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49AFC0 Offset: 0x4995C0 VA: 0x18049AFC0
	public void set_EnableVector2(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF8B3B0 Offset: 0xF899B0 VA: 0x180F8B3B0
	public bool get_EnableVector3() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF8B3C0 Offset: 0xF899C0 VA: 0x180F8B3C0
	public void set_EnableVector3(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF9E160 Offset: 0xF9C760 VA: 0x180F9E160
	public bool get_EnableVector4() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF9E170 Offset: 0xF9C770 VA: 0x180F9E170
	public void set_EnableVector4(bool value) { }

	// RVA: 0xF9E140 Offset: 0xF9C740 VA: 0x180F9E140
	public void .ctor() { }

	// RVA: 0xF9DBF0 Offset: 0xF9C1F0 VA: 0x180F9DBF0 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xF9DEF0 Offset: 0xF9C4F0 VA: 0x180F9DEF0
	private static void WriteVector(JsonWriter writer, float x, float y, Nullable<float> z, Nullable<float> w) { }

	// RVA: 0xF9D7C0 Offset: 0xF9BDC0 VA: 0x180F9D7C0 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xF9D3E0 Offset: 0xF9B9E0 VA: 0x180F9D3E0 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xF9D4D0 Offset: 0xF9BAD0 VA: 0x180F9D4D0
	private static Vector2 PopulateVector2(JsonReader reader) { }

	// RVA: 0xF9D5B0 Offset: 0xF9BBB0 VA: 0x180F9D5B0
	private static Vector3 PopulateVector3(JsonReader reader) { }

	// RVA: 0xF9D6A0 Offset: 0xF9BCA0 VA: 0x180F9D6A0
	private static Vector4 PopulateVector4(JsonReader reader) { }

	// RVA: 0xF9E070 Offset: 0xF9C670 VA: 0x180F9E070
	private static void .cctor() { }

}

