public class AssemblyLoadEventArgs : EventArgs // TypeDefIndex: 348
{	// Fields
	private Assembly m_loadedAssembly; // 0x10

	// Methods

	// RVA: 0x155AD50 Offset: 0x1559350 VA: 0x18155AD50
	public void .ctor(Assembly loadedAssembly) { }

}

public sealed class AssemblyLoadEventHandler : MulticastDelegate // TypeDefIndex: 349
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4D50 Offset: 0xAE3350 VA: 0x180AE4D50 Slot: 12
	public virtual void Invoke(object sender, AssemblyLoadEventArgs args) { }

	// RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10 Slot: 13
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

	// RVA: 0x7B9710 Offset: 0x7B7D10 VA: 0x1807B9710
	public void .ctor(string copyright) { }

}

public sealed class AssemblyTrademarkAttribute : Attribute // TypeDefIndex: 505
{	// Fields
	private string m_trademark; // 0x10

	// Methods

	// RVA: 0x7B9710 Offset: 0x7B7D10 VA: 0x1807B9710
	public void .ctor(string trademark) { }

}

public sealed class AssemblyProductAttribute : Attribute // TypeDefIndex: 506
{	// Fields
	private string m_product; // 0x10

	// Methods

	// RVA: 0x7B9710 Offset: 0x7B7D10 VA: 0x1807B9710
	public void .ctor(string product) { }

}

public sealed class AssemblyCompanyAttribute : Attribute // TypeDefIndex: 507
{	// Fields
	private string m_company; // 0x10

	// Methods

	// RVA: 0x7B9710 Offset: 0x7B7D10 VA: 0x1807B9710
	public void .ctor(string company) { }

}

public sealed class AssemblyDescriptionAttribute : Attribute // TypeDefIndex: 508
{	// Fields
	private string m_description; // 0x10

	// Methods

	// RVA: 0x7B9710 Offset: 0x7B7D10 VA: 0x1807B9710
	public void .ctor(string description) { }

}

public sealed class AssemblyTitleAttribute : Attribute // TypeDefIndex: 509
{	// Fields
	private string m_title; // 0x10

	// Methods

	// RVA: 0x7B9710 Offset: 0x7B7D10 VA: 0x1807B9710
	public void .ctor(string title) { }

}

public sealed class AssemblyConfigurationAttribute : Attribute // TypeDefIndex: 510
{	// Fields
	private string m_configuration; // 0x10

	// Methods

	// RVA: 0x7B9710 Offset: 0x7B7D10 VA: 0x1807B9710
	public void .ctor(string configuration) { }

}

public sealed class AssemblyDefaultAliasAttribute : Attribute // TypeDefIndex: 511
{	// Fields
	private string m_defaultAlias; // 0x10

	// Methods

	// RVA: 0x7B9710 Offset: 0x7B7D10 VA: 0x1807B9710
	public void .ctor(string defaultAlias) { }

}

public sealed class AssemblyInformationalVersionAttribute : Attribute // TypeDefIndex: 512
{	// Fields
	private string m_informationalVersion; // 0x10

	// Methods

	// RVA: 0x7B9710 Offset: 0x7B7D10 VA: 0x1807B9710
	public void .ctor(string informationalVersion) { }

}

public sealed class AssemblyFileVersionAttribute : Attribute // TypeDefIndex: 513
{	// Fields
	private string _version; // 0x10

	// Methods

	// RVA: 0x18C3000 Offset: 0x18C1600 VA: 0x1818C3000
	public void .ctor(string version) { }

}

public sealed class AssemblyKeyFileAttribute : Attribute // TypeDefIndex: 514
{	// Fields
	private string m_keyFile; // 0x10

	// Methods

	// RVA: 0x7B9710 Offset: 0x7B7D10 VA: 0x1807B9710
	public void .ctor(string keyFile) { }

}

public sealed class AssemblyDelaySignAttribute : Attribute // TypeDefIndex: 515
{	// Fields
	private bool m_delaySign; // 0x10

	// Methods

	// RVA: 0xFDD8E0 Offset: 0xFDBEE0 VA: 0x180FDD8E0
	public void .ctor(bool delaySign) { }

}

public sealed class AssemblyMetadataAttribute : Attribute // TypeDefIndex: 516
{	// Fields
	private string m_key; // 0x10
	private string m_value; // 0x18

	// Methods

	// RVA: 0x7B8CB0 Offset: 0x7B72B0 VA: 0x1807B8CB0
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

