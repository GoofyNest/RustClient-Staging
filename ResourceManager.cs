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

	// RVA: 0xFEE3F0 Offset: 0xFEC9F0 VA: 0x180FEE3F0
	private void Init() { }

	// RVA: 0xFEEF40 Offset: 0xFED540 VA: 0x180FEEF40
	protected void .ctor() { }

	// RVA: 0xFEF2E0 Offset: 0xFED8E0 VA: 0x180FEF2E0
	public void .ctor(string baseName, Assembly assembly) { }

	// RVA: 0xFEF040 Offset: 0xFED640 VA: 0x180FEF040
	public void .ctor(Type resourceSource) { }

	[OnDeserializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFEECC0 Offset: 0xFED2C0 VA: 0x180FEECC0
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFEEAF0 Offset: 0xFED0F0 VA: 0x180FEEAF0
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFEED10 Offset: 0xFED310 VA: 0x180FEED10
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0xFECD40 Offset: 0xFEB340 VA: 0x180FECD40
	private void CommonAssemblyInit() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 4
	public virtual string get_BaseName() { }

	// RVA: 0x5743A0 Offset: 0x5729A0 VA: 0x1805743A0
	protected UltimateResourceFallbackLocation get_FallbackLocation() { }

	// RVA: 0xFED520 Offset: 0xFEBB20 VA: 0x180FED520 Slot: 5
	protected virtual string GetResourceFileName(CultureInfo culture) { }

	// RVA: 0xFED100 Offset: 0xFEB700 VA: 0x180FED100
	internal ResourceSet GetFirstResourceSet(CultureInfo culture) { }

	// RVA: 0xFED650 Offset: 0xFEBC50 VA: 0x180FED650 Slot: 6
	public virtual ResourceSet GetResourceSet(CultureInfo culture, bool createIfNotExists, bool tryParents) { }

	// RVA: 0xFEE490 Offset: 0xFECA90 VA: 0x180FEE490 Slot: 7
	protected virtual ResourceSet InternalGetResourceSet(CultureInfo culture, bool createIfNotExists, bool tryParents) { }

	// RVA: 0xFEE4C0 Offset: 0xFECAC0 VA: 0x180FEE4C0
	private ResourceSet InternalGetResourceSet(CultureInfo requestedCulture, bool createIfNotExists, bool tryParents, ref StackCrawlMark stackMark) { }

	// RVA: 0xFECBC0 Offset: 0xFEB1C0 VA: 0x180FECBC0
	private static void AddResourceSet(Dictionary<string, ResourceSet> localResourceSets, string cultureName, ref ResourceSet rs) { }

	// RVA: 0xFEDA50 Offset: 0xFEC050 VA: 0x180FEDA50
	protected static Version GetSatelliteContractVersion(Assembly a) { }

	// RVA: 0xFECEB0 Offset: 0xFEB4B0 VA: 0x180FECEB0
	internal static bool CompareNames(string asmTypeName1, string typeName2, AssemblyName asmName2) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void SetAppXConfiguration() { }

	// RVA: 0xFEDFA0 Offset: 0xFEC5A0 VA: 0x180FEDFA0 Slot: 8
	public virtual string GetString(string name) { }

	// RVA: 0xFEDFC0 Offset: 0xFEC5C0 VA: 0x180FEDFC0 Slot: 9
	public virtual string GetString(string name, CultureInfo culture) { }

	// RVA: 0xFEED90 Offset: 0xFED390 VA: 0x180FEED90
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

	// RVA: 0xFEC970 Offset: 0xFEAF70 VA: 0x180FEC970
	internal void .ctor(ResourceManager rm) { }

	// RVA: 0x6C81E0 Offset: 0x6C67E0 VA: 0x1806C81E0
	internal string get_ModuleDir() { }

	// RVA: 0xFECA40 Offset: 0xFEB040 VA: 0x180FECA40
	internal Type get_LocationInfo() { }

	// RVA: 0xFECB50 Offset: 0xFEB150 VA: 0x180FECB50
	internal Type get_UserResourceSet() { }

	// RVA: 0xB28DF0 Offset: 0xB273F0 VA: 0x180B28DF0
	internal string get_BaseNameField() { }

	// RVA: 0xFECB10 Offset: 0xFEB110 VA: 0x180FECB10
	internal CultureInfo get_NeutralResourcesCulture() { }

	// RVA: 0xFEC8E0 Offset: 0xFEAEE0 VA: 0x180FEC8E0
	internal string GetResourceFileName(CultureInfo culture) { }

	// RVA: 0xFECA60 Offset: 0xFEB060 VA: 0x180FECA60
	internal bool get_LookedForSatelliteContractVersion() { }

	// RVA: 0xFECB70 Offset: 0xFEB170 VA: 0x180FECB70
	internal void set_LookedForSatelliteContractVersion(bool value) { }

	// RVA: 0xFECB30 Offset: 0xFEB130 VA: 0x180FECB30
	internal Version get_SatelliteContractVersion() { }

	// RVA: 0xFECB90 Offset: 0xFEB190 VA: 0x180FECB90
	internal void set_SatelliteContractVersion(Version value) { }

	// RVA: 0xFEC910 Offset: 0xFEAF10 VA: 0x180FEC910
	internal Version ObtainSatelliteContractVersion(Assembly a) { }

	// RVA: 0xFECA20 Offset: 0xFEB020 VA: 0x180FECA20
	internal UltimateResourceFallbackLocation get_FallbackLoc() { }

	// RVA: 0xFECA00 Offset: 0xFEB000 VA: 0x180FECA00
	internal RuntimeAssembly get_CallingAssembly() { }

	// RVA: 0xFECA80 Offset: 0xFEB080 VA: 0x180FECA80
	internal RuntimeAssembly get_MainAssembly() { }

	// RVA: 0x6C8A20 Offset: 0x6C7020 VA: 0x1806C8A20
	internal string get_BaseName() { }

}

