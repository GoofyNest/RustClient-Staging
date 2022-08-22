internal static class AppContextSwitches // TypeDefIndex: 142
{	// Fields
	public static readonly bool ThrowExceptionIfDisposedCancellationTokenSource; // 0x0
	public static readonly bool SetActorAsReferenceWhenCopyingClaimsIdentity; // 0x1
	public static readonly bool NoAsyncCurrentCulture; // 0x2
	public static readonly bool PreserveEventListnerObjectIdentity; // 0x3

}

public class AppDomainUnloadedException : SystemException // TypeDefIndex: 164
{	// Methods

	// RVA: 0x1551DB0 Offset: 0x15503B0 VA: 0x181551DB0
	public void .ctor() { }

	// RVA: 0xFDD150 Offset: 0xFDB750 VA: 0x180FDD150
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

public class ApplicationException : Exception // TypeDefIndex: 165
{	// Methods

	// RVA: 0x15538C0 Offset: 0x1551EC0 VA: 0x1815538C0
	public void .ctor() { }

	// RVA: 0x1553940 Offset: 0x1551F40 VA: 0x181553940
	public void .ctor(string message) { }

	// RVA: 0x1553830 Offset: 0x1551E30 VA: 0x181553830
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x15539C0 Offset: 0x1551FC0 VA: 0x1815539C0
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

	// RVA: 0x1553610 Offset: 0x1551C10 VA: 0x181553610
	private AppDomainSetup getSetup() { }

	// RVA: 0x1553610 Offset: 0x1551C10 VA: 0x181553610
	internal AppDomainSetup get_SetupInformationNoCopy() { }

	// RVA: 0x1553620 Offset: 0x1551C20 VA: 0x181553620 Slot: 6
	public string get_BaseDirectory() { }

	// RVA: 0x1553400 Offset: 0x1551A00 VA: 0x181553400
	private string getFriendlyName() { }

	// RVA: 0x1553400 Offset: 0x1551A00 VA: 0x181553400 Slot: 7
	public string get_FriendlyName() { }

	// RVA: 0x15535F0 Offset: 0x1551BF0 VA: 0x1815535F0
	private static AppDomain getCurDomain() { }

	// RVA: 0x15535F0 Offset: 0x1551BF0 VA: 0x1815535F0
	public static AppDomain get_CurrentDomain() { }

	// RVA: 0x15525D0 Offset: 0x1550BD0 VA: 0x1815525D0
	private Assembly[] GetAssemblies(bool refOnly) { }

	// RVA: 0x15525E0 Offset: 0x1550BE0 VA: 0x1815525E0 Slot: 8
	public Assembly[] GetAssemblies() { }

	// RVA: 0x1552600 Offset: 0x1550C00 VA: 0x181552600 Slot: 9
	public object GetData(string name) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 5
	public override object InitializeLifetimeService() { }

	// RVA: 0x15529F0 Offset: 0x1550FF0 VA: 0x1815529F0
	internal Assembly LoadAssembly(string assemblyRef, Evidence securityEvidence, bool refOnly) { }

	// RVA: 0x1552B00 Offset: 0x1551100 VA: 0x181552B00 Slot: 10
	public Assembly Load(AssemblyName assemblyRef) { }

	// RVA: 0x1552A00 Offset: 0x1551000 VA: 0x181552A00
	internal Assembly LoadSatellite(AssemblyName assemblyRef, bool throwOnError) { }

	[ObsoleteAttribute] // RVA: 0x8C760 Offset: 0x8BB60 VA: 0x18008C760
	// RVA: 0x1552B10 Offset: 0x1551110 VA: 0x181552B10 Slot: 11
	public Assembly Load(AssemblyName assemblyRef, Evidence assemblySecurity) { }

	// RVA: 0x15530B0 Offset: 0x15516B0 VA: 0x1815530B0 Slot: 12
	public Assembly Load(string assemblyString) { }

	// RVA: 0x15531B0 Offset: 0x15517B0 VA: 0x1815531B0
	internal Assembly Load(string assemblyString, Evidence assemblySecurity, bool refonly) { }

	// RVA: 0x15527D0 Offset: 0x1550DD0 VA: 0x1815527D0
	private static AppDomain InternalSetDomainByID(int domain_id) { }

	// RVA: 0x15527E0 Offset: 0x1550DE0 VA: 0x1815527E0
	private static AppDomain InternalSetDomain(AppDomain context) { }

	// RVA: 0x15527B0 Offset: 0x1550DB0 VA: 0x1815527B0
	internal static void InternalPushDomainRefByID(int domain_id) { }

	// RVA: 0x15527A0 Offset: 0x1550DA0 VA: 0x1815527A0
	internal static void InternalPopDomainRef() { }

	// RVA: 0x15527C0 Offset: 0x1550DC0 VA: 0x1815527C0
	internal static Context InternalSetContext(Context context) { }

	// RVA: 0x1552780 Offset: 0x1550D80 VA: 0x181552780
	internal static Context InternalGetContext() { }

	// RVA: 0x1552780 Offset: 0x1550D80 VA: 0x181552780
	internal static Context InternalGetDefaultContext() { }

	// RVA: 0x1552790 Offset: 0x1550D90 VA: 0x181552790
	internal static string InternalGetProcessGuid(string newguid) { }

	// RVA: 0x15527F0 Offset: 0x1550DF0 VA: 0x1815527F0
	internal static object InvokeInDomainByID(int domain_id, MethodInfo method, object obj, object[] args) { }

	// RVA: 0x15526D0 Offset: 0x1550CD0 VA: 0x1815526D0
	internal static string GetProcessGuid() { }

	// RVA: 0xD69700 Offset: 0xD67D00 VA: 0x180D69700
	private static bool InternalIsFinalizingForUnload(int domain_id) { }

	// RVA: 0x15529D0 Offset: 0x1550FD0 VA: 0x1815529D0
	public bool IsFinalizingForUnload() { }

	// RVA: 0x1553600 Offset: 0x1551C00 VA: 0x181553600
	private int getDomainID() { }

	[ObsoleteAttribute] // RVA: 0x8C8D0 Offset: 0x8BCD0 VA: 0x18008C8D0
	// RVA: 0x15525F0 Offset: 0x1550BF0 VA: 0x1815525F0
	public static int GetCurrentThreadId() { }

	// RVA: 0x1553400 Offset: 0x1551A00 VA: 0x181553400 Slot: 3
	public override string ToString() { }

	// RVA: 0x1551E10 Offset: 0x1550410 VA: 0x181551E10
	private void DoAssemblyLoad(Assembly assembly) { }

	// RVA: 0x1551EE0 Offset: 0x15504E0 VA: 0x181551EE0
	private Assembly DoAssemblyResolve(string name, Assembly requestingAssembly, bool refonly) { }

	// RVA: 0x1552320 Offset: 0x1550920 VA: 0x181552320
	internal Assembly DoTypeResolve(object name_or_tb) { }

	// RVA: 0x15521F0 Offset: 0x15507F0 VA: 0x1815521F0
	internal Assembly DoResourceResolve(string name, Assembly requesting) { }

	// RVA: 0x15521D0 Offset: 0x15507D0 VA: 0x1815521D0
	private void DoDomainUnload() { }

	// RVA: 0x1552610 Offset: 0x1550C10 VA: 0x181552610
	internal byte[] GetMarshalledDomainObjRef() { }

