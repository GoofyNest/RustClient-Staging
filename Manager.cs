public class Manager : IDisposable // TypeDefIndex: 6709
{	// Fields
	private Dictionary<uint, Group> groups; // 0x10
	internal Provider provider; // 0x18

	// Methods

	// RVA: 0x220F4D0 Offset: 0x220DAD0 VA: 0x18220F4D0 Slot: 5
	public virtual void Dispose() { }

	// RVA: 0x220FAF0 Offset: 0x220E0F0 VA: 0x18220FAF0
	public void .ctor(Provider p) { }

	// RVA: 0x220FA70 Offset: 0x220E070 VA: 0x18220FA70
	public Group TryGet(uint ID) { }

	// RVA: 0x220F800 Offset: 0x220DE00 VA: 0x18220F800
	public Group Get(uint ID) { }

	// RVA: 0x220F3C0 Offset: 0x220D9C0 VA: 0x18220F3C0
	public Subscriber CreateSubscriber(Connection connection) { }

	// RVA: 0x220F460 Offset: 0x220DA60 VA: 0x18220F460
	public void DestroySubscriber(ref Subscriber subscriber) { }

	// RVA: 0x220F970 Offset: 0x220DF70 VA: 0x18220F970
	public bool IsInside(Group group, Vector3 vPos) { }

	// RVA: 0x220F630 Offset: 0x220DC30 VA: 0x18220F630
	public Group GetGroup(Vector3 vPos) { }

	// RVA: 0x220F720 Offset: 0x220DD20 VA: 0x18220F720
	public void GetVisibleFromFar(Group center, List<Group> groups) { }

	// RVA: 0x220F790 Offset: 0x220DD90 VA: 0x18220F790
	public void GetVisibleFromNear(Group center, List<Group> groups) { }

}

public static class Manager // TypeDefIndex: 7007
{	// Fields
	private static Dictionary<string, GameObject> Prefabs; // 0x3934

	// Methods

	// RVA: 0xFC40E0 Offset: 0xFC26E0 VA: 0x180FC40E0
	internal static GameObject CreatePrefab(string name) { }

	// RVA: -1 Offset: -1
	internal static T Create<T>(string prefabName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D19B0 Offset: 0x5CFFB0 VA: 0x1805D19B0
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

	// RVA: 0xFC42B0 Offset: 0xFC28B0 VA: 0x180FC42B0
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

	// RVA: 0x22AC420 Offset: 0x22AAA20 VA: 0x1822AC420
	private void .ctor() { }

	// RVA: 0x22AC3C0 Offset: 0x22AA9C0 VA: 0x1822AC3C0
	private static void .cctor() { }

	// RVA: 0x22AC520 Offset: 0x22AAB20 VA: 0x1822AC520
	public static Manager get_PrimaryManager() { }

	// RVA: 0x22AC340 Offset: 0x22AA940 VA: 0x1822AC340
	private static string Normalize(string name) { }

	// RVA: 0x22ABB40 Offset: 0x22AA140 VA: 0x1822ABB40
	public Encoding GetEncoding(int codePage) { }

	// RVA: 0x22AB750 Offset: 0x22A9D50 VA: 0x1822AB750
	public Encoding GetEncoding(string name) { }

	// RVA: 0x22AB340 Offset: 0x22A9940 VA: 0x1822AB340
	public CultureInfo GetCulture(int culture, bool useUserOverride) { }

	// RVA: 0x22AB530 Offset: 0x22A9B30 VA: 0x1822AB530
	public CultureInfo GetCulture(string name, bool useUserOverride) { }

	// RVA: 0x22ABBF0 Offset: 0x22AA1F0 VA: 0x1822ABBF0
	internal object Instantiate(string name) { }

	// RVA: 0x22AC020 Offset: 0x22AA620 VA: 0x1822AC020
	private void LoadClassList() { }

	// RVA: 0x22AC1E0 Offset: 0x22AA7E0 VA: 0x1822AC1E0
	private void LoadInternalClasses() { }

}

