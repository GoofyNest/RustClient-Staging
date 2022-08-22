internal static class ThrowIfArgument // TypeDefIndex: 7637
{	// Methods

	// RVA: 0x13A9380 Offset: 0x13A7980 VA: 0x1813A9380
	internal static void IsNull(string parameterName, object argument) { }

	// RVA: -1 Offset: -1
	internal static void IsInvalidEnumValue<TEnum>(string parameterName, TEnum argument) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157D7D0 Offset: 0x157BDD0 VA: 0x18157D7D0
	|-ThrowIfArgument.IsInvalidEnumValue<SmpteFormat>
	|-ThrowIfArgument.IsInvalidEnumValue<MidiTimeCodeComponent>
	|-ThrowIfArgument.IsInvalidEnumValue<ByteEnum>
	|
	|-RVA: 0x157D960 Offset: 0x157BF60 VA: 0x18157D960
	|-ThrowIfArgument.IsInvalidEnumValue<TimeSpanMode>
	|-ThrowIfArgument.IsInvalidEnumValue<Int32Enum>
	*/

	// RVA: 0x13A93F0 Offset: 0x13A79F0 VA: 0x1813A93F0
	internal static void IsOutOfRange(string parameterName, int value, int min, int max, string message) { }

	// RVA: 0x13A94A0 Offset: 0x13A7AA0 VA: 0x1813A94A0
	internal static void IsOutOfRange(string parameterName, long value, long min, long max, string message) { }

	// RVA: 0x13A9550 Offset: 0x13A7B50 VA: 0x1813A9550
	internal static void IsOutOfRange(string parameterName, double value, double min, double max, string message) { }

	// RVA: 0x13A8ED0 Offset: 0x13A74D0 VA: 0x1813A8ED0
	internal static void DoesntSatisfyCondition(string parameterName, int value, Predicate<int> condition, string message) { }

	// RVA: 0x13A8F90 Offset: 0x13A7590 VA: 0x1813A8F90
	internal static void IsGreaterThan(string parameterName, int value, int reference, string message) { }

	// RVA: 0x13A9030 Offset: 0x13A7630 VA: 0x1813A9030
	internal static void IsLessThan(string parameterName, int value, int reference, string message) { }

	// RVA: 0x13A9060 Offset: 0x13A7660 VA: 0x1813A9060
	internal static void IsLessThan(string parameterName, long value, long reference, string message) { }

	// RVA: 0x13A9090 Offset: 0x13A7690 VA: 0x1813A9090
	internal static void IsLessThan(string parameterName, double value, double reference, string message) { }

	// RVA: 0x13A9160 Offset: 0x13A7760 VA: 0x1813A9160
	internal static void IsNegative(string parameterName, int value, string message) { }

	// RVA: 0x13A9250 Offset: 0x13A7850 VA: 0x1813A9250
	internal static void IsNegative(string parameterName, long value, string message) { }

	// RVA: 0x13A9190 Offset: 0x13A7790 VA: 0x1813A9190
	internal static void IsNegative(string parameterName, double value, string message) { }

	// RVA: 0x13A92B0 Offset: 0x13A78B0 VA: 0x1813A92B0
	internal static void IsNonpositive(string parameterName, int value, string message) { }

	// RVA: 0x13A9280 Offset: 0x13A7880 VA: 0x1813A9280
	internal static void IsNonpositive(string parameterName, long value, string message) { }

	// RVA: 0x13A92E0 Offset: 0x13A78E0 VA: 0x1813A92E0
	internal static void IsNullOrWhiteSpaceString(string parameterName, string value, string stringDescription) { }

	// RVA: 0x13A8FC0 Offset: 0x13A75C0 VA: 0x1813A8FC0
	internal static void IsInvalidIndex(string parameterName, int index, int collectionSize) { }

	// RVA: -1 Offset: -1
	internal static void StartsWithInvalidValue<T>(string parameterName, IEnumerable<T> collection, T invalidValue, string message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157DAF0 Offset: 0x157C0F0 VA: 0x18157DAF0
	|-ThrowIfArgument.StartsWithInvalidValue<byte>
	|
	|-RVA: 0x157DBD0 Offset: 0x157C1D0 VA: 0x18157DBD0
	|-ThrowIfArgument.StartsWithInvalidValue<object>
	*/

}

