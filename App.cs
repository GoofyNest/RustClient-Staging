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
	[ThreadStaticAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static Dictionary<string, object> type_resolve_in_progress; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static Dictionary<string, object> assembly_resolve_in_progress; // 0x80000008
	[ThreadStaticAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static Dictionary<string, object> assembly_resolve_in_progress_refonly; // 0x80000010
	private object _evidence; // 0x20
	private object _granted; // 0x28
	private int _principalPolicy; // 0x30
	[ThreadStaticAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static object _principal; // 0x80000018
	private static AppDomain default_domain; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private AssemblyLoadEventHandler AssemblyLoad; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ResolveEventHandler AssemblyResolve; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private EventHandler DomainUnload; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private EventHandler ProcessExit; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ResolveEventHandler ResourceResolve; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ResolveEventHandler TypeResolve; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private UnhandledExceptionEventHandler UnhandledException; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private EventHandler<FirstChanceExceptionEventArgs> FirstChanceException; // 0x70
	private object _domain_manager; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	[ObsoleteAttribute] // RVA: 0x8C780 Offset: 0x8BB80 VA: 0x18008C780
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

	[ObsoleteAttribute] // RVA: 0x8C970 Offset: 0x8BD70 VA: 0x18008C970
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

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1553410 Offset: 0x1551A10 VA: 0x181553410 Slot: 13
	public void add_DomainUnload(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1553650 Offset: 0x1551C50 VA: 0x181553650 Slot: 14
	public void remove_DomainUnload(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x15534B0 Offset: 0x1551AB0 VA: 0x1815534B0 Slot: 15
	public void add_ProcessExit(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x15536F0 Offset: 0x1551CF0 VA: 0x1815536F0 Slot: 16
	public void remove_ProcessExit(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1553550 Offset: 0x1551B50 VA: 0x181553550 Slot: 17
	public void add_UnhandledException(UnhandledExceptionEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private static Application.LowMemoryCallback lowMemory; // 0x0
	private static Application.LogCallback s_LogCallbackHandler; // 0x8
	private static Application.LogCallback s_LogCallbackHandlerThreaded; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	[DebuggerBrowsableAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	private static Action<bool> focusChanged; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	[DebuggerBrowsableAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	private static Action<string> deepLinkActivated; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	[DebuggerBrowsableAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	private static Func<bool> wantsToQuit; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	[DebuggerBrowsableAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	private static Action quitting; // 0x30

	// Properties
	public static bool isPlaying { get; }
	public static string dataPath { get; }
	public static string streamingAssetsPath { get; }
	[SecurityCriticalAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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
	[ObsoleteAttribute] // RVA: 0x75840 Offset: 0x74C40 VA: 0x180075840
	public static string loadedLevelName { get; }
	public static bool isEditor { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0x70DC0 Offset: 0x701C0 VA: 0x180070DC0
	// RVA: 0x181D230 Offset: 0x181B830 VA: 0x18181D230
	public static void Quit(int exitCode) { }

	// RVA: 0x181D270 Offset: 0x181B870 VA: 0x18181D270
	public static void Quit() { }

	[FreeFunctionAttribute] // RVA: 0x70FA0 Offset: 0x703A0 VA: 0x180070FA0
	// RVA: 0x181CEE0 Offset: 0x181B4E0 VA: 0x18181CEE0
	public static bool CanStreamedLevelBeLoaded(string levelName) { }

	[FreeFunctionAttribute] // RVA: 0x710D0 Offset: 0x704D0 VA: 0x1800710D0
	// RVA: 0x181D4F0 Offset: 0x181BAF0 VA: 0x18181D4F0
	public static bool get_isPlaying() { }

	[FreeFunctionAttribute] // RVA: 0x71210 Offset: 0x70610 VA: 0x180071210
	// RVA: 0x181D430 Offset: 0x181BA30 VA: 0x18181D430
	public static string get_dataPath() { }

	[FreeFunctionAttribute] // RVA: 0x712C0 Offset: 0x706C0 VA: 0x1800712C0
	// RVA: 0x181D5A0 Offset: 0x181BBA0 VA: 0x18181D5A0
	public static string get_streamingAssetsPath() { }

	[FreeFunctionAttribute] // RVA: 0x713E0 Offset: 0x707E0 VA: 0x1800713E0
	// RVA: 0x181D540 Offset: 0x181BB40 VA: 0x18181D540
	public static string get_persistentDataPath() { }

	[FreeFunctionAttribute] // RVA: 0x715B0 Offset: 0x709B0 VA: 0x1800715B0
	// RVA: 0x181D630 Offset: 0x181BC30 VA: 0x18181D630
	public static string get_unityVersion() { }

	[FreeFunctionAttribute] // RVA: 0x71730 Offset: 0x70B30 VA: 0x180071730
	// RVA: 0x181D660 Offset: 0x181BC60 VA: 0x18181D660
	public static string get_version() { }

	[FreeFunctionAttribute] // RVA: 0x71850 Offset: 0x70C50 VA: 0x180071850
	// RVA: 0x181D3D0 Offset: 0x181B9D0 VA: 0x18181D3D0
	public static string get_companyName() { }

	[FreeFunctionAttribute] // RVA: 0x71930 Offset: 0x70D30 VA: 0x180071930
	// RVA: 0x181D1F0 Offset: 0x181B7F0 VA: 0x18181D1F0
	public static void OpenURL(string url) { }

	[FreeFunctionAttribute] // RVA: 0x71A10 Offset: 0x70E10 VA: 0x180071A10
	// RVA: 0x181D600 Offset: 0x181BC00 VA: 0x18181D600
	public static int get_targetFrameRate() { }

	[FreeFunctionAttribute] // RVA: 0x71BA0 Offset: 0x70FA0 VA: 0x180071BA0
	// RVA: 0x181D760 Offset: 0x181BD60 VA: 0x18181D760
	public static void set_targetFrameRate(int value) { }

	[FreeFunctionAttribute] // RVA: 0x71D20 Offset: 0x71120 VA: 0x180071D20
	// RVA: 0x181D2A0 Offset: 0x181B8A0 VA: 0x18181D2A0
	private static void SetLogCallbackDefined(bool defined) { }

	[FreeFunctionAttribute] // RVA: 0x71E30 Offset: 0x71230 VA: 0x180071E30
	// RVA: 0x181CF20 Offset: 0x181B520 VA: 0x18181CF20
	public static StackTraceLogType GetStackTraceLogType(LogType logType) { }

	[FreeFunctionAttribute] // RVA: 0x72040 Offset: 0x71440 VA: 0x180072040
	// RVA: 0x181D2E0 Offset: 0x181B8E0 VA: 0x18181D2E0
	public static void SetStackTraceLogType(LogType logType, StackTraceLogType stackTraceType) { }

	[FreeFunctionAttribute] // RVA: 0x72230 Offset: 0x71630 VA: 0x180072230
	// RVA: 0x181D400 Offset: 0x181BA00 VA: 0x18181D400
	public static string get_consoleLogPath() { }

	[FreeFunctionAttribute] // RVA: 0x72310 Offset: 0x71710 VA: 0x180072310
	// RVA: 0x181D720 Offset: 0x181BD20 VA: 0x18181D720
	public static void set_backgroundLoadingPriority(ThreadPriority value) { }

	[FreeFunctionAttribute] // RVA: 0x72420 Offset: 0x71820 VA: 0x180072420
	// RVA: 0x181D570 Offset: 0x181BB70 VA: 0x18181D570
	public static RuntimePlatform get_platform() { }

	// RVA: 0x181D490 Offset: 0x181BA90 VA: 0x18181D490
	public static bool get_isMobilePlatform() { }

	[FreeFunctionAttribute] // RVA: 0x73920 Offset: 0x72D20 VA: 0x180073920
	// RVA: 0x181D5D0 Offset: 0x181BBD0 VA: 0x18181D5D0
	public static SystemLanguage get_systemLanguage() { }

	[FreeFunctionAttribute] // RVA: 0x73AD0 Offset: 0x72ED0 VA: 0x180073AD0
	// RVA: 0x181D460 Offset: 0x181BA60 VA: 0x18181D460
	public static NetworkReachability get_internetReachability() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x181CD00 Offset: 0x181B300 VA: 0x18181CD00
	internal static void CallLowMemory() { }

	// RVA: 0x181D320 Offset: 0x181B920 VA: 0x18181D320
	public static void add_logMessageReceived(Application.LogCallback value) { }

	// RVA: 0x181D690 Offset: 0x181BC90 VA: 0x18181D690
	public static void remove_logMessageReceived(Application.LogCallback value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x181CC40 Offset: 0x181B240 VA: 0x18181CC40
	private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x181CFB0 Offset: 0x181B5B0 VA: 0x18181CFB0
	private static bool Internal_ApplicationWantsToQuit() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x181CF60 Offset: 0x181B560 VA: 0x18181CF60
	private static void Internal_ApplicationQuit() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x181D1A0 Offset: 0x181B7A0 VA: 0x18181D1A0
	internal static void InvokeOnBeforeRender() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x181D140 Offset: 0x181B740 VA: 0x18181D140
	internal static void InvokeFocusChanged(bool focus) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x1831C90 Offset: 0x1830290 VA: 0x181831C90 Slot: 13
	public virtual IAsyncResult BeginInvoke(string condition, string stackTrace, LogType type, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public struct AppId // TypeDefIndex: 5235
{	// Fields
	public uint Value; // 0x0

	// Methods

	// RVA: 0x1D7D40 Offset: 0x1D7140 VA: 0x1801D7D40 Slot: 3
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

	// RVA: 0x1E4470 Offset: 0x1E3870 VA: 0x1801E4470 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E4460 Offset: 0x1E3860 VA: 0x1801E4460 Slot: 4
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

	// RVA: 0x1E4270 Offset: 0x1E3670 VA: 0x1801E4270 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E4260 Offset: 0x1E3660 VA: 0x1801E4260 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136AD30 Offset: 0x1369330 VA: 0x18136AD30
	private static void .cctor() { }

}

public static class Application // TypeDefIndex: 6176
{	// Fields
	private static MonoBehaviour _controller; // 0x0
	public static Manifest Manifest; // 0x8
	public static Dictionary<IPEndPoint, int> ServerMetadata; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static BaseIntegration <Integration>k__BackingField; // 0x18

	// Properties
	public static MonoBehaviour Controller { get; }
	public static BaseIntegration Integration { get; set; }

	// Methods

	// RVA: 0x14A9690 Offset: 0x14A7C90 VA: 0x1814A9690
	public static MonoBehaviour get_Controller() { }

	// RVA: 0x14A9380 Offset: 0x14A7980 VA: 0x1814A9380
	public static void Initialize(BaseIntegration integration) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x14A9790 Offset: 0x14A7D90 VA: 0x1814A9790
	public static BaseIntegration get_Integration() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x1F1040 Offset: 0x1F0440 VA: 0x1801F1040
	public int get_Version() { }

	// RVA: 0x1F0C10 Offset: 0x1F0010 VA: 0x1801F0C10
	public BuildInfo get_Build() { }

	// RVA: 0x1F0EA0 Offset: 0x1F02A0 VA: 0x1801F0EA0
	public string get_Name() { }

	// RVA: 0x1F0EB0 Offset: 0x1F02B0 VA: 0x1801F0EB0
	public string get_Os() { }

	// RVA: 0x1F0C30 Offset: 0x1F0030 VA: 0x1801F0C30
	public string get_Cpu() { }

	// RVA: 0x1F0C20 Offset: 0x1F0020 VA: 0x1801F0C20
	public int get_CpuCount() { }

	// RVA: 0x1F0C40 Offset: 0x1F0040 VA: 0x1801F0C40
	public int get_Mem() { }

	// RVA: 0x1F0C50 Offset: 0x1F0050 VA: 0x1801F0C50
	public string get_Gpu() { }

	// RVA: 0x1F0C40 Offset: 0x1F0040 VA: 0x1801F0C40
	public int get_GpuMem() { }

	// RVA: 0x1F0BD0 Offset: 0x1EFFD0 VA: 0x1801F0BD0
	public string get_Arch() { }

	// RVA: 0x1F0F80 Offset: 0x1F0380 VA: 0x1801F0F80
	public string get_UserId() { }

	// RVA: 0x1F0FE0 Offset: 0x1F03E0 VA: 0x1801F0FE0
	public string get_UserName() { }

	// RVA: 0x1F0EC0 Offset: 0x1F02C0 VA: 0x1801F0EC0
	public string get_ServerAddress() { }

	// RVA: 0x1F0F20 Offset: 0x1F0320 VA: 0x1801F0F20
	public string get_ServerName() { }

	// RVA: 0x1F0C60 Offset: 0x1F0060 VA: 0x1801F0C60
	public string get_LevelName() { }

	// RVA: 0x1F0CC0 Offset: 0x1F00C0 VA: 0x1801F0CC0
	public string get_LevelPos() { }

	// RVA: 0x1F0D80 Offset: 0x1F0180 VA: 0x1801F0D80
	public string get_LevelRot() { }

	// RVA: 0x1F0E40 Offset: 0x1F0240 VA: 0x1801F0E40
	public int get_MinutesPlayed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xFC8C0 Offset: 0xFBCC0 VA: 0x1800FC8C0
	public string get_Image() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF1510 Offset: 0xF0910 VA: 0x1800F1510
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

	// RVA: 0x1E25250 Offset: 0x1E23850 VA: 0x181E25250
	public static void ResetToPool(Approval instance) { }

	// RVA: 0x1E25090 Offset: 0x1E23690 VA: 0x181E25090
	public void ResetToPool() { }

	// RVA: 0x1E24E20 Offset: 0x1E23420 VA: 0x181E24E20 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E23980 Offset: 0x1E21F80 VA: 0x181E23980
	public void CopyTo(Approval instance) { }

	// RVA: 0x1E23A30 Offset: 0x1E22030 VA: 0x181E23A30
	public Approval Copy() { }

	// RVA: 0x1E247F0 Offset: 0x1E22DF0 VA: 0x181E247F0
	public static Approval Deserialize(Stream stream) { }

	// RVA: 0x1E23B20 Offset: 0x1E22120 VA: 0x181E23B20
	public static Approval DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E24110 Offset: 0x1E22710 VA: 0x181E24110
	public static Approval DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E24D00 Offset: 0x1E23300 VA: 0x181E24D00
	public static Approval Deserialize(byte[] buffer) { }

	// RVA: 0x1E25050 Offset: 0x1E23650 VA: 0x181E25050
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E25EC0 Offset: 0x1E244C0 VA: 0x181E25EC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E25EE0 Offset: 0x1E244E0 VA: 0x181E25EE0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Approval previous) { }

	// RVA: 0x1E25070 Offset: 0x1E23670 VA: 0x181E25070 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E246F0 Offset: 0x1E22CF0 VA: 0x181E246F0
	public static Approval Deserialize(byte[] buffer, Approval instance, bool isDelta = False) { }

	// RVA: 0x1E24870 Offset: 0x1E22E70 VA: 0x181E24870
	public static Approval Deserialize(Stream stream, Approval instance, bool isDelta) { }

	// RVA: 0x1E23BA0 Offset: 0x1E221A0 VA: 0x181E23BA0
	public static Approval DeserializeLengthDelimited(Stream stream, Approval instance, bool isDelta) { }

	// RVA: 0x1E241A0 Offset: 0x1E227A0 VA: 0x181E241A0
	public static Approval DeserializeLength(Stream stream, int length, Approval instance, bool isDelta) { }

	// RVA: 0x1E25410 Offset: 0x1E23A10 VA: 0x181E25410
	public static void SerializeDelta(Stream stream, Approval instance, Approval previous) { }

	// RVA: 0x1E25AE0 Offset: 0x1E240E0 VA: 0x181E25AE0
	public static void Serialize(Stream stream, Approval instance) { }

	// RVA: 0x1E25EB0 Offset: 0x1E244B0 VA: 0x181E25EB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E25EC0 Offset: 0x1E244C0 VA: 0x181E25EC0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E259D0 Offset: 0x1E23FD0 VA: 0x181E259D0
	public static byte[] SerializeToBytes(Approval instance) { }

	// RVA: 0x1E25920 Offset: 0x1E23F20 VA: 0x181E25920
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

	// RVA: 0x1E13100 Offset: 0x1E11700 VA: 0x181E13100
	public static void ResetToPool(AppRequest instance) { }

	// RVA: 0x1E12DB0 Offset: 0x1E113B0 VA: 0x181E12DB0
	public void ResetToPool() { }

	// RVA: 0x1E12CF0 Offset: 0x1E112F0 VA: 0x181E12CF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E11230 Offset: 0x1E0F830 VA: 0x181E11230
	public void CopyTo(AppRequest instance) { }

	// RVA: 0x1E11600 Offset: 0x1E0FC00 VA: 0x181E11600
	public AppRequest Copy() { }

	// RVA: 0x1E12A50 Offset: 0x1E11050 VA: 0x181E12A50
	public static AppRequest Deserialize(Stream stream) { }

	// RVA: 0x1E11D10 Offset: 0x1E10310 VA: 0x181E11D10
	public static AppRequest DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E12400 Offset: 0x1E10A00 VA: 0x181E12400
	public static AppRequest DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E12BD0 Offset: 0x1E111D0 VA: 0x181E12BD0
	public static AppRequest Deserialize(byte[] buffer) { }

	// RVA: 0x1E12D70 Offset: 0x1E11370 VA: 0x181E12D70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E150B0 Offset: 0x1E136B0 VA: 0x181E150B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E150D0 Offset: 0x1E136D0 VA: 0x181E150D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppRequest previous) { }

	// RVA: 0x1E12D90 Offset: 0x1E11390 VA: 0x181E12D90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E12AD0 Offset: 0x1E110D0 VA: 0x181E12AD0
	public static AppRequest Deserialize(byte[] buffer, AppRequest instance, bool isDelta = False) { }

	// RVA: 0x1E12490 Offset: 0x1E10A90 VA: 0x181E12490
	public static AppRequest Deserialize(Stream stream, AppRequest instance, bool isDelta) { }

	// RVA: 0x1E11680 Offset: 0x1E0FC80 VA: 0x181E11680
	public static AppRequest DeserializeLengthDelimited(Stream stream, AppRequest instance, bool isDelta) { }

	// RVA: 0x1E11D90 Offset: 0x1E10390 VA: 0x181E11D90
	public static AppRequest DeserializeLength(Stream stream, int length, AppRequest instance, bool isDelta) { }

	// RVA: 0x1E13450 Offset: 0x1E11A50 VA: 0x181E13450
	public static void SerializeDelta(Stream stream, AppRequest instance, AppRequest previous) { }

	// RVA: 0x1E14400 Offset: 0x1E12A00 VA: 0x181E14400
	public static void Serialize(Stream stream, AppRequest instance) { }

	// RVA: 0x1E150A0 Offset: 0x1E136A0 VA: 0x181E150A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E150B0 Offset: 0x1E136B0 VA: 0x181E150B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E142F0 Offset: 0x1E128F0 VA: 0x181E142F0
	public static byte[] SerializeToBytes(AppRequest instance) { }

	// RVA: 0x1E14240 Offset: 0x1E12840 VA: 0x181E14240
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

	// RVA: 0x2092670 Offset: 0x2090C70 VA: 0x182092670
	public static void ResetToPool(AppMessage instance) { }

	// RVA: 0x2092750 Offset: 0x2090D50 VA: 0x182092750
	public void ResetToPool() { }

	// RVA: 0x20924D0 Offset: 0x2090AD0 VA: 0x1820924D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20918E0 Offset: 0x208FEE0 VA: 0x1820918E0
	public void CopyTo(AppMessage instance) { }

	// RVA: 0x20919A0 Offset: 0x208FFA0 VA: 0x1820919A0
	public AppMessage Copy() { }

	// RVA: 0x2092450 Offset: 0x2090A50 VA: 0x182092450
	public static AppMessage Deserialize(Stream stream) { }

	// RVA: 0x2091AB0 Offset: 0x20900B0 VA: 0x182091AB0
	public static AppMessage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2092000 Offset: 0x2090600 VA: 0x182092000
	public static AppMessage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2092090 Offset: 0x2090690 VA: 0x182092090
	public static AppMessage Deserialize(byte[] buffer) { }

	// RVA: 0x2092630 Offset: 0x2090C30 VA: 0x182092630
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2092F10 Offset: 0x2091510 VA: 0x182092F10 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2092F30 Offset: 0x2091530 VA: 0x182092F30 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppMessage previous) { }

	// RVA: 0x2092650 Offset: 0x2090C50 VA: 0x182092650 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2092350 Offset: 0x2090950 VA: 0x182092350
	public static AppMessage Deserialize(byte[] buffer, AppMessage instance, bool isDelta = False) { }

	// RVA: 0x20921B0 Offset: 0x20907B0 VA: 0x1820921B0
	public static AppMessage Deserialize(Stream stream, AppMessage instance, bool isDelta) { }

	// RVA: 0x2091B30 Offset: 0x2090130 VA: 0x182091B30
	public static AppMessage DeserializeLengthDelimited(Stream stream, AppMessage instance, bool isDelta) { }

	// RVA: 0x2091DB0 Offset: 0x20903B0 VA: 0x182091DB0
	public static AppMessage DeserializeLength(Stream stream, int length, AppMessage instance, bool isDelta) { }

	// RVA: 0x2092830 Offset: 0x2090E30 VA: 0x182092830
	public static void SerializeDelta(Stream stream, AppMessage instance, AppMessage previous) { }

	// RVA: 0x2092C90 Offset: 0x2091290 VA: 0x182092C90
	public static void Serialize(Stream stream, AppMessage instance) { }

	// RVA: 0x2092F00 Offset: 0x2091500 VA: 0x182092F00
	public byte[] ToProtoBytes() { }

	// RVA: 0x2092F10 Offset: 0x2091510 VA: 0x182092F10
	public void ToProto(Stream stream) { }

	// RVA: 0x2092B80 Offset: 0x2091180 VA: 0x182092B80
	public static byte[] SerializeToBytes(AppMessage instance) { }

	// RVA: 0x2092AD0 Offset: 0x20910D0 VA: 0x182092AD0
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

	// RVA: 0x1E16A50 Offset: 0x1E15050 VA: 0x181E16A50
	public static void ResetToPool(AppResponse instance) { }

	// RVA: 0x1E16790 Offset: 0x1E14D90 VA: 0x181E16790
	public void ResetToPool() { }

	// RVA: 0x1E166D0 Offset: 0x1E14CD0 VA: 0x181E166D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E150F0 Offset: 0x1E136F0 VA: 0x181E150F0
	public void CopyTo(AppResponse instance) { }

	// RVA: 0x1E15480 Offset: 0x1E13A80 VA: 0x181E15480
	public AppResponse Copy() { }

	// RVA: 0x1E16550 Offset: 0x1E14B50 VA: 0x181E16550
	public static AppResponse Deserialize(Stream stream) { }

	// RVA: 0x1E15A10 Offset: 0x1E14010 VA: 0x181E15A10
	public static AppResponse DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E15F70 Offset: 0x1E14570 VA: 0x181E15F70
	public static AppResponse DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E16000 Offset: 0x1E14600 VA: 0x181E16000
	public static AppResponse Deserialize(byte[] buffer) { }

	// RVA: 0x1E16750 Offset: 0x1E14D50 VA: 0x181E16750
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E182E0 Offset: 0x1E168E0 VA: 0x181E182E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E18300 Offset: 0x1E16900 VA: 0x181E18300 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppResponse previous) { }

	// RVA: 0x1E16770 Offset: 0x1E14D70 VA: 0x181E16770 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E165D0 Offset: 0x1E14BD0 VA: 0x181E165D0
	public static AppResponse Deserialize(byte[] buffer, AppResponse instance, bool isDelta = False) { }

	// RVA: 0x1E16120 Offset: 0x1E14720 VA: 0x181E16120
	public static AppResponse Deserialize(Stream stream, AppResponse instance, bool isDelta) { }

	// RVA: 0x1E15500 Offset: 0x1E13B00 VA: 0x181E15500
	public static AppResponse DeserializeLengthDelimited(Stream stream, AppResponse instance, bool isDelta) { }

	// RVA: 0x1E15A90 Offset: 0x1E14090 VA: 0x181E15A90
	public static AppResponse DeserializeLength(Stream stream, int length, AppResponse instance, bool isDelta) { }

	// RVA: 0x1E16D10 Offset: 0x1E15310 VA: 0x181E16D10
	public static void SerializeDelta(Stream stream, AppResponse instance, AppResponse previous) { }

	// RVA: 0x1E17920 Offset: 0x1E15F20 VA: 0x181E17920
	public static void Serialize(Stream stream, AppResponse instance) { }

	// RVA: 0x1E182D0 Offset: 0x1E168D0 VA: 0x181E182D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E182E0 Offset: 0x1E168E0 VA: 0x181E182E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E17810 Offset: 0x1E15E10 VA: 0x181E17810
	public static byte[] SerializeToBytes(AppResponse instance) { }

	// RVA: 0x1E17760 Offset: 0x1E15D60 VA: 0x181E17760
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

	// RVA: 0x2015D30 Offset: 0x2014330 VA: 0x182015D30
	public static void ResetToPool(AppBroadcast instance) { }

	// RVA: 0x2015C10 Offset: 0x2014210 VA: 0x182015C10
	public void ResetToPool() { }

	// RVA: 0x2015870 Offset: 0x2013E70 VA: 0x182015870 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2014660 Offset: 0x2012C60 VA: 0x182014660
	public void CopyTo(AppBroadcast instance) { }

	// RVA: 0x2014760 Offset: 0x2012D60 VA: 0x182014760
	public AppBroadcast Copy() { }

	// RVA: 0x2014F00 Offset: 0x2013500 VA: 0x182014F00
	public static AppBroadcast Deserialize(Stream stream) { }

	// RVA: 0x2014B60 Offset: 0x2013160 VA: 0x182014B60
	public static AppBroadcast DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2014BE0 Offset: 0x20131E0 VA: 0x182014BE0
	public static AppBroadcast DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2015300 Offset: 0x2013900 VA: 0x182015300
	public static AppBroadcast Deserialize(byte[] buffer) { }

	// RVA: 0x2015A10 Offset: 0x2014010 VA: 0x182015A10
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2016710 Offset: 0x2014D10 VA: 0x182016710 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2016730 Offset: 0x2014D30 VA: 0x182016730 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppBroadcast previous) { }

	// RVA: 0x2015BF0 Offset: 0x20141F0 VA: 0x182015BF0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20155D0 Offset: 0x2013BD0 VA: 0x1820155D0
	public static AppBroadcast Deserialize(byte[] buffer, AppBroadcast instance, bool isDelta = False) { }

	// RVA: 0x2015120 Offset: 0x2013720 VA: 0x182015120
	public static AppBroadcast Deserialize(Stream stream, AppBroadcast instance, bool isDelta) { }

	// RVA: 0x20148A0 Offset: 0x2012EA0 VA: 0x1820148A0
	public static AppBroadcast DeserializeLengthDelimited(Stream stream, AppBroadcast instance, bool isDelta) { }

	// RVA: 0x2014C70 Offset: 0x2013270 VA: 0x182014C70
	public static AppBroadcast DeserializeLength(Stream stream, int length, AppBroadcast instance, bool isDelta) { }

	// RVA: 0x2015E50 Offset: 0x2014450 VA: 0x182015E50
	public static void SerializeDelta(Stream stream, AppBroadcast instance, AppBroadcast previous) { }

	// RVA: 0x20163A0 Offset: 0x20149A0 VA: 0x1820163A0
	public static void Serialize(Stream stream, AppBroadcast instance) { }

	// RVA: 0x2016700 Offset: 0x2014D00 VA: 0x182016700
	public byte[] ToProtoBytes() { }

	// RVA: 0x2016710 Offset: 0x2014D10 VA: 0x182016710
	public void ToProto(Stream stream) { }

	// RVA: 0x2016290 Offset: 0x2014890 VA: 0x182016290
	public static byte[] SerializeToBytes(AppBroadcast instance) { }

	// RVA: 0x20161E0 Offset: 0x20147E0 VA: 0x1820161E0
	public static void SerializeLengthDelimited(Stream stream, AppBroadcast instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class AppEmpty : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6515
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11

	// Methods

	// RVA: 0x2080660 Offset: 0x207EC60 VA: 0x182080660
	public static void ResetToPool(AppEmpty instance) { }

	// RVA: 0x20806D0 Offset: 0x207ECD0 VA: 0x1820806D0
	public void ResetToPool() { }

	// RVA: 0x2080540 Offset: 0x207EB40 VA: 0x182080540 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void CopyTo(AppEmpty instance) { }

	// RVA: 0x207FC90 Offset: 0x207E290 VA: 0x18207FC90
	public AppEmpty Copy() { }

	// RVA: 0x20804C0 Offset: 0x207EAC0 VA: 0x1820804C0
	public static AppEmpty Deserialize(Stream stream) { }

	// RVA: 0x207FEC0 Offset: 0x207E4C0 VA: 0x18207FEC0
	public static AppEmpty DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2080100 Offset: 0x207E700 VA: 0x182080100
	public static AppEmpty DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2080190 Offset: 0x207E790 VA: 0x182080190
	public static AppEmpty Deserialize(byte[] buffer) { }

	// RVA: 0x2080620 Offset: 0x207EC20 VA: 0x182080620
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2080A20 Offset: 0x207F020 VA: 0x182080A20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2080A90 Offset: 0x207F090 VA: 0x182080A90 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppEmpty previous) { }

	// RVA: 0x2080640 Offset: 0x207EC40 VA: 0x182080640 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20803C0 Offset: 0x207E9C0 VA: 0x1820803C0
	public static AppEmpty Deserialize(byte[] buffer, AppEmpty instance, bool isDelta = False) { }

	// RVA: 0x20802B0 Offset: 0x207E8B0 VA: 0x1820802B0
	public static AppEmpty Deserialize(Stream stream, AppEmpty instance, bool isDelta) { }

	// RVA: 0x207FCE0 Offset: 0x207E2E0 VA: 0x18207FCE0
	public static AppEmpty DeserializeLengthDelimited(Stream stream, AppEmpty instance, bool isDelta) { }

	// RVA: 0x207FF40 Offset: 0x207E540 VA: 0x18207FF40
	public static AppEmpty DeserializeLength(Stream stream, int length, AppEmpty instance, bool isDelta) { }

	// RVA: 0x2080740 Offset: 0x207ED40 VA: 0x182080740
	public static void SerializeDelta(Stream stream, AppEmpty instance, AppEmpty previous) { }

	// RVA: 0x20809B0 Offset: 0x207EFB0 VA: 0x1820809B0
	public static void Serialize(Stream stream, AppEmpty instance) { }

	// RVA: 0x2080A10 Offset: 0x207F010 VA: 0x182080A10
	public byte[] ToProtoBytes() { }

	// RVA: 0x2080A20 Offset: 0x207F020 VA: 0x182080A20
	public void ToProto(Stream stream) { }

	// RVA: 0x2080850 Offset: 0x207EE50 VA: 0x182080850
	public static byte[] SerializeToBytes(AppEmpty instance) { }

	// RVA: 0x20807A0 Offset: 0x207EDA0 VA: 0x1820807A0
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

	// RVA: 0x1E18D80 Offset: 0x1E17380 VA: 0x181E18D80
	public static void ResetToPool(AppSendMessage instance) { }

	// RVA: 0x1E18E10 Offset: 0x1E17410 VA: 0x181E18E10
	public void ResetToPool() { }

	// RVA: 0x1E18CC0 Offset: 0x1E172C0 VA: 0x181E18CC0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D67D50 Offset: 0x1D66350 VA: 0x181D67D50
	public void CopyTo(AppSendMessage instance) { }

	// RVA: 0x1E18320 Offset: 0x1E16920 VA: 0x181E18320
	public AppSendMessage Copy() { }

	// RVA: 0x1E189D0 Offset: 0x1E16FD0 VA: 0x181E189D0
	public static AppSendMessage Deserialize(Stream stream) { }

	// RVA: 0x1E185C0 Offset: 0x1E16BC0 VA: 0x181E185C0
	public static AppSendMessage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E18640 Offset: 0x1E16C40 VA: 0x181E18640
	public static AppSendMessage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E18A50 Offset: 0x1E17050 VA: 0x181E18A50
	public static AppSendMessage Deserialize(byte[] buffer) { }

	// RVA: 0x1E18D40 Offset: 0x1E17340 VA: 0x181E18D40
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E19300 Offset: 0x1E17900 VA: 0x181E19300 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E19320 Offset: 0x1E17920 VA: 0x181E19320 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppSendMessage previous) { }

	// RVA: 0x1E18D60 Offset: 0x1E17360 VA: 0x181E18D60 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E188D0 Offset: 0x1E16ED0 VA: 0x181E188D0
	public static AppSendMessage Deserialize(byte[] buffer, AppSendMessage instance, bool isDelta = False) { }

	// RVA: 0x1E18B70 Offset: 0x1E17170 VA: 0x181E18B70
	public static AppSendMessage Deserialize(Stream stream, AppSendMessage instance, bool isDelta) { }

	// RVA: 0x1E183A0 Offset: 0x1E169A0 VA: 0x181E183A0
	public static AppSendMessage DeserializeLengthDelimited(Stream stream, AppSendMessage instance, bool isDelta) { }

	// RVA: 0x1E186D0 Offset: 0x1E16CD0 VA: 0x181E186D0
	public static AppSendMessage DeserializeLength(Stream stream, int length, AppSendMessage instance, bool isDelta) { }

	// RVA: 0x1E18EA0 Offset: 0x1E174A0 VA: 0x181E18EA0
	public static void SerializeDelta(Stream stream, AppSendMessage instance, AppSendMessage previous) { }

	// RVA: 0x1E191C0 Offset: 0x1E177C0 VA: 0x181E191C0
	public static void Serialize(Stream stream, AppSendMessage instance) { }

	// RVA: 0x1E192F0 Offset: 0x1E178F0 VA: 0x181E192F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E19300 Offset: 0x1E17900 VA: 0x181E19300
	public void ToProto(Stream stream) { }

	// RVA: 0x1E190B0 Offset: 0x1E176B0 VA: 0x181E190B0
	public static byte[] SerializeToBytes(AppSendMessage instance) { }

	// RVA: 0x1E19000 Offset: 0x1E17600 VA: 0x181E19000
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

	// RVA: 0x1E19DA0 Offset: 0x1E183A0 VA: 0x181E19DA0
	public static void ResetToPool(AppSetEntityValue instance) { }

	// RVA: 0x1E19E20 Offset: 0x1E18420 VA: 0x181E19E20
	public void ResetToPool() { }

	// RVA: 0x1E19CE0 Offset: 0x1E182E0 VA: 0x181E19CE0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E19340 Offset: 0x1E17940 VA: 0x181E19340
	public void CopyTo(AppSetEntityValue instance) { }

	// RVA: 0x1E19360 Offset: 0x1E17960 VA: 0x181E19360
	public AppSetEntityValue Copy() { }

	// RVA: 0x1E19B60 Offset: 0x1E18160 VA: 0x181E19B60
	public static AppSetEntityValue Deserialize(Stream stream) { }

	// RVA: 0x1E193D0 Offset: 0x1E179D0 VA: 0x181E193D0
	public static AppSetEntityValue DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E19870 Offset: 0x1E17E70 VA: 0x181E19870
	public static AppSetEntityValue DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E19A40 Offset: 0x1E18040 VA: 0x181E19A40
	public static AppSetEntityValue Deserialize(byte[] buffer) { }

	// RVA: 0x1E19D60 Offset: 0x1E18360 VA: 0x181E19D60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E1A2B0 Offset: 0x1E188B0 VA: 0x181E1A2B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E1A380 Offset: 0x1E18980 VA: 0x181E1A380 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppSetEntityValue previous) { }

	// RVA: 0x1E19D80 Offset: 0x1E18380 VA: 0x181E19D80 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E19BE0 Offset: 0x1E181E0 VA: 0x181E19BE0
	public static AppSetEntityValue Deserialize(byte[] buffer, AppSetEntityValue instance, bool isDelta = False) { }

	// RVA: 0x1E19900 Offset: 0x1E17F00 VA: 0x181E19900
	public static AppSetEntityValue Deserialize(Stream stream, AppSetEntityValue instance, bool isDelta) { }

	// RVA: 0x1E19450 Offset: 0x1E17A50 VA: 0x181E19450
	public static AppSetEntityValue DeserializeLengthDelimited(Stream stream, AppSetEntityValue instance, bool isDelta) { }

	// RVA: 0x1E19670 Offset: 0x1E17C70 VA: 0x181E19670
	public static AppSetEntityValue DeserializeLength(Stream stream, int length, AppSetEntityValue instance, bool isDelta) { }

	// RVA: 0x1E19EA0 Offset: 0x1E184A0 VA: 0x181E19EA0
	public static void SerializeDelta(Stream stream, AppSetEntityValue instance, AppSetEntityValue previous) { }

	// RVA: 0x1E1A1D0 Offset: 0x1E187D0 VA: 0x181E1A1D0
	public static void Serialize(Stream stream, AppSetEntityValue instance) { }

	// RVA: 0x1E1A2A0 Offset: 0x1E188A0 VA: 0x181E1A2A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E1A2B0 Offset: 0x1E188B0 VA: 0x181E1A2B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E1A020 Offset: 0x1E18620 VA: 0x181E1A020
	public static byte[] SerializeToBytes(AppSetEntityValue instance) { }

	// RVA: 0x1E19F70 Offset: 0x1E18570 VA: 0x181E19F70
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

	// RVA: 0x2093A80 Offset: 0x2092080 VA: 0x182093A80
	public static void ResetToPool(AppPromoteToLeader instance) { }

	// RVA: 0x2093A00 Offset: 0x2092000 VA: 0x182093A00
	public void ResetToPool() { }

	// RVA: 0x20938D0 Offset: 0x2091ED0 VA: 0x1820938D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F1CBB0 Offset: 0x1F1B1B0 VA: 0x181F1CBB0
	public void CopyTo(AppPromoteToLeader instance) { }

	// RVA: 0x2092F50 Offset: 0x2091550 VA: 0x182092F50
	public AppPromoteToLeader Copy() { }

	// RVA: 0x2093750 Offset: 0x2091D50 VA: 0x182093750
	public static AppPromoteToLeader Deserialize(Stream stream) { }

	// RVA: 0x2092FC0 Offset: 0x20915C0 VA: 0x182092FC0
	public static AppPromoteToLeader DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2093260 Offset: 0x2091860 VA: 0x182093260
	public static AppPromoteToLeader DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2093630 Offset: 0x2091C30 VA: 0x182093630
	public static AppPromoteToLeader Deserialize(byte[] buffer) { }

	// RVA: 0x20939C0 Offset: 0x2091FC0 VA: 0x1820939C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2093F50 Offset: 0x2092550 VA: 0x182093F50 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2094020 Offset: 0x2092620 VA: 0x182094020 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppPromoteToLeader previous) { }

	// RVA: 0x20939E0 Offset: 0x2091FE0 VA: 0x1820939E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20937D0 Offset: 0x2091DD0 VA: 0x1820937D0
	public static AppPromoteToLeader Deserialize(byte[] buffer, AppPromoteToLeader instance, bool isDelta = False) { }

	// RVA: 0x20934F0 Offset: 0x2091AF0 VA: 0x1820934F0
	public static AppPromoteToLeader Deserialize(Stream stream, AppPromoteToLeader instance, bool isDelta) { }

	// RVA: 0x2093040 Offset: 0x2091640 VA: 0x182093040
	public static AppPromoteToLeader DeserializeLengthDelimited(Stream stream, AppPromoteToLeader instance, bool isDelta) { }

	// RVA: 0x20932F0 Offset: 0x20918F0 VA: 0x1820932F0
	public static AppPromoteToLeader DeserializeLength(Stream stream, int length, AppPromoteToLeader instance, bool isDelta) { }

	// RVA: 0x2093B00 Offset: 0x2092100 VA: 0x182093B00
	public static void SerializeDelta(Stream stream, AppPromoteToLeader instance, AppPromoteToLeader previous) { }

	// RVA: 0x2093E70 Offset: 0x2092470 VA: 0x182093E70
	public static void Serialize(Stream stream, AppPromoteToLeader instance) { }

	// RVA: 0x2093F40 Offset: 0x2092540 VA: 0x182093F40
	public byte[] ToProtoBytes() { }

	// RVA: 0x2093F50 Offset: 0x2092550 VA: 0x182093F50
	public void ToProto(Stream stream) { }

	// RVA: 0x2093CC0 Offset: 0x20922C0 VA: 0x182093CC0
	public static byte[] SerializeToBytes(AppPromoteToLeader instance) { }

	// RVA: 0x2093C10 Offset: 0x2092210 VA: 0x182093C10
	public static void SerializeLengthDelimited(Stream stream, AppPromoteToLeader instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class AppSuccess : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6519
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11

	// Methods

	// RVA: 0x1E1AEB0 Offset: 0x1E194B0 VA: 0x181E1AEB0
	public static void ResetToPool(AppSuccess instance) { }

	// RVA: 0x1E1AE40 Offset: 0x1E19440 VA: 0x181E1AE40
	public void ResetToPool() { }

	// RVA: 0x1E1AD80 Offset: 0x1E19380 VA: 0x181E1AD80 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void CopyTo(AppSuccess instance) { }

	// RVA: 0x1E1A4D0 Offset: 0x1E18AD0 VA: 0x181E1A4D0
	public AppSuccess Copy() { }

	// RVA: 0x1E1AC00 Offset: 0x1E19200 VA: 0x181E1AC00
	public static AppSuccess Deserialize(Stream stream) { }

	// RVA: 0x1E1A700 Offset: 0x1E18D00 VA: 0x181E1A700
	public static AppSuccess DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E1A940 Offset: 0x1E18F40 VA: 0x181E1A940
	public static AppSuccess DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E1AAE0 Offset: 0x1E190E0 VA: 0x181E1AAE0
	public static AppSuccess Deserialize(byte[] buffer) { }

	// RVA: 0x1E1AE00 Offset: 0x1E19400 VA: 0x181E1AE00
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E1B200 Offset: 0x1E19800 VA: 0x181E1B200 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E1B270 Offset: 0x1E19870 VA: 0x181E1B270 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppSuccess previous) { }

	// RVA: 0x1E1AE20 Offset: 0x1E19420 VA: 0x181E1AE20 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E1AC80 Offset: 0x1E19280 VA: 0x181E1AC80
	public static AppSuccess Deserialize(byte[] buffer, AppSuccess instance, bool isDelta = False) { }

	// RVA: 0x1E1A9D0 Offset: 0x1E18FD0 VA: 0x181E1A9D0
	public static AppSuccess Deserialize(Stream stream, AppSuccess instance, bool isDelta) { }

	// RVA: 0x1E1A520 Offset: 0x1E18B20 VA: 0x181E1A520
	public static AppSuccess DeserializeLengthDelimited(Stream stream, AppSuccess instance, bool isDelta) { }

	// RVA: 0x1E1A780 Offset: 0x1E18D80 VA: 0x181E1A780
	public static AppSuccess DeserializeLength(Stream stream, int length, AppSuccess instance, bool isDelta) { }

	// RVA: 0x1E1AF20 Offset: 0x1E19520 VA: 0x181E1AF20
	public static void SerializeDelta(Stream stream, AppSuccess instance, AppSuccess previous) { }

	// RVA: 0x1E1B190 Offset: 0x1E19790 VA: 0x181E1B190
	public static void Serialize(Stream stream, AppSuccess instance) { }

	// RVA: 0x1E1B1F0 Offset: 0x1E197F0 VA: 0x181E1B1F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E1B200 Offset: 0x1E19800 VA: 0x181E1B200
	public void ToProto(Stream stream) { }

	// RVA: 0x1E1B030 Offset: 0x1E19630 VA: 0x181E1B030
	public static byte[] SerializeToBytes(AppSuccess instance) { }

	// RVA: 0x1E1AF80 Offset: 0x1E19580 VA: 0x181E1AF80
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

	// RVA: 0x2086930 Offset: 0x2084F30 VA: 0x182086930
	public static void ResetToPool(AppError instance) { }

	// RVA: 0x20868A0 Offset: 0x2084EA0 VA: 0x1820868A0
	public void ResetToPool() { }

	// RVA: 0x2086750 Offset: 0x2084D50 VA: 0x182086750 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D67D50 Offset: 0x1D66350 VA: 0x181D67D50
	public void CopyTo(AppError instance) { }

	// RVA: 0x2085DB0 Offset: 0x20843B0 VA: 0x182085DB0
	public AppError Copy() { }

	// RVA: 0x2086460 Offset: 0x2084A60 VA: 0x182086460
	public static AppError Deserialize(Stream stream) { }

	// RVA: 0x2085E30 Offset: 0x2084430 VA: 0x182085E30
	public static AppError DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20862D0 Offset: 0x20848D0 VA: 0x1820862D0
	public static AppError DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2086630 Offset: 0x2084C30 VA: 0x182086630
	public static AppError Deserialize(byte[] buffer) { }

	// RVA: 0x2086860 Offset: 0x2084E60 VA: 0x182086860
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2086E20 Offset: 0x2085420 VA: 0x182086E20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2086E40 Offset: 0x2085440 VA: 0x182086E40 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppError previous) { }

	// RVA: 0x2086880 Offset: 0x2084E80 VA: 0x182086880 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2086360 Offset: 0x2084960 VA: 0x182086360
	public static AppError Deserialize(byte[] buffer, AppError instance, bool isDelta = False) { }

	// RVA: 0x20864E0 Offset: 0x2084AE0 VA: 0x1820864E0
	public static AppError Deserialize(Stream stream, AppError instance, bool isDelta) { }

	// RVA: 0x2085EB0 Offset: 0x20844B0 VA: 0x182085EB0
	public static AppError DeserializeLengthDelimited(Stream stream, AppError instance, bool isDelta) { }

	// RVA: 0x20860D0 Offset: 0x20846D0 VA: 0x1820860D0
	public static AppError DeserializeLength(Stream stream, int length, AppError instance, bool isDelta) { }

	// RVA: 0x20869C0 Offset: 0x2084FC0 VA: 0x1820869C0
	public static void SerializeDelta(Stream stream, AppError instance, AppError previous) { }

	// RVA: 0x2086CE0 Offset: 0x20852E0 VA: 0x182086CE0
	public static void Serialize(Stream stream, AppError instance) { }

	// RVA: 0x2086E10 Offset: 0x2085410 VA: 0x182086E10
	public byte[] ToProtoBytes() { }

	// RVA: 0x2086E20 Offset: 0x2085420 VA: 0x182086E20
	public void ToProto(Stream stream) { }

	// RVA: 0x2086BD0 Offset: 0x20851D0 VA: 0x182086BD0
	public static byte[] SerializeToBytes(AppError instance) { }

	// RVA: 0x2086B20 Offset: 0x2085120 VA: 0x182086B20
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

	// RVA: 0x2087A70 Offset: 0x2086070 VA: 0x182087A70
	public static void ResetToPool(AppFlag instance) { }

	// RVA: 0x2087AF0 Offset: 0x20860F0 VA: 0x182087AF0
	public void ResetToPool() { }

	// RVA: 0x2087940 Offset: 0x2085F40 VA: 0x182087940 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E19340 Offset: 0x1E17940 VA: 0x181E19340
	public void CopyTo(AppFlag instance) { }

	// RVA: 0x2086FC0 Offset: 0x20855C0 VA: 0x182086FC0
	public AppFlag Copy() { }

	// RVA: 0x20878C0 Offset: 0x2085EC0 VA: 0x1820878C0
	public static AppFlag Deserialize(Stream stream) { }

	// RVA: 0x2087250 Offset: 0x2085850 VA: 0x182087250
	public static AppFlag DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20872D0 Offset: 0x20858D0 VA: 0x1820872D0
	public static AppFlag DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2087560 Offset: 0x2085B60 VA: 0x182087560
	public static AppFlag Deserialize(byte[] buffer) { }

	// RVA: 0x2087A30 Offset: 0x2086030 VA: 0x182087A30
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2087F80 Offset: 0x2086580 VA: 0x182087F80 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2088050 Offset: 0x2086650 VA: 0x182088050 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppFlag previous) { }

	// RVA: 0x2087A50 Offset: 0x2086050 VA: 0x182087A50 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2087680 Offset: 0x2085C80 VA: 0x182087680
	public static AppFlag Deserialize(byte[] buffer, AppFlag instance, bool isDelta = False) { }

	// RVA: 0x2087780 Offset: 0x2085D80 VA: 0x182087780
	public static AppFlag Deserialize(Stream stream, AppFlag instance, bool isDelta) { }

	// RVA: 0x2087030 Offset: 0x2085630 VA: 0x182087030
	public static AppFlag DeserializeLengthDelimited(Stream stream, AppFlag instance, bool isDelta) { }

	// RVA: 0x2087360 Offset: 0x2085960 VA: 0x182087360
	public static AppFlag DeserializeLength(Stream stream, int length, AppFlag instance, bool isDelta) { }

	// RVA: 0x2087B70 Offset: 0x2086170 VA: 0x182087B70
	public static void SerializeDelta(Stream stream, AppFlag instance, AppFlag previous) { }

	// RVA: 0x2087EA0 Offset: 0x20864A0 VA: 0x182087EA0
	public static void Serialize(Stream stream, AppFlag instance) { }

	// RVA: 0x2087F70 Offset: 0x2086570 VA: 0x182087F70
	public byte[] ToProtoBytes() { }

	// RVA: 0x2087F80 Offset: 0x2086580 VA: 0x182087F80
	public void ToProto(Stream stream) { }

	// RVA: 0x2087CF0 Offset: 0x20862F0 VA: 0x182087CF0
	public static byte[] SerializeToBytes(AppFlag instance) { }

	// RVA: 0x2087C40 Offset: 0x2086240 VA: 0x182087C40
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

	// RVA: 0x20899B0 Offset: 0x2087FB0 VA: 0x1820899B0
	public static void ResetToPool(AppInfo instance) { }

	// RVA: 0x2089800 Offset: 0x2087E00 VA: 0x182089800
	public void ResetToPool() { }

	// RVA: 0x2089590 Offset: 0x2087B90 VA: 0x182089590 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20881A0 Offset: 0x20867A0 VA: 0x1820881A0
	public void CopyTo(AppInfo instance) { }

	// RVA: 0x2088250 Offset: 0x2086850 VA: 0x182088250
	public AppInfo Copy() { }

	// RVA: 0x2089510 Offset: 0x2087B10 VA: 0x182089510
	public static AppInfo Deserialize(Stream stream) { }

	// RVA: 0x2088870 Offset: 0x2086E70 VA: 0x182088870
	public static AppInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20888F0 Offset: 0x2086EF0 VA: 0x1820888F0
	public static AppInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2088F90 Offset: 0x2087590 VA: 0x182088F90
	public static AppInfo Deserialize(byte[] buffer) { }

	// RVA: 0x20897C0 Offset: 0x2087DC0 VA: 0x1820897C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x208A760 Offset: 0x2088D60 VA: 0x18208A760 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x208A780 Offset: 0x2088D80 VA: 0x18208A780 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppInfo previous) { }

	// RVA: 0x20897E0 Offset: 0x2087DE0 VA: 0x1820897E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2088E90 Offset: 0x2087490 VA: 0x182088E90
	public static AppInfo Deserialize(byte[] buffer, AppInfo instance, bool isDelta = False) { }

	// RVA: 0x20890B0 Offset: 0x20876B0 VA: 0x1820890B0
	public static AppInfo Deserialize(Stream stream, AppInfo instance, bool isDelta) { }

	// RVA: 0x2088340 Offset: 0x2086940 VA: 0x182088340
	public static AppInfo DeserializeLengthDelimited(Stream stream, AppInfo instance, bool isDelta) { }

	// RVA: 0x2088980 Offset: 0x2086F80 VA: 0x182088980
	public static AppInfo DeserializeLength(Stream stream, int length, AppInfo instance, bool isDelta) { }

	// RVA: 0x2089B60 Offset: 0x2088160 VA: 0x182089B60
	public static void SerializeDelta(Stream stream, AppInfo instance, AppInfo previous) { }

	// RVA: 0x208A330 Offset: 0x2088930 VA: 0x18208A330
	public static void Serialize(Stream stream, AppInfo instance) { }

	// RVA: 0x208A750 Offset: 0x2088D50 VA: 0x18208A750
	public byte[] ToProtoBytes() { }

	// RVA: 0x208A760 Offset: 0x2088D60 VA: 0x18208A760
	public void ToProto(Stream stream) { }

	// RVA: 0x208A220 Offset: 0x2088820 VA: 0x18208A220
	public static byte[] SerializeToBytes(AppInfo instance) { }

	// RVA: 0x208A170 Offset: 0x2088770 VA: 0x18208A170
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

	// RVA: 0x1E232C0 Offset: 0x1E218C0 VA: 0x181E232C0
	public static void ResetToPool(AppTime instance) { }

	// RVA: 0x1E23210 Offset: 0x1E21810 VA: 0x181E23210
	public void ResetToPool() { }

	// RVA: 0x1E22F10 Offset: 0x1E21510 VA: 0x181E22F10 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E21B60 Offset: 0x1E20160 VA: 0x181E21B60
	public void CopyTo(AppTime instance) { }

	// RVA: 0x1E21BA0 Offset: 0x1E201A0 VA: 0x181E21BA0
	public AppTime Copy() { }

	// RVA: 0x1E226B0 Offset: 0x1E20CB0 VA: 0x181E226B0
	public static AppTime Deserialize(Stream stream) { }

	// RVA: 0x1E21C20 Offset: 0x1E20220 VA: 0x181E21C20
	public static AppTime DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E21FD0 Offset: 0x1E205D0 VA: 0x181E21FD0
	public static AppTime DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E22BB0 Offset: 0x1E211B0 VA: 0x181E22BB0
	public static AppTime Deserialize(byte[] buffer) { }

	// RVA: 0x1E22F90 Offset: 0x1E21590 VA: 0x181E22F90
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E23940 Offset: 0x1E21F40 VA: 0x181E23940 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E23960 Offset: 0x1E21F60 VA: 0x181E23960 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppTime previous) { }

	// RVA: 0x1E231F0 Offset: 0x1E217F0 VA: 0x181E231F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E22370 Offset: 0x1E20970 VA: 0x181E22370
	public static AppTime Deserialize(byte[] buffer, AppTime instance, bool isDelta = False) { }

	// RVA: 0x1E22950 Offset: 0x1E20F50 VA: 0x181E22950
	public static AppTime Deserialize(Stream stream, AppTime instance, bool isDelta) { }

	// RVA: 0x1E21CA0 Offset: 0x1E202A0 VA: 0x181E21CA0
	public static AppTime DeserializeLengthDelimited(Stream stream, AppTime instance, bool isDelta) { }

	// RVA: 0x1E22060 Offset: 0x1E20660 VA: 0x181E22060
	public static AppTime DeserializeLength(Stream stream, int length, AppTime instance, bool isDelta) { }

	// RVA: 0x1E23370 Offset: 0x1E21970 VA: 0x181E23370
	public static void SerializeDelta(Stream stream, AppTime instance, AppTime previous) { }

	// RVA: 0x1E237C0 Offset: 0x1E21DC0 VA: 0x181E237C0
	public static void Serialize(Stream stream, AppTime instance) { }

	// RVA: 0x1E23930 Offset: 0x1E21F30 VA: 0x181E23930
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E23940 Offset: 0x1E21F40 VA: 0x181E23940
	public void ToProto(Stream stream) { }

	// RVA: 0x1E236B0 Offset: 0x1E21CB0 VA: 0x181E236B0
	public static byte[] SerializeToBytes(AppTime instance) { }

	// RVA: 0x1E23600 Offset: 0x1E21C00 VA: 0x181E23600
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

	// RVA: 0x208E2B0 Offset: 0x208C8B0 VA: 0x18208E2B0
	public static void ResetToPool(AppMap instance) { }

	// RVA: 0x208E080 Offset: 0x208C680 VA: 0x18208E080
	public void ResetToPool() { }

	// RVA: 0x208DC90 Offset: 0x208C290 VA: 0x18208DC90 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x208C1E0 Offset: 0x208A7E0 VA: 0x18208C1E0
	public void CopyTo(AppMap instance) { }

	// RVA: 0x208C400 Offset: 0x208AA00 VA: 0x18208C400
	public AppMap Copy() { }

	// RVA: 0x208D1B0 Offset: 0x208B7B0 VA: 0x18208D1B0
	public static AppMap Deserialize(Stream stream) { }

	// RVA: 0x208C8B0 Offset: 0x208AEB0 VA: 0x18208C8B0
	public static AppMap DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x208CD30 Offset: 0x208B330 VA: 0x18208CD30
	public static AppMap DeserializeLength(Stream stream, int length) { }

	// RVA: 0x208CDC0 Offset: 0x208B3C0 VA: 0x18208CDC0
	public static AppMap Deserialize(byte[] buffer) { }

	// RVA: 0x208DD10 Offset: 0x208C310 VA: 0x18208DD10
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x208EDD0 Offset: 0x208D3D0 VA: 0x18208EDD0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x208EDF0 Offset: 0x208D3F0 VA: 0x18208EDF0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppMap previous) { }

	// RVA: 0x208E060 Offset: 0x208C660 VA: 0x18208E060 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x208D860 Offset: 0x208BE60 VA: 0x18208D860
	public static AppMap Deserialize(byte[] buffer, AppMap instance, bool isDelta = False) { }

	// RVA: 0x208D510 Offset: 0x208BB10 VA: 0x18208D510
	public static AppMap Deserialize(Stream stream, AppMap instance, bool isDelta) { }

	// RVA: 0x208C480 Offset: 0x208AA80 VA: 0x18208C480
	public static AppMap DeserializeLengthDelimited(Stream stream, AppMap instance, bool isDelta) { }

	// RVA: 0x208C930 Offset: 0x208AF30 VA: 0x18208C930
	public static AppMap DeserializeLength(Stream stream, int length, AppMap instance, bool isDelta) { }

	// RVA: 0x208E4E0 Offset: 0x208CAE0 VA: 0x18208E4E0
	public static void SerializeDelta(Stream stream, AppMap instance, AppMap previous) { }

	// RVA: 0x208EA70 Offset: 0x208D070 VA: 0x18208EA70
	public static void Serialize(Stream stream, AppMap instance) { }

	// RVA: 0x208EDC0 Offset: 0x208D3C0 VA: 0x18208EDC0
	public byte[] ToProtoBytes() { }

	// RVA: 0x208EDD0 Offset: 0x208D3D0 VA: 0x18208EDD0
	public void ToProto(Stream stream) { }

	// RVA: 0x208E960 Offset: 0x208CF60 VA: 0x18208E960
	public static byte[] SerializeToBytes(AppMap instance) { }

	// RVA: 0x208E8B0 Offset: 0x208CEB0 VA: 0x18208E8B0
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

	// RVA: 0x2096BD0 Offset: 0x20951D0 VA: 0x182096BD0
	public static void ResetToPool(AppMap.Monument instance) { }

	// RVA: 0x2096C80 Offset: 0x2095280 VA: 0x182096C80
	public void ResetToPool() { }

	// RVA: 0x2096970 Offset: 0x2094F70 VA: 0x182096970 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2095960 Offset: 0x2093F60 VA: 0x182095960
	public void CopyTo(AppMap.Monument instance) { }

	// RVA: 0x20959B0 Offset: 0x2093FB0 VA: 0x1820959B0
	public AppMap.Monument Copy() { }

	// RVA: 0x2096070 Offset: 0x2094670 VA: 0x182096070
	public static AppMap.Monument Deserialize(Stream stream) { }

	// RVA: 0x2095CE0 Offset: 0x20942E0 VA: 0x182095CE0
	public static AppMap.Monument DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2095FE0 Offset: 0x20945E0 VA: 0x182095FE0
	public static AppMap.Monument DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2096500 Offset: 0x2094B00 VA: 0x182096500
	public static AppMap.Monument Deserialize(byte[] buffer) { }

	// RVA: 0x20969F0 Offset: 0x2094FF0 VA: 0x1820969F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20972C0 Offset: 0x20958C0 VA: 0x1820972C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20972E0 Offset: 0x20958E0 VA: 0x1820972E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppMap.Monument previous) { }

	// RVA: 0x2096BB0 Offset: 0x20951B0 VA: 0x182096BB0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2096270 Offset: 0x2094870 VA: 0x182096270
	public static AppMap.Monument Deserialize(byte[] buffer, AppMap.Monument instance, bool isDelta = False) { }

	// RVA: 0x20967B0 Offset: 0x2094DB0 VA: 0x1820967B0
	public static AppMap.Monument Deserialize(Stream stream, AppMap.Monument instance, bool isDelta) { }

	// RVA: 0x2095A40 Offset: 0x2094040 VA: 0x182095A40
	public static AppMap.Monument DeserializeLengthDelimited(Stream stream, AppMap.Monument instance, bool isDelta) { }

	// RVA: 0x2095D60 Offset: 0x2094360 VA: 0x182095D60
	public static AppMap.Monument DeserializeLength(Stream stream, int length, AppMap.Monument instance, bool isDelta) { }

	// RVA: 0x2096D30 Offset: 0x2095330 VA: 0x182096D30
	public static void SerializeDelta(Stream stream, AppMap.Monument instance, AppMap.Monument previous) { }

	// RVA: 0x2097120 Offset: 0x2095720 VA: 0x182097120
	public static void Serialize(Stream stream, AppMap.Monument instance) { }

	// RVA: 0x20972B0 Offset: 0x20958B0 VA: 0x1820972B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20972C0 Offset: 0x20958C0 VA: 0x1820972C0
	public void ToProto(Stream stream) { }

	// RVA: 0x2097010 Offset: 0x2095610 VA: 0x182097010
	public static byte[] SerializeToBytes(AppMap.Monument instance) { }

	// RVA: 0x2096F60 Offset: 0x2095560 VA: 0x182096F60
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

	// RVA: 0x2082EC0 Offset: 0x20814C0 VA: 0x182082EC0
	public static void ResetToPool(AppEntityInfo instance) { }

	// RVA: 0x2082E10 Offset: 0x2081410 VA: 0x182082E10
	public void ResetToPool() { }

	// RVA: 0x2082CA0 Offset: 0x20812A0 VA: 0x182082CA0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2080B20 Offset: 0x207F120 VA: 0x182080B20
	public void CopyTo(AppEntityInfo instance) { }

	// RVA: 0x20820B0 Offset: 0x20806B0 VA: 0x1820820B0
	public AppEntityInfo Copy() { }

	// RVA: 0x2082C20 Offset: 0x2081220 VA: 0x182082C20
	public static AppEntityInfo Deserialize(Stream stream) { }

	// RVA: 0x2082180 Offset: 0x2080780 VA: 0x182082180
	public static AppEntityInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2082770 Offset: 0x2080D70 VA: 0x182082770
	public static AppEntityInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2082800 Offset: 0x2080E00 VA: 0x182082800
	public static AppEntityInfo Deserialize(byte[] buffer) { }

	// RVA: 0x2082DD0 Offset: 0x20813D0 VA: 0x182082DD0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2083580 Offset: 0x2081B80 VA: 0x182083580 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20835A0 Offset: 0x2081BA0 VA: 0x1820835A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppEntityInfo previous) { }

	// RVA: 0x2082DF0 Offset: 0x20813F0 VA: 0x182082DF0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2082B20 Offset: 0x2081120 VA: 0x182082B20
	public static AppEntityInfo Deserialize(byte[] buffer, AppEntityInfo instance, bool isDelta = False) { }

	// RVA: 0x2082920 Offset: 0x2080F20 VA: 0x182082920
	public static AppEntityInfo Deserialize(Stream stream, AppEntityInfo instance, bool isDelta) { }

	// RVA: 0x2082200 Offset: 0x2080800 VA: 0x182082200
	public static AppEntityInfo DeserializeLengthDelimited(Stream stream, AppEntityInfo instance, bool isDelta) { }

	// RVA: 0x20824D0 Offset: 0x2080AD0 VA: 0x1820824D0
	public static AppEntityInfo DeserializeLength(Stream stream, int length, AppEntityInfo instance, bool isDelta) { }

	// RVA: 0x2082F70 Offset: 0x2081570 VA: 0x182082F70
	public static void SerializeDelta(Stream stream, AppEntityInfo instance, AppEntityInfo previous) { }

	// RVA: 0x2083360 Offset: 0x2081960 VA: 0x182083360
	public static void Serialize(Stream stream, AppEntityInfo instance) { }

	// RVA: 0x2083570 Offset: 0x2081B70 VA: 0x182083570
	public byte[] ToProtoBytes() { }

	// RVA: 0x2083580 Offset: 0x2081B80 VA: 0x182083580
	public void ToProto(Stream stream) { }

	// RVA: 0x2083250 Offset: 0x2081850 VA: 0x182083250
	public static byte[] SerializeToBytes(AppEntityInfo instance) { }

	// RVA: 0x20831A0 Offset: 0x20817A0 VA: 0x1820831A0
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

	// RVA: 0x20851B0 Offset: 0x20837B0 VA: 0x1820851B0
	public static void ResetToPool(AppEntityPayload instance) { }

	// RVA: 0x20853C0 Offset: 0x20839C0 VA: 0x1820853C0
	public void ResetToPool() { }

	// RVA: 0x2084E20 Offset: 0x2083420 VA: 0x182084E20 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20835C0 Offset: 0x2081BC0 VA: 0x1820835C0
	public void CopyTo(AppEntityPayload instance) { }

	// RVA: 0x2083770 Offset: 0x2081D70 VA: 0x182083770
	public AppEntityPayload Copy() { }

	// RVA: 0x2084440 Offset: 0x2082A40 VA: 0x182084440
	public static AppEntityPayload Deserialize(Stream stream) { }

	// RVA: 0x20837F0 Offset: 0x2081DF0 VA: 0x1820837F0
	public static AppEntityPayload DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2083C50 Offset: 0x2082250 VA: 0x182083C50
	public static AppEntityPayload DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2084090 Offset: 0x2082690 VA: 0x182084090
	public static AppEntityPayload Deserialize(byte[] buffer) { }

	// RVA: 0x2084EA0 Offset: 0x20834A0 VA: 0x182084EA0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2085D70 Offset: 0x2084370 VA: 0x182085D70 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2085D90 Offset: 0x2084390 VA: 0x182085D90 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppEntityPayload previous) { }

	// RVA: 0x2085190 Offset: 0x2083790 VA: 0x182085190 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2084750 Offset: 0x2082D50 VA: 0x182084750
	public static AppEntityPayload Deserialize(byte[] buffer, AppEntityPayload instance, bool isDelta = False) { }

	// RVA: 0x2084B20 Offset: 0x2083120 VA: 0x182084B20
	public static AppEntityPayload Deserialize(Stream stream, AppEntityPayload instance, bool isDelta) { }

	// RVA: 0x2083870 Offset: 0x2081E70 VA: 0x182083870
	public static AppEntityPayload DeserializeLengthDelimited(Stream stream, AppEntityPayload instance, bool isDelta) { }

	// RVA: 0x2083CE0 Offset: 0x20822E0 VA: 0x182083CE0
	public static AppEntityPayload DeserializeLength(Stream stream, int length, AppEntityPayload instance, bool isDelta) { }

	// RVA: 0x20855D0 Offset: 0x2083BD0 VA: 0x1820855D0
	public static void SerializeDelta(Stream stream, AppEntityPayload instance, AppEntityPayload previous) { }

	// RVA: 0x2085AB0 Offset: 0x20840B0 VA: 0x182085AB0
	public static void Serialize(Stream stream, AppEntityPayload instance) { }

	// RVA: 0x2085D60 Offset: 0x2084360 VA: 0x182085D60
	public byte[] ToProtoBytes() { }

	// RVA: 0x2085D70 Offset: 0x2084370 VA: 0x182085D70
	public void ToProto(Stream stream) { }

	// RVA: 0x20859A0 Offset: 0x2083FA0 VA: 0x1820859A0
	public static byte[] SerializeToBytes(AppEntityPayload instance) { }

	// RVA: 0x20858F0 Offset: 0x2083EF0 VA: 0x1820858F0
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

	// RVA: 0x2095350 Offset: 0x2093950 VA: 0x182095350
	public static void ResetToPool(AppEntityPayload.Item instance) { }

	// RVA: 0x20953E0 Offset: 0x20939E0 VA: 0x1820953E0
	public void ResetToPool() { }

	// RVA: 0x2095100 Offset: 0x2093700 VA: 0x182095100 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D68DA0 Offset: 0x1D673A0 VA: 0x181D68DA0
	public void CopyTo(AppEntityPayload.Item instance) { }

	// RVA: 0x20941D0 Offset: 0x20927D0 VA: 0x1820941D0
	public AppEntityPayload.Item Copy() { }

	// RVA: 0x2094840 Offset: 0x2092E40 VA: 0x182094840
	public static AppEntityPayload.Item Deserialize(Stream stream) { }

	// RVA: 0x2094250 Offset: 0x2092850 VA: 0x182094250
	public static AppEntityPayload.Item DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2094550 Offset: 0x2092B50 VA: 0x182094550
	public static AppEntityPayload.Item DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2094A30 Offset: 0x2093030 VA: 0x182094A30
	public static AppEntityPayload.Item Deserialize(byte[] buffer) { }

	// RVA: 0x2095180 Offset: 0x2093780 VA: 0x182095180
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2095920 Offset: 0x2093F20 VA: 0x182095920 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2095940 Offset: 0x2093F40 VA: 0x182095940 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppEntityPayload.Item previous) { }

	// RVA: 0x2095330 Offset: 0x2093930 VA: 0x182095330 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2094E80 Offset: 0x2093480 VA: 0x182094E80
	public static AppEntityPayload.Item Deserialize(byte[] buffer, AppEntityPayload.Item instance, bool isDelta = False) { }

	// RVA: 0x2094CD0 Offset: 0x20932D0 VA: 0x182094CD0
	public static AppEntityPayload.Item Deserialize(Stream stream, AppEntityPayload.Item instance, bool isDelta) { }

	// RVA: 0x20942D0 Offset: 0x20928D0 VA: 0x1820942D0
	public static AppEntityPayload.Item DeserializeLengthDelimited(Stream stream, AppEntityPayload.Item instance, bool isDelta) { }

	// RVA: 0x20945E0 Offset: 0x2092BE0 VA: 0x1820945E0
	public static AppEntityPayload.Item DeserializeLength(Stream stream, int length, AppEntityPayload.Item instance, bool isDelta) { }

	// RVA: 0x2095470 Offset: 0x2093A70 VA: 0x182095470
	public static void SerializeDelta(Stream stream, AppEntityPayload.Item instance, AppEntityPayload.Item previous) { }

	// RVA: 0x20957F0 Offset: 0x2093DF0 VA: 0x1820957F0
	public static void Serialize(Stream stream, AppEntityPayload.Item instance) { }

	// RVA: 0x2095910 Offset: 0x2093F10 VA: 0x182095910
	public byte[] ToProtoBytes() { }

	// RVA: 0x2095920 Offset: 0x2093F20 VA: 0x182095920
	public void ToProto(Stream stream) { }

	// RVA: 0x20956E0 Offset: 0x2093CE0 VA: 0x1820956E0
	public static byte[] SerializeToBytes(AppEntityPayload.Item instance) { }

	// RVA: 0x2095630 Offset: 0x2093C30 VA: 0x182095630
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

	// RVA: 0x1E1F900 Offset: 0x1E1DF00 VA: 0x181E1F900
	public static void ResetToPool(AppTeamInfo instance) { }

	// RVA: 0x1E1F4D0 Offset: 0x1E1DAD0 VA: 0x181E1F4D0
	public void ResetToPool() { }

	// RVA: 0x1E1F410 Offset: 0x1E1DA10 VA: 0x181E1F410 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E1DE40 Offset: 0x1E1C440 VA: 0x181E1DE40
	public void CopyTo(AppTeamInfo instance) { }

	// RVA: 0x1E1E290 Offset: 0x1E1C890 VA: 0x181E1E290
	public AppTeamInfo Copy() { }

	// RVA: 0x1E1F390 Offset: 0x1E1D990 VA: 0x181E1F390
	public static AppTeamInfo Deserialize(Stream stream) { }

	// RVA: 0x1E1E7D0 Offset: 0x1E1CDD0 VA: 0x181E1E7D0
	public static AppTeamInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E1E850 Offset: 0x1E1CE50 VA: 0x181E1E850
	public static AppTeamInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E1F270 Offset: 0x1E1D870 VA: 0x181E1F270
	public static AppTeamInfo Deserialize(byte[] buffer) { }

	// RVA: 0x1E1F490 Offset: 0x1E1DA90 VA: 0x181E1F490
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E20830 Offset: 0x1E1EE30 VA: 0x181E20830 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E20850 Offset: 0x1E1EE50 VA: 0x181E20850 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppTeamInfo previous) { }

	// RVA: 0x1E1F4B0 Offset: 0x1E1DAB0 VA: 0x181E1F4B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E1F170 Offset: 0x1E1D770 VA: 0x181E1F170
	public static AppTeamInfo Deserialize(byte[] buffer, AppTeamInfo instance, bool isDelta = False) { }

	// RVA: 0x1E1ED80 Offset: 0x1E1D380 VA: 0x181E1ED80
	public static AppTeamInfo Deserialize(Stream stream, AppTeamInfo instance, bool isDelta) { }

	// RVA: 0x1E1E310 Offset: 0x1E1C910 VA: 0x181E1E310
	public static AppTeamInfo DeserializeLengthDelimited(Stream stream, AppTeamInfo instance, bool isDelta) { }

	// RVA: 0x1E1E8E0 Offset: 0x1E1CEE0 VA: 0x181E1E8E0
	public static AppTeamInfo DeserializeLength(Stream stream, int length, AppTeamInfo instance, bool isDelta) { }

	// RVA: 0x1E1FD30 Offset: 0x1E1E330 VA: 0x181E1FD30
	public static void SerializeDelta(Stream stream, AppTeamInfo instance, AppTeamInfo previous) { }

	// RVA: 0x1E203A0 Offset: 0x1E1E9A0 VA: 0x181E203A0
	public static void Serialize(Stream stream, AppTeamInfo instance) { }

	// RVA: 0x1E20820 Offset: 0x1E1EE20 VA: 0x181E20820
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E20830 Offset: 0x1E1EE30 VA: 0x181E20830
	public void ToProto(Stream stream) { }

	// RVA: 0x1E20290 Offset: 0x1E1E890 VA: 0x181E20290
	public static byte[] SerializeToBytes(AppTeamInfo instance) { }

	// RVA: 0x1E201E0 Offset: 0x1E1E7E0 VA: 0x181E201E0
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

	// RVA: 0x1E27D00 Offset: 0x1E26300 VA: 0x181E27D00
	public static void ResetToPool(AppTeamInfo.Member instance) { }

	// RVA: 0x1E27C00 Offset: 0x1E26200 VA: 0x181E27C00
	public void ResetToPool() { }

	// RVA: 0x1E27830 Offset: 0x1E25E30 VA: 0x181E27830 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E25F00 Offset: 0x1E24500 VA: 0x181E25F00
	public void CopyTo(AppTeamInfo.Member instance) { }

	// RVA: 0x1E25F70 Offset: 0x1E24570 VA: 0x181E25F70
	public AppTeamInfo.Member Copy() { }

	// RVA: 0x1E26D70 Offset: 0x1E25370 VA: 0x181E26D70
	public static AppTeamInfo.Member Deserialize(Stream stream) { }

	// RVA: 0x1E26020 Offset: 0x1E24620 VA: 0x181E26020
	public static AppTeamInfo.Member DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E264B0 Offset: 0x1E24AB0 VA: 0x181E264B0
	public static AppTeamInfo.Member DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E26930 Offset: 0x1E24F30 VA: 0x181E26930
	public static AppTeamInfo.Member Deserialize(byte[] buffer) { }

	// RVA: 0x1E278B0 Offset: 0x1E25EB0 VA: 0x181E278B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E285E0 Offset: 0x1E26BE0 VA: 0x181E285E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E28600 Offset: 0x1E26C00 VA: 0x181E28600 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppTeamInfo.Member previous) { }

	// RVA: 0x1E27BE0 Offset: 0x1E261E0 VA: 0x181E27BE0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E27410 Offset: 0x1E25A10 VA: 0x181E27410
	public static AppTeamInfo.Member Deserialize(byte[] buffer, AppTeamInfo.Member instance, bool isDelta = False) { }

	// RVA: 0x1E270E0 Offset: 0x1E256E0 VA: 0x181E270E0
	public static AppTeamInfo.Member Deserialize(Stream stream, AppTeamInfo.Member instance, bool isDelta) { }

	// RVA: 0x1E260A0 Offset: 0x1E246A0 VA: 0x181E260A0
	public static AppTeamInfo.Member DeserializeLengthDelimited(Stream stream, AppTeamInfo.Member instance, bool isDelta) { }

	// RVA: 0x1E26540 Offset: 0x1E24B40 VA: 0x181E26540
	public static AppTeamInfo.Member DeserializeLength(Stream stream, int length, AppTeamInfo.Member instance, bool isDelta) { }

	// RVA: 0x1E27E00 Offset: 0x1E26400 VA: 0x181E27E00
	public static void SerializeDelta(Stream stream, AppTeamInfo.Member instance, AppTeamInfo.Member previous) { }

	// RVA: 0x1E28370 Offset: 0x1E26970 VA: 0x181E28370
	public static void Serialize(Stream stream, AppTeamInfo.Member instance) { }

	// RVA: 0x1E285D0 Offset: 0x1E26BD0 VA: 0x181E285D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E285E0 Offset: 0x1E26BE0 VA: 0x181E285E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E28260 Offset: 0x1E26860 VA: 0x181E28260
	public static byte[] SerializeToBytes(AppTeamInfo.Member instance) { }

	// RVA: 0x1E281B0 Offset: 0x1E267B0 VA: 0x181E281B0
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

	// RVA: 0x1E29810 Offset: 0x1E27E10 VA: 0x181E29810
	public static void ResetToPool(AppTeamInfo.Note instance) { }

	// RVA: 0x1E298A0 Offset: 0x1E27EA0 VA: 0x181E298A0
	public void ResetToPool() { }

	// RVA: 0x1E295C0 Offset: 0x1E27BC0 VA: 0x181E295C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E28620 Offset: 0x1E26C20 VA: 0x181E28620
	public void CopyTo(AppTeamInfo.Note instance) { }

	// RVA: 0x1E28650 Offset: 0x1E26C50 VA: 0x181E28650
	public AppTeamInfo.Note Copy() { }

	// RVA: 0x1E293D0 Offset: 0x1E279D0 VA: 0x181E293D0
	public static AppTeamInfo.Note Deserialize(Stream stream) { }

	// RVA: 0x1E286D0 Offset: 0x1E26CD0 VA: 0x181E286D0
	public static AppTeamInfo.Note DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E28C50 Offset: 0x1E27250 VA: 0x181E28C50
	public static AppTeamInfo.Note DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E29120 Offset: 0x1E27720 VA: 0x181E29120
	public static AppTeamInfo.Note Deserialize(byte[] buffer) { }

	// RVA: 0x1E29640 Offset: 0x1E27C40 VA: 0x181E29640
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E29E10 Offset: 0x1E28410 VA: 0x181E29E10 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E29E30 Offset: 0x1E28430 VA: 0x181E29E30 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppTeamInfo.Note previous) { }

	// RVA: 0x1E297F0 Offset: 0x1E27DF0 VA: 0x181E297F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E28CE0 Offset: 0x1E272E0 VA: 0x181E28CE0
	public static AppTeamInfo.Note Deserialize(byte[] buffer, AppTeamInfo.Note instance, bool isDelta = False) { }

	// RVA: 0x1E28F70 Offset: 0x1E27570 VA: 0x181E28F70
	public static AppTeamInfo.Note Deserialize(Stream stream, AppTeamInfo.Note instance, bool isDelta) { }

	// RVA: 0x1E28750 Offset: 0x1E26D50 VA: 0x181E28750
	public static AppTeamInfo.Note DeserializeLengthDelimited(Stream stream, AppTeamInfo.Note instance, bool isDelta) { }

	// RVA: 0x1E289E0 Offset: 0x1E26FE0 VA: 0x181E289E0
	public static AppTeamInfo.Note DeserializeLength(Stream stream, int length, AppTeamInfo.Note instance, bool isDelta) { }

	// RVA: 0x1E29930 Offset: 0x1E27F30 VA: 0x181E29930
	public static void SerializeDelta(Stream stream, AppTeamInfo.Note instance, AppTeamInfo.Note previous) { }

	// RVA: 0x1E29CD0 Offset: 0x1E282D0 VA: 0x181E29CD0
	public static void Serialize(Stream stream, AppTeamInfo.Note instance) { }

	// RVA: 0x1E29E00 Offset: 0x1E28400 VA: 0x181E29E00
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E29E10 Offset: 0x1E28410 VA: 0x181E29E10
	public void ToProto(Stream stream) { }

	// RVA: 0x1E29BC0 Offset: 0x1E281C0 VA: 0x181E29BC0
	public static byte[] SerializeToBytes(AppTeamInfo.Note instance) { }

	// RVA: 0x1E29B10 Offset: 0x1E28110 VA: 0x181E29B10
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

	// RVA: 0x2018020 Offset: 0x2016620 VA: 0x182018020
	public static void ResetToPool(AppChatMessage instance) { }

	// RVA: 0x2018130 Offset: 0x2016730 VA: 0x182018130
	public void ResetToPool() { }

	// RVA: 0x2017C00 Offset: 0x2016200 VA: 0x182017C00 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2016750 Offset: 0x2014D50 VA: 0x182016750
	public void CopyTo(AppChatMessage instance) { }

	// RVA: 0x20167C0 Offset: 0x2014DC0 VA: 0x1820167C0
	public AppChatMessage Copy() { }

	// RVA: 0x2017940 Offset: 0x2015F40 VA: 0x182017940
	public static AppChatMessage Deserialize(Stream stream) { }

	// RVA: 0x2016BC0 Offset: 0x20151C0 VA: 0x182016BC0
	public static AppChatMessage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2016C40 Offset: 0x2015240 VA: 0x182016C40
	public static AppChatMessage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2017000 Offset: 0x2015600 VA: 0x182017000
	public static AppChatMessage Deserialize(byte[] buffer) { }

	// RVA: 0x2017D90 Offset: 0x2016390 VA: 0x182017D90
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2018A30 Offset: 0x2017030 VA: 0x182018A30 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2018A50 Offset: 0x2017050 VA: 0x182018A50 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppChatMessage previous) { }

	// RVA: 0x2018000 Offset: 0x2016600 VA: 0x182018000 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20175F0 Offset: 0x2015BF0 VA: 0x1820175F0
	public static AppChatMessage Deserialize(byte[] buffer, AppChatMessage instance, bool isDelta = False) { }

	// RVA: 0x2017370 Offset: 0x2015970 VA: 0x182017370
	public static AppChatMessage Deserialize(Stream stream, AppChatMessage instance, bool isDelta) { }

	// RVA: 0x2016870 Offset: 0x2014E70 VA: 0x182016870
	public static AppChatMessage DeserializeLengthDelimited(Stream stream, AppChatMessage instance, bool isDelta) { }

	// RVA: 0x2016CD0 Offset: 0x20152D0 VA: 0x182016CD0
	public static AppChatMessage DeserializeLength(Stream stream, int length, AppChatMessage instance, bool isDelta) { }

	// RVA: 0x2018240 Offset: 0x2016840 VA: 0x182018240
	public static void SerializeDelta(Stream stream, AppChatMessage instance, AppChatMessage previous) { }

	// RVA: 0x2018760 Offset: 0x2016D60 VA: 0x182018760
	public static void Serialize(Stream stream, AppChatMessage instance) { }

	// RVA: 0x2018A20 Offset: 0x2017020 VA: 0x182018A20
	public byte[] ToProtoBytes() { }

	// RVA: 0x2018A30 Offset: 0x2017030 VA: 0x182018A30
	public void ToProto(Stream stream) { }

	// RVA: 0x2018650 Offset: 0x2016C50 VA: 0x182018650
	public static byte[] SerializeToBytes(AppChatMessage instance) { }

	// RVA: 0x20185A0 Offset: 0x2016BA0 VA: 0x1820185A0
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

	// RVA: 0x1E1D6C0 Offset: 0x1E1BCC0 VA: 0x181E1D6C0
	public static void ResetToPool(AppTeamChat instance) { }

	// RVA: 0x1E1D510 Offset: 0x1E1BB10 VA: 0x181E1D510
	public void ResetToPool() { }

	// RVA: 0x1E1D450 Offset: 0x1E1BA50 VA: 0x181E1D450 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E1C8A0 Offset: 0x1E1AEA0 VA: 0x181E1C8A0
	public void CopyTo(AppTeamChat instance) { }

	// RVA: 0x1E1C9D0 Offset: 0x1E1AFD0 VA: 0x181E1C9D0
	public AppTeamChat Copy() { }

	// RVA: 0x1E1D2B0 Offset: 0x1E1B8B0 VA: 0x181E1D2B0
	public static AppTeamChat Deserialize(Stream stream) { }

	// RVA: 0x1E1CA50 Offset: 0x1E1B050 VA: 0x181E1CA50
	public static AppTeamChat DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E1CF90 Offset: 0x1E1B590 VA: 0x181E1CF90
	public static AppTeamChat DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E1D330 Offset: 0x1E1B930 VA: 0x181E1D330
	public static AppTeamChat Deserialize(byte[] buffer) { }

	// RVA: 0x1E1D4D0 Offset: 0x1E1BAD0 VA: 0x181E1D4D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E1DE00 Offset: 0x1E1C400 VA: 0x181E1DE00 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E1DE20 Offset: 0x1E1C420 VA: 0x181E1DE20 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppTeamChat previous) { }

	// RVA: 0x1E1D4F0 Offset: 0x1E1BAF0 VA: 0x181E1D4F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E1D020 Offset: 0x1E1B620 VA: 0x181E1D020
	public static AppTeamChat Deserialize(byte[] buffer, AppTeamChat instance, bool isDelta = False) { }

	// RVA: 0x1E1D120 Offset: 0x1E1B720 VA: 0x181E1D120
	public static AppTeamChat Deserialize(Stream stream, AppTeamChat instance, bool isDelta) { }

	// RVA: 0x1E1CAD0 Offset: 0x1E1B0D0 VA: 0x181E1CAD0
	public static AppTeamChat DeserializeLengthDelimited(Stream stream, AppTeamChat instance, bool isDelta) { }

	// RVA: 0x1E1CD40 Offset: 0x1E1B340 VA: 0x181E1CD40
	public static AppTeamChat DeserializeLength(Stream stream, int length, AppTeamChat instance, bool isDelta) { }

	// RVA: 0x1E1D870 Offset: 0x1E1BE70 VA: 0x181E1D870
	public static void SerializeDelta(Stream stream, AppTeamChat instance, AppTeamChat previous) { }

	// RVA: 0x1E1DC10 Offset: 0x1E1C210 VA: 0x181E1DC10
	public static void Serialize(Stream stream, AppTeamChat instance) { }

	// RVA: 0x1E1DDF0 Offset: 0x1E1C3F0 VA: 0x181E1DDF0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E1DE00 Offset: 0x1E1C400 VA: 0x181E1DE00
	public void ToProto(Stream stream) { }

	// RVA: 0x1E1DB00 Offset: 0x1E1C100 VA: 0x181E1DB00
	public static byte[] SerializeToBytes(AppTeamChat instance) { }

	// RVA: 0x1E1DA50 Offset: 0x1E1C050 VA: 0x181E1DA50
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

	// RVA: 0x2090760 Offset: 0x208ED60 VA: 0x182090760
	public static void ResetToPool(AppMarker instance) { }

	// RVA: 0x20904C0 Offset: 0x208EAC0 VA: 0x1820904C0
	public void ResetToPool() { }

	// RVA: 0x2090400 Offset: 0x208EA00 VA: 0x182090400 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x208EE10 Offset: 0x208D410 VA: 0x18208EE10
	public void CopyTo(AppMarker instance) { }

	// RVA: 0x208F020 Offset: 0x208D620 VA: 0x18208F020
	public AppMarker Copy() { }

	// RVA: 0x2090280 Offset: 0x208E880 VA: 0x182090280
	public static AppMarker Deserialize(Stream stream) { }

	// RVA: 0x208F630 Offset: 0x208DC30 VA: 0x18208F630
	public static AppMarker DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x208F6B0 Offset: 0x208DCB0 VA: 0x18208F6B0
	public static AppMarker DeserializeLength(Stream stream, int length) { }

	// RVA: 0x208FCA0 Offset: 0x208E2A0 VA: 0x18208FCA0
	public static AppMarker Deserialize(byte[] buffer) { }

	// RVA: 0x2090480 Offset: 0x208EA80 VA: 0x182090480
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20918A0 Offset: 0x208FEA0 VA: 0x1820918A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20918C0 Offset: 0x208FEC0 VA: 0x1820918C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppMarker previous) { }

	// RVA: 0x20904A0 Offset: 0x208EAA0 VA: 0x1820904A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2090300 Offset: 0x208E900 VA: 0x182090300
	public static AppMarker Deserialize(byte[] buffer, AppMarker instance, bool isDelta = False) { }

	// RVA: 0x208FDC0 Offset: 0x208E3C0 VA: 0x18208FDC0
	public static AppMarker Deserialize(Stream stream, AppMarker instance, bool isDelta) { }

	// RVA: 0x208F0A0 Offset: 0x208D6A0 VA: 0x18208F0A0
	public static AppMarker DeserializeLengthDelimited(Stream stream, AppMarker instance, bool isDelta) { }

	// RVA: 0x208F740 Offset: 0x208DD40 VA: 0x18208F740
	public static AppMarker DeserializeLength(Stream stream, int length, AppMarker instance, bool isDelta) { }

	// RVA: 0x2090A00 Offset: 0x208F000 VA: 0x182090A00
	public static void SerializeDelta(Stream stream, AppMarker instance, AppMarker previous) { }

	// RVA: 0x2091360 Offset: 0x208F960 VA: 0x182091360
	public static void Serialize(Stream stream, AppMarker instance) { }

	// RVA: 0x2091890 Offset: 0x208FE90 VA: 0x182091890
	public byte[] ToProtoBytes() { }

	// RVA: 0x20918A0 Offset: 0x208FEA0 VA: 0x1820918A0
	public void ToProto(Stream stream) { }

	// RVA: 0x2091250 Offset: 0x208F850 VA: 0x182091250
	public static byte[] SerializeToBytes(AppMarker instance) { }

	// RVA: 0x20911A0 Offset: 0x208F7A0 VA: 0x1820911A0
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

	// RVA: 0x2099230 Offset: 0x2097830 VA: 0x182099230
	public static void ResetToPool(AppMarker.SellOrder instance) { }

	// RVA: 0x2099140 Offset: 0x2097740 VA: 0x182099140
	public void ResetToPool() { }

	// RVA: 0x2098D40 Offset: 0x2097340 VA: 0x182098D40 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2097300 Offset: 0x2095900 VA: 0x182097300
	public void CopyTo(AppMarker.SellOrder instance) { }

	// RVA: 0x2097350 Offset: 0x2095950 VA: 0x182097350
	public AppMarker.SellOrder Copy() { }

	// RVA: 0x2097D60 Offset: 0x2096360 VA: 0x182097D60
	public static AppMarker.SellOrder Deserialize(Stream stream) { }

	// RVA: 0x20973F0 Offset: 0x20959F0 VA: 0x1820973F0
	public static AppMarker.SellOrder DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2097CD0 Offset: 0x20962D0 VA: 0x182097CD0
	public static AppMarker.SellOrder DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20988C0 Offset: 0x2096EC0 VA: 0x1820988C0
	public static AppMarker.SellOrder Deserialize(byte[] buffer) { }

	// RVA: 0x2098DC0 Offset: 0x20973C0 VA: 0x182098DC0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2099A80 Offset: 0x2098080 VA: 0x182099A80 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2099AA0 Offset: 0x20980A0 VA: 0x182099AA0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppMarker.SellOrder previous) { }

	// RVA: 0x2099120 Offset: 0x2097720 VA: 0x182099120 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2098460 Offset: 0x2096A60 VA: 0x182098460
	public static AppMarker.SellOrder Deserialize(byte[] buffer, AppMarker.SellOrder instance, bool isDelta = False) { }

	// RVA: 0x2098100 Offset: 0x2096700 VA: 0x182098100
	public static AppMarker.SellOrder Deserialize(Stream stream, AppMarker.SellOrder instance, bool isDelta) { }

	// RVA: 0x2097470 Offset: 0x2095A70 VA: 0x182097470
	public static AppMarker.SellOrder DeserializeLengthDelimited(Stream stream, AppMarker.SellOrder instance, bool isDelta) { }

	// RVA: 0x20978B0 Offset: 0x2095EB0 VA: 0x1820978B0
	public static AppMarker.SellOrder DeserializeLength(Stream stream, int length, AppMarker.SellOrder instance, bool isDelta) { }

	// RVA: 0x2099320 Offset: 0x2097920 VA: 0x182099320
	public static void SerializeDelta(Stream stream, AppMarker.SellOrder instance, AppMarker.SellOrder previous) { }

	// RVA: 0x2099870 Offset: 0x2097E70 VA: 0x182099870
	public static void Serialize(Stream stream, AppMarker.SellOrder instance) { }

	// RVA: 0x2099A70 Offset: 0x2098070 VA: 0x182099A70
	public byte[] ToProtoBytes() { }

	// RVA: 0x2099A80 Offset: 0x2098080 VA: 0x182099A80
	public void ToProto(Stream stream) { }

	// RVA: 0x2099760 Offset: 0x2097D60 VA: 0x182099760
	public static byte[] SerializeToBytes(AppMarker.SellOrder instance) { }

	// RVA: 0x20996B0 Offset: 0x2097CB0 VA: 0x1820996B0
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

	// RVA: 0x208B8B0 Offset: 0x2089EB0 VA: 0x18208B8B0
	public static void ResetToPool(AppMapMarkers instance) { }

	// RVA: 0x208BA60 Offset: 0x208A060 VA: 0x18208BA60
	public void ResetToPool() { }

	// RVA: 0x208B630 Offset: 0x2089C30 VA: 0x18208B630 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x208A7A0 Offset: 0x2088DA0 VA: 0x18208A7A0
	public void CopyTo(AppMapMarkers instance) { }

	// RVA: 0x208A930 Offset: 0x2088F30 VA: 0x18208A930
	public AppMapMarkers Copy() { }

	// RVA: 0x208B2C0 Offset: 0x20898C0 VA: 0x18208B2C0
	public static AppMapMarkers Deserialize(Stream stream) { }

	// RVA: 0x208ADF0 Offset: 0x20893F0 VA: 0x18208ADF0
	public static AppMapMarkers DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x208B110 Offset: 0x2089710 VA: 0x18208B110
	public static AppMapMarkers DeserializeLength(Stream stream, int length) { }

	// RVA: 0x208B1A0 Offset: 0x20897A0 VA: 0x18208B1A0
	public static AppMapMarkers Deserialize(byte[] buffer) { }

	// RVA: 0x208B870 Offset: 0x2089E70 VA: 0x18208B870
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x208C1A0 Offset: 0x208A7A0 VA: 0x18208C1A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x208C1C0 Offset: 0x208A7C0 VA: 0x18208C1C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppMapMarkers previous) { }

	// RVA: 0x208B890 Offset: 0x2089E90 VA: 0x18208B890 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x208B340 Offset: 0x2089940 VA: 0x18208B340
	public static AppMapMarkers Deserialize(byte[] buffer, AppMapMarkers instance, bool isDelta = False) { }

	// RVA: 0x208B440 Offset: 0x2089A40 VA: 0x18208B440
	public static AppMapMarkers Deserialize(Stream stream, AppMapMarkers instance, bool isDelta) { }

	// RVA: 0x208AB20 Offset: 0x2089120 VA: 0x18208AB20
	public static AppMapMarkers DeserializeLengthDelimited(Stream stream, AppMapMarkers instance, bool isDelta) { }

	// RVA: 0x208AE70 Offset: 0x2089470 VA: 0x18208AE70
	public static AppMapMarkers DeserializeLength(Stream stream, int length, AppMapMarkers instance, bool isDelta) { }

	// RVA: 0x208BC10 Offset: 0x208A210 VA: 0x18208BC10
	public static void SerializeDelta(Stream stream, AppMapMarkers instance, AppMapMarkers previous) { }

	// RVA: 0x208BFB0 Offset: 0x208A5B0 VA: 0x18208BFB0
	public static void Serialize(Stream stream, AppMapMarkers instance) { }

	// RVA: 0x208C190 Offset: 0x208A790 VA: 0x18208C190
	public byte[] ToProtoBytes() { }

	// RVA: 0x208C1A0 Offset: 0x208A7A0 VA: 0x18208C1A0
	public void ToProto(Stream stream) { }

	// RVA: 0x208BEA0 Offset: 0x208A4A0 VA: 0x18208BEA0
	public static byte[] SerializeToBytes(AppMapMarkers instance) { }

	// RVA: 0x208BDF0 Offset: 0x208A3F0 VA: 0x18208BDF0
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

	// RVA: 0x1E1C190 Offset: 0x1E1A790 VA: 0x181E1C190
	public static void ResetToPool(AppTeamChanged instance) { }

	// RVA: 0x1E1C0E0 Offset: 0x1E1A6E0 VA: 0x181E1C0E0
	public void ResetToPool() { }

	// RVA: 0x1E1BF70 Offset: 0x1E1A570 VA: 0x181E1BF70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E1B300 Offset: 0x1E19900 VA: 0x181E1B300
	public void CopyTo(AppTeamChanged instance) { }

	// RVA: 0x1E1B380 Offset: 0x1E19980 VA: 0x181E1B380
	public AppTeamChanged Copy() { }

	// RVA: 0x1E1BAD0 Offset: 0x1E1A0D0 VA: 0x181E1BAD0
	public static AppTeamChanged Deserialize(Stream stream) { }

	// RVA: 0x1E1B450 Offset: 0x1E19A50 VA: 0x181E1B450
	public static AppTeamChanged DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E1B7A0 Offset: 0x1E19DA0 VA: 0x181E1B7A0
	public static AppTeamChanged DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E1BD50 Offset: 0x1E1A350 VA: 0x181E1BD50
	public static AppTeamChanged Deserialize(byte[] buffer) { }

	// RVA: 0x1E1C0A0 Offset: 0x1E1A6A0 VA: 0x181E1C0A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E1C860 Offset: 0x1E1AE60 VA: 0x181E1C860 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E1C880 Offset: 0x1E1AE80 VA: 0x181E1C880 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppTeamChanged previous) { }

	// RVA: 0x1E1C0C0 Offset: 0x1E1A6C0 VA: 0x181E1C0C0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E1BE70 Offset: 0x1E1A470 VA: 0x181E1BE70
	public static AppTeamChanged Deserialize(byte[] buffer, AppTeamChanged instance, bool isDelta = False) { }

	// RVA: 0x1E1BB50 Offset: 0x1E1A150 VA: 0x181E1BB50
	public static AppTeamChanged Deserialize(Stream stream, AppTeamChanged instance, bool isDelta) { }

	// RVA: 0x1E1B4D0 Offset: 0x1E19AD0 VA: 0x181E1B4D0
	public static AppTeamChanged DeserializeLengthDelimited(Stream stream, AppTeamChanged instance, bool isDelta) { }

	// RVA: 0x1E1B830 Offset: 0x1E19E30 VA: 0x181E1B830
	public static AppTeamChanged DeserializeLength(Stream stream, int length, AppTeamChanged instance, bool isDelta) { }

	// RVA: 0x1E1C240 Offset: 0x1E1A840 VA: 0x181E1C240
	public static void SerializeDelta(Stream stream, AppTeamChanged instance, AppTeamChanged previous) { }

	// RVA: 0x1E1C640 Offset: 0x1E1AC40 VA: 0x181E1C640
	public static void Serialize(Stream stream, AppTeamChanged instance) { }

	// RVA: 0x1E1C850 Offset: 0x1E1AE50 VA: 0x181E1C850
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E1C860 Offset: 0x1E1AE60 VA: 0x181E1C860
	public void ToProto(Stream stream) { }

	// RVA: 0x1E1C530 Offset: 0x1E1AB30 VA: 0x181E1C530
	public static byte[] SerializeToBytes(AppTeamChanged instance) { }

	// RVA: 0x1E1C480 Offset: 0x1E1AA80 VA: 0x181E1C480
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

	// RVA: 0x1E21510 Offset: 0x1E1FB10 VA: 0x181E21510
	public static void ResetToPool(AppTeamMessage instance) { }

	// RVA: 0x1E21470 Offset: 0x1E1FA70 VA: 0x181E21470
	public void ResetToPool() { }

	// RVA: 0x1E21310 Offset: 0x1E1F910 VA: 0x181E21310 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E20870 Offset: 0x1E1EE70 VA: 0x181E20870
	public void CopyTo(AppTeamMessage instance) { }

	// RVA: 0x1E208E0 Offset: 0x1E1EEE0 VA: 0x181E208E0
	public AppTeamMessage Copy() { }

	// RVA: 0x1E21290 Offset: 0x1E1F890 VA: 0x181E21290
	public static AppTeamMessage Deserialize(Stream stream) { }

	// RVA: 0x1E209B0 Offset: 0x1E1EFB0 VA: 0x181E209B0
	public static AppTeamMessage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E20E80 Offset: 0x1E1F480 VA: 0x181E20E80
	public static AppTeamMessage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E21010 Offset: 0x1E1F610 VA: 0x181E21010
	public static AppTeamMessage Deserialize(byte[] buffer) { }

	// RVA: 0x1E21430 Offset: 0x1E1FA30 VA: 0x181E21430
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E21B20 Offset: 0x1E20120 VA: 0x181E21B20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E21B40 Offset: 0x1E20140 VA: 0x181E21B40 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppTeamMessage previous) { }

	// RVA: 0x1E21450 Offset: 0x1E1FA50 VA: 0x181E21450 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E20F10 Offset: 0x1E1F510 VA: 0x181E20F10
	public static AppTeamMessage Deserialize(byte[] buffer, AppTeamMessage instance, bool isDelta = False) { }

	// RVA: 0x1E21130 Offset: 0x1E1F730 VA: 0x181E21130
	public static AppTeamMessage Deserialize(Stream stream, AppTeamMessage instance, bool isDelta) { }

	// RVA: 0x1E20A30 Offset: 0x1E1F030 VA: 0x181E20A30
	public static AppTeamMessage DeserializeLengthDelimited(Stream stream, AppTeamMessage instance, bool isDelta) { }

	// RVA: 0x1E20C70 Offset: 0x1E1F270 VA: 0x181E20C70
	public static AppTeamMessage DeserializeLength(Stream stream, int length, AppTeamMessage instance, bool isDelta) { }

	// RVA: 0x1E215B0 Offset: 0x1E1FBB0 VA: 0x181E215B0
	public static void SerializeDelta(Stream stream, AppTeamMessage instance, AppTeamMessage previous) { }

	// RVA: 0x1E21950 Offset: 0x1E1FF50 VA: 0x181E21950
	public static void Serialize(Stream stream, AppTeamMessage instance) { }

	// RVA: 0x1E21B10 Offset: 0x1E20110 VA: 0x181E21B10
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E21B20 Offset: 0x1E20120 VA: 0x181E21B20
	public void ToProto(Stream stream) { }

	// RVA: 0x1E21840 Offset: 0x1E1FE40 VA: 0x181E21840
	public static byte[] SerializeToBytes(AppTeamMessage instance) { }

	// RVA: 0x1E21790 Offset: 0x1E1FD90 VA: 0x181E21790
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

	// RVA: 0x20819B0 Offset: 0x207FFB0 VA: 0x1820819B0
	public static void ResetToPool(AppEntityChanged instance) { }

	// RVA: 0x2081900 Offset: 0x207FF00 VA: 0x182081900
	public void ResetToPool() { }

	// RVA: 0x2081790 Offset: 0x207FD90 VA: 0x182081790 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2080B20 Offset: 0x207F120 VA: 0x182080B20
	public void CopyTo(AppEntityChanged instance) { }

	// RVA: 0x2080BA0 Offset: 0x207F1A0 VA: 0x182080BA0
	public AppEntityChanged Copy() { }

	// RVA: 0x20813F0 Offset: 0x207F9F0 VA: 0x1820813F0
	public static AppEntityChanged Deserialize(Stream stream) { }

	// RVA: 0x2080F40 Offset: 0x207F540 VA: 0x182080F40
	public static AppEntityChanged DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2081260 Offset: 0x207F860 VA: 0x182081260
	public static AppEntityChanged DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2081670 Offset: 0x207FC70 VA: 0x182081670
	public static AppEntityChanged Deserialize(byte[] buffer) { }

	// RVA: 0x20818C0 Offset: 0x207FEC0 VA: 0x1820818C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2082070 Offset: 0x2080670 VA: 0x182082070 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2082090 Offset: 0x2080690 VA: 0x182082090 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppEntityChanged previous) { }

	// RVA: 0x20818E0 Offset: 0x207FEE0 VA: 0x1820818E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20812F0 Offset: 0x207F8F0 VA: 0x1820812F0
	public static AppEntityChanged Deserialize(byte[] buffer, AppEntityChanged instance, bool isDelta = False) { }

	// RVA: 0x2081470 Offset: 0x207FA70 VA: 0x182081470
	public static AppEntityChanged Deserialize(Stream stream, AppEntityChanged instance, bool isDelta) { }

	// RVA: 0x2080C70 Offset: 0x207F270 VA: 0x182080C70
	public static AppEntityChanged DeserializeLengthDelimited(Stream stream, AppEntityChanged instance, bool isDelta) { }

	// RVA: 0x2080FC0 Offset: 0x207F5C0 VA: 0x182080FC0
	public static AppEntityChanged DeserializeLength(Stream stream, int length, AppEntityChanged instance, bool isDelta) { }

	// RVA: 0x2081A60 Offset: 0x2080060 VA: 0x182081A60
	public static void SerializeDelta(Stream stream, AppEntityChanged instance, AppEntityChanged previous) { }

	// RVA: 0x2081E50 Offset: 0x2080450 VA: 0x182081E50
	public static void Serialize(Stream stream, AppEntityChanged instance) { }

	// RVA: 0x2082060 Offset: 0x2080660 VA: 0x182082060
	public byte[] ToProtoBytes() { }

	// RVA: 0x2082070 Offset: 0x2080670 VA: 0x182082070
	public void ToProto(Stream stream) { }

	// RVA: 0x2081D40 Offset: 0x2080340 VA: 0x182081D40
	public static byte[] SerializeToBytes(AppEntityChanged instance) { }

	// RVA: 0x2081C90 Offset: 0x2080290 VA: 0x182081C90
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

	// RVA: 0x1B9D7B0 Offset: 0x1B9BDB0 VA: 0x181B9D7B0
	public static void Quit() { }

	// RVA: 0x1B9D820 Offset: 0x1B9BE20 VA: 0x181B9D820
	public static string get_installPath() { }

	// RVA: 0x1B9D810 Offset: 0x1B9BE10 VA: 0x181B9D810
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ulong <InventoryId>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string <Desc>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string <Name>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ulong <WorkshopdId>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Price <Price>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <Tradable>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private DropChance <DropChance>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <Marketable>k__BackingField; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Skinnable <Skinnable>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <AllowInCrates>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public ulong get_InventoryId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x8C1080 Offset: 0x8BF680 VA: 0x1808C1080
	private void set_InventoryId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Desc() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	private void set_Desc(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	private void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public ulong get_WorkshopdId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xE72CC0 Offset: 0xE712C0 VA: 0x180E72CC0
	private void set_WorkshopdId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA38CE0 Offset: 0xA372E0 VA: 0x180A38CE0
	internal Price get_Price() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA392A0 Offset: 0xA378A0 VA: 0x180A392A0
	private void set_Price(Price value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xBA1A80 Offset: 0xBA0080 VA: 0x180BA1A80
	public bool get_Tradable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xE72CB0 Offset: 0xE712B0 VA: 0x180E72CB0
	private void set_Tradable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x6BB940 Offset: 0x6B9F40 VA: 0x1806BB940
	public DropChance get_DropChance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xC74910 Offset: 0xC72F10 VA: 0x180C74910
	private void set_DropChance(DropChance value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xC659E0 Offset: 0xC63FE0 VA: 0x180C659E0
	public bool get_Marketable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xE72CA0 Offset: 0xE712A0 VA: 0x180E72CA0
	private void set_Marketable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public Skinnable get_Skinnable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	private void set_Skinnable(Skinnable value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4BC3E0 Offset: 0x4BA9E0 VA: 0x1804BC3E0
	public bool get_AllowInCrates() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4BC5E0 Offset: 0x4BABE0 VA: 0x1804BC5E0
	private void set_AllowInCrates(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xBA1AA0 Offset: 0xBA00A0 VA: 0x180BA1AA0
	public bool get_IsLimitedTimeOffer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	[BaseEntity.Menu] // RVA: 0xB0480 Offset: 0xAF880 VA: 0x1800B0480
	[BaseEntity.Menu.Description] // RVA: 0xB0480 Offset: 0xAF880 VA: 0x1800B0480
	[BaseEntity.Menu.Icon] // RVA: 0xB0480 Offset: 0xAF880 VA: 0x1800B0480
	[BaseEntity.Menu.ShowIf] // RVA: 0xB0480 Offset: 0xAF880 VA: 0x1800B0480
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
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static string listenip; // 0x0
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static int port; // 0x8
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static string publicip; // 0x10
	[ServerVar] // RVA: 0x86470 Offset: 0x85870 VA: 0x180086470
	public static bool update; // 0x18
	[ServerVar] // RVA: 0x86540 Offset: 0x85940 VA: 0x180086540
	public static bool notifications; // 0x19
	[ServerVar] // RVA: 0x866A0 Offset: 0x85AA0 VA: 0x1800866A0
	public static int queuelimit; // 0x1C
	[ReplicatedVar] // RVA: 0x87AD0 Offset: 0x86ED0 VA: 0x180087AD0
	public static string serverid; // 0x20
	[ServerVar] // RVA: 0x87C90 Offset: 0x87090 VA: 0x180087C90
	public static float alarmcooldown; // 0x28
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static int maxconnections; // 0x2C
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static int maxconnectionsperip; // 0x30

	// Methods

	// RVA: 0x6CAE20 Offset: 0x6C9420 VA: 0x1806CAE20
	public void .ctor() { }

	// RVA: 0x6CAD20 Offset: 0x6C9320 VA: 0x1806CAD20
	private static void .cctor() { }

}

