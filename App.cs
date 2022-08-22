internal static class AppContextSwitches // TypeDefIndex: 142
{	// Fields
	public static readonly bool ThrowExceptionIfDisposedCancellationTokenSource; // 0x0
	public static readonly bool SetActorAsReferenceWhenCopyingClaimsIdentity; // 0x1
	public static readonly bool NoAsyncCurrentCulture; // 0x2
	public static readonly bool PreserveEventListnerObjectIdentity; // 0x3

}

public class AppDomainUnloadedException : SystemException // TypeDefIndex: 164
{	// Methods

	// RVA: 0x1552070 Offset: 0x1550670 VA: 0x181552070
	public void .ctor() { }

	// RVA: 0xFDD410 Offset: 0xFDBA10 VA: 0x180FDD410
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

public class ApplicationException : Exception // TypeDefIndex: 165
{	// Methods

	// RVA: 0x1553B80 Offset: 0x1552180 VA: 0x181553B80
	public void .ctor() { }

	// RVA: 0x1553C00 Offset: 0x1552200 VA: 0x181553C00
	public void .ctor(string message) { }

	// RVA: 0x1553AF0 Offset: 0x15520F0 VA: 0x181553AF0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1553C80 Offset: 0x1552280 VA: 0x181553C80
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

public sealed class AppDomain : MarshalByRefObject // TypeDefIndex: 337
{	// Fields
	private IntPtr _mono_app_domain; // 0x18
	private static string _process_guid; // 0x0
	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Dictionary<string, object> type_resolve_in_progress; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Dictionary<string, object> assembly_resolve_in_progress; // 0x80000008
	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Dictionary<string, object> assembly_resolve_in_progress_refonly; // 0x80000010
	private object _evidence; // 0x20
	private object _granted; // 0x28
	private int _principalPolicy; // 0x30
	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static object _principal; // 0x80000018
	private static AppDomain default_domain; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private AssemblyLoadEventHandler AssemblyLoad; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ResolveEventHandler AssemblyResolve; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private EventHandler DomainUnload; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private EventHandler ProcessExit; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ResolveEventHandler ResourceResolve; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ResolveEventHandler TypeResolve; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private UnhandledExceptionEventHandler UnhandledException; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private EventHandler<FirstChanceExceptionEventArgs> FirstChanceException; // 0x70
	private object _domain_manager; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ResolveEventHandler ReflectionOnlyAssemblyResolve; // 0x80
	private object _activation; // 0x88
	private object _applicationIdentity; // 0x90
	private List<string> compatibility_switch; // 0x98

