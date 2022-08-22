internal static class ThrowIfArgument // TypeDefIndex: 7637
{	// Methods

	// RVA: 0x13A8480 Offset: 0x13A6A80 VA: 0x1813A8480
	internal static void IsNull(string parameterName, object argument) { }

	// RVA: -1 Offset: -1
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

	// RVA: 0x13A84F0 Offset: 0x13A6AF0 VA: 0x1813A84F0
	internal static void IsOutOfRange(string parameterName, int value, int min, int max, string message) { }

	// RVA: 0x13A85A0 Offset: 0x13A6BA0 VA: 0x1813A85A0
	internal static void IsOutOfRange(string parameterName, long value, long min, long max, string message) { }

	// RVA: 0x13A8650 Offset: 0x13A6C50 VA: 0x1813A8650
	internal static void IsOutOfRange(string parameterName, double value, double min, double max, string message) { }

	// RVA: 0x13A7FD0 Offset: 0x13A65D0 VA: 0x1813A7FD0
	internal static void DoesntSatisfyCondition(string parameterName, int value, Predicate<int> condition, string message) { }

	// RVA: 0x13A8090 Offset: 0x13A6690 VA: 0x1813A8090
	internal static void IsGreaterThan(string parameterName, int value, int reference, string message) { }

	// RVA: 0x13A8130 Offset: 0x13A6730 VA: 0x1813A8130
	internal static void IsLessThan(string parameterName, int value, int reference, string message) { }

	// RVA: 0x13A8160 Offset: 0x13A6760 VA: 0x1813A8160
	internal static void IsLessThan(string parameterName, long value, long reference, string message) { }

	// RVA: 0x13A8190 Offset: 0x13A6790 VA: 0x1813A8190
	internal static void IsLessThan(string parameterName, double value, double reference, string message) { }

	// RVA: 0x13A8260 Offset: 0x13A6860 VA: 0x1813A8260
	internal static void IsNegative(string parameterName, int value, string message) { }

	// RVA: 0x13A8350 Offset: 0x13A6950 VA: 0x1813A8350
	internal static void IsNegative(string parameterName, long value, string message) { }

	// RVA: 0x13A8290 Offset: 0x13A6890 VA: 0x1813A8290
	internal static void IsNegative(string parameterName, double value, string message) { }

	// RVA: 0x13A83B0 Offset: 0x13A69B0 VA: 0x1813A83B0
	internal static void IsNonpositive(string parameterName, int value, string message) { }

	// RVA: 0x13A8380 Offset: 0x13A6980 VA: 0x1813A8380
	internal static void IsNonpositive(string parameterName, long value, string message) { }

	// RVA: 0x13A83E0 Offset: 0x13A69E0 VA: 0x1813A83E0
	internal static void IsNullOrWhiteSpaceString(string parameterName, string value, string stringDescription) { }

	// RVA: 0x13A80C0 Offset: 0x13A66C0 VA: 0x1813A80C0
	internal static void IsInvalidIndex(string parameterName, int index, int collectionSize) { }

	// RVA: -1 Offset: -1
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

