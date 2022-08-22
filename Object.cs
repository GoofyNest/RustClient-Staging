public class Object // TypeDefIndex: 383
{	// Methods

	// RVA: 0xAE59E0 Offset: 0xAE3FE0 VA: 0x180AE59E0 Slot: 0
	public virtual bool Equals(object obj) { }

	// RVA: 0x1683710 Offset: 0x1681D10 VA: 0x181683710
	public static bool Equals(object objA, object objB) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void .ctor() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 1
	protected virtual void Finalize() { }

	// RVA: 0x1683740 Offset: 0x1681D40 VA: 0x181683740 Slot: 2
	public virtual int GetHashCode() { }

	// RVA: 0x1683750 Offset: 0x1681D50 VA: 0x181683750
	public Type GetType() { }

	// RVA: 0x1683760 Offset: 0x1681D60 VA: 0x181683760
	protected object MemberwiseClone() { }

	// RVA: 0x1683770 Offset: 0x1681D70 VA: 0x181683770 Slot: 3
	public virtual string ToString() { }

	// RVA: 0x1683740 Offset: 0x1681D40 VA: 0x181683740
	internal static int InternalGetHashCode(object o) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void FieldGetter(string typeName, string fieldName, ref object val) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void FieldSetter(string typeName, string fieldName, object val) { }

}

public class Object // TypeDefIndex: 3535
{	// Fields
	private IntPtr m_CachedPtr; // 0x10
	internal static int OffsetOfInstanceIDInCPlusPlusObject; // 0x0
	private const string objectIsNullMessage = "The Object you want to instantiate is null.";
	private const string cloneDestroyedMessage = "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.";

	// Properties
	public string name { get; set; }
	public HideFlags hideFlags { get; set; }

	// Methods

	// RVA: 0x18F8240 Offset: 0x18F6840 VA: 0x1818F8240
	public int GetInstanceID() { }

	// RVA: 0x18F8230 Offset: 0x18F6830 VA: 0x1818F8230 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18F7E50 Offset: 0x18F6450 VA: 0x1818F7E50 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x18F96D0 Offset: 0x18F7CD0 VA: 0x1818F96D0
	public static bool op_Implicit(Object exists) { }

	// RVA: 0x18F7B60 Offset: 0x18F6160 VA: 0x1818F7B60
	private static bool CompareBaseObjects(Object lhs, Object rhs) { }

	// RVA: 0x18F9320 Offset: 0x18F7920 VA: 0x1818F9320
	private static bool IsNativeObjectAlive(Object o) { }

	// RVA: 0x181D9F0 Offset: 0x181BFF0 VA: 0x18181D9F0
	private IntPtr GetCachedPtr() { }

	// RVA: 0x18F94F0 Offset: 0x18F7AF0 VA: 0x1818F94F0
	public string get_name() { }

	// RVA: 0x18F9950 Offset: 0x18F7F50 VA: 0x1818F9950
	public void set_name(string value) { }

	[TypeInferenceRuleAttribute] // RVA: 0xC5BE0 Offset: 0xC4FE0 VA: 0x1800C5BE0
	// RVA: 0x18F8DA0 Offset: 0x18F73A0 VA: 0x1818F8DA0
	public static Object Instantiate(Object original, Vector3 position, Quaternion rotation) { }

