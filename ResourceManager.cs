public class ResourceManager // TypeDefIndex: 491
{	// Fields
	protected string BaseNameField; // 0x10
	[ObsoleteAttribute] // RVA: 0x964B0 Offset: 0x958B0 VA: 0x1800964B0
	protected Hashtable ResourceSets; // 0x18
	private Dictionary<string, ResourceSet> _resourceSets; // 0x20
	private string moduleDir; // 0x28
	protected Assembly MainAssembly; // 0x30
	private Type _locationInfo; // 0x38
	private Type _userResourceSet; // 0x40
	private CultureInfo _neutralResourcesCulture; // 0x48
	private ResourceManager.CultureNameResourceSetPair _lastUsedResourceCache; // 0x50
	private bool _ignoreCase; // 0x58
	private bool UseManifest; // 0x59
	[OptionalFieldAttribute] // RVA: 0x96550 Offset: 0x95950 VA: 0x180096550
	private bool UseSatelliteAssem; // 0x5A
	[OptionalFieldAttribute] // RVA: 0x7B570 Offset: 0x7A970 VA: 0x18007B570
	private UltimateResourceFallbackLocation _fallbackLoc; // 0x5C
	[OptionalFieldAttribute] // RVA: 0x7B570 Offset: 0x7A970 VA: 0x18007B570
	private Version _satelliteContractVersion; // 0x60
	[OptionalFieldAttribute] // RVA: 0x7B570 Offset: 0x7A970 VA: 0x18007B570
	private bool _lookedForSatelliteContractVersion; // 0x68
	[OptionalFieldAttribute] // RVA: 0x96550 Offset: 0x95950 VA: 0x180096550
	private Assembly _callingAssembly; // 0x70
	[OptionalFieldAttribute] // RVA: 0x7B710 Offset: 0x7AB10 VA: 0x18007B710
	private RuntimeAssembly m_callingAssembly; // 0x78
	private IResourceGroveler resourceGroveler; // 0x80
	public static readonly int MagicNumber; // 0x0
	public static readonly int HeaderVersionNumber; // 0x4
	private static readonly Type _minResourceSet; // 0x8
	internal static readonly string ResReaderTypeName; // 0x10
	internal static readonly string ResSetTypeName; // 0x18
	internal static readonly string MscorlibName; // 0x20
	internal static readonly int DEBUG; // 0x28

	// Properties
	public virtual string BaseName { get; }
	protected UltimateResourceFallbackLocation FallbackLocation { get; }

	// Methods

	// RVA: 0xFEEE90 Offset: 0xFED490 VA: 0x180FEEE90
	private void Init() { }

	// RVA: 0xFEF9E0 Offset: 0xFEDFE0 VA: 0x180FEF9E0
	protected void .ctor() { }

	// RVA: 0xFEFD80 Offset: 0xFEE380 VA: 0x180FEFD80
	public void .ctor(string baseName, Assembly assembly) { }

	// RVA: 0xFEFAE0 Offset: 0xFEE0E0 VA: 0x180FEFAE0
	public void .ctor(Type resourceSource) { }

	[OnDeserializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFEF760 Offset: 0xFEDD60 VA: 0x180FEF760
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFEF590 Offset: 0xFEDB90 VA: 0x180FEF590
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFEF7B0 Offset: 0xFEDDB0 VA: 0x180FEF7B0
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0xFED7E0 Offset: 0xFEBDE0 VA: 0x180FED7E0
	private void CommonAssemblyInit() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 4
	public virtual string get_BaseName() { }

	// RVA: 0x574330 Offset: 0x572930 VA: 0x180574330
	protected UltimateResourceFallbackLocation get_FallbackLocation() { }

	// RVA: 0xFEDFC0 Offset: 0xFEC5C0 VA: 0x180FEDFC0 Slot: 5
	protected virtual string GetResourceFileName(CultureInfo culture) { }

	// RVA: 0xFEDBA0 Offset: 0xFEC1A0 VA: 0x180FEDBA0
	internal ResourceSet GetFirstResourceSet(CultureInfo culture) { }

	// RVA: 0xFEE0F0 Offset: 0xFEC6F0 VA: 0x180FEE0F0 Slot: 6
	public virtual ResourceSet GetResourceSet(CultureInfo culture, bool createIfNotExists, bool tryParents) { }

	// RVA: 0xFEEF30 Offset: 0xFED530 VA: 0x180FEEF30 Slot: 7
	protected virtual ResourceSet InternalGetResourceSet(CultureInfo culture, bool createIfNotExists, bool tryParents) { }

	// RVA: 0xFEEF60 Offset: 0xFED560 VA: 0x180FEEF60
	private ResourceSet InternalGetResourceSet(CultureInfo requestedCulture, bool createIfNotExists, bool tryParents, ref StackCrawlMark stackMark) { }

	// RVA: 0xFED660 Offset: 0xFEBC60 VA: 0x180FED660
	private static void AddResourceSet(Dictionary<string, ResourceSet> localResourceSets, string cultureName, ref ResourceSet rs) { }

	// RVA: 0xFEE4F0 Offset: 0xFECAF0 VA: 0x180FEE4F0
	protected static Version GetSatelliteContractVersion(Assembly a) { }

	// RVA: 0xFED950 Offset: 0xFEBF50 VA: 0x180FED950
	internal static bool CompareNames(string asmTypeName1, string typeName2, AssemblyName asmName2) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void SetAppXConfiguration() { }

	// RVA: 0xFEEA40 Offset: 0xFED040 VA: 0x180FEEA40 Slot: 8
	public virtual string GetString(string name) { }

	// RVA: 0xFEEA60 Offset: 0xFED060 VA: 0x180FEEA60 Slot: 9
	public virtual string GetString(string name, CultureInfo culture) { }

	// RVA: 0xFEF830 Offset: 0xFEDE30 VA: 0x180FEF830
	private static void .cctor() { }

}

internal class ResourceManager.CultureNameResourceSetPair // TypeDefIndex: 492
{	// Fields
	public string lastCultureName; // 0x10
	public ResourceSet lastResourceSet; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

internal class ResourceManager.ResourceManagerMediator // TypeDefIndex: 493
{	// Fields
	private ResourceManager _rm; // 0x10

	// Properties
	internal string ModuleDir { get; }
	internal Type LocationInfo { get; }
	internal Type UserResourceSet { get; }
	internal string BaseNameField { get; }
	internal CultureInfo NeutralResourcesCulture { get; }
	internal bool LookedForSatelliteContractVersion { get; set; }
	internal Version SatelliteContractVersion { get; set; }
	internal UltimateResourceFallbackLocation FallbackLoc { get; }
	internal RuntimeAssembly CallingAssembly { get; }
	internal RuntimeAssembly MainAssembly { get; }
	internal string BaseName { get; }

	// Methods

	// RVA: 0xFED410 Offset: 0xFEBA10 VA: 0x180FED410
	internal void .ctor(ResourceManager rm) { }

	// RVA: 0x6C8170 Offset: 0x6C6770 VA: 0x1806C8170
	internal string get_ModuleDir() { }

	// RVA: 0xFED4E0 Offset: 0xFEBAE0 VA: 0x180FED4E0
	internal Type get_LocationInfo() { }

	// RVA: 0xFED5F0 Offset: 0xFEBBF0 VA: 0x180FED5F0
	internal Type get_UserResourceSet() { }

	// RVA: 0xB292C0 Offset: 0xB278C0 VA: 0x180B292C0
	internal string get_BaseNameField() { }

	// RVA: 0xFED5B0 Offset: 0xFEBBB0 VA: 0x180FED5B0
	internal CultureInfo get_NeutralResourcesCulture() { }

	// RVA: 0xFED380 Offset: 0xFEB980 VA: 0x180FED380
	internal string GetResourceFileName(CultureInfo culture) { }

	// RVA: 0xFED500 Offset: 0xFEBB00 VA: 0x180FED500
	internal bool get_LookedForSatelliteContractVersion() { }

	// RVA: 0xFED610 Offset: 0xFEBC10 VA: 0x180FED610
	internal void set_LookedForSatelliteContractVersion(bool value) { }

	// RVA: 0xFED5D0 Offset: 0xFEBBD0 VA: 0x180FED5D0
	internal Version get_SatelliteContractVersion() { }

	// RVA: 0xFED630 Offset: 0xFEBC30 VA: 0x180FED630
	internal void set_SatelliteContractVersion(Version value) { }

	// RVA: 0xFED3B0 Offset: 0xFEB9B0 VA: 0x180FED3B0
	internal Version ObtainSatelliteContractVersion(Assembly a) { }

	// RVA: 0xFED4C0 Offset: 0xFEBAC0 VA: 0x180FED4C0
	internal UltimateResourceFallbackLocation get_FallbackLoc() { }

	// RVA: 0xFED4A0 Offset: 0xFEBAA0 VA: 0x180FED4A0
	internal RuntimeAssembly get_CallingAssembly() { }

	// RVA: 0xFED520 Offset: 0xFEBB20 VA: 0x180FED520
	internal RuntimeAssembly get_MainAssembly() { }

	// RVA: 0x6C89B0 Offset: 0x6C6FB0 VA: 0x1806C89B0
	internal string get_BaseName() { }

}

