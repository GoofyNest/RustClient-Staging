public static class Assert // TypeDefIndex: 3904
{	// Fields
	[ObsoleteAttribute] // RVA: 0x85B90 Offset: 0x84F90 VA: 0x180085B90
	public static bool raiseExceptions; // 0x2B113D8

	// Methods

	// RVA: 0x181DE60 Offset: 0x181C460 VA: 0x18181DE60
	private static void Fail(string message, string userMessage) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: 0x181E400 Offset: 0x181CA00 VA: 0x18181E400
	public static void IsTrue(bool condition) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: 0x181E510 Offset: 0x181CB10 VA: 0x18181E510
	public static void IsTrue(bool condition, string message) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: 0x181E010 Offset: 0x181C610 VA: 0x18181E010
	public static void IsFalse(bool condition) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: 0x181E110 Offset: 0x181C710 VA: 0x18181E110
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
	// RVA: 0x181DDA0 Offset: 0x181C3A0 VA: 0x18181DDA0
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
	// RVA: 0x181E1F0 Offset: 0x181C7F0 VA: 0x18181E1F0
	public static void IsNotNull(Object value, string message) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: 0x181DD30 Offset: 0x181C330 VA: 0x18181DD30
	public static void AreEqual(int expected, int actual) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: 0x181DCC0 Offset: 0x181C2C0 VA: 0x18181DCC0
	public static void AreEqual(uint expected, uint actual) { }

	// RVA: 0x181E5F0 Offset: 0x181CBF0 VA: 0x18181E5F0
	private static void .cctor() { }

}