	// Properties
	internal AppDomainSetup SetupInformationNoCopy { get; }
	public string BaseDirectory { get; }
	public string FriendlyName { get; }
	public static AppDomain CurrentDomain { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	// RVA: 0x15538D0 Offset: 0x1551ED0 VA: 0x1815538D0
	private AppDomainSetup getSetup() { }

	// RVA: 0x15538D0 Offset: 0x1551ED0 VA: 0x1815538D0
	internal AppDomainSetup get_SetupInformationNoCopy() { }

	// RVA: 0x15538E0 Offset: 0x1551EE0 VA: 0x1815538E0 Slot: 6
	public string get_BaseDirectory() { }

	// RVA: 0x15536C0 Offset: 0x1551CC0 VA: 0x1815536C0
	private string getFriendlyName() { }

	// RVA: 0x15536C0 Offset: 0x1551CC0 VA: 0x1815536C0 Slot: 7
	public string get_FriendlyName() { }

	// RVA: 0x15538B0 Offset: 0x1551EB0 VA: 0x1815538B0
	private static AppDomain getCurDomain() { }

	// RVA: 0x15538B0 Offset: 0x1551EB0 VA: 0x1815538B0
	public static AppDomain get_CurrentDomain() { }

	// RVA: 0x1552890 Offset: 0x1550E90 VA: 0x181552890
	private Assembly[] GetAssemblies(bool refOnly) { }

	// RVA: 0x15528A0 Offset: 0x1550EA0 VA: 0x1815528A0 Slot: 8
	public Assembly[] GetAssemblies() { }

	// RVA: 0x15528C0 Offset: 0x1550EC0 VA: 0x1815528C0 Slot: 9
	public object GetData(string name) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 5
	public override object InitializeLifetimeService() { }

	// RVA: 0x1552CB0 Offset: 0x15512B0 VA: 0x181552CB0
	internal Assembly LoadAssembly(string assemblyRef, Evidence securityEvidence, bool refOnly) { }

	// RVA: 0x1552DC0 Offset: 0x15513C0 VA: 0x181552DC0 Slot: 10
	public Assembly Load(AssemblyName assemblyRef) { }

	// RVA: 0x1552CC0 Offset: 0x15512C0 VA: 0x181552CC0
	internal Assembly LoadSatellite(AssemblyName assemblyRef, bool throwOnError) { }

	[ObsoleteAttribute] // RVA: 0x8C760 Offset: 0x8BB60 VA: 0x18008C760
	// RVA: 0x1552DD0 Offset: 0x15513D0 VA: 0x181552DD0 Slot: 11
	public Assembly Load(AssemblyName assemblyRef, Evidence assemblySecurity) { }

	// RVA: 0x1553370 Offset: 0x1551970 VA: 0x181553370 Slot: 12
	public Assembly Load(string assemblyString) { }

	// RVA: 0x1553470 Offset: 0x1551A70 VA: 0x181553470
	internal Assembly Load(string assemblyString, Evidence assemblySecurity, bool refonly) { }

	// RVA: 0x1552A90 Offset: 0x1551090 VA: 0x181552A90
	private static AppDomain InternalSetDomainByID(int domain_id) { }

	// RVA: 0x1552AA0 Offset: 0x15510A0 VA: 0x181552AA0
	private static AppDomain InternalSetDomain(AppDomain context) { }

	// RVA: 0x1552A70 Offset: 0x1551070 VA: 0x181552A70
	internal static void InternalPushDomainRefByID(int domain_id) { }

	// RVA: 0x1552A60 Offset: 0x1551060 VA: 0x181552A60
	internal static void InternalPopDomainRef() { }

	// RVA: 0x1552A80 Offset: 0x1551080 VA: 0x181552A80
	internal static Context InternalSetContext(Context context) { }

	// RVA: 0x1552A40 Offset: 0x1551040 VA: 0x181552A40
	internal static Context InternalGetContext() { }

	// RVA: 0x1552A40 Offset: 0x1551040 VA: 0x181552A40
	internal static Context InternalGetDefaultContext() { }

	// RVA: 0x1552A50 Offset: 0x1551050 VA: 0x181552A50
	internal static string InternalGetProcessGuid(string newguid) { }

	// RVA: 0x1552AB0 Offset: 0x15510B0 VA: 0x181552AB0
	internal static object InvokeInDomainByID(int domain_id, MethodInfo method, object obj, object[] args) { }

	// RVA: 0x1552990 Offset: 0x1550F90 VA: 0x181552990
	internal static string GetProcessGuid() { }

	// RVA: 0xD699C0 Offset: 0xD67FC0 VA: 0x180D699C0
	private static bool InternalIsFinalizingForUnload(int domain_id) { }

	// RVA: 0x1552C90 Offset: 0x1551290 VA: 0x181552C90
	public bool IsFinalizingForUnload() { }

	// RVA: 0x15538C0 Offset: 0x1551EC0 VA: 0x1815538C0
	private int getDomainID() { }

	[ObsoleteAttribute] // RVA: 0x8C8D0 Offset: 0x8BCD0 VA: 0x18008C8D0
	// RVA: 0x15528B0 Offset: 0x1550EB0 VA: 0x1815528B0
	public static int GetCurrentThreadId() { }

	// RVA: 0x15536C0 Offset: 0x1551CC0 VA: 0x1815536C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x15520D0 Offset: 0x15506D0 VA: 0x1815520D0
	private void DoAssemblyLoad(Assembly assembly) { }

	// RVA: 0x15521A0 Offset: 0x15507A0 VA: 0x1815521A0
	private Assembly DoAssemblyResolve(string name, Assembly requestingAssembly, bool refonly) { }

	// RVA: 0x15525E0 Offset: 0x1550BE0 VA: 0x1815525E0
	internal Assembly DoTypeResolve(object name_or_tb) { }

	// RVA: 0x15524B0 Offset: 0x1550AB0 VA: 0x1815524B0
	internal Assembly DoResourceResolve(string name, Assembly requesting) { }

	// RVA: 0x1552490 Offset: 0x1550A90 VA: 0x181552490
	private void DoDomainUnload() { }

	// RVA: 0x15528D0 Offset: 0x1550ED0 VA: 0x1815528D0
	internal byte[] GetMarshalledDomainObjRef() { }

	// RVA: 0x1553590 Offset: 0x1551B90 VA: 0x181553590
	internal void ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg, out byte[] arrResponse, out CADMethodReturnMessage cadMrm) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x15536D0 Offset: 0x1551CD0 VA: 0x1815536D0 Slot: 13
	public void add_DomainUnload(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1553910 Offset: 0x1551F10 VA: 0x181553910 Slot: 14
	public void remove_DomainUnload(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1553770 Offset: 0x1551D70 VA: 0x181553770 Slot: 15
	public void add_ProcessExit(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x15539B0 Offset: 0x1551FB0 VA: 0x1815539B0 Slot: 16
	public void remove_ProcessExit(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1553810 Offset: 0x1551E10 VA: 0x181553810 Slot: 17
	public void add_UnhandledException(UnhandledExceptionEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1553A50 Offset: 0x1552050 VA: 0x181553A50 Slot: 18
	public void remove_UnhandledException(UnhandledExceptionEventHandler value) { }

}

public sealed class AppDomainSetup // TypeDefIndex: 346
{	// Fields
	private string application_base; // 0x10
	private string application_name; // 0x18
	private string cache_path; // 0x20
	private string configuration_file; // 0x28
	private string dynamic_base; // 0x30
	private string license_file; // 0x38
	private string private_bin_path; // 0x40
	private string private_bin_path_probe; // 0x48
	private string shadow_copy_directories; // 0x50
	private string shadow_copy_files; // 0x58
	private bool publisher_policy; // 0x60
	private bool path_changed; // 0x61
	private int loader_optimization; // 0x64
	private bool disallow_binding_redirects; // 0x68
	private bool disallow_code_downloads; // 0x69
	private object _activationArguments; // 0x70
	private object domain_initializer; // 0x78
	private object application_trust; // 0x80
	private string[] domain_initializer_args; // 0x88
	private bool disallow_appbase_probe; // 0x90
	private byte[] configuration_bytes; // 0x98
	private byte[] serialized_non_primitives; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <TargetFrameworkName>k__BackingField; // 0xA8

	// Properties
	public string ApplicationBase { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1551D10 Offset: 0x1550310 VA: 0x181551D10
	private static string GetAppBase(string appBase) { }

	// RVA: 0x1552060 Offset: 0x1550660 VA: 0x181552060 Slot: 4
	public string get_ApplicationBase() { }

}

internal class AppDomainLevelActivator : IActivator // TypeDefIndex: 1203
{	// Fields
	private string _activationUrl; // 0x10
	private IActivator _next; // 0x18

	// Properties
	public IActivator NextActivator { get; }

	// Methods

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	public void .ctor(string activationUrl, IActivator next) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	public IActivator get_NextActivator() { }

	// RVA: 0xFDB8D0 Offset: 0xFD9ED0 VA: 0x180FDB8D0 Slot: 5
	public IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall) { }

}

public class Application // TypeDefIndex: 3354
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private static Application.LowMemoryCallback lowMemory; // 0x0
	private static Application.LogCallback s_LogCallbackHandler; // 0x8
	private static Application.LogCallback s_LogCallbackHandlerThreaded; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private static Action<bool> focusChanged; // 0x18
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private static Action<string> deepLinkActivated; // 0x20
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private static Func<bool> wantsToQuit; // 0x28
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private static Action quitting; // 0x30

	// Properties
	public static bool isPlaying { get; }
	public static string dataPath { get; }
	public static string streamingAssetsPath { get; }
	[SecurityCriticalAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static string persistentDataPath { get; }
	public static string unityVersion { get; }
	public static string version { get; }
	public static string companyName { get; }
	public static int targetFrameRate { get; set; }
	public static string consoleLogPath { get; }
	public static ThreadPriority backgroundLoadingPriority { set; }
	public static RuntimePlatform platform { get; }
	public static bool isMobilePlatform { get; }
	public static SystemLanguage systemLanguage { get; }
	public static NetworkReachability internetReachability { get; }
	[ObsoleteAttribute] // RVA: 0x75710 Offset: 0x74B10 VA: 0x180075710
	public static string loadedLevelName { get; }
	public static bool isEditor { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0x70E00 Offset: 0x70200 VA: 0x180070E00
	// RVA: 0x181D4F0 Offset: 0x181BAF0 VA: 0x18181D4F0
	public static void Quit(int exitCode) { }

	// RVA: 0x181D530 Offset: 0x181BB30 VA: 0x18181D530
	public static void Quit() { }

	[FreeFunctionAttribute] // RVA: 0x70F10 Offset: 0x70310 VA: 0x180070F10
	// RVA: 0x181D1A0 Offset: 0x181B7A0 VA: 0x18181D1A0
	public static bool CanStreamedLevelBeLoaded(string levelName) { }

	[FreeFunctionAttribute] // RVA: 0x710A0 Offset: 0x704A0 VA: 0x1800710A0
	// RVA: 0x181D7B0 Offset: 0x181BDB0 VA: 0x18181D7B0
	public static bool get_isPlaying() { }

	[FreeFunctionAttribute] // RVA: 0x711D0 Offset: 0x705D0 VA: 0x1800711D0
	// RVA: 0x181D6F0 Offset: 0x181BCF0 VA: 0x18181D6F0
	public static string get_dataPath() { }

	[FreeFunctionAttribute] // RVA: 0x71310 Offset: 0x70710 VA: 0x180071310
	// RVA: 0x181D860 Offset: 0x181BE60 VA: 0x18181D860
	public static string get_streamingAssetsPath() { }

	[FreeFunctionAttribute] // RVA: 0x713D0 Offset: 0x707D0 VA: 0x1800713D0
	// RVA: 0x181D800 Offset: 0x181BE00 VA: 0x18181D800
	public static string get_persistentDataPath() { }

	[FreeFunctionAttribute] // RVA: 0x714E0 Offset: 0x708E0 VA: 0x1800714E0
	// RVA: 0x181D8F0 Offset: 0x181BEF0 VA: 0x18181D8F0
	public static string get_unityVersion() { }

	[FreeFunctionAttribute] // RVA: 0x71720 Offset: 0x70B20 VA: 0x180071720
	// RVA: 0x181D920 Offset: 0x181BF20 VA: 0x18181D920
	public static string get_version() { }

	[FreeFunctionAttribute] // RVA: 0x717E0 Offset: 0x70BE0 VA: 0x1800717E0
	// RVA: 0x181D690 Offset: 0x181BC90 VA: 0x18181D690
	public static string get_companyName() { }

	[FreeFunctionAttribute] // RVA: 0x71920 Offset: 0x70D20 VA: 0x180071920
	// RVA: 0x181D4B0 Offset: 0x181BAB0 VA: 0x18181D4B0
	public static void OpenURL(string url) { }

	[FreeFunctionAttribute] // RVA: 0x71A60 Offset: 0x70E60 VA: 0x180071A60
	// RVA: 0x181D8C0 Offset: 0x181BEC0 VA: 0x18181D8C0
	public static int get_targetFrameRate() { }

	[FreeFunctionAttribute] // RVA: 0x71B40 Offset: 0x70F40 VA: 0x180071B40
	// RVA: 0x181DA20 Offset: 0x181C020 VA: 0x18181DA20
	public static void set_targetFrameRate(int value) { }

	[FreeFunctionAttribute] // RVA: 0x71CD0 Offset: 0x710D0 VA: 0x180071CD0
	// RVA: 0x181D560 Offset: 0x181BB60 VA: 0x18181D560
	private static void SetLogCallbackDefined(bool defined) { }

	[FreeFunctionAttribute] // RVA: 0x71E10 Offset: 0x71210 VA: 0x180071E10
	// RVA: 0x181D1E0 Offset: 0x181B7E0 VA: 0x18181D1E0
	public static StackTraceLogType GetStackTraceLogType(LogType logType) { }

	[FreeFunctionAttribute] // RVA: 0x71ED0 Offset: 0x712D0 VA: 0x180071ED0
	// RVA: 0x181D5A0 Offset: 0x181BBA0 VA: 0x18181D5A0
	public static void SetStackTraceLogType(LogType logType, StackTraceLogType stackTraceType) { }

	[FreeFunctionAttribute] // RVA: 0x72180 Offset: 0x71580 VA: 0x180072180
	// RVA: 0x181D6C0 Offset: 0x181BCC0 VA: 0x18181D6C0
	public static string get_consoleLogPath() { }

	[FreeFunctionAttribute] // RVA: 0x722D0 Offset: 0x716D0 VA: 0x1800722D0
	// RVA: 0x181D9E0 Offset: 0x181BFE0 VA: 0x18181D9E0
	public static void set_backgroundLoadingPriority(ThreadPriority value) { }

	[FreeFunctionAttribute] // RVA: 0x72460 Offset: 0x71860 VA: 0x180072460
	// RVA: 0x181D830 Offset: 0x181BE30 VA: 0x18181D830
	public static RuntimePlatform get_platform() { }

	// RVA: 0x181D750 Offset: 0x181BD50 VA: 0x18181D750
	public static bool get_isMobilePlatform() { }

	[FreeFunctionAttribute] // RVA: 0x72530 Offset: 0x71930 VA: 0x180072530
	// RVA: 0x181D890 Offset: 0x181BE90 VA: 0x18181D890
	public static SystemLanguage get_systemLanguage() { }

	[FreeFunctionAttribute] // RVA: 0x73A40 Offset: 0x72E40 VA: 0x180073A40
	// RVA: 0x181D720 Offset: 0x181BD20 VA: 0x18181D720
	public static NetworkReachability get_internetReachability() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x181CFC0 Offset: 0x181B5C0 VA: 0x18181CFC0
	internal static void CallLowMemory() { }

	// RVA: 0x181D5E0 Offset: 0x181BBE0 VA: 0x18181D5E0
	public static void add_logMessageReceived(Application.LogCallback value) { }

	// RVA: 0x181D950 Offset: 0x181BF50 VA: 0x18181D950
	public static void remove_logMessageReceived(Application.LogCallback value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x181CF00 Offset: 0x181B500 VA: 0x18181CF00
	private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x181D270 Offset: 0x181B870 VA: 0x18181D270
	private static bool Internal_ApplicationWantsToQuit() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x181D220 Offset: 0x181B820 VA: 0x18181D220
	private static void Internal_ApplicationQuit() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x181D460 Offset: 0x181BA60 VA: 0x18181D460
	internal static void InvokeOnBeforeRender() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x181D400 Offset: 0x181BA00 VA: 0x18181D400
	internal static void InvokeFocusChanged(bool focus) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x181D3A0 Offset: 0x181B9A0 VA: 0x18181D3A0
	internal static void InvokeDeepLinkActivated(string url) { }

	// RVA: 0x181D7E0 Offset: 0x181BDE0 VA: 0x18181D7E0
	public static string get_loadedLevelName() { }

	// RVA: 0x48D660 Offset: 0x48BC60 VA: 0x18048D660
	public static bool get_isEditor() { }

}

public sealed class Application.LowMemoryCallback : MulticastDelegate // TypeDefIndex: 3355
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x49A1D0 Offset: 0x4987D0 VA: 0x18049A1D0 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x49A190 Offset: 0x498790 VA: 0x18049A190 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class Application.LogCallback : MulticastDelegate // TypeDefIndex: 3356
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1310770 Offset: 0x130ED70 VA: 0x181310770 Slot: 12
	public virtual void Invoke(string condition, string stackTrace, LogType type) { }

	// RVA: 0x1831F10 Offset: 0x1830510 VA: 0x181831F10 Slot: 13
	public virtual IAsyncResult BeginInvoke(string condition, string stackTrace, LogType type, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public struct AppId // TypeDefIndex: 5235
{	// Fields
	public uint Value; // 0x0

	// Methods

	// RVA: 0x1D7CC0 Offset: 0x1D70C0 VA: 0x1801D7CC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x68A6C0 Offset: 0x688CC0 VA: 0x18068A6C0
	public static AppId op_Implicit(uint value) { }

	// RVA: 0x68A6C0 Offset: 0x688CC0 VA: 0x18068A6C0
	public static AppId op_Implicit(int value) { }

	// RVA: 0x68A6C0 Offset: 0x688CC0 VA: 0x18068A6C0
	public static uint op_Implicit(AppId value) { }

}

internal struct AppResumingFromSuspend_t : ICallbackData // TypeDefIndex: 5333
{	// Fields
	public static int _datasize; // 0x13900

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E43F0 Offset: 0x1E37F0 VA: 0x1801E43F0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E43E0 Offset: 0x1E37E0 VA: 0x1801E43E0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136B090 Offset: 0x1369690 VA: 0x18136B090
	private static void .cctor() { }

}

internal struct AppProofOfPurchaseKeyResponse_t : ICallbackData // TypeDefIndex: 5401
{	// Fields
	internal Result Result; // 0x0
	internal uint AppID; // 0x4
	internal uint CchKeyLength; // 0x8
	internal byte[] Key; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E41F0 Offset: 0x1E35F0 VA: 0x1801E41F0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E41E0 Offset: 0x1E35E0 VA: 0x1801E41E0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136AFF0 Offset: 0x13695F0 VA: 0x18136AFF0
	private static void .cctor() { }

}

public static class Application // TypeDefIndex: 6176
{	// Fields
	private static MonoBehaviour _controller; // 0x0
	public static Manifest Manifest; // 0x8
	public static Dictionary<IPEndPoint, int> ServerMetadata; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static BaseIntegration <Integration>k__BackingField; // 0x18

	// Properties
	public static MonoBehaviour Controller { get; }
	public static BaseIntegration Integration { get; set; }

	// Methods

	// RVA: 0x14A9950 Offset: 0x14A7F50 VA: 0x1814A9950
	public static MonoBehaviour get_Controller() { }

	// RVA: 0x14A9640 Offset: 0x14A7C40 VA: 0x1814A9640
	public static void Initialize(BaseIntegration integration) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14A9A50 Offset: 0x14A8050 VA: 0x1814A9A50
	public static BaseIntegration get_Integration() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14A9A90 Offset: 0x14A8090 VA: 0x1814A9A90
	public static void set_Integration(BaseIntegration value) { }

}

internal class ApplicationControllerMonobehaviour : MonoBehaviour // TypeDefIndex: 6217
{	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void OnApplicationQuit() { }

	// RVA: 0x14A94A0 Offset: 0x14A7AA0 VA: 0x1814A94A0
	public void Update() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public struct AppInfo // TypeDefIndex: 6240
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Image>k__BackingField; // 0x0

	// Properties
	public int Version { get; }
	public BuildInfo Build { get; }
	public string Name { get; }
	public string Os { get; }
	public string Cpu { get; }
	public int CpuCount { get; }
	public int Mem { get; }
	public string Gpu { get; }
	public int GpuMem { get; }
	public string Arch { get; }
	public string UserId { get; }
	public string UserName { get; }
	public string ServerAddress { get; }
	public string ServerName { get; }
	public string LevelName { get; }
	public string LevelPos { get; }
	public string LevelRot { get; }
	public int MinutesPlayed { get; }
	public string Image { get; set; }

	// Methods

	// RVA: 0x1F0FC0 Offset: 0x1F03C0 VA: 0x1801F0FC0
	public int get_Version() { }

	// RVA: 0x1F0B90 Offset: 0x1EFF90 VA: 0x1801F0B90
	public BuildInfo get_Build() { }

	// RVA: 0x1F0E20 Offset: 0x1F0220 VA: 0x1801F0E20
	public string get_Name() { }

	// RVA: 0x1F0E30 Offset: 0x1F0230 VA: 0x1801F0E30
	public string get_Os() { }

	// RVA: 0x1F0BB0 Offset: 0x1EFFB0 VA: 0x1801F0BB0
	public string get_Cpu() { }

	// RVA: 0x1F0BA0 Offset: 0x1EFFA0 VA: 0x1801F0BA0
	public int get_CpuCount() { }

	// RVA: 0x1F0BC0 Offset: 0x1EFFC0 VA: 0x1801F0BC0
	public int get_Mem() { }

	// RVA: 0x1F0BD0 Offset: 0x1EFFD0 VA: 0x1801F0BD0
	public string get_Gpu() { }

	// RVA: 0x1F0BC0 Offset: 0x1EFFC0 VA: 0x1801F0BC0
	public int get_GpuMem() { }

	// RVA: 0x1F0B50 Offset: 0x1EFF50 VA: 0x1801F0B50
	public string get_Arch() { }

	// RVA: 0x1F0F00 Offset: 0x1F0300 VA: 0x1801F0F00
	public string get_UserId() { }

	// RVA: 0x1F0F60 Offset: 0x1F0360 VA: 0x1801F0F60
	public string get_UserName() { }

	// RVA: 0x1F0E40 Offset: 0x1F0240 VA: 0x1801F0E40
	public string get_ServerAddress() { }

	// RVA: 0x1F0EA0 Offset: 0x1F02A0 VA: 0x1801F0EA0
	public string get_ServerName() { }

	// RVA: 0x1F0BE0 Offset: 0x1EFFE0 VA: 0x1801F0BE0
	public string get_LevelName() { }

	// RVA: 0x1F0C40 Offset: 0x1F0040 VA: 0x1801F0C40
	public string get_LevelPos() { }

	// RVA: 0x1F0D00 Offset: 0x1F0100 VA: 0x1801F0D00
	public string get_LevelRot() { }

	// RVA: 0x1F0DC0 Offset: 0x1F01C0 VA: 0x1801F0DC0
	public int get_MinutesPlayed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	public string get_Image() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF1490 Offset: 0xF0890 VA: 0x1800F1490
	public void set_Image(string value) { }

}

public class Approval : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6476
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string level; // 0x18
	public string hostname; // 0x20
	public bool modded; // 0x28
	public bool official; // 0x29
	public ulong steamid; // 0x30
	public uint ipaddress; // 0x38
	public int port; // 0x3C
	public uint levelSeed; // 0x40
	public uint levelSize; // 0x44
	public string checksum; // 0x48
	public uint encryption; // 0x50
	public string levelUrl; // 0x58
	public bool levelTransfer; // 0x60

	// Methods

	// RVA: 0x1E25350 Offset: 0x1E23950 VA: 0x181E25350
	public static void ResetToPool(Approval instance) { }

	// RVA: 0x1E25190 Offset: 0x1E23790 VA: 0x181E25190
	public void ResetToPool() { }

	// RVA: 0x1E24F20 Offset: 0x1E23520 VA: 0x181E24F20 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E23A80 Offset: 0x1E22080 VA: 0x181E23A80
	public void CopyTo(Approval instance) { }

	// RVA: 0x1E23B30 Offset: 0x1E22130 VA: 0x181E23B30
	public Approval Copy() { }

	// RVA: 0x1E248F0 Offset: 0x1E22EF0 VA: 0x181E248F0
	public static Approval Deserialize(Stream stream) { }

	// RVA: 0x1E23C20 Offset: 0x1E22220 VA: 0x181E23C20
	public static Approval DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E24210 Offset: 0x1E22810 VA: 0x181E24210
	public static Approval DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E24E00 Offset: 0x1E23400 VA: 0x181E24E00
	public static Approval Deserialize(byte[] buffer) { }

	// RVA: 0x1E25150 Offset: 0x1E23750 VA: 0x181E25150
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E25FC0 Offset: 0x1E245C0 VA: 0x181E25FC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E25FE0 Offset: 0x1E245E0 VA: 0x181E25FE0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Approval previous) { }

	// RVA: 0x1E25170 Offset: 0x1E23770 VA: 0x181E25170 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E247F0 Offset: 0x1E22DF0 VA: 0x181E247F0
	public static Approval Deserialize(byte[] buffer, Approval instance, bool isDelta = False) { }

	// RVA: 0x1E24970 Offset: 0x1E22F70 VA: 0x181E24970
	public static Approval Deserialize(Stream stream, Approval instance, bool isDelta) { }

	// RVA: 0x1E23CA0 Offset: 0x1E222A0 VA: 0x181E23CA0
	public static Approval DeserializeLengthDelimited(Stream stream, Approval instance, bool isDelta) { }

	// RVA: 0x1E242A0 Offset: 0x1E228A0 VA: 0x181E242A0
	public static Approval DeserializeLength(Stream stream, int length, Approval instance, bool isDelta) { }

	// RVA: 0x1E25510 Offset: 0x1E23B10 VA: 0x181E25510
	public static void SerializeDelta(Stream stream, Approval instance, Approval previous) { }

	// RVA: 0x1E25BE0 Offset: 0x1E241E0 VA: 0x181E25BE0
	public static void Serialize(Stream stream, Approval instance) { }

	// RVA: 0x1E25FB0 Offset: 0x1E245B0 VA: 0x181E25FB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E25FC0 Offset: 0x1E245C0 VA: 0x181E25FC0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E25AD0 Offset: 0x1E240D0 VA: 0x181E25AD0
	public static byte[] SerializeToBytes(Approval instance) { }

	// RVA: 0x1E25A20 Offset: 0x1E24020 VA: 0x181E25A20
	public static void SerializeLengthDelimited(Stream stream, Approval instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class AppRequest : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6511
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint seq; // 0x14
	public ulong playerId; // 0x18
	public int playerToken; // 0x20
	public uint entityId; // 0x24
	public AppEmpty getInfo; // 0x28
	public AppEmpty getTime; // 0x30
	public AppEmpty getMap; // 0x38
	public AppEmpty getTeamInfo; // 0x40
	public AppEmpty getTeamChat; // 0x48
	public AppSendMessage sendTeamMessage; // 0x50
	public AppEmpty getEntityInfo; // 0x58
	public AppSetEntityValue setEntityValue; // 0x60
	public AppEmpty checkSubscription; // 0x68
	public AppFlag setSubscription; // 0x70
	public AppEmpty getMapMarkers; // 0x78
	public AppPromoteToLeader promoteToLeader; // 0x80

	// Methods

	// RVA: 0x1E13200 Offset: 0x1E11800 VA: 0x181E13200
	public static void ResetToPool(AppRequest instance) { }

	// RVA: 0x1E12EB0 Offset: 0x1E114B0 VA: 0x181E12EB0
	public void ResetToPool() { }

	// RVA: 0x1E12DF0 Offset: 0x1E113F0 VA: 0x181E12DF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E11330 Offset: 0x1E0F930 VA: 0x181E11330
	public void CopyTo(AppRequest instance) { }

	// RVA: 0x1E11700 Offset: 0x1E0FD00 VA: 0x181E11700
	public AppRequest Copy() { }

	// RVA: 0x1E12B50 Offset: 0x1E11150 VA: 0x181E12B50
	public static AppRequest Deserialize(Stream stream) { }

	// RVA: 0x1E11E10 Offset: 0x1E10410 VA: 0x181E11E10
	public static AppRequest DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E12500 Offset: 0x1E10B00 VA: 0x181E12500
	public static AppRequest DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E12CD0 Offset: 0x1E112D0 VA: 0x181E12CD0
	public static AppRequest Deserialize(byte[] buffer) { }

	// RVA: 0x1E12E70 Offset: 0x1E11470 VA: 0x181E12E70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E151B0 Offset: 0x1E137B0 VA: 0x181E151B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E151D0 Offset: 0x1E137D0 VA: 0x181E151D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppRequest previous) { }

	// RVA: 0x1E12E90 Offset: 0x1E11490 VA: 0x181E12E90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E12BD0 Offset: 0x1E111D0 VA: 0x181E12BD0
	public static AppRequest Deserialize(byte[] buffer, AppRequest instance, bool isDelta = False) { }

	// RVA: 0x1E12590 Offset: 0x1E10B90 VA: 0x181E12590
	public static AppRequest Deserialize(Stream stream, AppRequest instance, bool isDelta) { }

	// RVA: 0x1E11780 Offset: 0x1E0FD80 VA: 0x181E11780
	public static AppRequest DeserializeLengthDelimited(Stream stream, AppRequest instance, bool isDelta) { }

	// RVA: 0x1E11E90 Offset: 0x1E10490 VA: 0x181E11E90
	public static AppRequest DeserializeLength(Stream stream, int length, AppRequest instance, bool isDelta) { }

	// RVA: 0x1E13550 Offset: 0x1E11B50 VA: 0x181E13550
	public static void SerializeDelta(Stream stream, AppRequest instance, AppRequest previous) { }

	// RVA: 0x1E14500 Offset: 0x1E12B00 VA: 0x181E14500
	public static void Serialize(Stream stream, AppRequest instance) { }

	// RVA: 0x1E151A0 Offset: 0x1E137A0 VA: 0x181E151A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E151B0 Offset: 0x1E137B0 VA: 0x181E151B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E143F0 Offset: 0x1E129F0 VA: 0x181E143F0
	public static byte[] SerializeToBytes(AppRequest instance) { }

	// RVA: 0x1E14340 Offset: 0x1E12940 VA: 0x181E14340
	public static void SerializeLengthDelimited(Stream stream, AppRequest instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class AppMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6512
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public AppResponse response; // 0x18
	public AppBroadcast broadcast; // 0x20

	// Methods

	// RVA: 0x2092770 Offset: 0x2090D70 VA: 0x182092770
	public static void ResetToPool(AppMessage instance) { }

	// RVA: 0x2092850 Offset: 0x2090E50 VA: 0x182092850
	public void ResetToPool() { }

	// RVA: 0x20925D0 Offset: 0x2090BD0 VA: 0x1820925D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20919E0 Offset: 0x208FFE0 VA: 0x1820919E0
	public void CopyTo(AppMessage instance) { }

	// RVA: 0x2091AA0 Offset: 0x20900A0 VA: 0x182091AA0
	public AppMessage Copy() { }

	// RVA: 0x2092550 Offset: 0x2090B50 VA: 0x182092550
	public static AppMessage Deserialize(Stream stream) { }

	// RVA: 0x2091BB0 Offset: 0x20901B0 VA: 0x182091BB0
	public static AppMessage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2092100 Offset: 0x2090700 VA: 0x182092100
	public static AppMessage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2092190 Offset: 0x2090790 VA: 0x182092190
	public static AppMessage Deserialize(byte[] buffer) { }

	// RVA: 0x2092730 Offset: 0x2090D30 VA: 0x182092730
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2093010 Offset: 0x2091610 VA: 0x182093010 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2093030 Offset: 0x2091630 VA: 0x182093030 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppMessage previous) { }

	// RVA: 0x2092750 Offset: 0x2090D50 VA: 0x182092750 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2092450 Offset: 0x2090A50 VA: 0x182092450
	public static AppMessage Deserialize(byte[] buffer, AppMessage instance, bool isDelta = False) { }

	// RVA: 0x20922B0 Offset: 0x20908B0 VA: 0x1820922B0
	public static AppMessage Deserialize(Stream stream, AppMessage instance, bool isDelta) { }

	// RVA: 0x2091C30 Offset: 0x2090230 VA: 0x182091C30
	public static AppMessage DeserializeLengthDelimited(Stream stream, AppMessage instance, bool isDelta) { }

	// RVA: 0x2091EB0 Offset: 0x20904B0 VA: 0x182091EB0
	public static AppMessage DeserializeLength(Stream stream, int length, AppMessage instance, bool isDelta) { }

	// RVA: 0x2092930 Offset: 0x2090F30 VA: 0x182092930
	public static void SerializeDelta(Stream stream, AppMessage instance, AppMessage previous) { }

	// RVA: 0x2092D90 Offset: 0x2091390 VA: 0x182092D90
	public static void Serialize(Stream stream, AppMessage instance) { }

	// RVA: 0x2093000 Offset: 0x2091600 VA: 0x182093000
	public byte[] ToProtoBytes() { }

	// RVA: 0x2093010 Offset: 0x2091610 VA: 0x182093010
	public void ToProto(Stream stream) { }

	// RVA: 0x2092C80 Offset: 0x2091280 VA: 0x182092C80
	public static byte[] SerializeToBytes(AppMessage instance) { }

	// RVA: 0x2092BD0 Offset: 0x20911D0 VA: 0x182092BD0
	public static void SerializeLengthDelimited(Stream stream, AppMessage instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class AppResponse : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6513
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint seq; // 0x14
	public AppSuccess success; // 0x18
	public AppError error; // 0x20
	public AppInfo info; // 0x28
	public AppTime time; // 0x30
	public AppMap map; // 0x38
	public AppTeamInfo teamInfo; // 0x40
	public AppTeamChat teamChat; // 0x48
	public AppEntityInfo entityInfo; // 0x50
	public AppFlag flag; // 0x58
	public AppMapMarkers mapMarkers; // 0x60

	// Methods

	// RVA: 0x1E16B50 Offset: 0x1E15150 VA: 0x181E16B50
	public static void ResetToPool(AppResponse instance) { }

	// RVA: 0x1E16890 Offset: 0x1E14E90 VA: 0x181E16890
	public void ResetToPool() { }

	// RVA: 0x1E167D0 Offset: 0x1E14DD0 VA: 0x181E167D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E151F0 Offset: 0x1E137F0 VA: 0x181E151F0
	public void CopyTo(AppResponse instance) { }

	// RVA: 0x1E15580 Offset: 0x1E13B80 VA: 0x181E15580
	public AppResponse Copy() { }

	// RVA: 0x1E16650 Offset: 0x1E14C50 VA: 0x181E16650
	public static AppResponse Deserialize(Stream stream) { }

	// RVA: 0x1E15B10 Offset: 0x1E14110 VA: 0x181E15B10
	public static AppResponse DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E16070 Offset: 0x1E14670 VA: 0x181E16070
	public static AppResponse DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E16100 Offset: 0x1E14700 VA: 0x181E16100
	public static AppResponse Deserialize(byte[] buffer) { }

	// RVA: 0x1E16850 Offset: 0x1E14E50 VA: 0x181E16850
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E183E0 Offset: 0x1E169E0 VA: 0x181E183E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E18400 Offset: 0x1E16A00 VA: 0x181E18400 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppResponse previous) { }

	// RVA: 0x1E16870 Offset: 0x1E14E70 VA: 0x181E16870 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E166D0 Offset: 0x1E14CD0 VA: 0x181E166D0
	public static AppResponse Deserialize(byte[] buffer, AppResponse instance, bool isDelta = False) { }

	// RVA: 0x1E16220 Offset: 0x1E14820 VA: 0x181E16220
	public static AppResponse Deserialize(Stream stream, AppResponse instance, bool isDelta) { }

	// RVA: 0x1E15600 Offset: 0x1E13C00 VA: 0x181E15600
	public static AppResponse DeserializeLengthDelimited(Stream stream, AppResponse instance, bool isDelta) { }

	// RVA: 0x1E15B90 Offset: 0x1E14190 VA: 0x181E15B90
	public static AppResponse DeserializeLength(Stream stream, int length, AppResponse instance, bool isDelta) { }

	// RVA: 0x1E16E10 Offset: 0x1E15410 VA: 0x181E16E10
	public static void SerializeDelta(Stream stream, AppResponse instance, AppResponse previous) { }

	// RVA: 0x1E17A20 Offset: 0x1E16020 VA: 0x181E17A20
	public static void Serialize(Stream stream, AppResponse instance) { }

	// RVA: 0x1E183D0 Offset: 0x1E169D0 VA: 0x181E183D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E183E0 Offset: 0x1E169E0 VA: 0x181E183E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E17910 Offset: 0x1E15F10 VA: 0x181E17910
	public static byte[] SerializeToBytes(AppResponse instance) { }

	// RVA: 0x1E17860 Offset: 0x1E15E60 VA: 0x181E17860
	public static void SerializeLengthDelimited(Stream stream, AppResponse instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class AppBroadcast : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6514
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public AppTeamChanged teamChanged; // 0x18
	public AppTeamMessage teamMessage; // 0x20
	public AppEntityChanged entityChanged; // 0x28

	// Methods

	// RVA: 0x2015E30 Offset: 0x2014430 VA: 0x182015E30
	public static void ResetToPool(AppBroadcast instance) { }

	// RVA: 0x2015D10 Offset: 0x2014310 VA: 0x182015D10
	public void ResetToPool() { }

	// RVA: 0x2015970 Offset: 0x2013F70 VA: 0x182015970 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2014760 Offset: 0x2012D60 VA: 0x182014760
	public void CopyTo(AppBroadcast instance) { }

	// RVA: 0x2014860 Offset: 0x2012E60 VA: 0x182014860
	public AppBroadcast Copy() { }

	// RVA: 0x2015000 Offset: 0x2013600 VA: 0x182015000
	public static AppBroadcast Deserialize(Stream stream) { }

	// RVA: 0x2014C60 Offset: 0x2013260 VA: 0x182014C60
	public static AppBroadcast DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2014CE0 Offset: 0x20132E0 VA: 0x182014CE0
	public static AppBroadcast DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2015400 Offset: 0x2013A00 VA: 0x182015400
	public static AppBroadcast Deserialize(byte[] buffer) { }

	// RVA: 0x2015B10 Offset: 0x2014110 VA: 0x182015B10
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2016810 Offset: 0x2014E10 VA: 0x182016810 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2016830 Offset: 0x2014E30 VA: 0x182016830 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppBroadcast previous) { }

	// RVA: 0x2015CF0 Offset: 0x20142F0 VA: 0x182015CF0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20156D0 Offset: 0x2013CD0 VA: 0x1820156D0
	public static AppBroadcast Deserialize(byte[] buffer, AppBroadcast instance, bool isDelta = False) { }

	// RVA: 0x2015220 Offset: 0x2013820 VA: 0x182015220
	public static AppBroadcast Deserialize(Stream stream, AppBroadcast instance, bool isDelta) { }

	// RVA: 0x20149A0 Offset: 0x2012FA0 VA: 0x1820149A0
	public static AppBroadcast DeserializeLengthDelimited(Stream stream, AppBroadcast instance, bool isDelta) { }

	// RVA: 0x2014D70 Offset: 0x2013370 VA: 0x182014D70
	public static AppBroadcast DeserializeLength(Stream stream, int length, AppBroadcast instance, bool isDelta) { }

	// RVA: 0x2015F50 Offset: 0x2014550 VA: 0x182015F50
	public static void SerializeDelta(Stream stream, AppBroadcast instance, AppBroadcast previous) { }

	// RVA: 0x20164A0 Offset: 0x2014AA0 VA: 0x1820164A0
	public static void Serialize(Stream stream, AppBroadcast instance) { }

	// RVA: 0x2016800 Offset: 0x2014E00 VA: 0x182016800
	public byte[] ToProtoBytes() { }

	// RVA: 0x2016810 Offset: 0x2014E10 VA: 0x182016810
	public void ToProto(Stream stream) { }

	// RVA: 0x2016390 Offset: 0x2014990 VA: 0x182016390
	public static byte[] SerializeToBytes(AppBroadcast instance) { }

	// RVA: 0x20162E0 Offset: 0x20148E0 VA: 0x1820162E0
	public static void SerializeLengthDelimited(Stream stream, AppBroadcast instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class AppEmpty : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6515
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11

	// Methods

	// RVA: 0x2080760 Offset: 0x207ED60 VA: 0x182080760
	public static void ResetToPool(AppEmpty instance) { }

	// RVA: 0x20807D0 Offset: 0x207EDD0 VA: 0x1820807D0
	public void ResetToPool() { }

	// RVA: 0x2080640 Offset: 0x207EC40 VA: 0x182080640 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void CopyTo(AppEmpty instance) { }

	// RVA: 0x207FD90 Offset: 0x207E390 VA: 0x18207FD90
	public AppEmpty Copy() { }

	// RVA: 0x20805C0 Offset: 0x207EBC0 VA: 0x1820805C0
	public static AppEmpty Deserialize(Stream stream) { }

	// RVA: 0x207FFC0 Offset: 0x207E5C0 VA: 0x18207FFC0
	public static AppEmpty DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2080200 Offset: 0x207E800 VA: 0x182080200
	public static AppEmpty DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2080290 Offset: 0x207E890 VA: 0x182080290
	public static AppEmpty Deserialize(byte[] buffer) { }

	// RVA: 0x2080720 Offset: 0x207ED20 VA: 0x182080720
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2080B20 Offset: 0x207F120 VA: 0x182080B20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2080B90 Offset: 0x207F190 VA: 0x182080B90 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppEmpty previous) { }

	// RVA: 0x2080740 Offset: 0x207ED40 VA: 0x182080740 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20804C0 Offset: 0x207EAC0 VA: 0x1820804C0
	public static AppEmpty Deserialize(byte[] buffer, AppEmpty instance, bool isDelta = False) { }

	// RVA: 0x20803B0 Offset: 0x207E9B0 VA: 0x1820803B0
	public static AppEmpty Deserialize(Stream stream, AppEmpty instance, bool isDelta) { }

	// RVA: 0x207FDE0 Offset: 0x207E3E0 VA: 0x18207FDE0
	public static AppEmpty DeserializeLengthDelimited(Stream stream, AppEmpty instance, bool isDelta) { }

	// RVA: 0x2080040 Offset: 0x207E640 VA: 0x182080040
	public static AppEmpty DeserializeLength(Stream stream, int length, AppEmpty instance, bool isDelta) { }

	// RVA: 0x2080840 Offset: 0x207EE40 VA: 0x182080840
	public static void SerializeDelta(Stream stream, AppEmpty instance, AppEmpty previous) { }

	// RVA: 0x2080AB0 Offset: 0x207F0B0 VA: 0x182080AB0
	public static void Serialize(Stream stream, AppEmpty instance) { }

	// RVA: 0x2080B10 Offset: 0x207F110 VA: 0x182080B10
	public byte[] ToProtoBytes() { }

	// RVA: 0x2080B20 Offset: 0x207F120 VA: 0x182080B20
	public void ToProto(Stream stream) { }

	// RVA: 0x2080950 Offset: 0x207EF50 VA: 0x182080950
	public static byte[] SerializeToBytes(AppEmpty instance) { }

	// RVA: 0x20808A0 Offset: 0x207EEA0 VA: 0x1820808A0
	public static void SerializeLengthDelimited(Stream stream, AppEmpty instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class AppSendMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6516
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string message; // 0x18

	// Methods

	// RVA: 0x1E18E80 Offset: 0x1E17480 VA: 0x181E18E80
	public static void ResetToPool(AppSendMessage instance) { }

	// RVA: 0x1E18F10 Offset: 0x1E17510 VA: 0x181E18F10
	public void ResetToPool() { }

	// RVA: 0x1E18DC0 Offset: 0x1E173C0 VA: 0x181E18DC0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D67E50 Offset: 0x1D66450 VA: 0x181D67E50
	public void CopyTo(AppSendMessage instance) { }

	// RVA: 0x1E18420 Offset: 0x1E16A20 VA: 0x181E18420
	public AppSendMessage Copy() { }

	// RVA: 0x1E18AD0 Offset: 0x1E170D0 VA: 0x181E18AD0
	public static AppSendMessage Deserialize(Stream stream) { }

	// RVA: 0x1E186C0 Offset: 0x1E16CC0 VA: 0x181E186C0
	public static AppSendMessage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E18740 Offset: 0x1E16D40 VA: 0x181E18740
	public static AppSendMessage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E18B50 Offset: 0x1E17150 VA: 0x181E18B50
	public static AppSendMessage Deserialize(byte[] buffer) { }

	// RVA: 0x1E18E40 Offset: 0x1E17440 VA: 0x181E18E40
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E19400 Offset: 0x1E17A00 VA: 0x181E19400 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E19420 Offset: 0x1E17A20 VA: 0x181E19420 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppSendMessage previous) { }

	// RVA: 0x1E18E60 Offset: 0x1E17460 VA: 0x181E18E60 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E189D0 Offset: 0x1E16FD0 VA: 0x181E189D0
	public static AppSendMessage Deserialize(byte[] buffer, AppSendMessage instance, bool isDelta = False) { }

	// RVA: 0x1E18C70 Offset: 0x1E17270 VA: 0x181E18C70
	public static AppSendMessage Deserialize(Stream stream, AppSendMessage instance, bool isDelta) { }

	// RVA: 0x1E184A0 Offset: 0x1E16AA0 VA: 0x181E184A0
	public static AppSendMessage DeserializeLengthDelimited(Stream stream, AppSendMessage instance, bool isDelta) { }

	// RVA: 0x1E187D0 Offset: 0x1E16DD0 VA: 0x181E187D0
	public static AppSendMessage DeserializeLength(Stream stream, int length, AppSendMessage instance, bool isDelta) { }

	// RVA: 0x1E18FA0 Offset: 0x1E175A0 VA: 0x181E18FA0
	public static void SerializeDelta(Stream stream, AppSendMessage instance, AppSendMessage previous) { }

	// RVA: 0x1E192C0 Offset: 0x1E178C0 VA: 0x181E192C0
	public static void Serialize(Stream stream, AppSendMessage instance) { }

	// RVA: 0x1E193F0 Offset: 0x1E179F0 VA: 0x181E193F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E19400 Offset: 0x1E17A00 VA: 0x181E19400
	public void ToProto(Stream stream) { }

	// RVA: 0x1E191B0 Offset: 0x1E177B0 VA: 0x181E191B0
	public static byte[] SerializeToBytes(AppSendMessage instance) { }

	// RVA: 0x1E19100 Offset: 0x1E17700 VA: 0x181E19100
	public static void SerializeLengthDelimited(Stream stream, AppSendMessage instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class AppSetEntityValue : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6517
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public bool value; // 0x12

	// Methods

	// RVA: 0x1E19EA0 Offset: 0x1E184A0 VA: 0x181E19EA0
	public static void ResetToPool(AppSetEntityValue instance) { }

	// RVA: 0x1E19F20 Offset: 0x1E18520 VA: 0x181E19F20
	public void ResetToPool() { }

	// RVA: 0x1E19DE0 Offset: 0x1E183E0 VA: 0x181E19DE0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E19440 Offset: 0x1E17A40 VA: 0x181E19440
	public void CopyTo(AppSetEntityValue instance) { }

	// RVA: 0x1E19460 Offset: 0x1E17A60 VA: 0x181E19460
	public AppSetEntityValue Copy() { }

	// RVA: 0x1E19C60 Offset: 0x1E18260 VA: 0x181E19C60
	public static AppSetEntityValue Deserialize(Stream stream) { }

	// RVA: 0x1E194D0 Offset: 0x1E17AD0 VA: 0x181E194D0
	public static AppSetEntityValue DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E19970 Offset: 0x1E17F70 VA: 0x181E19970
	public static AppSetEntityValue DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E19B40 Offset: 0x1E18140 VA: 0x181E19B40
	public static AppSetEntityValue Deserialize(byte[] buffer) { }

	// RVA: 0x1E19E60 Offset: 0x1E18460 VA: 0x181E19E60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E1A3B0 Offset: 0x1E189B0 VA: 0x181E1A3B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E1A480 Offset: 0x1E18A80 VA: 0x181E1A480 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppSetEntityValue previous) { }

	// RVA: 0x1E19E80 Offset: 0x1E18480 VA: 0x181E19E80 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E19CE0 Offset: 0x1E182E0 VA: 0x181E19CE0
	public static AppSetEntityValue Deserialize(byte[] buffer, AppSetEntityValue instance, bool isDelta = False) { }

	// RVA: 0x1E19A00 Offset: 0x1E18000 VA: 0x181E19A00
	public static AppSetEntityValue Deserialize(Stream stream, AppSetEntityValue instance, bool isDelta) { }

	// RVA: 0x1E19550 Offset: 0x1E17B50 VA: 0x181E19550
	public static AppSetEntityValue DeserializeLengthDelimited(Stream stream, AppSetEntityValue instance, bool isDelta) { }

	// RVA: 0x1E19770 Offset: 0x1E17D70 VA: 0x181E19770
	public static AppSetEntityValue DeserializeLength(Stream stream, int length, AppSetEntityValue instance, bool isDelta) { }

	// RVA: 0x1E19FA0 Offset: 0x1E185A0 VA: 0x181E19FA0
	public static void SerializeDelta(Stream stream, AppSetEntityValue instance, AppSetEntityValue previous) { }

	// RVA: 0x1E1A2D0 Offset: 0x1E188D0 VA: 0x181E1A2D0
	public static void Serialize(Stream stream, AppSetEntityValue instance) { }

	// RVA: 0x1E1A3A0 Offset: 0x1E189A0 VA: 0x181E1A3A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E1A3B0 Offset: 0x1E189B0 VA: 0x181E1A3B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E1A120 Offset: 0x1E18720 VA: 0x181E1A120
	public static byte[] SerializeToBytes(AppSetEntityValue instance) { }

	// RVA: 0x1E1A070 Offset: 0x1E18670 VA: 0x181E1A070
	public static void SerializeLengthDelimited(Stream stream, AppSetEntityValue instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class AppPromoteToLeader : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6518
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong steamId; // 0x18

	// Methods

	// RVA: 0x2093B80 Offset: 0x2092180 VA: 0x182093B80
	public static void ResetToPool(AppPromoteToLeader instance) { }

	// RVA: 0x2093B00 Offset: 0x2092100 VA: 0x182093B00
	public void ResetToPool() { }

	// RVA: 0x20939D0 Offset: 0x2091FD0 VA: 0x1820939D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F1CCB0 Offset: 0x1F1B2B0 VA: 0x181F1CCB0
	public void CopyTo(AppPromoteToLeader instance) { }

	// RVA: 0x2093050 Offset: 0x2091650 VA: 0x182093050
	public AppPromoteToLeader Copy() { }

	// RVA: 0x2093850 Offset: 0x2091E50 VA: 0x182093850
	public static AppPromoteToLeader Deserialize(Stream stream) { }

	// RVA: 0x20930C0 Offset: 0x20916C0 VA: 0x1820930C0
	public static AppPromoteToLeader DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2093360 Offset: 0x2091960 VA: 0x182093360
	public static AppPromoteToLeader DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2093730 Offset: 0x2091D30 VA: 0x182093730
	public static AppPromoteToLeader Deserialize(byte[] buffer) { }

	// RVA: 0x2093AC0 Offset: 0x20920C0 VA: 0x182093AC0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2094050 Offset: 0x2092650 VA: 0x182094050 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2094120 Offset: 0x2092720 VA: 0x182094120 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppPromoteToLeader previous) { }

	// RVA: 0x2093AE0 Offset: 0x20920E0 VA: 0x182093AE0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20938D0 Offset: 0x2091ED0 VA: 0x1820938D0
	public static AppPromoteToLeader Deserialize(byte[] buffer, AppPromoteToLeader instance, bool isDelta = False) { }

	// RVA: 0x20935F0 Offset: 0x2091BF0 VA: 0x1820935F0
	public static AppPromoteToLeader Deserialize(Stream stream, AppPromoteToLeader instance, bool isDelta) { }

	// RVA: 0x2093140 Offset: 0x2091740 VA: 0x182093140
	public static AppPromoteToLeader DeserializeLengthDelimited(Stream stream, AppPromoteToLeader instance, bool isDelta) { }

	// RVA: 0x20933F0 Offset: 0x20919F0 VA: 0x1820933F0
	public static AppPromoteToLeader DeserializeLength(Stream stream, int length, AppPromoteToLeader instance, bool isDelta) { }

	// RVA: 0x2093C00 Offset: 0x2092200 VA: 0x182093C00
	public static void SerializeDelta(Stream stream, AppPromoteToLeader instance, AppPromoteToLeader previous) { }

	// RVA: 0x2093F70 Offset: 0x2092570 VA: 0x182093F70
	public static void Serialize(Stream stream, AppPromoteToLeader instance) { }

	// RVA: 0x2094040 Offset: 0x2092640 VA: 0x182094040
	public byte[] ToProtoBytes() { }

	// RVA: 0x2094050 Offset: 0x2092650 VA: 0x182094050
	public void ToProto(Stream stream) { }

	// RVA: 0x2093DC0 Offset: 0x20923C0 VA: 0x182093DC0
	public static byte[] SerializeToBytes(AppPromoteToLeader instance) { }

	// RVA: 0x2093D10 Offset: 0x2092310 VA: 0x182093D10
	public static void SerializeLengthDelimited(Stream stream, AppPromoteToLeader instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class AppSuccess : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6519
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11

	// Methods

	// RVA: 0x1E1AFB0 Offset: 0x1E195B0 VA: 0x181E1AFB0
	public static void ResetToPool(AppSuccess instance) { }

	// RVA: 0x1E1AF40 Offset: 0x1E19540 VA: 0x181E1AF40
	public void ResetToPool() { }

	// RVA: 0x1E1AE80 Offset: 0x1E19480 VA: 0x181E1AE80 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void CopyTo(AppSuccess instance) { }

	// RVA: 0x1E1A5D0 Offset: 0x1E18BD0 VA: 0x181E1A5D0
	public AppSuccess Copy() { }

	// RVA: 0x1E1AD00 Offset: 0x1E19300 VA: 0x181E1AD00
	public static AppSuccess Deserialize(Stream stream) { }

	// RVA: 0x1E1A800 Offset: 0x1E18E00 VA: 0x181E1A800
	public static AppSuccess DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E1AA40 Offset: 0x1E19040 VA: 0x181E1AA40
	public static AppSuccess DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E1ABE0 Offset: 0x1E191E0 VA: 0x181E1ABE0
	public static AppSuccess Deserialize(byte[] buffer) { }

	// RVA: 0x1E1AF00 Offset: 0x1E19500 VA: 0x181E1AF00
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E1B300 Offset: 0x1E19900 VA: 0x181E1B300 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E1B370 Offset: 0x1E19970 VA: 0x181E1B370 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppSuccess previous) { }

	// RVA: 0x1E1AF20 Offset: 0x1E19520 VA: 0x181E1AF20 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E1AD80 Offset: 0x1E19380 VA: 0x181E1AD80
	public static AppSuccess Deserialize(byte[] buffer, AppSuccess instance, bool isDelta = False) { }

	// RVA: 0x1E1AAD0 Offset: 0x1E190D0 VA: 0x181E1AAD0
	public static AppSuccess Deserialize(Stream stream, AppSuccess instance, bool isDelta) { }

	// RVA: 0x1E1A620 Offset: 0x1E18C20 VA: 0x181E1A620
	public static AppSuccess DeserializeLengthDelimited(Stream stream, AppSuccess instance, bool isDelta) { }

	// RVA: 0x1E1A880 Offset: 0x1E18E80 VA: 0x181E1A880
	public static AppSuccess DeserializeLength(Stream stream, int length, AppSuccess instance, bool isDelta) { }

	// RVA: 0x1E1B020 Offset: 0x1E19620 VA: 0x181E1B020
	public static void SerializeDelta(Stream stream, AppSuccess instance, AppSuccess previous) { }

	// RVA: 0x1E1B290 Offset: 0x1E19890 VA: 0x181E1B290
	public static void Serialize(Stream stream, AppSuccess instance) { }

	// RVA: 0x1E1B2F0 Offset: 0x1E198F0 VA: 0x181E1B2F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E1B300 Offset: 0x1E19900 VA: 0x181E1B300
	public void ToProto(Stream stream) { }

	// RVA: 0x1E1B130 Offset: 0x1E19730 VA: 0x181E1B130
	public static byte[] SerializeToBytes(AppSuccess instance) { }

	// RVA: 0x1E1B080 Offset: 0x1E19680 VA: 0x181E1B080
	public static void SerializeLengthDelimited(Stream stream, AppSuccess instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class AppError : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6520
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string error; // 0x18

	// Methods

	// RVA: 0x2086A30 Offset: 0x2085030 VA: 0x182086A30
	public static void ResetToPool(AppError instance) { }

	// RVA: 0x20869A0 Offset: 0x2084FA0 VA: 0x1820869A0
	public void ResetToPool() { }

	// RVA: 0x2086850 Offset: 0x2084E50 VA: 0x182086850 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D67E50 Offset: 0x1D66450 VA: 0x181D67E50
	public void CopyTo(AppError instance) { }

	// RVA: 0x2085EB0 Offset: 0x20844B0 VA: 0x182085EB0
	public AppError Copy() { }

	// RVA: 0x2086560 Offset: 0x2084B60 VA: 0x182086560
	public static AppError Deserialize(Stream stream) { }

	// RVA: 0x2085F30 Offset: 0x2084530 VA: 0x182085F30
	public static AppError DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20863D0 Offset: 0x20849D0 VA: 0x1820863D0
	public static AppError DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2086730 Offset: 0x2084D30 VA: 0x182086730
	public static AppError Deserialize(byte[] buffer) { }

	// RVA: 0x2086960 Offset: 0x2084F60 VA: 0x182086960
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2086F20 Offset: 0x2085520 VA: 0x182086F20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2086F40 Offset: 0x2085540 VA: 0x182086F40 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppError previous) { }

	// RVA: 0x2086980 Offset: 0x2084F80 VA: 0x182086980 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2086460 Offset: 0x2084A60 VA: 0x182086460
	public static AppError Deserialize(byte[] buffer, AppError instance, bool isDelta = False) { }

	// RVA: 0x20865E0 Offset: 0x2084BE0 VA: 0x1820865E0
	public static AppError Deserialize(Stream stream, AppError instance, bool isDelta) { }

	// RVA: 0x2085FB0 Offset: 0x20845B0 VA: 0x182085FB0
	public static AppError DeserializeLengthDelimited(Stream stream, AppError instance, bool isDelta) { }

	// RVA: 0x20861D0 Offset: 0x20847D0 VA: 0x1820861D0
	public static AppError DeserializeLength(Stream stream, int length, AppError instance, bool isDelta) { }

	// RVA: 0x2086AC0 Offset: 0x20850C0 VA: 0x182086AC0
	public static void SerializeDelta(Stream stream, AppError instance, AppError previous) { }

	// RVA: 0x2086DE0 Offset: 0x20853E0 VA: 0x182086DE0
	public static void Serialize(Stream stream, AppError instance) { }

	// RVA: 0x2086F10 Offset: 0x2085510 VA: 0x182086F10
	public byte[] ToProtoBytes() { }

	// RVA: 0x2086F20 Offset: 0x2085520 VA: 0x182086F20
	public void ToProto(Stream stream) { }

	// RVA: 0x2086CD0 Offset: 0x20852D0 VA: 0x182086CD0
	public static byte[] SerializeToBytes(AppError instance) { }

	// RVA: 0x2086C20 Offset: 0x2085220 VA: 0x182086C20
	public static void SerializeLengthDelimited(Stream stream, AppError instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class AppFlag : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6521
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public bool value; // 0x12

	// Methods

	// RVA: 0x2087B70 Offset: 0x2086170 VA: 0x182087B70
	public static void ResetToPool(AppFlag instance) { }

	// RVA: 0x2087BF0 Offset: 0x20861F0 VA: 0x182087BF0
	public void ResetToPool() { }

	// RVA: 0x2087A40 Offset: 0x2086040 VA: 0x182087A40 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E19440 Offset: 0x1E17A40 VA: 0x181E19440
	public void CopyTo(AppFlag instance) { }

	// RVA: 0x20870C0 Offset: 0x20856C0 VA: 0x1820870C0
	public AppFlag Copy() { }

	// RVA: 0x20879C0 Offset: 0x2085FC0 VA: 0x1820879C0
	public static AppFlag Deserialize(Stream stream) { }

	// RVA: 0x2087350 Offset: 0x2085950 VA: 0x182087350
	public static AppFlag DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20873D0 Offset: 0x20859D0 VA: 0x1820873D0
	public static AppFlag DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2087660 Offset: 0x2085C60 VA: 0x182087660
	public static AppFlag Deserialize(byte[] buffer) { }

	// RVA: 0x2087B30 Offset: 0x2086130 VA: 0x182087B30
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2088080 Offset: 0x2086680 VA: 0x182088080 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2088150 Offset: 0x2086750 VA: 0x182088150 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppFlag previous) { }

	// RVA: 0x2087B50 Offset: 0x2086150 VA: 0x182087B50 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2087780 Offset: 0x2085D80 VA: 0x182087780
	public static AppFlag Deserialize(byte[] buffer, AppFlag instance, bool isDelta = False) { }

	// RVA: 0x2087880 Offset: 0x2085E80 VA: 0x182087880
	public static AppFlag Deserialize(Stream stream, AppFlag instance, bool isDelta) { }

	// RVA: 0x2087130 Offset: 0x2085730 VA: 0x182087130
	public static AppFlag DeserializeLengthDelimited(Stream stream, AppFlag instance, bool isDelta) { }

	// RVA: 0x2087460 Offset: 0x2085A60 VA: 0x182087460
	public static AppFlag DeserializeLength(Stream stream, int length, AppFlag instance, bool isDelta) { }

	// RVA: 0x2087C70 Offset: 0x2086270 VA: 0x182087C70
	public static void SerializeDelta(Stream stream, AppFlag instance, AppFlag previous) { }

	// RVA: 0x2087FA0 Offset: 0x20865A0 VA: 0x182087FA0
	public static void Serialize(Stream stream, AppFlag instance) { }

	// RVA: 0x2088070 Offset: 0x2086670 VA: 0x182088070
	public byte[] ToProtoBytes() { }

	// RVA: 0x2088080 Offset: 0x2086680 VA: 0x182088080
	public void ToProto(Stream stream) { }

	// RVA: 0x2087DF0 Offset: 0x20863F0 VA: 0x182087DF0
	public static byte[] SerializeToBytes(AppFlag instance) { }

	// RVA: 0x2087D40 Offset: 0x2086340 VA: 0x182087D40
	public static void SerializeLengthDelimited(Stream stream, AppFlag instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class AppInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6522
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string name; // 0x18
	public string headerImage; // 0x20
	public string url; // 0x28
	public string map; // 0x30
	public uint mapSize; // 0x38
	public uint wipeTime; // 0x3C
	public uint players; // 0x40
	public uint maxPlayers; // 0x44
	public uint queuedPlayers; // 0x48
	public uint seed; // 0x4C
	public uint salt; // 0x50
	public string logoImage; // 0x58

	// Methods

	// RVA: 0x2089AB0 Offset: 0x20880B0 VA: 0x182089AB0
	public static void ResetToPool(AppInfo instance) { }

	// RVA: 0x2089900 Offset: 0x2087F00 VA: 0x182089900
	public void ResetToPool() { }

	// RVA: 0x2089690 Offset: 0x2087C90 VA: 0x182089690 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20882A0 Offset: 0x20868A0 VA: 0x1820882A0
	public void CopyTo(AppInfo instance) { }

	// RVA: 0x2088350 Offset: 0x2086950 VA: 0x182088350
	public AppInfo Copy() { }

	// RVA: 0x2089610 Offset: 0x2087C10 VA: 0x182089610
	public static AppInfo Deserialize(Stream stream) { }

	// RVA: 0x2088970 Offset: 0x2086F70 VA: 0x182088970
	public static AppInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20889F0 Offset: 0x2086FF0 VA: 0x1820889F0
	public static AppInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2089090 Offset: 0x2087690 VA: 0x182089090
	public static AppInfo Deserialize(byte[] buffer) { }

	// RVA: 0x20898C0 Offset: 0x2087EC0 VA: 0x1820898C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x208A860 Offset: 0x2088E60 VA: 0x18208A860 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x208A880 Offset: 0x2088E80 VA: 0x18208A880 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppInfo previous) { }

	// RVA: 0x20898E0 Offset: 0x2087EE0 VA: 0x1820898E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2088F90 Offset: 0x2087590 VA: 0x182088F90
	public static AppInfo Deserialize(byte[] buffer, AppInfo instance, bool isDelta = False) { }

	// RVA: 0x20891B0 Offset: 0x20877B0 VA: 0x1820891B0
	public static AppInfo Deserialize(Stream stream, AppInfo instance, bool isDelta) { }

	// RVA: 0x2088440 Offset: 0x2086A40 VA: 0x182088440
	public static AppInfo DeserializeLengthDelimited(Stream stream, AppInfo instance, bool isDelta) { }

	// RVA: 0x2088A80 Offset: 0x2087080 VA: 0x182088A80
	public static AppInfo DeserializeLength(Stream stream, int length, AppInfo instance, bool isDelta) { }

	// RVA: 0x2089C60 Offset: 0x2088260 VA: 0x182089C60
	public static void SerializeDelta(Stream stream, AppInfo instance, AppInfo previous) { }

	// RVA: 0x208A430 Offset: 0x2088A30 VA: 0x18208A430
	public static void Serialize(Stream stream, AppInfo instance) { }

	// RVA: 0x208A850 Offset: 0x2088E50 VA: 0x18208A850
	public byte[] ToProtoBytes() { }

	// RVA: 0x208A860 Offset: 0x2088E60 VA: 0x18208A860
	public void ToProto(Stream stream) { }

	// RVA: 0x208A320 Offset: 0x2088920 VA: 0x18208A320
	public static byte[] SerializeToBytes(AppInfo instance) { }

	// RVA: 0x208A270 Offset: 0x2088870 VA: 0x18208A270
	public static void SerializeLengthDelimited(Stream stream, AppInfo instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class AppTime : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6523
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float dayLengthMinutes; // 0x14
	public float timeScale; // 0x18
	public float sunrise; // 0x1C
	public float sunset; // 0x20
	public float time; // 0x24

	// Methods

	// RVA: 0x1E233C0 Offset: 0x1E219C0 VA: 0x181E233C0
	public static void ResetToPool(AppTime instance) { }

	// RVA: 0x1E23310 Offset: 0x1E21910 VA: 0x181E23310
	public void ResetToPool() { }

	// RVA: 0x1E23010 Offset: 0x1E21610 VA: 0x181E23010 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E21C60 Offset: 0x1E20260 VA: 0x181E21C60
	public void CopyTo(AppTime instance) { }

	// RVA: 0x1E21CA0 Offset: 0x1E202A0 VA: 0x181E21CA0
	public AppTime Copy() { }

	// RVA: 0x1E227B0 Offset: 0x1E20DB0 VA: 0x181E227B0
	public static AppTime Deserialize(Stream stream) { }

	// RVA: 0x1E21D20 Offset: 0x1E20320 VA: 0x181E21D20
	public static AppTime DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E220D0 Offset: 0x1E206D0 VA: 0x181E220D0
	public static AppTime DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E22CB0 Offset: 0x1E212B0 VA: 0x181E22CB0
	public static AppTime Deserialize(byte[] buffer) { }

	// RVA: 0x1E23090 Offset: 0x1E21690 VA: 0x181E23090
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E23A40 Offset: 0x1E22040 VA: 0x181E23A40 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E23A60 Offset: 0x1E22060 VA: 0x181E23A60 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppTime previous) { }

	// RVA: 0x1E232F0 Offset: 0x1E218F0 VA: 0x181E232F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E22470 Offset: 0x1E20A70 VA: 0x181E22470
	public static AppTime Deserialize(byte[] buffer, AppTime instance, bool isDelta = False) { }

	// RVA: 0x1E22A50 Offset: 0x1E21050 VA: 0x181E22A50
	public static AppTime Deserialize(Stream stream, AppTime instance, bool isDelta) { }

	// RVA: 0x1E21DA0 Offset: 0x1E203A0 VA: 0x181E21DA0
	public static AppTime DeserializeLengthDelimited(Stream stream, AppTime instance, bool isDelta) { }

	// RVA: 0x1E22160 Offset: 0x1E20760 VA: 0x181E22160
	public static AppTime DeserializeLength(Stream stream, int length, AppTime instance, bool isDelta) { }

	// RVA: 0x1E23470 Offset: 0x1E21A70 VA: 0x181E23470
	public static void SerializeDelta(Stream stream, AppTime instance, AppTime previous) { }

	// RVA: 0x1E238C0 Offset: 0x1E21EC0 VA: 0x181E238C0
	public static void Serialize(Stream stream, AppTime instance) { }

	// RVA: 0x1E23A30 Offset: 0x1E22030 VA: 0x181E23A30
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E23A40 Offset: 0x1E22040 VA: 0x181E23A40
	public void ToProto(Stream stream) { }

	// RVA: 0x1E237B0 Offset: 0x1E21DB0 VA: 0x181E237B0
	public static byte[] SerializeToBytes(AppTime instance) { }

	// RVA: 0x1E23700 Offset: 0x1E21D00 VA: 0x181E23700
	public static void SerializeLengthDelimited(Stream stream, AppTime instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class AppMap : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6524
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint width; // 0x14
	public uint height; // 0x18
	public byte[] jpgImage; // 0x20
	public int oceanMargin; // 0x28
	public List<AppMap.Monument> monuments; // 0x30
	public string background; // 0x38

	// Methods

	// RVA: 0x208E3B0 Offset: 0x208C9B0 VA: 0x18208E3B0
	public static void ResetToPool(AppMap instance) { }

	// RVA: 0x208E180 Offset: 0x208C780 VA: 0x18208E180
	public void ResetToPool() { }

	// RVA: 0x208DD90 Offset: 0x208C390 VA: 0x18208DD90 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x208C2E0 Offset: 0x208A8E0 VA: 0x18208C2E0
	public void CopyTo(AppMap instance) { }

	// RVA: 0x208C500 Offset: 0x208AB00 VA: 0x18208C500
	public AppMap Copy() { }

	// RVA: 0x208D2B0 Offset: 0x208B8B0 VA: 0x18208D2B0
	public static AppMap Deserialize(Stream stream) { }

	// RVA: 0x208C9B0 Offset: 0x208AFB0 VA: 0x18208C9B0
	public static AppMap DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x208CE30 Offset: 0x208B430 VA: 0x18208CE30
	public static AppMap DeserializeLength(Stream stream, int length) { }

	// RVA: 0x208CEC0 Offset: 0x208B4C0 VA: 0x18208CEC0
	public static AppMap Deserialize(byte[] buffer) { }

	// RVA: 0x208DE10 Offset: 0x208C410 VA: 0x18208DE10
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x208EED0 Offset: 0x208D4D0 VA: 0x18208EED0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x208EEF0 Offset: 0x208D4F0 VA: 0x18208EEF0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppMap previous) { }

	// RVA: 0x208E160 Offset: 0x208C760 VA: 0x18208E160 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x208D960 Offset: 0x208BF60 VA: 0x18208D960
	public static AppMap Deserialize(byte[] buffer, AppMap instance, bool isDelta = False) { }

	// RVA: 0x208D610 Offset: 0x208BC10 VA: 0x18208D610
	public static AppMap Deserialize(Stream stream, AppMap instance, bool isDelta) { }

	// RVA: 0x208C580 Offset: 0x208AB80 VA: 0x18208C580
	public static AppMap DeserializeLengthDelimited(Stream stream, AppMap instance, bool isDelta) { }

	// RVA: 0x208CA30 Offset: 0x208B030 VA: 0x18208CA30
	public static AppMap DeserializeLength(Stream stream, int length, AppMap instance, bool isDelta) { }

	// RVA: 0x208E5E0 Offset: 0x208CBE0 VA: 0x18208E5E0
	public static void SerializeDelta(Stream stream, AppMap instance, AppMap previous) { }

	// RVA: 0x208EB70 Offset: 0x208D170 VA: 0x18208EB70
	public static void Serialize(Stream stream, AppMap instance) { }

	// RVA: 0x208EEC0 Offset: 0x208D4C0 VA: 0x18208EEC0
	public byte[] ToProtoBytes() { }

	// RVA: 0x208EED0 Offset: 0x208D4D0 VA: 0x18208EED0
	public void ToProto(Stream stream) { }

	// RVA: 0x208EA60 Offset: 0x208D060 VA: 0x18208EA60
	public static byte[] SerializeToBytes(AppMap instance) { }

	// RVA: 0x208E9B0 Offset: 0x208CFB0 VA: 0x18208E9B0
	public static void SerializeLengthDelimited(Stream stream, AppMap instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class AppMap.Monument : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6525
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string token; // 0x18
	public float x; // 0x20
	public float y; // 0x24

	// Methods

	// RVA: 0x2096CD0 Offset: 0x20952D0 VA: 0x182096CD0
	public static void ResetToPool(AppMap.Monument instance) { }

	// RVA: 0x2096D80 Offset: 0x2095380 VA: 0x182096D80
	public void ResetToPool() { }

	// RVA: 0x2096A70 Offset: 0x2095070 VA: 0x182096A70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2095A60 Offset: 0x2094060 VA: 0x182095A60
	public void CopyTo(AppMap.Monument instance) { }

	// RVA: 0x2095AB0 Offset: 0x20940B0 VA: 0x182095AB0
	public AppMap.Monument Copy() { }

	// RVA: 0x2096170 Offset: 0x2094770 VA: 0x182096170
	public static AppMap.Monument Deserialize(Stream stream) { }

	// RVA: 0x2095DE0 Offset: 0x20943E0 VA: 0x182095DE0
	public static AppMap.Monument DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20960E0 Offset: 0x20946E0 VA: 0x1820960E0
	public static AppMap.Monument DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2096600 Offset: 0x2094C00 VA: 0x182096600
	public static AppMap.Monument Deserialize(byte[] buffer) { }

	// RVA: 0x2096AF0 Offset: 0x20950F0 VA: 0x182096AF0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20973C0 Offset: 0x20959C0 VA: 0x1820973C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20973E0 Offset: 0x20959E0 VA: 0x1820973E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppMap.Monument previous) { }

	// RVA: 0x2096CB0 Offset: 0x20952B0 VA: 0x182096CB0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2096370 Offset: 0x2094970 VA: 0x182096370
	public static AppMap.Monument Deserialize(byte[] buffer, AppMap.Monument instance, bool isDelta = False) { }

	// RVA: 0x20968B0 Offset: 0x2094EB0 VA: 0x1820968B0
	public static AppMap.Monument Deserialize(Stream stream, AppMap.Monument instance, bool isDelta) { }

	// RVA: 0x2095B40 Offset: 0x2094140 VA: 0x182095B40
	public static AppMap.Monument DeserializeLengthDelimited(Stream stream, AppMap.Monument instance, bool isDelta) { }

	// RVA: 0x2095E60 Offset: 0x2094460 VA: 0x182095E60
	public static AppMap.Monument DeserializeLength(Stream stream, int length, AppMap.Monument instance, bool isDelta) { }

	// RVA: 0x2096E30 Offset: 0x2095430 VA: 0x182096E30
	public static void SerializeDelta(Stream stream, AppMap.Monument instance, AppMap.Monument previous) { }

	// RVA: 0x2097220 Offset: 0x2095820 VA: 0x182097220
	public static void Serialize(Stream stream, AppMap.Monument instance) { }

	// RVA: 0x20973B0 Offset: 0x20959B0 VA: 0x1820973B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20973C0 Offset: 0x20959C0 VA: 0x1820973C0
	public void ToProto(Stream stream) { }

	// RVA: 0x2097110 Offset: 0x2095710 VA: 0x182097110
	public static byte[] SerializeToBytes(AppMap.Monument instance) { }

	// RVA: 0x2097060 Offset: 0x2095660 VA: 0x182097060
	public static void SerializeLengthDelimited(Stream stream, AppMap.Monument instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class AppEntityInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6526
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public AppEntityType type; // 0x14
	public AppEntityPayload payload; // 0x18

	// Methods

	// RVA: 0x2082FC0 Offset: 0x20815C0 VA: 0x182082FC0
	public static void ResetToPool(AppEntityInfo instance) { }

	// RVA: 0x2082F10 Offset: 0x2081510 VA: 0x182082F10
	public void ResetToPool() { }

	// RVA: 0x2082DA0 Offset: 0x20813A0 VA: 0x182082DA0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2080C20 Offset: 0x207F220 VA: 0x182080C20
	public void CopyTo(AppEntityInfo instance) { }

	// RVA: 0x20821B0 Offset: 0x20807B0 VA: 0x1820821B0
	public AppEntityInfo Copy() { }

	// RVA: 0x2082D20 Offset: 0x2081320 VA: 0x182082D20
	public static AppEntityInfo Deserialize(Stream stream) { }

	// RVA: 0x2082280 Offset: 0x2080880 VA: 0x182082280
	public static AppEntityInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2082870 Offset: 0x2080E70 VA: 0x182082870
	public static AppEntityInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2082900 Offset: 0x2080F00 VA: 0x182082900
	public static AppEntityInfo Deserialize(byte[] buffer) { }

	// RVA: 0x2082ED0 Offset: 0x20814D0 VA: 0x182082ED0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2083680 Offset: 0x2081C80 VA: 0x182083680 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20836A0 Offset: 0x2081CA0 VA: 0x1820836A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppEntityInfo previous) { }

	// RVA: 0x2082EF0 Offset: 0x20814F0 VA: 0x182082EF0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2082C20 Offset: 0x2081220 VA: 0x182082C20
	public static AppEntityInfo Deserialize(byte[] buffer, AppEntityInfo instance, bool isDelta = False) { }

	// RVA: 0x2082A20 Offset: 0x2081020 VA: 0x182082A20
	public static AppEntityInfo Deserialize(Stream stream, AppEntityInfo instance, bool isDelta) { }

	// RVA: 0x2082300 Offset: 0x2080900 VA: 0x182082300
	public static AppEntityInfo DeserializeLengthDelimited(Stream stream, AppEntityInfo instance, bool isDelta) { }

	// RVA: 0x20825D0 Offset: 0x2080BD0 VA: 0x1820825D0
	public static AppEntityInfo DeserializeLength(Stream stream, int length, AppEntityInfo instance, bool isDelta) { }

	// RVA: 0x2083070 Offset: 0x2081670 VA: 0x182083070
	public static void SerializeDelta(Stream stream, AppEntityInfo instance, AppEntityInfo previous) { }

	// RVA: 0x2083460 Offset: 0x2081A60 VA: 0x182083460
	public static void Serialize(Stream stream, AppEntityInfo instance) { }

	// RVA: 0x2083670 Offset: 0x2081C70 VA: 0x182083670
	public byte[] ToProtoBytes() { }

	// RVA: 0x2083680 Offset: 0x2081C80 VA: 0x182083680
	public void ToProto(Stream stream) { }

	// RVA: 0x2083350 Offset: 0x2081950 VA: 0x182083350
	public static byte[] SerializeToBytes(AppEntityInfo instance) { }

	// RVA: 0x20832A0 Offset: 0x20818A0 VA: 0x1820832A0
	public static void SerializeLengthDelimited(Stream stream, AppEntityInfo instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class AppEntityPayload : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6527
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public bool value; // 0x12
	public List<AppEntityPayload.Item> items; // 0x18
	public int capacity; // 0x20
	public bool hasProtection; // 0x24
	public uint protectionExpiry; // 0x28

	// Methods

	// RVA: 0x20852B0 Offset: 0x20838B0 VA: 0x1820852B0
	public static void ResetToPool(AppEntityPayload instance) { }

	// RVA: 0x20854C0 Offset: 0x2083AC0 VA: 0x1820854C0
	public void ResetToPool() { }

	// RVA: 0x2084F20 Offset: 0x2083520 VA: 0x182084F20 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20836C0 Offset: 0x2081CC0 VA: 0x1820836C0
	public void CopyTo(AppEntityPayload instance) { }

	// RVA: 0x2083870 Offset: 0x2081E70 VA: 0x182083870
	public AppEntityPayload Copy() { }

	// RVA: 0x2084540 Offset: 0x2082B40 VA: 0x182084540
	public static AppEntityPayload Deserialize(Stream stream) { }

	// RVA: 0x20838F0 Offset: 0x2081EF0 VA: 0x1820838F0
	public static AppEntityPayload DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2083D50 Offset: 0x2082350 VA: 0x182083D50
	public static AppEntityPayload DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2084190 Offset: 0x2082790 VA: 0x182084190
	public static AppEntityPayload Deserialize(byte[] buffer) { }

	// RVA: 0x2084FA0 Offset: 0x20835A0 VA: 0x182084FA0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2085E70 Offset: 0x2084470 VA: 0x182085E70 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2085E90 Offset: 0x2084490 VA: 0x182085E90 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppEntityPayload previous) { }

	// RVA: 0x2085290 Offset: 0x2083890 VA: 0x182085290 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2084850 Offset: 0x2082E50 VA: 0x182084850
	public static AppEntityPayload Deserialize(byte[] buffer, AppEntityPayload instance, bool isDelta = False) { }

	// RVA: 0x2084C20 Offset: 0x2083220 VA: 0x182084C20
	public static AppEntityPayload Deserialize(Stream stream, AppEntityPayload instance, bool isDelta) { }

	// RVA: 0x2083970 Offset: 0x2081F70 VA: 0x182083970
	public static AppEntityPayload DeserializeLengthDelimited(Stream stream, AppEntityPayload instance, bool isDelta) { }

	// RVA: 0x2083DE0 Offset: 0x20823E0 VA: 0x182083DE0
	public static AppEntityPayload DeserializeLength(Stream stream, int length, AppEntityPayload instance, bool isDelta) { }

	// RVA: 0x20856D0 Offset: 0x2083CD0 VA: 0x1820856D0
	public static void SerializeDelta(Stream stream, AppEntityPayload instance, AppEntityPayload previous) { }

	// RVA: 0x2085BB0 Offset: 0x20841B0 VA: 0x182085BB0
	public static void Serialize(Stream stream, AppEntityPayload instance) { }

	// RVA: 0x2085E60 Offset: 0x2084460 VA: 0x182085E60
	public byte[] ToProtoBytes() { }

	// RVA: 0x2085E70 Offset: 0x2084470 VA: 0x182085E70
	public void ToProto(Stream stream) { }

	// RVA: 0x2085AA0 Offset: 0x20840A0 VA: 0x182085AA0
	public static byte[] SerializeToBytes(AppEntityPayload instance) { }

	// RVA: 0x20859F0 Offset: 0x2083FF0 VA: 0x1820859F0
	public static void SerializeLengthDelimited(Stream stream, AppEntityPayload instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class AppEntityPayload.Item : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6528
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int itemId; // 0x14
	public int quantity; // 0x18
	public bool itemIsBlueprint; // 0x1C

	// Methods

	// RVA: 0x2095450 Offset: 0x2093A50 VA: 0x182095450
	public static void ResetToPool(AppEntityPayload.Item instance) { }

	// RVA: 0x20954E0 Offset: 0x2093AE0 VA: 0x1820954E0
	public void ResetToPool() { }

	// RVA: 0x2095200 Offset: 0x2093800 VA: 0x182095200 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D68EA0 Offset: 0x1D674A0 VA: 0x181D68EA0
	public void CopyTo(AppEntityPayload.Item instance) { }

	// RVA: 0x20942D0 Offset: 0x20928D0 VA: 0x1820942D0
	public AppEntityPayload.Item Copy() { }

	// RVA: 0x2094940 Offset: 0x2092F40 VA: 0x182094940
	public static AppEntityPayload.Item Deserialize(Stream stream) { }

	// RVA: 0x2094350 Offset: 0x2092950 VA: 0x182094350
	public static AppEntityPayload.Item DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2094650 Offset: 0x2092C50 VA: 0x182094650
	public static AppEntityPayload.Item DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2094B30 Offset: 0x2093130 VA: 0x182094B30
	public static AppEntityPayload.Item Deserialize(byte[] buffer) { }

	// RVA: 0x2095280 Offset: 0x2093880 VA: 0x182095280
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2095A20 Offset: 0x2094020 VA: 0x182095A20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2095A40 Offset: 0x2094040 VA: 0x182095A40 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppEntityPayload.Item previous) { }

	// RVA: 0x2095430 Offset: 0x2093A30 VA: 0x182095430 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2094F80 Offset: 0x2093580 VA: 0x182094F80
	public static AppEntityPayload.Item Deserialize(byte[] buffer, AppEntityPayload.Item instance, bool isDelta = False) { }

	// RVA: 0x2094DD0 Offset: 0x20933D0 VA: 0x182094DD0
	public static AppEntityPayload.Item Deserialize(Stream stream, AppEntityPayload.Item instance, bool isDelta) { }

	// RVA: 0x20943D0 Offset: 0x20929D0 VA: 0x1820943D0
	public static AppEntityPayload.Item DeserializeLengthDelimited(Stream stream, AppEntityPayload.Item instance, bool isDelta) { }

	// RVA: 0x20946E0 Offset: 0x2092CE0 VA: 0x1820946E0
	public static AppEntityPayload.Item DeserializeLength(Stream stream, int length, AppEntityPayload.Item instance, bool isDelta) { }

	// RVA: 0x2095570 Offset: 0x2093B70 VA: 0x182095570
	public static void SerializeDelta(Stream stream, AppEntityPayload.Item instance, AppEntityPayload.Item previous) { }

	// RVA: 0x20958F0 Offset: 0x2093EF0 VA: 0x1820958F0
	public static void Serialize(Stream stream, AppEntityPayload.Item instance) { }

	// RVA: 0x2095A10 Offset: 0x2094010 VA: 0x182095A10
	public byte[] ToProtoBytes() { }

	// RVA: 0x2095A20 Offset: 0x2094020 VA: 0x182095A20
	public void ToProto(Stream stream) { }

	// RVA: 0x20957E0 Offset: 0x2093DE0 VA: 0x1820957E0
	public static byte[] SerializeToBytes(AppEntityPayload.Item instance) { }

	// RVA: 0x2095730 Offset: 0x2093D30 VA: 0x182095730
	public static void SerializeLengthDelimited(Stream stream, AppEntityPayload.Item instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class AppTeamInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6529
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong leaderSteamId; // 0x18
	public List<AppTeamInfo.Member> members; // 0x20
	public List<AppTeamInfo.Note> mapNotes; // 0x28
	public List<AppTeamInfo.Note> leaderMapNotes; // 0x30

	// Methods

	// RVA: 0x1E1FA00 Offset: 0x1E1E000 VA: 0x181E1FA00
	public static void ResetToPool(AppTeamInfo instance) { }

	// RVA: 0x1E1F5D0 Offset: 0x1E1DBD0 VA: 0x181E1F5D0
	public void ResetToPool() { }

	// RVA: 0x1E1F510 Offset: 0x1E1DB10 VA: 0x181E1F510 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E1DF40 Offset: 0x1E1C540 VA: 0x181E1DF40
	public void CopyTo(AppTeamInfo instance) { }

	// RVA: 0x1E1E390 Offset: 0x1E1C990 VA: 0x181E1E390
	public AppTeamInfo Copy() { }

	// RVA: 0x1E1F490 Offset: 0x1E1DA90 VA: 0x181E1F490
	public static AppTeamInfo Deserialize(Stream stream) { }

	// RVA: 0x1E1E8D0 Offset: 0x1E1CED0 VA: 0x181E1E8D0
	public static AppTeamInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E1E950 Offset: 0x1E1CF50 VA: 0x181E1E950
	public static AppTeamInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E1F370 Offset: 0x1E1D970 VA: 0x181E1F370
	public static AppTeamInfo Deserialize(byte[] buffer) { }

	// RVA: 0x1E1F590 Offset: 0x1E1DB90 VA: 0x181E1F590
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E20930 Offset: 0x1E1EF30 VA: 0x181E20930 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E20950 Offset: 0x1E1EF50 VA: 0x181E20950 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppTeamInfo previous) { }

	// RVA: 0x1E1F5B0 Offset: 0x1E1DBB0 VA: 0x181E1F5B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E1F270 Offset: 0x1E1D870 VA: 0x181E1F270
	public static AppTeamInfo Deserialize(byte[] buffer, AppTeamInfo instance, bool isDelta = False) { }

	// RVA: 0x1E1EE80 Offset: 0x1E1D480 VA: 0x181E1EE80
	public static AppTeamInfo Deserialize(Stream stream, AppTeamInfo instance, bool isDelta) { }

	// RVA: 0x1E1E410 Offset: 0x1E1CA10 VA: 0x181E1E410
	public static AppTeamInfo DeserializeLengthDelimited(Stream stream, AppTeamInfo instance, bool isDelta) { }

	// RVA: 0x1E1E9E0 Offset: 0x1E1CFE0 VA: 0x181E1E9E0
	public static AppTeamInfo DeserializeLength(Stream stream, int length, AppTeamInfo instance, bool isDelta) { }

	// RVA: 0x1E1FE30 Offset: 0x1E1E430 VA: 0x181E1FE30
	public static void SerializeDelta(Stream stream, AppTeamInfo instance, AppTeamInfo previous) { }

	// RVA: 0x1E204A0 Offset: 0x1E1EAA0 VA: 0x181E204A0
	public static void Serialize(Stream stream, AppTeamInfo instance) { }

	// RVA: 0x1E20920 Offset: 0x1E1EF20 VA: 0x181E20920
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E20930 Offset: 0x1E1EF30 VA: 0x181E20930
	public void ToProto(Stream stream) { }

	// RVA: 0x1E20390 Offset: 0x1E1E990 VA: 0x181E20390
	public static byte[] SerializeToBytes(AppTeamInfo instance) { }

	// RVA: 0x1E202E0 Offset: 0x1E1E8E0 VA: 0x181E202E0
	public static void SerializeLengthDelimited(Stream stream, AppTeamInfo instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class AppTeamInfo.Member : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6530
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong steamId; // 0x18
	public string name; // 0x20
	public float x; // 0x28
	public float y; // 0x2C
	public bool isOnline; // 0x30
	public uint spawnTime; // 0x34
	public bool isAlive; // 0x38
	public uint deathTime; // 0x3C

	// Methods

	// RVA: 0x1E27E00 Offset: 0x1E26400 VA: 0x181E27E00
	public static void ResetToPool(AppTeamInfo.Member instance) { }

	// RVA: 0x1E27D00 Offset: 0x1E26300 VA: 0x181E27D00
	public void ResetToPool() { }

	// RVA: 0x1E27930 Offset: 0x1E25F30 VA: 0x181E27930 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E26000 Offset: 0x1E24600 VA: 0x181E26000
	public void CopyTo(AppTeamInfo.Member instance) { }

	// RVA: 0x1E26070 Offset: 0x1E24670 VA: 0x181E26070
	public AppTeamInfo.Member Copy() { }

	// RVA: 0x1E26E70 Offset: 0x1E25470 VA: 0x181E26E70
	public static AppTeamInfo.Member Deserialize(Stream stream) { }

	// RVA: 0x1E26120 Offset: 0x1E24720 VA: 0x181E26120
	public static AppTeamInfo.Member DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E265B0 Offset: 0x1E24BB0 VA: 0x181E265B0
	public static AppTeamInfo.Member DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E26A30 Offset: 0x1E25030 VA: 0x181E26A30
	public static AppTeamInfo.Member Deserialize(byte[] buffer) { }

	// RVA: 0x1E279B0 Offset: 0x1E25FB0 VA: 0x181E279B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E286E0 Offset: 0x1E26CE0 VA: 0x181E286E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E28700 Offset: 0x1E26D00 VA: 0x181E28700 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppTeamInfo.Member previous) { }

	// RVA: 0x1E27CE0 Offset: 0x1E262E0 VA: 0x181E27CE0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E27510 Offset: 0x1E25B10 VA: 0x181E27510
	public static AppTeamInfo.Member Deserialize(byte[] buffer, AppTeamInfo.Member instance, bool isDelta = False) { }

	// RVA: 0x1E271E0 Offset: 0x1E257E0 VA: 0x181E271E0
	public static AppTeamInfo.Member Deserialize(Stream stream, AppTeamInfo.Member instance, bool isDelta) { }

	// RVA: 0x1E261A0 Offset: 0x1E247A0 VA: 0x181E261A0
	public static AppTeamInfo.Member DeserializeLengthDelimited(Stream stream, AppTeamInfo.Member instance, bool isDelta) { }

	// RVA: 0x1E26640 Offset: 0x1E24C40 VA: 0x181E26640
	public static AppTeamInfo.Member DeserializeLength(Stream stream, int length, AppTeamInfo.Member instance, bool isDelta) { }

	// RVA: 0x1E27F00 Offset: 0x1E26500 VA: 0x181E27F00
	public static void SerializeDelta(Stream stream, AppTeamInfo.Member instance, AppTeamInfo.Member previous) { }

	// RVA: 0x1E28470 Offset: 0x1E26A70 VA: 0x181E28470
	public static void Serialize(Stream stream, AppTeamInfo.Member instance) { }

	// RVA: 0x1E286D0 Offset: 0x1E26CD0 VA: 0x181E286D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E286E0 Offset: 0x1E26CE0 VA: 0x181E286E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E28360 Offset: 0x1E26960 VA: 0x181E28360
	public static byte[] SerializeToBytes(AppTeamInfo.Member instance) { }

	// RVA: 0x1E282B0 Offset: 0x1E268B0 VA: 0x181E282B0
	public static void SerializeLengthDelimited(Stream stream, AppTeamInfo.Member instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class AppTeamInfo.Note : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6531
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int type; // 0x14
	public float x; // 0x18
	public float y; // 0x1C

	// Methods

	// RVA: 0x1E29910 Offset: 0x1E27F10 VA: 0x181E29910
	public static void ResetToPool(AppTeamInfo.Note instance) { }

	// RVA: 0x1E299A0 Offset: 0x1E27FA0 VA: 0x181E299A0
	public void ResetToPool() { }

	// RVA: 0x1E296C0 Offset: 0x1E27CC0 VA: 0x181E296C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E28720 Offset: 0x1E26D20 VA: 0x181E28720
	public void CopyTo(AppTeamInfo.Note instance) { }

	// RVA: 0x1E28750 Offset: 0x1E26D50 VA: 0x181E28750
	public AppTeamInfo.Note Copy() { }

	// RVA: 0x1E294D0 Offset: 0x1E27AD0 VA: 0x181E294D0
	public static AppTeamInfo.Note Deserialize(Stream stream) { }

	// RVA: 0x1E287D0 Offset: 0x1E26DD0 VA: 0x181E287D0
	public static AppTeamInfo.Note DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E28D50 Offset: 0x1E27350 VA: 0x181E28D50
	public static AppTeamInfo.Note DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E29220 Offset: 0x1E27820 VA: 0x181E29220
	public static AppTeamInfo.Note Deserialize(byte[] buffer) { }

	// RVA: 0x1E29740 Offset: 0x1E27D40 VA: 0x181E29740
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E29F10 Offset: 0x1E28510 VA: 0x181E29F10 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E29F30 Offset: 0x1E28530 VA: 0x181E29F30 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppTeamInfo.Note previous) { }

	// RVA: 0x1E298F0 Offset: 0x1E27EF0 VA: 0x181E298F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E28DE0 Offset: 0x1E273E0 VA: 0x181E28DE0
	public static AppTeamInfo.Note Deserialize(byte[] buffer, AppTeamInfo.Note instance, bool isDelta = False) { }

	// RVA: 0x1E29070 Offset: 0x1E27670 VA: 0x181E29070
	public static AppTeamInfo.Note Deserialize(Stream stream, AppTeamInfo.Note instance, bool isDelta) { }

	// RVA: 0x1E28850 Offset: 0x1E26E50 VA: 0x181E28850
	public static AppTeamInfo.Note DeserializeLengthDelimited(Stream stream, AppTeamInfo.Note instance, bool isDelta) { }

	// RVA: 0x1E28AE0 Offset: 0x1E270E0 VA: 0x181E28AE0
	public static AppTeamInfo.Note DeserializeLength(Stream stream, int length, AppTeamInfo.Note instance, bool isDelta) { }

	// RVA: 0x1E29A30 Offset: 0x1E28030 VA: 0x181E29A30
	public static void SerializeDelta(Stream stream, AppTeamInfo.Note instance, AppTeamInfo.Note previous) { }

	// RVA: 0x1E29DD0 Offset: 0x1E283D0 VA: 0x181E29DD0
	public static void Serialize(Stream stream, AppTeamInfo.Note instance) { }

	// RVA: 0x1E29F00 Offset: 0x1E28500 VA: 0x181E29F00
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E29F10 Offset: 0x1E28510 VA: 0x181E29F10
	public void ToProto(Stream stream) { }

	// RVA: 0x1E29CC0 Offset: 0x1E282C0 VA: 0x181E29CC0
	public static byte[] SerializeToBytes(AppTeamInfo.Note instance) { }

	// RVA: 0x1E29C10 Offset: 0x1E28210 VA: 0x181E29C10
	public static void SerializeLengthDelimited(Stream stream, AppTeamInfo.Note instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class AppChatMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6532
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong steamId; // 0x18
	public string name; // 0x20
	public string message; // 0x28
	public string color; // 0x30
	public uint time; // 0x38

	// Methods

	// RVA: 0x2018120 Offset: 0x2016720 VA: 0x182018120
	public static void ResetToPool(AppChatMessage instance) { }

	// RVA: 0x2018230 Offset: 0x2016830 VA: 0x182018230
	public void ResetToPool() { }

	// RVA: 0x2017D00 Offset: 0x2016300 VA: 0x182017D00 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2016850 Offset: 0x2014E50 VA: 0x182016850
	public void CopyTo(AppChatMessage instance) { }

	// RVA: 0x20168C0 Offset: 0x2014EC0 VA: 0x1820168C0
	public AppChatMessage Copy() { }

	// RVA: 0x2017A40 Offset: 0x2016040 VA: 0x182017A40
	public static AppChatMessage Deserialize(Stream stream) { }

	// RVA: 0x2016CC0 Offset: 0x20152C0 VA: 0x182016CC0
	public static AppChatMessage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2016D40 Offset: 0x2015340 VA: 0x182016D40
	public static AppChatMessage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2017100 Offset: 0x2015700 VA: 0x182017100
	public static AppChatMessage Deserialize(byte[] buffer) { }

	// RVA: 0x2017E90 Offset: 0x2016490 VA: 0x182017E90
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2018B30 Offset: 0x2017130 VA: 0x182018B30 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2018B50 Offset: 0x2017150 VA: 0x182018B50 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppChatMessage previous) { }

	// RVA: 0x2018100 Offset: 0x2016700 VA: 0x182018100 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20176F0 Offset: 0x2015CF0 VA: 0x1820176F0
	public static AppChatMessage Deserialize(byte[] buffer, AppChatMessage instance, bool isDelta = False) { }

	// RVA: 0x2017470 Offset: 0x2015A70 VA: 0x182017470
	public static AppChatMessage Deserialize(Stream stream, AppChatMessage instance, bool isDelta) { }

	// RVA: 0x2016970 Offset: 0x2014F70 VA: 0x182016970
	public static AppChatMessage DeserializeLengthDelimited(Stream stream, AppChatMessage instance, bool isDelta) { }

	// RVA: 0x2016DD0 Offset: 0x20153D0 VA: 0x182016DD0
	public static AppChatMessage DeserializeLength(Stream stream, int length, AppChatMessage instance, bool isDelta) { }

	// RVA: 0x2018340 Offset: 0x2016940 VA: 0x182018340
	public static void SerializeDelta(Stream stream, AppChatMessage instance, AppChatMessage previous) { }

	// RVA: 0x2018860 Offset: 0x2016E60 VA: 0x182018860
	public static void Serialize(Stream stream, AppChatMessage instance) { }

	// RVA: 0x2018B20 Offset: 0x2017120 VA: 0x182018B20
	public byte[] ToProtoBytes() { }

	// RVA: 0x2018B30 Offset: 0x2017130 VA: 0x182018B30
	public void ToProto(Stream stream) { }

	// RVA: 0x2018750 Offset: 0x2016D50 VA: 0x182018750
	public static byte[] SerializeToBytes(AppChatMessage instance) { }

	// RVA: 0x20186A0 Offset: 0x2016CA0 VA: 0x1820186A0
	public static void SerializeLengthDelimited(Stream stream, AppChatMessage instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class AppTeamChat : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6533
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<AppChatMessage> messages; // 0x18

	// Methods

	// RVA: 0x1E1D7C0 Offset: 0x1E1BDC0 VA: 0x181E1D7C0
	public static void ResetToPool(AppTeamChat instance) { }

	// RVA: 0x1E1D610 Offset: 0x1E1BC10 VA: 0x181E1D610
	public void ResetToPool() { }

	// RVA: 0x1E1D550 Offset: 0x1E1BB50 VA: 0x181E1D550 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E1C9A0 Offset: 0x1E1AFA0 VA: 0x181E1C9A0
	public void CopyTo(AppTeamChat instance) { }

	// RVA: 0x1E1CAD0 Offset: 0x1E1B0D0 VA: 0x181E1CAD0
	public AppTeamChat Copy() { }

	// RVA: 0x1E1D3B0 Offset: 0x1E1B9B0 VA: 0x181E1D3B0
	public static AppTeamChat Deserialize(Stream stream) { }

	// RVA: 0x1E1CB50 Offset: 0x1E1B150 VA: 0x181E1CB50
	public static AppTeamChat DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E1D090 Offset: 0x1E1B690 VA: 0x181E1D090
	public static AppTeamChat DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E1D430 Offset: 0x1E1BA30 VA: 0x181E1D430
	public static AppTeamChat Deserialize(byte[] buffer) { }

	// RVA: 0x1E1D5D0 Offset: 0x1E1BBD0 VA: 0x181E1D5D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E1DF00 Offset: 0x1E1C500 VA: 0x181E1DF00 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E1DF20 Offset: 0x1E1C520 VA: 0x181E1DF20 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppTeamChat previous) { }

	// RVA: 0x1E1D5F0 Offset: 0x1E1BBF0 VA: 0x181E1D5F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E1D120 Offset: 0x1E1B720 VA: 0x181E1D120
	public static AppTeamChat Deserialize(byte[] buffer, AppTeamChat instance, bool isDelta = False) { }

	// RVA: 0x1E1D220 Offset: 0x1E1B820 VA: 0x181E1D220
	public static AppTeamChat Deserialize(Stream stream, AppTeamChat instance, bool isDelta) { }

	// RVA: 0x1E1CBD0 Offset: 0x1E1B1D0 VA: 0x181E1CBD0
	public static AppTeamChat DeserializeLengthDelimited(Stream stream, AppTeamChat instance, bool isDelta) { }

	// RVA: 0x1E1CE40 Offset: 0x1E1B440 VA: 0x181E1CE40
	public static AppTeamChat DeserializeLength(Stream stream, int length, AppTeamChat instance, bool isDelta) { }

	// RVA: 0x1E1D970 Offset: 0x1E1BF70 VA: 0x181E1D970
	public static void SerializeDelta(Stream stream, AppTeamChat instance, AppTeamChat previous) { }

	// RVA: 0x1E1DD10 Offset: 0x1E1C310 VA: 0x181E1DD10
	public static void Serialize(Stream stream, AppTeamChat instance) { }

	// RVA: 0x1E1DEF0 Offset: 0x1E1C4F0 VA: 0x181E1DEF0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E1DF00 Offset: 0x1E1C500 VA: 0x181E1DF00
	public void ToProto(Stream stream) { }

	// RVA: 0x1E1DC00 Offset: 0x1E1C200 VA: 0x181E1DC00
	public static byte[] SerializeToBytes(AppTeamChat instance) { }

	// RVA: 0x1E1DB50 Offset: 0x1E1C150 VA: 0x181E1DB50
	public static void SerializeLengthDelimited(Stream stream, AppTeamChat instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class AppMarker : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6534
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint id; // 0x14
	public AppMarkerType type; // 0x18
	public float x; // 0x1C
	public float y; // 0x20
	public ulong steamId; // 0x28
	public float rotation; // 0x30
	public float radius; // 0x34
	public Vector4 color1; // 0x38
	public Vector4 color2; // 0x48
	public float alpha; // 0x58
	public string name; // 0x60
	public bool outOfStock; // 0x68
	public List<AppMarker.SellOrder> sellOrders; // 0x70

	// Methods

	// RVA: 0x2090860 Offset: 0x208EE60 VA: 0x182090860
	public static void ResetToPool(AppMarker instance) { }

	// RVA: 0x20905C0 Offset: 0x208EBC0 VA: 0x1820905C0
	public void ResetToPool() { }

	// RVA: 0x2090500 Offset: 0x208EB00 VA: 0x182090500 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x208EF10 Offset: 0x208D510 VA: 0x18208EF10
	public void CopyTo(AppMarker instance) { }

	// RVA: 0x208F120 Offset: 0x208D720 VA: 0x18208F120
	public AppMarker Copy() { }

	// RVA: 0x2090380 Offset: 0x208E980 VA: 0x182090380
	public static AppMarker Deserialize(Stream stream) { }

	// RVA: 0x208F730 Offset: 0x208DD30 VA: 0x18208F730
	public static AppMarker DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x208F7B0 Offset: 0x208DDB0 VA: 0x18208F7B0
	public static AppMarker DeserializeLength(Stream stream, int length) { }

	// RVA: 0x208FDA0 Offset: 0x208E3A0 VA: 0x18208FDA0
	public static AppMarker Deserialize(byte[] buffer) { }

	// RVA: 0x2090580 Offset: 0x208EB80 VA: 0x182090580
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20919A0 Offset: 0x208FFA0 VA: 0x1820919A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20919C0 Offset: 0x208FFC0 VA: 0x1820919C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppMarker previous) { }

	// RVA: 0x20905A0 Offset: 0x208EBA0 VA: 0x1820905A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2090400 Offset: 0x208EA00 VA: 0x182090400
	public static AppMarker Deserialize(byte[] buffer, AppMarker instance, bool isDelta = False) { }

	// RVA: 0x208FEC0 Offset: 0x208E4C0 VA: 0x18208FEC0
	public static AppMarker Deserialize(Stream stream, AppMarker instance, bool isDelta) { }

	// RVA: 0x208F1A0 Offset: 0x208D7A0 VA: 0x18208F1A0
	public static AppMarker DeserializeLengthDelimited(Stream stream, AppMarker instance, bool isDelta) { }

	// RVA: 0x208F840 Offset: 0x208DE40 VA: 0x18208F840
	public static AppMarker DeserializeLength(Stream stream, int length, AppMarker instance, bool isDelta) { }

	// RVA: 0x2090B00 Offset: 0x208F100 VA: 0x182090B00
	public static void SerializeDelta(Stream stream, AppMarker instance, AppMarker previous) { }

	// RVA: 0x2091460 Offset: 0x208FA60 VA: 0x182091460
	public static void Serialize(Stream stream, AppMarker instance) { }

	// RVA: 0x2091990 Offset: 0x208FF90 VA: 0x182091990
	public byte[] ToProtoBytes() { }

	// RVA: 0x20919A0 Offset: 0x208FFA0 VA: 0x1820919A0
	public void ToProto(Stream stream) { }

	// RVA: 0x2091350 Offset: 0x208F950 VA: 0x182091350
	public static byte[] SerializeToBytes(AppMarker instance) { }

	// RVA: 0x20912A0 Offset: 0x208F8A0 VA: 0x1820912A0
	public static void SerializeLengthDelimited(Stream stream, AppMarker instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class AppMarker.SellOrder : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6535
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int itemId; // 0x14
	public int quantity; // 0x18
	public int currencyId; // 0x1C
	public int costPerItem; // 0x20
	public int amountInStock; // 0x24
	public bool itemIsBlueprint; // 0x28
	public bool currencyIsBlueprint; // 0x29
	public float itemCondition; // 0x2C
	public float itemConditionMax; // 0x30

	// Methods

	// RVA: 0x2099330 Offset: 0x2097930 VA: 0x182099330
	public static void ResetToPool(AppMarker.SellOrder instance) { }

	// RVA: 0x2099240 Offset: 0x2097840 VA: 0x182099240
	public void ResetToPool() { }

	// RVA: 0x2098E40 Offset: 0x2097440 VA: 0x182098E40 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2097400 Offset: 0x2095A00 VA: 0x182097400
	public void CopyTo(AppMarker.SellOrder instance) { }

	// RVA: 0x2097450 Offset: 0x2095A50 VA: 0x182097450
	public AppMarker.SellOrder Copy() { }

	// RVA: 0x2097E60 Offset: 0x2096460 VA: 0x182097E60
	public static AppMarker.SellOrder Deserialize(Stream stream) { }

	// RVA: 0x20974F0 Offset: 0x2095AF0 VA: 0x1820974F0
	public static AppMarker.SellOrder DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2097DD0 Offset: 0x20963D0 VA: 0x182097DD0
	public static AppMarker.SellOrder DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20989C0 Offset: 0x2096FC0 VA: 0x1820989C0
	public static AppMarker.SellOrder Deserialize(byte[] buffer) { }

	// RVA: 0x2098EC0 Offset: 0x20974C0 VA: 0x182098EC0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2099B80 Offset: 0x2098180 VA: 0x182099B80 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2099BA0 Offset: 0x20981A0 VA: 0x182099BA0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppMarker.SellOrder previous) { }

	// RVA: 0x2099220 Offset: 0x2097820 VA: 0x182099220 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2098560 Offset: 0x2096B60 VA: 0x182098560
	public static AppMarker.SellOrder Deserialize(byte[] buffer, AppMarker.SellOrder instance, bool isDelta = False) { }

	// RVA: 0x2098200 Offset: 0x2096800 VA: 0x182098200
	public static AppMarker.SellOrder Deserialize(Stream stream, AppMarker.SellOrder instance, bool isDelta) { }

	// RVA: 0x2097570 Offset: 0x2095B70 VA: 0x182097570
	public static AppMarker.SellOrder DeserializeLengthDelimited(Stream stream, AppMarker.SellOrder instance, bool isDelta) { }

	// RVA: 0x20979B0 Offset: 0x2095FB0 VA: 0x1820979B0
	public static AppMarker.SellOrder DeserializeLength(Stream stream, int length, AppMarker.SellOrder instance, bool isDelta) { }

	// RVA: 0x2099420 Offset: 0x2097A20 VA: 0x182099420
	public static void SerializeDelta(Stream stream, AppMarker.SellOrder instance, AppMarker.SellOrder previous) { }

	// RVA: 0x2099970 Offset: 0x2097F70 VA: 0x182099970
	public static void Serialize(Stream stream, AppMarker.SellOrder instance) { }

	// RVA: 0x2099B70 Offset: 0x2098170 VA: 0x182099B70
	public byte[] ToProtoBytes() { }

	// RVA: 0x2099B80 Offset: 0x2098180 VA: 0x182099B80
	public void ToProto(Stream stream) { }

	// RVA: 0x2099860 Offset: 0x2097E60 VA: 0x182099860
	public static byte[] SerializeToBytes(AppMarker.SellOrder instance) { }

	// RVA: 0x20997B0 Offset: 0x2097DB0 VA: 0x1820997B0
	public static void SerializeLengthDelimited(Stream stream, AppMarker.SellOrder instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class AppMapMarkers : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6536
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<AppMarker> markers; // 0x18

	// Methods

	// RVA: 0x208B9B0 Offset: 0x2089FB0 VA: 0x18208B9B0
	public static void ResetToPool(AppMapMarkers instance) { }

	// RVA: 0x208BB60 Offset: 0x208A160 VA: 0x18208BB60
	public void ResetToPool() { }

	// RVA: 0x208B730 Offset: 0x2089D30 VA: 0x18208B730 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x208A8A0 Offset: 0x2088EA0 VA: 0x18208A8A0
	public void CopyTo(AppMapMarkers instance) { }

	// RVA: 0x208AA30 Offset: 0x2089030 VA: 0x18208AA30
	public AppMapMarkers Copy() { }

	// RVA: 0x208B3C0 Offset: 0x20899C0 VA: 0x18208B3C0
	public static AppMapMarkers Deserialize(Stream stream) { }

	// RVA: 0x208AEF0 Offset: 0x20894F0 VA: 0x18208AEF0
	public static AppMapMarkers DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x208B210 Offset: 0x2089810 VA: 0x18208B210
	public static AppMapMarkers DeserializeLength(Stream stream, int length) { }

	// RVA: 0x208B2A0 Offset: 0x20898A0 VA: 0x18208B2A0
	public static AppMapMarkers Deserialize(byte[] buffer) { }

	// RVA: 0x208B970 Offset: 0x2089F70 VA: 0x18208B970
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x208C2A0 Offset: 0x208A8A0 VA: 0x18208C2A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x208C2C0 Offset: 0x208A8C0 VA: 0x18208C2C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppMapMarkers previous) { }

	// RVA: 0x208B990 Offset: 0x2089F90 VA: 0x18208B990 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x208B440 Offset: 0x2089A40 VA: 0x18208B440
	public static AppMapMarkers Deserialize(byte[] buffer, AppMapMarkers instance, bool isDelta = False) { }

	// RVA: 0x208B540 Offset: 0x2089B40 VA: 0x18208B540
	public static AppMapMarkers Deserialize(Stream stream, AppMapMarkers instance, bool isDelta) { }

	// RVA: 0x208AC20 Offset: 0x2089220 VA: 0x18208AC20
	public static AppMapMarkers DeserializeLengthDelimited(Stream stream, AppMapMarkers instance, bool isDelta) { }

	// RVA: 0x208AF70 Offset: 0x2089570 VA: 0x18208AF70
	public static AppMapMarkers DeserializeLength(Stream stream, int length, AppMapMarkers instance, bool isDelta) { }

	// RVA: 0x208BD10 Offset: 0x208A310 VA: 0x18208BD10
	public static void SerializeDelta(Stream stream, AppMapMarkers instance, AppMapMarkers previous) { }

	// RVA: 0x208C0B0 Offset: 0x208A6B0 VA: 0x18208C0B0
	public static void Serialize(Stream stream, AppMapMarkers instance) { }

	// RVA: 0x208C290 Offset: 0x208A890 VA: 0x18208C290
	public byte[] ToProtoBytes() { }

	// RVA: 0x208C2A0 Offset: 0x208A8A0 VA: 0x18208C2A0
	public void ToProto(Stream stream) { }

	// RVA: 0x208BFA0 Offset: 0x208A5A0 VA: 0x18208BFA0
	public static byte[] SerializeToBytes(AppMapMarkers instance) { }

	// RVA: 0x208BEF0 Offset: 0x208A4F0 VA: 0x18208BEF0
	public static void SerializeLengthDelimited(Stream stream, AppMapMarkers instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class AppTeamChanged : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6537
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong playerId; // 0x18
	public AppTeamInfo teamInfo; // 0x20

	// Methods

	// RVA: 0x1E1C290 Offset: 0x1E1A890 VA: 0x181E1C290
	public static void ResetToPool(AppTeamChanged instance) { }

	// RVA: 0x1E1C1E0 Offset: 0x1E1A7E0 VA: 0x181E1C1E0
	public void ResetToPool() { }

	// RVA: 0x1E1C070 Offset: 0x1E1A670 VA: 0x181E1C070 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E1B400 Offset: 0x1E19A00 VA: 0x181E1B400
	public void CopyTo(AppTeamChanged instance) { }

	// RVA: 0x1E1B480 Offset: 0x1E19A80 VA: 0x181E1B480
	public AppTeamChanged Copy() { }

	// RVA: 0x1E1BBD0 Offset: 0x1E1A1D0 VA: 0x181E1BBD0
	public static AppTeamChanged Deserialize(Stream stream) { }

	// RVA: 0x1E1B550 Offset: 0x1E19B50 VA: 0x181E1B550
	public static AppTeamChanged DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E1B8A0 Offset: 0x1E19EA0 VA: 0x181E1B8A0
	public static AppTeamChanged DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E1BE50 Offset: 0x1E1A450 VA: 0x181E1BE50
	public static AppTeamChanged Deserialize(byte[] buffer) { }

	// RVA: 0x1E1C1A0 Offset: 0x1E1A7A0 VA: 0x181E1C1A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E1C960 Offset: 0x1E1AF60 VA: 0x181E1C960 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E1C980 Offset: 0x1E1AF80 VA: 0x181E1C980 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppTeamChanged previous) { }

	// RVA: 0x1E1C1C0 Offset: 0x1E1A7C0 VA: 0x181E1C1C0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E1BF70 Offset: 0x1E1A570 VA: 0x181E1BF70
	public static AppTeamChanged Deserialize(byte[] buffer, AppTeamChanged instance, bool isDelta = False) { }

	// RVA: 0x1E1BC50 Offset: 0x1E1A250 VA: 0x181E1BC50
	public static AppTeamChanged Deserialize(Stream stream, AppTeamChanged instance, bool isDelta) { }

	// RVA: 0x1E1B5D0 Offset: 0x1E19BD0 VA: 0x181E1B5D0
	public static AppTeamChanged DeserializeLengthDelimited(Stream stream, AppTeamChanged instance, bool isDelta) { }

	// RVA: 0x1E1B930 Offset: 0x1E19F30 VA: 0x181E1B930
	public static AppTeamChanged DeserializeLength(Stream stream, int length, AppTeamChanged instance, bool isDelta) { }

	// RVA: 0x1E1C340 Offset: 0x1E1A940 VA: 0x181E1C340
	public static void SerializeDelta(Stream stream, AppTeamChanged instance, AppTeamChanged previous) { }

	// RVA: 0x1E1C740 Offset: 0x1E1AD40 VA: 0x181E1C740
	public static void Serialize(Stream stream, AppTeamChanged instance) { }

	// RVA: 0x1E1C950 Offset: 0x1E1AF50 VA: 0x181E1C950
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E1C960 Offset: 0x1E1AF60 VA: 0x181E1C960
	public void ToProto(Stream stream) { }

	// RVA: 0x1E1C630 Offset: 0x1E1AC30 VA: 0x181E1C630
	public static byte[] SerializeToBytes(AppTeamChanged instance) { }

	// RVA: 0x1E1C580 Offset: 0x1E1AB80 VA: 0x181E1C580
	public static void SerializeLengthDelimited(Stream stream, AppTeamChanged instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class AppTeamMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6538
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public AppChatMessage message; // 0x18

	// Methods

	// RVA: 0x1E21610 Offset: 0x1E1FC10 VA: 0x181E21610
	public static void ResetToPool(AppTeamMessage instance) { }

	// RVA: 0x1E21570 Offset: 0x1E1FB70 VA: 0x181E21570
	public void ResetToPool() { }

	// RVA: 0x1E21410 Offset: 0x1E1FA10 VA: 0x181E21410 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E20970 Offset: 0x1E1EF70 VA: 0x181E20970
	public void CopyTo(AppTeamMessage instance) { }

	// RVA: 0x1E209E0 Offset: 0x1E1EFE0 VA: 0x181E209E0
	public AppTeamMessage Copy() { }

	// RVA: 0x1E21390 Offset: 0x1E1F990 VA: 0x181E21390
	public static AppTeamMessage Deserialize(Stream stream) { }

	// RVA: 0x1E20AB0 Offset: 0x1E1F0B0 VA: 0x181E20AB0
	public static AppTeamMessage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E20F80 Offset: 0x1E1F580 VA: 0x181E20F80
	public static AppTeamMessage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E21110 Offset: 0x1E1F710 VA: 0x181E21110
	public static AppTeamMessage Deserialize(byte[] buffer) { }

	// RVA: 0x1E21530 Offset: 0x1E1FB30 VA: 0x181E21530
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E21C20 Offset: 0x1E20220 VA: 0x181E21C20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E21C40 Offset: 0x1E20240 VA: 0x181E21C40 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppTeamMessage previous) { }

	// RVA: 0x1E21550 Offset: 0x1E1FB50 VA: 0x181E21550 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E21010 Offset: 0x1E1F610 VA: 0x181E21010
	public static AppTeamMessage Deserialize(byte[] buffer, AppTeamMessage instance, bool isDelta = False) { }

	// RVA: 0x1E21230 Offset: 0x1E1F830 VA: 0x181E21230
	public static AppTeamMessage Deserialize(Stream stream, AppTeamMessage instance, bool isDelta) { }

	// RVA: 0x1E20B30 Offset: 0x1E1F130 VA: 0x181E20B30
	public static AppTeamMessage DeserializeLengthDelimited(Stream stream, AppTeamMessage instance, bool isDelta) { }

	// RVA: 0x1E20D70 Offset: 0x1E1F370 VA: 0x181E20D70
	public static AppTeamMessage DeserializeLength(Stream stream, int length, AppTeamMessage instance, bool isDelta) { }

	// RVA: 0x1E216B0 Offset: 0x1E1FCB0 VA: 0x181E216B0
	public static void SerializeDelta(Stream stream, AppTeamMessage instance, AppTeamMessage previous) { }

	// RVA: 0x1E21A50 Offset: 0x1E20050 VA: 0x181E21A50
	public static void Serialize(Stream stream, AppTeamMessage instance) { }

	// RVA: 0x1E21C10 Offset: 0x1E20210 VA: 0x181E21C10
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E21C20 Offset: 0x1E20220 VA: 0x181E21C20
	public void ToProto(Stream stream) { }

	// RVA: 0x1E21940 Offset: 0x1E1FF40 VA: 0x181E21940
	public static byte[] SerializeToBytes(AppTeamMessage instance) { }

	// RVA: 0x1E21890 Offset: 0x1E1FE90 VA: 0x181E21890
	public static void SerializeLengthDelimited(Stream stream, AppTeamMessage instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class AppEntityChanged : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6539
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint entityId; // 0x14
	public AppEntityPayload payload; // 0x18

	// Methods

	// RVA: 0x2081AB0 Offset: 0x20800B0 VA: 0x182081AB0
	public static void ResetToPool(AppEntityChanged instance) { }

	// RVA: 0x2081A00 Offset: 0x2080000 VA: 0x182081A00
	public void ResetToPool() { }

	// RVA: 0x2081890 Offset: 0x207FE90 VA: 0x182081890 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2080C20 Offset: 0x207F220 VA: 0x182080C20
	public void CopyTo(AppEntityChanged instance) { }

	// RVA: 0x2080CA0 Offset: 0x207F2A0 VA: 0x182080CA0
	public AppEntityChanged Copy() { }

	// RVA: 0x20814F0 Offset: 0x207FAF0 VA: 0x1820814F0
	public static AppEntityChanged Deserialize(Stream stream) { }

	// RVA: 0x2081040 Offset: 0x207F640 VA: 0x182081040
	public static AppEntityChanged DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2081360 Offset: 0x207F960 VA: 0x182081360
	public static AppEntityChanged DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2081770 Offset: 0x207FD70 VA: 0x182081770
	public static AppEntityChanged Deserialize(byte[] buffer) { }

	// RVA: 0x20819C0 Offset: 0x207FFC0 VA: 0x1820819C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2082170 Offset: 0x2080770 VA: 0x182082170 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2082190 Offset: 0x2080790 VA: 0x182082190 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppEntityChanged previous) { }

	// RVA: 0x20819E0 Offset: 0x207FFE0 VA: 0x1820819E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20813F0 Offset: 0x207F9F0 VA: 0x1820813F0
	public static AppEntityChanged Deserialize(byte[] buffer, AppEntityChanged instance, bool isDelta = False) { }

	// RVA: 0x2081570 Offset: 0x207FB70 VA: 0x182081570
	public static AppEntityChanged Deserialize(Stream stream, AppEntityChanged instance, bool isDelta) { }

	// RVA: 0x2080D70 Offset: 0x207F370 VA: 0x182080D70
	public static AppEntityChanged DeserializeLengthDelimited(Stream stream, AppEntityChanged instance, bool isDelta) { }

	// RVA: 0x20810C0 Offset: 0x207F6C0 VA: 0x1820810C0
	public static AppEntityChanged DeserializeLength(Stream stream, int length, AppEntityChanged instance, bool isDelta) { }

	// RVA: 0x2081B60 Offset: 0x2080160 VA: 0x182081B60
	public static void SerializeDelta(Stream stream, AppEntityChanged instance, AppEntityChanged previous) { }

	// RVA: 0x2081F50 Offset: 0x2080550 VA: 0x182081F50
	public static void Serialize(Stream stream, AppEntityChanged instance) { }

	// RVA: 0x2082160 Offset: 0x2080760 VA: 0x182082160
	public byte[] ToProtoBytes() { }

	// RVA: 0x2082170 Offset: 0x2080770 VA: 0x182082170
	public void ToProto(Stream stream) { }

	// RVA: 0x2081E40 Offset: 0x2080440 VA: 0x182081E40
	public static byte[] SerializeToBytes(AppEntityChanged instance) { }

	// RVA: 0x2081D90 Offset: 0x2080390 VA: 0x182081D90
	public static void SerializeLengthDelimited(Stream stream, AppEntityChanged instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public enum AppEntityType // TypeDefIndex: 6557
{	// Fields
	public int value__; // 0x0
	public const AppEntityType Switch = 1;
	public const AppEntityType Alarm = 2;
	public const AppEntityType StorageMonitor = 3;

}

public enum AppMarkerType // TypeDefIndex: 6558
{	// Fields
	public int value__; // 0x0
	public const AppMarkerType Undefined = 0;
	public const AppMarkerType Player = 1;
	public const AppMarkerType Explosion = 2;
	public const AppMarkerType VendingMachine = 3;
	public const AppMarkerType CH47 = 4;
	public const AppMarkerType CargoShip = 5;
	public const AppMarkerType Crate = 6;
	public const AppMarkerType GenericRadius = 7;
	public const AppMarkerType PatrolHelicopter = 8;

}

public static class Application // TypeDefIndex: 6613
{	// Fields
	public static bool isQuitting; // 0x0
	public static bool isLoading; // 0x1
	public static bool isReceiving; // 0x2
	public static bool isLoadingSave; // 0x3
	public static bool isLoadingPrefabs; // 0x4

	// Properties
	public static string installPath { get; }
	public static string dataPath { get; }

	// Methods

	// RVA: 0x1B9D8B0 Offset: 0x1B9BEB0 VA: 0x181B9D8B0
	public static void Quit() { }

	// RVA: 0x1B9D920 Offset: 0x1B9BF20 VA: 0x181B9D920
	public static string get_installPath() { }

	// RVA: 0x1B9D910 Offset: 0x1B9BF10 VA: 0x181B9D910
	public static string get_dataPath() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

public enum AppCategory // TypeDefIndex: 7672
{	// Fields
	public int value__; // 0x0
	public const AppCategory Invalid = 0;
	public const AppCategory Utility = 1;
	public const AppCategory Game = 2;

}

public static class Approved // TypeDefIndex: 7722
{	// Fields
	private static Dictionary<ulong, ApprovedSkinInfo> _all; // 0x1E60

	// Properties
	public static IReadOnlyDictionary<ulong, ApprovedSkinInfo> All { get; }

	// Methods

	// RVA: 0x375F90 Offset: 0x374590 VA: 0x180375F90
	private static void Add_2016() { }

	// RVA: 0x39D9B0 Offset: 0x39BFB0 VA: 0x18039D9B0
	private static void Add_December_29_2016() { }

	// RVA: 0x39AD50 Offset: 0x399350 VA: 0x18039AD50
	private static void Add_December_22_2016() { }

	// RVA: 0x396410 Offset: 0x394A10 VA: 0x180396410
	private static void Add_December_15_2016() { }

	// RVA: 0x3A1450 Offset: 0x39FA50 VA: 0x1803A1450
	private static void Add_December_8_2016() { }

	// RVA: 0x39E8E0 Offset: 0x39CEE0 VA: 0x18039E8E0
	private static void Add_December_2_2018() { }

	// RVA: 0x398830 Offset: 0x396E30 VA: 0x180398830
	private static void Add_December_1_2016() { }

	// RVA: 0x400760 Offset: 0x3FED60 VA: 0x180400760
	private static void Add_November_24_2016() { }

	// RVA: 0x3FD590 Offset: 0x3FBB90 VA: 0x1803FD590
	private static void Add_November_17_2016() { }

	// RVA: 0x3FBF40 Offset: 0x3FA540 VA: 0x1803FBF40
	private static void Add_November_16_2016() { }

	// RVA: 0x3F9A90 Offset: 0x3F8090 VA: 0x1803F9A90
	private static void Add_November_10_2016() { }

	// RVA: 0x4047C0 Offset: 0x402DC0 VA: 0x1804047C0
	private static void Add_November_3_2016() { }

	// RVA: 0x375FF0 Offset: 0x3745F0 VA: 0x180375FF0
	private static void Add_2017() { }

	// RVA: 0x39CF40 Offset: 0x39B540 VA: 0x18039CF40
	private static void Add_December_28_2017() { }

	// RVA: 0x39A600 Offset: 0x398C00 VA: 0x18039A600
	private static void Add_December_21_2017() { }

	// RVA: 0x395D90 Offset: 0x394390 VA: 0x180395D90
	private static void Add_December_14_2017() { }

	// RVA: 0x3A09E0 Offset: 0x39EFE0 VA: 0x1803A09E0
	private static void Add_December_7_2017() { }

	// RVA: 0x403DF0 Offset: 0x4023F0 VA: 0x180403DF0
	private static void Add_November_30_2017() { }

	// RVA: 0x3FFF50 Offset: 0x3FE550 VA: 0x1803FFF50
	private static void Add_November_23_2017() { }

	// RVA: 0x3FCB20 Offset: 0x3FB120 VA: 0x1803FCB20
	private static void Add_November_16_2017() { }

	// RVA: 0x405E20 Offset: 0x404420 VA: 0x180405E20
	private static void Add_November_9_2017() { }

	// RVA: 0x4032B0 Offset: 0x4018B0 VA: 0x1804032B0
	private static void Add_November_2_2017() { }

	// RVA: 0x40D7A0 Offset: 0x40BDA0 VA: 0x18040D7A0
	private static void Add_October_26_2017() { }

	// RVA: 0x40A540 Offset: 0x408B40 VA: 0x18040A540
	private static void Add_October_19_2017() { }

	// RVA: 0x408420 Offset: 0x406A20 VA: 0x180408420
	private static void Add_October_12_2017() { }

	// RVA: 0x4112E0 Offset: 0x40F8E0 VA: 0x1804112E0
	private static void Add_October_5_2017() { }

	// RVA: 0x41A4C0 Offset: 0x418AC0 VA: 0x18041A4C0
	private static void Add_September_28_2017() { }

	// RVA: 0x417E00 Offset: 0x416400 VA: 0x180417E00
	private static void Add_September_21_2017() { }

	// RVA: 0x414FE0 Offset: 0x4135E0 VA: 0x180414FE0
	private static void Add_September_14_2017() { }

	// RVA: 0x41C820 Offset: 0x41AE20 VA: 0x18041C820
	private static void Add_September_7_2017() { }

	// RVA: 0x390760 Offset: 0x38ED60 VA: 0x180390760
	private static void Add_August_31_2017() { }

	// RVA: 0x38DD50 Offset: 0x38C350 VA: 0x18038DD50
	private static void Add_August_24_2017() { }

	// RVA: 0x38A7B0 Offset: 0x388DB0 VA: 0x18038A7B0
	private static void Add_August_17_2017() { }

	// RVA: 0x387140 Offset: 0x385740 VA: 0x180387140
	private static void Add_August_10_2017() { }

	// RVA: 0x391500 Offset: 0x38FB00 VA: 0x180391500
	private static void Add_August_3_2017() { }

	// RVA: 0x3C8870 Offset: 0x3C6E70 VA: 0x1803C8870
	private static void Add_July_27_2017() { }

	// RVA: 0x3C56B0 Offset: 0x3C3CB0 VA: 0x1803C56B0
	private static void Add_July_20_2017() { }

	// RVA: 0x3C14D0 Offset: 0x3BFAD0 VA: 0x1803C14D0
	private static void Add_July_13_2017() { }

	// RVA: 0x3CC3F0 Offset: 0x3CA9F0 VA: 0x1803CC3F0
	private static void Add_July_6_2017() { }

	// RVA: 0x3D7A30 Offset: 0x3D6030 VA: 0x1803D7A30
	private static void Add_June_29_2017() { }

	// RVA: 0x3D14C0 Offset: 0x3CFAC0 VA: 0x1803D14C0
	private static void Add_June_15_2017() { }

	// RVA: 0x3DA980 Offset: 0x3D8F80 VA: 0x1803DA980
	private static void Add_June_8_2017() { }

	// RVA: 0x3D3940 Offset: 0x3D1F40 VA: 0x1803D3940
	private static void Add_June_1_2017() { }

	// RVA: 0x3F33B0 Offset: 0x3F19B0 VA: 0x1803F33B0
	private static void Add_May_25_2017() { }

	// RVA: 0x3EFCA0 Offset: 0x3EE2A0 VA: 0x1803EFCA0
	private static void Add_May_18_2017() { }

	// RVA: 0x3ED600 Offset: 0x3EBC00 VA: 0x1803ED600
	private static void Add_May_11_2017() { }

	// RVA: 0x3F7580 Offset: 0x3F5B80 VA: 0x1803F7580
	private static void Add_May_4_2017() { }

	// RVA: 0x37FF20 Offset: 0x37E520 VA: 0x18037FF20
	private static void Add_April_27_2017() { }

	// RVA: 0x37CDA0 Offset: 0x37B3A0 VA: 0x18037CDA0
	private static void Add_April_20_2017() { }

	// RVA: 0x3790B0 Offset: 0x3776B0 VA: 0x1803790B0
	private static void Add_April_13_2017() { }

	// RVA: 0x383A90 Offset: 0x382090 VA: 0x180383A90
	private static void Add_April_6_2017() { }

	// RVA: 0x3E7AE0 Offset: 0x3E60E0 VA: 0x1803E7AE0
	private static void Add_March_30_2017() { }

	// RVA: 0x3E3730 Offset: 0x3E1D30 VA: 0x1803E3730
	private static void Add_March_23_2017() { }

	// RVA: 0x3DE8D0 Offset: 0x3DCED0 VA: 0x1803DE8D0
	private static void Add_March_15_2017() { }

	// RVA: 0x3EA1E0 Offset: 0x3E87E0 VA: 0x1803EA1E0
	private static void Add_March_8_2017() { }

	// RVA: 0x3E6A20 Offset: 0x3E5020 VA: 0x1803E6A20
	private static void Add_March_2_2017() { }

	// RVA: 0x3AAF00 Offset: 0x3A9500 VA: 0x1803AAF00
	private static void Add_February_23_2017() { }

	// RVA: 0x3A75D0 Offset: 0x3A5BD0 VA: 0x1803A75D0
	private static void Add_February_16_2017() { }

	// RVA: 0x3AFD60 Offset: 0x3AE360 VA: 0x1803AFD60
	private static void Add_February_9_2017() { }

	// RVA: 0x3AD5C0 Offset: 0x3ABBC0 VA: 0x1803AD5C0
	private static void Add_February_2_2017() { }

	// RVA: 0x3B7570 Offset: 0x3B5B70 VA: 0x1803B7570
	private static void Add_January_18_2017() { }

	// RVA: 0x3B44F0 Offset: 0x3B2AF0 VA: 0x1803B44F0
	private static void Add_January_12_2017() { }

	// RVA: 0x3BD2F0 Offset: 0x3BB8F0 VA: 0x1803BD2F0
	private static void Add_January_4_2017() { }

	// RVA: 0x376160 Offset: 0x374760 VA: 0x180376160
	private static void Add_2018() { }

	// RVA: 0x399B40 Offset: 0x398140 VA: 0x180399B40
	private static void Add_December_20_2018() { }

	// RVA: 0x395610 Offset: 0x393C10 VA: 0x180395610
	private static void Add_December_13_2020() { }

	// RVA: 0x3A0350 Offset: 0x39E950 VA: 0x1803A0350
	private static void Add_December_6_2018() { }

	// RVA: 0x402C20 Offset: 0x401220 VA: 0x180402C20
	private static void Add_November_29_2018() { }

	// RVA: 0x3FF8C0 Offset: 0x3FDEC0 VA: 0x1803FF8C0
	private static void Add_November_22_2018() { }

	// RVA: 0x3FB890 Offset: 0x3F9E90 VA: 0x1803FB890
	private static void Add_November_15_2018() { }

	// RVA: 0x406890 Offset: 0x404E90 VA: 0x180406890
	private static void Add_November_9_2018() { }

	// RVA: 0x3FEBA0 Offset: 0x3FD1A0 VA: 0x1803FEBA0
	private static void Add_November_1_2018() { }

	// RVA: 0x40E3A0 Offset: 0x40C9A0 VA: 0x18040E3A0
	private static void Add_October_26_2018() { }

	// RVA: 0x40B140 Offset: 0x409740 VA: 0x18040B140
	private static void Add_October_19_2018() { }

	// RVA: 0x4076E0 Offset: 0x405CE0 VA: 0x1804076E0
	private static void Add_October_11_2018() { }

	// RVA: 0x410AA0 Offset: 0x40F0A0 VA: 0x180410AA0
	private static void Add_October_4_2018() { }

	// RVA: 0x419E20 Offset: 0x418420 VA: 0x180419E20
	private static void Add_September_27_2018() { }

	// RVA: 0x417760 Offset: 0x415D60 VA: 0x180417760
	private static void Add_September_20_2018() { }

	// RVA: 0x415990 Offset: 0x413F90 VA: 0x180415990
	private static void Add_September_14_2018() { }

	// RVA: 0x41BE10 Offset: 0x41A410 VA: 0x18041BE10
	private static void Add_September_5_2018() { }

	// RVA: 0x38D6C0 Offset: 0x38BCC0 VA: 0x18038D6C0
	private static void Add_August_23_2018() { }

	// RVA: 0x389F80 Offset: 0x388580 VA: 0x180389F80
	private static void Add_August_16_2018() { }

	// RVA: 0x392100 Offset: 0x390700 VA: 0x180392100
	private static void Add_August_9_2018() { }

	// RVA: 0x38FD90 Offset: 0x38E390 VA: 0x18038FD90
	private static void Add_August_2_2018() { }

	// RVA: 0x3C7760 Offset: 0x3C5D60 VA: 0x1803C7760
	private static void Add_July_26_2018() { }

	// RVA: 0x3C4640 Offset: 0x3C2C40 VA: 0x1803C4640
	private static void Add_July_19_2018() { }

	// RVA: 0x3C03A0 Offset: 0x3BE9A0 VA: 0x1803C03A0
	private static void Add_July_12_2018() { }

	// RVA: 0x3CB3A0 Offset: 0x3C99A0 VA: 0x1803CB3A0
	private static void Add_July_5_2018() { }

	// RVA: 0x3D6B70 Offset: 0x3D5170 VA: 0x1803D6B70
	private static void Add_June_28_2018() { }

	// RVA: 0x3D4D80 Offset: 0x3D3380 VA: 0x1803D4D80
	private static void Add_June_22_2018() { }

	// RVA: 0x3D01C0 Offset: 0x3CE7C0 VA: 0x1803D01C0
	private static void Add_June_14_2018() { }

	// RVA: 0x3D9EF0 Offset: 0x3D84F0 VA: 0x1803D9EF0
	private static void Add_June_7_2018() { }

	// RVA: 0x3F6AE0 Offset: 0x3F50E0 VA: 0x1803F6AE0
	private static void Add_May_31_2018() { }

	// RVA: 0x3F2360 Offset: 0x3F0960 VA: 0x1803F2360
	private static void Add_May_24_2018() { }

	// RVA: 0x3F53E0 Offset: 0x3F39E0 VA: 0x1803F53E0
	private static void Add_May_2_2018() { }

	// RVA: 0x37F380 Offset: 0x37D980 VA: 0x18037F380
	private static void Add_April_26_2018() { }

	// RVA: 0x37BBC0 Offset: 0x37A1C0 VA: 0x18037BBC0
	private static void Add_April_19_2018() { }

	// RVA: 0x378490 Offset: 0x376A90 VA: 0x180378490
	private static void Add_April_12_2018() { }

	// RVA: 0x382870 Offset: 0x380E70 VA: 0x180382870
	private static void Add_April_5_2018() { }

	// RVA: 0x3E6050 Offset: 0x3E4650 VA: 0x1803E6050
	private static void Add_March_29_2018() { }

	// RVA: 0x3E26A0 Offset: 0x3E0CA0 VA: 0x1803E26A0
	private static void Add_March_22_2018() { }

	// RVA: 0x3DF670 Offset: 0x3DDC70 VA: 0x1803DF670
	private static void Add_March_15_2018() { }

	// RVA: 0x3EAB90 Offset: 0x3E9190 VA: 0x1803EAB90
	private static void Add_March_8_2018() { }

	// RVA: 0x3E1580 Offset: 0x3DFB80 VA: 0x1803E1580
	private static void Add_March_1_2018() { }

	// RVA: 0x3AA340 Offset: 0x3A8940 VA: 0x1803AA340
	private static void Add_February_22_2018() { }

	// RVA: 0x3A6C20 Offset: 0x3A5220 VA: 0x1803A6C20
	private static void Add_February_15_2018() { }

	// RVA: 0x3AED40 Offset: 0x3AD340 VA: 0x1803AED40
	private static void Add_February_8_2018() { }

	// RVA: 0x3A9230 Offset: 0x3A7830 VA: 0x1803A9230
	private static void Add_February_1_2018() { }

	// RVA: 0x3B9D10 Offset: 0x3B8310 VA: 0x1803B9D10
	private static void Add_January_25_2018() { }

	// RVA: 0x3B7F20 Offset: 0x3B6520 VA: 0x1803B7F20
	private static void Add_January_18_2018() { }

	// RVA: 0x3B3B30 Offset: 0x3B2130 VA: 0x1803B3B30
	private static void Add_January_11_2018() { }

	// RVA: 0x3BDB00 Offset: 0x3BC100 VA: 0x1803BDB00
	private static void Add_January_4_2018() { }

	// RVA: 0x3762C0 Offset: 0x3748C0 VA: 0x1803762C0
	private static void Add_2019() { }

	// RVA: 0x39C890 Offset: 0x39AE90 VA: 0x18039C890
	private static void Add_December_27_2019() { }

	// RVA: 0x397E70 Offset: 0x396470 VA: 0x180397E70
	private static void Add_December_19_2019() { }

	// RVA: 0x394F70 Offset: 0x393570 VA: 0x180394F70
	private static void Add_December_12_2019() { }

	// RVA: 0x39FCC0 Offset: 0x39E2C0 VA: 0x18039FCC0
	private static void Add_December_5_2019() { }

	// RVA: 0x402260 Offset: 0x400860 VA: 0x180402260
	private static void Add_November_28_2019() { }

	// RVA: 0x3FF230 Offset: 0x3FD830 VA: 0x1803FF230
	private static void Add_November_21_2019() { }

	// RVA: 0x3FB1C0 Offset: 0x3F97C0 VA: 0x1803FB1C0
	private static void Add_November_14_2019() { }

	// RVA: 0x4055F0 Offset: 0x403BF0 VA: 0x1804055F0
	private static void Add_November_7_2019() { }

	// RVA: 0x40FCA0 Offset: 0x40E2A0 VA: 0x18040FCA0
	private static void Add_October_31_2019() { }

	// RVA: 0x40CD90 Offset: 0x40B390 VA: 0x18040CD90
	private static void Add_October_24_2019() { }

	// RVA: 0x409CE0 Offset: 0x4082E0 VA: 0x180409CE0
	private static void Add_October_18_2019() { }

	// RVA: 0x407D80 Offset: 0x406380 VA: 0x180407D80
	private static void Add_October_11_2019() { }

	// RVA: 0x410400 Offset: 0x40EA00 VA: 0x180410400
	private static void Add_October_3_2019() { }

	// RVA: 0x419770 Offset: 0x417D70 VA: 0x180419770
	private static void Add_September_26_2019() { }

	// RVA: 0x416E80 Offset: 0x415480 VA: 0x180416E80
	private static void Add_September_19_2019() { }

	// RVA: 0x414950 Offset: 0x412F50 VA: 0x180414950
	private static void Add_September_12_2019() { }

	// RVA: 0x41D360 Offset: 0x41B960 VA: 0x18041D360
	private static void Add_September_9_2019() { }

	// RVA: 0x38F6E0 Offset: 0x38DCE0 VA: 0x18038F6E0
	private static void Add_August_29_2019() { }

	// RVA: 0x38CF70 Offset: 0x38B570 VA: 0x18038CF70
	private static void Add_August_22_2019() { }

	// RVA: 0x3895B0 Offset: 0x387BB0 VA: 0x1803895B0
	private static void Add_August_15_2019() { }

	// RVA: 0x392AE0 Offset: 0x3910E0 VA: 0x180392AE0
	private static void Add_August_9_2019() { }

	// RVA: 0x38C250 Offset: 0x38A850 VA: 0x18038C250
	private static void Add_August_1_2019() { }

	// RVA: 0x3C81E0 Offset: 0x3C67E0 VA: 0x1803C81E0
	private static void Add_July_26_2019() { }

	// RVA: 0x3C5010 Offset: 0x3C3610 VA: 0x1803C5010
	private static void Add_July_19_2019() { }

	// RVA: 0x3C0D70 Offset: 0x3BF370 VA: 0x1803C0D70
	private static void Add_July_12_2019() { }

	// RVA: 0x3CBD60 Offset: 0x3CA360 VA: 0x1803CBD60
	private static void Add_July_5_2019() { }

	// RVA: 0x3D7390 Offset: 0x3D5990 VA: 0x1803D7390
	private static void Add_June_28_2019() { }

	// RVA: 0x3D46E0 Offset: 0x3D2CE0 VA: 0x1803D46E0
	private static void Add_June_21_2019() { }

	// RVA: 0x3D0BB0 Offset: 0x3CF1B0 VA: 0x1803D0BB0
	private static void Add_June_14_2019() { }

	// RVA: 0x3D9870 Offset: 0x3D7E70 VA: 0x1803D9870
	private static void Add_June_6_2019() { }

	// RVA: 0x3F6450 Offset: 0x3F4A50 VA: 0x1803F6450
	private static void Add_May_30_2019() { }

	// RVA: 0x3F1CA0 Offset: 0x3F02A0 VA: 0x1803F1CA0
	private static void Add_May_23_2019() { }

	// RVA: 0x3EF620 Offset: 0x3EDC20 VA: 0x1803EF620
	private static void Add_May_16_2019() { }

	// RVA: 0x3F8680 Offset: 0x3F6C80 VA: 0x1803F8680
	private static void Add_May_9_2019() { }

	// RVA: 0x3F5DB0 Offset: 0x3F43B0 VA: 0x1803F5DB0
	private static void Add_May_2_2019() { }

	// RVA: 0x37ECF0 Offset: 0x37D2F0 VA: 0x18037ECF0
	private static void Add_April_25_2019() { }

	// RVA: 0x37C590 Offset: 0x37AB90 VA: 0x18037C590
	private static void Add_April_19_2019() { }

	// RVA: 0x377DF0 Offset: 0x3763F0 VA: 0x180377DF0
	private static void Add_April_11_2019() { }

	// RVA: 0x3833D0 Offset: 0x3819D0 VA: 0x1803833D0
	private static void Add_April_5_2019() { }

	// RVA: 0x3E5320 Offset: 0x3E3920 VA: 0x1803E5320
	private static void Add_March_28_2019() { }

	// RVA: 0x3E3080 Offset: 0x3E1680 VA: 0x1803E3080
	private static void Add_March_22_2019() { }

	// RVA: 0x3DE250 Offset: 0x3DC850 VA: 0x1803DE250
	private static void Add_March_14_2019() { }

	// RVA: 0x3E9B40 Offset: 0x3E8140 VA: 0x1803E9B40
	private static void Add_March_7_2019() { }

	// RVA: 0x3ACF30 Offset: 0x3AB530 VA: 0x1803ACF30
	private static void Add_February_28_2019() { }

	// RVA: 0x3AA860 Offset: 0x3A8E60 VA: 0x1803AA860
	private static void Add_February_22_2019() { }

	// RVA: 0x3A6590 Offset: 0x3A4B90 VA: 0x1803A6590
	private static void Add_February_14_2019() { }

	// RVA: 0x3AE910 Offset: 0x3ACF10 VA: 0x1803AE910
	private static void Add_February_7_2019() { }

	// RVA: 0x3BBBE0 Offset: 0x3BA1E0 VA: 0x1803BBBE0
	private static void Add_January_31_2019() { }

	// RVA: 0x3B9650 Offset: 0x3B7C50 VA: 0x1803B9650
	private static void Add_January_24_2019() { }

	// RVA: 0x3B6860 Offset: 0x3B4E60 VA: 0x1803B6860
	private static void Add_January_17_2019() { }

	// RVA: 0x3B2E00 Offset: 0x3B1400 VA: 0x1803B2E00
	private static void Add_January_10_2019() { }

	// RVA: 0x3BC920 Offset: 0x3BAF20 VA: 0x1803BC920
	private static void Add_January_3_2019() { }

	// RVA: 0x376440 Offset: 0x374A40 VA: 0x180376440
	private static void Add_2020() { }

	// RVA: 0x39F5F0 Offset: 0x39DBF0 VA: 0x18039F5F0
	private static void Add_December_31_2020() { }

	// RVA: 0x39C290 Offset: 0x39A890 VA: 0x18039C290
	private static void Add_December_24_2020() { }

	// RVA: 0x397600 Offset: 0x395C00 VA: 0x180397600
	private static void Add_December_18_2020() { }

	// RVA: 0x3948E0 Offset: 0x392EE0 VA: 0x1803948E0
	private static void Add_December_10_2020() { }

	// RVA: 0x3939F0 Offset: 0x391FF0 VA: 0x1803939F0
	private static void Add_December_03_2020() { }

	// RVA: 0x401BD0 Offset: 0x4001D0 VA: 0x180401BD0
	private static void Add_November_26_2020() { }

	// RVA: 0x3FDCC0 Offset: 0x3FC2C0 VA: 0x1803FDCC0
	private static void Add_November_19_2020() { }

	// RVA: 0x3FAB00 Offset: 0x3F9100 VA: 0x1803FAB00
	private static void Add_November_12_2020() { }

	// RVA: 0x3F9400 Offset: 0x3F7A00 VA: 0x1803F9400
	private static void Add_November_05_2020() { }

	// RVA: 0x40F370 Offset: 0x40D970 VA: 0x18040F370
	private static void Add_October_29_2020() { }

	// RVA: 0x40C6E0 Offset: 0x40ACE0 VA: 0x18040C6E0
	private static void Add_October_22_2020() { }

	// RVA: 0x409620 Offset: 0x407C20 VA: 0x180409620
	private static void Add_October_16_2020() { }

	// RVA: 0x412080 Offset: 0x410680 VA: 0x180412080
	private static void Add_October_8_2020() { }

	// RVA: 0x40B970 Offset: 0x409F70 VA: 0x18040B970
	private static void Add_October_1_2020() { }

	// RVA: 0x4190E0 Offset: 0x4176E0 VA: 0x1804190E0
	private static void Add_September_24_2020() { }

	// RVA: 0x4167C0 Offset: 0x414DC0 VA: 0x1804167C0
	private static void Add_September_17_2020() { }

	// RVA: 0x414100 Offset: 0x412700 VA: 0x180414100
	private static void Add_September_10_2020() { }

	// RVA: 0x41B790 Offset: 0x419D90 VA: 0x18041B790
	private static void Add_September_3_2020() { }

	// RVA: 0x38F030 Offset: 0x38D630 VA: 0x18038F030
	private static void Add_August_27_2020() { }

	// RVA: 0x38C8D0 Offset: 0x38AED0 VA: 0x18038C8D0
	private static void Add_August_21_2020() { }

	// RVA: 0x388EB0 Offset: 0x3874B0 VA: 0x180388EB0
	private static void Add_August_13_2020() { }

	// RVA: 0x385BA0 Offset: 0x3841A0 VA: 0x180385BA0
	private static void Add_August_06_2020() { }

	// RVA: 0x3CABC0 Offset: 0x3C91C0 VA: 0x1803CABC0
	private static void Add_July_31_2020() { }

	// RVA: 0x3C7060 Offset: 0x3C5660 VA: 0x1803C7060
	private static void Add_July_24_2020() { }

	// RVA: 0x3C3F40 Offset: 0x3C2540 VA: 0x1803C3F40
	private static void Add_July_17_2020() { }

	// RVA: 0x3CD4B0 Offset: 0x3CBAB0 VA: 0x1803CD4B0
	private static void Add_July_9_2020() { }

	// RVA: 0x3CA150 Offset: 0x3C8750 VA: 0x1803CA150
	private static void Add_July_2_2020() { }

	// RVA: 0x3D64C0 Offset: 0x3D4AC0 VA: 0x1803D64C0
	private static void Add_June_26_2020() { }

	// RVA: 0x3D30F0 Offset: 0x3D16F0 VA: 0x1803D30F0
	private static void Add_June_19_2020() { }

	// RVA: 0x3CFB00 Offset: 0x3CE100 VA: 0x1803CFB00
	private static void Add_June_11_2020() { }

	// RVA: 0x3D91E0 Offset: 0x3D77E0 VA: 0x1803D91E0
	private static void Add_June_4_2020() { }

	// RVA: 0x3F4D40 Offset: 0x3F3340 VA: 0x1803F4D40
	private static void Add_May_28_2020() { }

	// RVA: 0x3F1610 Offset: 0x3EFC10 VA: 0x1803F1610
	private static void Add_May_21_2020() { }

	// RVA: 0x3EEF70 Offset: 0x3ED570 VA: 0x1803EEF70
	private static void Add_May_14_2020() { }

	// RVA: 0x3F7FF0 Offset: 0x3F65F0 VA: 0x1803F7FF0
	private static void Add_May_8_2020() { }

	// RVA: 0x3821F0 Offset: 0x3807F0 VA: 0x1803821F0
	private static void Add_April_30_2020() { }

	// RVA: 0x37E640 Offset: 0x37CC40 VA: 0x18037E640
	private static void Add_April_24_2020() { }

	// RVA: 0x37B520 Offset: 0x379B20 VA: 0x18037B520
	private static void Add_April_16_2020() { }

	// RVA: 0x384450 Offset: 0x382A50 VA: 0x180384450
	private static void Add_April_9_2020() { }

	// RVA: 0x381B70 Offset: 0x380170 VA: 0x180381B70
	private static void Add_April_2_2020() { }

	// RVA: 0x3E59B0 Offset: 0x3E3FB0 VA: 0x1803E59B0
	private static void Add_March_28_2020() { }

	// RVA: 0x3E2010 Offset: 0x3E0610 VA: 0x1803E2010
	private static void Add_March_20_2020() { }

	// RVA: 0x3DDBB0 Offset: 0x3DC1B0 VA: 0x1803DDBB0
	private static void Add_March_13_2020() { }

	// RVA: 0x3E94B0 Offset: 0x3E7AB0 VA: 0x1803E94B0
	private static void Add_March_5_2020() { }

	// RVA: 0x3AC8A0 Offset: 0x3AAEA0 VA: 0x1803AC8A0
	private static void Add_February_27_2020() { }

	// RVA: 0x3A9BE0 Offset: 0x3A81E0 VA: 0x1803A9BE0
	private static void Add_February_21_2020() { }

	// RVA: 0x3A5B20 Offset: 0x3A4120 VA: 0x1803A5B20
	private static void Add_February_13_2020() { }

	// RVA: 0x3AE290 Offset: 0x3AC890 VA: 0x1803AE290
	private static void Add_February_6_2020() { }

	// RVA: 0x3BC270 Offset: 0x3BA870 VA: 0x1803BC270
	private static void Add_January_31_2020() { }

	// RVA: 0x3B6EF0 Offset: 0x3B54F0 VA: 0x1803B6EF0
	private static void Add_January_17_2020() { }

	// RVA: 0x3B34A0 Offset: 0x3B1AA0 VA: 0x1803B34A0
	private static void Add_January_10_2020() { }

	// RVA: 0x3BB550 Offset: 0x3B9B50 VA: 0x1803BB550
	private static void Add_January_2_2020() { }

	// RVA: 0x3765C0 Offset: 0x374BC0 VA: 0x1803765C0
	private static void Add_2021() { }

	// RVA: 0x39EE30 Offset: 0x39D430 VA: 0x18039EE30
	private static void Add_December_30_2021() { }

	// RVA: 0x39BB00 Offset: 0x39A100 VA: 0x18039BB00
	private static void Add_December_23_2021() { }

	// RVA: 0x396DC0 Offset: 0x3953C0 VA: 0x180396DC0
	private static void Add_December_16_2021() { }

	// RVA: 0x394090 Offset: 0x392690 VA: 0x180394090
	private static void Add_December_09_2021() { }

	// RVA: 0x393310 Offset: 0x391910 VA: 0x180393310
	private static void Add_December_02_2021() { }

	// RVA: 0x4014E0 Offset: 0x3FFAE0 VA: 0x1804014E0
	private static void Add_November_25_2021() { }

	// RVA: 0x3FE730 Offset: 0x3FCD30 VA: 0x1803FE730
	private static void Add_November_19_2021_TWITCHDROPS() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void Add_November_18_2021() { }

	// RVA: 0x3FE3A0 Offset: 0x3FC9A0 VA: 0x1803FE3A0
	private static void Add_November_19_2021_CHARITABLE_RUST() { }

	// RVA: 0x3FA350 Offset: 0x3F8950 VA: 0x1803FA350
	private static void Add_November_11_2021() { }

	// RVA: 0x3F8D30 Offset: 0x3F7330 VA: 0x1803F8D30
	private static void Add_November_04_2021() { }

	// RVA: 0x40EBE0 Offset: 0x40D1E0 VA: 0x18040EBE0
	private static void Add_October_27_2021() { }

	// RVA: 0x40BF50 Offset: 0x40A550 VA: 0x18040BF50
	private static void Add_October_21_2021() { }

	// RVA: 0x408F60 Offset: 0x407560 VA: 0x180408F60
	private static void Add_October_14_2021() { }

	// RVA: 0x406FF0 Offset: 0x4055F0 VA: 0x180406FF0
	private static void Add_October_07_2021() { }

	// RVA: 0x41B0C0 Offset: 0x4196C0 VA: 0x18041B0C0
	private static void Add_September_30_2021() { }

	// RVA: 0x418870 Offset: 0x416E70 VA: 0x180418870
	private static void Add_September_23_2021() { }

	// RVA: 0x416020 Offset: 0x414620 VA: 0x180416020
	private static void Add_September_16_2021() { }

	// RVA: 0x413870 Offset: 0x411E70 VA: 0x180413870
	private static void Add_September_09_2021() { }

	// RVA: 0x4130C0 Offset: 0x4116C0 VA: 0x1804130C0
	private static void Add_September_02_2021() { }

	// RVA: 0x412810 Offset: 0x410E10 VA: 0x180412810
	private static void Add_September_01_2021_STREAMERSKINS() { }

	// RVA: 0x38E950 Offset: 0x38CF50 VA: 0x18038E950
	private static void Add_August_26_2021() { }

	// RVA: 0x38B810 Offset: 0x389E10 VA: 0x18038B810
	private static void Add_August_19_2021() { }

	// RVA: 0x3887E0 Offset: 0x386DE0 VA: 0x1803887E0
	private static void Add_August_12_2021() { }

	// RVA: 0x384940 Offset: 0x382F40 VA: 0x180384940
	private static void Add_August_04_2021() { }

	// RVA: 0x3C9A80 Offset: 0x3C8080 VA: 0x1803C9A80
	private static void Add_July_29_2021() { }

	// RVA: 0x3C6980 Offset: 0x3C4F80 VA: 0x1803C6980
	private static void Add_July_22_2021() { }

	// RVA: 0x3C2AC0 Offset: 0x3C10C0 VA: 0x1803C2AC0
	private static void Add_July_15_2021_STREAMERSKINS() { }

	// RVA: 0x3C36D0 Offset: 0x3C1CD0 VA: 0x1803C36D0
	private static void Add_July_15_2021() { }

	// RVA: 0x3BFCC0 Offset: 0x3BE2C0 VA: 0x1803BFCC0
	private static void Add_July_08_2021() { }

	// RVA: 0x3BEB70 Offset: 0x3BD170 VA: 0x1803BEB70
	private static void Add_July_05_2021_STREAMERSKINS() { }

	// RVA: 0x3BE4B0 Offset: 0x3BCAB0 VA: 0x1803BE4B0
	private static void Add_July_01_2021() { }

	// RVA: 0x3D5DF0 Offset: 0x3D43F0 VA: 0x1803D5DF0
	private static void Add_June_24_2021() { }

	// RVA: 0x3D2880 Offset: 0x3D0E80 VA: 0x1803D2880
	private static void Add_June_17_2021() { }

	// RVA: 0x3CF420 Offset: 0x3CDA20 VA: 0x1803CF420
	private static void Add_June_10_2021() { }

	// RVA: 0x3CE6A0 Offset: 0x3CCCA0 VA: 0x1803CE6A0
	private static void Add_June_03_2021() { }

	// RVA: 0x3F45C0 Offset: 0x3F2BC0 VA: 0x1803F45C0
	private static void Add_May_27_2021() { }

	// RVA: 0x3F0EA0 Offset: 0x3EF4A0 VA: 0x1803F0EA0
	private static void Add_May_20_2021() { }

	// RVA: 0x3EE7C0 Offset: 0x3ECDC0 VA: 0x1803EE7C0
	private static void Add_May_13_2021() { }

	// RVA: 0x3ECF20 Offset: 0x3EB520 VA: 0x1803ECF20
	private static void Add_May_06_2021() { }

	// RVA: 0x3EBEB0 Offset: 0x3EA4B0 VA: 0x1803EBEB0
	private static void Add_May_05_2021_STREAMERSKINS() { }

	// RVA: 0x3812D0 Offset: 0x37F8D0 VA: 0x1803812D0
	private static void Add_April_29_2021() { }

	// RVA: 0x37DF70 Offset: 0x37C570 VA: 0x18037DF70
	private static void Add_April_22_2021() { }

	// RVA: 0x37AE50 Offset: 0x379450 VA: 0x18037AE50
	private static void Add_April_15_2021() { }

	// RVA: 0x377720 Offset: 0x375D20 VA: 0x180377720
	private static void Add_April_09_2021() { }

	// RVA: 0x3768B0 Offset: 0x374EB0 VA: 0x1803768B0
	private static void Add_April_01_2021() { }

	// RVA: 0x3E8550 Offset: 0x3E6B50 VA: 0x1803E8550
	private static void Add_March_31_2021_STREAMERSKINS() { }

	// RVA: 0x3E4C50 Offset: 0x3E3250 VA: 0x1803E4C50
	private static void Add_March_25_2021() { }

	// RVA: 0x3E0EB0 Offset: 0x3DF4B0 VA: 0x1803E0EB0
	private static void Add_March_18_2021() { }

	// RVA: 0x3DD4E0 Offset: 0x3DBAE0 VA: 0x1803DD4E0
	private static void Add_March_11_2021() { }

	// RVA: 0x3DC780 Offset: 0x3DAD80 VA: 0x1803DC780
	private static void Add_March_04_2021() { }

	// RVA: 0x3DB650 Offset: 0x3D9C50 VA: 0x1803DB650
	private static void Add_March_03_2021_STREAMERSKINS() { }

	// RVA: 0x3AC1D0 Offset: 0x3AA7D0 VA: 0x1803AC1D0
	private static void Add_February_25_2021() { }

	// RVA: 0x3A8B30 Offset: 0x3A7130 VA: 0x1803A8B30
	private static void Add_February_18_2021() { }

	// RVA: 0x3A4FE0 Offset: 0x3A35E0 VA: 0x1803A4FE0
	private static void Add_February_11_2021() { }

	// RVA: 0x3A3C50 Offset: 0x3A2250 VA: 0x1803A3C50
	private static void Add_February_10_2021_STREAMERSKINS() { }

	// RVA: 0x3A3570 Offset: 0x3A1B70 VA: 0x1803A3570
	private static void Add_February_04_2021() { }

	// RVA: 0x3A2520 Offset: 0x3A0B20 VA: 0x1803A2520
	private static void Add_February_03_2021_STREAMERSKINS() { }

	// RVA: 0x3BA6D0 Offset: 0x3B8CD0 VA: 0x1803BA6D0
	private static void Add_January_28_2021() { }

	// RVA: 0x3B8F70 Offset: 0x3B7570 VA: 0x1803B8F70
	private static void Add_January_21_2021() { }

	// RVA: 0x3B5E00 Offset: 0x3B4400 VA: 0x1803B5E00
	private static void Add_January_15_2021_STREAMERSKINS() { }

	// RVA: 0x3B5730 Offset: 0x3B3D30 VA: 0x1803B5730
	private static void Add_January_14_2021() { }

	// RVA: 0x3B2680 Offset: 0x3B0C80 VA: 0x1803B2680
	private static void Add_January_07_2021() { }

	// RVA: 0x3B0C90 Offset: 0x3AF290 VA: 0x1803B0C90
	private static void Add_January_06_2021_STREAMERSKINS() { }

	// RVA: 0x376790 Offset: 0x374D90 VA: 0x180376790
	private static void Add_2022() { }

	// RVA: 0x38B160 Offset: 0x389760 VA: 0x18038B160
	private static void Add_August_18_2022() { }

	// RVA: 0x388070 Offset: 0x386670 VA: 0x180388070
	private static void Add_August_11_2022() { }

	// RVA: 0x386380 Offset: 0x384980 VA: 0x180386380
	private static void Add_August_08_2022_STREAMERSKINS() { }

	// RVA: 0x385320 Offset: 0x383920 VA: 0x180385320
	private static void Add_August_04_2022() { }

	// RVA: 0x3C93B0 Offset: 0x3C79B0 VA: 0x1803C93B0
	private static void Add_July_28_2022() { }

	// RVA: 0x3C61F0 Offset: 0x3C47F0 VA: 0x1803C61F0
	private static void Add_July_21_2022() { }

	// RVA: 0x3C2400 Offset: 0x3C0A00 VA: 0x1803C2400
	private static void Add_July_14_2022() { }

	// RVA: 0x3BF4F0 Offset: 0x3BDAF0 VA: 0x1803BF4F0
	private static void Add_July_07_2022() { }

	// RVA: 0x3D8A30 Offset: 0x3D7030 VA: 0x1803D8A30
	private static void Add_June_30_2022() { }

	// RVA: 0x3D5740 Offset: 0x3D3D40 VA: 0x1803D5740
	private static void Add_June_23_2022() { }

	// RVA: 0x3D1F30 Offset: 0x3D0530 VA: 0x1803D1F30
	private static void Add_June_16_2022() { }

	// RVA: 0x3CED60 Offset: 0x3CD360 VA: 0x1803CED60
	private static void Add_June_09_2022() { }

	// RVA: 0x3CDC90 Offset: 0x3CC290 VA: 0x1803CDC90
	private static void Add_June_02_2022() { }

	// RVA: 0x3F3EF0 Offset: 0x3F24F0 VA: 0x1803F3EF0
	private static void Add_May_26_2022() { }

	// RVA: 0x3F07E0 Offset: 0x3EEDE0 VA: 0x1803F07E0
	private static void Add_May_19_2022() { }

	// RVA: 0x3EE070 Offset: 0x3EC670 VA: 0x1803EE070
	private static void Add_May_12_2022() { }

	// RVA: 0x3EC830 Offset: 0x3EAE30 VA: 0x1803EC830
	private static void Add_May_05_2022() { }

	// RVA: 0x3EB6E0 Offset: 0x3E9CE0 VA: 0x1803EB6E0
	private static void Add_May_04_2022_STREAMERSKINS() { }

	// RVA: 0x380BF0 Offset: 0x37F1F0 VA: 0x180380BF0
	private static void Add_April_28_2022() { }

	// RVA: 0x37D810 Offset: 0x37BE10 VA: 0x18037D810
	private static void Add_April_21_2022() { }

	// RVA: 0x37A3C0 Offset: 0x3789C0 VA: 0x18037A3C0
	private static void Add_April_14_2022_EASTER() { }

	// RVA: 0x379BF0 Offset: 0x3781F0 VA: 0x180379BF0
	private static void Add_April_13_2022_STREAMERSKINS() { }

	// RVA: 0x377030 Offset: 0x375630 VA: 0x180377030
	private static void Add_April_07_2022() { }

	// RVA: 0x3E8D20 Offset: 0x3E7320 VA: 0x1803E8D20
	private static void Add_March_31_2022() { }

	// RVA: 0x3E44D0 Offset: 0x3E2AD0 VA: 0x1803E44D0
	private static void Add_March_24_2022() { }

	// RVA: 0x3E01D0 Offset: 0x3DE7D0 VA: 0x1803E01D0
	private static void Add_March_17_2022_STREAMERSKINS() { }

	// RVA: 0x3E07F0 Offset: 0x3DEDF0 VA: 0x1803E07F0
	private static void Add_March_17_2022() { }

	// RVA: 0x3DCD70 Offset: 0x3DB370 VA: 0x1803DCD70
	private static void Add_March_10_2022() { }

	// RVA: 0x3DC0B0 Offset: 0x3DA6B0 VA: 0x1803DC0B0
	private static void Add_March_03_2022() { }

	// RVA: 0x3ABA40 Offset: 0x3AA040 VA: 0x1803ABA40
	private static void Add_February_24_2022() { }

	// RVA: 0x3A8460 Offset: 0x3A6A60 VA: 0x1803A8460
	private static void Add_February_17_2022() { }

	// RVA: 0x3A46B0 Offset: 0x3A2CB0 VA: 0x1803A46B0
	private static void Add_February_10_2022() { }

	// RVA: 0x3A2F80 Offset: 0x3A1580 VA: 0x1803A2F80
	private static void Add_February_03_2022() { }

	// RVA: 0x3A1D50 Offset: 0x3A0350 VA: 0x1803A1D50
	private static void Add_February_01_2022_STREAMERSKINS() { }

	// RVA: 0x3BAD90 Offset: 0x3B9390 VA: 0x1803BAD90
	private static void Add_January_28_2022() { }

	// RVA: 0x3B88D0 Offset: 0x3B6ED0 VA: 0x1803B88D0
	private static void Add_January_20_2022() { }

	// RVA: 0x3B4F60 Offset: 0x3B3560 VA: 0x1803B4F60
	private static void Add_January_13_2022() { }

	// RVA: 0x3B1460 Offset: 0x3AFA60 VA: 0x1803B1460
	private static void Add_January_06_2022_STREAMERSKINS() { }

	// RVA: 0x3B1F90 Offset: 0x3B0590 VA: 0x1803B1F90
	private static void Add_January_06_2022() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void Add_Unlimited() { }

	// RVA: 0x41E060 Offset: 0x41C660 VA: 0x18041E060
	public static IReadOnlyDictionary<ulong, ApprovedSkinInfo> get_All() { }

	// RVA: 0x41DBE0 Offset: 0x41C1E0 VA: 0x18041DBE0
	private static void Initialize() { }

	// RVA: 0x41D9F0 Offset: 0x41BFF0 VA: 0x18041D9F0
	private static void Add(ApprovedSkinInfo skin) { }

	// RVA: 0x41DAE0 Offset: 0x41C0E0 VA: 0x18041DAE0
	public static ApprovedSkinInfo FindByInventoryId(int id) { }

	// RVA: 0x41DA50 Offset: 0x41C050 VA: 0x18041DA50
	private static void EnsureInitialized() { }

}

public class ApprovedSkinInfo // TypeDefIndex: 7738
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ulong <InventoryId>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Desc>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Name>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ulong <WorkshopdId>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Price <Price>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <Tradable>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private DropChance <DropChance>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <Marketable>k__BackingField; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Skinnable <Skinnable>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <AllowInCrates>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IsLimitedTimeOffer>k__BackingField; // 0x49

	// Properties
	public ulong InventoryId { get; set; }
	public string Desc { get; set; }
	public string Name { get; set; }
	public ulong WorkshopdId { get; set; }
	internal Price Price { get; set; }
	public bool Tradable { get; set; }
	public DropChance DropChance { get; set; }
	public bool Marketable { get; set; }
	public Skinnable Skinnable { get; set; }
	public bool AllowInCrates { get; set; }
	public bool IsLimitedTimeOffer { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public ulong get_InventoryId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1190 Offset: 0x8BF790 VA: 0x1808C1190
	private void set_InventoryId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Desc() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	private void set_Desc(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	private void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public ulong get_WorkshopdId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE72F80 Offset: 0xE71580 VA: 0x180E72F80
	private void set_WorkshopdId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA38FA0 Offset: 0xA375A0 VA: 0x180A38FA0
	internal Price get_Price() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA39560 Offset: 0xA37B60 VA: 0x180A39560
	private void set_Price(Price value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xBA1D40 Offset: 0xBA0340 VA: 0x180BA1D40
	public bool get_Tradable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE72F70 Offset: 0xE71570 VA: 0x180E72F70
	private void set_Tradable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6BBA50 Offset: 0x6BA050 VA: 0x1806BBA50
	public DropChance get_DropChance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC74BD0 Offset: 0xC731D0 VA: 0x180C74BD0
	private void set_DropChance(DropChance value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC65CA0 Offset: 0xC642A0 VA: 0x180C65CA0
	public bool get_Marketable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE72F60 Offset: 0xE71560 VA: 0x180E72F60
	private void set_Marketable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public Skinnable get_Skinnable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	private void set_Skinnable(Skinnable value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC3E0 Offset: 0x4BA9E0 VA: 0x1804BC3E0
	public bool get_AllowInCrates() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5E0 Offset: 0x4BABE0 VA: 0x1804BC5E0
	private void set_AllowInCrates(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xBA1D60 Offset: 0xBA0360 VA: 0x180BA1D60
	public bool get_IsLimitedTimeOffer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x82D900 Offset: 0x82BF00 VA: 0x18082D900
	private void set_IsLimitedTimeOffer(bool value) { }

	// RVA: 0xE72500 Offset: 0xE70B00 VA: 0x180E72500
	public void .ctor(ulong WorkshopdId, string Name, string Desc, string ItemName) { }

	// RVA: 0xE724D0 Offset: 0xE70AD0 VA: 0x180E724D0
	public ApprovedSkinInfo Store(Price Price, bool CanBeTraded, bool CanBeSold) { }

	// RVA: 0xE724E0 Offset: 0xE70AE0 VA: 0x180E724E0
	public ApprovedSkinInfo TimeLimited() { }

	// RVA: 0xE724F0 Offset: 0xE70AF0 VA: 0x180E724F0
	public ApprovedSkinInfo Unlimited() { }

	// RVA: 0xE724C0 Offset: 0xE70AC0 VA: 0x180E724C0
	public ApprovedSkinInfo NoCrate() { }

	// RVA: 0xE724A0 Offset: 0xE70AA0 VA: 0x180E724A0
	public ApprovedSkinInfo Drops(DropChance DropChance) { }

	// RVA: 0xE724B0 Offset: 0xE70AB0 VA: 0x180E724B0
	public ApprovedSkinInfo ItemId(ulong InventoryId) { }

	// RVA: 0xE726B0 Offset: 0xE70CB0 VA: 0x180E726B0
	public static ItemSchema.Item op_Implicit(ApprovedSkinInfo o) { }

}

private sealed class ApprovedSkinInfo.<>c__DisplayClass44_0 // TypeDefIndex: 7739
{	// Fields
	public string ItemName; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xE80AE0 Offset: 0xE7F0E0 VA: 0x180E80AE0
	internal bool <.ctor>b__0(Skinnable x) { }

}

public abstract class AppIOEntity : IOEntity // TypeDefIndex: 8306
{	// Fields
	private Option __menuOption_Menu_Pair; // 0x288

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x82AE80 Offset: 0x829480 VA: 0x18082AE80 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x82B3D0 Offset: 0x8299D0 VA: 0x18082B3D0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x82B280 Offset: 0x829880 VA: 0x18082B280 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0xB0520 Offset: 0xAF920 VA: 0x1800B0520
	[BaseEntity.Menu.Description] // RVA: 0xB0520 Offset: 0xAF920 VA: 0x1800B0520
	[BaseEntity.Menu.Icon] // RVA: 0xB0520 Offset: 0xAF920 VA: 0x1800B0520
	[BaseEntity.Menu.ShowIf] // RVA: 0xB0520 Offset: 0xAF920 VA: 0x1800B0520
	// RVA: 0x82B1E0 Offset: 0x8297E0 VA: 0x18082B1E0
	public void Menu_Pair(BasePlayer player) { }

	// RVA: 0x82B220 Offset: 0x829820 VA: 0x18082B220
	public bool Menu_ShowIf(BasePlayer player) { }

	// RVA: 0x82B370 Offset: 0x829970 VA: 0x18082B370
	protected void .ctor() { }

}

public class ApplyTerrainAnchors : MonoBehaviour // TypeDefIndex: 10373
{	// Methods

	// RVA: 0x82B4E0 Offset: 0x829AE0 VA: 0x18082B4E0
	protected void Awake() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ApplyTerrainModifiers : MonoBehaviour // TypeDefIndex: 10574
{	// Methods

	// RVA: 0x82B5E0 Offset: 0x829BE0 VA: 0x18082B5E0
	protected void Awake() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ApplyTweakUIChanges : MonoBehaviour // TypeDefIndex: 11135
{	// Fields
	public Button ApplyButton; // 0x18
	public TweakUIBase[] Options; // 0x20

	// Methods

	// RVA: 0x82B7C0 Offset: 0x829DC0 VA: 0x18082B7C0
	private void OnEnable() { }

	// RVA: 0x82B6E0 Offset: 0x829CE0 VA: 0x18082B6E0
	public void Apply() { }

	// RVA: 0x82B850 Offset: 0x829E50 VA: 0x18082B850
	public void SetDirty() { }

	// RVA: 0x82B7D0 Offset: 0x829DD0 VA: 0x18082B7D0
	public void SetClean() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class App : ConsoleSystem // TypeDefIndex: 11882
{	// Fields
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static string listenip; // 0x0
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static int port; // 0x8
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static string publicip; // 0x10
	[ServerVar] // RVA: 0x86530 Offset: 0x85930 VA: 0x180086530
	public static bool update; // 0x18
	[ServerVar] // RVA: 0x86600 Offset: 0x85A00 VA: 0x180086600
	public static bool notifications; // 0x19
	[ServerVar] // RVA: 0x87AA0 Offset: 0x86EA0 VA: 0x180087AA0
	public static int queuelimit; // 0x1C
	[ReplicatedVar] // RVA: 0x87BB0 Offset: 0x86FB0 VA: 0x180087BB0
	public static string serverid; // 0x20
	[ServerVar] // RVA: 0x87D90 Offset: 0x87190 VA: 0x180087D90
	public static float alarmcooldown; // 0x28
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static int maxconnections; // 0x2C
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static int maxconnectionsperip; // 0x30

	// Methods

	// RVA: 0x6CAF30 Offset: 0x6C9530 VA: 0x1806CAF30
	public void .ctor() { }

	// RVA: 0x6CAE30 Offset: 0x6C9430 VA: 0x1806CAE30
	private static void .cctor() { }

}

