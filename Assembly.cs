public class AssemblyLoadEventArgs : EventArgs // TypeDefIndex: 348
{	// Fields
	private Assembly m_loadedAssembly; // 0x10

	// Methods

	// RVA: 0x155B9C0 Offset: 0x1559FC0 VA: 0x18155B9C0
	public void .ctor(Assembly loadedAssembly) { }

}

public sealed class AssemblyLoadEventHandler : MulticastDelegate // TypeDefIndex: 349
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE45C0 Offset: 0xAE2BC0 VA: 0x180AE45C0 Slot: 12
	public virtual void Invoke(object sender, AssemblyLoadEventArgs args) { }

	// RVA: 0xAE4580 Offset: 0xAE2B80 VA: 0x180AE4580 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, AssemblyLoadEventArgs args, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public enum AssemblyHashAlgorithm // TypeDefIndex: 430
{	// Fields
	public int value__; // 0x0
	public const AssemblyHashAlgorithm None = 0;
	public const AssemblyHashAlgorithm MD5 = 32771;
	public const AssemblyHashAlgorithm SHA1 = 32772;
	public const AssemblyHashAlgorithm SHA256 = 32780;
	public const AssemblyHashAlgorithm SHA384 = 32781;
	public const AssemblyHashAlgorithm SHA512 = 32782;

}

public enum AssemblyVersionCompatibility // TypeDefIndex: 431
{	// Fields
	public int value__; // 0x0
	public const AssemblyVersionCompatibility SameMachine = 1;
	public const AssemblyVersionCompatibility SameProcess = 2;
	public const AssemblyVersionCompatibility SameDomain = 3;

}

public sealed class AssemblyCopyrightAttribute : Attribute // TypeDefIndex: 504
{	// Fields
	private string m_copyright; // 0x10

	// Methods

	// RVA: 0x7EDCE0 Offset: 0x7EC2E0 VA: 0x1807EDCE0
	public void .ctor(string copyright) { }

}

public sealed class AssemblyTrademarkAttribute : Attribute // TypeDefIndex: 505
{	// Fields
	private string m_trademark; // 0x10

	// Methods

	// RVA: 0x7EDCE0 Offset: 0x7EC2E0 VA: 0x1807EDCE0
	public void .ctor(string trademark) { }

}

public sealed class AssemblyProductAttribute : Attribute // TypeDefIndex: 506
{	// Fields
	private string m_product; // 0x10

	// Methods

	// RVA: 0x7EDCE0 Offset: 0x7EC2E0 VA: 0x1807EDCE0
	public void .ctor(string product) { }

}

public sealed class AssemblyCompanyAttribute : Attribute // TypeDefIndex: 507
{	// Fields
	private string m_company; // 0x10

	// Methods

	// RVA: 0x7EDCE0 Offset: 0x7EC2E0 VA: 0x1807EDCE0
	public void .ctor(string company) { }

}

public sealed class AssemblyDescriptionAttribute : Attribute // TypeDefIndex: 508
{	// Fields
	private string m_description; // 0x10

	// Methods

	// RVA: 0x7EDCE0 Offset: 0x7EC2E0 VA: 0x1807EDCE0
	public void .ctor(string description) { }

}

public sealed class AssemblyTitleAttribute : Attribute // TypeDefIndex: 509
{	// Fields
	private string m_title; // 0x10

	// Methods

	// RVA: 0x7EDCE0 Offset: 0x7EC2E0 VA: 0x1807EDCE0
	public void .ctor(string title) { }

}

public sealed class AssemblyConfigurationAttribute : Attribute // TypeDefIndex: 510
{	// Fields
	private string m_configuration; // 0x10

	// Methods

	// RVA: 0x7EDCE0 Offset: 0x7EC2E0 VA: 0x1807EDCE0
	public void .ctor(string configuration) { }

}

public sealed class AssemblyDefaultAliasAttribute : Attribute // TypeDefIndex: 511
{	// Fields
	private string m_defaultAlias; // 0x10

	// Methods

	// RVA: 0x7EDCE0 Offset: 0x7EC2E0 VA: 0x1807EDCE0
	public void .ctor(string defaultAlias) { }

}

public sealed class AssemblyInformationalVersionAttribute : Attribute // TypeDefIndex: 512
{	// Fields
	private string m_informationalVersion; // 0x10

	// Methods

	// RVA: 0x7EDCE0 Offset: 0x7EC2E0 VA: 0x1807EDCE0
	public void .ctor(string informationalVersion) { }

}