	// RVA: 0x15532D0 Offset: 0x15518D0 VA: 0x1815532D0
	internal void ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg, out byte[] arrResponse, out CADMethodReturnMessage cadMrm) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1553410 Offset: 0x1551A10 VA: 0x181553410 Slot: 13
	public void add_DomainUnload(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1553650 Offset: 0x1551C50 VA: 0x181553650 Slot: 14
	public void remove_DomainUnload(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x15534B0 Offset: 0x1551AB0 VA: 0x1815534B0 Slot: 15
	public void add_ProcessExit(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x15536F0 Offset: 0x1551CF0 VA: 0x1815536F0 Slot: 16
	public void remove_ProcessExit(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1553550 Offset: 0x1551B50 VA: 0x181553550 Slot: 17
	public void add_UnhandledException(UnhandledExceptionEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1553790 Offset: 0x1551D90 VA: 0x181553790 Slot: 18
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

	// RVA: 0x1551A50 Offset: 0x1550050 VA: 0x181551A50
	private static string GetAppBase(string appBase) { }

	// RVA: 0x1551DA0 Offset: 0x15503A0 VA: 0x181551DA0 Slot: 4
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

	// RVA: 0xFDB610 Offset: 0xFD9C10 VA: 0x180FDB610 Slot: 5
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
	// RVA: 0x181D230 Offset: 0x181B830 VA: 0x18181D230
	public static void Quit(int exitCode) { }

	// RVA: 0x181D270 Offset: 0x181B870 VA: 0x18181D270
	public static void Quit() { }

	[FreeFunctionAttribute] // RVA: 0x70F10 Offset: 0x70310 VA: 0x180070F10
	// RVA: 0x181CEE0 Offset: 0x181B4E0 VA: 0x18181CEE0
	public static bool CanStreamedLevelBeLoaded(string levelName) { }

	[FreeFunctionAttribute] // RVA: 0x710A0 Offset: 0x704A0 VA: 0x1800710A0
	// RVA: 0x181D4F0 Offset: 0x181BAF0 VA: 0x18181D4F0
	public static bool get_isPlaying() { }

	[FreeFunctionAttribute] // RVA: 0x711D0 Offset: 0x705D0 VA: 0x1800711D0
	// RVA: 0x181D430 Offset: 0x181BA30 VA: 0x18181D430
	public static string get_dataPath() { }

	[FreeFunctionAttribute] // RVA: 0x71310 Offset: 0x70710 VA: 0x180071310
	// RVA: 0x181D5A0 Offset: 0x181BBA0 VA: 0x18181D5A0
	public static string get_streamingAssetsPath() { }

	[FreeFunctionAttribute] // RVA: 0x713D0 Offset: 0x707D0 VA: 0x1800713D0
	// RVA: 0x181D540 Offset: 0x181BB40 VA: 0x18181D540
	public static string get_persistentDataPath() { }

	[FreeFunctionAttribute] // RVA: 0x714E0 Offset: 0x708E0 VA: 0x1800714E0
	// RVA: 0x181D630 Offset: 0x181BC30 VA: 0x18181D630
	public static string get_unityVersion() { }

	[FreeFunctionAttribute] // RVA: 0x71720 Offset: 0x70B20 VA: 0x180071720
	// RVA: 0x181D660 Offset: 0x181BC60 VA: 0x18181D660
	public static string get_version() { }

	[FreeFunctionAttribute] // RVA: 0x717E0 Offset: 0x70BE0 VA: 0x1800717E0
	// RVA: 0x181D3D0 Offset: 0x181B9D0 VA: 0x18181D3D0
	public static string get_companyName() { }

	[FreeFunctionAttribute] // RVA: 0x71920 Offset: 0x70D20 VA: 0x180071920
	// RVA: 0x181D1F0 Offset: 0x181B7F0 VA: 0x18181D1F0
	public static void OpenURL(string url) { }

	[FreeFunctionAttribute] // RVA: 0x71A60 Offset: 0x70E60 VA: 0x180071A60
	// RVA: 0x181D600 Offset: 0x181BC00 VA: 0x18181D600
	public static int get_targetFrameRate() { }

	[FreeFunctionAttribute] // RVA: 0x71B40 Offset: 0x70F40 VA: 0x180071B40
	// RVA: 0x181D760 Offset: 0x181BD60 VA: 0x18181D760
	public static void set_targetFrameRate(int value) { }

	[FreeFunctionAttribute] // RVA: 0x71CD0 Offset: 0x710D0 VA: 0x180071CD0
	// RVA: 0x181D2A0 Offset: 0x181B8A0 VA: 0x18181D2A0
	private static void SetLogCallbackDefined(bool defined) { }

	[FreeFunctionAttribute] // RVA: 0x71E10 Offset: 0x71210 VA: 0x180071E10
	// RVA: 0x181CF20 Offset: 0x181B520 VA: 0x18181CF20
	public static StackTraceLogType GetStackTraceLogType(LogType logType) { }

	[FreeFunctionAttribute] // RVA: 0x71ED0 Offset: 0x712D0 VA: 0x180071ED0
	// RVA: 0x181D2E0 Offset: 0x181B8E0 VA: 0x18181D2E0
	public static void SetStackTraceLogType(LogType logType, StackTraceLogType stackTraceType) { }

	[FreeFunctionAttribute] // RVA: 0x72180 Offset: 0x71580 VA: 0x180072180
	// RVA: 0x181D400 Offset: 0x181BA00 VA: 0x18181D400
	public static string get_consoleLogPath() { }

	[FreeFunctionAttribute] // RVA: 0x722D0 Offset: 0x716D0 VA: 0x1800722D0
	// RVA: 0x181D720 Offset: 0x181BD20 VA: 0x18181D720
	public static void set_backgroundLoadingPriority(ThreadPriority value) { }

	[FreeFunctionAttribute] // RVA: 0x72460 Offset: 0x71860 VA: 0x180072460
	// RVA: 0x181D570 Offset: 0x181BB70 VA: 0x18181D570
	public static RuntimePlatform get_platform() { }

	// RVA: 0x181D490 Offset: 0x181BA90 VA: 0x18181D490
	public static bool get_isMobilePlatform() { }

	[FreeFunctionAttribute] // RVA: 0x72530 Offset: 0x71930 VA: 0x180072530
	// RVA: 0x181D5D0 Offset: 0x181BBD0 VA: 0x18181D5D0
	public static SystemLanguage get_systemLanguage() { }

	[FreeFunctionAttribute] // RVA: 0x73A40 Offset: 0x72E40 VA: 0x180073A40
	// RVA: 0x181D460 Offset: 0x181BA60 VA: 0x18181D460
	public static NetworkReachability get_internetReachability() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x181CD00 Offset: 0x181B300 VA: 0x18181CD00
	internal static void CallLowMemory() { }

	// RVA: 0x181D320 Offset: 0x181B920 VA: 0x18181D320
	public static void add_logMessageReceived(Application.LogCallback value) { }

	// RVA: 0x181D690 Offset: 0x181BC90 VA: 0x18181D690
	public static void remove_logMessageReceived(Application.LogCallback value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x181CC40 Offset: 0x181B240 VA: 0x18181CC40
	private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x181CFB0 Offset: 0x181B5B0 VA: 0x18181CFB0
	private static bool Internal_ApplicationWantsToQuit() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x181CF60 Offset: 0x181B560 VA: 0x18181CF60
	private static void Internal_ApplicationQuit() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x181D1A0 Offset: 0x181B7A0 VA: 0x18181D1A0
	internal static void InvokeOnBeforeRender() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x181D140 Offset: 0x181B740 VA: 0x18181D140
	internal static void InvokeFocusChanged(bool focus) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x181D0E0 Offset: 0x181B6E0 VA: 0x18181D0E0
	internal static void InvokeDeepLinkActivated(string url) { }

	// RVA: 0x181D520 Offset: 0x181BB20 VA: 0x18181D520
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

	// RVA: 0x13104B0 Offset: 0x130EAB0 VA: 0x1813104B0 Slot: 12
	public virtual void Invoke(string condition, string stackTrace, LogType type) { }

	// RVA: 0x1831C50 Offset: 0x1830250 VA: 0x181831C50 Slot: 13
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

	// RVA: 0x136ADD0 Offset: 0x13693D0 VA: 0x18136ADD0
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

	// RVA: 0x136AD30 Offset: 0x1369330 VA: 0x18136AD30
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

	// RVA: 0x14A9690 Offset: 0x14A7C90 VA: 0x1814A9690
	public static MonoBehaviour get_Controller() { }

	// RVA: 0x14A9380 Offset: 0x14A7980 VA: 0x1814A9380
	public static void Initialize(BaseIntegration integration) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14A9790 Offset: 0x14A7D90 VA: 0x1814A9790
	public static BaseIntegration get_Integration() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14A97D0 Offset: 0x14A7DD0 VA: 0x1814A97D0
	public static void set_Integration(BaseIntegration value) { }

}

internal class ApplicationControllerMonobehaviour : MonoBehaviour // TypeDefIndex: 6217
{	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void OnApplicationQuit() { }

	// RVA: 0x14A91E0 Offset: 0x14A77E0 VA: 0x1814A91E0
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

	// RVA: 0x1E25090 Offset: 0x1E23690 VA: 0x181E25090
	public static void ResetToPool(Approval instance) { }

	// RVA: 0x1E24ED0 Offset: 0x1E234D0 VA: 0x181E24ED0
	public void ResetToPool() { }

	// RVA: 0x1E24C60 Offset: 0x1E23260 VA: 0x181E24C60 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E237C0 Offset: 0x1E21DC0 VA: 0x181E237C0
	public void CopyTo(Approval instance) { }

	// RVA: 0x1E23870 Offset: 0x1E21E70 VA: 0x181E23870
	public Approval Copy() { }

	// RVA: 0x1E24630 Offset: 0x1E22C30 VA: 0x181E24630
	public static Approval Deserialize(Stream stream) { }

	// RVA: 0x1E23960 Offset: 0x1E21F60 VA: 0x181E23960
	public static Approval DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E23F50 Offset: 0x1E22550 VA: 0x181E23F50
	public static Approval DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E24B40 Offset: 0x1E23140 VA: 0x181E24B40
	public static Approval Deserialize(byte[] buffer) { }

	// RVA: 0x1E24E90 Offset: 0x1E23490 VA: 0x181E24E90
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E25D00 Offset: 0x1E24300 VA: 0x181E25D00 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E25D20 Offset: 0x1E24320 VA: 0x181E25D20 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Approval previous) { }

	// RVA: 0x1E24EB0 Offset: 0x1E234B0 VA: 0x181E24EB0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E24530 Offset: 0x1E22B30 VA: 0x181E24530
	public static Approval Deserialize(byte[] buffer, Approval instance, bool isDelta = False) { }

	// RVA: 0x1E246B0 Offset: 0x1E22CB0 VA: 0x181E246B0
	public static Approval Deserialize(Stream stream, Approval instance, bool isDelta) { }

	// RVA: 0x1E239E0 Offset: 0x1E21FE0 VA: 0x181E239E0
	public static Approval DeserializeLengthDelimited(Stream stream, Approval instance, bool isDelta) { }

	// RVA: 0x1E23FE0 Offset: 0x1E225E0 VA: 0x181E23FE0
	public static Approval DeserializeLength(Stream stream, int length, Approval instance, bool isDelta) { }

	// RVA: 0x1E25250 Offset: 0x1E23850 VA: 0x181E25250
	public static void SerializeDelta(Stream stream, Approval instance, Approval previous) { }

	// RVA: 0x1E25920 Offset: 0x1E23F20 VA: 0x181E25920
	public static void Serialize(Stream stream, Approval instance) { }

	// RVA: 0x1E25CF0 Offset: 0x1E242F0 VA: 0x181E25CF0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E25D00 Offset: 0x1E24300 VA: 0x181E25D00
	public void ToProto(Stream stream) { }

	// RVA: 0x1E25810 Offset: 0x1E23E10 VA: 0x181E25810
	public static byte[] SerializeToBytes(Approval instance) { }

	// RVA: 0x1E25760 Offset: 0x1E23D60 VA: 0x181E25760
	public static void SerializeLengthDelimited(Stream stream, Approval instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x1E12F40 Offset: 0x1E11540 VA: 0x181E12F40
	public static void ResetToPool(AppRequest instance) { }

	// RVA: 0x1E12BF0 Offset: 0x1E111F0 VA: 0x181E12BF0
	public void ResetToPool() { }

	// RVA: 0x1E12B30 Offset: 0x1E11130 VA: 0x181E12B30 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E11070 Offset: 0x1E0F670 VA: 0x181E11070
	public void CopyTo(AppRequest instance) { }

	// RVA: 0x1E11440 Offset: 0x1E0FA40 VA: 0x181E11440
	public AppRequest Copy() { }

	// RVA: 0x1E12890 Offset: 0x1E10E90 VA: 0x181E12890
	public static AppRequest Deserialize(Stream stream) { }

	// RVA: 0x1E11B50 Offset: 0x1E10150 VA: 0x181E11B50
	public static AppRequest DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E12240 Offset: 0x1E10840 VA: 0x181E12240
	public static AppRequest DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E12A10 Offset: 0x1E11010 VA: 0x181E12A10
	public static AppRequest Deserialize(byte[] buffer) { }

	// RVA: 0x1E12BB0 Offset: 0x1E111B0 VA: 0x181E12BB0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E14EF0 Offset: 0x1E134F0 VA: 0x181E14EF0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E14F10 Offset: 0x1E13510 VA: 0x181E14F10 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppRequest previous) { }

	// RVA: 0x1E12BD0 Offset: 0x1E111D0 VA: 0x181E12BD0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E12910 Offset: 0x1E10F10 VA: 0x181E12910
	public static AppRequest Deserialize(byte[] buffer, AppRequest instance, bool isDelta = False) { }

	// RVA: 0x1E122D0 Offset: 0x1E108D0 VA: 0x181E122D0
	public static AppRequest Deserialize(Stream stream, AppRequest instance, bool isDelta) { }

	// RVA: 0x1E114C0 Offset: 0x1E0FAC0 VA: 0x181E114C0
	public static AppRequest DeserializeLengthDelimited(Stream stream, AppRequest instance, bool isDelta) { }

	// RVA: 0x1E11BD0 Offset: 0x1E101D0 VA: 0x181E11BD0
	public static AppRequest DeserializeLength(Stream stream, int length, AppRequest instance, bool isDelta) { }

	// RVA: 0x1E13290 Offset: 0x1E11890 VA: 0x181E13290
	public static void SerializeDelta(Stream stream, AppRequest instance, AppRequest previous) { }

	// RVA: 0x1E14240 Offset: 0x1E12840 VA: 0x181E14240
	public static void Serialize(Stream stream, AppRequest instance) { }

	// RVA: 0x1E14EE0 Offset: 0x1E134E0 VA: 0x181E14EE0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E14EF0 Offset: 0x1E134F0 VA: 0x181E14EF0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E14130 Offset: 0x1E12730 VA: 0x181E14130
	public static byte[] SerializeToBytes(AppRequest instance) { }

	// RVA: 0x1E14080 Offset: 0x1E12680 VA: 0x181E14080
	public static void SerializeLengthDelimited(Stream stream, AppRequest instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class AppMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6512
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public AppResponse response; // 0x18
	public AppBroadcast broadcast; // 0x20

	// Methods

	// RVA: 0x20924B0 Offset: 0x2090AB0 VA: 0x1820924B0
	public static void ResetToPool(AppMessage instance) { }

	// RVA: 0x2092590 Offset: 0x2090B90 VA: 0x182092590
	public void ResetToPool() { }

	// RVA: 0x2092310 Offset: 0x2090910 VA: 0x182092310 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2091720 Offset: 0x208FD20 VA: 0x182091720
	public void CopyTo(AppMessage instance) { }

	// RVA: 0x20917E0 Offset: 0x208FDE0 VA: 0x1820917E0
	public AppMessage Copy() { }

	// RVA: 0x2092290 Offset: 0x2090890 VA: 0x182092290
	public static AppMessage Deserialize(Stream stream) { }

	// RVA: 0x20918F0 Offset: 0x208FEF0 VA: 0x1820918F0
	public static AppMessage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2091E40 Offset: 0x2090440 VA: 0x182091E40
	public static AppMessage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2091ED0 Offset: 0x20904D0 VA: 0x182091ED0
	public static AppMessage Deserialize(byte[] buffer) { }

	// RVA: 0x2092470 Offset: 0x2090A70 VA: 0x182092470
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2092D50 Offset: 0x2091350 VA: 0x182092D50 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2092D70 Offset: 0x2091370 VA: 0x182092D70 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppMessage previous) { }

	// RVA: 0x2092490 Offset: 0x2090A90 VA: 0x182092490 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2092190 Offset: 0x2090790 VA: 0x182092190
	public static AppMessage Deserialize(byte[] buffer, AppMessage instance, bool isDelta = False) { }

	// RVA: 0x2091FF0 Offset: 0x20905F0 VA: 0x182091FF0
	public static AppMessage Deserialize(Stream stream, AppMessage instance, bool isDelta) { }

	// RVA: 0x2091970 Offset: 0x208FF70 VA: 0x182091970
	public static AppMessage DeserializeLengthDelimited(Stream stream, AppMessage instance, bool isDelta) { }

	// RVA: 0x2091BF0 Offset: 0x20901F0 VA: 0x182091BF0
	public static AppMessage DeserializeLength(Stream stream, int length, AppMessage instance, bool isDelta) { }

	// RVA: 0x2092670 Offset: 0x2090C70 VA: 0x182092670
	public static void SerializeDelta(Stream stream, AppMessage instance, AppMessage previous) { }

	// RVA: 0x2092AD0 Offset: 0x20910D0 VA: 0x182092AD0
	public static void Serialize(Stream stream, AppMessage instance) { }

	// RVA: 0x2092D40 Offset: 0x2091340 VA: 0x182092D40
	public byte[] ToProtoBytes() { }

	// RVA: 0x2092D50 Offset: 0x2091350 VA: 0x182092D50
	public void ToProto(Stream stream) { }

	// RVA: 0x20929C0 Offset: 0x2090FC0 VA: 0x1820929C0
	public static byte[] SerializeToBytes(AppMessage instance) { }

	// RVA: 0x2092910 Offset: 0x2090F10 VA: 0x182092910
	public static void SerializeLengthDelimited(Stream stream, AppMessage instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x1E16890 Offset: 0x1E14E90 VA: 0x181E16890
	public static void ResetToPool(AppResponse instance) { }

	// RVA: 0x1E165D0 Offset: 0x1E14BD0 VA: 0x181E165D0
	public void ResetToPool() { }

	// RVA: 0x1E16510 Offset: 0x1E14B10 VA: 0x181E16510 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E14F30 Offset: 0x1E13530 VA: 0x181E14F30
	public void CopyTo(AppResponse instance) { }

	// RVA: 0x1E152C0 Offset: 0x1E138C0 VA: 0x181E152C0
	public AppResponse Copy() { }

	// RVA: 0x1E16390 Offset: 0x1E14990 VA: 0x181E16390
	public static AppResponse Deserialize(Stream stream) { }

	// RVA: 0x1E15850 Offset: 0x1E13E50 VA: 0x181E15850
	public static AppResponse DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E15DB0 Offset: 0x1E143B0 VA: 0x181E15DB0
	public static AppResponse DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E15E40 Offset: 0x1E14440 VA: 0x181E15E40
	public static AppResponse Deserialize(byte[] buffer) { }

	// RVA: 0x1E16590 Offset: 0x1E14B90 VA: 0x181E16590
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E18120 Offset: 0x1E16720 VA: 0x181E18120 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E18140 Offset: 0x1E16740 VA: 0x181E18140 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppResponse previous) { }

	// RVA: 0x1E165B0 Offset: 0x1E14BB0 VA: 0x181E165B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E16410 Offset: 0x1E14A10 VA: 0x181E16410
	public static AppResponse Deserialize(byte[] buffer, AppResponse instance, bool isDelta = False) { }

	// RVA: 0x1E15F60 Offset: 0x1E14560 VA: 0x181E15F60
	public static AppResponse Deserialize(Stream stream, AppResponse instance, bool isDelta) { }

	// RVA: 0x1E15340 Offset: 0x1E13940 VA: 0x181E15340
	public static AppResponse DeserializeLengthDelimited(Stream stream, AppResponse instance, bool isDelta) { }

	// RVA: 0x1E158D0 Offset: 0x1E13ED0 VA: 0x181E158D0
	public static AppResponse DeserializeLength(Stream stream, int length, AppResponse instance, bool isDelta) { }

	// RVA: 0x1E16B50 Offset: 0x1E15150 VA: 0x181E16B50
	public static void SerializeDelta(Stream stream, AppResponse instance, AppResponse previous) { }

	// RVA: 0x1E17760 Offset: 0x1E15D60 VA: 0x181E17760
	public static void Serialize(Stream stream, AppResponse instance) { }

	// RVA: 0x1E18110 Offset: 0x1E16710 VA: 0x181E18110
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E18120 Offset: 0x1E16720 VA: 0x181E18120
	public void ToProto(Stream stream) { }

	// RVA: 0x1E17650 Offset: 0x1E15C50 VA: 0x181E17650
	public static byte[] SerializeToBytes(AppResponse instance) { }

	// RVA: 0x1E175A0 Offset: 0x1E15BA0 VA: 0x181E175A0
	public static void SerializeLengthDelimited(Stream stream, AppResponse instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x2015B70 Offset: 0x2014170 VA: 0x182015B70
	public static void ResetToPool(AppBroadcast instance) { }

	// RVA: 0x2015A50 Offset: 0x2014050 VA: 0x182015A50
	public void ResetToPool() { }

	// RVA: 0x20156B0 Offset: 0x2013CB0 VA: 0x1820156B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20144A0 Offset: 0x2012AA0 VA: 0x1820144A0
	public void CopyTo(AppBroadcast instance) { }

	// RVA: 0x20145A0 Offset: 0x2012BA0 VA: 0x1820145A0
	public AppBroadcast Copy() { }

	// RVA: 0x2014D40 Offset: 0x2013340 VA: 0x182014D40
	public static AppBroadcast Deserialize(Stream stream) { }

	// RVA: 0x20149A0 Offset: 0x2012FA0 VA: 0x1820149A0
	public static AppBroadcast DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2014A20 Offset: 0x2013020 VA: 0x182014A20
	public static AppBroadcast DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2015140 Offset: 0x2013740 VA: 0x182015140
	public static AppBroadcast Deserialize(byte[] buffer) { }

	// RVA: 0x2015850 Offset: 0x2013E50 VA: 0x182015850
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2016550 Offset: 0x2014B50 VA: 0x182016550 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2016570 Offset: 0x2014B70 VA: 0x182016570 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppBroadcast previous) { }

	// RVA: 0x2015A30 Offset: 0x2014030 VA: 0x182015A30 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2015410 Offset: 0x2013A10 VA: 0x182015410
	public static AppBroadcast Deserialize(byte[] buffer, AppBroadcast instance, bool isDelta = False) { }

	// RVA: 0x2014F60 Offset: 0x2013560 VA: 0x182014F60
	public static AppBroadcast Deserialize(Stream stream, AppBroadcast instance, bool isDelta) { }

	// RVA: 0x20146E0 Offset: 0x2012CE0 VA: 0x1820146E0
	public static AppBroadcast DeserializeLengthDelimited(Stream stream, AppBroadcast instance, bool isDelta) { }

	// RVA: 0x2014AB0 Offset: 0x20130B0 VA: 0x182014AB0
	public static AppBroadcast DeserializeLength(Stream stream, int length, AppBroadcast instance, bool isDelta) { }

	// RVA: 0x2015C90 Offset: 0x2014290 VA: 0x182015C90
	public static void SerializeDelta(Stream stream, AppBroadcast instance, AppBroadcast previous) { }

	// RVA: 0x20161E0 Offset: 0x20147E0 VA: 0x1820161E0
	public static void Serialize(Stream stream, AppBroadcast instance) { }

	// RVA: 0x2016540 Offset: 0x2014B40 VA: 0x182016540
	public byte[] ToProtoBytes() { }

	// RVA: 0x2016550 Offset: 0x2014B50 VA: 0x182016550
	public void ToProto(Stream stream) { }

	// RVA: 0x20160D0 Offset: 0x20146D0 VA: 0x1820160D0
	public static byte[] SerializeToBytes(AppBroadcast instance) { }

	// RVA: 0x2016020 Offset: 0x2014620 VA: 0x182016020
	public static void SerializeLengthDelimited(Stream stream, AppBroadcast instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class AppEmpty : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6515
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11

	// Methods

	// RVA: 0x20804A0 Offset: 0x207EAA0 VA: 0x1820804A0
	public static void ResetToPool(AppEmpty instance) { }

	// RVA: 0x2080510 Offset: 0x207EB10 VA: 0x182080510
	public void ResetToPool() { }

	// RVA: 0x2080380 Offset: 0x207E980 VA: 0x182080380 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void CopyTo(AppEmpty instance) { }

	// RVA: 0x207FAD0 Offset: 0x207E0D0 VA: 0x18207FAD0
	public AppEmpty Copy() { }

	// RVA: 0x2080300 Offset: 0x207E900 VA: 0x182080300
	public static AppEmpty Deserialize(Stream stream) { }

	// RVA: 0x207FD00 Offset: 0x207E300 VA: 0x18207FD00
	public static AppEmpty DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x207FF40 Offset: 0x207E540 VA: 0x18207FF40
	public static AppEmpty DeserializeLength(Stream stream, int length) { }

	// RVA: 0x207FFD0 Offset: 0x207E5D0 VA: 0x18207FFD0
	public static AppEmpty Deserialize(byte[] buffer) { }

	// RVA: 0x2080460 Offset: 0x207EA60 VA: 0x182080460
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2080860 Offset: 0x207EE60 VA: 0x182080860 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20808D0 Offset: 0x207EED0 VA: 0x1820808D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppEmpty previous) { }

	// RVA: 0x2080480 Offset: 0x207EA80 VA: 0x182080480 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2080200 Offset: 0x207E800 VA: 0x182080200
	public static AppEmpty Deserialize(byte[] buffer, AppEmpty instance, bool isDelta = False) { }

	// RVA: 0x20800F0 Offset: 0x207E6F0 VA: 0x1820800F0
	public static AppEmpty Deserialize(Stream stream, AppEmpty instance, bool isDelta) { }

	// RVA: 0x207FB20 Offset: 0x207E120 VA: 0x18207FB20
	public static AppEmpty DeserializeLengthDelimited(Stream stream, AppEmpty instance, bool isDelta) { }

	// RVA: 0x207FD80 Offset: 0x207E380 VA: 0x18207FD80
	public static AppEmpty DeserializeLength(Stream stream, int length, AppEmpty instance, bool isDelta) { }

	// RVA: 0x2080580 Offset: 0x207EB80 VA: 0x182080580
	public static void SerializeDelta(Stream stream, AppEmpty instance, AppEmpty previous) { }

	// RVA: 0x20807F0 Offset: 0x207EDF0 VA: 0x1820807F0
	public static void Serialize(Stream stream, AppEmpty instance) { }

	// RVA: 0x2080850 Offset: 0x207EE50 VA: 0x182080850
	public byte[] ToProtoBytes() { }

	// RVA: 0x2080860 Offset: 0x207EE60 VA: 0x182080860
	public void ToProto(Stream stream) { }

	// RVA: 0x2080690 Offset: 0x207EC90 VA: 0x182080690
	public static byte[] SerializeToBytes(AppEmpty instance) { }

	// RVA: 0x20805E0 Offset: 0x207EBE0 VA: 0x1820805E0
	public static void SerializeLengthDelimited(Stream stream, AppEmpty instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class AppSendMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6516
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string message; // 0x18

	// Methods

	// RVA: 0x1E18BC0 Offset: 0x1E171C0 VA: 0x181E18BC0
	public static void ResetToPool(AppSendMessage instance) { }

	// RVA: 0x1E18C50 Offset: 0x1E17250 VA: 0x181E18C50
	public void ResetToPool() { }

	// RVA: 0x1E18B00 Offset: 0x1E17100 VA: 0x181E18B00 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D67B90 Offset: 0x1D66190 VA: 0x181D67B90
	public void CopyTo(AppSendMessage instance) { }

	// RVA: 0x1E18160 Offset: 0x1E16760 VA: 0x181E18160
	public AppSendMessage Copy() { }

	// RVA: 0x1E18810 Offset: 0x1E16E10 VA: 0x181E18810
	public static AppSendMessage Deserialize(Stream stream) { }

	// RVA: 0x1E18400 Offset: 0x1E16A00 VA: 0x181E18400
	public static AppSendMessage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E18480 Offset: 0x1E16A80 VA: 0x181E18480
	public static AppSendMessage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E18890 Offset: 0x1E16E90 VA: 0x181E18890
	public static AppSendMessage Deserialize(byte[] buffer) { }

	// RVA: 0x1E18B80 Offset: 0x1E17180 VA: 0x181E18B80
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E19140 Offset: 0x1E17740 VA: 0x181E19140 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E19160 Offset: 0x1E17760 VA: 0x181E19160 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppSendMessage previous) { }

	// RVA: 0x1E18BA0 Offset: 0x1E171A0 VA: 0x181E18BA0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E18710 Offset: 0x1E16D10 VA: 0x181E18710
	public static AppSendMessage Deserialize(byte[] buffer, AppSendMessage instance, bool isDelta = False) { }

	// RVA: 0x1E189B0 Offset: 0x1E16FB0 VA: 0x181E189B0
	public static AppSendMessage Deserialize(Stream stream, AppSendMessage instance, bool isDelta) { }

	// RVA: 0x1E181E0 Offset: 0x1E167E0 VA: 0x181E181E0
	public static AppSendMessage DeserializeLengthDelimited(Stream stream, AppSendMessage instance, bool isDelta) { }

	// RVA: 0x1E18510 Offset: 0x1E16B10 VA: 0x181E18510
	public static AppSendMessage DeserializeLength(Stream stream, int length, AppSendMessage instance, bool isDelta) { }

	// RVA: 0x1E18CE0 Offset: 0x1E172E0 VA: 0x181E18CE0
	public static void SerializeDelta(Stream stream, AppSendMessage instance, AppSendMessage previous) { }

	// RVA: 0x1E19000 Offset: 0x1E17600 VA: 0x181E19000
	public static void Serialize(Stream stream, AppSendMessage instance) { }

	// RVA: 0x1E19130 Offset: 0x1E17730 VA: 0x181E19130
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E19140 Offset: 0x1E17740 VA: 0x181E19140
	public void ToProto(Stream stream) { }

	// RVA: 0x1E18EF0 Offset: 0x1E174F0 VA: 0x181E18EF0
	public static byte[] SerializeToBytes(AppSendMessage instance) { }

	// RVA: 0x1E18E40 Offset: 0x1E17440 VA: 0x181E18E40
	public static void SerializeLengthDelimited(Stream stream, AppSendMessage instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class AppSetEntityValue : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6517
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public bool value; // 0x12

	// Methods

	// RVA: 0x1E19BE0 Offset: 0x1E181E0 VA: 0x181E19BE0
	public static void ResetToPool(AppSetEntityValue instance) { }

	// RVA: 0x1E19C60 Offset: 0x1E18260 VA: 0x181E19C60
	public void ResetToPool() { }

	// RVA: 0x1E19B20 Offset: 0x1E18120 VA: 0x181E19B20 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E19180 Offset: 0x1E17780 VA: 0x181E19180
	public void CopyTo(AppSetEntityValue instance) { }

	// RVA: 0x1E191A0 Offset: 0x1E177A0 VA: 0x181E191A0
	public AppSetEntityValue Copy() { }

	// RVA: 0x1E199A0 Offset: 0x1E17FA0 VA: 0x181E199A0
	public static AppSetEntityValue Deserialize(Stream stream) { }

	// RVA: 0x1E19210 Offset: 0x1E17810 VA: 0x181E19210
	public static AppSetEntityValue DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E196B0 Offset: 0x1E17CB0 VA: 0x181E196B0
	public static AppSetEntityValue DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E19880 Offset: 0x1E17E80 VA: 0x181E19880
	public static AppSetEntityValue Deserialize(byte[] buffer) { }

	// RVA: 0x1E19BA0 Offset: 0x1E181A0 VA: 0x181E19BA0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E1A0F0 Offset: 0x1E186F0 VA: 0x181E1A0F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E1A1C0 Offset: 0x1E187C0 VA: 0x181E1A1C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppSetEntityValue previous) { }

	// RVA: 0x1E19BC0 Offset: 0x1E181C0 VA: 0x181E19BC0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E19A20 Offset: 0x1E18020 VA: 0x181E19A20
	public static AppSetEntityValue Deserialize(byte[] buffer, AppSetEntityValue instance, bool isDelta = False) { }

	// RVA: 0x1E19740 Offset: 0x1E17D40 VA: 0x181E19740
	public static AppSetEntityValue Deserialize(Stream stream, AppSetEntityValue instance, bool isDelta) { }

	// RVA: 0x1E19290 Offset: 0x1E17890 VA: 0x181E19290
	public static AppSetEntityValue DeserializeLengthDelimited(Stream stream, AppSetEntityValue instance, bool isDelta) { }

	// RVA: 0x1E194B0 Offset: 0x1E17AB0 VA: 0x181E194B0
	public static AppSetEntityValue DeserializeLength(Stream stream, int length, AppSetEntityValue instance, bool isDelta) { }

	// RVA: 0x1E19CE0 Offset: 0x1E182E0 VA: 0x181E19CE0
	public static void SerializeDelta(Stream stream, AppSetEntityValue instance, AppSetEntityValue previous) { }

	// RVA: 0x1E1A010 Offset: 0x1E18610 VA: 0x181E1A010
	public static void Serialize(Stream stream, AppSetEntityValue instance) { }

	// RVA: 0x1E1A0E0 Offset: 0x1E186E0 VA: 0x181E1A0E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E1A0F0 Offset: 0x1E186F0 VA: 0x181E1A0F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E19E60 Offset: 0x1E18460 VA: 0x181E19E60
	public static byte[] SerializeToBytes(AppSetEntityValue instance) { }

	// RVA: 0x1E19DB0 Offset: 0x1E183B0 VA: 0x181E19DB0
	public static void SerializeLengthDelimited(Stream stream, AppSetEntityValue instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class AppPromoteToLeader : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6518
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong steamId; // 0x18

	// Methods

	// RVA: 0x20938C0 Offset: 0x2091EC0 VA: 0x1820938C0
	public static void ResetToPool(AppPromoteToLeader instance) { }

	// RVA: 0x2093840 Offset: 0x2091E40 VA: 0x182093840
	public void ResetToPool() { }

	// RVA: 0x2093710 Offset: 0x2091D10 VA: 0x182093710 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F1C9F0 Offset: 0x1F1AFF0 VA: 0x181F1C9F0
	public void CopyTo(AppPromoteToLeader instance) { }

	// RVA: 0x2092D90 Offset: 0x2091390 VA: 0x182092D90
	public AppPromoteToLeader Copy() { }

	// RVA: 0x2093590 Offset: 0x2091B90 VA: 0x182093590
	public static AppPromoteToLeader Deserialize(Stream stream) { }

	// RVA: 0x2092E00 Offset: 0x2091400 VA: 0x182092E00
	public static AppPromoteToLeader DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20930A0 Offset: 0x20916A0 VA: 0x1820930A0
	public static AppPromoteToLeader DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2093470 Offset: 0x2091A70 VA: 0x182093470
	public static AppPromoteToLeader Deserialize(byte[] buffer) { }

	// RVA: 0x2093800 Offset: 0x2091E00 VA: 0x182093800
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2093D90 Offset: 0x2092390 VA: 0x182093D90 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2093E60 Offset: 0x2092460 VA: 0x182093E60 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppPromoteToLeader previous) { }

	// RVA: 0x2093820 Offset: 0x2091E20 VA: 0x182093820 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2093610 Offset: 0x2091C10 VA: 0x182093610
	public static AppPromoteToLeader Deserialize(byte[] buffer, AppPromoteToLeader instance, bool isDelta = False) { }

	// RVA: 0x2093330 Offset: 0x2091930 VA: 0x182093330
	public static AppPromoteToLeader Deserialize(Stream stream, AppPromoteToLeader instance, bool isDelta) { }

	// RVA: 0x2092E80 Offset: 0x2091480 VA: 0x182092E80
	public static AppPromoteToLeader DeserializeLengthDelimited(Stream stream, AppPromoteToLeader instance, bool isDelta) { }

	// RVA: 0x2093130 Offset: 0x2091730 VA: 0x182093130
	public static AppPromoteToLeader DeserializeLength(Stream stream, int length, AppPromoteToLeader instance, bool isDelta) { }

	// RVA: 0x2093940 Offset: 0x2091F40 VA: 0x182093940
	public static void SerializeDelta(Stream stream, AppPromoteToLeader instance, AppPromoteToLeader previous) { }

	// RVA: 0x2093CB0 Offset: 0x20922B0 VA: 0x182093CB0
	public static void Serialize(Stream stream, AppPromoteToLeader instance) { }

	// RVA: 0x2093D80 Offset: 0x2092380 VA: 0x182093D80
	public byte[] ToProtoBytes() { }

	// RVA: 0x2093D90 Offset: 0x2092390 VA: 0x182093D90
	public void ToProto(Stream stream) { }

	// RVA: 0x2093B00 Offset: 0x2092100 VA: 0x182093B00
	public static byte[] SerializeToBytes(AppPromoteToLeader instance) { }

	// RVA: 0x2093A50 Offset: 0x2092050 VA: 0x182093A50
	public static void SerializeLengthDelimited(Stream stream, AppPromoteToLeader instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class AppSuccess : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6519
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11

	// Methods

	// RVA: 0x1E1ACF0 Offset: 0x1E192F0 VA: 0x181E1ACF0
	public static void ResetToPool(AppSuccess instance) { }

	// RVA: 0x1E1AC80 Offset: 0x1E19280 VA: 0x181E1AC80
	public void ResetToPool() { }

	// RVA: 0x1E1ABC0 Offset: 0x1E191C0 VA: 0x181E1ABC0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void CopyTo(AppSuccess instance) { }

	// RVA: 0x1E1A310 Offset: 0x1E18910 VA: 0x181E1A310
	public AppSuccess Copy() { }

	// RVA: 0x1E1AA40 Offset: 0x1E19040 VA: 0x181E1AA40
	public static AppSuccess Deserialize(Stream stream) { }

	// RVA: 0x1E1A540 Offset: 0x1E18B40 VA: 0x181E1A540
	public static AppSuccess DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E1A780 Offset: 0x1E18D80 VA: 0x181E1A780
	public static AppSuccess DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E1A920 Offset: 0x1E18F20 VA: 0x181E1A920
	public static AppSuccess Deserialize(byte[] buffer) { }

	// RVA: 0x1E1AC40 Offset: 0x1E19240 VA: 0x181E1AC40
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E1B040 Offset: 0x1E19640 VA: 0x181E1B040 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E1B0B0 Offset: 0x1E196B0 VA: 0x181E1B0B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppSuccess previous) { }

	// RVA: 0x1E1AC60 Offset: 0x1E19260 VA: 0x181E1AC60 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E1AAC0 Offset: 0x1E190C0 VA: 0x181E1AAC0
	public static AppSuccess Deserialize(byte[] buffer, AppSuccess instance, bool isDelta = False) { }

	// RVA: 0x1E1A810 Offset: 0x1E18E10 VA: 0x181E1A810
	public static AppSuccess Deserialize(Stream stream, AppSuccess instance, bool isDelta) { }

	// RVA: 0x1E1A360 Offset: 0x1E18960 VA: 0x181E1A360
	public static AppSuccess DeserializeLengthDelimited(Stream stream, AppSuccess instance, bool isDelta) { }

	// RVA: 0x1E1A5C0 Offset: 0x1E18BC0 VA: 0x181E1A5C0
	public static AppSuccess DeserializeLength(Stream stream, int length, AppSuccess instance, bool isDelta) { }

	// RVA: 0x1E1AD60 Offset: 0x1E19360 VA: 0x181E1AD60
	public static void SerializeDelta(Stream stream, AppSuccess instance, AppSuccess previous) { }

	// RVA: 0x1E1AFD0 Offset: 0x1E195D0 VA: 0x181E1AFD0
	public static void Serialize(Stream stream, AppSuccess instance) { }

	// RVA: 0x1E1B030 Offset: 0x1E19630 VA: 0x181E1B030
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E1B040 Offset: 0x1E19640 VA: 0x181E1B040
	public void ToProto(Stream stream) { }

	// RVA: 0x1E1AE70 Offset: 0x1E19470 VA: 0x181E1AE70
	public static byte[] SerializeToBytes(AppSuccess instance) { }

	// RVA: 0x1E1ADC0 Offset: 0x1E193C0 VA: 0x181E1ADC0
	public static void SerializeLengthDelimited(Stream stream, AppSuccess instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class AppError : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6520
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string error; // 0x18

	// Methods

	// RVA: 0x2086770 Offset: 0x2084D70 VA: 0x182086770
	public static void ResetToPool(AppError instance) { }

	// RVA: 0x20866E0 Offset: 0x2084CE0 VA: 0x1820866E0
	public void ResetToPool() { }

	// RVA: 0x2086590 Offset: 0x2084B90 VA: 0x182086590 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D67B90 Offset: 0x1D66190 VA: 0x181D67B90
	public void CopyTo(AppError instance) { }

	// RVA: 0x2085BF0 Offset: 0x20841F0 VA: 0x182085BF0
	public AppError Copy() { }

	// RVA: 0x20862A0 Offset: 0x20848A0 VA: 0x1820862A0
	public static AppError Deserialize(Stream stream) { }

	// RVA: 0x2085C70 Offset: 0x2084270 VA: 0x182085C70
	public static AppError DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2086110 Offset: 0x2084710 VA: 0x182086110
	public static AppError DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2086470 Offset: 0x2084A70 VA: 0x182086470
	public static AppError Deserialize(byte[] buffer) { }

	// RVA: 0x20866A0 Offset: 0x2084CA0 VA: 0x1820866A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2086C60 Offset: 0x2085260 VA: 0x182086C60 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2086C80 Offset: 0x2085280 VA: 0x182086C80 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppError previous) { }

	// RVA: 0x20866C0 Offset: 0x2084CC0 VA: 0x1820866C0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20861A0 Offset: 0x20847A0 VA: 0x1820861A0
	public static AppError Deserialize(byte[] buffer, AppError instance, bool isDelta = False) { }

	// RVA: 0x2086320 Offset: 0x2084920 VA: 0x182086320
	public static AppError Deserialize(Stream stream, AppError instance, bool isDelta) { }

	// RVA: 0x2085CF0 Offset: 0x20842F0 VA: 0x182085CF0
	public static AppError DeserializeLengthDelimited(Stream stream, AppError instance, bool isDelta) { }

	// RVA: 0x2085F10 Offset: 0x2084510 VA: 0x182085F10
	public static AppError DeserializeLength(Stream stream, int length, AppError instance, bool isDelta) { }

	// RVA: 0x2086800 Offset: 0x2084E00 VA: 0x182086800
	public static void SerializeDelta(Stream stream, AppError instance, AppError previous) { }

	// RVA: 0x2086B20 Offset: 0x2085120 VA: 0x182086B20
	public static void Serialize(Stream stream, AppError instance) { }

	// RVA: 0x2086C50 Offset: 0x2085250 VA: 0x182086C50
	public byte[] ToProtoBytes() { }

	// RVA: 0x2086C60 Offset: 0x2085260 VA: 0x182086C60
	public void ToProto(Stream stream) { }

	// RVA: 0x2086A10 Offset: 0x2085010 VA: 0x182086A10
	public static byte[] SerializeToBytes(AppError instance) { }

	// RVA: 0x2086960 Offset: 0x2084F60 VA: 0x182086960
	public static void SerializeLengthDelimited(Stream stream, AppError instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class AppFlag : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6521
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public bool value; // 0x12

	// Methods

	// RVA: 0x20878B0 Offset: 0x2085EB0 VA: 0x1820878B0
	public static void ResetToPool(AppFlag instance) { }

	// RVA: 0x2087930 Offset: 0x2085F30 VA: 0x182087930
	public void ResetToPool() { }

	// RVA: 0x2087780 Offset: 0x2085D80 VA: 0x182087780 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E19180 Offset: 0x1E17780 VA: 0x181E19180
	public void CopyTo(AppFlag instance) { }

	// RVA: 0x2086E00 Offset: 0x2085400 VA: 0x182086E00
	public AppFlag Copy() { }

	// RVA: 0x2087700 Offset: 0x2085D00 VA: 0x182087700
	public static AppFlag Deserialize(Stream stream) { }

	// RVA: 0x2087090 Offset: 0x2085690 VA: 0x182087090
	public static AppFlag DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2087110 Offset: 0x2085710 VA: 0x182087110
	public static AppFlag DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20873A0 Offset: 0x20859A0 VA: 0x1820873A0
	public static AppFlag Deserialize(byte[] buffer) { }

	// RVA: 0x2087870 Offset: 0x2085E70 VA: 0x182087870
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2087DC0 Offset: 0x20863C0 VA: 0x182087DC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2087E90 Offset: 0x2086490 VA: 0x182087E90 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppFlag previous) { }

	// RVA: 0x2087890 Offset: 0x2085E90 VA: 0x182087890 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20874C0 Offset: 0x2085AC0 VA: 0x1820874C0
	public static AppFlag Deserialize(byte[] buffer, AppFlag instance, bool isDelta = False) { }

	// RVA: 0x20875C0 Offset: 0x2085BC0 VA: 0x1820875C0
	public static AppFlag Deserialize(Stream stream, AppFlag instance, bool isDelta) { }

	// RVA: 0x2086E70 Offset: 0x2085470 VA: 0x182086E70
	public static AppFlag DeserializeLengthDelimited(Stream stream, AppFlag instance, bool isDelta) { }

	// RVA: 0x20871A0 Offset: 0x20857A0 VA: 0x1820871A0
	public static AppFlag DeserializeLength(Stream stream, int length, AppFlag instance, bool isDelta) { }

	// RVA: 0x20879B0 Offset: 0x2085FB0 VA: 0x1820879B0
	public static void SerializeDelta(Stream stream, AppFlag instance, AppFlag previous) { }

	// RVA: 0x2087CE0 Offset: 0x20862E0 VA: 0x182087CE0
	public static void Serialize(Stream stream, AppFlag instance) { }

	// RVA: 0x2087DB0 Offset: 0x20863B0 VA: 0x182087DB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x2087DC0 Offset: 0x20863C0 VA: 0x182087DC0
	public void ToProto(Stream stream) { }

	// RVA: 0x2087B30 Offset: 0x2086130 VA: 0x182087B30
	public static byte[] SerializeToBytes(AppFlag instance) { }

	// RVA: 0x2087A80 Offset: 0x2086080 VA: 0x182087A80
	public static void SerializeLengthDelimited(Stream stream, AppFlag instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x20897F0 Offset: 0x2087DF0 VA: 0x1820897F0
	public static void ResetToPool(AppInfo instance) { }

	// RVA: 0x2089640 Offset: 0x2087C40 VA: 0x182089640
	public void ResetToPool() { }

	// RVA: 0x20893D0 Offset: 0x20879D0 VA: 0x1820893D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2087FE0 Offset: 0x20865E0 VA: 0x182087FE0
	public void CopyTo(AppInfo instance) { }

	// RVA: 0x2088090 Offset: 0x2086690 VA: 0x182088090
	public AppInfo Copy() { }

	// RVA: 0x2089350 Offset: 0x2087950 VA: 0x182089350
	public static AppInfo Deserialize(Stream stream) { }

	// RVA: 0x20886B0 Offset: 0x2086CB0 VA: 0x1820886B0
	public static AppInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2088730 Offset: 0x2086D30 VA: 0x182088730
	public static AppInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2088DD0 Offset: 0x20873D0 VA: 0x182088DD0
	public static AppInfo Deserialize(byte[] buffer) { }

	// RVA: 0x2089600 Offset: 0x2087C00 VA: 0x182089600
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x208A5A0 Offset: 0x2088BA0 VA: 0x18208A5A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x208A5C0 Offset: 0x2088BC0 VA: 0x18208A5C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppInfo previous) { }

	// RVA: 0x2089620 Offset: 0x2087C20 VA: 0x182089620 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2088CD0 Offset: 0x20872D0 VA: 0x182088CD0
	public static AppInfo Deserialize(byte[] buffer, AppInfo instance, bool isDelta = False) { }

	// RVA: 0x2088EF0 Offset: 0x20874F0 VA: 0x182088EF0
	public static AppInfo Deserialize(Stream stream, AppInfo instance, bool isDelta) { }

	// RVA: 0x2088180 Offset: 0x2086780 VA: 0x182088180
	public static AppInfo DeserializeLengthDelimited(Stream stream, AppInfo instance, bool isDelta) { }

	// RVA: 0x20887C0 Offset: 0x2086DC0 VA: 0x1820887C0
	public static AppInfo DeserializeLength(Stream stream, int length, AppInfo instance, bool isDelta) { }

	// RVA: 0x20899A0 Offset: 0x2087FA0 VA: 0x1820899A0
	public static void SerializeDelta(Stream stream, AppInfo instance, AppInfo previous) { }

	// RVA: 0x208A170 Offset: 0x2088770 VA: 0x18208A170
	public static void Serialize(Stream stream, AppInfo instance) { }

	// RVA: 0x208A590 Offset: 0x2088B90 VA: 0x18208A590
	public byte[] ToProtoBytes() { }

	// RVA: 0x208A5A0 Offset: 0x2088BA0 VA: 0x18208A5A0
	public void ToProto(Stream stream) { }

	// RVA: 0x208A060 Offset: 0x2088660 VA: 0x18208A060
	public static byte[] SerializeToBytes(AppInfo instance) { }

	// RVA: 0x2089FB0 Offset: 0x20885B0 VA: 0x182089FB0
	public static void SerializeLengthDelimited(Stream stream, AppInfo instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x1E23100 Offset: 0x1E21700 VA: 0x181E23100
	public static void ResetToPool(AppTime instance) { }

	// RVA: 0x1E23050 Offset: 0x1E21650 VA: 0x181E23050
	public void ResetToPool() { }

	// RVA: 0x1E22D50 Offset: 0x1E21350 VA: 0x181E22D50 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E219A0 Offset: 0x1E1FFA0 VA: 0x181E219A0
	public void CopyTo(AppTime instance) { }

	// RVA: 0x1E219E0 Offset: 0x1E1FFE0 VA: 0x181E219E0
	public AppTime Copy() { }

	// RVA: 0x1E224F0 Offset: 0x1E20AF0 VA: 0x181E224F0
	public static AppTime Deserialize(Stream stream) { }

	// RVA: 0x1E21A60 Offset: 0x1E20060 VA: 0x181E21A60
	public static AppTime DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E21E10 Offset: 0x1E20410 VA: 0x181E21E10
	public static AppTime DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E229F0 Offset: 0x1E20FF0 VA: 0x181E229F0
	public static AppTime Deserialize(byte[] buffer) { }

	// RVA: 0x1E22DD0 Offset: 0x1E213D0 VA: 0x181E22DD0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E23780 Offset: 0x1E21D80 VA: 0x181E23780 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E237A0 Offset: 0x1E21DA0 VA: 0x181E237A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppTime previous) { }

	// RVA: 0x1E23030 Offset: 0x1E21630 VA: 0x181E23030 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E221B0 Offset: 0x1E207B0 VA: 0x181E221B0
	public static AppTime Deserialize(byte[] buffer, AppTime instance, bool isDelta = False) { }

	// RVA: 0x1E22790 Offset: 0x1E20D90 VA: 0x181E22790
	public static AppTime Deserialize(Stream stream, AppTime instance, bool isDelta) { }

	// RVA: 0x1E21AE0 Offset: 0x1E200E0 VA: 0x181E21AE0
	public static AppTime DeserializeLengthDelimited(Stream stream, AppTime instance, bool isDelta) { }

	// RVA: 0x1E21EA0 Offset: 0x1E204A0 VA: 0x181E21EA0
	public static AppTime DeserializeLength(Stream stream, int length, AppTime instance, bool isDelta) { }

	// RVA: 0x1E231B0 Offset: 0x1E217B0 VA: 0x181E231B0
	public static void SerializeDelta(Stream stream, AppTime instance, AppTime previous) { }

	// RVA: 0x1E23600 Offset: 0x1E21C00 VA: 0x181E23600
	public static void Serialize(Stream stream, AppTime instance) { }

	// RVA: 0x1E23770 Offset: 0x1E21D70 VA: 0x181E23770
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E23780 Offset: 0x1E21D80 VA: 0x181E23780
	public void ToProto(Stream stream) { }

	// RVA: 0x1E234F0 Offset: 0x1E21AF0 VA: 0x181E234F0
	public static byte[] SerializeToBytes(AppTime instance) { }

	// RVA: 0x1E23440 Offset: 0x1E21A40 VA: 0x181E23440
	public static void SerializeLengthDelimited(Stream stream, AppTime instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x208E0F0 Offset: 0x208C6F0 VA: 0x18208E0F0
	public static void ResetToPool(AppMap instance) { }

	// RVA: 0x208DEC0 Offset: 0x208C4C0 VA: 0x18208DEC0
	public void ResetToPool() { }

	// RVA: 0x208DAD0 Offset: 0x208C0D0 VA: 0x18208DAD0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x208C020 Offset: 0x208A620 VA: 0x18208C020
	public void CopyTo(AppMap instance) { }

	// RVA: 0x208C240 Offset: 0x208A840 VA: 0x18208C240
	public AppMap Copy() { }

	// RVA: 0x208CFF0 Offset: 0x208B5F0 VA: 0x18208CFF0
	public static AppMap Deserialize(Stream stream) { }

	// RVA: 0x208C6F0 Offset: 0x208ACF0 VA: 0x18208C6F0
	public static AppMap DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x208CB70 Offset: 0x208B170 VA: 0x18208CB70
	public static AppMap DeserializeLength(Stream stream, int length) { }

	// RVA: 0x208CC00 Offset: 0x208B200 VA: 0x18208CC00
	public static AppMap Deserialize(byte[] buffer) { }

	// RVA: 0x208DB50 Offset: 0x208C150 VA: 0x18208DB50
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x208EC10 Offset: 0x208D210 VA: 0x18208EC10 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x208EC30 Offset: 0x208D230 VA: 0x18208EC30 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppMap previous) { }

	// RVA: 0x208DEA0 Offset: 0x208C4A0 VA: 0x18208DEA0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x208D6A0 Offset: 0x208BCA0 VA: 0x18208D6A0
	public static AppMap Deserialize(byte[] buffer, AppMap instance, bool isDelta = False) { }

	// RVA: 0x208D350 Offset: 0x208B950 VA: 0x18208D350
	public static AppMap Deserialize(Stream stream, AppMap instance, bool isDelta) { }

	// RVA: 0x208C2C0 Offset: 0x208A8C0 VA: 0x18208C2C0
	public static AppMap DeserializeLengthDelimited(Stream stream, AppMap instance, bool isDelta) { }

	// RVA: 0x208C770 Offset: 0x208AD70 VA: 0x18208C770
	public static AppMap DeserializeLength(Stream stream, int length, AppMap instance, bool isDelta) { }

	// RVA: 0x208E320 Offset: 0x208C920 VA: 0x18208E320
	public static void SerializeDelta(Stream stream, AppMap instance, AppMap previous) { }

	// RVA: 0x208E8B0 Offset: 0x208CEB0 VA: 0x18208E8B0
	public static void Serialize(Stream stream, AppMap instance) { }

	// RVA: 0x208EC00 Offset: 0x208D200 VA: 0x18208EC00
	public byte[] ToProtoBytes() { }

	// RVA: 0x208EC10 Offset: 0x208D210 VA: 0x18208EC10
	public void ToProto(Stream stream) { }

	// RVA: 0x208E7A0 Offset: 0x208CDA0 VA: 0x18208E7A0
	public static byte[] SerializeToBytes(AppMap instance) { }

	// RVA: 0x208E6F0 Offset: 0x208CCF0 VA: 0x18208E6F0
	public static void SerializeLengthDelimited(Stream stream, AppMap instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x2096A10 Offset: 0x2095010 VA: 0x182096A10
	public static void ResetToPool(AppMap.Monument instance) { }

	// RVA: 0x2096AC0 Offset: 0x20950C0 VA: 0x182096AC0
	public void ResetToPool() { }

	// RVA: 0x20967B0 Offset: 0x2094DB0 VA: 0x1820967B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20957A0 Offset: 0x2093DA0 VA: 0x1820957A0
	public void CopyTo(AppMap.Monument instance) { }

	// RVA: 0x20957F0 Offset: 0x2093DF0 VA: 0x1820957F0
	public AppMap.Monument Copy() { }

	// RVA: 0x2095EB0 Offset: 0x20944B0 VA: 0x182095EB0
	public static AppMap.Monument Deserialize(Stream stream) { }

	// RVA: 0x2095B20 Offset: 0x2094120 VA: 0x182095B20
	public static AppMap.Monument DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2095E20 Offset: 0x2094420 VA: 0x182095E20
	public static AppMap.Monument DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2096340 Offset: 0x2094940 VA: 0x182096340
	public static AppMap.Monument Deserialize(byte[] buffer) { }

	// RVA: 0x2096830 Offset: 0x2094E30 VA: 0x182096830
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2097100 Offset: 0x2095700 VA: 0x182097100 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2097120 Offset: 0x2095720 VA: 0x182097120 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppMap.Monument previous) { }

	// RVA: 0x20969F0 Offset: 0x2094FF0 VA: 0x1820969F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20960B0 Offset: 0x20946B0 VA: 0x1820960B0
	public static AppMap.Monument Deserialize(byte[] buffer, AppMap.Monument instance, bool isDelta = False) { }

	// RVA: 0x20965F0 Offset: 0x2094BF0 VA: 0x1820965F0
	public static AppMap.Monument Deserialize(Stream stream, AppMap.Monument instance, bool isDelta) { }

	// RVA: 0x2095880 Offset: 0x2093E80 VA: 0x182095880
	public static AppMap.Monument DeserializeLengthDelimited(Stream stream, AppMap.Monument instance, bool isDelta) { }

	// RVA: 0x2095BA0 Offset: 0x20941A0 VA: 0x182095BA0
	public static AppMap.Monument DeserializeLength(Stream stream, int length, AppMap.Monument instance, bool isDelta) { }

	// RVA: 0x2096B70 Offset: 0x2095170 VA: 0x182096B70
	public static void SerializeDelta(Stream stream, AppMap.Monument instance, AppMap.Monument previous) { }

	// RVA: 0x2096F60 Offset: 0x2095560 VA: 0x182096F60
	public static void Serialize(Stream stream, AppMap.Monument instance) { }

	// RVA: 0x20970F0 Offset: 0x20956F0 VA: 0x1820970F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x2097100 Offset: 0x2095700 VA: 0x182097100
	public void ToProto(Stream stream) { }

	// RVA: 0x2096E50 Offset: 0x2095450 VA: 0x182096E50
	public static byte[] SerializeToBytes(AppMap.Monument instance) { }

	// RVA: 0x2096DA0 Offset: 0x20953A0 VA: 0x182096DA0
	public static void SerializeLengthDelimited(Stream stream, AppMap.Monument instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class AppEntityInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6526
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public AppEntityType type; // 0x14
	public AppEntityPayload payload; // 0x18

	// Methods

	// RVA: 0x2082D00 Offset: 0x2081300 VA: 0x182082D00
	public static void ResetToPool(AppEntityInfo instance) { }

	// RVA: 0x2082C50 Offset: 0x2081250 VA: 0x182082C50
	public void ResetToPool() { }

	// RVA: 0x2082AE0 Offset: 0x20810E0 VA: 0x182082AE0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2080960 Offset: 0x207EF60 VA: 0x182080960
	public void CopyTo(AppEntityInfo instance) { }

	// RVA: 0x2081EF0 Offset: 0x20804F0 VA: 0x182081EF0
	public AppEntityInfo Copy() { }

	// RVA: 0x2082A60 Offset: 0x2081060 VA: 0x182082A60
	public static AppEntityInfo Deserialize(Stream stream) { }

	// RVA: 0x2081FC0 Offset: 0x20805C0 VA: 0x182081FC0
	public static AppEntityInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20825B0 Offset: 0x2080BB0 VA: 0x1820825B0
	public static AppEntityInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2082640 Offset: 0x2080C40 VA: 0x182082640
	public static AppEntityInfo Deserialize(byte[] buffer) { }

	// RVA: 0x2082C10 Offset: 0x2081210 VA: 0x182082C10
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20833C0 Offset: 0x20819C0 VA: 0x1820833C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20833E0 Offset: 0x20819E0 VA: 0x1820833E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppEntityInfo previous) { }

	// RVA: 0x2082C30 Offset: 0x2081230 VA: 0x182082C30 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2082960 Offset: 0x2080F60 VA: 0x182082960
	public static AppEntityInfo Deserialize(byte[] buffer, AppEntityInfo instance, bool isDelta = False) { }

	// RVA: 0x2082760 Offset: 0x2080D60 VA: 0x182082760
	public static AppEntityInfo Deserialize(Stream stream, AppEntityInfo instance, bool isDelta) { }

	// RVA: 0x2082040 Offset: 0x2080640 VA: 0x182082040
	public static AppEntityInfo DeserializeLengthDelimited(Stream stream, AppEntityInfo instance, bool isDelta) { }

	// RVA: 0x2082310 Offset: 0x2080910 VA: 0x182082310
	public static AppEntityInfo DeserializeLength(Stream stream, int length, AppEntityInfo instance, bool isDelta) { }

	// RVA: 0x2082DB0 Offset: 0x20813B0 VA: 0x182082DB0
	public static void SerializeDelta(Stream stream, AppEntityInfo instance, AppEntityInfo previous) { }

	// RVA: 0x20831A0 Offset: 0x20817A0 VA: 0x1820831A0
	public static void Serialize(Stream stream, AppEntityInfo instance) { }

	// RVA: 0x20833B0 Offset: 0x20819B0 VA: 0x1820833B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20833C0 Offset: 0x20819C0 VA: 0x1820833C0
	public void ToProto(Stream stream) { }

	// RVA: 0x2083090 Offset: 0x2081690 VA: 0x182083090
	public static byte[] SerializeToBytes(AppEntityInfo instance) { }

	// RVA: 0x2082FE0 Offset: 0x20815E0 VA: 0x182082FE0
	public static void SerializeLengthDelimited(Stream stream, AppEntityInfo instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x2084FF0 Offset: 0x20835F0 VA: 0x182084FF0
	public static void ResetToPool(AppEntityPayload instance) { }

	// RVA: 0x2085200 Offset: 0x2083800 VA: 0x182085200
	public void ResetToPool() { }

	// RVA: 0x2084C60 Offset: 0x2083260 VA: 0x182084C60 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2083400 Offset: 0x2081A00 VA: 0x182083400
	public void CopyTo(AppEntityPayload instance) { }

	// RVA: 0x20835B0 Offset: 0x2081BB0 VA: 0x1820835B0
	public AppEntityPayload Copy() { }

	// RVA: 0x2084280 Offset: 0x2082880 VA: 0x182084280
	public static AppEntityPayload Deserialize(Stream stream) { }

	// RVA: 0x2083630 Offset: 0x2081C30 VA: 0x182083630
	public static AppEntityPayload DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2083A90 Offset: 0x2082090 VA: 0x182083A90
	public static AppEntityPayload DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2083ED0 Offset: 0x20824D0 VA: 0x182083ED0
	public static AppEntityPayload Deserialize(byte[] buffer) { }

	// RVA: 0x2084CE0 Offset: 0x20832E0 VA: 0x182084CE0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2085BB0 Offset: 0x20841B0 VA: 0x182085BB0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2085BD0 Offset: 0x20841D0 VA: 0x182085BD0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppEntityPayload previous) { }

	// RVA: 0x2084FD0 Offset: 0x20835D0 VA: 0x182084FD0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2084590 Offset: 0x2082B90 VA: 0x182084590
	public static AppEntityPayload Deserialize(byte[] buffer, AppEntityPayload instance, bool isDelta = False) { }

	// RVA: 0x2084960 Offset: 0x2082F60 VA: 0x182084960
	public static AppEntityPayload Deserialize(Stream stream, AppEntityPayload instance, bool isDelta) { }

	// RVA: 0x20836B0 Offset: 0x2081CB0 VA: 0x1820836B0
	public static AppEntityPayload DeserializeLengthDelimited(Stream stream, AppEntityPayload instance, bool isDelta) { }

	// RVA: 0x2083B20 Offset: 0x2082120 VA: 0x182083B20
	public static AppEntityPayload DeserializeLength(Stream stream, int length, AppEntityPayload instance, bool isDelta) { }

	// RVA: 0x2085410 Offset: 0x2083A10 VA: 0x182085410
	public static void SerializeDelta(Stream stream, AppEntityPayload instance, AppEntityPayload previous) { }

	// RVA: 0x20858F0 Offset: 0x2083EF0 VA: 0x1820858F0
	public static void Serialize(Stream stream, AppEntityPayload instance) { }

	// RVA: 0x2085BA0 Offset: 0x20841A0 VA: 0x182085BA0
	public byte[] ToProtoBytes() { }

	// RVA: 0x2085BB0 Offset: 0x20841B0 VA: 0x182085BB0
	public void ToProto(Stream stream) { }

	// RVA: 0x20857E0 Offset: 0x2083DE0 VA: 0x1820857E0
	public static byte[] SerializeToBytes(AppEntityPayload instance) { }

	// RVA: 0x2085730 Offset: 0x2083D30 VA: 0x182085730
	public static void SerializeLengthDelimited(Stream stream, AppEntityPayload instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x2095190 Offset: 0x2093790 VA: 0x182095190
	public static void ResetToPool(AppEntityPayload.Item instance) { }

	// RVA: 0x2095220 Offset: 0x2093820 VA: 0x182095220
	public void ResetToPool() { }

	// RVA: 0x2094F40 Offset: 0x2093540 VA: 0x182094F40 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D68BE0 Offset: 0x1D671E0 VA: 0x181D68BE0
	public void CopyTo(AppEntityPayload.Item instance) { }

	// RVA: 0x2094010 Offset: 0x2092610 VA: 0x182094010
	public AppEntityPayload.Item Copy() { }

	// RVA: 0x2094680 Offset: 0x2092C80 VA: 0x182094680
	public static AppEntityPayload.Item Deserialize(Stream stream) { }

	// RVA: 0x2094090 Offset: 0x2092690 VA: 0x182094090
	public static AppEntityPayload.Item DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2094390 Offset: 0x2092990 VA: 0x182094390
	public static AppEntityPayload.Item DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2094870 Offset: 0x2092E70 VA: 0x182094870
	public static AppEntityPayload.Item Deserialize(byte[] buffer) { }

	// RVA: 0x2094FC0 Offset: 0x20935C0 VA: 0x182094FC0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2095760 Offset: 0x2093D60 VA: 0x182095760 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2095780 Offset: 0x2093D80 VA: 0x182095780 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppEntityPayload.Item previous) { }

	// RVA: 0x2095170 Offset: 0x2093770 VA: 0x182095170 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2094CC0 Offset: 0x20932C0 VA: 0x182094CC0
	public static AppEntityPayload.Item Deserialize(byte[] buffer, AppEntityPayload.Item instance, bool isDelta = False) { }

	// RVA: 0x2094B10 Offset: 0x2093110 VA: 0x182094B10
	public static AppEntityPayload.Item Deserialize(Stream stream, AppEntityPayload.Item instance, bool isDelta) { }

	// RVA: 0x2094110 Offset: 0x2092710 VA: 0x182094110
	public static AppEntityPayload.Item DeserializeLengthDelimited(Stream stream, AppEntityPayload.Item instance, bool isDelta) { }

	// RVA: 0x2094420 Offset: 0x2092A20 VA: 0x182094420
	public static AppEntityPayload.Item DeserializeLength(Stream stream, int length, AppEntityPayload.Item instance, bool isDelta) { }

	// RVA: 0x20952B0 Offset: 0x20938B0 VA: 0x1820952B0
	public static void SerializeDelta(Stream stream, AppEntityPayload.Item instance, AppEntityPayload.Item previous) { }

	// RVA: 0x2095630 Offset: 0x2093C30 VA: 0x182095630
	public static void Serialize(Stream stream, AppEntityPayload.Item instance) { }

	// RVA: 0x2095750 Offset: 0x2093D50 VA: 0x182095750
	public byte[] ToProtoBytes() { }

	// RVA: 0x2095760 Offset: 0x2093D60 VA: 0x182095760
	public void ToProto(Stream stream) { }

	// RVA: 0x2095520 Offset: 0x2093B20 VA: 0x182095520
	public static byte[] SerializeToBytes(AppEntityPayload.Item instance) { }

	// RVA: 0x2095470 Offset: 0x2093A70 VA: 0x182095470
	public static void SerializeLengthDelimited(Stream stream, AppEntityPayload.Item instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x1E1F740 Offset: 0x1E1DD40 VA: 0x181E1F740
	public static void ResetToPool(AppTeamInfo instance) { }

	// RVA: 0x1E1F310 Offset: 0x1E1D910 VA: 0x181E1F310
	public void ResetToPool() { }

	// RVA: 0x1E1F250 Offset: 0x1E1D850 VA: 0x181E1F250 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E1DC80 Offset: 0x1E1C280 VA: 0x181E1DC80
	public void CopyTo(AppTeamInfo instance) { }

	// RVA: 0x1E1E0D0 Offset: 0x1E1C6D0 VA: 0x181E1E0D0
	public AppTeamInfo Copy() { }

	// RVA: 0x1E1F1D0 Offset: 0x1E1D7D0 VA: 0x181E1F1D0
	public static AppTeamInfo Deserialize(Stream stream) { }

	// RVA: 0x1E1E610 Offset: 0x1E1CC10 VA: 0x181E1E610
	public static AppTeamInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E1E690 Offset: 0x1E1CC90 VA: 0x181E1E690
	public static AppTeamInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E1F0B0 Offset: 0x1E1D6B0 VA: 0x181E1F0B0
	public static AppTeamInfo Deserialize(byte[] buffer) { }

	// RVA: 0x1E1F2D0 Offset: 0x1E1D8D0 VA: 0x181E1F2D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E20670 Offset: 0x1E1EC70 VA: 0x181E20670 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E20690 Offset: 0x1E1EC90 VA: 0x181E20690 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppTeamInfo previous) { }

	// RVA: 0x1E1F2F0 Offset: 0x1E1D8F0 VA: 0x181E1F2F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E1EFB0 Offset: 0x1E1D5B0 VA: 0x181E1EFB0
	public static AppTeamInfo Deserialize(byte[] buffer, AppTeamInfo instance, bool isDelta = False) { }

	// RVA: 0x1E1EBC0 Offset: 0x1E1D1C0 VA: 0x181E1EBC0
	public static AppTeamInfo Deserialize(Stream stream, AppTeamInfo instance, bool isDelta) { }

	// RVA: 0x1E1E150 Offset: 0x1E1C750 VA: 0x181E1E150
	public static AppTeamInfo DeserializeLengthDelimited(Stream stream, AppTeamInfo instance, bool isDelta) { }

	// RVA: 0x1E1E720 Offset: 0x1E1CD20 VA: 0x181E1E720
	public static AppTeamInfo DeserializeLength(Stream stream, int length, AppTeamInfo instance, bool isDelta) { }

	// RVA: 0x1E1FB70 Offset: 0x1E1E170 VA: 0x181E1FB70
	public static void SerializeDelta(Stream stream, AppTeamInfo instance, AppTeamInfo previous) { }

	// RVA: 0x1E201E0 Offset: 0x1E1E7E0 VA: 0x181E201E0
	public static void Serialize(Stream stream, AppTeamInfo instance) { }

	// RVA: 0x1E20660 Offset: 0x1E1EC60 VA: 0x181E20660
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E20670 Offset: 0x1E1EC70 VA: 0x181E20670
	public void ToProto(Stream stream) { }

	// RVA: 0x1E200D0 Offset: 0x1E1E6D0 VA: 0x181E200D0
	public static byte[] SerializeToBytes(AppTeamInfo instance) { }

	// RVA: 0x1E20020 Offset: 0x1E1E620 VA: 0x181E20020
	public static void SerializeLengthDelimited(Stream stream, AppTeamInfo instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x1E27B40 Offset: 0x1E26140 VA: 0x181E27B40
	public static void ResetToPool(AppTeamInfo.Member instance) { }

	// RVA: 0x1E27A40 Offset: 0x1E26040 VA: 0x181E27A40
	public void ResetToPool() { }

	// RVA: 0x1E27670 Offset: 0x1E25C70 VA: 0x181E27670 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E25D40 Offset: 0x1E24340 VA: 0x181E25D40
	public void CopyTo(AppTeamInfo.Member instance) { }

	// RVA: 0x1E25DB0 Offset: 0x1E243B0 VA: 0x181E25DB0
	public AppTeamInfo.Member Copy() { }

	// RVA: 0x1E26BB0 Offset: 0x1E251B0 VA: 0x181E26BB0
	public static AppTeamInfo.Member Deserialize(Stream stream) { }

	// RVA: 0x1E25E60 Offset: 0x1E24460 VA: 0x181E25E60
	public static AppTeamInfo.Member DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E262F0 Offset: 0x1E248F0 VA: 0x181E262F0
	public static AppTeamInfo.Member DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E26770 Offset: 0x1E24D70 VA: 0x181E26770
	public static AppTeamInfo.Member Deserialize(byte[] buffer) { }

	// RVA: 0x1E276F0 Offset: 0x1E25CF0 VA: 0x181E276F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E28420 Offset: 0x1E26A20 VA: 0x181E28420 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E28440 Offset: 0x1E26A40 VA: 0x181E28440 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppTeamInfo.Member previous) { }

	// RVA: 0x1E27A20 Offset: 0x1E26020 VA: 0x181E27A20 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E27250 Offset: 0x1E25850 VA: 0x181E27250
	public static AppTeamInfo.Member Deserialize(byte[] buffer, AppTeamInfo.Member instance, bool isDelta = False) { }

	// RVA: 0x1E26F20 Offset: 0x1E25520 VA: 0x181E26F20
	public static AppTeamInfo.Member Deserialize(Stream stream, AppTeamInfo.Member instance, bool isDelta) { }

	// RVA: 0x1E25EE0 Offset: 0x1E244E0 VA: 0x181E25EE0
	public static AppTeamInfo.Member DeserializeLengthDelimited(Stream stream, AppTeamInfo.Member instance, bool isDelta) { }

	// RVA: 0x1E26380 Offset: 0x1E24980 VA: 0x181E26380
	public static AppTeamInfo.Member DeserializeLength(Stream stream, int length, AppTeamInfo.Member instance, bool isDelta) { }

	// RVA: 0x1E27C40 Offset: 0x1E26240 VA: 0x181E27C40
	public static void SerializeDelta(Stream stream, AppTeamInfo.Member instance, AppTeamInfo.Member previous) { }

	// RVA: 0x1E281B0 Offset: 0x1E267B0 VA: 0x181E281B0
	public static void Serialize(Stream stream, AppTeamInfo.Member instance) { }

	// RVA: 0x1E28410 Offset: 0x1E26A10 VA: 0x181E28410
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E28420 Offset: 0x1E26A20 VA: 0x181E28420
	public void ToProto(Stream stream) { }

	// RVA: 0x1E280A0 Offset: 0x1E266A0 VA: 0x181E280A0
	public static byte[] SerializeToBytes(AppTeamInfo.Member instance) { }

	// RVA: 0x1E27FF0 Offset: 0x1E265F0 VA: 0x181E27FF0
	public static void SerializeLengthDelimited(Stream stream, AppTeamInfo.Member instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x1E29650 Offset: 0x1E27C50 VA: 0x181E29650
	public static void ResetToPool(AppTeamInfo.Note instance) { }

	// RVA: 0x1E296E0 Offset: 0x1E27CE0 VA: 0x181E296E0
	public void ResetToPool() { }

	// RVA: 0x1E29400 Offset: 0x1E27A00 VA: 0x181E29400 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E28460 Offset: 0x1E26A60 VA: 0x181E28460
	public void CopyTo(AppTeamInfo.Note instance) { }

	// RVA: 0x1E28490 Offset: 0x1E26A90 VA: 0x181E28490
	public AppTeamInfo.Note Copy() { }

	// RVA: 0x1E29210 Offset: 0x1E27810 VA: 0x181E29210
	public static AppTeamInfo.Note Deserialize(Stream stream) { }

	// RVA: 0x1E28510 Offset: 0x1E26B10 VA: 0x181E28510
	public static AppTeamInfo.Note DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E28A90 Offset: 0x1E27090 VA: 0x181E28A90
	public static AppTeamInfo.Note DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E28F60 Offset: 0x1E27560 VA: 0x181E28F60
	public static AppTeamInfo.Note Deserialize(byte[] buffer) { }

	// RVA: 0x1E29480 Offset: 0x1E27A80 VA: 0x181E29480
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E29C50 Offset: 0x1E28250 VA: 0x181E29C50 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E29C70 Offset: 0x1E28270 VA: 0x181E29C70 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppTeamInfo.Note previous) { }

	// RVA: 0x1E29630 Offset: 0x1E27C30 VA: 0x181E29630 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E28B20 Offset: 0x1E27120 VA: 0x181E28B20
	public static AppTeamInfo.Note Deserialize(byte[] buffer, AppTeamInfo.Note instance, bool isDelta = False) { }

	// RVA: 0x1E28DB0 Offset: 0x1E273B0 VA: 0x181E28DB0
	public static AppTeamInfo.Note Deserialize(Stream stream, AppTeamInfo.Note instance, bool isDelta) { }

	// RVA: 0x1E28590 Offset: 0x1E26B90 VA: 0x181E28590
	public static AppTeamInfo.Note DeserializeLengthDelimited(Stream stream, AppTeamInfo.Note instance, bool isDelta) { }

	// RVA: 0x1E28820 Offset: 0x1E26E20 VA: 0x181E28820
	public static AppTeamInfo.Note DeserializeLength(Stream stream, int length, AppTeamInfo.Note instance, bool isDelta) { }

	// RVA: 0x1E29770 Offset: 0x1E27D70 VA: 0x181E29770
	public static void SerializeDelta(Stream stream, AppTeamInfo.Note instance, AppTeamInfo.Note previous) { }

	// RVA: 0x1E29B10 Offset: 0x1E28110 VA: 0x181E29B10
	public static void Serialize(Stream stream, AppTeamInfo.Note instance) { }

	// RVA: 0x1E29C40 Offset: 0x1E28240 VA: 0x181E29C40
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E29C50 Offset: 0x1E28250 VA: 0x181E29C50
	public void ToProto(Stream stream) { }

	// RVA: 0x1E29A00 Offset: 0x1E28000 VA: 0x181E29A00
	public static byte[] SerializeToBytes(AppTeamInfo.Note instance) { }

	// RVA: 0x1E29950 Offset: 0x1E27F50 VA: 0x181E29950
	public static void SerializeLengthDelimited(Stream stream, AppTeamInfo.Note instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x2017E60 Offset: 0x2016460 VA: 0x182017E60
	public static void ResetToPool(AppChatMessage instance) { }

	// RVA: 0x2017F70 Offset: 0x2016570 VA: 0x182017F70
	public void ResetToPool() { }

	// RVA: 0x2017A40 Offset: 0x2016040 VA: 0x182017A40 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2016590 Offset: 0x2014B90 VA: 0x182016590
	public void CopyTo(AppChatMessage instance) { }

	// RVA: 0x2016600 Offset: 0x2014C00 VA: 0x182016600
	public AppChatMessage Copy() { }

	// RVA: 0x2017780 Offset: 0x2015D80 VA: 0x182017780
	public static AppChatMessage Deserialize(Stream stream) { }

	// RVA: 0x2016A00 Offset: 0x2015000 VA: 0x182016A00
	public static AppChatMessage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2016A80 Offset: 0x2015080 VA: 0x182016A80
	public static AppChatMessage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2016E40 Offset: 0x2015440 VA: 0x182016E40
	public static AppChatMessage Deserialize(byte[] buffer) { }

	// RVA: 0x2017BD0 Offset: 0x20161D0 VA: 0x182017BD0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2018870 Offset: 0x2016E70 VA: 0x182018870 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2018890 Offset: 0x2016E90 VA: 0x182018890 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppChatMessage previous) { }

	// RVA: 0x2017E40 Offset: 0x2016440 VA: 0x182017E40 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2017430 Offset: 0x2015A30 VA: 0x182017430
	public static AppChatMessage Deserialize(byte[] buffer, AppChatMessage instance, bool isDelta = False) { }

	// RVA: 0x20171B0 Offset: 0x20157B0 VA: 0x1820171B0
	public static AppChatMessage Deserialize(Stream stream, AppChatMessage instance, bool isDelta) { }

	// RVA: 0x20166B0 Offset: 0x2014CB0 VA: 0x1820166B0
	public static AppChatMessage DeserializeLengthDelimited(Stream stream, AppChatMessage instance, bool isDelta) { }

	// RVA: 0x2016B10 Offset: 0x2015110 VA: 0x182016B10
	public static AppChatMessage DeserializeLength(Stream stream, int length, AppChatMessage instance, bool isDelta) { }

	// RVA: 0x2018080 Offset: 0x2016680 VA: 0x182018080
	public static void SerializeDelta(Stream stream, AppChatMessage instance, AppChatMessage previous) { }

	// RVA: 0x20185A0 Offset: 0x2016BA0 VA: 0x1820185A0
	public static void Serialize(Stream stream, AppChatMessage instance) { }

	// RVA: 0x2018860 Offset: 0x2016E60 VA: 0x182018860
	public byte[] ToProtoBytes() { }

	// RVA: 0x2018870 Offset: 0x2016E70 VA: 0x182018870
	public void ToProto(Stream stream) { }

	// RVA: 0x2018490 Offset: 0x2016A90 VA: 0x182018490
	public static byte[] SerializeToBytes(AppChatMessage instance) { }

	// RVA: 0x20183E0 Offset: 0x20169E0 VA: 0x1820183E0
	public static void SerializeLengthDelimited(Stream stream, AppChatMessage instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class AppTeamChat : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6533
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<AppChatMessage> messages; // 0x18

	// Methods

	// RVA: 0x1E1D500 Offset: 0x1E1BB00 VA: 0x181E1D500
	public static void ResetToPool(AppTeamChat instance) { }

	// RVA: 0x1E1D350 Offset: 0x1E1B950 VA: 0x181E1D350
	public void ResetToPool() { }

	// RVA: 0x1E1D290 Offset: 0x1E1B890 VA: 0x181E1D290 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E1C6E0 Offset: 0x1E1ACE0 VA: 0x181E1C6E0
	public void CopyTo(AppTeamChat instance) { }

	// RVA: 0x1E1C810 Offset: 0x1E1AE10 VA: 0x181E1C810
	public AppTeamChat Copy() { }

	// RVA: 0x1E1D0F0 Offset: 0x1E1B6F0 VA: 0x181E1D0F0
	public static AppTeamChat Deserialize(Stream stream) { }

	// RVA: 0x1E1C890 Offset: 0x1E1AE90 VA: 0x181E1C890
	public static AppTeamChat DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E1CDD0 Offset: 0x1E1B3D0 VA: 0x181E1CDD0
	public static AppTeamChat DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E1D170 Offset: 0x1E1B770 VA: 0x181E1D170
	public static AppTeamChat Deserialize(byte[] buffer) { }

	// RVA: 0x1E1D310 Offset: 0x1E1B910 VA: 0x181E1D310
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E1DC40 Offset: 0x1E1C240 VA: 0x181E1DC40 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E1DC60 Offset: 0x1E1C260 VA: 0x181E1DC60 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppTeamChat previous) { }

	// RVA: 0x1E1D330 Offset: 0x1E1B930 VA: 0x181E1D330 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E1CE60 Offset: 0x1E1B460 VA: 0x181E1CE60
	public static AppTeamChat Deserialize(byte[] buffer, AppTeamChat instance, bool isDelta = False) { }

	// RVA: 0x1E1CF60 Offset: 0x1E1B560 VA: 0x181E1CF60
	public static AppTeamChat Deserialize(Stream stream, AppTeamChat instance, bool isDelta) { }

	// RVA: 0x1E1C910 Offset: 0x1E1AF10 VA: 0x181E1C910
	public static AppTeamChat DeserializeLengthDelimited(Stream stream, AppTeamChat instance, bool isDelta) { }

	// RVA: 0x1E1CB80 Offset: 0x1E1B180 VA: 0x181E1CB80
	public static AppTeamChat DeserializeLength(Stream stream, int length, AppTeamChat instance, bool isDelta) { }

	// RVA: 0x1E1D6B0 Offset: 0x1E1BCB0 VA: 0x181E1D6B0
	public static void SerializeDelta(Stream stream, AppTeamChat instance, AppTeamChat previous) { }

	// RVA: 0x1E1DA50 Offset: 0x1E1C050 VA: 0x181E1DA50
	public static void Serialize(Stream stream, AppTeamChat instance) { }

	// RVA: 0x1E1DC30 Offset: 0x1E1C230 VA: 0x181E1DC30
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E1DC40 Offset: 0x1E1C240 VA: 0x181E1DC40
	public void ToProto(Stream stream) { }

	// RVA: 0x1E1D940 Offset: 0x1E1BF40 VA: 0x181E1D940
	public static byte[] SerializeToBytes(AppTeamChat instance) { }

	// RVA: 0x1E1D890 Offset: 0x1E1BE90 VA: 0x181E1D890
	public static void SerializeLengthDelimited(Stream stream, AppTeamChat instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x20905A0 Offset: 0x208EBA0 VA: 0x1820905A0
	public static void ResetToPool(AppMarker instance) { }

	// RVA: 0x2090300 Offset: 0x208E900 VA: 0x182090300
	public void ResetToPool() { }

	// RVA: 0x2090240 Offset: 0x208E840 VA: 0x182090240 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x208EC50 Offset: 0x208D250 VA: 0x18208EC50
	public void CopyTo(AppMarker instance) { }

	// RVA: 0x208EE60 Offset: 0x208D460 VA: 0x18208EE60
	public AppMarker Copy() { }

	// RVA: 0x20900C0 Offset: 0x208E6C0 VA: 0x1820900C0
	public static AppMarker Deserialize(Stream stream) { }

	// RVA: 0x208F470 Offset: 0x208DA70 VA: 0x18208F470
	public static AppMarker DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x208F4F0 Offset: 0x208DAF0 VA: 0x18208F4F0
	public static AppMarker DeserializeLength(Stream stream, int length) { }

	// RVA: 0x208FAE0 Offset: 0x208E0E0 VA: 0x18208FAE0
	public static AppMarker Deserialize(byte[] buffer) { }

	// RVA: 0x20902C0 Offset: 0x208E8C0 VA: 0x1820902C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20916E0 Offset: 0x208FCE0 VA: 0x1820916E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2091700 Offset: 0x208FD00 VA: 0x182091700 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppMarker previous) { }

	// RVA: 0x20902E0 Offset: 0x208E8E0 VA: 0x1820902E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2090140 Offset: 0x208E740 VA: 0x182090140
	public static AppMarker Deserialize(byte[] buffer, AppMarker instance, bool isDelta = False) { }

	// RVA: 0x208FC00 Offset: 0x208E200 VA: 0x18208FC00
	public static AppMarker Deserialize(Stream stream, AppMarker instance, bool isDelta) { }

	// RVA: 0x208EEE0 Offset: 0x208D4E0 VA: 0x18208EEE0
	public static AppMarker DeserializeLengthDelimited(Stream stream, AppMarker instance, bool isDelta) { }

	// RVA: 0x208F580 Offset: 0x208DB80 VA: 0x18208F580
	public static AppMarker DeserializeLength(Stream stream, int length, AppMarker instance, bool isDelta) { }

	// RVA: 0x2090840 Offset: 0x208EE40 VA: 0x182090840
	public static void SerializeDelta(Stream stream, AppMarker instance, AppMarker previous) { }

	// RVA: 0x20911A0 Offset: 0x208F7A0 VA: 0x1820911A0
	public static void Serialize(Stream stream, AppMarker instance) { }

	// RVA: 0x20916D0 Offset: 0x208FCD0 VA: 0x1820916D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20916E0 Offset: 0x208FCE0 VA: 0x1820916E0
	public void ToProto(Stream stream) { }

	// RVA: 0x2091090 Offset: 0x208F690 VA: 0x182091090
	public static byte[] SerializeToBytes(AppMarker instance) { }

	// RVA: 0x2090FE0 Offset: 0x208F5E0 VA: 0x182090FE0
	public static void SerializeLengthDelimited(Stream stream, AppMarker instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x2099070 Offset: 0x2097670 VA: 0x182099070
	public static void ResetToPool(AppMarker.SellOrder instance) { }

	// RVA: 0x2098F80 Offset: 0x2097580 VA: 0x182098F80
	public void ResetToPool() { }

	// RVA: 0x2098B80 Offset: 0x2097180 VA: 0x182098B80 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2097140 Offset: 0x2095740 VA: 0x182097140
	public void CopyTo(AppMarker.SellOrder instance) { }

	// RVA: 0x2097190 Offset: 0x2095790 VA: 0x182097190
	public AppMarker.SellOrder Copy() { }

	// RVA: 0x2097BA0 Offset: 0x20961A0 VA: 0x182097BA0
	public static AppMarker.SellOrder Deserialize(Stream stream) { }

	// RVA: 0x2097230 Offset: 0x2095830 VA: 0x182097230
	public static AppMarker.SellOrder DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2097B10 Offset: 0x2096110 VA: 0x182097B10
	public static AppMarker.SellOrder DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2098700 Offset: 0x2096D00 VA: 0x182098700
	public static AppMarker.SellOrder Deserialize(byte[] buffer) { }

	// RVA: 0x2098C00 Offset: 0x2097200 VA: 0x182098C00
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20998C0 Offset: 0x2097EC0 VA: 0x1820998C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20998E0 Offset: 0x2097EE0 VA: 0x1820998E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppMarker.SellOrder previous) { }

	// RVA: 0x2098F60 Offset: 0x2097560 VA: 0x182098F60 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20982A0 Offset: 0x20968A0 VA: 0x1820982A0
	public static AppMarker.SellOrder Deserialize(byte[] buffer, AppMarker.SellOrder instance, bool isDelta = False) { }

	// RVA: 0x2097F40 Offset: 0x2096540 VA: 0x182097F40
	public static AppMarker.SellOrder Deserialize(Stream stream, AppMarker.SellOrder instance, bool isDelta) { }

	// RVA: 0x20972B0 Offset: 0x20958B0 VA: 0x1820972B0
	public static AppMarker.SellOrder DeserializeLengthDelimited(Stream stream, AppMarker.SellOrder instance, bool isDelta) { }

	// RVA: 0x20976F0 Offset: 0x2095CF0 VA: 0x1820976F0
	public static AppMarker.SellOrder DeserializeLength(Stream stream, int length, AppMarker.SellOrder instance, bool isDelta) { }

	// RVA: 0x2099160 Offset: 0x2097760 VA: 0x182099160
	public static void SerializeDelta(Stream stream, AppMarker.SellOrder instance, AppMarker.SellOrder previous) { }

	// RVA: 0x20996B0 Offset: 0x2097CB0 VA: 0x1820996B0
	public static void Serialize(Stream stream, AppMarker.SellOrder instance) { }

	// RVA: 0x20998B0 Offset: 0x2097EB0 VA: 0x1820998B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20998C0 Offset: 0x2097EC0 VA: 0x1820998C0
	public void ToProto(Stream stream) { }

	// RVA: 0x20995A0 Offset: 0x2097BA0 VA: 0x1820995A0
	public static byte[] SerializeToBytes(AppMarker.SellOrder instance) { }

	// RVA: 0x20994F0 Offset: 0x2097AF0 VA: 0x1820994F0
	public static void SerializeLengthDelimited(Stream stream, AppMarker.SellOrder instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class AppMapMarkers : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6536
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<AppMarker> markers; // 0x18

	// Methods

	// RVA: 0x208B6F0 Offset: 0x2089CF0 VA: 0x18208B6F0
	public static void ResetToPool(AppMapMarkers instance) { }

	// RVA: 0x208B8A0 Offset: 0x2089EA0 VA: 0x18208B8A0
	public void ResetToPool() { }

	// RVA: 0x208B470 Offset: 0x2089A70 VA: 0x18208B470 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x208A5E0 Offset: 0x2088BE0 VA: 0x18208A5E0
	public void CopyTo(AppMapMarkers instance) { }

	// RVA: 0x208A770 Offset: 0x2088D70 VA: 0x18208A770
	public AppMapMarkers Copy() { }

	// RVA: 0x208B100 Offset: 0x2089700 VA: 0x18208B100
	public static AppMapMarkers Deserialize(Stream stream) { }

	// RVA: 0x208AC30 Offset: 0x2089230 VA: 0x18208AC30
	public static AppMapMarkers DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x208AF50 Offset: 0x2089550 VA: 0x18208AF50
	public static AppMapMarkers DeserializeLength(Stream stream, int length) { }

	// RVA: 0x208AFE0 Offset: 0x20895E0 VA: 0x18208AFE0
	public static AppMapMarkers Deserialize(byte[] buffer) { }

	// RVA: 0x208B6B0 Offset: 0x2089CB0 VA: 0x18208B6B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x208BFE0 Offset: 0x208A5E0 VA: 0x18208BFE0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x208C000 Offset: 0x208A600 VA: 0x18208C000 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppMapMarkers previous) { }

	// RVA: 0x208B6D0 Offset: 0x2089CD0 VA: 0x18208B6D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x208B180 Offset: 0x2089780 VA: 0x18208B180
	public static AppMapMarkers Deserialize(byte[] buffer, AppMapMarkers instance, bool isDelta = False) { }

	// RVA: 0x208B280 Offset: 0x2089880 VA: 0x18208B280
	public static AppMapMarkers Deserialize(Stream stream, AppMapMarkers instance, bool isDelta) { }

	// RVA: 0x208A960 Offset: 0x2088F60 VA: 0x18208A960
	public static AppMapMarkers DeserializeLengthDelimited(Stream stream, AppMapMarkers instance, bool isDelta) { }

	// RVA: 0x208ACB0 Offset: 0x20892B0 VA: 0x18208ACB0
	public static AppMapMarkers DeserializeLength(Stream stream, int length, AppMapMarkers instance, bool isDelta) { }

	// RVA: 0x208BA50 Offset: 0x208A050 VA: 0x18208BA50
	public static void SerializeDelta(Stream stream, AppMapMarkers instance, AppMapMarkers previous) { }

	// RVA: 0x208BDF0 Offset: 0x208A3F0 VA: 0x18208BDF0
	public static void Serialize(Stream stream, AppMapMarkers instance) { }

	// RVA: 0x208BFD0 Offset: 0x208A5D0 VA: 0x18208BFD0
	public byte[] ToProtoBytes() { }

	// RVA: 0x208BFE0 Offset: 0x208A5E0 VA: 0x18208BFE0
	public void ToProto(Stream stream) { }

	// RVA: 0x208BCE0 Offset: 0x208A2E0 VA: 0x18208BCE0
	public static byte[] SerializeToBytes(AppMapMarkers instance) { }

	// RVA: 0x208BC30 Offset: 0x208A230 VA: 0x18208BC30
	public static void SerializeLengthDelimited(Stream stream, AppMapMarkers instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class AppTeamChanged : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6537
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong playerId; // 0x18
	public AppTeamInfo teamInfo; // 0x20

	// Methods

	// RVA: 0x1E1BFD0 Offset: 0x1E1A5D0 VA: 0x181E1BFD0
	public static void ResetToPool(AppTeamChanged instance) { }

	// RVA: 0x1E1BF20 Offset: 0x1E1A520 VA: 0x181E1BF20
	public void ResetToPool() { }

	// RVA: 0x1E1BDB0 Offset: 0x1E1A3B0 VA: 0x181E1BDB0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E1B140 Offset: 0x1E19740 VA: 0x181E1B140
	public void CopyTo(AppTeamChanged instance) { }

	// RVA: 0x1E1B1C0 Offset: 0x1E197C0 VA: 0x181E1B1C0
	public AppTeamChanged Copy() { }

	// RVA: 0x1E1B910 Offset: 0x1E19F10 VA: 0x181E1B910
	public static AppTeamChanged Deserialize(Stream stream) { }

	// RVA: 0x1E1B290 Offset: 0x1E19890 VA: 0x181E1B290
	public static AppTeamChanged DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E1B5E0 Offset: 0x1E19BE0 VA: 0x181E1B5E0
	public static AppTeamChanged DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E1BB90 Offset: 0x1E1A190 VA: 0x181E1BB90
	public static AppTeamChanged Deserialize(byte[] buffer) { }

	// RVA: 0x1E1BEE0 Offset: 0x1E1A4E0 VA: 0x181E1BEE0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E1C6A0 Offset: 0x1E1ACA0 VA: 0x181E1C6A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E1C6C0 Offset: 0x1E1ACC0 VA: 0x181E1C6C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppTeamChanged previous) { }

	// RVA: 0x1E1BF00 Offset: 0x1E1A500 VA: 0x181E1BF00 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E1BCB0 Offset: 0x1E1A2B0 VA: 0x181E1BCB0
	public static AppTeamChanged Deserialize(byte[] buffer, AppTeamChanged instance, bool isDelta = False) { }

	// RVA: 0x1E1B990 Offset: 0x1E19F90 VA: 0x181E1B990
	public static AppTeamChanged Deserialize(Stream stream, AppTeamChanged instance, bool isDelta) { }

	// RVA: 0x1E1B310 Offset: 0x1E19910 VA: 0x181E1B310
	public static AppTeamChanged DeserializeLengthDelimited(Stream stream, AppTeamChanged instance, bool isDelta) { }

	// RVA: 0x1E1B670 Offset: 0x1E19C70 VA: 0x181E1B670
	public static AppTeamChanged DeserializeLength(Stream stream, int length, AppTeamChanged instance, bool isDelta) { }

	// RVA: 0x1E1C080 Offset: 0x1E1A680 VA: 0x181E1C080
	public static void SerializeDelta(Stream stream, AppTeamChanged instance, AppTeamChanged previous) { }

	// RVA: 0x1E1C480 Offset: 0x1E1AA80 VA: 0x181E1C480
	public static void Serialize(Stream stream, AppTeamChanged instance) { }

	// RVA: 0x1E1C690 Offset: 0x1E1AC90 VA: 0x181E1C690
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E1C6A0 Offset: 0x1E1ACA0 VA: 0x181E1C6A0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E1C370 Offset: 0x1E1A970 VA: 0x181E1C370
	public static byte[] SerializeToBytes(AppTeamChanged instance) { }

	// RVA: 0x1E1C2C0 Offset: 0x1E1A8C0 VA: 0x181E1C2C0
	public static void SerializeLengthDelimited(Stream stream, AppTeamChanged instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class AppTeamMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6538
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public AppChatMessage message; // 0x18

	// Methods

	// RVA: 0x1E21350 Offset: 0x1E1F950 VA: 0x181E21350
	public static void ResetToPool(AppTeamMessage instance) { }

	// RVA: 0x1E212B0 Offset: 0x1E1F8B0 VA: 0x181E212B0
	public void ResetToPool() { }

	// RVA: 0x1E21150 Offset: 0x1E1F750 VA: 0x181E21150 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E206B0 Offset: 0x1E1ECB0 VA: 0x181E206B0
	public void CopyTo(AppTeamMessage instance) { }

	// RVA: 0x1E20720 Offset: 0x1E1ED20 VA: 0x181E20720
	public AppTeamMessage Copy() { }

	// RVA: 0x1E210D0 Offset: 0x1E1F6D0 VA: 0x181E210D0
	public static AppTeamMessage Deserialize(Stream stream) { }

	// RVA: 0x1E207F0 Offset: 0x1E1EDF0 VA: 0x181E207F0
	public static AppTeamMessage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E20CC0 Offset: 0x1E1F2C0 VA: 0x181E20CC0
	public static AppTeamMessage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E20E50 Offset: 0x1E1F450 VA: 0x181E20E50
	public static AppTeamMessage Deserialize(byte[] buffer) { }

	// RVA: 0x1E21270 Offset: 0x1E1F870 VA: 0x181E21270
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E21960 Offset: 0x1E1FF60 VA: 0x181E21960 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E21980 Offset: 0x1E1FF80 VA: 0x181E21980 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppTeamMessage previous) { }

	// RVA: 0x1E21290 Offset: 0x1E1F890 VA: 0x181E21290 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E20D50 Offset: 0x1E1F350 VA: 0x181E20D50
	public static AppTeamMessage Deserialize(byte[] buffer, AppTeamMessage instance, bool isDelta = False) { }

	// RVA: 0x1E20F70 Offset: 0x1E1F570 VA: 0x181E20F70
	public static AppTeamMessage Deserialize(Stream stream, AppTeamMessage instance, bool isDelta) { }

	// RVA: 0x1E20870 Offset: 0x1E1EE70 VA: 0x181E20870
	public static AppTeamMessage DeserializeLengthDelimited(Stream stream, AppTeamMessage instance, bool isDelta) { }

	// RVA: 0x1E20AB0 Offset: 0x1E1F0B0 VA: 0x181E20AB0
	public static AppTeamMessage DeserializeLength(Stream stream, int length, AppTeamMessage instance, bool isDelta) { }

	// RVA: 0x1E213F0 Offset: 0x1E1F9F0 VA: 0x181E213F0
	public static void SerializeDelta(Stream stream, AppTeamMessage instance, AppTeamMessage previous) { }

	// RVA: 0x1E21790 Offset: 0x1E1FD90 VA: 0x181E21790
	public static void Serialize(Stream stream, AppTeamMessage instance) { }

	// RVA: 0x1E21950 Offset: 0x1E1FF50 VA: 0x181E21950
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E21960 Offset: 0x1E1FF60 VA: 0x181E21960
	public void ToProto(Stream stream) { }

	// RVA: 0x1E21680 Offset: 0x1E1FC80 VA: 0x181E21680
	public static byte[] SerializeToBytes(AppTeamMessage instance) { }

	// RVA: 0x1E215D0 Offset: 0x1E1FBD0 VA: 0x181E215D0
	public static void SerializeLengthDelimited(Stream stream, AppTeamMessage instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class AppEntityChanged : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6539
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint entityId; // 0x14
	public AppEntityPayload payload; // 0x18

	// Methods

	// RVA: 0x20817F0 Offset: 0x207FDF0 VA: 0x1820817F0
	public static void ResetToPool(AppEntityChanged instance) { }

	// RVA: 0x2081740 Offset: 0x207FD40 VA: 0x182081740
	public void ResetToPool() { }

	// RVA: 0x20815D0 Offset: 0x207FBD0 VA: 0x1820815D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2080960 Offset: 0x207EF60 VA: 0x182080960
	public void CopyTo(AppEntityChanged instance) { }

	// RVA: 0x20809E0 Offset: 0x207EFE0 VA: 0x1820809E0
	public AppEntityChanged Copy() { }

	// RVA: 0x2081230 Offset: 0x207F830 VA: 0x182081230
	public static AppEntityChanged Deserialize(Stream stream) { }

	// RVA: 0x2080D80 Offset: 0x207F380 VA: 0x182080D80
	public static AppEntityChanged DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20810A0 Offset: 0x207F6A0 VA: 0x1820810A0
	public static AppEntityChanged DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20814B0 Offset: 0x207FAB0 VA: 0x1820814B0
	public static AppEntityChanged Deserialize(byte[] buffer) { }

	// RVA: 0x2081700 Offset: 0x207FD00 VA: 0x182081700
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2081EB0 Offset: 0x20804B0 VA: 0x182081EB0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2081ED0 Offset: 0x20804D0 VA: 0x182081ED0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppEntityChanged previous) { }

	// RVA: 0x2081720 Offset: 0x207FD20 VA: 0x182081720 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2081130 Offset: 0x207F730 VA: 0x182081130
	public static AppEntityChanged Deserialize(byte[] buffer, AppEntityChanged instance, bool isDelta = False) { }

	// RVA: 0x20812B0 Offset: 0x207F8B0 VA: 0x1820812B0
	public static AppEntityChanged Deserialize(Stream stream, AppEntityChanged instance, bool isDelta) { }

	// RVA: 0x2080AB0 Offset: 0x207F0B0 VA: 0x182080AB0
	public static AppEntityChanged DeserializeLengthDelimited(Stream stream, AppEntityChanged instance, bool isDelta) { }

	// RVA: 0x2080E00 Offset: 0x207F400 VA: 0x182080E00
	public static AppEntityChanged DeserializeLength(Stream stream, int length, AppEntityChanged instance, bool isDelta) { }

	// RVA: 0x20818A0 Offset: 0x207FEA0 VA: 0x1820818A0
	public static void SerializeDelta(Stream stream, AppEntityChanged instance, AppEntityChanged previous) { }

	// RVA: 0x2081C90 Offset: 0x2080290 VA: 0x182081C90
	public static void Serialize(Stream stream, AppEntityChanged instance) { }

	// RVA: 0x2081EA0 Offset: 0x20804A0 VA: 0x182081EA0
	public byte[] ToProtoBytes() { }

	// RVA: 0x2081EB0 Offset: 0x20804B0 VA: 0x182081EB0
	public void ToProto(Stream stream) { }

	// RVA: 0x2081B80 Offset: 0x2080180 VA: 0x182081B80
	public static byte[] SerializeToBytes(AppEntityChanged instance) { }

	// RVA: 0x2081AD0 Offset: 0x20800D0 VA: 0x182081AD0
	public static void SerializeLengthDelimited(Stream stream, AppEntityChanged instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x1B9D5F0 Offset: 0x1B9BBF0 VA: 0x181B9D5F0
	public static void Quit() { }

	// RVA: 0x1B9D660 Offset: 0x1B9BC60 VA: 0x181B9D660
	public static string get_installPath() { }

	// RVA: 0x1B9D650 Offset: 0x1B9BC50 VA: 0x181B9D650
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
	// RVA: 0x8C1080 Offset: 0x8BF680 VA: 0x1808C1080
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
	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public ulong get_WorkshopdId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE72CC0 Offset: 0xE712C0 VA: 0x180E72CC0
	private void set_WorkshopdId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA38CE0 Offset: 0xA372E0 VA: 0x180A38CE0
	internal Price get_Price() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA392A0 Offset: 0xA378A0 VA: 0x180A392A0
	private void set_Price(Price value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xBA1A80 Offset: 0xBA0080 VA: 0x180BA1A80
	public bool get_Tradable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE72CB0 Offset: 0xE712B0 VA: 0x180E72CB0
	private void set_Tradable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6BB940 Offset: 0x6B9F40 VA: 0x1806BB940
	public DropChance get_DropChance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC74910 Offset: 0xC72F10 VA: 0x180C74910
	private void set_DropChance(DropChance value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC659E0 Offset: 0xC63FE0 VA: 0x180C659E0
	public bool get_Marketable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE72CA0 Offset: 0xE712A0 VA: 0x180E72CA0
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
	// RVA: 0xBA1AA0 Offset: 0xBA00A0 VA: 0x180BA1AA0
	public bool get_IsLimitedTimeOffer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x82D7F0 Offset: 0x82BDF0 VA: 0x18082D7F0
	private void set_IsLimitedTimeOffer(bool value) { }

	// RVA: 0xE72240 Offset: 0xE70840 VA: 0x180E72240
	public void .ctor(ulong WorkshopdId, string Name, string Desc, string ItemName) { }

	// RVA: 0xE72210 Offset: 0xE70810 VA: 0x180E72210
	public ApprovedSkinInfo Store(Price Price, bool CanBeTraded, bool CanBeSold) { }

	// RVA: 0xE72220 Offset: 0xE70820 VA: 0x180E72220
	public ApprovedSkinInfo TimeLimited() { }

	// RVA: 0xE72230 Offset: 0xE70830 VA: 0x180E72230
	public ApprovedSkinInfo Unlimited() { }

	// RVA: 0xE72200 Offset: 0xE70800 VA: 0x180E72200
	public ApprovedSkinInfo NoCrate() { }

	// RVA: 0xE721E0 Offset: 0xE707E0 VA: 0x180E721E0
	public ApprovedSkinInfo Drops(DropChance DropChance) { }

	// RVA: 0xE721F0 Offset: 0xE707F0 VA: 0x180E721F0
	public ApprovedSkinInfo ItemId(ulong InventoryId) { }

	// RVA: 0xE723F0 Offset: 0xE709F0 VA: 0x180E723F0
	public static ItemSchema.Item op_Implicit(ApprovedSkinInfo o) { }

}

private sealed class ApprovedSkinInfo.<>c__DisplayClass44_0 // TypeDefIndex: 7739
{	// Fields
	public string ItemName; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xE80820 Offset: 0xE7EE20 VA: 0x180E80820
	internal bool <.ctor>b__0(Skinnable x) { }

}

public abstract class AppIOEntity : IOEntity // TypeDefIndex: 8306
{	// Fields
	private Option __menuOption_Menu_Pair; // 0x288

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x82AD70 Offset: 0x829370 VA: 0x18082AD70 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x82B2C0 Offset: 0x8298C0 VA: 0x18082B2C0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x82B170 Offset: 0x829770 VA: 0x18082B170 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0xB0520 Offset: 0xAF920 VA: 0x1800B0520
	[BaseEntity.Menu.Description] // RVA: 0xB0520 Offset: 0xAF920 VA: 0x1800B0520
	[BaseEntity.Menu.Icon] // RVA: 0xB0520 Offset: 0xAF920 VA: 0x1800B0520
	[BaseEntity.Menu.ShowIf] // RVA: 0xB0520 Offset: 0xAF920 VA: 0x1800B0520
	// RVA: 0x82B0D0 Offset: 0x8296D0 VA: 0x18082B0D0
	public void Menu_Pair(BasePlayer player) { }

	// RVA: 0x82B110 Offset: 0x829710 VA: 0x18082B110
	public bool Menu_ShowIf(BasePlayer player) { }

	// RVA: 0x82B260 Offset: 0x829860 VA: 0x18082B260
	protected void .ctor() { }

}

public class ApplyTerrainAnchors : MonoBehaviour // TypeDefIndex: 10373
{	// Methods

	// RVA: 0x82B3D0 Offset: 0x8299D0 VA: 0x18082B3D0
	protected void Awake() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ApplyTerrainModifiers : MonoBehaviour // TypeDefIndex: 10574
{	// Methods

	// RVA: 0x82B4D0 Offset: 0x829AD0 VA: 0x18082B4D0
	protected void Awake() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ApplyTweakUIChanges : MonoBehaviour // TypeDefIndex: 11135
{	// Fields
	public Button ApplyButton; // 0x18
	public TweakUIBase[] Options; // 0x20

	// Methods

	// RVA: 0x82B6B0 Offset: 0x829CB0 VA: 0x18082B6B0
	private void OnEnable() { }

	// RVA: 0x82B5D0 Offset: 0x829BD0 VA: 0x18082B5D0
	public void Apply() { }

	// RVA: 0x82B740 Offset: 0x829D40 VA: 0x18082B740
	public void SetDirty() { }

	// RVA: 0x82B6C0 Offset: 0x829CC0 VA: 0x18082B6C0
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

	// RVA: 0x6CAE20 Offset: 0x6C9420 VA: 0x1806CAE20
	public void .ctor() { }

	// RVA: 0x6CAD20 Offset: 0x6C9320 VA: 0x1806CAD20
	private static void .cctor() { }

}

