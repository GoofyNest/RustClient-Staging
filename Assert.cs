public static class Assert // TypeDefIndex: 3904
{	// Fields
	[ObsoleteAttribute] // RVA: 0x85B90 Offset: 0x84F90 VA: 0x180085B90
	public static bool raiseExceptions; // 0x13282

	// Methods

	// RVA: 0x180B2A0 Offset: 0x18098A0 VA: 0x18180B2A0
	private static void Fail(string message, string userMessage) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: 0x180B840 Offset: 0x1809E40 VA: 0x18180B840
	public static void IsTrue(bool condition) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: 0x180B950 Offset: 0x1809F50 VA: 0x18180B950
	public static void IsTrue(bool condition, string message) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: 0x180B450 Offset: 0x1809A50 VA: 0x18180B450
	public static void IsFalse(bool condition) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: 0x180B550 Offset: 0x1809B50 VA: 0x18180B550
	public static void IsFalse(bool condition, string message) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: -1 Offset: -1
	public static void AreEqual<T>(T expected, T actual) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C95B0 Offset: 0x5C7BB0 VA: 0x1805C95B0
	|-Assert.AreEqual<RendererGrid>
	|-Assert.AreEqual<object>
	|
	|-RVA: 0x5C98E0 Offset: 0x5C7EE0 VA: 0x1805C98E0
	|-Assert.AreEqual<uint>
	*/

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: -1 Offset: -1
	public static void AreEqual<T>(T expected, T actual, string message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C9500 Offset: 0x5C7B00 VA: 0x1805C9500
	|-Assert.AreEqual<int>
	|
	|-RVA: 0x5C9630 Offset: 0x5C7C30 VA: 0x1805C9630
	|-Assert.AreEqual<object>
	|
	|-RVA: 0x5C9960 Offset: 0x5C7F60 VA: 0x1805C9960
	|-Assert.AreEqual<uint>
	*/

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: -1 Offset: -1
	public static void AreEqual<T>(T expected, T actual, string message, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C9250 Offset: 0x5C7850 VA: 0x1805C9250
	|-Assert.AreEqual<int>
	|
	|-RVA: 0x5C96E0 Offset: 0x5C7CE0 VA: 0x1805C96E0
	|-Assert.AreEqual<object>
	|
	|-RVA: 0x5C9A10 Offset: 0x5C8010 VA: 0x1805C9A10
	|-Assert.AreEqual<uint>
	*/

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: 0x180B1E0 Offset: 0x18097E0 VA: 0x18180B1E0
	public static void AreEqual(Object expected, Object actual, string message) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: -1 Offset: -1
	public static void IsNotNull<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C9CC0 Offset: 0x5C82C0 VA: 0x1805C9CC0
	|-Assert.IsNotNull<Manifest>
	|-Assert.IsNotNull<Dictionary<IPEndPoint, int>>
	|-Assert.IsNotNull<object>
	|-Assert.IsNotNull<Type>
	|-Assert.IsNotNull<AnimationCurve>
	|-Assert.IsNotNull<PostProcessEffectSettings>
	|-Assert.IsNotNull<PostProcessResources>
	|-Assert.IsNotNull<Texture>
	*/

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: -1 Offset: -1
	public static void IsNotNull<T>(T value, string message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C9D30 Offset: 0x5C8330 VA: 0x1805C9D30
	|-Assert.IsNotNull<InputState>
	|-Assert.IsNotNull<Client>
	|-Assert.IsNotNull<NetWrite>
	|-Assert.IsNotNull<PlayerInput>
	|-Assert.IsNotNull<List<PostProcessVolume>>
	|-Assert.IsNotNull<object>
	|-Assert.IsNotNull<PostProcessEffectSettings>
	*/

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: 0x180B630 Offset: 0x1809C30 VA: 0x18180B630
	public static void IsNotNull(Object value, string message) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: 0x180B170 Offset: 0x1809770 VA: 0x18180B170
	public static void AreEqual(int expected, int actual) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: 0x180B100 Offset: 0x1809700 VA: 0x18180B100
	public static void AreEqual(uint expected, uint actual) { }

	// RVA: 0x180BA30 Offset: 0x180A030 VA: 0x18180BA30
	private static void .cctor() { }

}

