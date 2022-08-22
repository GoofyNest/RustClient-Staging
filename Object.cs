public class Object // TypeDefIndex: 383
{	// Methods

	// RVA: 0xAE5CA0 Offset: 0xAE42A0 VA: 0x180AE5CA0 Slot: 0
	public virtual bool Equals(object obj) { }

	// RVA: 0x16839D0 Offset: 0x1681FD0 VA: 0x1816839D0
	public static bool Equals(object objA, object objB) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void .ctor() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 1
	protected virtual void Finalize() { }

	// RVA: 0x1683A00 Offset: 0x1682000 VA: 0x181683A00 Slot: 2
	public virtual int GetHashCode() { }

	// RVA: 0x1683A10 Offset: 0x1682010 VA: 0x181683A10
	public Type GetType() { }

	// RVA: 0x1683A20 Offset: 0x1682020 VA: 0x181683A20
	protected object MemberwiseClone() { }

	// RVA: 0x1683A30 Offset: 0x1682030 VA: 0x181683A30 Slot: 3
	public virtual string ToString() { }

	// RVA: 0x1683A00 Offset: 0x1682000 VA: 0x181683A00
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

	// RVA: 0x18F8500 Offset: 0x18F6B00 VA: 0x1818F8500
	public int GetInstanceID() { }

	// RVA: 0x18F84F0 Offset: 0x18F6AF0 VA: 0x1818F84F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18F8110 Offset: 0x18F6710 VA: 0x1818F8110 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x18F9990 Offset: 0x18F7F90 VA: 0x1818F9990
	public static bool op_Implicit(Object exists) { }

	// RVA: 0x18F7E20 Offset: 0x18F6420 VA: 0x1818F7E20
	private static bool CompareBaseObjects(Object lhs, Object rhs) { }

	// RVA: 0x18F95E0 Offset: 0x18F7BE0 VA: 0x1818F95E0
	private static bool IsNativeObjectAlive(Object o) { }

	// RVA: 0x181DCB0 Offset: 0x181C2B0 VA: 0x18181DCB0
	private IntPtr GetCachedPtr() { }

	// RVA: 0x18F97B0 Offset: 0x18F7DB0 VA: 0x1818F97B0
	public string get_name() { }

	// RVA: 0x18F9C10 Offset: 0x18F8210 VA: 0x1818F9C10
	public void set_name(string value) { }

	[TypeInferenceRuleAttribute] // RVA: 0xC5BE0 Offset: 0xC4FE0 VA: 0x1800C5BE0
	// RVA: 0x18F9060 Offset: 0x18F7660 VA: 0x1818F9060
	public static Object Instantiate(Object original, Vector3 position, Quaternion rotation) { }

	[TypeInferenceRuleAttribute] // RVA: 0xC5BE0 Offset: 0xC4FE0 VA: 0x1800C5BE0
	// RVA: 0x18F8860 Offset: 0x18F6E60 VA: 0x1818F8860
	public static Object Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent) { }

	[TypeInferenceRuleAttribute] // RVA: 0xC5BE0 Offset: 0xC4FE0 VA: 0x1800C5BE0
	// RVA: 0x18F86A0 Offset: 0x18F6CA0 VA: 0x1818F86A0
	public static Object Instantiate(Object original) { }

	[TypeInferenceRuleAttribute] // RVA: 0xC5BE0 Offset: 0xC4FE0 VA: 0x1800C5BE0
	// RVA: 0x18F8BE0 Offset: 0x18F71E0 VA: 0x1818F8BE0
	public static Object Instantiate(Object original, Transform parent, bool instantiateInWorldSpace) { }

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B9E40 Offset: 0x15B8440 VA: 0x1815B9E40
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
	|-RVA: 0x15BA180 Offset: 0x15B8780 VA: 0x1815BA180
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
	|-RVA: 0x15BA090 Offset: 0x15B8690 VA: 0x1815BA090
	|-Object.Instantiate<GameObject>
	|-Object.Instantiate<object>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original, Transform parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B9F50 Offset: 0x15B8550 VA: 0x1815B9F50
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
	|-RVA: 0x15B9FD0 Offset: 0x15B85D0 VA: 0x1815B9FD0
	|-Object.Instantiate<object>
	*/

	[NativeMethodAttribute] // RVA: 0xC5F20 Offset: 0xC5320 VA: 0x1800C5F20
	// RVA: 0x18F8010 Offset: 0x18F6610 VA: 0x1818F8010
	public static void Destroy(Object obj, float t) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F8060 Offset: 0x18F6660 VA: 0x1818F8060
	public static void Destroy(Object obj) { }

	[NativeMethodAttribute] // RVA: 0xC6230 Offset: 0xC5630 VA: 0x1800C6230
	// RVA: 0x18F7FC0 Offset: 0x18F65C0 VA: 0x1818F7FC0
	public static void DestroyImmediate(Object obj, bool allowDestroyingAssets) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F7F50 Offset: 0x18F6550 VA: 0x1818F7F50
	public static void DestroyImmediate(Object obj) { }

	[FreeFunctionAttribute] // RVA: 0xC6380 Offset: 0xC5780 VA: 0x1800C6380
	[TypeInferenceRuleAttribute] // RVA: 0xC6380 Offset: 0xC5780 VA: 0x1800C6380
	// RVA: 0x18F84B0 Offset: 0x18F6AB0 VA: 0x1818F84B0
	public static Object[] FindObjectsOfType(Type type) { }

	[FreeFunctionAttribute] // RVA: 0xC6410 Offset: 0xC5810 VA: 0x1800C6410
	// RVA: 0x18F80D0 Offset: 0x18F66D0 VA: 0x1818F80D0
	public static void DontDestroyOnLoad(Object target) { }

	// RVA: 0x18F9770 Offset: 0x18F7D70 VA: 0x1818F9770
	public HideFlags get_hideFlags() { }

	// RVA: 0x18F9BD0 Offset: 0x18F81D0 VA: 0x1818F9BD0
	public void set_hideFlags(HideFlags value) { }

	// RVA: -1 Offset: -1
	public static T[] FindObjectsOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3B890 Offset: 0x1A39E90 VA: 0x181A3B890
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
	|-RVA: 0x15B9D60 Offset: 0x15B8360 VA: 0x1815B9D60
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

	// RVA: 0x18F7DB0 Offset: 0x18F63B0 VA: 0x1818F7DB0
	private static void CheckNullArgument(object arg, string message) { }

	[TypeInferenceRuleAttribute] // RVA: 0xB9C80 Offset: 0xB9080 VA: 0x1800B9C80
	// RVA: 0x18F8420 Offset: 0x18F6A20 VA: 0x1818F8420
	public static Object FindObjectOfType(Type type) { }

	// RVA: 0x18F9680 Offset: 0x18F7C80 VA: 0x1818F9680 Slot: 3
	public override string ToString() { }

	// RVA: 0x18F9820 Offset: 0x18F7E20 VA: 0x1818F9820
	public static bool op_Equality(Object x, Object y) { }

	// RVA: 0x18F9A60 Offset: 0x18F8060 VA: 0x1818F9A60
	public static bool op_Inequality(Object x, Object y) { }

	[NativeMethodAttribute] // RVA: 0xC6530 Offset: 0xC5930 VA: 0x1800C6530
	// RVA: 0x18F8670 Offset: 0x18F6C70 VA: 0x1818F8670
	private static int GetOffsetOfInstanceIDInCPlusPlusObject() { }

	[FreeFunctionAttribute] // RVA: 0xC6590 Offset: 0xC5990 VA: 0x1800C6590
	// RVA: 0x18F93A0 Offset: 0x18F79A0 VA: 0x1818F93A0
	private static Object Internal_CloneSingle(Object data) { }

	[FreeFunctionAttribute] // RVA: 0xC6590 Offset: 0xC5990 VA: 0x1800C6590
	// RVA: 0x18F9340 Offset: 0x18F7940 VA: 0x1818F9340
	private static Object Internal_CloneSingleWithParent(Object data, Transform parent, bool worldPositionStays) { }

	[FreeFunctionAttribute] // RVA: 0xC6720 Offset: 0xC5B20 VA: 0x1800C6720
	// RVA: 0x18F9550 Offset: 0x18F7B50 VA: 0x1818F9550
	private static Object Internal_InstantiateSingle(Object data, Vector3 pos, Quaternion rot) { }

	[FreeFunctionAttribute] // RVA: 0xC6720 Offset: 0xC5B20 VA: 0x1800C6720
	// RVA: 0x18F9450 Offset: 0x18F7A50 VA: 0x1818F9450
	private static Object Internal_InstantiateSingleWithParent(Object data, Transform parent, Vector3 pos, Quaternion rot) { }

	[FreeFunctionAttribute] // RVA: 0xC6A30 Offset: 0xC5E30 VA: 0x1800C6A30
	// RVA: 0x18F96F0 Offset: 0x18F7CF0 VA: 0x1818F96F0
	private static string ToString(Object obj) { }

	[FreeFunctionAttribute] // RVA: 0xC6AF0 Offset: 0xC5EF0 VA: 0x1800C6AF0
	// RVA: 0x18F8630 Offset: 0x18F6C30 VA: 0x1818F8630
	private static string GetName(Object obj) { }

	[FreeFunctionAttribute] // RVA: 0xC6BB0 Offset: 0xC5FB0 VA: 0x1800C6BB0
	// RVA: 0x18F9630 Offset: 0x18F7C30 VA: 0x1818F9630
	private static void SetName(Object obj, string name) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xC6C70 Offset: 0xC6070 VA: 0x1800C6C70
	[FreeFunctionAttribute] // RVA: 0xC6C70 Offset: 0xC6070 VA: 0x1800C6C70
	// RVA: 0x18F83E0 Offset: 0x18F69E0 VA: 0x1818F83E0
	internal static Object FindObjectFromInstanceID(int instanceID) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x18F9730 Offset: 0x18F7D30 VA: 0x1818F9730
	private static void .cctor() { }

	// RVA: 0x18F94F0 Offset: 0x18F7AF0 VA: 0x1818F94F0
	private static Object Internal_InstantiateSingle_Injected(Object data, ref Vector3 pos, ref Quaternion rot) { }

	// RVA: 0x18F93E0 Offset: 0x18F79E0 VA: 0x1818F93E0
	private static Object Internal_InstantiateSingleWithParent_Injected(Object data, Transform parent, ref Vector3 pos, ref Quaternion rot) { }

}

