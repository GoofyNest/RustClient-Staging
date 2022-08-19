internal static class CollectionParser // TypeDefIndex: 5762
{	// Methods

	// RVA: -1 Offset: -1
	public static bool TryParse<T>(string input, int minimalCount, ElementTryParser<T> parser, out List<T> result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEE640 Offset: 0xBECC40 VA: 0x180BEE640
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

	// RVA: 0x1086910 Offset: 0x1084F10 VA: 0x181086910
	public static bool TryParse(string input, int minimalCount, out List<string> result) { }

	// RVA: 0x10867D0 Offset: 0x1084DD0 VA: 0x1810867D0
	private static bool TryParseStringElement(Lexer lexer, out string parsedValue, out Token t) { }

}

