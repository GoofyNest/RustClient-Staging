internal static class ThrowIfArgument // TypeDefIndex: 7637
{
	internal static void IsNull(string parameterName, object argument) { }

	internal static void IsInvalidEnumValue<TEnum>(string parameterName, TEnum argument) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157C8A0 Offset: 0x157AEA0 VA: 0x18157C8A0
	|-ThrowIfArgument.IsInvalidEnumValue<SmpteFormat>
	|-ThrowIfArgument.IsInvalidEnumValue<MidiTimeCodeComponent>
	|-ThrowIfArgument.IsInvalidEnumValue<ByteEnum>
	|
	|-RVA: 0x157CA30 Offset: 0x157B030 VA: 0x18157CA30
	|-ThrowIfArgument.IsInvalidEnumValue<TimeSpanMode>
	|-ThrowIfArgument.IsInvalidEnumValue<Int32Enum>
	*/

	internal static void IsOutOfRange(string parameterName, int value, int min, int max, string message) { }

	internal static void IsOutOfRange(string parameterName, long value, long min, long max, string message) { }

	internal static void IsOutOfRange(string parameterName, double value, double min, double max, string message) { }

	internal static void DoesntSatisfyCondition(string parameterName, int value, Predicate<int> condition, string message) { }

	internal static void IsGreaterThan(string parameterName, int value, int reference, string message) { }

	internal static void IsLessThan(string parameterName, int value, int reference, string message) { }

	internal static void IsLessThan(string parameterName, long value, long reference, string message) { }

	internal static void IsLessThan(string parameterName, double value, double reference, string message) { }

	internal static void IsNegative(string parameterName, int value, string message) { }

	internal static void IsNegative(string parameterName, long value, string message) { }

	internal static void IsNegative(string parameterName, double value, string message) { }

	internal static void IsNonpositive(string parameterName, int value, string message) { }

	internal static void IsNonpositive(string parameterName, long value, string message) { }

	internal static void IsNullOrWhiteSpaceString(string parameterName, string value, string stringDescription) { }

	internal static void IsInvalidIndex(string parameterName, int index, int collectionSize) { }

	internal static void StartsWithInvalidValue<T>(string parameterName, IEnumerable<T> collection, T invalidValue, string message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157CBC0 Offset: 0x157B1C0 VA: 0x18157CBC0
	|-ThrowIfArgument.StartsWithInvalidValue<byte>
	|
	|-RVA: 0x157CCA0 Offset: 0x157B2A0 VA: 0x18157CCA0
	|-ThrowIfArgument.StartsWithInvalidValue<object>
	*/

}