public class Object : IEnumerable<KeyValuePair<string, Value>>, IEnumerable // TypeDefIndex: 8141
{	// Fields
	private readonly IDictionary<string, Value> values; // 0x10

	// Properties
	public Value Item { get; set; }

	// Methods

	// RVA: 0x1073200 Offset: 0x1071800 VA: 0x181073200
	public void .ctor() { }

	// RVA: 0x1072F50 Offset: 0x1071550 VA: 0x181072F50
	public void .ctor(Object other) { }

	// RVA: 0x10716E0 Offset: 0x106FCE0 VA: 0x1810716E0
	public bool ContainsKey(string key) { }

	// RVA: 0x1071AB0 Offset: 0x10700B0 VA: 0x181071AB0
	public Value GetValue(string key) { }

	// RVA: 0x1071A20 Offset: 0x1070020 VA: 0x181071A20
	public string GetString(string key, string strDEFAULT = "") { }

	// RVA: 0x10718D0 Offset: 0x106FED0 VA: 0x1810718D0
	public double GetNumber(string key, double iDefault = 0) { }

	// RVA: 0x10718B0 Offset: 0x106FEB0 VA: 0x1810718B0
	public int GetInt(string key, int iDefault = 0) { }

	// RVA: 0x1071890 Offset: 0x106FE90 VA: 0x181071890
	public float GetFloat(string key, float iDefault = 0) { }

