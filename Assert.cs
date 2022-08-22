public static class Assert // TypeDefIndex: 3904
{	[ObsoleteAttribute] // RVA: 0x85B90 Offset: 0x84F90 VA: 0x180085B90
	public static bool raiseExceptions; // 0x13282


	private static void Fail(string message, string userMessage) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	public static void IsTrue(bool condition) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	public static void IsTrue(bool condition, string message) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	public static void IsFalse(bool condition) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	public static void IsFalse(bool condition, string message) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
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
	public static void AreEqual(Object expected, Object actual, string message) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
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
	public static void IsNotNull(Object value, string message) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	public static void AreEqual(int expected, int actual) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	public static void AreEqual(uint expected, uint actual) { }

	private static void .cctor() { }

}

