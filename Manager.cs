public class Manager : IDisposable // TypeDefIndex: 6709
{	// Fields
	private Dictionary<uint, Group> groups; // 0x10
	internal Provider provider; // 0x18

	// Methods

	// RVA: 0x220FDF0 Offset: 0x220E3F0 VA: 0x18220FDF0 Slot: 5
	public virtual void Dispose() { }

	// RVA: 0x2210410 Offset: 0x220EA10 VA: 0x182210410
	public void .ctor(Provider p) { }

	// RVA: 0x2210390 Offset: 0x220E990 VA: 0x182210390
	public Group TryGet(uint ID) { }

	// RVA: 0x2210120 Offset: 0x220E720 VA: 0x182210120
	public Group Get(uint ID) { }

	// RVA: 0x220FCE0 Offset: 0x220E2E0 VA: 0x18220FCE0
	public Subscriber CreateSubscriber(Connection connection) { }

	// RVA: 0x220FD80 Offset: 0x220E380 VA: 0x18220FD80
	public void DestroySubscriber(ref Subscriber subscriber) { }

	// RVA: 0x2210290 Offset: 0x220E890 VA: 0x182210290
	public bool IsInside(Group group, Vector3 vPos) { }

	// RVA: 0x220FF50 Offset: 0x220E550 VA: 0x18220FF50
	public Group GetGroup(Vector3 vPos) { }

	// RVA: 0x2210040 Offset: 0x220E640 VA: 0x182210040
	public void GetVisibleFromFar(Group center, List<Group> groups) { }

	// RVA: 0x22100B0 Offset: 0x220E6B0 VA: 0x1822100B0
	public void GetVisibleFromNear(Group center, List<Group> groups) { }

}

public static class Manager // TypeDefIndex: 7007
{	// Fields
	private static Dictionary<string, GameObject> Prefabs; // 0x3740

	// Methods

	// RVA: 0xFC4E40 Offset: 0xFC3440 VA: 0x180FC4E40
	internal static GameObject CreatePrefab(string name) { }

	// RVA: -1 Offset: -1
	internal static T Create<T>(string prefabName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1940 Offset: 0x5CFF40 VA: 0x1805D1940
	|-Manager.Create<Blocker>
	|-Manager.Create<Dropdown>
	|-Manager.Create<Menu>
	|-Manager.Create<RustButton>
	|-Manager.Create<RustButtonGroup>
	|-Manager.Create<RustIcon>
	|-Manager.Create<RustInput>
	|-Manager.Create<RustLayout>
	|-Manager.Create<RustOption>
	|-Manager.Create<RustSlider>
	|-Manager.Create<RustText>
	|-Manager.Create<RustToggle>
	|-Manager.Create<RustWrapper>
	|-Manager.Create<TabControl>
	|-Manager.Create<Video>
	|-Manager.Create<object>
	|-Manager.Create<LayoutElement>
	*/

	// RVA: 0xFC5010 Offset: 0xFC3610 VA: 0x180FC5010
	private static void .cctor() { }

}

public class Manager // TypeDefIndex: 7372
{	// Fields
	private const string hex = "0123456789abcdef";
	private static Manager manager; // 0x0
	private Hashtable handlers; // 0x10
	private Hashtable active; // 0x18
	private Hashtable assemblies; // 0x20
	private static readonly object lockobj; // 0x8

	// Properties
	public static Manager PrimaryManager { get; }

	// Methods

	// RVA: 0x22ACD40 Offset: 0x22AB340 VA: 0x1822ACD40
	private void .ctor() { }

	// RVA: 0x22ACCE0 Offset: 0x22AB2E0 VA: 0x1822ACCE0
	private static void .cctor() { }

	// RVA: 0x22ACE40 Offset: 0x22AB440 VA: 0x1822ACE40
	public static Manager get_PrimaryManager() { }

	// RVA: 0x22ACC60 Offset: 0x22AB260 VA: 0x1822ACC60
	private static string Normalize(string name) { }

	// RVA: 0x22AC460 Offset: 0x22AAA60 VA: 0x1822AC460
	public Encoding GetEncoding(int codePage) { }

	// RVA: 0x22AC070 Offset: 0x22AA670 VA: 0x1822AC070
	public Encoding GetEncoding(string name) { }

	// RVA: 0x22ABC60 Offset: 0x22AA260 VA: 0x1822ABC60
	public CultureInfo GetCulture(int culture, bool useUserOverride) { }

	// RVA: 0x22ABE50 Offset: 0x22AA450 VA: 0x1822ABE50
	public CultureInfo GetCulture(string name, bool useUserOverride) { }

	// RVA: 0x22AC510 Offset: 0x22AAB10 VA: 0x1822AC510
	internal object Instantiate(string name) { }

	// RVA: 0x22AC940 Offset: 0x22AAF40 VA: 0x1822AC940
	private void LoadClassList() { }

	// RVA: 0x22ACB00 Offset: 0x22AB100 VA: 0x1822ACB00
	private void LoadInternalClasses() { }

}

