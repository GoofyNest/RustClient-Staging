internal static class AppContextSwitches // TypeDefIndex: 142
{	// Fields
	public static readonly bool ThrowExceptionIfDisposedCancellationTokenSource; // 0x0
	public static readonly bool SetActorAsReferenceWhenCopyingClaimsIdentity; // 0x1
	public static readonly bool NoAsyncCurrentCulture; // 0x2
	public static readonly bool PreserveEventListnerObjectIdentity; // 0x3

}

public class AppDomainUnloadedException : SystemException // TypeDefIndex: 164
{	// Methods

	// RVA: 0x1551140 Offset: 0x154F740 VA: 0x181551140
	public void .ctor() { }

	// RVA: 0xFDDEB0 Offset: 0xFDC4B0 VA: 0x180FDDEB0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

public class ApplicationException : Exception // TypeDefIndex: 165
{	// Methods

	// RVA: 0x1552C50 Offset: 0x1551250 VA: 0x181552C50
	public void .ctor() { }

	// RVA: 0x1552CD0 Offset: 0x15512D0 VA: 0x181552CD0
	public void .ctor(string message) { }

	// RVA: 0x1552BC0 Offset: 0x15511C0 VA: 0x181552BC0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1552D50 Offset: 0x1551350 VA: 0x181552D50
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

	// RVA: 0x15529A0 Offset: 0x1550FA0 VA: 0x1815529A0
	private AppDomainSetup getSetup() { }

	// RVA: 0x15529A0 Offset: 0x1550FA0 VA: 0x1815529A0
	internal AppDomainSetup get_SetupInformationNoCopy() { }

	// RVA: 0x15529B0 Offset: 0x1550FB0 VA: 0x1815529B0 Slot: 6
	public string get_BaseDirectory() { }

	// RVA: 0x1552790 Offset: 0x1550D90 VA: 0x181552790
	private string getFriendlyName() { }

	// RVA: 0x1552790 Offset: 0x1550D90 VA: 0x181552790 Slot: 7
	public string get_FriendlyName() { }

	// RVA: 0x1552980 Offset: 0x1550F80 VA: 0x181552980
	private static AppDomain getCurDomain() { }

	// RVA: 0x1552980 Offset: 0x1550F80 VA: 0x181552980
	public static AppDomain get_CurrentDomain() { }

	// RVA: 0x1551960 Offset: 0x154FF60 VA: 0x181551960
	private Assembly[] GetAssemblies(bool refOnly) { }

	// RVA: 0x1551970 Offset: 0x154FF70 VA: 0x181551970 Slot: 8
	public Assembly[] GetAssemblies() { }

	// RVA: 0x1551990 Offset: 0x154FF90 VA: 0x181551990 Slot: 9
	public object GetData(string name) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 5
	public override object InitializeLifetimeService() { }

	// RVA: 0x1551D80 Offset: 0x1550380 VA: 0x181551D80
	internal Assembly LoadAssembly(string assemblyRef, Evidence securityEvidence, bool refOnly) { }

	// RVA: 0x1551E90 Offset: 0x1550490 VA: 0x181551E90 Slot: 10
	public Assembly Load(AssemblyName assemblyRef) { }

	// RVA: 0x1551D90 Offset: 0x1550390 VA: 0x181551D90
	internal Assembly LoadSatellite(AssemblyName assemblyRef, bool throwOnError) { }

	[ObsoleteAttribute] // RVA: 0x8C760 Offset: 0x8BB60 VA: 0x18008C760
	// RVA: 0x1551EA0 Offset: 0x15504A0 VA: 0x181551EA0 Slot: 11
	public Assembly Load(AssemblyName assemblyRef, Evidence assemblySecurity) { }

	// RVA: 0x1552440 Offset: 0x1550A40 VA: 0x181552440 Slot: 12
	public Assembly Load(string assemblyString) { }

	// RVA: 0x1552540 Offset: 0x1550B40 VA: 0x181552540
	internal Assembly Load(string assemblyString, Evidence assemblySecurity, bool refonly) { }

	// RVA: 0x1551B60 Offset: 0x1550160 VA: 0x181551B60
	private static AppDomain InternalSetDomainByID(int domain_id) { }

	// RVA: 0x1551B70 Offset: 0x1550170 VA: 0x181551B70
	private static AppDomain InternalSetDomain(AppDomain context) { }

	// RVA: 0x1551B40 Offset: 0x1550140 VA: 0x181551B40
	internal static void InternalPushDomainRefByID(int domain_id) { }

	// RVA: 0x1551B30 Offset: 0x1550130 VA: 0x181551B30
	internal static void InternalPopDomainRef() { }

	// RVA: 0x1551B50 Offset: 0x1550150 VA: 0x181551B50
	internal static Context InternalSetContext(Context context) { }

	// RVA: 0x1551B10 Offset: 0x1550110 VA: 0x181551B10
	internal static Context InternalGetContext() { }

	// RVA: 0x1551B10 Offset: 0x1550110 VA: 0x181551B10
	internal static Context InternalGetDefaultContext() { }

	// RVA: 0x1551B20 Offset: 0x1550120 VA: 0x181551B20
	internal static string InternalGetProcessGuid(string newguid) { }

	// RVA: 0x1551B80 Offset: 0x1550180 VA: 0x181551B80
	internal static object InvokeInDomainByID(int domain_id, MethodInfo method, object obj, object[] args) { }

	// RVA: 0x1551A60 Offset: 0x1550060 VA: 0x181551A60
	internal static string GetProcessGuid() { }

	// RVA: 0xD6A470 Offset: 0xD68A70 VA: 0x180D6A470
	private static bool InternalIsFinalizingForUnload(int domain_id) { }

	// RVA: 0x1551D60 Offset: 0x1550360 VA: 0x181551D60
	public bool IsFinalizingForUnload() { }

	// RVA: 0x1552990 Offset: 0x1550F90 VA: 0x181552990
	private int getDomainID() { }

	[ObsoleteAttribute] // RVA: 0x8C8D0 Offset: 0x8BCD0 VA: 0x18008C8D0
	// RVA: 0x1551980 Offset: 0x154FF80 VA: 0x181551980
	public static int GetCurrentThreadId() { }

	// RVA: 0x1552790 Offset: 0x1550D90 VA: 0x181552790 Slot: 3
	public override string ToString() { }

	// RVA: 0x15511A0 Offset: 0x154F7A0 VA: 0x1815511A0
	private void DoAssemblyLoad(Assembly assembly) { }

	// RVA: 0x1551270 Offset: 0x154F870 VA: 0x181551270
	private Assembly DoAssemblyResolve(string name, Assembly requestingAssembly, bool refonly) { }

	// RVA: 0x15516B0 Offset: 0x154FCB0 VA: 0x1815516B0
	internal Assembly DoTypeResolve(object name_or_tb) { }

	// RVA: 0x1551580 Offset: 0x154FB80 VA: 0x181551580
	internal Assembly DoResourceResolve(string name, Assembly requesting) { }

	// RVA: 0x1551560 Offset: 0x154FB60 VA: 0x181551560
	private void DoDomainUnload() { }

	// RVA: 0x15519A0 Offset: 0x154FFA0 VA: 0x1815519A0
	internal byte[] GetMarshalledDomainObjRef() { }