public sealed class AssemblyFileVersionAttribute : Attribute // TypeDefIndex: 513
{	// Fields
	private string _version; // 0x10

	// Methods

	// RVA: 0x18C3660 Offset: 0x18C1C60 VA: 0x1818C3660
	public void .ctor(string version) { }

}

public sealed class AssemblyKeyFileAttribute : Attribute // TypeDefIndex: 514
{	// Fields
	private string m_keyFile; // 0x10

	// Methods

	// RVA: 0x7EDCE0 Offset: 0x7EC2E0 VA: 0x1807EDCE0
	public void .ctor(string keyFile) { }

}

public sealed class AssemblyDelaySignAttribute : Attribute // TypeDefIndex: 515
{	// Fields
	private bool m_delaySign; // 0x10

	// Methods

	// RVA: 0xFDCB80 Offset: 0xFDB180 VA: 0x180FDCB80
	public void .ctor(bool delaySign) { }

}

public sealed class AssemblyMetadataAttribute : Attribute // TypeDefIndex: 516
{	// Fields
	private string m_key; // 0x10
	private string m_value; // 0x18

	// Methods

	// RVA: 0x7ED280 Offset: 0x7EB880 VA: 0x1807ED280
	public void .ctor(string key, string value) { }

}

public enum AssemblyNameFlags // TypeDefIndex: 517
{	// Fields
	public int value__; // 0x0
	public const AssemblyNameFlags None = 0;
	public const AssemblyNameFlags PublicKey = 1;
	public const AssemblyNameFlags EnableJITcompileOptimizer = 16384;
	public const AssemblyNameFlags EnableJITcompileTracking = 32768;
	public const AssemblyNameFlags Retargetable = 256;

}

public enum AssemblyContentType // TypeDefIndex: 518
{	// Fields
	public int value__; // 0x0
	public const AssemblyContentType Default = 0;
	public const AssemblyContentType WindowsRuntime = 1;

}

public class Assembly : ICustomAttributeProvider, ISerializable, _Assembly // TypeDefIndex: 555
{	// Fields
	internal IntPtr _mono_assembly; // 0x10
	private Assembly.ResolveEventHolder resolve_event_holder; // 0x18
	private object _evidence; // 0x20
	private object _minimum; // 0x28
	private object _optional; // 0x30
	private object _refuse; // 0x38
	private object _granted; // 0x40
	private object _denied; // 0x48
	private bool fromByteArray; // 0x50
	private string assemblyName; // 0x58

