public static class Assert // TypeDefIndex: 3904
{	// Fields
	[ObsoleteAttribute] // RVA: 0x85B90 Offset: 0x84F90 VA: 0x180085B90
	public static bool raiseExceptions; // 0x2B10398

	// Methods

	// RVA: 0x181DBA0 Offset: 0x181C1A0 VA: 0x18181DBA0
	private static void Fail(string message, string userMessage) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: 0x181E140 Offset: 0x181C740 VA: 0x18181E140
	public static void IsTrue(bool condition) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: 0x181E250 Offset: 0x181C850 VA: 0x18181E250
	public static void IsTrue(bool condition, string message) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: 0x181DD50 Offset: 0x181C350 VA: 0x18181DD50
	public static void IsFalse(bool condition) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: 0x181DE50 Offset: 0x181C450 VA: 0x18181DE50
	public static void IsFalse(bool condition, string message) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: -1 Offset: -1
	public static void AreEqual<T>(T expected, T actual) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C9620 Offset: 0x5C7C20 VA: 0x1805C9620
	|-Assert.AreEqual<RendererGrid>
	|-Assert.AreEqual<object>
	|
	|-RVA: 0x5C9950 Offset: 0x5C7F50 VA: 0x1805C9950
	|-Assert.AreEqual<uint>
	*/

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: -1 Offset: -1
	public static void AreEqual<T>(T expected, T actual, string message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C9570 Offset: 0x5C7B70 VA: 0x1805C9570
	|-Assert.AreEqual<int>
	|
	|-RVA: 0x5C96A0 Offset: 0x5C7CA0 VA: 0x1805C96A0
	|-Assert.AreEqual<object>
	|
	|-RVA: 0x5C99D0 Offset: 0x5C7FD0 VA: 0x1805C99D0
	|-Assert.AreEqual<uint>
	*/

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: -1 Offset: -1
	public static void AreEqual<T>(T expected, T actual, string message, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C92C0 Offset: 0x5C78C0 VA: 0x1805C92C0
	|-Assert.AreEqual<int>
	|
	|-RVA: 0x5C9750 Offset: 0x5C7D50 VA: 0x1805C9750
	|-Assert.AreEqual<object>
	|
	|-RVA: 0x5C9A80 Offset: 0x5C8080 VA: 0x1805C9A80
	|-Assert.AreEqual<uint>
	*/

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: 0x181DAE0 Offset: 0x181C0E0 VA: 0x18181DAE0
	public static void AreEqual(Object expected, Object actual, string message) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: -1 Offset: -1
	public static void IsNotNull<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C9D30 Offset: 0x5C8330 VA: 0x1805C9D30
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
	|-RVA: 0x5C9DA0 Offset: 0x5C83A0 VA: 0x1805C9DA0
	|-Assert.IsNotNull<InputState>
	|-Assert.IsNotNull<Client>
	|-Assert.IsNotNull<NetWrite>
	|-Assert.IsNotNull<PlayerInput>
	|-Assert.IsNotNull<List<PostProcessVolume>>
	|-Assert.IsNotNull<object>
	|-Assert.IsNotNull<PostProcessEffectSettings>
	*/

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: 0x181DF30 Offset: 0x181C530 VA: 0x18181DF30
	public static void IsNotNull(Object value, string message) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: 0x181DA70 Offset: 0x181C070 VA: 0x18181DA70
	public static void AreEqual(int expected, int actual) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: 0x181DA00 Offset: 0x181C000 VA: 0x18181DA00
	public static void AreEqual(uint expected, uint actual) { }

	// RVA: 0x181E330 Offset: 0x181C930 VA: 0x18181E330
	private static void .cctor() { }

}