	// RVA: 0x18C5C30 Offset: 0x18C4230 VA: 0x1818C5C30
	protected void .ctor() { }

	// RVA: 0x18C4750 Offset: 0x18C2D50 VA: 0x1818C4750
	private string get_code_base(bool escaped) { }

	// RVA: 0x18C5D00 Offset: 0x18C4300 VA: 0x1818C5D00
	private string get_fullname() { }

	// RVA: 0x18C5D10 Offset: 0x18C4310 VA: 0x1818C5D10
	private string get_location() { }

	// RVA: 0x17C7AA0 Offset: 0x17C60A0 VA: 0x1817C7AA0
	internal static string GetAotId() { }

	// RVA: 0x18C4750 Offset: 0x18C2D50 VA: 0x1818C4750
	private string GetCodeBase(bool escaped) { }

	// RVA: 0x18C5CA0 Offset: 0x18C42A0 VA: 0x1818C5CA0 Slot: 8
	public virtual string get_CodeBase() { }

	// RVA: 0xD878A0 Offset: 0xD85EA0 VA: 0x180D878A0 Slot: 9
	public virtual string get_FullName() { }

	// RVA: 0x18C5CB0 Offset: 0x18C42B0 VA: 0x1818C5CB0 Slot: 10
	public virtual string get_Location() { }

	// RVA: 0x18C5230 Offset: 0x18C3830 VA: 0x1818C5230 Slot: 11
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18C59E0 Offset: 0x18C3FE0 VA: 0x1818C59E0 Slot: 12
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18C4760 Offset: 0x18C2D60 VA: 0x1818C4760 Slot: 13
	public virtual object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18C47D0 Offset: 0x18C2DD0 VA: 0x1818C47D0 Slot: 14
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x17C7AA0 Offset: 0x17C60A0 VA: 0x1817C7AA0
	private object GetFilesInternal(string name, bool getResourceModules) { }

	// RVA: 0x18C4880 Offset: 0x18C2E80 VA: 0x1818C4880 Slot: 15
	public virtual FileStream GetFile(string name) { }

	// RVA: 0x18C4AF0 Offset: 0x18C30F0 VA: 0x1818C4AF0
	internal IntPtr GetManifestResourceInternal(string name, out int size, out Module module) { }

	// RVA: 0x18C4B10 Offset: 0x18C3110 VA: 0x1818C4B10 Slot: 16
	public virtual Stream GetManifestResourceStream(string name) { }

	// RVA: 0x18C4F90 Offset: 0x18C3590 VA: 0x1818C4F90
	internal Stream GetManifestResourceStream(Type type, string name, bool skipSecurityCheck, ref StackCrawlMark stackMark) { }

	// RVA: 0x18C4E80 Offset: 0x18C3480 VA: 0x1818C4E80
	internal Stream GetManifestResourceStream(string name, ref StackCrawlMark stackMark, bool skipSecurityCheck) { }

	// RVA: 0x18C5550 Offset: 0x18C3B50 VA: 0x1818C5550
	internal string GetSimpleName() { }

	// RVA: 0x18C5280 Offset: 0x18C3880 VA: 0x1818C5280
	internal byte[] GetPublicKey() { }

	// RVA: 0x18C5650 Offset: 0x18C3C50 VA: 0x1818C5650
	internal Version GetVersion() { }

	// RVA: 0x18C49A0 Offset: 0x18C2FA0 VA: 0x1818C49A0
	private AssemblyNameFlags GetFlags() { }

	// RVA: 0x18C5640 Offset: 0x18C3C40 VA: 0x1818C5640 Slot: 17
	internal virtual Type[] GetTypes(bool exportedOnly) { }

	// RVA: 0x18C5620 Offset: 0x18C3C20 VA: 0x1818C5620 Slot: 18
	public virtual Type[] GetTypes() { }

	// RVA: 0x18C55C0 Offset: 0x18C3BC0 VA: 0x1818C55C0 Slot: 19
	public virtual Type GetType(string name, bool throwOnError) { }

	// RVA: 0x18C55F0 Offset: 0x18C3BF0 VA: 0x1818C55F0 Slot: 20
	public virtual Type GetType(string name) { }