	// Properties
	public virtual string CodeBase { get; }
	public virtual string FullName { get; }
	public virtual string Location { get; }
	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	public virtual bool ReflectionOnly { get; }
	[MonoTODOAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public bool IsFullyTrusted { get; }

	// Methods

	// RVA: 0x18C6290 Offset: 0x18C4890 VA: 0x1818C6290
	protected void .ctor() { }

	// RVA: 0x18C4DB0 Offset: 0x18C33B0 VA: 0x1818C4DB0
	private string get_code_base(bool escaped) { }

	// RVA: 0x18C6360 Offset: 0x18C4960 VA: 0x1818C6360
	private string get_fullname() { }

	// RVA: 0x18C6370 Offset: 0x18C4970 VA: 0x1818C6370
	private string get_location() { }

	// RVA: 0x17C9C90 Offset: 0x17C8290 VA: 0x1817C9C90
	internal static string GetAotId() { }

	// RVA: 0x18C4DB0 Offset: 0x18C33B0 VA: 0x1818C4DB0
	private string GetCodeBase(bool escaped) { }

	// RVA: 0x18C6300 Offset: 0x18C4900 VA: 0x1818C6300 Slot: 8
	public virtual string get_CodeBase() { }

	// RVA: 0xD86B30 Offset: 0xD85130 VA: 0x180D86B30 Slot: 9
	public virtual string get_FullName() { }

	// RVA: 0x18C6310 Offset: 0x18C4910 VA: 0x1818C6310 Slot: 10
	public virtual string get_Location() { }

	// RVA: 0x18C5890 Offset: 0x18C3E90 VA: 0x1818C5890 Slot: 11
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18C6040 Offset: 0x18C4640 VA: 0x1818C6040 Slot: 12
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18C4DC0 Offset: 0x18C33C0 VA: 0x1818C4DC0 Slot: 13
	public virtual object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18C4E30 Offset: 0x18C3430 VA: 0x1818C4E30 Slot: 14
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x17C9C90 Offset: 0x17C8290 VA: 0x1817C9C90
	private object GetFilesInternal(string name, bool getResourceModules) { }

	// RVA: 0x18C4EE0 Offset: 0x18C34E0 VA: 0x1818C4EE0 Slot: 15
	public virtual FileStream GetFile(string name) { }

	// RVA: 0x18C5150 Offset: 0x18C3750 VA: 0x1818C5150
	internal IntPtr GetManifestResourceInternal(string name, out int size, out Module module) { }

	// RVA: 0x18C5170 Offset: 0x18C3770 VA: 0x1818C5170 Slot: 16
	public virtual Stream GetManifestResourceStream(string name) { }

	// RVA: 0x18C55F0 Offset: 0x18C3BF0 VA: 0x1818C55F0
	internal Stream GetManifestResourceStream(Type type, string name, bool skipSecurityCheck, ref StackCrawlMark stackMark) { }

	// RVA: 0x18C54E0 Offset: 0x18C3AE0 VA: 0x1818C54E0
	internal Stream GetManifestResourceStream(string name, ref StackCrawlMark stackMark, bool skipSecurityCheck) { }

	// RVA: 0x18C5BB0 Offset: 0x18C41B0 VA: 0x1818C5BB0
	internal string GetSimpleName() { }

	// RVA: 0x18C58E0 Offset: 0x18C3EE0 VA: 0x1818C58E0
	internal byte[] GetPublicKey() { }

	// RVA: 0x18C5CB0 Offset: 0x18C42B0 VA: 0x1818C5CB0
	internal Version GetVersion() { }

	// RVA: 0x18C5000 Offset: 0x18C3600 VA: 0x1818C5000
	private AssemblyNameFlags GetFlags() { }

	// RVA: 0x18C5CA0 Offset: 0x18C42A0 VA: 0x1818C5CA0 Slot: 17
	internal virtual Type[] GetTypes(bool exportedOnly) { }

	// RVA: 0x18C5C80 Offset: 0x18C4280 VA: 0x1818C5C80 Slot: 18
	public virtual Type[] GetTypes() { }

	// RVA: 0x18C5C20 Offset: 0x18C4220 VA: 0x1818C5C20 Slot: 19
	public virtual Type GetType(string name, bool throwOnError) { }

	// RVA: 0x18C5C50 Offset: 0x18C4250 VA: 0x1818C5C50 Slot: 20
	public virtual Type GetType(string name) { }

	// RVA: 0x18C6030 Offset: 0x18C4630 VA: 0x1818C6030
	internal Type InternalGetType(Module module, string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x18C5820 Offset: 0x18C3E20 VA: 0x1818C5820 Slot: 21
	public virtual AssemblyName GetName(bool copiedName) { }

	// RVA: 0x18C5870 Offset: 0x18C3E70 VA: 0x1818C5870 Slot: 22
	public virtual AssemblyName GetName() { }

	// RVA: 0x18C6260 Offset: 0x18C4860 VA: 0x1818C6260 Slot: 3
	public override string ToString() { }

	// RVA: 0x18C4CF0 Offset: 0x18C32F0 VA: 0x1818C4CF0
	public static Assembly GetAssembly(Type type) { }

	// RVA: 0x18C5CF0 Offset: 0x18C42F0 VA: 0x1818C5CF0
	internal RuntimeAssembly InternalGetSatelliteAssembly(string name, CultureInfo culture, Version version, bool throwOnFileNotFound, ref StackCrawlMark stackMark) { }

	// RVA: 0x18C60D0 Offset: 0x18C46D0 VA: 0x1818C60D0
	private static Assembly LoadFrom(string assemblyFile, bool refonly) { }

	// RVA: 0x18C60C0 Offset: 0x18C46C0 VA: 0x1818C60C0
	public static Assembly LoadFrom(string assemblyFile) { }

	[ObsoleteAttribute] // RVA: 0x9E1A0 Offset: 0x9D5A0 VA: 0x18009E1A0
	// RVA: 0x18C60C0 Offset: 0x18C46C0 VA: 0x1818C60C0
	public static Assembly LoadFrom(string assemblyFile, Evidence securityEvidence) { }

	// RVA: 0x18C6200 Offset: 0x18C4800 VA: 0x1818C6200
	public static Assembly Load(string assemblyString) { }

	// RVA: 0x18C6230 Offset: 0x18C4830 VA: 0x1818C6230
	public static Assembly Load(AssemblyName assemblyRef) { }

	// RVA: 0x18C6380 Offset: 0x18C4980 VA: 0x1818C6380
	private static Assembly load_with_partial_name(string name, Evidence e) { }

	[ObsoleteAttribute] // RVA: 0x9E2C0 Offset: 0x9D6C0 VA: 0x18009E2C0
	// RVA: 0x18C60E0 Offset: 0x18C46E0 VA: 0x1818C60E0
	public static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence) { }

	// RVA: 0x18C6150 Offset: 0x18C4750 VA: 0x1818C6150
	internal static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence, bool oldBehavior) { }

