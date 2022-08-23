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
	|-RVA: 0x5C9680 Offset: 0x5C7C80 VA: 0x1805C9680
	|-Assert.AreEqual<RendererGrid>
	|-Assert.AreEqual<object>
	|
	|-RVA: 0x5C99B0 Offset: 0x5C7FB0 VA: 0x1805C99B0
	|-Assert.AreEqual<uint>
	*/

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	public static void AreEqual<T>(T expected, T actual, string message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C95D0 Offset: 0x5C7BD0 VA: 0x1805C95D0
	|-Assert.AreEqual<int>
	|
	|-RVA: 0x5C9700 Offset: 0x5C7D00 VA: 0x1805C9700
	|-Assert.AreEqual<object>
	|
	|-RVA: 0x5C9A30 Offset: 0x5C8030 VA: 0x1805C9A30
	|-Assert.AreEqual<uint>
	*/

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	public static void AreEqual<T>(T expected, T actual, string message, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C9320 Offset: 0x5C7920 VA: 0x1805C9320
	|-Assert.AreEqual<int>
	|
	|-RVA: 0x5C97B0 Offset: 0x5C7DB0 VA: 0x1805C97B0
	|-Assert.AreEqual<object>
	|
	|-RVA: 0x5C9AE0 Offset: 0x5C80E0 VA: 0x1805C9AE0
	|-Assert.AreEqual<uint>
	*/

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	public static void AreEqual(Object expected, Object actual, string message) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	public static void IsNotNull<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C9D90 Offset: 0x5C8390 VA: 0x1805C9D90
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
	|-RVA: 0x5C9E00 Offset: 0x5C8400 VA: 0x1805C9E00
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

