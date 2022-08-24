public class CompanionSetupScreen : SingletonComponent<CompanionSetupScreen> // TypeDefIndex: 11089
{	public const string PairedKey = "companionPaired";
	public GameObject instructionsBody; // 0x18
	public GameObject detailsPanel; // 0x20
	public GameObject loadingMessage; // 0x28
	public GameObject errorMessage; // 0x30
	public GameObject notSupportedMessage; // 0x38
	public GameObject disabledMessage; // 0x40
	public GameObject enabledMessage; // 0x48
	public GameObject refreshButton; // 0x50
	public GameObject enableButton; // 0x58
	public GameObject disableButton; // 0x60
	public GameObject pairButton; // 0x68
	public RustText serverName; // 0x70
	public RustButton helpButton; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private CompanionSetupScreen.ScreenState <State>k__BackingField; // 0x80
	private bool _isLoading; // 0x84
	private Nullable<bool> _enabled; // 0x85
	private bool _hidePair; // 0x87

	public CompanionSetupScreen.ScreenState State { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public CompanionSetupScreen.ScreenState get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_State(CompanionSetupScreen.ScreenState value) { }

	public void OnEnable() { }

	public void Refresh() { }

	[AsyncStateMachineAttribute] // RVA: 0x94CC0 Offset: 0x940C0 VA: 0x180094CC0
	public void RefreshImpl() { }

	[AsyncStateMachineAttribute] // RVA: 0x94E40 Offset: 0x94240 VA: 0x180094E40
	public void Enable() { }

	[AsyncStateMachineAttribute] // RVA: 0x94F30 Offset: 0x94330 VA: 0x180094F30
	public void Disable() { }

	public void Pair() { }

	private void ResetPair() { }

	public void OpenVideo() { }

	public void HelpPressed() { }

	public void HelpReleased() { }

	private void UpdateUI() { }

	public void ChangeState(CompanionSetupScreen.ScreenState state) { }

	public void .ctor() { }

}

public enum CompanionSetupScreen.ScreenState // TypeDefIndex: 11090
{	public int value__; // 0x0
	public const CompanionSetupScreen.ScreenState Loading = 0;
	public const CompanionSetupScreen.ScreenState Error = 1;
	public const CompanionSetupScreen.ScreenState NoServer = 2;
	public const CompanionSetupScreen.ScreenState NotSupported = 3;
	public const CompanionSetupScreen.ScreenState NotInstalled = 4;
	public const CompanionSetupScreen.ScreenState Disabled = 5;
	public const CompanionSetupScreen.ScreenState Enabled = 6;
	public const CompanionSetupScreen.ScreenState ShowHelp = 7;

}

private struct CompanionSetupScreen.<RefreshImpl>d__24 : IAsyncStateMachine // TypeDefIndex: 11091
{	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public CompanionSetupScreen <>4__this; // 0x28
	private TaskAwaiter<CompanionSubscription.Status> <>u__1; // 0x30


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct CompanionSetupScreen.<Enable>d__25 : IAsyncStateMachine // TypeDefIndex: 11092
{	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public CompanionSetupScreen <>4__this; // 0x28
	private TaskAwaiter <>u__1; // 0x30


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct CompanionSetupScreen.<Disable>d__26 : IAsyncStateMachine // TypeDefIndex: 11093
{	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public CompanionSetupScreen <>4__this; // 0x28
	private TaskAwaiter <>u__1; // 0x30


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public static class CompanionSubscription // TypeDefIndex: 11094
{	private const string ApiEndpoint = "https://companion-rust.facepunch.com/api/subscriptions";
	private const string CheckApi = "https://companion-rust.facepunch.com/api/subscriptions/check";
	private const string AddApi = "https://companion-rust.facepunch.com/api/subscriptions/add";
	private const string RemoveApi = "https://companion-rust.facepunch.com/api/subscriptions/remove";
	private static readonly HttpClient Http; // 0x2B10918


	[AsyncStateMachineAttribute] // RVA: 0x954B0 Offset: 0x948B0 VA: 0x1800954B0
	public static Task<CompanionSubscription.Status> CheckStatus() { }

	[AsyncStateMachineAttribute] // RVA: 0x955B0 Offset: 0x949B0 VA: 0x1800955B0
	public static Task Add() { }

	[AsyncStateMachineAttribute] // RVA: 0x956E0 Offset: 0x94AE0 VA: 0x1800956E0
	public static Task Remove() { }

	private static StringContent GenerateRequest(IAuthTicket authTicket) { }

	private static void .cctor() { }

}

private class CompanionSubscription.Request // TypeDefIndex: 11095
{	public string SteamTicket; // 0x10
	public string ServerId; // 0x18


	public void .ctor() { }

}

public class CompanionSubscription.Status // TypeDefIndex: 11096
{	public bool IsInstalled; // 0x10
	public bool IsSubscribed; // 0x11


	public void .ctor() { }

}

private struct CompanionSubscription.<CheckStatus>d__5 : IAsyncStateMachine // TypeDefIndex: 11097
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<CompanionSubscription.Status> <>t__builder; // 0x8
	private IAuthTicket <ticket>5__2; // 0x20
	private TaskAwaiter<IAuthTicket> <>u__1; // 0x28
	private TaskAwaiter<HttpResponseMessage> <>u__2; // 0x30
	private TaskAwaiter<string> <>u__3; // 0x38


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct CompanionSubscription.<Add>d__6 : IAsyncStateMachine // TypeDefIndex: 11098
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	private IAuthTicket <ticket>5__2; // 0x20
	private TaskAwaiter<IAuthTicket> <>u__1; // 0x28
	private TaskAwaiter<HttpResponseMessage> <>u__2; // 0x30


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct CompanionSubscription.<Remove>d__7 : IAsyncStateMachine // TypeDefIndex: 11099
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	private IAuthTicket <ticket>5__2; // 0x20
	private TaskAwaiter<IAuthTicket> <>u__1; // 0x28
	private TaskAwaiter<HttpResponseMessage> <>u__2; // 0x30


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

