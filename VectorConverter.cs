public class VectorConverter : JsonConverter // TypeDefIndex: 6107
{	// Fields
	private static readonly Type V2; // 0x0
	private static readonly Type V3; // 0x8
	private static readonly Type V4; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <EnableVector2>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <EnableVector3>k__BackingField; // 0x11
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <EnableVector4>k__BackingField; // 0x12

	// Properties
	public bool EnableVector2 { get; set; }
	public bool EnableVector3 { get; set; }
	public bool EnableVector4 { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_EnableVector2() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFC0 Offset: 0x4995C0 VA: 0x18049AFC0
	public void set_EnableVector2(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF8C110 Offset: 0xF8A710 VA: 0x180F8C110
	public bool get_EnableVector3() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF8C120 Offset: 0xF8A720 VA: 0x180F8C120
	public void set_EnableVector3(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF9EEC0 Offset: 0xF9D4C0 VA: 0x180F9EEC0
	public bool get_EnableVector4() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF9EED0 Offset: 0xF9D4D0 VA: 0x180F9EED0
	public void set_EnableVector4(bool value) { }

	// RVA: 0xF9EEA0 Offset: 0xF9D4A0 VA: 0x180F9EEA0
	public void .ctor() { }

	// RVA: 0xF9E950 Offset: 0xF9CF50 VA: 0x180F9E950 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xF9EC50 Offset: 0xF9D250 VA: 0x180F9EC50
	private static void WriteVector(JsonWriter writer, float x, float y, Nullable<float> z, Nullable<float> w) { }

	// RVA: 0xF9E520 Offset: 0xF9CB20 VA: 0x180F9E520 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xF9E140 Offset: 0xF9C740 VA: 0x180F9E140 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xF9E230 Offset: 0xF9C830 VA: 0x180F9E230
	private static Vector2 PopulateVector2(JsonReader reader) { }

	// RVA: 0xF9E310 Offset: 0xF9C910 VA: 0x180F9E310
	private static Vector3 PopulateVector3(JsonReader reader) { }

	// RVA: 0xF9E400 Offset: 0xF9CA00 VA: 0x180F9E400
	private static Vector4 PopulateVector4(JsonReader reader) { }

	// RVA: 0xF9EDD0 Offset: 0xF9D3D0 VA: 0x180F9EDD0
	private static void .cctor() { }

}