	[TypeInferenceRuleAttribute] // RVA: 0xC5BE0 Offset: 0xC4FE0 VA: 0x1800C5BE0
	// RVA: 0x18F85A0 Offset: 0x18F6BA0 VA: 0x1818F85A0
	public static Object Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent) { }

	[TypeInferenceRuleAttribute] // RVA: 0xC5BE0 Offset: 0xC4FE0 VA: 0x1800C5BE0
	// RVA: 0x18F83E0 Offset: 0x18F69E0 VA: 0x1818F83E0
	public static Object Instantiate(Object original) { }

	[TypeInferenceRuleAttribute] // RVA: 0xC5BE0 Offset: 0xC4FE0 VA: 0x1800C5BE0
	// RVA: 0x18F8920 Offset: 0x18F6F20 VA: 0x1818F8920
	public static Object Instantiate(Object original, Transform parent, bool instantiateInWorldSpace) { }

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B9B80 Offset: 0x15B8180 VA: 0x1815B9B80
	|-Object.Instantiate<ERMarkerExt>
	|-Object.Instantiate<ERSOMarkerExt>
	|-Object.Instantiate<ERSORoadExt>
	|-Object.Instantiate<ItemSearchEntry>
	|-Object.Instantiate<TechTreeDialog>
	|-Object.Instantiate<TechTreeEntry>
	|-Object.Instantiate<TechTreeGroup>
	|-Object.Instantiate<TechTreeLine>
	|-Object.Instantiate<GameObject>
	|-Object.Instantiate<Material>
	|-Object.Instantiate<Mesh>
	|-Object.Instantiate<ParticleSystem>
	|-Object.Instantiate<PostProcessEffectSettings>
	|-Object.Instantiate<Texture2D>
	|-Object.Instantiate<Transform>
	|-Object.Instantiate<Dropdown.DropdownItem>
	|-Object.Instantiate<object>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B9EC0 Offset: 0x15B84C0 VA: 0x1815B9EC0
	|-Object.Instantiate<ArcadeEntity>
	|-Object.Instantiate<ArcadeEntityController>
	|-Object.Instantiate<BaseArcadeGame>
	|-Object.Instantiate<GameObject>
	|-Object.Instantiate<object>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation, Transform parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B9DD0 Offset: 0x15B83D0 VA: 0x1815B9DD0
	|-Object.Instantiate<GameObject>
	|-Object.Instantiate<object>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original, Transform parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B9C90 Offset: 0x15B8290 VA: 0x1815B9C90
	|-Object.Instantiate<ContactsEntry>
	|-Object.Instantiate<HttpImage>
	|-Object.Instantiate<RustText>
	|-Object.Instantiate<SleepingBagButton>
	|-Object.Instantiate<SleepingBagClusterMapMarker>
	|-Object.Instantiate<SleepingBagMapMarker>
	|-Object.Instantiate<UIMapVendingMachineMarker>
	|-Object.Instantiate<GameObject>
	|-Object.Instantiate<object>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original, Transform parent, bool worldPositionStays) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B9D10 Offset: 0x15B8310 VA: 0x1815B9D10
	|-Object.Instantiate<object>
	*/

	[NativeMethodAttribute] // RVA: 0xC5F20 Offset: 0xC5320 VA: 0x1800C5F20
	// RVA: 0x18F7D50 Offset: 0x18F6350 VA: 0x1818F7D50
	public static void Destroy(Object obj, float t) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F7DA0 Offset: 0x18F63A0 VA: 0x1818F7DA0
	public static void Destroy(Object obj) { }

	[NativeMethodAttribute] // RVA: 0xC6230 Offset: 0xC5630 VA: 0x1800C6230
	// RVA: 0x18F7D00 Offset: 0x18F6300 VA: 0x1818F7D00
	public static void DestroyImmediate(Object obj, bool allowDestroyingAssets) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F7C90 Offset: 0x18F6290 VA: 0x1818F7C90
	public static void DestroyImmediate(Object obj) { }

	[FreeFunctionAttribute] // RVA: 0xC6380 Offset: 0xC5780 VA: 0x1800C6380
	[TypeInferenceRuleAttribute] // RVA: 0xC6380 Offset: 0xC5780 VA: 0x1800C6380
	// RVA: 0x18F81F0 Offset: 0x18F67F0 VA: 0x1818F81F0
	public static Object[] FindObjectsOfType(Type type) { }

	[FreeFunctionAttribute] // RVA: 0xC6410 Offset: 0xC5810 VA: 0x1800C6410
	// RVA: 0x18F7E10 Offset: 0x18F6410 VA: 0x1818F7E10
	public static void DontDestroyOnLoad(Object target) { }

	// RVA: 0x18F94B0 Offset: 0x18F7AB0 VA: 0x1818F94B0
	public HideFlags get_hideFlags() { }

	// RVA: 0x18F9910 Offset: 0x18F7F10 VA: 0x1818F9910
	public void set_hideFlags(HideFlags value) { }

	// RVA: -1 Offset: -1
	public static T[] FindObjectsOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3B5D0 Offset: 0x1A39BD0 VA: 0x181A3B5D0
	|-Object.FindObjectsOfType<BaseEntity>
	|-Object.FindObjectsOfType<BenchmarkScene>
	|-Object.FindObjectsOfType<BlendedLoopEngineSound>
	|-Object.FindObjectsOfType<DamageRenderer>
	|-Object.FindObjectsOfType<GameSetup>
	|-Object.FindObjectsOfType<LaserBeam>
	|-Object.FindObjectsOfType<RendererBatch>
	|-Object.FindObjectsOfType<PropRenderer>
	|-Object.FindObjectsOfType<SingletonComponent>
	|-Object.FindObjectsOfType<Animator>
	|-Object.FindObjectsOfType<BoxCollider>
	|-Object.FindObjectsOfType<CapsuleCollider>
	|-Object.FindObjectsOfType<Collider>
	|-Object.FindObjectsOfType<LODGroup>
	|-Object.FindObjectsOfType<MeshCollider>
	|-Object.FindObjectsOfType<Object>
	|-Object.FindObjectsOfType<ParticleSystem>
	|-Object.FindObjectsOfType<Renderer>
	|-Object.FindObjectsOfType<Rigidbody>
	|-Object.FindObjectsOfType<SphereCollider>
	|-Object.FindObjectsOfType<Texture>
	|-Object.FindObjectsOfType<Transform>
	|-Object.FindObjectsOfType<WearableShadowLod>
	|-Object.FindObjectsOfType<object>
	*/

	// RVA: -1 Offset: -1
	public static T FindObjectOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B9AA0 Offset: 0x15B80A0 VA: 0x1815B9AA0
	|-Object.FindObjectOfType<Client>
	|-Object.FindObjectOfType<CursorManager>
	|-Object.FindObjectOfType<MainCamera>
	|-Object.FindObjectOfType<MusicManager>
	|-Object.FindObjectOfType<Performance>
	|-Object.FindObjectOfType<SoundManager>
	|-Object.FindObjectOfType<Terrain>
	|-Object.FindObjectOfType<WindZone>
	|-Object.FindObjectOfType<object>
	*/

	// RVA: 0x18F7AF0 Offset: 0x18F60F0 VA: 0x1818F7AF0
	private static void CheckNullArgument(object arg, string message) { }

	[TypeInferenceRuleAttribute] // RVA: 0xB9C80 Offset: 0xB9080 VA: 0x1800B9C80
	// RVA: 0x18F8160 Offset: 0x18F6760 VA: 0x1818F8160
	public static Object FindObjectOfType(Type type) { }

	// RVA: 0x18F93C0 Offset: 0x18F79C0 VA: 0x1818F93C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x18F9560 Offset: 0x18F7B60 VA: 0x1818F9560
	public static bool op_Equality(Object x, Object y) { }

	// RVA: 0x18F97A0 Offset: 0x18F7DA0 VA: 0x1818F97A0
	public static bool op_Inequality(Object x, Object y) { }

	[NativeMethodAttribute] // RVA: 0xC6530 Offset: 0xC5930 VA: 0x1800C6530
	// RVA: 0x18F83B0 Offset: 0x18F69B0 VA: 0x1818F83B0
	private static int GetOffsetOfInstanceIDInCPlusPlusObject() { }

	[FreeFunctionAttribute] // RVA: 0xC6590 Offset: 0xC5990 VA: 0x1800C6590
	// RVA: 0x18F90E0 Offset: 0x18F76E0 VA: 0x1818F90E0
	private static Object Internal_CloneSingle(Object data) { }

	[FreeFunctionAttribute] // RVA: 0xC6590 Offset: 0xC5990 VA: 0x1800C6590
	// RVA: 0x18F9080 Offset: 0x18F7680 VA: 0x1818F9080
	private static Object Internal_CloneSingleWithParent(Object data, Transform parent, bool worldPositionStays) { }

	[FreeFunctionAttribute] // RVA: 0xC6720 Offset: 0xC5B20 VA: 0x1800C6720
	// RVA: 0x18F9290 Offset: 0x18F7890 VA: 0x1818F9290
	private static Object Internal_InstantiateSingle(Object data, Vector3 pos, Quaternion rot) { }

	[FreeFunctionAttribute] // RVA: 0xC6720 Offset: 0xC5B20 VA: 0x1800C6720
	// RVA: 0x18F9190 Offset: 0x18F7790 VA: 0x1818F9190
	private static Object Internal_InstantiateSingleWithParent(Object data, Transform parent, Vector3 pos, Quaternion rot) { }

	[FreeFunctionAttribute] // RVA: 0xC6A30 Offset: 0xC5E30 VA: 0x1800C6A30
	// RVA: 0x18F9430 Offset: 0x18F7A30 VA: 0x1818F9430
	private static string ToString(Object obj) { }

	[FreeFunctionAttribute] // RVA: 0xC6AF0 Offset: 0xC5EF0 VA: 0x1800C6AF0
	// RVA: 0x18F8370 Offset: 0x18F6970 VA: 0x1818F8370
	private static string GetName(Object obj) { }

	[FreeFunctionAttribute] // RVA: 0xC6BB0 Offset: 0xC5FB0 VA: 0x1800C6BB0
	// RVA: 0x18F9370 Offset: 0x18F7970 VA: 0x1818F9370
	private static void SetName(Object obj, string name) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xC6C70 Offset: 0xC6070 VA: 0x1800C6C70
	[FreeFunctionAttribute] // RVA: 0xC6C70 Offset: 0xC6070 VA: 0x1800C6C70
	// RVA: 0x18F8120 Offset: 0x18F6720 VA: 0x1818F8120
	internal static Object FindObjectFromInstanceID(int instanceID) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x18F9470 Offset: 0x18F7A70 VA: 0x1818F9470
	private static void .cctor() { }

	// RVA: 0x18F9230 Offset: 0x18F7830 VA: 0x1818F9230
	private static Object Internal_InstantiateSingle_Injected(Object data, ref Vector3 pos, ref Quaternion rot) { }

	// RVA: 0x18F9120 Offset: 0x18F7720 VA: 0x1818F9120
	private static Object Internal_InstantiateSingleWithParent_Injected(Object data, Transform parent, ref Vector3 pos, ref Quaternion rot) { }

}

