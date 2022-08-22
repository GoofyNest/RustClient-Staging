public class IsoDateTimeConverter : DateTimeConverterBase // TypeDefIndex: 6109
{	// Fields
	private DateTimeStyles _dateTimeStyles; // 0x10
	private string _dateTimeFormat; // 0x18
	private CultureInfo _culture; // 0x20

	// Properties
	public CultureInfo Culture { get; }

	// Methods

	// RVA: 0xF89610 Offset: 0xF87C10 VA: 0x180F89610
	public CultureInfo get_Culture() { }

	// RVA: 0xF89390 Offset: 0xF87990 VA: 0x180F89390 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xF88DE0 Offset: 0xF873E0 VA: 0x180F88DE0 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xF89600 Offset: 0xF87C00 VA: 0x180F89600
	public void .ctor() { }

}

