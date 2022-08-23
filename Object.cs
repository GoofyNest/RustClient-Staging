public class Object // TypeDefIndex: 383
{
	public virtual bool Equals(object obj) { }

	public static bool Equals(object objA, object objB) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	public void .ctor() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	protected virtual void Finalize() { }

	public virtual int GetHashCode() { }

	public Type GetType() { }

	protected object MemberwiseClone() { }

	public virtual string ToString() { }

	internal static int InternalGetHashCode(object o) { }

	private void FieldGetter(string typeName, string fieldName, ref object val) { }

	private void FieldSetter(string typeName, string fieldName, object val) { }

}

public class Object // TypeDefIndex: 3535
{	private IntPtr m_CachedPtr; // 0x10
	internal static int OffsetOfInstanceIDInCPlusPlusObject; // 0x0
	private const string objectIsNullMessage = "The Object you want to instantiate is null.";
	private const string cloneDestroyedMessage = "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.";

	public string name { get; set; }
	public HideFlags hideFlags { get; set; }


	public int GetInstanceID() { }

	public override int GetHashCode() { }

	public override bool Equals(object other) { }

	public static bool op_Implicit(Object exists) { }

	private static bool CompareBaseObjects(Object lhs, Object rhs) { }

	private static bool IsNativeObjectAlive(Object o) { }

	private IntPtr GetCachedPtr() { }

	public string get_name() { }

	public void set_name(string value) { }

	[TypeInferenceRuleAttribute] // RVA: 0xC5BE0 Offset: 0xC4FE0 VA: 0x1800C5BE0
	public static Object Instantiate(Object original, Vector3 position, Quaternion rotation) { }

