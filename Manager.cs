public class Manager : IDisposable // TypeDefIndex: 6709
{	// Fields
	private Dictionary<uint, Group> groups; // 0x10
	internal Provider provider; // 0x18

	// Methods

	// RVA: 0x220F5D0 Offset: 0x220DBD0 VA: 0x18220F5D0 Slot: 5
	public virtual void Dispose() { }

	// RVA: 0x220FBF0 Offset: 0x220E1F0 VA: 0x18220FBF0
	public void .ctor(Provider p) { }

	// RVA: 0x220FB70 Offset: 0x220E170 VA: 0x18220FB70
	public Group TryGet(uint ID) { }

	// RVA: 0x220F900 Offset: 0x220DF00 VA: 0x18220F900
	public Group Get(uint ID) { }

	// RVA: 0x220F4C0 Offset: 0x220DAC0 VA: 0x18220F4C0
	public Subscriber CreateSubscriber(Connection connection) { }

	// RVA: 0x220F560 Offset: 0x220DB60 VA: 0x18220F560
	public void DestroySubscriber(ref Subscriber subscriber) { }

	// RVA: 0x220FA70 Offset: 0x220E070 VA: 0x18220FA70
	public bool IsInside(Group group, Vector3 vPos) { }

	// RVA: 0x220F730 Offset: 0x220DD30 VA: 0x18220F730
	public Group GetGroup(Vector3 vPos) { }

	// RVA: 0x220F820 Offset: 0x220DE20 VA: 0x18220F820
	public void GetVisibleFromFar(Group center, List<Group> groups) { }

	// RVA: 0x220F890 Offset: 0x220DE90 VA: 0x18220F890
	public void GetVisibleFromNear(Group center, List<Group> groups) { }

}

public static class Manager // TypeDefIndex: 7007
{	// Fields
	private static Dictionary<string, GameObject> Prefabs; // 0x3934

	// Methods

	// RVA: 0xFC43A0 Offset: 0xFC29A0 VA: 0x180FC43A0
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

	// RVA: 0xFC4570 Offset: 0xFC2B70 VA: 0x180FC4570
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

	// RVA: 0x22AC520 Offset: 0x22AAB20 VA: 0x1822AC520
	private void .ctor() { }

	// RVA: 0x22AC4C0 Offset: 0x22AAAC0 VA: 0x1822AC4C0
	private static void .cctor() { }

	// RVA: 0x22AC620 Offset: 0x22AAC20 VA: 0x1822AC620
	public static Manager get_PrimaryManager() { }

	// RVA: 0x22AC440 Offset: 0x22AAA40 VA: 0x1822AC440
	private static string Normalize(string name) { }

	// RVA: 0x22ABC40 Offset: 0x22AA240 VA: 0x1822ABC40
	public Encoding GetEncoding(int codePage) { }

	// RVA: 0x22AB850 Offset: 0x22A9E50 VA: 0x1822AB850
	public Encoding GetEncoding(string name) { }

	// RVA: 0x22AB440 Offset: 0x22A9A40 VA: 0x1822AB440
	public CultureInfo GetCulture(int culture, bool useUserOverride) { }

	// RVA: 0x22AB630 Offset: 0x22A9C30 VA: 0x1822AB630
	public CultureInfo GetCulture(string name, bool useUserOverride) { }

	// RVA: 0x22ABCF0 Offset: 0x22AA2F0 VA: 0x1822ABCF0
	internal object Instantiate(string name) { }

	// RVA: 0x22AC120 Offset: 0x22AA720 VA: 0x1822AC120
	private void LoadClassList() { }

	// RVA: 0x22AC2E0 Offset: 0x22AA8E0 VA: 0x1822AC2E0
	private void LoadInternalClasses() { }

}