	// RVA: 0x10719A0 Offset: 0x106FFA0 VA: 0x1810719A0
	public Object GetObject(string key) { }

	// RVA: 0x10717E0 Offset: 0x106FDE0 VA: 0x1810717E0
	public bool GetBoolean(string key, bool bDefault = False) { }

	// RVA: 0x1071760 Offset: 0x106FD60 VA: 0x181071760
	public Array GetArray(string key) { }

	// RVA: 0x1073270 Offset: 0x1071870 VA: 0x181073270
	public Value get_Item(string key) { }

	// RVA: 0x1073280 Offset: 0x1071880 VA: 0x181073280
	public void set_Item(string key, Value value) { }

	// RVA: 0x10715B0 Offset: 0x106FBB0 VA: 0x1810715B0
	public void Add(string key, Value value) { }

	// RVA: 0x1071620 Offset: 0x106FC20 VA: 0x181071620
	public void Add(KeyValuePair<string, Value> pair) { }

	// RVA: 0x1071E40 Offset: 0x1070440 VA: 0x181071E40
	public static Object Parse(string jsonString) { }

	// RVA: 0x1072B40 Offset: 0x1071140 VA: 0x181072B40
	private static int SkipWhitespace(string str, int pos) { }

	// RVA: 0x1071D30 Offset: 0x1070330 VA: 0x181071D30
	private static string ParseString(string str, ref int startPosition) { }

	// RVA: 0x1071B80 Offset: 0x1070180 VA: 0x181071B80
	private static double ParseNumber(string str, ref int startPosition) { }

	// RVA: 0x1071740 Offset: 0x106FD40 VA: 0x181071740
	private static Object Fail(char expected, int position) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	private static Object Fail(string expected, int position) { }

	// RVA: 0x1072C30 Offset: 0x1071230 VA: 0x181072C30 Slot: 3
	public override string ToString() { }

	// RVA: 0x1071840 Offset: 0x106FE40 VA: 0x181071840 Slot: 4
	public IEnumerator<KeyValuePair<string, Value>> GetEnumerator() { }

	// RVA: 0x1072BE0 Offset: 0x10711E0 VA: 0x181072BE0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1071690 Offset: 0x106FC90 VA: 0x181071690
	public void Clear() { }

	// RVA: 0x1072AC0 Offset: 0x10710C0 VA: 0x181072AC0
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

