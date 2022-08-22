public class RegexConverter : JsonConverter // TypeDefIndex: 6105
{	// Methods

	// RVA: 0xF9D510 Offset: 0xF9BB10 VA: 0x180F9D510 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xF9CD40 Offset: 0xF9B340 VA: 0x180F9CD40
	private bool HasFlag(RegexOptions options, RegexOptions flag) { }

	// RVA: 0xF9D300 Offset: 0xF9B900 VA: 0x180F9D300
	private void WriteBson(BsonWriter writer, Regex regex) { }

	// RVA: 0xF9D950 Offset: 0xF9BF50 VA: 0x180F9D950
	private void WriteJson(JsonWriter writer, Regex regex, JsonSerializer serializer) { }

	// RVA: 0xF9CD50 Offset: 0xF9B350 VA: 0x180F9CD50 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xF9D1A0 Offset: 0xF9B7A0 VA: 0x180F9D1A0
	private object ReadRegexString(JsonReader reader) { }

	// RVA: 0xF9CF40 Offset: 0xF9B540 VA: 0x180F9CF40
	private Regex ReadRegexObject(JsonReader reader, JsonSerializer serializer) { }

	// RVA: 0xF9CCD0 Offset: 0xF9B2D0 VA: 0x180F9CCD0 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

