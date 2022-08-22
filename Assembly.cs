public class AssemblyLoadEventArgs : EventArgs // TypeDefIndex: 348
{	// Fields
	private Assembly m_loadedAssembly; // 0x10

	// Methods

	// RVA: 0x155BC80 Offset: 0x155A280 VA: 0x18155BC80
	public void .ctor(Assembly loadedAssembly) { }

}

public sealed class AssemblyLoadEventHandler : MulticastDelegate // TypeDefIndex: 349
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4880 Offset: 0xAE2E80 VA: 0x180AE4880 Slot: 12
	public virtual void Invoke(object sender, AssemblyLoadEventArgs args) { }

	// RVA: 0xAE4840 Offset: 0xAE2E40 VA: 0x180AE4840 Slot: 13
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

	// RVA: 0x7EDDF0 Offset: 0x7EC3F0 VA: 0x1807EDDF0
	public void .ctor(string copyright) { }

}

public sealed class AssemblyTrademarkAttribute : Attribute // TypeDefIndex: 505
{	// Fields
	private string m_trademark; // 0x10

	// Methods

	// RVA: 0x7EDDF0 Offset: 0x7EC3F0 VA: 0x1807EDDF0
	public void .ctor(string trademark) { }

}

public sealed class AssemblyProductAttribute : Attribute // TypeDefIndex: 506
{	// Fields
	private string m_product; // 0x10

	// Methods

	// RVA: 0x7EDDF0 Offset: 0x7EC3F0 VA: 0x1807EDDF0
	public void .ctor(string product) { }

}

public sealed class AssemblyCompanyAttribute : Attribute // TypeDefIndex: 507
{	// Fields
	private string m_company; // 0x10

	// Methods

	// RVA: 0x7EDDF0 Offset: 0x7EC3F0 VA: 0x1807EDDF0
	public void .ctor(string company) { }

}

public sealed class AssemblyDescriptionAttribute : Attribute // TypeDefIndex: 508
{	// Fields
	private string m_description; // 0x10

	// Methods

	// RVA: 0x7EDDF0 Offset: 0x7EC3F0 VA: 0x1807EDDF0
	public void .ctor(string description) { }

}

public sealed class AssemblyTitleAttribute : Attribute // TypeDefIndex: 509
{	// Fields
	private string m_title; // 0x10

	// Methods

	// RVA: 0x7EDDF0 Offset: 0x7EC3F0 VA: 0x1807EDDF0
	public void .ctor(string title) { }

}

public sealed class AssemblyConfigurationAttribute : Attribute // TypeDefIndex: 510
{	// Fields
	private string m_configuration; // 0x10

	// Methods

	// RVA: 0x7EDDF0 Offset: 0x7EC3F0 VA: 0x1807EDDF0
	public void .ctor(string configuration) { }

}

public sealed class AssemblyDefaultAliasAttribute : Attribute // TypeDefIndex: 511
{	// Fields
	private string m_defaultAlias; // 0x10

	// Methods

	// RVA: 0x7EDDF0 Offset: 0x7EC3F0 VA: 0x1807EDDF0
	public void .ctor(string defaultAlias) { }

}

public sealed class AssemblyInformationalVersionAttribute : Attribute // TypeDefIndex: 512
{	// Fields
	private string m_informationalVersion; // 0x10

	// Methods

	// RVA: 0x7EDDF0 Offset: 0x7EC3F0 VA: 0x1807EDDF0
	public void .ctor(string informationalVersion) { }

}

public sealed class AssemblyFileVersionAttribute : Attribute // TypeDefIndex: 513
{	// Fields
	private string _version; // 0x10

	// Methods

	// RVA: 0x18C38E0 Offset: 0x18C1EE0 VA: 0x1818C38E0
	public void .ctor(string version) { }

}

public sealed class AssemblyKeyFileAttribute : Attribute // TypeDefIndex: 514
{	// Fields
	private string m_keyFile; // 0x10

	// Methods

	// RVA: 0x7EDDF0 Offset: 0x7EC3F0 VA: 0x1807EDDF0
	public void .ctor(string keyFile) { }

}

public sealed class AssemblyDelaySignAttribute : Attribute // TypeDefIndex: 515
{	// Fields
	private bool m_delaySign; // 0x10

	// Methods

	// RVA: 0xFDCE40 Offset: 0xFDB440 VA: 0x180FDCE40
	public void .ctor(bool delaySign) { }

}

public sealed class AssemblyMetadataAttribute : Attribute // TypeDefIndex: 516
{	// Fields
	private string m_key; // 0x10
	private string m_value; // 0x18

