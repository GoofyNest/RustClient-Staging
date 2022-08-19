public class RegexConverter : JsonConverter // TypeDefIndex: 6105
{	// Methods

	// RVA: 0xF9C7B0 Offset: 0xF9ADB0 VA: 0x180F9C7B0 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xF9BFE0 Offset: 0xF9A5E0 VA: 0x180F9BFE0
	private bool HasFlag(RegexOptions options, RegexOptions flag) { }

	// RVA: 0xF9C5A0 Offset: 0xF9ABA0 VA: 0x180F9C5A0
	private void WriteBson(BsonWriter writer, Regex regex) { }

	// RVA: 0xF9CBF0 Offset: 0xF9B1F0 VA: 0x180F9CBF0
	private void WriteJson(JsonWriter writer, Regex regex, JsonSerializer serializer) { }

	// RVA: 0xF9BFF0 Offset: 0xF9A5F0 VA: 0x180F9BFF0 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xF9C440 Offset: 0xF9AA40 VA: 0x180F9C440
	private object ReadRegexString(JsonReader reader) { }

	// RVA: 0xF9C1E0 Offset: 0xF9A7E0 VA: 0x180F9C1E0
	private Regex ReadRegexObject(JsonReader reader, JsonSerializer serializer) { }

	// RVA: 0xF9BF70 Offset: 0xF9A570 VA: 0x180F9BF70 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