	// RVA: 0x1552660 Offset: 0x1550C60 VA: 0x181552660
	internal void ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg, out byte[] arrResponse, out CADMethodReturnMessage cadMrm) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x15527A0 Offset: 0x1550DA0 VA: 0x1815527A0 Slot: 13
	public void add_DomainUnload(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x15529E0 Offset: 0x1550FE0 VA: 0x1815529E0 Slot: 14
	public void remove_DomainUnload(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1552840 Offset: 0x1550E40 VA: 0x181552840 Slot: 15
	public void add_ProcessExit(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1552A80 Offset: 0x1551080 VA: 0x181552A80 Slot: 16
	public void remove_ProcessExit(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x15528E0 Offset: 0x1550EE0 VA: 0x1815528E0 Slot: 17
	public void add_UnhandledException(UnhandledExceptionEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1552B20 Offset: 0x1551120 VA: 0x181552B20 Slot: 18
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

	// RVA: 0x1550DE0 Offset: 0x154F3E0 VA: 0x181550DE0
	private static string GetAppBase(string appBase) { }

	// RVA: 0x1551130 Offset: 0x154F730 VA: 0x181551130 Slot: 4
	public string get_ApplicationBase() { }

}

internal class AppDomainLevelActivator : IActivator // TypeDefIndex: 1203
{	// Fields
	private string _activationUrl; // 0x10
	private IActivator _next; // 0x18

	// Properties
	public IActivator NextActivator { get; }

	// Methods

	// RVA: 0x522C40 Offset: 0x521240 VA: 0x180522C40
	public void .ctor(string activationUrl, IActivator next) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	public IActivator get_NextActivator() { }

	// RVA: 0xFDC370 Offset: 0xFDA970 VA: 0x180FDC370 Slot: 5
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
	// RVA: 0x180A930 Offset: 0x1808F30 VA: 0x18180A930
	public static void Quit(int exitCode) { }

	// RVA: 0x180A970 Offset: 0x1808F70 VA: 0x18180A970
	public static void Quit() { }

	[FreeFunctionAttribute] // RVA: 0x70F10 Offset: 0x70310 VA: 0x180070F10
	// RVA: 0x180A5E0 Offset: 0x1808BE0 VA: 0x18180A5E0
	public static bool CanStreamedLevelBeLoaded(string levelName) { }

	[FreeFunctionAttribute] // RVA: 0x710A0 Offset: 0x704A0 VA: 0x1800710A0
	// RVA: 0x180ABF0 Offset: 0x18091F0 VA: 0x18180ABF0
	public static bool get_isPlaying() { }

	[FreeFunctionAttribute] // RVA: 0x711D0 Offset: 0x705D0 VA: 0x1800711D0
	// RVA: 0x180AB30 Offset: 0x1809130 VA: 0x18180AB30
	public static string get_dataPath() { }

	[FreeFunctionAttribute] // RVA: 0x71310 Offset: 0x70710 VA: 0x180071310
	// RVA: 0x180ACA0 Offset: 0x18092A0 VA: 0x18180ACA0
	public static string get_streamingAssetsPath() { }

	[FreeFunctionAttribute] // RVA: 0x713D0 Offset: 0x707D0 VA: 0x1800713D0
	// RVA: 0x180AC40 Offset: 0x1809240 VA: 0x18180AC40
	public static string get_persistentDataPath() { }

	[FreeFunctionAttribute] // RVA: 0x714E0 Offset: 0x708E0 VA: 0x1800714E0
	// RVA: 0x180AD30 Offset: 0x1809330 VA: 0x18180AD30
	public static string get_unityVersion() { }

	[FreeFunctionAttribute] // RVA: 0x71720 Offset: 0x70B20 VA: 0x180071720
	// RVA: 0x180AD60 Offset: 0x1809360 VA: 0x18180AD60
	public static string get_version() { }

	[FreeFunctionAttribute] // RVA: 0x717E0 Offset: 0x70BE0 VA: 0x1800717E0
	// RVA: 0x180AAD0 Offset: 0x18090D0 VA: 0x18180AAD0
	public static string get_companyName() { }

	[FreeFunctionAttribute] // RVA: 0x71920 Offset: 0x70D20 VA: 0x180071920
	// RVA: 0x180A8F0 Offset: 0x1808EF0 VA: 0x18180A8F0
	public static void OpenURL(string url) { }

	[FreeFunctionAttribute] // RVA: 0x71A60 Offset: 0x70E60 VA: 0x180071A60
	// RVA: 0x180AD00 Offset: 0x1809300 VA: 0x18180AD00
	public static int get_targetFrameRate() { }

	[FreeFunctionAttribute] // RVA: 0x71B40 Offset: 0x70F40 VA: 0x180071B40
	// RVA: 0x180AE60 Offset: 0x1809460 VA: 0x18180AE60
	public static void set_targetFrameRate(int value) { }

	[FreeFunctionAttribute] // RVA: 0x71CD0 Offset: 0x710D0 VA: 0x180071CD0
	// RVA: 0x180A9A0 Offset: 0x1808FA0 VA: 0x18180A9A0
	private static void SetLogCallbackDefined(bool defined) { }

	[FreeFunctionAttribute] // RVA: 0x71E10 Offset: 0x71210 VA: 0x180071E10
	// RVA: 0x180A620 Offset: 0x1808C20 VA: 0x18180A620
	public static StackTraceLogType GetStackTraceLogType(LogType logType) { }

	[FreeFunctionAttribute] // RVA: 0x71ED0 Offset: 0x712D0 VA: 0x180071ED0
	// RVA: 0x180A9E0 Offset: 0x1808FE0 VA: 0x18180A9E0
	public static void SetStackTraceLogType(LogType logType, StackTraceLogType stackTraceType) { }

	[FreeFunctionAttribute] // RVA: 0x72180 Offset: 0x71580 VA: 0x180072180
	// RVA: 0x180AB00 Offset: 0x1809100 VA: 0x18180AB00
	public static string get_consoleLogPath() { }

	[FreeFunctionAttribute] // RVA: 0x722D0 Offset: 0x716D0 VA: 0x1800722D0
	// RVA: 0x180AE20 Offset: 0x1809420 VA: 0x18180AE20
	public static void set_backgroundLoadingPriority(ThreadPriority value) { }

	[FreeFunctionAttribute] // RVA: 0x72460 Offset: 0x71860 VA: 0x180072460
	// RVA: 0x180AC70 Offset: 0x1809270 VA: 0x18180AC70
	public static RuntimePlatform get_platform() { }

	// RVA: 0x180AB90 Offset: 0x1809190 VA: 0x18180AB90
	public static bool get_isMobilePlatform() { }

	[FreeFunctionAttribute] // RVA: 0x72530 Offset: 0x71930 VA: 0x180072530
	// RVA: 0x180ACD0 Offset: 0x18092D0 VA: 0x18180ACD0
	public static SystemLanguage get_systemLanguage() { }

	[FreeFunctionAttribute] // RVA: 0x73A40 Offset: 0x72E40 VA: 0x180073A40
	// RVA: 0x180AB60 Offset: 0x1809160 VA: 0x18180AB60
	public static NetworkReachability get_internetReachability() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x180A400 Offset: 0x1808A00 VA: 0x18180A400
	internal static void CallLowMemory() { }

	// RVA: 0x180AA20 Offset: 0x1809020 VA: 0x18180AA20
	public static void add_logMessageReceived(Application.LogCallback value) { }

	// RVA: 0x180AD90 Offset: 0x1809390 VA: 0x18180AD90
	public static void remove_logMessageReceived(Application.LogCallback value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x180A340 Offset: 0x1808940 VA: 0x18180A340
	private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x180A6B0 Offset: 0x1808CB0 VA: 0x18180A6B0
	private static bool Internal_ApplicationWantsToQuit() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x180A660 Offset: 0x1808C60 VA: 0x18180A660
	private static void Internal_ApplicationQuit() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x180A8A0 Offset: 0x1808EA0 VA: 0x18180A8A0
	internal static void InvokeOnBeforeRender() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x180A840 Offset: 0x1808E40 VA: 0x18180A840
	internal static void InvokeFocusChanged(bool focus) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x180A7E0 Offset: 0x1808DE0 VA: 0x18180A7E0
	internal static void InvokeDeepLinkActivated(string url) { }

	// RVA: 0x180AC20 Offset: 0x1809220 VA: 0x18180AC20
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

	// RVA: 0x181F3E0 Offset: 0x181D9E0 VA: 0x18181F3E0 Slot: 12
	public virtual void Invoke(string condition, string stackTrace, LogType type) { }

	// RVA: 0x181F350 Offset: 0x181D950 VA: 0x18181F350 Slot: 13
	public virtual IAsyncResult BeginInvoke(string condition, string stackTrace, LogType type, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public struct AppId // TypeDefIndex: 5235
{	// Fields
	public uint Value; // 0x0

	// Methods

	// RVA: 0x1D8330 Offset: 0x1D7730 VA: 0x1801D8330 Slot: 3
	public override string ToString() { }

	// RVA: 0x68A650 Offset: 0x688C50 VA: 0x18068A650
	public static AppId op_Implicit(uint value) { }

	// RVA: 0x68A650 Offset: 0x688C50 VA: 0x18068A650
	public static AppId op_Implicit(int value) { }

	// RVA: 0x68A650 Offset: 0x688C50 VA: 0x18068A650
	public static uint op_Implicit(AppId value) { }

}

internal struct AppResumingFromSuspend_t : ICallbackData // TypeDefIndex: 5333
{	// Fields
	public static int _datasize; // 0x2B1075C

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E4810 Offset: 0x1E3C10 VA: 0x1801E4810 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E4800 Offset: 0x1E3C00 VA: 0x1801E4800 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136A190 Offset: 0x1368790 VA: 0x18136A190
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

	// RVA: 0x1E4610 Offset: 0x1E3A10 VA: 0x1801E4610 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E4600 Offset: 0x1E3A00 VA: 0x1801E4600 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136A0F0 Offset: 0x13686F0 VA: 0x18136A0F0
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

	// RVA: 0x14A8A20 Offset: 0x14A7020 VA: 0x1814A8A20
	public static MonoBehaviour get_Controller() { }

	// RVA: 0x14A8710 Offset: 0x14A6D10 VA: 0x1814A8710
	public static void Initialize(BaseIntegration integration) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14A8B20 Offset: 0x14A7120 VA: 0x1814A8B20
	public static BaseIntegration get_Integration() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14A8B60 Offset: 0x14A7160 VA: 0x1814A8B60
	public static void set_Integration(BaseIntegration value) { }

}

internal class ApplicationControllerMonobehaviour : MonoBehaviour // TypeDefIndex: 6217
{	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void OnApplicationQuit() { }

	// RVA: 0x14A8570 Offset: 0x14A6B70 VA: 0x1814A8570
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

	// RVA: 0x1F13E0 Offset: 0x1F07E0 VA: 0x1801F13E0
	public int get_Version() { }

	// RVA: 0x1F0FB0 Offset: 0x1F03B0 VA: 0x1801F0FB0
	public BuildInfo get_Build() { }

	// RVA: 0x1F1240 Offset: 0x1F0640 VA: 0x1801F1240
	public string get_Name() { }

	// RVA: 0x1F1250 Offset: 0x1F0650 VA: 0x1801F1250
	public string get_Os() { }

	// RVA: 0x1F0FD0 Offset: 0x1F03D0 VA: 0x1801F0FD0
	public string get_Cpu() { }

	// RVA: 0x1F0FC0 Offset: 0x1F03C0 VA: 0x1801F0FC0
	public int get_CpuCount() { }

	// RVA: 0x1F0FE0 Offset: 0x1F03E0 VA: 0x1801F0FE0
	public int get_Mem() { }

	// RVA: 0x1F0FF0 Offset: 0x1F03F0 VA: 0x1801F0FF0
	public string get_Gpu() { }

	// RVA: 0x1F0FE0 Offset: 0x1F03E0 VA: 0x1801F0FE0
	public int get_GpuMem() { }

	// RVA: 0x1F0F70 Offset: 0x1F0370 VA: 0x1801F0F70
	public string get_Arch() { }

	// RVA: 0x1F1320 Offset: 0x1F0720 VA: 0x1801F1320
	public string get_UserId() { }

	// RVA: 0x1F1380 Offset: 0x1F0780 VA: 0x1801F1380
	public string get_UserName() { }

	// RVA: 0x1F1260 Offset: 0x1F0660 VA: 0x1801F1260
	public string get_ServerAddress() { }

	// RVA: 0x1F12C0 Offset: 0x1F06C0 VA: 0x1801F12C0
	public string get_ServerName() { }

	// RVA: 0x1F1000 Offset: 0x1F0400 VA: 0x1801F1000
	public string get_LevelName() { }

	// RVA: 0x1F1060 Offset: 0x1F0460 VA: 0x1801F1060
	public string get_LevelPos() { }

	// RVA: 0x1F1120 Offset: 0x1F0520 VA: 0x1801F1120
	public string get_LevelRot() { }

	// RVA: 0x1F11E0 Offset: 0x1F05E0 VA: 0x1801F11E0
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

	// RVA: 0x1E25B70 Offset: 0x1E24170 VA: 0x181E25B70
	public static void ResetToPool(Approval instance) { }

	// RVA: 0x1E259B0 Offset: 0x1E23FB0 VA: 0x181E259B0
	public void ResetToPool() { }

	// RVA: 0x1E25740 Offset: 0x1E23D40 VA: 0x181E25740 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E242A0 Offset: 0x1E228A0 VA: 0x181E242A0
	public void CopyTo(Approval instance) { }

	// RVA: 0x1E24350 Offset: 0x1E22950 VA: 0x181E24350
	public Approval Copy() { }

	// RVA: 0x1E25110 Offset: 0x1E23710 VA: 0x181E25110
	public static Approval Deserialize(Stream stream) { }

	// RVA: 0x1E24440 Offset: 0x1E22A40 VA: 0x181E24440
	public static Approval DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E24A30 Offset: 0x1E23030 VA: 0x181E24A30
	public static Approval DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E25620 Offset: 0x1E23C20 VA: 0x181E25620
	public static Approval Deserialize(byte[] buffer) { }

	// RVA: 0x1E25970 Offset: 0x1E23F70 VA: 0x181E25970
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E267E0 Offset: 0x1E24DE0 VA: 0x181E267E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E26800 Offset: 0x1E24E00 VA: 0x181E26800 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Approval previous) { }

	// RVA: 0x1E25990 Offset: 0x1E23F90 VA: 0x181E25990 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E25010 Offset: 0x1E23610 VA: 0x181E25010
	public static Approval Deserialize(byte[] buffer, Approval instance, bool isDelta = False) { }

	// RVA: 0x1E25190 Offset: 0x1E23790 VA: 0x181E25190
	public static Approval Deserialize(Stream stream, Approval instance, bool isDelta) { }

	// RVA: 0x1E244C0 Offset: 0x1E22AC0 VA: 0x181E244C0
	public static Approval DeserializeLengthDelimited(Stream stream, Approval instance, bool isDelta) { }

	// RVA: 0x1E24AC0 Offset: 0x1E230C0 VA: 0x181E24AC0
	public static Approval DeserializeLength(Stream stream, int length, Approval instance, bool isDelta) { }

	// RVA: 0x1E25D30 Offset: 0x1E24330 VA: 0x181E25D30
	public static void SerializeDelta(Stream stream, Approval instance, Approval previous) { }

	// RVA: 0x1E26400 Offset: 0x1E24A00 VA: 0x181E26400
	public static void Serialize(Stream stream, Approval instance) { }

	// RVA: 0x1E267D0 Offset: 0x1E24DD0 VA: 0x181E267D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E267E0 Offset: 0x1E24DE0 VA: 0x181E267E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E262F0 Offset: 0x1E248F0 VA: 0x181E262F0
	public static byte[] SerializeToBytes(Approval instance) { }

	// RVA: 0x1E26240 Offset: 0x1E24840 VA: 0x181E26240
	public static void SerializeLengthDelimited(Stream stream, Approval instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x1E13A20 Offset: 0x1E12020 VA: 0x181E13A20
	public static void ResetToPool(AppRequest instance) { }

	// RVA: 0x1E136D0 Offset: 0x1E11CD0 VA: 0x181E136D0
	public void ResetToPool() { }

	// RVA: 0x1E13610 Offset: 0x1E11C10 VA: 0x181E13610 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E11B50 Offset: 0x1E10150 VA: 0x181E11B50
	public void CopyTo(AppRequest instance) { }

	// RVA: 0x1E11F20 Offset: 0x1E10520 VA: 0x181E11F20
	public AppRequest Copy() { }

	// RVA: 0x1E13370 Offset: 0x1E11970 VA: 0x181E13370
	public static AppRequest Deserialize(Stream stream) { }

	// RVA: 0x1E12630 Offset: 0x1E10C30 VA: 0x181E12630
	public static AppRequest DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E12D20 Offset: 0x1E11320 VA: 0x181E12D20
	public static AppRequest DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E134F0 Offset: 0x1E11AF0 VA: 0x181E134F0
	public static AppRequest Deserialize(byte[] buffer) { }

	// RVA: 0x1E13690 Offset: 0x1E11C90 VA: 0x181E13690
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E159D0 Offset: 0x1E13FD0 VA: 0x181E159D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E159F0 Offset: 0x1E13FF0 VA: 0x181E159F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppRequest previous) { }

	// RVA: 0x1E136B0 Offset: 0x1E11CB0 VA: 0x181E136B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E133F0 Offset: 0x1E119F0 VA: 0x181E133F0
	public static AppRequest Deserialize(byte[] buffer, AppRequest instance, bool isDelta = False) { }

	// RVA: 0x1E12DB0 Offset: 0x1E113B0 VA: 0x181E12DB0
	public static AppRequest Deserialize(Stream stream, AppRequest instance, bool isDelta) { }

	// RVA: 0x1E11FA0 Offset: 0x1E105A0 VA: 0x181E11FA0
	public static AppRequest DeserializeLengthDelimited(Stream stream, AppRequest instance, bool isDelta) { }

	// RVA: 0x1E126B0 Offset: 0x1E10CB0 VA: 0x181E126B0
	public static AppRequest DeserializeLength(Stream stream, int length, AppRequest instance, bool isDelta) { }

	// RVA: 0x1E13D70 Offset: 0x1E12370 VA: 0x181E13D70
	public static void SerializeDelta(Stream stream, AppRequest instance, AppRequest previous) { }

	// RVA: 0x1E14D20 Offset: 0x1E13320 VA: 0x181E14D20
	public static void Serialize(Stream stream, AppRequest instance) { }

	// RVA: 0x1E159C0 Offset: 0x1E13FC0 VA: 0x181E159C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E159D0 Offset: 0x1E13FD0 VA: 0x181E159D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E14C10 Offset: 0x1E13210 VA: 0x181E14C10
	public static byte[] SerializeToBytes(AppRequest instance) { }

	// RVA: 0x1E14B60 Offset: 0x1E13160 VA: 0x181E14B60
	public static void SerializeLengthDelimited(Stream stream, AppRequest instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class AppMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6512
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public AppResponse response; // 0x18
	public AppBroadcast broadcast; // 0x20

	// Methods

	// RVA: 0x2092F90 Offset: 0x2091590 VA: 0x182092F90
	public static void ResetToPool(AppMessage instance) { }

	// RVA: 0x2093070 Offset: 0x2091670 VA: 0x182093070
	public void ResetToPool() { }

	// RVA: 0x2092DF0 Offset: 0x20913F0 VA: 0x182092DF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2092200 Offset: 0x2090800 VA: 0x182092200
	public void CopyTo(AppMessage instance) { }

	// RVA: 0x20922C0 Offset: 0x20908C0 VA: 0x1820922C0
	public AppMessage Copy() { }

	// RVA: 0x2092D70 Offset: 0x2091370 VA: 0x182092D70
	public static AppMessage Deserialize(Stream stream) { }

	// RVA: 0x20923D0 Offset: 0x20909D0 VA: 0x1820923D0
	public static AppMessage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2092920 Offset: 0x2090F20 VA: 0x182092920
	public static AppMessage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20929B0 Offset: 0x2090FB0 VA: 0x1820929B0
	public static AppMessage Deserialize(byte[] buffer) { }

	// RVA: 0x2092F50 Offset: 0x2091550 VA: 0x182092F50
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2093830 Offset: 0x2091E30 VA: 0x182093830 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2093850 Offset: 0x2091E50 VA: 0x182093850 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppMessage previous) { }

	// RVA: 0x2092F70 Offset: 0x2091570 VA: 0x182092F70 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2092C70 Offset: 0x2091270 VA: 0x182092C70
	public static AppMessage Deserialize(byte[] buffer, AppMessage instance, bool isDelta = False) { }

	// RVA: 0x2092AD0 Offset: 0x20910D0 VA: 0x182092AD0
	public static AppMessage Deserialize(Stream stream, AppMessage instance, bool isDelta) { }

	// RVA: 0x2092450 Offset: 0x2090A50 VA: 0x182092450
	public static AppMessage DeserializeLengthDelimited(Stream stream, AppMessage instance, bool isDelta) { }

	// RVA: 0x20926D0 Offset: 0x2090CD0 VA: 0x1820926D0
	public static AppMessage DeserializeLength(Stream stream, int length, AppMessage instance, bool isDelta) { }

	// RVA: 0x2093150 Offset: 0x2091750 VA: 0x182093150
	public static void SerializeDelta(Stream stream, AppMessage instance, AppMessage previous) { }

	// RVA: 0x20935B0 Offset: 0x2091BB0 VA: 0x1820935B0
	public static void Serialize(Stream stream, AppMessage instance) { }

	// RVA: 0x2093820 Offset: 0x2091E20 VA: 0x182093820
	public byte[] ToProtoBytes() { }

	// RVA: 0x2093830 Offset: 0x2091E30 VA: 0x182093830
	public void ToProto(Stream stream) { }

	// RVA: 0x20934A0 Offset: 0x2091AA0 VA: 0x1820934A0
	public static byte[] SerializeToBytes(AppMessage instance) { }

	// RVA: 0x20933F0 Offset: 0x20919F0 VA: 0x1820933F0
	public static void SerializeLengthDelimited(Stream stream, AppMessage instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x1E17370 Offset: 0x1E15970 VA: 0x181E17370
	public static void ResetToPool(AppResponse instance) { }

	// RVA: 0x1E170B0 Offset: 0x1E156B0 VA: 0x181E170B0
	public void ResetToPool() { }

	// RVA: 0x1E16FF0 Offset: 0x1E155F0 VA: 0x181E16FF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E15A10 Offset: 0x1E14010 VA: 0x181E15A10
	public void CopyTo(AppResponse instance) { }

	// RVA: 0x1E15DA0 Offset: 0x1E143A0 VA: 0x181E15DA0
	public AppResponse Copy() { }

	// RVA: 0x1E16E70 Offset: 0x1E15470 VA: 0x181E16E70
	public static AppResponse Deserialize(Stream stream) { }

	// RVA: 0x1E16330 Offset: 0x1E14930 VA: 0x181E16330
	public static AppResponse DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E16890 Offset: 0x1E14E90 VA: 0x181E16890
	public static AppResponse DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E16920 Offset: 0x1E14F20 VA: 0x181E16920
	public static AppResponse Deserialize(byte[] buffer) { }

	// RVA: 0x1E17070 Offset: 0x1E15670 VA: 0x181E17070
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E18C00 Offset: 0x1E17200 VA: 0x181E18C00 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E18C20 Offset: 0x1E17220 VA: 0x181E18C20 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppResponse previous) { }

	// RVA: 0x1E17090 Offset: 0x1E15690 VA: 0x181E17090 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E16EF0 Offset: 0x1E154F0 VA: 0x181E16EF0
	public static AppResponse Deserialize(byte[] buffer, AppResponse instance, bool isDelta = False) { }

	// RVA: 0x1E16A40 Offset: 0x1E15040 VA: 0x181E16A40
	public static AppResponse Deserialize(Stream stream, AppResponse instance, bool isDelta) { }

	// RVA: 0x1E15E20 Offset: 0x1E14420 VA: 0x181E15E20
	public static AppResponse DeserializeLengthDelimited(Stream stream, AppResponse instance, bool isDelta) { }

	// RVA: 0x1E163B0 Offset: 0x1E149B0 VA: 0x181E163B0
	public static AppResponse DeserializeLength(Stream stream, int length, AppResponse instance, bool isDelta) { }

	// RVA: 0x1E17630 Offset: 0x1E15C30 VA: 0x181E17630
	public static void SerializeDelta(Stream stream, AppResponse instance, AppResponse previous) { }

	// RVA: 0x1E18240 Offset: 0x1E16840 VA: 0x181E18240
	public static void Serialize(Stream stream, AppResponse instance) { }

	// RVA: 0x1E18BF0 Offset: 0x1E171F0 VA: 0x181E18BF0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E18C00 Offset: 0x1E17200 VA: 0x181E18C00
	public void ToProto(Stream stream) { }

	// RVA: 0x1E18130 Offset: 0x1E16730 VA: 0x181E18130
	public static byte[] SerializeToBytes(AppResponse instance) { }

	// RVA: 0x1E18080 Offset: 0x1E16680 VA: 0x181E18080
	public static void SerializeLengthDelimited(Stream stream, AppResponse instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x2016650 Offset: 0x2014C50 VA: 0x182016650
	public static void ResetToPool(AppBroadcast instance) { }

	// RVA: 0x2016530 Offset: 0x2014B30 VA: 0x182016530
	public void ResetToPool() { }

	// RVA: 0x2016190 Offset: 0x2014790 VA: 0x182016190 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2014F80 Offset: 0x2013580 VA: 0x182014F80
	public void CopyTo(AppBroadcast instance) { }

	// RVA: 0x2015080 Offset: 0x2013680 VA: 0x182015080
	public AppBroadcast Copy() { }

	// RVA: 0x2015820 Offset: 0x2013E20 VA: 0x182015820
	public static AppBroadcast Deserialize(Stream stream) { }

	// RVA: 0x2015480 Offset: 0x2013A80 VA: 0x182015480
	public static AppBroadcast DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2015500 Offset: 0x2013B00 VA: 0x182015500
	public static AppBroadcast DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2015C20 Offset: 0x2014220 VA: 0x182015C20
	public static AppBroadcast Deserialize(byte[] buffer) { }

	// RVA: 0x2016330 Offset: 0x2014930 VA: 0x182016330
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2017030 Offset: 0x2015630 VA: 0x182017030 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2017050 Offset: 0x2015650 VA: 0x182017050 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppBroadcast previous) { }

	// RVA: 0x2016510 Offset: 0x2014B10 VA: 0x182016510 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2015EF0 Offset: 0x20144F0 VA: 0x182015EF0
	public static AppBroadcast Deserialize(byte[] buffer, AppBroadcast instance, bool isDelta = False) { }

	// RVA: 0x2015A40 Offset: 0x2014040 VA: 0x182015A40
	public static AppBroadcast Deserialize(Stream stream, AppBroadcast instance, bool isDelta) { }

	// RVA: 0x20151C0 Offset: 0x20137C0 VA: 0x1820151C0
	public static AppBroadcast DeserializeLengthDelimited(Stream stream, AppBroadcast instance, bool isDelta) { }

	// RVA: 0x2015590 Offset: 0x2013B90 VA: 0x182015590
	public static AppBroadcast DeserializeLength(Stream stream, int length, AppBroadcast instance, bool isDelta) { }

	// RVA: 0x2016770 Offset: 0x2014D70 VA: 0x182016770
	public static void SerializeDelta(Stream stream, AppBroadcast instance, AppBroadcast previous) { }

	// RVA: 0x2016CC0 Offset: 0x20152C0 VA: 0x182016CC0
	public static void Serialize(Stream stream, AppBroadcast instance) { }

	// RVA: 0x2017020 Offset: 0x2015620 VA: 0x182017020
	public byte[] ToProtoBytes() { }

	// RVA: 0x2017030 Offset: 0x2015630 VA: 0x182017030
	public void ToProto(Stream stream) { }

	// RVA: 0x2016BB0 Offset: 0x20151B0 VA: 0x182016BB0
	public static byte[] SerializeToBytes(AppBroadcast instance) { }

	// RVA: 0x2016B00 Offset: 0x2015100 VA: 0x182016B00
	public static void SerializeLengthDelimited(Stream stream, AppBroadcast instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class AppEmpty : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6515
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11

	// Methods

	// RVA: 0x2080F80 Offset: 0x207F580 VA: 0x182080F80
	public static void ResetToPool(AppEmpty instance) { }

	// RVA: 0x2080FF0 Offset: 0x207F5F0 VA: 0x182080FF0
	public void ResetToPool() { }

	// RVA: 0x2080E60 Offset: 0x207F460 VA: 0x182080E60 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void CopyTo(AppEmpty instance) { }

	// RVA: 0x20805B0 Offset: 0x207EBB0 VA: 0x1820805B0
	public AppEmpty Copy() { }

	// RVA: 0x2080DE0 Offset: 0x207F3E0 VA: 0x182080DE0
	public static AppEmpty Deserialize(Stream stream) { }

	// RVA: 0x20807E0 Offset: 0x207EDE0 VA: 0x1820807E0
	public static AppEmpty DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2080A20 Offset: 0x207F020 VA: 0x182080A20
	public static AppEmpty DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2080AB0 Offset: 0x207F0B0 VA: 0x182080AB0
	public static AppEmpty Deserialize(byte[] buffer) { }

	// RVA: 0x2080F40 Offset: 0x207F540 VA: 0x182080F40
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2081340 Offset: 0x207F940 VA: 0x182081340 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20813B0 Offset: 0x207F9B0 VA: 0x1820813B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppEmpty previous) { }

	// RVA: 0x2080F60 Offset: 0x207F560 VA: 0x182080F60 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2080CE0 Offset: 0x207F2E0 VA: 0x182080CE0
	public static AppEmpty Deserialize(byte[] buffer, AppEmpty instance, bool isDelta = False) { }

	// RVA: 0x2080BD0 Offset: 0x207F1D0 VA: 0x182080BD0
	public static AppEmpty Deserialize(Stream stream, AppEmpty instance, bool isDelta) { }

	// RVA: 0x2080600 Offset: 0x207EC00 VA: 0x182080600
	public static AppEmpty DeserializeLengthDelimited(Stream stream, AppEmpty instance, bool isDelta) { }

	// RVA: 0x2080860 Offset: 0x207EE60 VA: 0x182080860
	public static AppEmpty DeserializeLength(Stream stream, int length, AppEmpty instance, bool isDelta) { }

	// RVA: 0x2081060 Offset: 0x207F660 VA: 0x182081060
	public static void SerializeDelta(Stream stream, AppEmpty instance, AppEmpty previous) { }

	// RVA: 0x20812D0 Offset: 0x207F8D0 VA: 0x1820812D0
	public static void Serialize(Stream stream, AppEmpty instance) { }

	// RVA: 0x2081330 Offset: 0x207F930 VA: 0x182081330
	public byte[] ToProtoBytes() { }

	// RVA: 0x2081340 Offset: 0x207F940 VA: 0x182081340
	public void ToProto(Stream stream) { }

	// RVA: 0x2081170 Offset: 0x207F770 VA: 0x182081170
	public static byte[] SerializeToBytes(AppEmpty instance) { }

	// RVA: 0x20810C0 Offset: 0x207F6C0 VA: 0x1820810C0
	public static void SerializeLengthDelimited(Stream stream, AppEmpty instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class AppSendMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6516
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string message; // 0x18

	// Methods

	// RVA: 0x1E196A0 Offset: 0x1E17CA0 VA: 0x181E196A0
	public static void ResetToPool(AppSendMessage instance) { }

	// RVA: 0x1E19730 Offset: 0x1E17D30 VA: 0x181E19730
	public void ResetToPool() { }

	// RVA: 0x1E195E0 Offset: 0x1E17BE0 VA: 0x181E195E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D68640 Offset: 0x1D66C40 VA: 0x181D68640
	public void CopyTo(AppSendMessage instance) { }

	// RVA: 0x1E18C40 Offset: 0x1E17240 VA: 0x181E18C40
	public AppSendMessage Copy() { }

	// RVA: 0x1E192F0 Offset: 0x1E178F0 VA: 0x181E192F0
	public static AppSendMessage Deserialize(Stream stream) { }

	// RVA: 0x1E18EE0 Offset: 0x1E174E0 VA: 0x181E18EE0
	public static AppSendMessage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E18F60 Offset: 0x1E17560 VA: 0x181E18F60
	public static AppSendMessage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E19370 Offset: 0x1E17970 VA: 0x181E19370
	public static AppSendMessage Deserialize(byte[] buffer) { }

	// RVA: 0x1E19660 Offset: 0x1E17C60 VA: 0x181E19660
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E19C20 Offset: 0x1E18220 VA: 0x181E19C20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E19C40 Offset: 0x1E18240 VA: 0x181E19C40 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppSendMessage previous) { }

	// RVA: 0x1E19680 Offset: 0x1E17C80 VA: 0x181E19680 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E191F0 Offset: 0x1E177F0 VA: 0x181E191F0
	public static AppSendMessage Deserialize(byte[] buffer, AppSendMessage instance, bool isDelta = False) { }

	// RVA: 0x1E19490 Offset: 0x1E17A90 VA: 0x181E19490
	public static AppSendMessage Deserialize(Stream stream, AppSendMessage instance, bool isDelta) { }

	// RVA: 0x1E18CC0 Offset: 0x1E172C0 VA: 0x181E18CC0
	public static AppSendMessage DeserializeLengthDelimited(Stream stream, AppSendMessage instance, bool isDelta) { }

	// RVA: 0x1E18FF0 Offset: 0x1E175F0 VA: 0x181E18FF0
	public static AppSendMessage DeserializeLength(Stream stream, int length, AppSendMessage instance, bool isDelta) { }

	// RVA: 0x1E197C0 Offset: 0x1E17DC0 VA: 0x181E197C0
	public static void SerializeDelta(Stream stream, AppSendMessage instance, AppSendMessage previous) { }

	// RVA: 0x1E19AE0 Offset: 0x1E180E0 VA: 0x181E19AE0
	public static void Serialize(Stream stream, AppSendMessage instance) { }

	// RVA: 0x1E19C10 Offset: 0x1E18210 VA: 0x181E19C10
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E19C20 Offset: 0x1E18220 VA: 0x181E19C20
	public void ToProto(Stream stream) { }

	// RVA: 0x1E199D0 Offset: 0x1E17FD0 VA: 0x181E199D0
	public static byte[] SerializeToBytes(AppSendMessage instance) { }

	// RVA: 0x1E19920 Offset: 0x1E17F20 VA: 0x181E19920
	public static void SerializeLengthDelimited(Stream stream, AppSendMessage instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class AppSetEntityValue : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6517
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public bool value; // 0x12

	// Methods

	// RVA: 0x1E1A6C0 Offset: 0x1E18CC0 VA: 0x181E1A6C0
	public static void ResetToPool(AppSetEntityValue instance) { }

	// RVA: 0x1E1A740 Offset: 0x1E18D40 VA: 0x181E1A740
	public void ResetToPool() { }

	// RVA: 0x1E1A600 Offset: 0x1E18C00 VA: 0x181E1A600 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E19C60 Offset: 0x1E18260 VA: 0x181E19C60
	public void CopyTo(AppSetEntityValue instance) { }

	// RVA: 0x1E19C80 Offset: 0x1E18280 VA: 0x181E19C80
	public AppSetEntityValue Copy() { }

	// RVA: 0x1E1A480 Offset: 0x1E18A80 VA: 0x181E1A480
	public static AppSetEntityValue Deserialize(Stream stream) { }

	// RVA: 0x1E19CF0 Offset: 0x1E182F0 VA: 0x181E19CF0
	public static AppSetEntityValue DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E1A190 Offset: 0x1E18790 VA: 0x181E1A190
	public static AppSetEntityValue DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E1A360 Offset: 0x1E18960 VA: 0x181E1A360
	public static AppSetEntityValue Deserialize(byte[] buffer) { }

	// RVA: 0x1E1A680 Offset: 0x1E18C80 VA: 0x181E1A680
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E1ABD0 Offset: 0x1E191D0 VA: 0x181E1ABD0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E1ACA0 Offset: 0x1E192A0 VA: 0x181E1ACA0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppSetEntityValue previous) { }

	// RVA: 0x1E1A6A0 Offset: 0x1E18CA0 VA: 0x181E1A6A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E1A500 Offset: 0x1E18B00 VA: 0x181E1A500
	public static AppSetEntityValue Deserialize(byte[] buffer, AppSetEntityValue instance, bool isDelta = False) { }

	// RVA: 0x1E1A220 Offset: 0x1E18820 VA: 0x181E1A220
	public static AppSetEntityValue Deserialize(Stream stream, AppSetEntityValue instance, bool isDelta) { }

	// RVA: 0x1E19D70 Offset: 0x1E18370 VA: 0x181E19D70
	public static AppSetEntityValue DeserializeLengthDelimited(Stream stream, AppSetEntityValue instance, bool isDelta) { }

	// RVA: 0x1E19F90 Offset: 0x1E18590 VA: 0x181E19F90
	public static AppSetEntityValue DeserializeLength(Stream stream, int length, AppSetEntityValue instance, bool isDelta) { }

	// RVA: 0x1E1A7C0 Offset: 0x1E18DC0 VA: 0x181E1A7C0
	public static void SerializeDelta(Stream stream, AppSetEntityValue instance, AppSetEntityValue previous) { }

	// RVA: 0x1E1AAF0 Offset: 0x1E190F0 VA: 0x181E1AAF0
	public static void Serialize(Stream stream, AppSetEntityValue instance) { }

	// RVA: 0x1E1ABC0 Offset: 0x1E191C0 VA: 0x181E1ABC0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E1ABD0 Offset: 0x1E191D0 VA: 0x181E1ABD0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E1A940 Offset: 0x1E18F40 VA: 0x181E1A940
	public static byte[] SerializeToBytes(AppSetEntityValue instance) { }

	// RVA: 0x1E1A890 Offset: 0x1E18E90 VA: 0x181E1A890
	public static void SerializeLengthDelimited(Stream stream, AppSetEntityValue instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class AppPromoteToLeader : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6518
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong steamId; // 0x18

	// Methods

	// RVA: 0x20943A0 Offset: 0x20929A0 VA: 0x1820943A0
	public static void ResetToPool(AppPromoteToLeader instance) { }

	// RVA: 0x2094320 Offset: 0x2092920 VA: 0x182094320
	public void ResetToPool() { }

	// RVA: 0x20941F0 Offset: 0x20927F0 VA: 0x1820941F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F1D4D0 Offset: 0x1F1BAD0 VA: 0x181F1D4D0
	public void CopyTo(AppPromoteToLeader instance) { }

	// RVA: 0x2093870 Offset: 0x2091E70 VA: 0x182093870
	public AppPromoteToLeader Copy() { }

	// RVA: 0x2094070 Offset: 0x2092670 VA: 0x182094070
	public static AppPromoteToLeader Deserialize(Stream stream) { }

	// RVA: 0x20938E0 Offset: 0x2091EE0 VA: 0x1820938E0
	public static AppPromoteToLeader DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2093B80 Offset: 0x2092180 VA: 0x182093B80
	public static AppPromoteToLeader DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2093F50 Offset: 0x2092550 VA: 0x182093F50
	public static AppPromoteToLeader Deserialize(byte[] buffer) { }

	// RVA: 0x20942E0 Offset: 0x20928E0 VA: 0x1820942E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2094870 Offset: 0x2092E70 VA: 0x182094870 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2094940 Offset: 0x2092F40 VA: 0x182094940 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppPromoteToLeader previous) { }

	// RVA: 0x2094300 Offset: 0x2092900 VA: 0x182094300 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20940F0 Offset: 0x20926F0 VA: 0x1820940F0
	public static AppPromoteToLeader Deserialize(byte[] buffer, AppPromoteToLeader instance, bool isDelta = False) { }

	// RVA: 0x2093E10 Offset: 0x2092410 VA: 0x182093E10
	public static AppPromoteToLeader Deserialize(Stream stream, AppPromoteToLeader instance, bool isDelta) { }

	// RVA: 0x2093960 Offset: 0x2091F60 VA: 0x182093960
	public static AppPromoteToLeader DeserializeLengthDelimited(Stream stream, AppPromoteToLeader instance, bool isDelta) { }

	// RVA: 0x2093C10 Offset: 0x2092210 VA: 0x182093C10
	public static AppPromoteToLeader DeserializeLength(Stream stream, int length, AppPromoteToLeader instance, bool isDelta) { }

	// RVA: 0x2094420 Offset: 0x2092A20 VA: 0x182094420
	public static void SerializeDelta(Stream stream, AppPromoteToLeader instance, AppPromoteToLeader previous) { }

	// RVA: 0x2094790 Offset: 0x2092D90 VA: 0x182094790
	public static void Serialize(Stream stream, AppPromoteToLeader instance) { }

	// RVA: 0x2094860 Offset: 0x2092E60 VA: 0x182094860
	public byte[] ToProtoBytes() { }

	// RVA: 0x2094870 Offset: 0x2092E70 VA: 0x182094870
	public void ToProto(Stream stream) { }

	// RVA: 0x20945E0 Offset: 0x2092BE0 VA: 0x1820945E0
	public static byte[] SerializeToBytes(AppPromoteToLeader instance) { }

	// RVA: 0x2094530 Offset: 0x2092B30 VA: 0x182094530
	public static void SerializeLengthDelimited(Stream stream, AppPromoteToLeader instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class AppSuccess : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6519
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11

	// Methods

	// RVA: 0x1E1B7D0 Offset: 0x1E19DD0 VA: 0x181E1B7D0
	public static void ResetToPool(AppSuccess instance) { }

	// RVA: 0x1E1B760 Offset: 0x1E19D60 VA: 0x181E1B760
	public void ResetToPool() { }

	// RVA: 0x1E1B6A0 Offset: 0x1E19CA0 VA: 0x181E1B6A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void CopyTo(AppSuccess instance) { }

	// RVA: 0x1E1ADF0 Offset: 0x1E193F0 VA: 0x181E1ADF0
	public AppSuccess Copy() { }

	// RVA: 0x1E1B520 Offset: 0x1E19B20 VA: 0x181E1B520
	public static AppSuccess Deserialize(Stream stream) { }

	// RVA: 0x1E1B020 Offset: 0x1E19620 VA: 0x181E1B020
	public static AppSuccess DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E1B260 Offset: 0x1E19860 VA: 0x181E1B260
	public static AppSuccess DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E1B400 Offset: 0x1E19A00 VA: 0x181E1B400
	public static AppSuccess Deserialize(byte[] buffer) { }

	// RVA: 0x1E1B720 Offset: 0x1E19D20 VA: 0x181E1B720
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E1BB20 Offset: 0x1E1A120 VA: 0x181E1BB20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E1BB90 Offset: 0x1E1A190 VA: 0x181E1BB90 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppSuccess previous) { }

	// RVA: 0x1E1B740 Offset: 0x1E19D40 VA: 0x181E1B740 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E1B5A0 Offset: 0x1E19BA0 VA: 0x181E1B5A0
	public static AppSuccess Deserialize(byte[] buffer, AppSuccess instance, bool isDelta = False) { }

	// RVA: 0x1E1B2F0 Offset: 0x1E198F0 VA: 0x181E1B2F0
	public static AppSuccess Deserialize(Stream stream, AppSuccess instance, bool isDelta) { }

	// RVA: 0x1E1AE40 Offset: 0x1E19440 VA: 0x181E1AE40
	public static AppSuccess DeserializeLengthDelimited(Stream stream, AppSuccess instance, bool isDelta) { }

	// RVA: 0x1E1B0A0 Offset: 0x1E196A0 VA: 0x181E1B0A0
	public static AppSuccess DeserializeLength(Stream stream, int length, AppSuccess instance, bool isDelta) { }

	// RVA: 0x1E1B840 Offset: 0x1E19E40 VA: 0x181E1B840
	public static void SerializeDelta(Stream stream, AppSuccess instance, AppSuccess previous) { }

	// RVA: 0x1E1BAB0 Offset: 0x1E1A0B0 VA: 0x181E1BAB0
	public static void Serialize(Stream stream, AppSuccess instance) { }

	// RVA: 0x1E1BB10 Offset: 0x1E1A110 VA: 0x181E1BB10
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E1BB20 Offset: 0x1E1A120 VA: 0x181E1BB20
	public void ToProto(Stream stream) { }

	// RVA: 0x1E1B950 Offset: 0x1E19F50 VA: 0x181E1B950
	public static byte[] SerializeToBytes(AppSuccess instance) { }

	// RVA: 0x1E1B8A0 Offset: 0x1E19EA0 VA: 0x181E1B8A0
	public static void SerializeLengthDelimited(Stream stream, AppSuccess instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class AppError : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6520
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string error; // 0x18

	// Methods

	// RVA: 0x2087250 Offset: 0x2085850 VA: 0x182087250
	public static void ResetToPool(AppError instance) { }

	// RVA: 0x20871C0 Offset: 0x20857C0 VA: 0x1820871C0
	public void ResetToPool() { }

	// RVA: 0x2087070 Offset: 0x2085670 VA: 0x182087070 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D68640 Offset: 0x1D66C40 VA: 0x181D68640
	public void CopyTo(AppError instance) { }

	// RVA: 0x20866D0 Offset: 0x2084CD0 VA: 0x1820866D0
	public AppError Copy() { }

	// RVA: 0x2086D80 Offset: 0x2085380 VA: 0x182086D80
	public static AppError Deserialize(Stream stream) { }

	// RVA: 0x2086750 Offset: 0x2084D50 VA: 0x182086750
	public static AppError DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2086BF0 Offset: 0x20851F0 VA: 0x182086BF0
	public static AppError DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2086F50 Offset: 0x2085550 VA: 0x182086F50
	public static AppError Deserialize(byte[] buffer) { }

	// RVA: 0x2087180 Offset: 0x2085780 VA: 0x182087180
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2087740 Offset: 0x2085D40 VA: 0x182087740 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2087760 Offset: 0x2085D60 VA: 0x182087760 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppError previous) { }

	// RVA: 0x20871A0 Offset: 0x20857A0 VA: 0x1820871A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2086C80 Offset: 0x2085280 VA: 0x182086C80
	public static AppError Deserialize(byte[] buffer, AppError instance, bool isDelta = False) { }

	// RVA: 0x2086E00 Offset: 0x2085400 VA: 0x182086E00
	public static AppError Deserialize(Stream stream, AppError instance, bool isDelta) { }

	// RVA: 0x20867D0 Offset: 0x2084DD0 VA: 0x1820867D0
	public static AppError DeserializeLengthDelimited(Stream stream, AppError instance, bool isDelta) { }

	// RVA: 0x20869F0 Offset: 0x2084FF0 VA: 0x1820869F0
	public static AppError DeserializeLength(Stream stream, int length, AppError instance, bool isDelta) { }

	// RVA: 0x20872E0 Offset: 0x20858E0 VA: 0x1820872E0
	public static void SerializeDelta(Stream stream, AppError instance, AppError previous) { }

	// RVA: 0x2087600 Offset: 0x2085C00 VA: 0x182087600
	public static void Serialize(Stream stream, AppError instance) { }

	// RVA: 0x2087730 Offset: 0x2085D30 VA: 0x182087730
	public byte[] ToProtoBytes() { }

	// RVA: 0x2087740 Offset: 0x2085D40 VA: 0x182087740
	public void ToProto(Stream stream) { }

	// RVA: 0x20874F0 Offset: 0x2085AF0 VA: 0x1820874F0
	public static byte[] SerializeToBytes(AppError instance) { }

	// RVA: 0x2087440 Offset: 0x2085A40 VA: 0x182087440
	public static void SerializeLengthDelimited(Stream stream, AppError instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class AppFlag : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6521
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public bool value; // 0x12

	// Methods

	// RVA: 0x2088390 Offset: 0x2086990 VA: 0x182088390
	public static void ResetToPool(AppFlag instance) { }

	// RVA: 0x2088410 Offset: 0x2086A10 VA: 0x182088410
	public void ResetToPool() { }

	// RVA: 0x2088260 Offset: 0x2086860 VA: 0x182088260 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E19C60 Offset: 0x1E18260 VA: 0x181E19C60
	public void CopyTo(AppFlag instance) { }

	// RVA: 0x20878E0 Offset: 0x2085EE0 VA: 0x1820878E0
	public AppFlag Copy() { }

	// RVA: 0x20881E0 Offset: 0x20867E0 VA: 0x1820881E0
	public static AppFlag Deserialize(Stream stream) { }

	// RVA: 0x2087B70 Offset: 0x2086170 VA: 0x182087B70
	public static AppFlag DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2087BF0 Offset: 0x20861F0 VA: 0x182087BF0
	public static AppFlag DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2087E80 Offset: 0x2086480 VA: 0x182087E80
	public static AppFlag Deserialize(byte[] buffer) { }

	// RVA: 0x2088350 Offset: 0x2086950 VA: 0x182088350
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20888A0 Offset: 0x2086EA0 VA: 0x1820888A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2088970 Offset: 0x2086F70 VA: 0x182088970 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppFlag previous) { }

	// RVA: 0x2088370 Offset: 0x2086970 VA: 0x182088370 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2087FA0 Offset: 0x20865A0 VA: 0x182087FA0
	public static AppFlag Deserialize(byte[] buffer, AppFlag instance, bool isDelta = False) { }

	// RVA: 0x20880A0 Offset: 0x20866A0 VA: 0x1820880A0
	public static AppFlag Deserialize(Stream stream, AppFlag instance, bool isDelta) { }

	// RVA: 0x2087950 Offset: 0x2085F50 VA: 0x182087950
	public static AppFlag DeserializeLengthDelimited(Stream stream, AppFlag instance, bool isDelta) { }

	// RVA: 0x2087C80 Offset: 0x2086280 VA: 0x182087C80
	public static AppFlag DeserializeLength(Stream stream, int length, AppFlag instance, bool isDelta) { }

	// RVA: 0x2088490 Offset: 0x2086A90 VA: 0x182088490
	public static void SerializeDelta(Stream stream, AppFlag instance, AppFlag previous) { }

	// RVA: 0x20887C0 Offset: 0x2086DC0 VA: 0x1820887C0
	public static void Serialize(Stream stream, AppFlag instance) { }

	// RVA: 0x2088890 Offset: 0x2086E90 VA: 0x182088890
	public byte[] ToProtoBytes() { }

	// RVA: 0x20888A0 Offset: 0x2086EA0 VA: 0x1820888A0
	public void ToProto(Stream stream) { }

	// RVA: 0x2088610 Offset: 0x2086C10 VA: 0x182088610
	public static byte[] SerializeToBytes(AppFlag instance) { }

	// RVA: 0x2088560 Offset: 0x2086B60 VA: 0x182088560
	public static void SerializeLengthDelimited(Stream stream, AppFlag instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x208A2D0 Offset: 0x20888D0 VA: 0x18208A2D0
	public static void ResetToPool(AppInfo instance) { }

	// RVA: 0x208A120 Offset: 0x2088720 VA: 0x18208A120
	public void ResetToPool() { }

	// RVA: 0x2089EB0 Offset: 0x20884B0 VA: 0x182089EB0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2088AC0 Offset: 0x20870C0 VA: 0x182088AC0
	public void CopyTo(AppInfo instance) { }

	// RVA: 0x2088B70 Offset: 0x2087170 VA: 0x182088B70
	public AppInfo Copy() { }

	// RVA: 0x2089E30 Offset: 0x2088430 VA: 0x182089E30
	public static AppInfo Deserialize(Stream stream) { }

	// RVA: 0x2089190 Offset: 0x2087790 VA: 0x182089190
	public static AppInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2089210 Offset: 0x2087810 VA: 0x182089210
	public static AppInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20898B0 Offset: 0x2087EB0 VA: 0x1820898B0
	public static AppInfo Deserialize(byte[] buffer) { }

	// RVA: 0x208A0E0 Offset: 0x20886E0 VA: 0x18208A0E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x208B080 Offset: 0x2089680 VA: 0x18208B080 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x208B0A0 Offset: 0x20896A0 VA: 0x18208B0A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppInfo previous) { }

	// RVA: 0x208A100 Offset: 0x2088700 VA: 0x18208A100 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20897B0 Offset: 0x2087DB0 VA: 0x1820897B0
	public static AppInfo Deserialize(byte[] buffer, AppInfo instance, bool isDelta = False) { }

	// RVA: 0x20899D0 Offset: 0x2087FD0 VA: 0x1820899D0
	public static AppInfo Deserialize(Stream stream, AppInfo instance, bool isDelta) { }

	// RVA: 0x2088C60 Offset: 0x2087260 VA: 0x182088C60
	public static AppInfo DeserializeLengthDelimited(Stream stream, AppInfo instance, bool isDelta) { }

	// RVA: 0x20892A0 Offset: 0x20878A0 VA: 0x1820892A0
	public static AppInfo DeserializeLength(Stream stream, int length, AppInfo instance, bool isDelta) { }

	// RVA: 0x208A480 Offset: 0x2088A80 VA: 0x18208A480
	public static void SerializeDelta(Stream stream, AppInfo instance, AppInfo previous) { }

	// RVA: 0x208AC50 Offset: 0x2089250 VA: 0x18208AC50
	public static void Serialize(Stream stream, AppInfo instance) { }

	// RVA: 0x208B070 Offset: 0x2089670 VA: 0x18208B070
	public byte[] ToProtoBytes() { }

	// RVA: 0x208B080 Offset: 0x2089680 VA: 0x18208B080
	public void ToProto(Stream stream) { }

	// RVA: 0x208AB40 Offset: 0x2089140 VA: 0x18208AB40
	public static byte[] SerializeToBytes(AppInfo instance) { }

	// RVA: 0x208AA90 Offset: 0x2089090 VA: 0x18208AA90
	public static void SerializeLengthDelimited(Stream stream, AppInfo instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x1E23BE0 Offset: 0x1E221E0 VA: 0x181E23BE0
	public static void ResetToPool(AppTime instance) { }

	// RVA: 0x1E23B30 Offset: 0x1E22130 VA: 0x181E23B30
	public void ResetToPool() { }

	// RVA: 0x1E23830 Offset: 0x1E21E30 VA: 0x181E23830 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E22480 Offset: 0x1E20A80 VA: 0x181E22480
	public void CopyTo(AppTime instance) { }

	// RVA: 0x1E224C0 Offset: 0x1E20AC0 VA: 0x181E224C0
	public AppTime Copy() { }

	// RVA: 0x1E22FD0 Offset: 0x1E215D0 VA: 0x181E22FD0
	public static AppTime Deserialize(Stream stream) { }

	// RVA: 0x1E22540 Offset: 0x1E20B40 VA: 0x181E22540
	public static AppTime DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E228F0 Offset: 0x1E20EF0 VA: 0x181E228F0
	public static AppTime DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E234D0 Offset: 0x1E21AD0 VA: 0x181E234D0
	public static AppTime Deserialize(byte[] buffer) { }

	// RVA: 0x1E238B0 Offset: 0x1E21EB0 VA: 0x181E238B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E24260 Offset: 0x1E22860 VA: 0x181E24260 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E24280 Offset: 0x1E22880 VA: 0x181E24280 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppTime previous) { }

	// RVA: 0x1E23B10 Offset: 0x1E22110 VA: 0x181E23B10 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E22C90 Offset: 0x1E21290 VA: 0x181E22C90
	public static AppTime Deserialize(byte[] buffer, AppTime instance, bool isDelta = False) { }

	// RVA: 0x1E23270 Offset: 0x1E21870 VA: 0x181E23270
	public static AppTime Deserialize(Stream stream, AppTime instance, bool isDelta) { }

	// RVA: 0x1E225C0 Offset: 0x1E20BC0 VA: 0x181E225C0
	public static AppTime DeserializeLengthDelimited(Stream stream, AppTime instance, bool isDelta) { }

	// RVA: 0x1E22980 Offset: 0x1E20F80 VA: 0x181E22980
	public static AppTime DeserializeLength(Stream stream, int length, AppTime instance, bool isDelta) { }

	// RVA: 0x1E23C90 Offset: 0x1E22290 VA: 0x181E23C90
	public static void SerializeDelta(Stream stream, AppTime instance, AppTime previous) { }

	// RVA: 0x1E240E0 Offset: 0x1E226E0 VA: 0x181E240E0
	public static void Serialize(Stream stream, AppTime instance) { }

	// RVA: 0x1E24250 Offset: 0x1E22850 VA: 0x181E24250
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E24260 Offset: 0x1E22860 VA: 0x181E24260
	public void ToProto(Stream stream) { }

	// RVA: 0x1E23FD0 Offset: 0x1E225D0 VA: 0x181E23FD0
	public static byte[] SerializeToBytes(AppTime instance) { }

	// RVA: 0x1E23F20 Offset: 0x1E22520 VA: 0x181E23F20
	public static void SerializeLengthDelimited(Stream stream, AppTime instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x208EBD0 Offset: 0x208D1D0 VA: 0x18208EBD0
	public static void ResetToPool(AppMap instance) { }

	// RVA: 0x208E9A0 Offset: 0x208CFA0 VA: 0x18208E9A0
	public void ResetToPool() { }

	// RVA: 0x208E5B0 Offset: 0x208CBB0 VA: 0x18208E5B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x208CB00 Offset: 0x208B100 VA: 0x18208CB00
	public void CopyTo(AppMap instance) { }

	// RVA: 0x208CD20 Offset: 0x208B320 VA: 0x18208CD20
	public AppMap Copy() { }

	// RVA: 0x208DAD0 Offset: 0x208C0D0 VA: 0x18208DAD0
	public static AppMap Deserialize(Stream stream) { }

	// RVA: 0x208D1D0 Offset: 0x208B7D0 VA: 0x18208D1D0
	public static AppMap DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x208D650 Offset: 0x208BC50 VA: 0x18208D650
	public static AppMap DeserializeLength(Stream stream, int length) { }

	// RVA: 0x208D6E0 Offset: 0x208BCE0 VA: 0x18208D6E0
	public static AppMap Deserialize(byte[] buffer) { }

	// RVA: 0x208E630 Offset: 0x208CC30 VA: 0x18208E630
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x208F6F0 Offset: 0x208DCF0 VA: 0x18208F6F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x208F710 Offset: 0x208DD10 VA: 0x18208F710 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppMap previous) { }

	// RVA: 0x208E980 Offset: 0x208CF80 VA: 0x18208E980 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x208E180 Offset: 0x208C780 VA: 0x18208E180
	public static AppMap Deserialize(byte[] buffer, AppMap instance, bool isDelta = False) { }

	// RVA: 0x208DE30 Offset: 0x208C430 VA: 0x18208DE30
	public static AppMap Deserialize(Stream stream, AppMap instance, bool isDelta) { }

	// RVA: 0x208CDA0 Offset: 0x208B3A0 VA: 0x18208CDA0
	public static AppMap DeserializeLengthDelimited(Stream stream, AppMap instance, bool isDelta) { }

	// RVA: 0x208D250 Offset: 0x208B850 VA: 0x18208D250
	public static AppMap DeserializeLength(Stream stream, int length, AppMap instance, bool isDelta) { }

	// RVA: 0x208EE00 Offset: 0x208D400 VA: 0x18208EE00
	public static void SerializeDelta(Stream stream, AppMap instance, AppMap previous) { }

	// RVA: 0x208F390 Offset: 0x208D990 VA: 0x18208F390
	public static void Serialize(Stream stream, AppMap instance) { }

	// RVA: 0x208F6E0 Offset: 0x208DCE0 VA: 0x18208F6E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x208F6F0 Offset: 0x208DCF0 VA: 0x18208F6F0
	public void ToProto(Stream stream) { }

	// RVA: 0x208F280 Offset: 0x208D880 VA: 0x18208F280
	public static byte[] SerializeToBytes(AppMap instance) { }

	// RVA: 0x208F1D0 Offset: 0x208D7D0 VA: 0x18208F1D0
	public static void SerializeLengthDelimited(Stream stream, AppMap instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x20974F0 Offset: 0x2095AF0 VA: 0x1820974F0
	public static void ResetToPool(AppMap.Monument instance) { }

	// RVA: 0x20975A0 Offset: 0x2095BA0 VA: 0x1820975A0
	public void ResetToPool() { }

	// RVA: 0x2097290 Offset: 0x2095890 VA: 0x182097290 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2096280 Offset: 0x2094880 VA: 0x182096280
	public void CopyTo(AppMap.Monument instance) { }

	// RVA: 0x20962D0 Offset: 0x20948D0 VA: 0x1820962D0
	public AppMap.Monument Copy() { }

	// RVA: 0x2096990 Offset: 0x2094F90 VA: 0x182096990
	public static AppMap.Monument Deserialize(Stream stream) { }

	// RVA: 0x2096600 Offset: 0x2094C00 VA: 0x182096600
	public static AppMap.Monument DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2096900 Offset: 0x2094F00 VA: 0x182096900
	public static AppMap.Monument DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2096E20 Offset: 0x2095420 VA: 0x182096E20
	public static AppMap.Monument Deserialize(byte[] buffer) { }

	// RVA: 0x2097310 Offset: 0x2095910 VA: 0x182097310
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2097BE0 Offset: 0x20961E0 VA: 0x182097BE0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2097C00 Offset: 0x2096200 VA: 0x182097C00 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppMap.Monument previous) { }

	// RVA: 0x20974D0 Offset: 0x2095AD0 VA: 0x1820974D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2096B90 Offset: 0x2095190 VA: 0x182096B90
	public static AppMap.Monument Deserialize(byte[] buffer, AppMap.Monument instance, bool isDelta = False) { }

	// RVA: 0x20970D0 Offset: 0x20956D0 VA: 0x1820970D0
	public static AppMap.Monument Deserialize(Stream stream, AppMap.Monument instance, bool isDelta) { }

	// RVA: 0x2096360 Offset: 0x2094960 VA: 0x182096360
	public static AppMap.Monument DeserializeLengthDelimited(Stream stream, AppMap.Monument instance, bool isDelta) { }

	// RVA: 0x2096680 Offset: 0x2094C80 VA: 0x182096680
	public static AppMap.Monument DeserializeLength(Stream stream, int length, AppMap.Monument instance, bool isDelta) { }

	// RVA: 0x2097650 Offset: 0x2095C50 VA: 0x182097650
	public static void SerializeDelta(Stream stream, AppMap.Monument instance, AppMap.Monument previous) { }

	// RVA: 0x2097A40 Offset: 0x2096040 VA: 0x182097A40
	public static void Serialize(Stream stream, AppMap.Monument instance) { }

	// RVA: 0x2097BD0 Offset: 0x20961D0 VA: 0x182097BD0
	public byte[] ToProtoBytes() { }

	// RVA: 0x2097BE0 Offset: 0x20961E0 VA: 0x182097BE0
	public void ToProto(Stream stream) { }

	// RVA: 0x2097930 Offset: 0x2095F30 VA: 0x182097930
	public static byte[] SerializeToBytes(AppMap.Monument instance) { }

	// RVA: 0x2097880 Offset: 0x2095E80 VA: 0x182097880
	public static void SerializeLengthDelimited(Stream stream, AppMap.Monument instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class AppEntityInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6526
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public AppEntityType type; // 0x14
	public AppEntityPayload payload; // 0x18

	// Methods

	// RVA: 0x20837E0 Offset: 0x2081DE0 VA: 0x1820837E0
	public static void ResetToPool(AppEntityInfo instance) { }

	// RVA: 0x2083730 Offset: 0x2081D30 VA: 0x182083730
	public void ResetToPool() { }

	// RVA: 0x20835C0 Offset: 0x2081BC0 VA: 0x1820835C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2081440 Offset: 0x207FA40 VA: 0x182081440
	public void CopyTo(AppEntityInfo instance) { }

	// RVA: 0x20829D0 Offset: 0x2080FD0 VA: 0x1820829D0
	public AppEntityInfo Copy() { }

	// RVA: 0x2083540 Offset: 0x2081B40 VA: 0x182083540
	public static AppEntityInfo Deserialize(Stream stream) { }

	// RVA: 0x2082AA0 Offset: 0x20810A0 VA: 0x182082AA0
	public static AppEntityInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2083090 Offset: 0x2081690 VA: 0x182083090
	public static AppEntityInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2083120 Offset: 0x2081720 VA: 0x182083120
	public static AppEntityInfo Deserialize(byte[] buffer) { }

	// RVA: 0x20836F0 Offset: 0x2081CF0 VA: 0x1820836F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2083EA0 Offset: 0x20824A0 VA: 0x182083EA0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2083EC0 Offset: 0x20824C0 VA: 0x182083EC0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppEntityInfo previous) { }

	// RVA: 0x2083710 Offset: 0x2081D10 VA: 0x182083710 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2083440 Offset: 0x2081A40 VA: 0x182083440
	public static AppEntityInfo Deserialize(byte[] buffer, AppEntityInfo instance, bool isDelta = False) { }

	// RVA: 0x2083240 Offset: 0x2081840 VA: 0x182083240
	public static AppEntityInfo Deserialize(Stream stream, AppEntityInfo instance, bool isDelta) { }

	// RVA: 0x2082B20 Offset: 0x2081120 VA: 0x182082B20
	public static AppEntityInfo DeserializeLengthDelimited(Stream stream, AppEntityInfo instance, bool isDelta) { }

	// RVA: 0x2082DF0 Offset: 0x20813F0 VA: 0x182082DF0
	public static AppEntityInfo DeserializeLength(Stream stream, int length, AppEntityInfo instance, bool isDelta) { }

	// RVA: 0x2083890 Offset: 0x2081E90 VA: 0x182083890
	public static void SerializeDelta(Stream stream, AppEntityInfo instance, AppEntityInfo previous) { }

	// RVA: 0x2083C80 Offset: 0x2082280 VA: 0x182083C80
	public static void Serialize(Stream stream, AppEntityInfo instance) { }

	// RVA: 0x2083E90 Offset: 0x2082490 VA: 0x182083E90
	public byte[] ToProtoBytes() { }

	// RVA: 0x2083EA0 Offset: 0x20824A0 VA: 0x182083EA0
	public void ToProto(Stream stream) { }

	// RVA: 0x2083B70 Offset: 0x2082170 VA: 0x182083B70
	public static byte[] SerializeToBytes(AppEntityInfo instance) { }

	// RVA: 0x2083AC0 Offset: 0x20820C0 VA: 0x182083AC0
	public static void SerializeLengthDelimited(Stream stream, AppEntityInfo instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x2085AD0 Offset: 0x20840D0 VA: 0x182085AD0
	public static void ResetToPool(AppEntityPayload instance) { }

	// RVA: 0x2085CE0 Offset: 0x20842E0 VA: 0x182085CE0
	public void ResetToPool() { }

	// RVA: 0x2085740 Offset: 0x2083D40 VA: 0x182085740 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2083EE0 Offset: 0x20824E0 VA: 0x182083EE0
	public void CopyTo(AppEntityPayload instance) { }

	// RVA: 0x2084090 Offset: 0x2082690 VA: 0x182084090
	public AppEntityPayload Copy() { }

	// RVA: 0x2084D60 Offset: 0x2083360 VA: 0x182084D60
	public static AppEntityPayload Deserialize(Stream stream) { }

	// RVA: 0x2084110 Offset: 0x2082710 VA: 0x182084110
	public static AppEntityPayload DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2084570 Offset: 0x2082B70 VA: 0x182084570
	public static AppEntityPayload DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20849B0 Offset: 0x2082FB0 VA: 0x1820849B0
	public static AppEntityPayload Deserialize(byte[] buffer) { }

	// RVA: 0x20857C0 Offset: 0x2083DC0 VA: 0x1820857C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2086690 Offset: 0x2084C90 VA: 0x182086690 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20866B0 Offset: 0x2084CB0 VA: 0x1820866B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppEntityPayload previous) { }

	// RVA: 0x2085AB0 Offset: 0x20840B0 VA: 0x182085AB0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2085070 Offset: 0x2083670 VA: 0x182085070
	public static AppEntityPayload Deserialize(byte[] buffer, AppEntityPayload instance, bool isDelta = False) { }

	// RVA: 0x2085440 Offset: 0x2083A40 VA: 0x182085440
	public static AppEntityPayload Deserialize(Stream stream, AppEntityPayload instance, bool isDelta) { }

	// RVA: 0x2084190 Offset: 0x2082790 VA: 0x182084190
	public static AppEntityPayload DeserializeLengthDelimited(Stream stream, AppEntityPayload instance, bool isDelta) { }

	// RVA: 0x2084600 Offset: 0x2082C00 VA: 0x182084600
	public static AppEntityPayload DeserializeLength(Stream stream, int length, AppEntityPayload instance, bool isDelta) { }

	// RVA: 0x2085EF0 Offset: 0x20844F0 VA: 0x182085EF0
	public static void SerializeDelta(Stream stream, AppEntityPayload instance, AppEntityPayload previous) { }

	// RVA: 0x20863D0 Offset: 0x20849D0 VA: 0x1820863D0
	public static void Serialize(Stream stream, AppEntityPayload instance) { }

	// RVA: 0x2086680 Offset: 0x2084C80 VA: 0x182086680
	public byte[] ToProtoBytes() { }

	// RVA: 0x2086690 Offset: 0x2084C90 VA: 0x182086690
	public void ToProto(Stream stream) { }

	// RVA: 0x20862C0 Offset: 0x20848C0 VA: 0x1820862C0
	public static byte[] SerializeToBytes(AppEntityPayload instance) { }

	// RVA: 0x2086210 Offset: 0x2084810 VA: 0x182086210
	public static void SerializeLengthDelimited(Stream stream, AppEntityPayload instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x2095C70 Offset: 0x2094270 VA: 0x182095C70
	public static void ResetToPool(AppEntityPayload.Item instance) { }

	// RVA: 0x2095D00 Offset: 0x2094300 VA: 0x182095D00
	public void ResetToPool() { }

	// RVA: 0x2095A20 Offset: 0x2094020 VA: 0x182095A20 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D69690 Offset: 0x1D67C90 VA: 0x181D69690
	public void CopyTo(AppEntityPayload.Item instance) { }

	// RVA: 0x2094AF0 Offset: 0x20930F0 VA: 0x182094AF0
	public AppEntityPayload.Item Copy() { }

	// RVA: 0x2095160 Offset: 0x2093760 VA: 0x182095160
	public static AppEntityPayload.Item Deserialize(Stream stream) { }

	// RVA: 0x2094B70 Offset: 0x2093170 VA: 0x182094B70
	public static AppEntityPayload.Item DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2094E70 Offset: 0x2093470 VA: 0x182094E70
	public static AppEntityPayload.Item DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2095350 Offset: 0x2093950 VA: 0x182095350
	public static AppEntityPayload.Item Deserialize(byte[] buffer) { }

	// RVA: 0x2095AA0 Offset: 0x20940A0 VA: 0x182095AA0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2096240 Offset: 0x2094840 VA: 0x182096240 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2096260 Offset: 0x2094860 VA: 0x182096260 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppEntityPayload.Item previous) { }

	// RVA: 0x2095C50 Offset: 0x2094250 VA: 0x182095C50 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20957A0 Offset: 0x2093DA0 VA: 0x1820957A0
	public static AppEntityPayload.Item Deserialize(byte[] buffer, AppEntityPayload.Item instance, bool isDelta = False) { }

	// RVA: 0x20955F0 Offset: 0x2093BF0 VA: 0x1820955F0
	public static AppEntityPayload.Item Deserialize(Stream stream, AppEntityPayload.Item instance, bool isDelta) { }

	// RVA: 0x2094BF0 Offset: 0x20931F0 VA: 0x182094BF0
	public static AppEntityPayload.Item DeserializeLengthDelimited(Stream stream, AppEntityPayload.Item instance, bool isDelta) { }

	// RVA: 0x2094F00 Offset: 0x2093500 VA: 0x182094F00
	public static AppEntityPayload.Item DeserializeLength(Stream stream, int length, AppEntityPayload.Item instance, bool isDelta) { }

	// RVA: 0x2095D90 Offset: 0x2094390 VA: 0x182095D90
	public static void SerializeDelta(Stream stream, AppEntityPayload.Item instance, AppEntityPayload.Item previous) { }

	// RVA: 0x2096110 Offset: 0x2094710 VA: 0x182096110
	public static void Serialize(Stream stream, AppEntityPayload.Item instance) { }

	// RVA: 0x2096230 Offset: 0x2094830 VA: 0x182096230
	public byte[] ToProtoBytes() { }

	// RVA: 0x2096240 Offset: 0x2094840 VA: 0x182096240
	public void ToProto(Stream stream) { }

	// RVA: 0x2096000 Offset: 0x2094600 VA: 0x182096000
	public static byte[] SerializeToBytes(AppEntityPayload.Item instance) { }

	// RVA: 0x2095F50 Offset: 0x2094550 VA: 0x182095F50
	public static void SerializeLengthDelimited(Stream stream, AppEntityPayload.Item instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x1E20220 Offset: 0x1E1E820 VA: 0x181E20220
	public static void ResetToPool(AppTeamInfo instance) { }

	// RVA: 0x1E1FDF0 Offset: 0x1E1E3F0 VA: 0x181E1FDF0
	public void ResetToPool() { }

	// RVA: 0x1E1FD30 Offset: 0x1E1E330 VA: 0x181E1FD30 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E1E760 Offset: 0x1E1CD60 VA: 0x181E1E760
	public void CopyTo(AppTeamInfo instance) { }

	// RVA: 0x1E1EBB0 Offset: 0x1E1D1B0 VA: 0x181E1EBB0
	public AppTeamInfo Copy() { }

	// RVA: 0x1E1FCB0 Offset: 0x1E1E2B0 VA: 0x181E1FCB0
	public static AppTeamInfo Deserialize(Stream stream) { }

	// RVA: 0x1E1F0F0 Offset: 0x1E1D6F0 VA: 0x181E1F0F0
	public static AppTeamInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E1F170 Offset: 0x1E1D770 VA: 0x181E1F170
	public static AppTeamInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E1FB90 Offset: 0x1E1E190 VA: 0x181E1FB90
	public static AppTeamInfo Deserialize(byte[] buffer) { }

	// RVA: 0x1E1FDB0 Offset: 0x1E1E3B0 VA: 0x181E1FDB0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E21150 Offset: 0x1E1F750 VA: 0x181E21150 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E21170 Offset: 0x1E1F770 VA: 0x181E21170 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppTeamInfo previous) { }

	// RVA: 0x1E1FDD0 Offset: 0x1E1E3D0 VA: 0x181E1FDD0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E1FA90 Offset: 0x1E1E090 VA: 0x181E1FA90
	public static AppTeamInfo Deserialize(byte[] buffer, AppTeamInfo instance, bool isDelta = False) { }

	// RVA: 0x1E1F6A0 Offset: 0x1E1DCA0 VA: 0x181E1F6A0
	public static AppTeamInfo Deserialize(Stream stream, AppTeamInfo instance, bool isDelta) { }

	// RVA: 0x1E1EC30 Offset: 0x1E1D230 VA: 0x181E1EC30
	public static AppTeamInfo DeserializeLengthDelimited(Stream stream, AppTeamInfo instance, bool isDelta) { }

	// RVA: 0x1E1F200 Offset: 0x1E1D800 VA: 0x181E1F200
	public static AppTeamInfo DeserializeLength(Stream stream, int length, AppTeamInfo instance, bool isDelta) { }

	// RVA: 0x1E20650 Offset: 0x1E1EC50 VA: 0x181E20650
	public static void SerializeDelta(Stream stream, AppTeamInfo instance, AppTeamInfo previous) { }

	// RVA: 0x1E20CC0 Offset: 0x1E1F2C0 VA: 0x181E20CC0
	public static void Serialize(Stream stream, AppTeamInfo instance) { }

	// RVA: 0x1E21140 Offset: 0x1E1F740 VA: 0x181E21140
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E21150 Offset: 0x1E1F750 VA: 0x181E21150
	public void ToProto(Stream stream) { }

	// RVA: 0x1E20BB0 Offset: 0x1E1F1B0 VA: 0x181E20BB0
	public static byte[] SerializeToBytes(AppTeamInfo instance) { }

	// RVA: 0x1E20B00 Offset: 0x1E1F100 VA: 0x181E20B00
	public static void SerializeLengthDelimited(Stream stream, AppTeamInfo instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x1E28620 Offset: 0x1E26C20 VA: 0x181E28620
	public static void ResetToPool(AppTeamInfo.Member instance) { }

	// RVA: 0x1E28520 Offset: 0x1E26B20 VA: 0x181E28520
	public void ResetToPool() { }

	// RVA: 0x1E28150 Offset: 0x1E26750 VA: 0x181E28150 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E26820 Offset: 0x1E24E20 VA: 0x181E26820
	public void CopyTo(AppTeamInfo.Member instance) { }

	// RVA: 0x1E26890 Offset: 0x1E24E90 VA: 0x181E26890
	public AppTeamInfo.Member Copy() { }

	// RVA: 0x1E27690 Offset: 0x1E25C90 VA: 0x181E27690
	public static AppTeamInfo.Member Deserialize(Stream stream) { }

	// RVA: 0x1E26940 Offset: 0x1E24F40 VA: 0x181E26940
	public static AppTeamInfo.Member DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E26DD0 Offset: 0x1E253D0 VA: 0x181E26DD0
	public static AppTeamInfo.Member DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E27250 Offset: 0x1E25850 VA: 0x181E27250
	public static AppTeamInfo.Member Deserialize(byte[] buffer) { }

	// RVA: 0x1E281D0 Offset: 0x1E267D0 VA: 0x181E281D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E28F00 Offset: 0x1E27500 VA: 0x181E28F00 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E28F20 Offset: 0x1E27520 VA: 0x181E28F20 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppTeamInfo.Member previous) { }

	// RVA: 0x1E28500 Offset: 0x1E26B00 VA: 0x181E28500 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E27D30 Offset: 0x1E26330 VA: 0x181E27D30
	public static AppTeamInfo.Member Deserialize(byte[] buffer, AppTeamInfo.Member instance, bool isDelta = False) { }

	// RVA: 0x1E27A00 Offset: 0x1E26000 VA: 0x181E27A00
	public static AppTeamInfo.Member Deserialize(Stream stream, AppTeamInfo.Member instance, bool isDelta) { }

	// RVA: 0x1E269C0 Offset: 0x1E24FC0 VA: 0x181E269C0
	public static AppTeamInfo.Member DeserializeLengthDelimited(Stream stream, AppTeamInfo.Member instance, bool isDelta) { }

	// RVA: 0x1E26E60 Offset: 0x1E25460 VA: 0x181E26E60
	public static AppTeamInfo.Member DeserializeLength(Stream stream, int length, AppTeamInfo.Member instance, bool isDelta) { }

	// RVA: 0x1E28720 Offset: 0x1E26D20 VA: 0x181E28720
	public static void SerializeDelta(Stream stream, AppTeamInfo.Member instance, AppTeamInfo.Member previous) { }

	// RVA: 0x1E28C90 Offset: 0x1E27290 VA: 0x181E28C90
	public static void Serialize(Stream stream, AppTeamInfo.Member instance) { }

	// RVA: 0x1E28EF0 Offset: 0x1E274F0 VA: 0x181E28EF0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E28F00 Offset: 0x1E27500 VA: 0x181E28F00
	public void ToProto(Stream stream) { }

	// RVA: 0x1E28B80 Offset: 0x1E27180 VA: 0x181E28B80
	public static byte[] SerializeToBytes(AppTeamInfo.Member instance) { }

	// RVA: 0x1E28AD0 Offset: 0x1E270D0 VA: 0x181E28AD0
	public static void SerializeLengthDelimited(Stream stream, AppTeamInfo.Member instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x1E2A130 Offset: 0x1E28730 VA: 0x181E2A130
	public static void ResetToPool(AppTeamInfo.Note instance) { }

	// RVA: 0x1E2A1C0 Offset: 0x1E287C0 VA: 0x181E2A1C0
	public void ResetToPool() { }

	// RVA: 0x1E29EE0 Offset: 0x1E284E0 VA: 0x181E29EE0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E28F40 Offset: 0x1E27540 VA: 0x181E28F40
	public void CopyTo(AppTeamInfo.Note instance) { }

	// RVA: 0x1E28F70 Offset: 0x1E27570 VA: 0x181E28F70
	public AppTeamInfo.Note Copy() { }

	// RVA: 0x1E29CF0 Offset: 0x1E282F0 VA: 0x181E29CF0
	public static AppTeamInfo.Note Deserialize(Stream stream) { }

	// RVA: 0x1E28FF0 Offset: 0x1E275F0 VA: 0x181E28FF0
	public static AppTeamInfo.Note DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E29570 Offset: 0x1E27B70 VA: 0x181E29570
	public static AppTeamInfo.Note DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E29A40 Offset: 0x1E28040 VA: 0x181E29A40
	public static AppTeamInfo.Note Deserialize(byte[] buffer) { }

	// RVA: 0x1E29F60 Offset: 0x1E28560 VA: 0x181E29F60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E2A730 Offset: 0x1E28D30 VA: 0x181E2A730 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E2A750 Offset: 0x1E28D50 VA: 0x181E2A750 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppTeamInfo.Note previous) { }

	// RVA: 0x1E2A110 Offset: 0x1E28710 VA: 0x181E2A110 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E29600 Offset: 0x1E27C00 VA: 0x181E29600
	public static AppTeamInfo.Note Deserialize(byte[] buffer, AppTeamInfo.Note instance, bool isDelta = False) { }

	// RVA: 0x1E29890 Offset: 0x1E27E90 VA: 0x181E29890
	public static AppTeamInfo.Note Deserialize(Stream stream, AppTeamInfo.Note instance, bool isDelta) { }

	// RVA: 0x1E29070 Offset: 0x1E27670 VA: 0x181E29070
	public static AppTeamInfo.Note DeserializeLengthDelimited(Stream stream, AppTeamInfo.Note instance, bool isDelta) { }

	// RVA: 0x1E29300 Offset: 0x1E27900 VA: 0x181E29300
	public static AppTeamInfo.Note DeserializeLength(Stream stream, int length, AppTeamInfo.Note instance, bool isDelta) { }

	// RVA: 0x1E2A250 Offset: 0x1E28850 VA: 0x181E2A250
	public static void SerializeDelta(Stream stream, AppTeamInfo.Note instance, AppTeamInfo.Note previous) { }

	// RVA: 0x1E2A5F0 Offset: 0x1E28BF0 VA: 0x181E2A5F0
	public static void Serialize(Stream stream, AppTeamInfo.Note instance) { }

	// RVA: 0x1E2A720 Offset: 0x1E28D20 VA: 0x181E2A720
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E2A730 Offset: 0x1E28D30 VA: 0x181E2A730
	public void ToProto(Stream stream) { }

	// RVA: 0x1E2A4E0 Offset: 0x1E28AE0 VA: 0x181E2A4E0
	public static byte[] SerializeToBytes(AppTeamInfo.Note instance) { }

	// RVA: 0x1E2A430 Offset: 0x1E28A30 VA: 0x181E2A430
	public static void SerializeLengthDelimited(Stream stream, AppTeamInfo.Note instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x2018940 Offset: 0x2016F40 VA: 0x182018940
	public static void ResetToPool(AppChatMessage instance) { }

	// RVA: 0x2018A50 Offset: 0x2017050 VA: 0x182018A50
	public void ResetToPool() { }

	// RVA: 0x2018520 Offset: 0x2016B20 VA: 0x182018520 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2017070 Offset: 0x2015670 VA: 0x182017070
	public void CopyTo(AppChatMessage instance) { }

	// RVA: 0x20170E0 Offset: 0x20156E0 VA: 0x1820170E0
	public AppChatMessage Copy() { }

	// RVA: 0x2018260 Offset: 0x2016860 VA: 0x182018260
	public static AppChatMessage Deserialize(Stream stream) { }

	// RVA: 0x20174E0 Offset: 0x2015AE0 VA: 0x1820174E0
	public static AppChatMessage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2017560 Offset: 0x2015B60 VA: 0x182017560
	public static AppChatMessage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2017920 Offset: 0x2015F20 VA: 0x182017920
	public static AppChatMessage Deserialize(byte[] buffer) { }

	// RVA: 0x20186B0 Offset: 0x2016CB0 VA: 0x1820186B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2019350 Offset: 0x2017950 VA: 0x182019350 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2019370 Offset: 0x2017970 VA: 0x182019370 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppChatMessage previous) { }

	// RVA: 0x2018920 Offset: 0x2016F20 VA: 0x182018920 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2017F10 Offset: 0x2016510 VA: 0x182017F10
	public static AppChatMessage Deserialize(byte[] buffer, AppChatMessage instance, bool isDelta = False) { }

	// RVA: 0x2017C90 Offset: 0x2016290 VA: 0x182017C90
	public static AppChatMessage Deserialize(Stream stream, AppChatMessage instance, bool isDelta) { }

	// RVA: 0x2017190 Offset: 0x2015790 VA: 0x182017190
	public static AppChatMessage DeserializeLengthDelimited(Stream stream, AppChatMessage instance, bool isDelta) { }

	// RVA: 0x20175F0 Offset: 0x2015BF0 VA: 0x1820175F0
	public static AppChatMessage DeserializeLength(Stream stream, int length, AppChatMessage instance, bool isDelta) { }

	// RVA: 0x2018B60 Offset: 0x2017160 VA: 0x182018B60
	public static void SerializeDelta(Stream stream, AppChatMessage instance, AppChatMessage previous) { }

	// RVA: 0x2019080 Offset: 0x2017680 VA: 0x182019080
	public static void Serialize(Stream stream, AppChatMessage instance) { }

	// RVA: 0x2019340 Offset: 0x2017940 VA: 0x182019340
	public byte[] ToProtoBytes() { }

	// RVA: 0x2019350 Offset: 0x2017950 VA: 0x182019350
	public void ToProto(Stream stream) { }

	// RVA: 0x2018F70 Offset: 0x2017570 VA: 0x182018F70
	public static byte[] SerializeToBytes(AppChatMessage instance) { }

	// RVA: 0x2018EC0 Offset: 0x20174C0 VA: 0x182018EC0
	public static void SerializeLengthDelimited(Stream stream, AppChatMessage instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class AppTeamChat : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6533
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<AppChatMessage> messages; // 0x18

	// Methods

	// RVA: 0x1E1DFE0 Offset: 0x1E1C5E0 VA: 0x181E1DFE0
	public static void ResetToPool(AppTeamChat instance) { }

	// RVA: 0x1E1DE30 Offset: 0x1E1C430 VA: 0x181E1DE30
	public void ResetToPool() { }

	// RVA: 0x1E1DD70 Offset: 0x1E1C370 VA: 0x181E1DD70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E1D1C0 Offset: 0x1E1B7C0 VA: 0x181E1D1C0
	public void CopyTo(AppTeamChat instance) { }

	// RVA: 0x1E1D2F0 Offset: 0x1E1B8F0 VA: 0x181E1D2F0
	public AppTeamChat Copy() { }

	// RVA: 0x1E1DBD0 Offset: 0x1E1C1D0 VA: 0x181E1DBD0
	public static AppTeamChat Deserialize(Stream stream) { }

	// RVA: 0x1E1D370 Offset: 0x1E1B970 VA: 0x181E1D370
	public static AppTeamChat DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E1D8B0 Offset: 0x1E1BEB0 VA: 0x181E1D8B0
	public static AppTeamChat DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E1DC50 Offset: 0x1E1C250 VA: 0x181E1DC50
	public static AppTeamChat Deserialize(byte[] buffer) { }

	// RVA: 0x1E1DDF0 Offset: 0x1E1C3F0 VA: 0x181E1DDF0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E1E720 Offset: 0x1E1CD20 VA: 0x181E1E720 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E1E740 Offset: 0x1E1CD40 VA: 0x181E1E740 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppTeamChat previous) { }

	// RVA: 0x1E1DE10 Offset: 0x1E1C410 VA: 0x181E1DE10 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E1D940 Offset: 0x1E1BF40 VA: 0x181E1D940
	public static AppTeamChat Deserialize(byte[] buffer, AppTeamChat instance, bool isDelta = False) { }

	// RVA: 0x1E1DA40 Offset: 0x1E1C040 VA: 0x181E1DA40
	public static AppTeamChat Deserialize(Stream stream, AppTeamChat instance, bool isDelta) { }

	// RVA: 0x1E1D3F0 Offset: 0x1E1B9F0 VA: 0x181E1D3F0
	public static AppTeamChat DeserializeLengthDelimited(Stream stream, AppTeamChat instance, bool isDelta) { }

	// RVA: 0x1E1D660 Offset: 0x1E1BC60 VA: 0x181E1D660
	public static AppTeamChat DeserializeLength(Stream stream, int length, AppTeamChat instance, bool isDelta) { }

	// RVA: 0x1E1E190 Offset: 0x1E1C790 VA: 0x181E1E190
	public static void SerializeDelta(Stream stream, AppTeamChat instance, AppTeamChat previous) { }

	// RVA: 0x1E1E530 Offset: 0x1E1CB30 VA: 0x181E1E530
	public static void Serialize(Stream stream, AppTeamChat instance) { }

	// RVA: 0x1E1E710 Offset: 0x1E1CD10 VA: 0x181E1E710
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E1E720 Offset: 0x1E1CD20 VA: 0x181E1E720
	public void ToProto(Stream stream) { }

	// RVA: 0x1E1E420 Offset: 0x1E1CA20 VA: 0x181E1E420
	public static byte[] SerializeToBytes(AppTeamChat instance) { }

	// RVA: 0x1E1E370 Offset: 0x1E1C970 VA: 0x181E1E370
	public static void SerializeLengthDelimited(Stream stream, AppTeamChat instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x2091080 Offset: 0x208F680 VA: 0x182091080
	public static void ResetToPool(AppMarker instance) { }

	// RVA: 0x2090DE0 Offset: 0x208F3E0 VA: 0x182090DE0
	public void ResetToPool() { }

	// RVA: 0x2090D20 Offset: 0x208F320 VA: 0x182090D20 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x208F730 Offset: 0x208DD30 VA: 0x18208F730
	public void CopyTo(AppMarker instance) { }

	// RVA: 0x208F940 Offset: 0x208DF40 VA: 0x18208F940
	public AppMarker Copy() { }

	// RVA: 0x2090BA0 Offset: 0x208F1A0 VA: 0x182090BA0
	public static AppMarker Deserialize(Stream stream) { }

	// RVA: 0x208FF50 Offset: 0x208E550 VA: 0x18208FF50
	public static AppMarker DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x208FFD0 Offset: 0x208E5D0 VA: 0x18208FFD0
	public static AppMarker DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20905C0 Offset: 0x208EBC0 VA: 0x1820905C0
	public static AppMarker Deserialize(byte[] buffer) { }

	// RVA: 0x2090DA0 Offset: 0x208F3A0 VA: 0x182090DA0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20921C0 Offset: 0x20907C0 VA: 0x1820921C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20921E0 Offset: 0x20907E0 VA: 0x1820921E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppMarker previous) { }

	// RVA: 0x2090DC0 Offset: 0x208F3C0 VA: 0x182090DC0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2090C20 Offset: 0x208F220 VA: 0x182090C20
	public static AppMarker Deserialize(byte[] buffer, AppMarker instance, bool isDelta = False) { }

	// RVA: 0x20906E0 Offset: 0x208ECE0 VA: 0x1820906E0
	public static AppMarker Deserialize(Stream stream, AppMarker instance, bool isDelta) { }

	// RVA: 0x208F9C0 Offset: 0x208DFC0 VA: 0x18208F9C0
	public static AppMarker DeserializeLengthDelimited(Stream stream, AppMarker instance, bool isDelta) { }

	// RVA: 0x2090060 Offset: 0x208E660 VA: 0x182090060
	public static AppMarker DeserializeLength(Stream stream, int length, AppMarker instance, bool isDelta) { }

	// RVA: 0x2091320 Offset: 0x208F920 VA: 0x182091320
	public static void SerializeDelta(Stream stream, AppMarker instance, AppMarker previous) { }

	// RVA: 0x2091C80 Offset: 0x2090280 VA: 0x182091C80
	public static void Serialize(Stream stream, AppMarker instance) { }

	// RVA: 0x20921B0 Offset: 0x20907B0 VA: 0x1820921B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20921C0 Offset: 0x20907C0 VA: 0x1820921C0
	public void ToProto(Stream stream) { }

	// RVA: 0x2091B70 Offset: 0x2090170 VA: 0x182091B70
	public static byte[] SerializeToBytes(AppMarker instance) { }

	// RVA: 0x2091AC0 Offset: 0x20900C0 VA: 0x182091AC0
	public static void SerializeLengthDelimited(Stream stream, AppMarker instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x2099B50 Offset: 0x2098150 VA: 0x182099B50
	public static void ResetToPool(AppMarker.SellOrder instance) { }

	// RVA: 0x2099A60 Offset: 0x2098060 VA: 0x182099A60
	public void ResetToPool() { }

	// RVA: 0x2099660 Offset: 0x2097C60 VA: 0x182099660 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2097C20 Offset: 0x2096220 VA: 0x182097C20
	public void CopyTo(AppMarker.SellOrder instance) { }

	// RVA: 0x2097C70 Offset: 0x2096270 VA: 0x182097C70
	public AppMarker.SellOrder Copy() { }

	// RVA: 0x2098680 Offset: 0x2096C80 VA: 0x182098680
	public static AppMarker.SellOrder Deserialize(Stream stream) { }

	// RVA: 0x2097D10 Offset: 0x2096310 VA: 0x182097D10
	public static AppMarker.SellOrder DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20985F0 Offset: 0x2096BF0 VA: 0x1820985F0
	public static AppMarker.SellOrder DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20991E0 Offset: 0x20977E0 VA: 0x1820991E0
	public static AppMarker.SellOrder Deserialize(byte[] buffer) { }

	// RVA: 0x20996E0 Offset: 0x2097CE0 VA: 0x1820996E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x209A3A0 Offset: 0x20989A0 VA: 0x18209A3A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x209A3C0 Offset: 0x20989C0 VA: 0x18209A3C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppMarker.SellOrder previous) { }

	// RVA: 0x2099A40 Offset: 0x2098040 VA: 0x182099A40 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2098D80 Offset: 0x2097380 VA: 0x182098D80
	public static AppMarker.SellOrder Deserialize(byte[] buffer, AppMarker.SellOrder instance, bool isDelta = False) { }

	// RVA: 0x2098A20 Offset: 0x2097020 VA: 0x182098A20
	public static AppMarker.SellOrder Deserialize(Stream stream, AppMarker.SellOrder instance, bool isDelta) { }

	// RVA: 0x2097D90 Offset: 0x2096390 VA: 0x182097D90
	public static AppMarker.SellOrder DeserializeLengthDelimited(Stream stream, AppMarker.SellOrder instance, bool isDelta) { }

	// RVA: 0x20981D0 Offset: 0x20967D0 VA: 0x1820981D0
	public static AppMarker.SellOrder DeserializeLength(Stream stream, int length, AppMarker.SellOrder instance, bool isDelta) { }

	// RVA: 0x2099C40 Offset: 0x2098240 VA: 0x182099C40
	public static void SerializeDelta(Stream stream, AppMarker.SellOrder instance, AppMarker.SellOrder previous) { }

	// RVA: 0x209A190 Offset: 0x2098790 VA: 0x18209A190
	public static void Serialize(Stream stream, AppMarker.SellOrder instance) { }

	// RVA: 0x209A390 Offset: 0x2098990 VA: 0x18209A390
	public byte[] ToProtoBytes() { }

	// RVA: 0x209A3A0 Offset: 0x20989A0 VA: 0x18209A3A0
	public void ToProto(Stream stream) { }

	// RVA: 0x209A080 Offset: 0x2098680 VA: 0x18209A080
	public static byte[] SerializeToBytes(AppMarker.SellOrder instance) { }

	// RVA: 0x2099FD0 Offset: 0x20985D0 VA: 0x182099FD0
	public static void SerializeLengthDelimited(Stream stream, AppMarker.SellOrder instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class AppMapMarkers : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6536
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<AppMarker> markers; // 0x18

	// Methods

	// RVA: 0x208C1D0 Offset: 0x208A7D0 VA: 0x18208C1D0
	public static void ResetToPool(AppMapMarkers instance) { }

	// RVA: 0x208C380 Offset: 0x208A980 VA: 0x18208C380
	public void ResetToPool() { }

	// RVA: 0x208BF50 Offset: 0x208A550 VA: 0x18208BF50 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x208B0C0 Offset: 0x20896C0 VA: 0x18208B0C0
	public void CopyTo(AppMapMarkers instance) { }

	// RVA: 0x208B250 Offset: 0x2089850 VA: 0x18208B250
	public AppMapMarkers Copy() { }

	// RVA: 0x208BBE0 Offset: 0x208A1E0 VA: 0x18208BBE0
	public static AppMapMarkers Deserialize(Stream stream) { }

	// RVA: 0x208B710 Offset: 0x2089D10 VA: 0x18208B710
	public static AppMapMarkers DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x208BA30 Offset: 0x208A030 VA: 0x18208BA30
	public static AppMapMarkers DeserializeLength(Stream stream, int length) { }

	// RVA: 0x208BAC0 Offset: 0x208A0C0 VA: 0x18208BAC0
	public static AppMapMarkers Deserialize(byte[] buffer) { }

	// RVA: 0x208C190 Offset: 0x208A790 VA: 0x18208C190
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x208CAC0 Offset: 0x208B0C0 VA: 0x18208CAC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x208CAE0 Offset: 0x208B0E0 VA: 0x18208CAE0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppMapMarkers previous) { }

	// RVA: 0x208C1B0 Offset: 0x208A7B0 VA: 0x18208C1B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x208BC60 Offset: 0x208A260 VA: 0x18208BC60
	public static AppMapMarkers Deserialize(byte[] buffer, AppMapMarkers instance, bool isDelta = False) { }

	// RVA: 0x208BD60 Offset: 0x208A360 VA: 0x18208BD60
	public static AppMapMarkers Deserialize(Stream stream, AppMapMarkers instance, bool isDelta) { }

	// RVA: 0x208B440 Offset: 0x2089A40 VA: 0x18208B440
	public static AppMapMarkers DeserializeLengthDelimited(Stream stream, AppMapMarkers instance, bool isDelta) { }

	// RVA: 0x208B790 Offset: 0x2089D90 VA: 0x18208B790
	public static AppMapMarkers DeserializeLength(Stream stream, int length, AppMapMarkers instance, bool isDelta) { }

	// RVA: 0x208C530 Offset: 0x208AB30 VA: 0x18208C530
	public static void SerializeDelta(Stream stream, AppMapMarkers instance, AppMapMarkers previous) { }

	// RVA: 0x208C8D0 Offset: 0x208AED0 VA: 0x18208C8D0
	public static void Serialize(Stream stream, AppMapMarkers instance) { }

	// RVA: 0x208CAB0 Offset: 0x208B0B0 VA: 0x18208CAB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x208CAC0 Offset: 0x208B0C0 VA: 0x18208CAC0
	public void ToProto(Stream stream) { }

	// RVA: 0x208C7C0 Offset: 0x208ADC0 VA: 0x18208C7C0
	public static byte[] SerializeToBytes(AppMapMarkers instance) { }

	// RVA: 0x208C710 Offset: 0x208AD10 VA: 0x18208C710
	public static void SerializeLengthDelimited(Stream stream, AppMapMarkers instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class AppTeamChanged : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6537
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong playerId; // 0x18
	public AppTeamInfo teamInfo; // 0x20

	// Methods

	// RVA: 0x1E1CAB0 Offset: 0x1E1B0B0 VA: 0x181E1CAB0
	public static void ResetToPool(AppTeamChanged instance) { }

	// RVA: 0x1E1CA00 Offset: 0x1E1B000 VA: 0x181E1CA00
	public void ResetToPool() { }

	// RVA: 0x1E1C890 Offset: 0x1E1AE90 VA: 0x181E1C890 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E1BC20 Offset: 0x1E1A220 VA: 0x181E1BC20
	public void CopyTo(AppTeamChanged instance) { }

	// RVA: 0x1E1BCA0 Offset: 0x1E1A2A0 VA: 0x181E1BCA0
	public AppTeamChanged Copy() { }

	// RVA: 0x1E1C3F0 Offset: 0x1E1A9F0 VA: 0x181E1C3F0
	public static AppTeamChanged Deserialize(Stream stream) { }

	// RVA: 0x1E1BD70 Offset: 0x1E1A370 VA: 0x181E1BD70
	public static AppTeamChanged DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E1C0C0 Offset: 0x1E1A6C0 VA: 0x181E1C0C0
	public static AppTeamChanged DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E1C670 Offset: 0x1E1AC70 VA: 0x181E1C670
	public static AppTeamChanged Deserialize(byte[] buffer) { }

	// RVA: 0x1E1C9C0 Offset: 0x1E1AFC0 VA: 0x181E1C9C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E1D180 Offset: 0x1E1B780 VA: 0x181E1D180 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E1D1A0 Offset: 0x1E1B7A0 VA: 0x181E1D1A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppTeamChanged previous) { }

	// RVA: 0x1E1C9E0 Offset: 0x1E1AFE0 VA: 0x181E1C9E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E1C790 Offset: 0x1E1AD90 VA: 0x181E1C790
	public static AppTeamChanged Deserialize(byte[] buffer, AppTeamChanged instance, bool isDelta = False) { }

	// RVA: 0x1E1C470 Offset: 0x1E1AA70 VA: 0x181E1C470
	public static AppTeamChanged Deserialize(Stream stream, AppTeamChanged instance, bool isDelta) { }

	// RVA: 0x1E1BDF0 Offset: 0x1E1A3F0 VA: 0x181E1BDF0
	public static AppTeamChanged DeserializeLengthDelimited(Stream stream, AppTeamChanged instance, bool isDelta) { }

	// RVA: 0x1E1C150 Offset: 0x1E1A750 VA: 0x181E1C150
	public static AppTeamChanged DeserializeLength(Stream stream, int length, AppTeamChanged instance, bool isDelta) { }

	// RVA: 0x1E1CB60 Offset: 0x1E1B160 VA: 0x181E1CB60
	public static void SerializeDelta(Stream stream, AppTeamChanged instance, AppTeamChanged previous) { }

	// RVA: 0x1E1CF60 Offset: 0x1E1B560 VA: 0x181E1CF60
	public static void Serialize(Stream stream, AppTeamChanged instance) { }

	// RVA: 0x1E1D170 Offset: 0x1E1B770 VA: 0x181E1D170
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E1D180 Offset: 0x1E1B780 VA: 0x181E1D180
	public void ToProto(Stream stream) { }

	// RVA: 0x1E1CE50 Offset: 0x1E1B450 VA: 0x181E1CE50
	public static byte[] SerializeToBytes(AppTeamChanged instance) { }

	// RVA: 0x1E1CDA0 Offset: 0x1E1B3A0 VA: 0x181E1CDA0
	public static void SerializeLengthDelimited(Stream stream, AppTeamChanged instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class AppTeamMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6538
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public AppChatMessage message; // 0x18

	// Methods

	// RVA: 0x1E21E30 Offset: 0x1E20430 VA: 0x181E21E30
	public static void ResetToPool(AppTeamMessage instance) { }

	// RVA: 0x1E21D90 Offset: 0x1E20390 VA: 0x181E21D90
	public void ResetToPool() { }

	// RVA: 0x1E21C30 Offset: 0x1E20230 VA: 0x181E21C30 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E21190 Offset: 0x1E1F790 VA: 0x181E21190
	public void CopyTo(AppTeamMessage instance) { }

	// RVA: 0x1E21200 Offset: 0x1E1F800 VA: 0x181E21200
	public AppTeamMessage Copy() { }

	// RVA: 0x1E21BB0 Offset: 0x1E201B0 VA: 0x181E21BB0
	public static AppTeamMessage Deserialize(Stream stream) { }

	// RVA: 0x1E212D0 Offset: 0x1E1F8D0 VA: 0x181E212D0
	public static AppTeamMessage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E217A0 Offset: 0x1E1FDA0 VA: 0x181E217A0
	public static AppTeamMessage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E21930 Offset: 0x1E1FF30 VA: 0x181E21930
	public static AppTeamMessage Deserialize(byte[] buffer) { }

	// RVA: 0x1E21D50 Offset: 0x1E20350 VA: 0x181E21D50
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E22440 Offset: 0x1E20A40 VA: 0x181E22440 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E22460 Offset: 0x1E20A60 VA: 0x181E22460 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppTeamMessage previous) { }

	// RVA: 0x1E21D70 Offset: 0x1E20370 VA: 0x181E21D70 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E21830 Offset: 0x1E1FE30 VA: 0x181E21830
	public static AppTeamMessage Deserialize(byte[] buffer, AppTeamMessage instance, bool isDelta = False) { }

	// RVA: 0x1E21A50 Offset: 0x1E20050 VA: 0x181E21A50
	public static AppTeamMessage Deserialize(Stream stream, AppTeamMessage instance, bool isDelta) { }

	// RVA: 0x1E21350 Offset: 0x1E1F950 VA: 0x181E21350
	public static AppTeamMessage DeserializeLengthDelimited(Stream stream, AppTeamMessage instance, bool isDelta) { }

	// RVA: 0x1E21590 Offset: 0x1E1FB90 VA: 0x181E21590
	public static AppTeamMessage DeserializeLength(Stream stream, int length, AppTeamMessage instance, bool isDelta) { }

	// RVA: 0x1E21ED0 Offset: 0x1E204D0 VA: 0x181E21ED0
	public static void SerializeDelta(Stream stream, AppTeamMessage instance, AppTeamMessage previous) { }

	// RVA: 0x1E22270 Offset: 0x1E20870 VA: 0x181E22270
	public static void Serialize(Stream stream, AppTeamMessage instance) { }

	// RVA: 0x1E22430 Offset: 0x1E20A30 VA: 0x181E22430
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E22440 Offset: 0x1E20A40 VA: 0x181E22440
	public void ToProto(Stream stream) { }

	// RVA: 0x1E22160 Offset: 0x1E20760 VA: 0x181E22160
	public static byte[] SerializeToBytes(AppTeamMessage instance) { }

	// RVA: 0x1E220B0 Offset: 0x1E206B0 VA: 0x181E220B0
	public static void SerializeLengthDelimited(Stream stream, AppTeamMessage instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class AppEntityChanged : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6539
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint entityId; // 0x14
	public AppEntityPayload payload; // 0x18

	// Methods

	// RVA: 0x20822D0 Offset: 0x20808D0 VA: 0x1820822D0
	public static void ResetToPool(AppEntityChanged instance) { }

	// RVA: 0x2082220 Offset: 0x2080820 VA: 0x182082220
	public void ResetToPool() { }

	// RVA: 0x20820B0 Offset: 0x20806B0 VA: 0x1820820B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2081440 Offset: 0x207FA40 VA: 0x182081440
	public void CopyTo(AppEntityChanged instance) { }

	// RVA: 0x20814C0 Offset: 0x207FAC0 VA: 0x1820814C0
	public AppEntityChanged Copy() { }

	// RVA: 0x2081D10 Offset: 0x2080310 VA: 0x182081D10
	public static AppEntityChanged Deserialize(Stream stream) { }

	// RVA: 0x2081860 Offset: 0x207FE60 VA: 0x182081860
	public static AppEntityChanged DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2081B80 Offset: 0x2080180 VA: 0x182081B80
	public static AppEntityChanged DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2081F90 Offset: 0x2080590 VA: 0x182081F90
	public static AppEntityChanged Deserialize(byte[] buffer) { }

	// RVA: 0x20821E0 Offset: 0x20807E0 VA: 0x1820821E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2082990 Offset: 0x2080F90 VA: 0x182082990 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20829B0 Offset: 0x2080FB0 VA: 0x1820829B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppEntityChanged previous) { }

	// RVA: 0x2082200 Offset: 0x2080800 VA: 0x182082200 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2081C10 Offset: 0x2080210 VA: 0x182081C10
	public static AppEntityChanged Deserialize(byte[] buffer, AppEntityChanged instance, bool isDelta = False) { }

	// RVA: 0x2081D90 Offset: 0x2080390 VA: 0x182081D90
	public static AppEntityChanged Deserialize(Stream stream, AppEntityChanged instance, bool isDelta) { }

	// RVA: 0x2081590 Offset: 0x207FB90 VA: 0x182081590
	public static AppEntityChanged DeserializeLengthDelimited(Stream stream, AppEntityChanged instance, bool isDelta) { }

	// RVA: 0x20818E0 Offset: 0x207FEE0 VA: 0x1820818E0
	public static AppEntityChanged DeserializeLength(Stream stream, int length, AppEntityChanged instance, bool isDelta) { }

	// RVA: 0x2082380 Offset: 0x2080980 VA: 0x182082380
	public static void SerializeDelta(Stream stream, AppEntityChanged instance, AppEntityChanged previous) { }

	// RVA: 0x2082770 Offset: 0x2080D70 VA: 0x182082770
	public static void Serialize(Stream stream, AppEntityChanged instance) { }

	// RVA: 0x2082980 Offset: 0x2080F80 VA: 0x182082980
	public byte[] ToProtoBytes() { }

	// RVA: 0x2082990 Offset: 0x2080F90 VA: 0x182082990
	public void ToProto(Stream stream) { }

	// RVA: 0x2082660 Offset: 0x2080C60 VA: 0x182082660
	public static byte[] SerializeToBytes(AppEntityChanged instance) { }

	// RVA: 0x20825B0 Offset: 0x2080BB0 VA: 0x1820825B0
	public static void SerializeLengthDelimited(Stream stream, AppEntityChanged instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x1B9E0A0 Offset: 0x1B9C6A0 VA: 0x181B9E0A0
	public static void Quit() { }

	// RVA: 0x1B9E110 Offset: 0x1B9C710 VA: 0x181B9E110
	public static string get_installPath() { }

	// RVA: 0x1B9E100 Offset: 0x1B9C700 VA: 0x181B9E100
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
	private static Dictionary<ulong, ApprovedSkinInfo> _all; // 0x2B10368

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
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public ulong get_InventoryId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C16A0 Offset: 0x8BFCA0 VA: 0x1808C16A0
	private void set_InventoryId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Desc() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	private void set_Desc(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	private void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public ulong get_WorkshopdId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE73A30 Offset: 0xE72030 VA: 0x180E73A30
	private void set_WorkshopdId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA39490 Offset: 0xA37A90 VA: 0x180A39490
	internal Price get_Price() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA39A50 Offset: 0xA38050 VA: 0x180A39A50
	private void set_Price(Price value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xBA2210 Offset: 0xBA0810 VA: 0x180BA2210
	public bool get_Tradable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE73A20 Offset: 0xE72020 VA: 0x180E73A20
	private void set_Tradable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6BB9E0 Offset: 0x6B9FE0 VA: 0x1806BB9E0
	public DropChance get_DropChance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC75070 Offset: 0xC73670 VA: 0x180C75070
	private void set_DropChance(DropChance value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC66170 Offset: 0xC64770 VA: 0x180C66170
	public bool get_Marketable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE73A10 Offset: 0xE72010 VA: 0x180E73A10
	private void set_Marketable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public Skinnable get_Skinnable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0
	private void set_Skinnable(Skinnable value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC370 Offset: 0x4BA970 VA: 0x1804BC370
	public bool get_AllowInCrates() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC570 Offset: 0x4BAB70 VA: 0x1804BC570
	private void set_AllowInCrates(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xBA2230 Offset: 0xBA0830 VA: 0x180BA2230
	public bool get_IsLimitedTimeOffer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x82DE50 Offset: 0x82C450 VA: 0x18082DE50
	private void set_IsLimitedTimeOffer(bool value) { }

	// RVA: 0xE72FB0 Offset: 0xE715B0 VA: 0x180E72FB0
	public void .ctor(ulong WorkshopdId, string Name, string Desc, string ItemName) { }

	// RVA: 0xE72F80 Offset: 0xE71580 VA: 0x180E72F80
	public ApprovedSkinInfo Store(Price Price, bool CanBeTraded, bool CanBeSold) { }

	// RVA: 0xE72F90 Offset: 0xE71590 VA: 0x180E72F90
	public ApprovedSkinInfo TimeLimited() { }

	// RVA: 0xE72FA0 Offset: 0xE715A0 VA: 0x180E72FA0
	public ApprovedSkinInfo Unlimited() { }

	// RVA: 0xE72F70 Offset: 0xE71570 VA: 0x180E72F70
	public ApprovedSkinInfo NoCrate() { }

	// RVA: 0xE72F50 Offset: 0xE71550 VA: 0x180E72F50
	public ApprovedSkinInfo Drops(DropChance DropChance) { }

	// RVA: 0xE72F60 Offset: 0xE71560 VA: 0x180E72F60
	public ApprovedSkinInfo ItemId(ulong InventoryId) { }

	// RVA: 0xE73160 Offset: 0xE71760 VA: 0x180E73160
	public static ItemSchema.Item op_Implicit(ApprovedSkinInfo o) { }

}

private sealed class ApprovedSkinInfo.<>c__DisplayClass44_0 // TypeDefIndex: 7739
{	// Fields
	public string ItemName; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xE81590 Offset: 0xE7FB90 VA: 0x180E81590
	internal bool <.ctor>b__0(Skinnable x) { }

}

public abstract class AppIOEntity : IOEntity // TypeDefIndex: 8306
{	// Fields
	private Option __menuOption_Menu_Pair; // 0x288

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x82B3D0 Offset: 0x8299D0 VA: 0x18082B3D0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x82B920 Offset: 0x829F20 VA: 0x18082B920 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x82B7D0 Offset: 0x829DD0 VA: 0x18082B7D0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0xB0520 Offset: 0xAF920 VA: 0x1800B0520
	[BaseEntity.Menu.Description] // RVA: 0xB0520 Offset: 0xAF920 VA: 0x1800B0520
	[BaseEntity.Menu.Icon] // RVA: 0xB0520 Offset: 0xAF920 VA: 0x1800B0520
	[BaseEntity.Menu.ShowIf] // RVA: 0xB0520 Offset: 0xAF920 VA: 0x1800B0520
	// RVA: 0x82B730 Offset: 0x829D30 VA: 0x18082B730
	public void Menu_Pair(BasePlayer player) { }

	// RVA: 0x82B770 Offset: 0x829D70 VA: 0x18082B770
	public bool Menu_ShowIf(BasePlayer player) { }

	// RVA: 0x82B8C0 Offset: 0x829EC0 VA: 0x18082B8C0
	protected void .ctor() { }

}

public class ApplyTerrainAnchors : MonoBehaviour // TypeDefIndex: 10373
{	// Methods

	// RVA: 0x82BA30 Offset: 0x82A030 VA: 0x18082BA30
	protected void Awake() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ApplyTerrainModifiers : MonoBehaviour // TypeDefIndex: 10574
{	// Methods

	// RVA: 0x82BB30 Offset: 0x82A130 VA: 0x18082BB30
	protected void Awake() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ApplyTweakUIChanges : MonoBehaviour // TypeDefIndex: 11135
{	// Fields
	public Button ApplyButton; // 0x18
	public TweakUIBase[] Options; // 0x20

	// Methods

	// RVA: 0x82BD10 Offset: 0x82A310 VA: 0x18082BD10
	private void OnEnable() { }

	// RVA: 0x82BC30 Offset: 0x82A230 VA: 0x18082BC30
	public void Apply() { }

	// RVA: 0x82BDA0 Offset: 0x82A3A0 VA: 0x18082BDA0
	public void SetDirty() { }

	// RVA: 0x82BD20 Offset: 0x82A320 VA: 0x18082BD20
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

	// RVA: 0x6CAEC0 Offset: 0x6C94C0 VA: 0x1806CAEC0
	public void .ctor() { }

	// RVA: 0x6CADC0 Offset: 0x6C93C0 VA: 0x1806CADC0
	private static void .cctor() { }

}

