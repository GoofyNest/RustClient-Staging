internal static class CollectionParser // TypeDefIndex: 5762
{	// Methods

	// RVA: -1 Offset: -1
	public static bool TryParse<T>(string input, int minimalCount, ElementTryParser<T> parser, out List<T> result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEEDD0 Offset: 0xBED3D0 VA: 0x180BEEDD0
	|-CollectionParser.TryParse<AuthenticationHeaderValue>
	|-CollectionParser.TryParse<EntityTagHeaderValue>
	|-CollectionParser.TryParse<MediaTypeWithQualityHeaderValue>
	|-CollectionParser.TryParse<NameValueHeaderValue>
	|-CollectionParser.TryParse<NameValueWithParametersHeaderValue>
	|-CollectionParser.TryParse<ProductHeaderValue>
	|-CollectionParser.TryParse<StringWithQualityHeaderValue>
	|-CollectionParser.TryParse<TransferCodingHeaderValue>
	|-CollectionParser.TryParse<TransferCodingWithQualityHeaderValue>
	|-CollectionParser.TryParse<ViaHeaderValue>
	|-CollectionParser.TryParse<WarningHeaderValue>
	|-CollectionParser.TryParse<object>
	|-CollectionParser.TryParse<string>
	*/

	// RVA: 0x1087640 Offset: 0x1085C40 VA: 0x181087640
	public static bool TryParse(string input, int minimalCount, out List<string> result) { }

	// RVA: 0x1087500 Offset: 0x1085B00 VA: 0x181087500
	private static bool TryParseStringElement(Lexer lexer, out string parsedValue, out Token t) { }

}