	// RVA: 0x18C57D0 Offset: 0x18C3DD0 VA: 0x1818C57D0 Slot: 23
	internal virtual Module[] GetModulesInternal() { }

	// RVA: 0x18C5160 Offset: 0x18C3760 VA: 0x1818C5160 Slot: 24
	public virtual string[] GetManifestResourceNames() { }

	// RVA: 0x18C4EB0 Offset: 0x18C34B0 VA: 0x1818C4EB0
	public static Assembly GetExecutingAssembly() { }

	// RVA: 0x18C4DA0 Offset: 0x18C33A0 VA: 0x1818C4DA0
	public static Assembly GetCallingAssembly() { }

	// RVA: 0x18C5CE0 Offset: 0x18C42E0 VA: 0x1818C5CE0
	internal static IntPtr InternalGetReferencedAssemblies(Assembly module) { }

	// RVA: 0x18C5910 Offset: 0x18C3F10 VA: 0x1818C5910
	internal static AssemblyName[] GetReferencedAssemblies(Assembly module) { }

	// RVA: 0x18C5030 Offset: 0x18C3630 VA: 0x1818C5030
	private bool GetManifestResourceInfoInternal(string name, ManifestResourceInfo info) { }

	// RVA: 0x18C5040 Offset: 0x18C3640 VA: 0x1818C5040 Slot: 25
	public virtual ManifestResourceInfo GetManifestResourceInfo(string resourceName) { }

	// RVA: 0xD69700 Offset: 0xD67D00 VA: 0x180D69700 Slot: 26
	public virtual bool get_ReflectionOnly() { }

	// RVA: 0xCCE560 Offset: 0xCCCB60 VA: 0x180CCE560 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18C4C00 Offset: 0x18C3200 VA: 0x1818C4C00 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x18C4BB0 Offset: 0x18C31B0 VA: 0x1818C4BB0
	private static Exception CreateNIE() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250
	public bool get_IsFullyTrusted() { }

	// RVA: 0x18C5BE0 Offset: 0x18C41E0 VA: 0x1818C5BE0 Slot: 27
	public virtual Type GetType(string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x18C5790 Offset: 0x18C3D90 VA: 0x1818C5790 Slot: 28
	public virtual Module GetModule(string name) { }

	// RVA: 0x18C5B70 Offset: 0x18C4170 VA: 0x1818C5B70 Slot: 29
	public virtual AssemblyName[] GetReferencedAssemblies() { }

	// RVA: 0x18C57E0 Offset: 0x18C3DE0 VA: 0x1818C57E0 Slot: 30
	public virtual Module[] GetModules(bool getResourceModules) { }

	// RVA: 0x18C6390 Offset: 0x18C4990 VA: 0x1818C6390
	public static bool op_Equality(Assembly left, Assembly right) { }

	// RVA: 0x18C63E0 Offset: 0x18C49E0 VA: 0x1818C63E0
	public static bool op_Inequality(Assembly left, Assembly right) { }

}

internal class Assembly.ResolveEventHolder // TypeDefIndex: 556
{	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

internal class Assembly.UnmanagedMemoryStreamForModule : UnmanagedMemoryStream // TypeDefIndex: 557
{	// Fields
	private Module module; // 0x68

	// Methods

	// RVA: 0x18D7E30 Offset: 0x18D6430 VA: 0x1818D7E30
	public void .ctor(byte* pointer, long length, Module module) { }

