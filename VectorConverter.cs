public class VectorConverter : JsonConverter // TypeDefIndex: 6107
{	private static readonly Type V2; // 0x0
	private static readonly Type V3; // 0x8
	private static readonly Type V4; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private bool <EnableVector2>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private bool <EnableVector3>k__BackingField; // 0x11
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private bool <EnableVector4>k__BackingField; // 0x12

	public bool EnableVector2 { get; set; }
	public bool EnableVector3 { get; set; }
	public bool EnableVector4 { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public bool get_EnableVector2() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void set_EnableVector2(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public bool get_EnableVector3() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void set_EnableVector3(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public bool get_EnableVector4() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void set_EnableVector4(bool value) { }

	public void .ctor() { }

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	private static void WriteVector(JsonWriter writer, float x, float y, Nullable<float> z, Nullable<float> w) { }

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public override bool CanConvert(Type objectType) { }

	private static Vector2 PopulateVector2(JsonReader reader) { }

	private static Vector3 PopulateVector3(JsonReader reader) { }

	private static Vector4 PopulateVector4(JsonReader reader) { }

	private static void .cctor() { }

}

