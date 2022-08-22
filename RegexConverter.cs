public class RegexConverter : JsonConverter // TypeDefIndex: 6105
{	// Methods

	// RVA: 0xF9CA70 Offset: 0xF9B070 VA: 0x180F9CA70 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xF9C2A0 Offset: 0xF9A8A0 VA: 0x180F9C2A0
	private bool HasFlag(RegexOptions options, RegexOptions flag) { }

	// RVA: 0xF9C860 Offset: 0xF9AE60 VA: 0x180F9C860
	private void WriteBson(BsonWriter writer, Regex regex) { }

	// RVA: 0xF9CEB0 Offset: 0xF9B4B0 VA: 0x180F9CEB0
	private void WriteJson(JsonWriter writer, Regex regex, JsonSerializer serializer) { }

	// RVA: 0xF9C2B0 Offset: 0xF9A8B0 VA: 0x180F9C2B0 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xF9C700 Offset: 0xF9AD00 VA: 0x180F9C700
	private object ReadRegexString(JsonReader reader) { }

	// RVA: 0xF9C4A0 Offset: 0xF9AAA0 VA: 0x180F9C4A0
	private Regex ReadRegexObject(JsonReader reader, JsonSerializer serializer) { }

	// RVA: 0xF9C230 Offset: 0xF9A830 VA: 0x180F9C230 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