	// RVA: 0x18D7DE0 Offset: 0x18D63E0 VA: 0x1818D7DE0 Slot: 17
	protected override void Dispose(bool disposing) { }

}

public sealed class AssemblyName : ICloneable, ISerializable, IDeserializationCallback, _AssemblyName // TypeDefIndex: 558
{	// Fields
	private string name; // 0x10
	private string codebase; // 0x18
	private int major; // 0x20
	private int minor; // 0x24
	private int build; // 0x28
	private int revision; // 0x2C
	private CultureInfo cultureinfo; // 0x30
	private AssemblyNameFlags flags; // 0x38
	private AssemblyHashAlgorithm hashalg; // 0x3C
	private StrongNameKeyPair keypair; // 0x40
	private byte[] publicKey; // 0x48
	private byte[] keyToken; // 0x50
	private AssemblyVersionCompatibility versioncompat; // 0x58
	private Version version; // 0x60
	private ProcessorArchitecture processor_architecture; // 0x68
	private AssemblyContentType contentType; // 0x6C

	// Properties
	public string Name { get; set; }
	public string CodeBase { get; }
	public CultureInfo CultureInfo { get; set; }
	public AssemblyNameFlags Flags { get; set; }
	public string FullName { get; }
	public Version Version { get; set; }
	private bool IsPublicKeyValid { get; }

	// Methods

	// RVA: 0x18C4690 Offset: 0x18C2C90 VA: 0x1818C4690
	public void .ctor() { }

	// RVA: 0x18C4020 Offset: 0x18C2620 VA: 0x1818C4020
	private static bool ParseAssemblyName(IntPtr name, out MonoAssemblyName aname, out bool is_version_definited, out bool is_token_defined) { }

	// RVA: 0x18C4090 Offset: 0x18C2690 VA: 0x1818C4090
	public void .ctor(string assemblyName) { }

	// RVA: 0x18C42D0 Offset: 0x18C28D0 VA: 0x1818C42D0
	internal void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Name() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_Name(string value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_CodeBase() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public CultureInfo get_CultureInfo() { }

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	public void set_CultureInfo(CultureInfo value) { }

	// RVA: 0x6BB940 Offset: 0x6B9F40 VA: 0x1806BB940
	public AssemblyNameFlags get_Flags() { }

	// RVA: 0xC74910 Offset: 0xC72F10 VA: 0x180C74910
	public void set_Flags(AssemblyNameFlags value) { }

	// RVA: 0x18C46B0 Offset: 0x18C2CB0 VA: 0x1818C46B0
	public string get_FullName() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public Version get_Version() { }

	// RVA: 0x18C4B00 Offset: 0x18C3100 VA: 0x1818C4B00
	public void set_Version(Version value) { }

	// RVA: 0x18C4060 Offset: 0x18C2660 VA: 0x1818C4060 Slot: 3
	public override string ToString() { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public byte[] GetPublicKey() { }

	// RVA: 0x18C3E40 Offset: 0x18C2440 VA: 0x1818C3E40
	public byte[] GetPublicKeyToken() { }

	// RVA: 0x18C4A50 Offset: 0x18C3050 VA: 0x1818C4A50
	private bool get_IsPublicKeyValid() { }

	// RVA: 0x18C3F40 Offset: 0x18C2540 VA: 0x1818C3F40
	private byte[] InternalGetPublicKeyToken() { }

	// RVA: 0xD72E30 Offset: 0xD71430 VA: 0x180D72E30
	private static void get_public_token(byte* token, byte* pubkey, int len) { }

	// RVA: 0x18C37F0 Offset: 0x18C1DF0 VA: 0x1818C37F0
	private byte[] ComputePublicKeyToken() { }

	// RVA: 0x18C4030 Offset: 0x18C2630 VA: 0x1818C4030
	public void SetPublicKey(byte[] publicKey) { }

	// RVA: 0x18C3C40 Offset: 0x18C2240 VA: 0x1818C3C40 Slot: 5
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18C36F0 Offset: 0x18C1CF0 VA: 0x1818C36F0 Slot: 4
	public object Clone() { }

	// RVA: 0x18C4010 Offset: 0x18C2610 VA: 0x1818C4010 Slot: 6
	public void OnDeserialization(object sender) { }

	// RVA: 0x18C3C30 Offset: 0x18C2230 VA: 0x1818C3C30
	private static MonoAssemblyName* GetNativeName(IntPtr assembly_ptr) { }

	// RVA: 0x18C3950 Offset: 0x18C1F50 VA: 0x1818C3950
	internal void FillName(MonoAssemblyName* native, string codeBase, bool addVersion, bool addPublickey, bool defaultToken, bool assemblyRef) { }

	// RVA: 0x18C3880 Offset: 0x18C1E80 VA: 0x1818C3880
	internal static AssemblyName Create(Assembly assembly, bool fillCodebase) { }

}

