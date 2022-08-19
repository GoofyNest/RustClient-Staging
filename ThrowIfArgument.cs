internal static class ThrowIfArgument // TypeDefIndex: 7637
{	// Methods

	// RVA: 0x13A90C0 Offset: 0x13A76C0 VA: 0x1813A90C0
	internal static void IsNull(string parameterName, object argument) { }

	// RVA: -1 Offset: -1
	internal static void IsInvalidEnumValue<TEnum>(string parameterName, TEnum argument) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157D510 Offset: 0x157BB10 VA: 0x18157D510
	|-ThrowIfArgument.IsInvalidEnumValue<SmpteFormat>
	|-ThrowIfArgument.IsInvalidEnumValue<MidiTimeCodeComponent>
	|-ThrowIfArgument.IsInvalidEnumValue<ByteEnum>
	|
	|-RVA: 0x157D6A0 Offset: 0x157BCA0 VA: 0x18157D6A0
	|-ThrowIfArgument.IsInvalidEnumValue<TimeSpanMode>
	|-ThrowIfArgument.IsInvalidEnumValue<Int32Enum>
	*/

	// RVA: 0x13A9130 Offset: 0x13A7730 VA: 0x1813A9130
	internal static void IsOutOfRange(string parameterName, int value, int min, int max, string message) { }

	// RVA: 0x13A91E0 Offset: 0x13A77E0 VA: 0x1813A91E0
	internal static void IsOutOfRange(string parameterName, long value, long min, long max, string message) { }

	// RVA: 0x13A9290 Offset: 0x13A7890 VA: 0x1813A9290
	internal static void IsOutOfRange(string parameterName, double value, double min, double max, string message) { }

	// RVA: 0x13A8C10 Offset: 0x13A7210 VA: 0x1813A8C10
	internal static void DoesntSatisfyCondition(string parameterName, int value, Predicate<int> condition, string message) { }

	// RVA: 0x13A8CD0 Offset: 0x13A72D0 VA: 0x1813A8CD0
	internal static void IsGreaterThan(string parameterName, int value, int reference, string message) { }

	// RVA: 0x13A8D70 Offset: 0x13A7370 VA: 0x1813A8D70
	internal static void IsLessThan(string parameterName, int value, int reference, string message) { }

	// RVA: 0x13A8DA0 Offset: 0x13A73A0 VA: 0x1813A8DA0
	internal static void IsLessThan(string parameterName, long value, long reference, string message) { }

	// RVA: 0x13A8DD0 Offset: 0x13A73D0 VA: 0x1813A8DD0
	internal static void IsLessThan(string parameterName, double value, double reference, string message) { }

	// RVA: 0x13A8EA0 Offset: 0x13A74A0 VA: 0x1813A8EA0
	internal static void IsNegative(string parameterName, int value, string message) { }

	// RVA: 0x13A8F90 Offset: 0x13A7590 VA: 0x1813A8F90
	internal static void IsNegative(string parameterName, long value, string message) { }

	// RVA: 0x13A8ED0 Offset: 0x13A74D0 VA: 0x1813A8ED0
	internal static void IsNegative(string parameterName, double value, string message) { }

	// RVA: 0x13A8FF0 Offset: 0x13A75F0 VA: 0x1813A8FF0
	internal static void IsNonpositive(string parameterName, int value, string message) { }

	// RVA: 0x13A8FC0 Offset: 0x13A75C0 VA: 0x1813A8FC0
	internal static void IsNonpositive(string parameterName, long value, string message) { }

	// RVA: 0x13A9020 Offset: 0x13A7620 VA: 0x1813A9020
	internal static void IsNullOrWhiteSpaceString(string parameterName, string value, string stringDescription) { }

	// RVA: 0x13A8D00 Offset: 0x13A7300 VA: 0x1813A8D00
	internal static void IsInvalidIndex(string parameterName, int index, int collectionSize) { }

	// RVA: -1 Offset: -1
	internal static void StartsWithInvalidValue<T>(string parameterName, IEnumerable<T> collection, T invalidValue, string message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157D830 Offset: 0x157BE30 VA: 0x18157D830
	|-ThrowIfArgument.StartsWithInvalidValue<byte>
	|
	|-RVA: 0x157D910 Offset: 0x157BF10 VA: 0x18157D910
	|-ThrowIfArgument.StartsWithInvalidValue<object>
	*/

}