public class Object : IEnumerable<KeyValuePair<string, Value>>, IEnumerable // TypeDefIndex: 8141
{	// Fields
	private readonly IDictionary<string, Value> values; // 0x10

	// Properties
	public Value Item { get; set; }

	// Methods

	// RVA: 0x1072F40 Offset: 0x1071540 VA: 0x181072F40
	public void .ctor() { }

	// RVA: 0x1072C90 Offset: 0x1071290 VA: 0x181072C90
	public void .ctor(Object other) { }

	// RVA: 0x1071420 Offset: 0x106FA20 VA: 0x181071420
	public bool ContainsKey(string key) { }

	// RVA: 0x10717F0 Offset: 0x106FDF0 VA: 0x1810717F0
	public Value GetValue(string key) { }

	// RVA: 0x1071760 Offset: 0x106FD60 VA: 0x181071760
	public string GetString(string key, string strDEFAULT = "") { }

	// RVA: 0x1071610 Offset: 0x106FC10 VA: 0x181071610
	public double GetNumber(string key, double iDefault = 0) { }

	// RVA: 0x10715F0 Offset: 0x106FBF0 VA: 0x1810715F0
	public int GetInt(string key, int iDefault = 0) { }

	// RVA: 0x10715D0 Offset: 0x106FBD0 VA: 0x1810715D0
	public float GetFloat(string key, float iDefault = 0) { }

