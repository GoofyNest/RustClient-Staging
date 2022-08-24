public class Object // TypeDefIndex: 383
{
	public virtual bool Equals(object obj) { }

	public static bool Equals(object objA, object objB) { }

	[ReliabilityContractAttribute] // RVA: 0x83D60 Offset: 0x83160 VA: 0x180083D60
	public void .ctor() { }

	[ReliabilityContractAttribute] // RVA: 0x76D60 Offset: 0x76160 VA: 0x180076D60
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

	[TypeInferenceRuleAttribute] // RVA: 0xC5CE0 Offset: 0xC50E0 VA: 0x1800C5CE0
	public static Object Instantiate(Object original, Vector3 position, Quaternion rotation) { }

	[TypeInferenceRuleAttribute] // RVA: 0xC5CE0 Offset: 0xC50E0 VA: 0x1800C5CE0
	public static Object Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent) { }

	[TypeInferenceRuleAttribute] // RVA: 0xC5CE0 Offset: 0xC50E0 VA: 0x1800C5CE0
	public static Object Instantiate(Object original) { }

	[TypeInferenceRuleAttribute] // RVA: 0xC5CE0 Offset: 0xC50E0 VA: 0x1800C5CE0
	public static Object Instantiate(Object original, Transform parent, bool instantiateInWorldSpace) { }

	public static T Instantiate<T>(T original) { }
	/* GenericInstMethod :
	|
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
	|-Object.Instantiate<ArcadeEntity>
	|-Object.Instantiate<ArcadeEntityController>
	|-Object.Instantiate<BaseArcadeGame>
	|-Object.Instantiate<GameObject>
	|-Object.Instantiate<object>
	*/

	public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation, Transform parent) { }
	/* GenericInstMethod :
	|
	|-Object.Instantiate<GameObject>
	|-Object.Instantiate<object>
	*/

	public static T Instantiate<T>(T original, Transform parent) { }
	/* GenericInstMethod :
	|
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
	|-Object.Instantiate<object>
	*/

	[NativeMethodAttribute] // RVA: 0xC6020 Offset: 0xC5420 VA: 0x1800C6020
	public static void Destroy(Object obj, float t) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static void Destroy(Object obj) { }

	[NativeMethodAttribute] // RVA: 0xC6270 Offset: 0xC5670 VA: 0x1800C6270
	public static void DestroyImmediate(Object obj, bool allowDestroyingAssets) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static void DestroyImmediate(Object obj) { }

	[TypeInferenceRuleAttribute] // RVA: 0xC6400 Offset: 0xC5800 VA: 0x1800C6400
	[FreeFunctionAttribute] // RVA: 0xC6400 Offset: 0xC5800 VA: 0x1800C6400
	public static Object[] FindObjectsOfType(Type type) { }

	[FreeFunctionAttribute] // RVA: 0xC64F0 Offset: 0xC58F0 VA: 0x1800C64F0
	public static void DontDestroyOnLoad(Object target) { }

	public HideFlags get_hideFlags() { }

	public void set_hideFlags(HideFlags value) { }

	public static T[] FindObjectsOfType<T>() { }
	/* GenericInstMethod :
	|
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

	[TypeInferenceRuleAttribute] // RVA: 0xB9DB0 Offset: 0xB91B0 VA: 0x1800B9DB0
	public static Object FindObjectOfType(Type type) { }

	public override string ToString() { }

	public static bool op_Equality(Object x, Object y) { }

	public static bool op_Inequality(Object x, Object y) { }

	[NativeMethodAttribute] // RVA: 0xC6650 Offset: 0xC5A50 VA: 0x1800C6650
	private static int GetOffsetOfInstanceIDInCPlusPlusObject() { }

	[FreeFunctionAttribute] // RVA: 0xC66D0 Offset: 0xC5AD0 VA: 0x1800C66D0
	private static Object Internal_CloneSingle(Object data) { }

	[FreeFunctionAttribute] // RVA: 0xC66D0 Offset: 0xC5AD0 VA: 0x1800C66D0
	private static Object Internal_CloneSingleWithParent(Object data, Transform parent, bool worldPositionStays) { }

	[FreeFunctionAttribute] // RVA: 0xC6910 Offset: 0xC5D10 VA: 0x1800C6910
	private static Object Internal_InstantiateSingle(Object data, Vector3 pos, Quaternion rot) { }

	[FreeFunctionAttribute] // RVA: 0xC6910 Offset: 0xC5D10 VA: 0x1800C6910
	private static Object Internal_InstantiateSingleWithParent(Object data, Transform parent, Vector3 pos, Quaternion rot) { }

	[FreeFunctionAttribute] // RVA: 0xC6C10 Offset: 0xC6010 VA: 0x1800C6C10
	private static string ToString(Object obj) { }

	[FreeFunctionAttribute] // RVA: 0xC6CC0 Offset: 0xC60C0 VA: 0x1800C6CC0
	private static string GetName(Object obj) { }

	[FreeFunctionAttribute] // RVA: 0xC6D30 Offset: 0xC6130 VA: 0x1800C6D30
	private static void SetName(Object obj, string name) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xC6DD0 Offset: 0xC61D0 VA: 0x1800C6DD0
	[FreeFunctionAttribute] // RVA: 0xC6DD0 Offset: 0xC61D0 VA: 0x1800C6DD0
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

