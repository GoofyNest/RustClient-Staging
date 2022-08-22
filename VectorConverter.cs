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
	// RVA: 0xF8B670 Offset: 0xF89C70 VA: 0x180F8B670
	public bool get_EnableVector3() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF8B680 Offset: 0xF89C80 VA: 0x180F8B680
	public void set_EnableVector3(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF9E420 Offset: 0xF9CA20 VA: 0x180F9E420
	public bool get_EnableVector4() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF9E430 Offset: 0xF9CA30 VA: 0x180F9E430
	public void set_EnableVector4(bool value) { }

	// RVA: 0xF9E400 Offset: 0xF9CA00 VA: 0x180F9E400
	public void .ctor() { }

	// RVA: 0xF9DEB0 Offset: 0xF9C4B0 VA: 0x180F9DEB0 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xF9E1B0 Offset: 0xF9C7B0 VA: 0x180F9E1B0
	private static void WriteVector(JsonWriter writer, float x, float y, Nullable<float> z, Nullable<float> w) { }

	// RVA: 0xF9DA80 Offset: 0xF9C080 VA: 0x180F9DA80 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xF9D6A0 Offset: 0xF9BCA0 VA: 0x180F9D6A0 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xF9D790 Offset: 0xF9BD90 VA: 0x180F9D790
	private static Vector2 PopulateVector2(JsonReader reader) { }

	// RVA: 0xF9D870 Offset: 0xF9BE70 VA: 0x180F9D870
	private static Vector3 PopulateVector3(JsonReader reader) { }

	// RVA: 0xF9D960 Offset: 0xF9BF60 VA: 0x180F9D960
	private static Vector4 PopulateVector4(JsonReader reader) { }

	// RVA: 0xF9E330 Offset: 0xF9C930 VA: 0x180F9E330
	private static void .cctor() { }

}