	// RVA: 0x10716E0 Offset: 0x106FCE0 VA: 0x1810716E0
	public Object GetObject(string key) { }

	// RVA: 0x1071520 Offset: 0x106FB20 VA: 0x181071520
	public bool GetBoolean(string key, bool bDefault = False) { }

	// RVA: 0x10714A0 Offset: 0x106FAA0 VA: 0x1810714A0
	public Array GetArray(string key) { }

	// RVA: 0x1072FB0 Offset: 0x10715B0 VA: 0x181072FB0
	public Value get_Item(string key) { }

	// RVA: 0x1072FC0 Offset: 0x10715C0 VA: 0x181072FC0
	public void set_Item(string key, Value value) { }

	// RVA: 0x10712F0 Offset: 0x106F8F0 VA: 0x1810712F0
	public void Add(string key, Value value) { }

	// RVA: 0x1071360 Offset: 0x106F960 VA: 0x181071360
	public void Add(KeyValuePair<string, Value> pair) { }

	// RVA: 0x1071B80 Offset: 0x1070180 VA: 0x181071B80
	public static Object Parse(string jsonString) { }

	// RVA: 0x1072880 Offset: 0x1070E80 VA: 0x181072880
	private static int SkipWhitespace(string str, int pos) { }

	// RVA: 0x1071A70 Offset: 0x1070070 VA: 0x181071A70
	private static string ParseString(string str, ref int startPosition) { }

	// RVA: 0x10718C0 Offset: 0x106FEC0 VA: 0x1810718C0
	private static double ParseNumber(string str, ref int startPosition) { }

	// RVA: 0x1071480 Offset: 0x106FA80 VA: 0x181071480
	private static Object Fail(char expected, int position) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	private static Object Fail(string expected, int position) { }

	// RVA: 0x1072970 Offset: 0x1070F70 VA: 0x181072970 Slot: 3
	public override string ToString() { }

	// RVA: 0x1071580 Offset: 0x106FB80 VA: 0x181071580 Slot: 4
	public IEnumerator<KeyValuePair<string, Value>> GetEnumerator() { }

	// RVA: 0x1072920 Offset: 0x1070F20 VA: 0x181072920 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x10713D0 Offset: 0x106F9D0 VA: 0x1810713D0
	public void Clear() { }

	// RVA: 0x1072800 Offset: 0x1070E00 VA: 0x181072800
	public void Remove(string key) { }

}

private enum Object.ParsingState // TypeDefIndex: 8142
{	// Fields
	public int value__; // 0x0
	public const Object.ParsingState Object = 0;
	public const Object.ParsingState Array = 1;
	public const Object.ParsingState EndObject = 2;
	public const Object.ParsingState EndArray = 3;
	public const Object.ParsingState Key = 4;
	public const Object.ParsingState Value = 5;
	public const Object.ParsingState KeyValueSeparator = 6;
	public const Object.ParsingState ValueSeparator = 7;
	public const Object.ParsingState String = 8;
	public const Object.ParsingState Number = 9;
	public const Object.ParsingState Boolean = 10;
	public const Object.ParsingState Null = 11;

}

