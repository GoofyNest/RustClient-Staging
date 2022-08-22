public class IsoDateTimeConverter : DateTimeConverterBase // TypeDefIndex: 6109
{	// Fields
	private DateTimeStyles _dateTimeStyles; // 0x10
	private string _dateTimeFormat; // 0x18
	private CultureInfo _culture; // 0x20

	// Properties
	public CultureInfo Culture { get; }

	// Methods

	// RVA: 0xF8A0B0 Offset: 0xF886B0 VA: 0x180F8A0B0
	public CultureInfo get_Culture() { }

	// RVA: 0xF89E30 Offset: 0xF88430 VA: 0x180F89E30 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xF89880 Offset: 0xF87E80 VA: 0x180F89880 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xF8A0A0 Offset: 0xF886A0 VA: 0x180F8A0A0
	public void .ctor() { }

}