	// Methods

	// RVA: 0x7ED390 Offset: 0x7EB990 VA: 0x1807ED390
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
	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public virtual bool ReflectionOnly { get; }
	[MonoTODOAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool IsFullyTrusted { get; }

	// Methods

	// RVA: 0x18C6510 Offset: 0x18C4B10 VA: 0x1818C6510
	protected void .ctor() { }

	// RVA: 0x18C5030 Offset: 0x18C3630 VA: 0x1818C5030
	private string get_code_base(bool escaped) { }

	// RVA: 0x18C65E0 Offset: 0x18C4BE0 VA: 0x1818C65E0
	private string get_fullname() { }

	// RVA: 0x18C65F0 Offset: 0x18C4BF0 VA: 0x1818C65F0
	private string get_location() { }

	// RVA: 0x17C9F50 Offset: 0x17C8550 VA: 0x1817C9F50
	internal static string GetAotId() { }

	// RVA: 0x18C5030 Offset: 0x18C3630 VA: 0x1818C5030
	private string GetCodeBase(bool escaped) { }

	// RVA: 0x18C6580 Offset: 0x18C4B80 VA: 0x1818C6580 Slot: 8
	public virtual string get_CodeBase() { }

	// RVA: 0xD86DF0 Offset: 0xD853F0 VA: 0x180D86DF0 Slot: 9
	public virtual string get_FullName() { }

	// RVA: 0x18C6590 Offset: 0x18C4B90 VA: 0x1818C6590 Slot: 10
	public virtual string get_Location() { }

	// RVA: 0x18C5B10 Offset: 0x18C4110 VA: 0x1818C5B10 Slot: 11
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18C62C0 Offset: 0x18C48C0 VA: 0x1818C62C0 Slot: 12
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18C5040 Offset: 0x18C3640 VA: 0x1818C5040 Slot: 13
	public virtual object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18C50B0 Offset: 0x18C36B0 VA: 0x1818C50B0 Slot: 14
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x17C9F50 Offset: 0x17C8550 VA: 0x1817C9F50
	private object GetFilesInternal(string name, bool getResourceModules) { }

	// RVA: 0x18C5160 Offset: 0x18C3760 VA: 0x1818C5160 Slot: 15
	public virtual FileStream GetFile(string name) { }

	// RVA: 0x18C53D0 Offset: 0x18C39D0 VA: 0x1818C53D0
	internal IntPtr GetManifestResourceInternal(string name, out int size, out Module module) { }

	// RVA: 0x18C53F0 Offset: 0x18C39F0 VA: 0x1818C53F0 Slot: 16
	public virtual Stream GetManifestResourceStream(string name) { }

	// RVA: 0x18C5870 Offset: 0x18C3E70 VA: 0x1818C5870
	internal Stream GetManifestResourceStream(Type type, string name, bool skipSecurityCheck, ref StackCrawlMark stackMark) { }

	// RVA: 0x18C5760 Offset: 0x18C3D60 VA: 0x1818C5760
	internal Stream GetManifestResourceStream(string name, ref StackCrawlMark stackMark, bool skipSecurityCheck) { }

	// RVA: 0x18C5E30 Offset: 0x18C4430 VA: 0x1818C5E30
	internal string GetSimpleName() { }

	// RVA: 0x18C5B60 Offset: 0x18C4160 VA: 0x1818C5B60
	internal byte[] GetPublicKey() { }

	// RVA: 0x18C5F30 Offset: 0x18C4530 VA: 0x1818C5F30
	internal Version GetVersion() { }

	// RVA: 0x18C5280 Offset: 0x18C3880 VA: 0x1818C5280
	private AssemblyNameFlags GetFlags() { }

	// RVA: 0x18C5F20 Offset: 0x18C4520 VA: 0x1818C5F20 Slot: 17
	internal virtual Type[] GetTypes(bool exportedOnly) { }

	// RVA: 0x18C5F00 Offset: 0x18C4500 VA: 0x1818C5F00 Slot: 18
	public virtual Type[] GetTypes() { }

	// RVA: 0x18C5EA0 Offset: 0x18C44A0 VA: 0x1818C5EA0 Slot: 19
	public virtual Type GetType(string name, bool throwOnError) { }

	// RVA: 0x18C5ED0 Offset: 0x18C44D0 VA: 0x1818C5ED0 Slot: 20
	public virtual Type GetType(string name) { }

	// RVA: 0x18C62B0 Offset: 0x18C48B0 VA: 0x1818C62B0
	internal Type InternalGetType(Module module, string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x18C5AA0 Offset: 0x18C40A0 VA: 0x1818C5AA0 Slot: 21
	public virtual AssemblyName GetName(bool copiedName) { }

	// RVA: 0x18C5AF0 Offset: 0x18C40F0 VA: 0x1818C5AF0 Slot: 22
	public virtual AssemblyName GetName() { }

	// RVA: 0x18C64E0 Offset: 0x18C4AE0 VA: 0x1818C64E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x18C4F70 Offset: 0x18C3570 VA: 0x1818C4F70
	public static Assembly GetAssembly(Type type) { }

	// RVA: 0x18C5F70 Offset: 0x18C4570 VA: 0x1818C5F70
	internal RuntimeAssembly InternalGetSatelliteAssembly(string name, CultureInfo culture, Version version, bool throwOnFileNotFound, ref StackCrawlMark stackMark) { }

	// RVA: 0x18C6350 Offset: 0x18C4950 VA: 0x1818C6350
	private static Assembly LoadFrom(string assemblyFile, bool refonly) { }

	// RVA: 0x18C6340 Offset: 0x18C4940 VA: 0x1818C6340
	public static Assembly LoadFrom(string assemblyFile) { }

	[ObsoleteAttribute] // RVA: 0x9E110 Offset: 0x9D510 VA: 0x18009E110
	// RVA: 0x18C6340 Offset: 0x18C4940 VA: 0x1818C6340
	public static Assembly LoadFrom(string assemblyFile, Evidence securityEvidence) { }

	// RVA: 0x18C6480 Offset: 0x18C4A80 VA: 0x1818C6480
	public static Assembly Load(string assemblyString) { }

	// RVA: 0x18C64B0 Offset: 0x18C4AB0 VA: 0x1818C64B0
	public static Assembly Load(AssemblyName assemblyRef) { }

	// RVA: 0x18C6600 Offset: 0x18C4C00 VA: 0x1818C6600
	private static Assembly load_with_partial_name(string name, Evidence e) { }

	[ObsoleteAttribute] // RVA: 0x9E240 Offset: 0x9D640 VA: 0x18009E240
	// RVA: 0x18C6360 Offset: 0x18C4960 VA: 0x1818C6360
	public static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence) { }

	// RVA: 0x18C63D0 Offset: 0x18C49D0 VA: 0x1818C63D0
	internal static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence, bool oldBehavior) { }

