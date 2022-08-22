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

	// RVA: 0xFEE130 Offset: 0xFEC730 VA: 0x180FEE130
	private void Init() { }

	// RVA: 0xFEEC80 Offset: 0xFED280 VA: 0x180FEEC80
	protected void .ctor() { }

	// RVA: 0xFEF020 Offset: 0xFED620 VA: 0x180FEF020
	public void .ctor(string baseName, Assembly assembly) { }

	// RVA: 0xFEED80 Offset: 0xFED380 VA: 0x180FEED80
	public void .ctor(Type resourceSource) { }

	[OnDeserializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFEEA00 Offset: 0xFED000 VA: 0x180FEEA00
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFEE830 Offset: 0xFECE30 VA: 0x180FEE830
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFEEA50 Offset: 0xFED050 VA: 0x180FEEA50
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0xFECA80 Offset: 0xFEB080 VA: 0x180FECA80
	private void CommonAssemblyInit() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 4
	public virtual string get_BaseName() { }

	// RVA: 0x5743A0 Offset: 0x5729A0 VA: 0x1805743A0
	protected UltimateResourceFallbackLocation get_FallbackLocation() { }

	// RVA: 0xFED260 Offset: 0xFEB860 VA: 0x180FED260 Slot: 5
	protected virtual string GetResourceFileName(CultureInfo culture) { }

	// RVA: 0xFECE40 Offset: 0xFEB440 VA: 0x180FECE40
	internal ResourceSet GetFirstResourceSet(CultureInfo culture) { }

	// RVA: 0xFED390 Offset: 0xFEB990 VA: 0x180FED390 Slot: 6
	public virtual ResourceSet GetResourceSet(CultureInfo culture, bool createIfNotExists, bool tryParents) { }

	// RVA: 0xFEE1D0 Offset: 0xFEC7D0 VA: 0x180FEE1D0 Slot: 7
	protected virtual ResourceSet InternalGetResourceSet(CultureInfo culture, bool createIfNotExists, bool tryParents) { }

	// RVA: 0xFEE200 Offset: 0xFEC800 VA: 0x180FEE200
	private ResourceSet InternalGetResourceSet(CultureInfo requestedCulture, bool createIfNotExists, bool tryParents, ref StackCrawlMark stackMark) { }

	// RVA: 0xFEC900 Offset: 0xFEAF00 VA: 0x180FEC900
	private static void AddResourceSet(Dictionary<string, ResourceSet> localResourceSets, string cultureName, ref ResourceSet rs) { }

	// RVA: 0xFED790 Offset: 0xFEBD90 VA: 0x180FED790
	protected static Version GetSatelliteContractVersion(Assembly a) { }

	// RVA: 0xFECBF0 Offset: 0xFEB1F0 VA: 0x180FECBF0
	internal static bool CompareNames(string asmTypeName1, string typeName2, AssemblyName asmName2) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void SetAppXConfiguration() { }

	// RVA: 0xFEDCE0 Offset: 0xFEC2E0 VA: 0x180FEDCE0 Slot: 8
	public virtual string GetString(string name) { }

	// RVA: 0xFEDD00 Offset: 0xFEC300 VA: 0x180FEDD00 Slot: 9
	public virtual string GetString(string name, CultureInfo culture) { }

	// RVA: 0xFEEAD0 Offset: 0xFED0D0 VA: 0x180FEEAD0
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

	// RVA: 0xFEC6B0 Offset: 0xFEACB0 VA: 0x180FEC6B0
	internal void .ctor(ResourceManager rm) { }

	// RVA: 0x6C80D0 Offset: 0x6C66D0 VA: 0x1806C80D0
	internal string get_ModuleDir() { }

	// RVA: 0xFEC780 Offset: 0xFEAD80 VA: 0x180FEC780
	internal Type get_LocationInfo() { }

	// RVA: 0xFEC890 Offset: 0xFEAE90 VA: 0x180FEC890
	internal Type get_UserResourceSet() { }

	// RVA: 0xB28B30 Offset: 0xB27130 VA: 0x180B28B30
	internal string get_BaseNameField() { }

	// RVA: 0xFEC850 Offset: 0xFEAE50 VA: 0x180FEC850
	internal CultureInfo get_NeutralResourcesCulture() { }

	// RVA: 0xFEC620 Offset: 0xFEAC20 VA: 0x180FEC620
	internal string GetResourceFileName(CultureInfo culture) { }

	// RVA: 0xFEC7A0 Offset: 0xFEADA0 VA: 0x180FEC7A0
	internal bool get_LookedForSatelliteContractVersion() { }

	// RVA: 0xFEC8B0 Offset: 0xFEAEB0 VA: 0x180FEC8B0
	internal void set_LookedForSatelliteContractVersion(bool value) { }

	// RVA: 0xFEC870 Offset: 0xFEAE70 VA: 0x180FEC870
	internal Version get_SatelliteContractVersion() { }

	// RVA: 0xFEC8D0 Offset: 0xFEAED0 VA: 0x180FEC8D0
	internal void set_SatelliteContractVersion(Version value) { }

	// RVA: 0xFEC650 Offset: 0xFEAC50 VA: 0x180FEC650
	internal Version ObtainSatelliteContractVersion(Assembly a) { }

	// RVA: 0xFEC760 Offset: 0xFEAD60 VA: 0x180FEC760
	internal UltimateResourceFallbackLocation get_FallbackLoc() { }

	// RVA: 0xFEC740 Offset: 0xFEAD40 VA: 0x180FEC740
	internal RuntimeAssembly get_CallingAssembly() { }

	// RVA: 0xFEC7C0 Offset: 0xFEADC0 VA: 0x180FEC7C0
	internal RuntimeAssembly get_MainAssembly() { }

	// RVA: 0x6C8910 Offset: 0x6C6F10 VA: 0x1806C8910
	internal string get_BaseName() { }

}

