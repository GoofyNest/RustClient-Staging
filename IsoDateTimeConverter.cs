public class IsoDateTimeConverter : DateTimeConverterBase // TypeDefIndex: 6109
{	// Fields
	private DateTimeStyles _dateTimeStyles; // 0x10
	private string _dateTimeFormat; // 0x18
	private CultureInfo _culture; // 0x20

	// Properties
	public CultureInfo Culture { get; }

	// Methods

	// RVA: 0xF89350 Offset: 0xF87950 VA: 0x180F89350
	public CultureInfo get_Culture() { }

	// RVA: 0xF890D0 Offset: 0xF876D0 VA: 0x180F890D0 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xF88B20 Offset: 0xF87120 VA: 0x180F88B20 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xF89340 Offset: 0xF87940 VA: 0x180F89340
	public void .ctor() { }

}