	// RVA: 0x18C5A50 Offset: 0x18C4050 VA: 0x1818C5A50 Slot: 23
	internal virtual Module[] GetModulesInternal() { }

	// RVA: 0x18C53E0 Offset: 0x18C39E0 VA: 0x1818C53E0 Slot: 24
	public virtual string[] GetManifestResourceNames() { }

	// RVA: 0x18C5130 Offset: 0x18C3730 VA: 0x1818C5130
	public static Assembly GetExecutingAssembly() { }

	// RVA: 0x18C5020 Offset: 0x18C3620 VA: 0x1818C5020
	public static Assembly GetCallingAssembly() { }

	// RVA: 0x18C5F60 Offset: 0x18C4560 VA: 0x1818C5F60
	internal static IntPtr InternalGetReferencedAssemblies(Assembly module) { }

	// RVA: 0x18C5B90 Offset: 0x18C4190 VA: 0x1818C5B90
	internal static AssemblyName[] GetReferencedAssemblies(Assembly module) { }

	// RVA: 0x18C52B0 Offset: 0x18C38B0 VA: 0x1818C52B0
	private bool GetManifestResourceInfoInternal(string name, ManifestResourceInfo info) { }

	// RVA: 0x18C52C0 Offset: 0x18C38C0 VA: 0x1818C52C0 Slot: 25
	public virtual ManifestResourceInfo GetManifestResourceInfo(string resourceName) { }

	// RVA: 0xD699C0 Offset: 0xD67FC0 VA: 0x180D699C0 Slot: 26
	public virtual bool get_ReflectionOnly() { }

	// RVA: 0xCCE820 Offset: 0xCCCE20 VA: 0x180CCE820 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18C4E80 Offset: 0x18C3480 VA: 0x1818C4E80 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x18C4E30 Offset: 0x18C3430 VA: 0x1818C4E30
	private static Exception CreateNIE() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250
	public bool get_IsFullyTrusted() { }