	// RVA: 0x18C59D0 Offset: 0x18C3FD0 VA: 0x1818C59D0
	internal Type InternalGetType(Module module, string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x18C51C0 Offset: 0x18C37C0 VA: 0x1818C51C0 Slot: 21
	public virtual AssemblyName GetName(bool copiedName) { }

	// RVA: 0x18C5210 Offset: 0x18C3810 VA: 0x1818C5210 Slot: 22
	public virtual AssemblyName GetName() { }

	// RVA: 0x18C5C00 Offset: 0x18C4200 VA: 0x1818C5C00 Slot: 3
	public override string ToString() { }

	// RVA: 0x18C4690 Offset: 0x18C2C90 VA: 0x1818C4690
	public static Assembly GetAssembly(Type type) { }

	// RVA: 0x18C5690 Offset: 0x18C3C90 VA: 0x1818C5690
	internal RuntimeAssembly InternalGetSatelliteAssembly(string name, CultureInfo culture, Version version, bool throwOnFileNotFound, ref StackCrawlMark stackMark) { }

	// RVA: 0x18C5A70 Offset: 0x18C4070 VA: 0x1818C5A70
	private static Assembly LoadFrom(string assemblyFile, bool refonly) { }

	// RVA: 0x18C5A60 Offset: 0x18C4060 VA: 0x1818C5A60
	public static Assembly LoadFrom(string assemblyFile) { }

	[ObsoleteAttribute] // RVA: 0x9E110 Offset: 0x9D510 VA: 0x18009E110
	// RVA: 0x18C5A60 Offset: 0x18C4060 VA: 0x1818C5A60
	public static Assembly LoadFrom(string assemblyFile, Evidence securityEvidence) { }

	// RVA: 0x18C5BA0 Offset: 0x18C41A0 VA: 0x1818C5BA0
	public static Assembly Load(string assemblyString) { }

	// RVA: 0x18C5BD0 Offset: 0x18C41D0 VA: 0x1818C5BD0
	public static Assembly Load(AssemblyName assemblyRef) { }

	// RVA: 0x18C5D20 Offset: 0x18C4320 VA: 0x1818C5D20
	private static Assembly load_with_partial_name(string name, Evidence e) { }

	[ObsoleteAttribute] // RVA: 0x9E240 Offset: 0x9D640 VA: 0x18009E240
	// RVA: 0x18C5A80 Offset: 0x18C4080 VA: 0x1818C5A80
	public static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence) { }