	[TypeInferenceRuleAttribute] // RVA: 0xC5BE0 Offset: 0xC4FE0 VA: 0x1800C5BE0
	public static Object Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent) { }

	[TypeInferenceRuleAttribute] // RVA: 0xC5BE0 Offset: 0xC4FE0 VA: 0x1800C5BE0
	public static Object Instantiate(Object original) { }

	[TypeInferenceRuleAttribute] // RVA: 0xC5BE0 Offset: 0xC4FE0 VA: 0x1800C5BE0
	public static Object Instantiate(Object original, Transform parent, bool instantiateInWorldSpace) { }

	public static T Instantiate<T>(T original) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B9010 Offset: 0x15B7610 VA: 0x1815B9010
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

	public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B9350 Offset: 0x15B7950 VA: 0x1815B9350
	|-Object.Instantiate<ArcadeEntity>
	|-Object.Instantiate<ArcadeEntityController>
	|-Object.Instantiate<BaseArcadeGame>
	|-Object.Instantiate<GameObject>
	|-Object.Instantiate<object>
	*/

	public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation, Transform parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B9260 Offset: 0x15B7860 VA: 0x1815B9260
	|-Object.Instantiate<GameObject>
	|-Object.Instantiate<object>
	*/

	public static T Instantiate<T>(T original, Transform parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B9120 Offset: 0x15B7720 VA: 0x1815B9120
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

	public static T Instantiate<T>(T original, Transform parent, bool worldPositionStays) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B91A0 Offset: 0x15B77A0 VA: 0x1815B91A0
	|-Object.Instantiate<object>
	*/

	[NativeMethodAttribute] // RVA: 0xC5F20 Offset: 0xC5320 VA: 0x1800C5F20
	public static void Destroy(Object obj, float t) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void Destroy(Object obj) { }

	[NativeMethodAttribute] // RVA: 0xC6230 Offset: 0xC5630 VA: 0x1800C6230
	public static void DestroyImmediate(Object obj, bool allowDestroyingAssets) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void DestroyImmediate(Object obj) { }

	[FreeFunctionAttribute] // RVA: 0xC6380 Offset: 0xC5780 VA: 0x1800C6380
	[TypeInferenceRuleAttribute] // RVA: 0xC6380 Offset: 0xC5780 VA: 0x1800C6380
	public static Object[] FindObjectsOfType(Type type) { }

	[FreeFunctionAttribute] // RVA: 0xC6410 Offset: 0xC5810 VA: 0x1800C6410
	public static void DontDestroyOnLoad(Object target) { }

	public HideFlags get_hideFlags() { }

	public void set_hideFlags(HideFlags value) { }

	public static T[] FindObjectsOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3B0B0 Offset: 0x1A396B0 VA: 0x181A3B0B0
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

	public static T FindObjectOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B8F30 Offset: 0x15B7530 VA: 0x1815B8F30
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

	private static void CheckNullArgument(object arg, string message) { }

	[TypeInferenceRuleAttribute] // RVA: 0xB9C80 Offset: 0xB9080 VA: 0x1800B9C80
	public static Object FindObjectOfType(Type type) { }

	public override string ToString() { }

	public static bool op_Equality(Object x, Object y) { }

	public static bool op_Inequality(Object x, Object y) { }

	[NativeMethodAttribute] // RVA: 0xC6530 Offset: 0xC5930 VA: 0x1800C6530
	private static int GetOffsetOfInstanceIDInCPlusPlusObject() { }

	[FreeFunctionAttribute] // RVA: 0xC6590 Offset: 0xC5990 VA: 0x1800C6590
	private static Object Internal_CloneSingle(Object data) { }

	[FreeFunctionAttribute] // RVA: 0xC6590 Offset: 0xC5990 VA: 0x1800C6590
	private static Object Internal_CloneSingleWithParent(Object data, Transform parent, bool worldPositionStays) { }

	[FreeFunctionAttribute] // RVA: 0xC6720 Offset: 0xC5B20 VA: 0x1800C6720
	private static Object Internal_InstantiateSingle(Object data, Vector3 pos, Quaternion rot) { }

	[FreeFunctionAttribute] // RVA: 0xC6720 Offset: 0xC5B20 VA: 0x1800C6720
	private static Object Internal_InstantiateSingleWithParent(Object data, Transform parent, Vector3 pos, Quaternion rot) { }

	[FreeFunctionAttribute] // RVA: 0xC6A30 Offset: 0xC5E30 VA: 0x1800C6A30
	private static string ToString(Object obj) { }

	[FreeFunctionAttribute] // RVA: 0xC6AF0 Offset: 0xC5EF0 VA: 0x1800C6AF0
	private static string GetName(Object obj) { }

	[FreeFunctionAttribute] // RVA: 0xC6BB0 Offset: 0xC5FB0 VA: 0x1800C6BB0
	private static void SetName(Object obj, string name) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xC6C70 Offset: 0xC6070 VA: 0x1800C6C70
	[FreeFunctionAttribute] // RVA: 0xC6C70 Offset: 0xC6070 VA: 0x1800C6C70
	internal static Object FindObjectFromInstanceID(int instanceID) { }

	public void .ctor() { }

	private static void .cctor() { }

	private static Object Internal_InstantiateSingle_Injected(Object data, ref Vector3 pos, ref Quaternion rot) { }

	private static Object Internal_InstantiateSingleWithParent_Injected(Object data, Transform parent, ref Vector3 pos, ref Quaternion rot) { }

}

public class Object : IEnumerable<KeyValuePair<string, Value>>, IEnumerable // TypeDefIndex: 8141
{	private readonly IDictionary<string, Value> values; // 0x10

	public Value Item { get; set; }


	public void .ctor() { }

	public void .ctor(Object other) { }

	public bool ContainsKey(string key) { }

	public Value GetValue(string key) { }

	public string GetString(string key, string strDEFAULT = "") { }

	public double GetNumber(string key, double iDefault = 0) { }

	public int GetInt(string key, int iDefault = 0) { }

	public float GetFloat(string key, float iDefault = 0) { }

	public Object GetObject(string key) { }

	public bool GetBoolean(string key, bool bDefault = False) { }

	public Array GetArray(string key) { }

	public Value get_Item(string key) { }

	public void set_Item(string key, Value value) { }

	public void Add(string key, Value value) { }

	public void Add(KeyValuePair<string, Value> pair) { }

	public static Object Parse(string jsonString) { }

	private static int SkipWhitespace(string str, int pos) { }

	private static string ParseString(string str, ref int startPosition) { }

	private static double ParseNumber(string str, ref int startPosition) { }

	private static Object Fail(char expected, int position) { }

	private static Object Fail(string expected, int position) { }

	public override string ToString() { }

	public IEnumerator<KeyValuePair<string, Value>> GetEnumerator() { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public void Clear() { }

	public void Remove(string key) { }

}

private enum Object.ParsingState // TypeDefIndex: 8142
{	public int value__; // 0x0
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