	// RVA: 0x18C5E60 Offset: 0x18C4460 VA: 0x1818C5E60 Slot: 27
	public virtual Type GetType(string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x18C5A10 Offset: 0x18C4010 VA: 0x1818C5A10 Slot: 28
	public virtual Module GetModule(string name) { }

	// RVA: 0x18C5DF0 Offset: 0x18C43F0 VA: 0x1818C5DF0 Slot: 29
	public virtual AssemblyName[] GetReferencedAssemblies() { }

	// RVA: 0x18C5A60 Offset: 0x18C4060 VA: 0x1818C5A60 Slot: 30
	public virtual Module[] GetModules(bool getResourceModules) { }

	// RVA: 0x18C6610 Offset: 0x18C4C10 VA: 0x1818C6610
	public static bool op_Equality(Assembly left, Assembly right) { }

	// RVA: 0x18C6660 Offset: 0x18C4C60 VA: 0x1818C6660
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

	// RVA: 0x18D80B0 Offset: 0x18D66B0 VA: 0x1818D80B0
	public void .ctor(byte* pointer, long length, Module module) { }

	// RVA: 0x18D8060 Offset: 0x18D6660 VA: 0x1818D8060 Slot: 17
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

	// RVA: 0x18C4910 Offset: 0x18C2F10 VA: 0x1818C4910
	public void .ctor() { }

	// RVA: 0x18C42A0 Offset: 0x18C28A0 VA: 0x1818C42A0
	private static bool ParseAssemblyName(IntPtr name, out MonoAssemblyName aname, out bool is_version_definited, out bool is_token_defined) { }

	// RVA: 0x18C4310 Offset: 0x18C2910 VA: 0x1818C4310
	public void .ctor(string assemblyName) { }

	// RVA: 0x18C4550 Offset: 0x18C2B50 VA: 0x1818C4550
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

	// RVA: 0x6BBA50 Offset: 0x6BA050 VA: 0x1806BBA50
	public AssemblyNameFlags get_Flags() { }

	// RVA: 0xC74BD0 Offset: 0xC731D0 VA: 0x180C74BD0
	public void set_Flags(AssemblyNameFlags value) { }

	// RVA: 0x18C4930 Offset: 0x18C2F30 VA: 0x1818C4930
	public string get_FullName() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public Version get_Version() { }

	// RVA: 0x18C4D80 Offset: 0x18C3380 VA: 0x1818C4D80
	public void set_Version(Version value) { }

	// RVA: 0x18C42E0 Offset: 0x18C28E0 VA: 0x1818C42E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public byte[] GetPublicKey() { }

	// RVA: 0x18C40C0 Offset: 0x18C26C0 VA: 0x1818C40C0
	public byte[] GetPublicKeyToken() { }

	// RVA: 0x18C4CD0 Offset: 0x18C32D0 VA: 0x1818C4CD0
	private bool get_IsPublicKeyValid() { }

	// RVA: 0x18C41C0 Offset: 0x18C27C0 VA: 0x1818C41C0
	private byte[] InternalGetPublicKeyToken() { }

	// RVA: 0xD730F0 Offset: 0xD716F0 VA: 0x180D730F0
	private static void get_public_token(byte* token, byte* pubkey, int len) { }

	// RVA: 0x18C3A70 Offset: 0x18C2070 VA: 0x1818C3A70
	private byte[] ComputePublicKeyToken() { }

	// RVA: 0x18C42B0 Offset: 0x18C28B0 VA: 0x1818C42B0
	public void SetPublicKey(byte[] publicKey) { }

	// RVA: 0x18C3EC0 Offset: 0x18C24C0 VA: 0x1818C3EC0 Slot: 5
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18C3970 Offset: 0x18C1F70 VA: 0x1818C3970 Slot: 4
	public object Clone() { }

	// RVA: 0x18C4290 Offset: 0x18C2890 VA: 0x1818C4290 Slot: 6
	public void OnDeserialization(object sender) { }

	// RVA: 0x18C3EB0 Offset: 0x18C24B0 VA: 0x1818C3EB0
	private static MonoAssemblyName* GetNativeName(IntPtr assembly_ptr) { }

	// RVA: 0x18C3BD0 Offset: 0x18C21D0 VA: 0x1818C3BD0
	internal void FillName(MonoAssemblyName* native, string codeBase, bool addVersion, bool addPublickey, bool defaultToken, bool assemblyRef) { }

	// RVA: 0x18C3B00 Offset: 0x18C2100 VA: 0x1818C3B00
	internal static AssemblyName Create(Assembly assembly, bool fillCodebase) { }

}