	// RVA: 0x18C5AF0 Offset: 0x18C40F0 VA: 0x1818C5AF0
	internal static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence, bool oldBehavior) { }

	// RVA: 0x18C5170 Offset: 0x18C3770 VA: 0x1818C5170 Slot: 23
	internal virtual Module[] GetModulesInternal() { }

	// RVA: 0x18C4B00 Offset: 0x18C3100 VA: 0x1818C4B00 Slot: 24
	public virtual string[] GetManifestResourceNames() { }

	// RVA: 0x18C4850 Offset: 0x18C2E50 VA: 0x1818C4850
	public static Assembly GetExecutingAssembly() { }

	// RVA: 0x18C4740 Offset: 0x18C2D40 VA: 0x1818C4740
	public static Assembly GetCallingAssembly() { }

	// RVA: 0x18C5680 Offset: 0x18C3C80 VA: 0x1818C5680
	internal static IntPtr InternalGetReferencedAssemblies(Assembly module) { }

	// RVA: 0x18C52B0 Offset: 0x18C38B0 VA: 0x1818C52B0
	internal static AssemblyName[] GetReferencedAssemblies(Assembly module) { }

	// RVA: 0x18C49D0 Offset: 0x18C2FD0 VA: 0x1818C49D0
	private bool GetManifestResourceInfoInternal(string name, ManifestResourceInfo info) { }

	// RVA: 0x18C49E0 Offset: 0x18C2FE0 VA: 0x1818C49E0 Slot: 25
	public virtual ManifestResourceInfo GetManifestResourceInfo(string resourceName) { }

	// RVA: 0xD6A470 Offset: 0xD68A70 VA: 0x180D6A470 Slot: 26
	public virtual bool get_ReflectionOnly() { }

	// RVA: 0xCCECC0 Offset: 0xCCD2C0 VA: 0x180CCECC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18C45A0 Offset: 0x18C2BA0 VA: 0x1818C45A0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x18C4550 Offset: 0x18C2B50 VA: 0x1818C4550
	private static Exception CreateNIE() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0
	public bool get_IsFullyTrusted() { }

	// RVA: 0x18C5580 Offset: 0x18C3B80 VA: 0x1818C5580 Slot: 27
	public virtual Type GetType(string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x18C5130 Offset: 0x18C3730 VA: 0x1818C5130 Slot: 28
	public virtual Module GetModule(string name) { }

	// RVA: 0x18C5510 Offset: 0x18C3B10 VA: 0x1818C5510 Slot: 29
	public virtual AssemblyName[] GetReferencedAssemblies() { }

	// RVA: 0x18C5180 Offset: 0x18C3780 VA: 0x1818C5180 Slot: 30
	public virtual Module[] GetModules(bool getResourceModules) { }

	// RVA: 0x18C5D30 Offset: 0x18C4330 VA: 0x1818C5D30
	public static bool op_Equality(Assembly left, Assembly right) { }

	// RVA: 0x18C5D80 Offset: 0x18C4380 VA: 0x1818C5D80
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

	// RVA: 0x18D77D0 Offset: 0x18D5DD0 VA: 0x1818D77D0
	public void .ctor(byte* pointer, long length, Module module) { }

	// RVA: 0x18D7780 Offset: 0x18D5D80 VA: 0x1818D7780 Slot: 17
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

	// RVA: 0x18C4030 Offset: 0x18C2630 VA: 0x1818C4030
	public void .ctor() { }

	// RVA: 0x18C39C0 Offset: 0x18C1FC0 VA: 0x1818C39C0
	private static bool ParseAssemblyName(IntPtr name, out MonoAssemblyName aname, out bool is_version_definited, out bool is_token_defined) { }

	// RVA: 0x18C3A30 Offset: 0x18C2030 VA: 0x1818C3A30
	public void .ctor(string assemblyName) { }

	// RVA: 0x18C3C70 Offset: 0x18C2270 VA: 0x1818C3C70
	internal void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_Name() { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	public void set_Name(string value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_CodeBase() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public CultureInfo get_CultureInfo() { }

	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	public void set_CultureInfo(CultureInfo value) { }

	// RVA: 0x6BB9E0 Offset: 0x6B9FE0 VA: 0x1806BB9E0
	public AssemblyNameFlags get_Flags() { }

	// RVA: 0xC75070 Offset: 0xC73670 VA: 0x180C75070
	public void set_Flags(AssemblyNameFlags value) { }

	// RVA: 0x18C4050 Offset: 0x18C2650 VA: 0x1818C4050
	public string get_FullName() { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	public Version get_Version() { }

	// RVA: 0x18C44A0 Offset: 0x18C2AA0 VA: 0x1818C44A0
	public void set_Version(Version value) { }

	// RVA: 0x18C3A00 Offset: 0x18C2000 VA: 0x1818C3A00 Slot: 3
	public override string ToString() { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	public byte[] GetPublicKey() { }

	// RVA: 0x18C37E0 Offset: 0x18C1DE0 VA: 0x1818C37E0
	public byte[] GetPublicKeyToken() { }

	// RVA: 0x18C43F0 Offset: 0x18C29F0 VA: 0x1818C43F0
	private bool get_IsPublicKeyValid() { }

	// RVA: 0x18C38E0 Offset: 0x18C1EE0 VA: 0x1818C38E0
	private byte[] InternalGetPublicKeyToken() { }

	// RVA: 0xD73BA0 Offset: 0xD721A0 VA: 0x180D73BA0
	private static void get_public_token(byte* token, byte* pubkey, int len) { }

	// RVA: 0x18C3190 Offset: 0x18C1790 VA: 0x1818C3190
	private byte[] ComputePublicKeyToken() { }

	// RVA: 0x18C39D0 Offset: 0x18C1FD0 VA: 0x1818C39D0
	public void SetPublicKey(byte[] publicKey) { }

	// RVA: 0x18C35E0 Offset: 0x18C1BE0 VA: 0x1818C35E0 Slot: 5
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18C3090 Offset: 0x18C1690 VA: 0x1818C3090 Slot: 4
	public object Clone() { }

	// RVA: 0x18C39B0 Offset: 0x18C1FB0 VA: 0x1818C39B0 Slot: 6
	public void OnDeserialization(object sender) { }

	// RVA: 0x18C35D0 Offset: 0x18C1BD0 VA: 0x1818C35D0
	private static MonoAssemblyName* GetNativeName(IntPtr assembly_ptr) { }

	// RVA: 0x18C32F0 Offset: 0x18C18F0 VA: 0x1818C32F0
	internal void FillName(MonoAssemblyName* native, string codeBase, bool addVersion, bool addPublickey, bool defaultToken, bool assemblyRef) { }

	// RVA: 0x18C3220 Offset: 0x18C1820 VA: 0x1818C3220
	internal static AssemblyName Create(Assembly assembly, bool fillCodebase) { }

}

