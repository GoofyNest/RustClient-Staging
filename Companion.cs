public class CompanionSetupScreen : SingletonComponent<CompanionSetupScreen> // TypeDefIndex: 11085
{	// Fields
	public const string PairedKey = "companionPaired";
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private CompanionSetupScreen.ScreenState <State>k__BackingField; // 0x80
	private bool _isLoading; // 0x84
	private Nullable<bool> _enabled; // 0x85
	private bool _hidePair; // 0x87

	// Properties
	public CompanionSetupScreen.ScreenState State { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5828D0 Offset: 0x580ED0 VA: 0x1805828D0
	public CompanionSetupScreen.ScreenState get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5828E0 Offset: 0x580EE0 VA: 0x1805828E0
	private void set_State(CompanionSetupScreen.ScreenState value) { }

	// RVA: 0x582120 Offset: 0x580720 VA: 0x180582120
	public void OnEnable() { }

	// RVA: 0x5823B0 Offset: 0x5809B0 VA: 0x1805823B0
	public void Refresh() { }

	[AsyncStateMachineAttribute] // RVA: 0x95060 Offset: 0x94460 VA: 0x180095060
	// RVA: 0x5822E0 Offset: 0x5808E0 VA: 0x1805822E0
	public void RefreshImpl() { }

	[AsyncStateMachineAttribute] // RVA: 0x95260 Offset: 0x94660 VA: 0x180095260
	// RVA: 0x581F00 Offset: 0x580500 VA: 0x180581F00
	public void Enable() { }

	[AsyncStateMachineAttribute] // RVA: 0x95320 Offset: 0x94720 VA: 0x180095320
	// RVA: 0x581E30 Offset: 0x580430 VA: 0x180581E30
	public void Disable() { }

	// RVA: 0x582170 Offset: 0x580770 VA: 0x180582170
	public void Pair() { }

	// RVA: 0x582840 Offset: 0x580E40 VA: 0x180582840
	private void ResetPair() { }

	// RVA: 0x582130 Offset: 0x580730 VA: 0x180582130
	public void OpenVideo() { }

	// RVA: 0x581FD0 Offset: 0x5805D0 VA: 0x180581FD0
	public void HelpPressed() { }

	// RVA: 0x582120 Offset: 0x580720 VA: 0x180582120
	public void HelpReleased() { }

	// RVA: 0x582860 Offset: 0x580E60 VA: 0x180582860
	private void UpdateUI() { }

	// RVA: 0x581BF0 Offset: 0x5801F0 VA: 0x180581BF0
	public void ChangeState(CompanionSetupScreen.ScreenState state) { }

	// RVA: 0x582870 Offset: 0x580E70 VA: 0x180582870
	public void .ctor() { }

}

public enum CompanionSetupScreen.ScreenState // TypeDefIndex: 11086
{	// Fields
	public int value__; // 0x0
	public const CompanionSetupScreen.ScreenState Loading = 0;
	public const CompanionSetupScreen.ScreenState Error = 1;
	public const CompanionSetupScreen.ScreenState NoServer = 2;
	public const CompanionSetupScreen.ScreenState NotSupported = 3;
	public const CompanionSetupScreen.ScreenState NotInstalled = 4;
	public const CompanionSetupScreen.ScreenState Disabled = 5;
	public const CompanionSetupScreen.ScreenState Enabled = 6;
	public const CompanionSetupScreen.ScreenState ShowHelp = 7;

}

private struct CompanionSetupScreen.<RefreshImpl>d__24 : IAsyncStateMachine // TypeDefIndex: 11087
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public CompanionSetupScreen <>4__this; // 0x28
	private TaskAwaiter<CompanionSubscription.Status> <>u__1; // 0x30

	// Methods

	// RVA: 0xF2D20 Offset: 0xF2120 VA: 0x1800F2D20 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF1530 Offset: 0xF0930 VA: 0x1800F1530 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct CompanionSetupScreen.<Enable>d__25 : IAsyncStateMachine // TypeDefIndex: 11088
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public CompanionSetupScreen <>4__this; // 0x28
	private TaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0xF2D10 Offset: 0xF2110 VA: 0x1800F2D10 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF1530 Offset: 0xF0930 VA: 0x1800F1530 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct CompanionSetupScreen.<Disable>d__26 : IAsyncStateMachine // TypeDefIndex: 11089
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public CompanionSetupScreen <>4__this; // 0x28
	private TaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0xF2D00 Offset: 0xF2100 VA: 0x1800F2D00 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF1530 Offset: 0xF0930 VA: 0x1800F1530 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public static class CompanionSubscription // TypeDefIndex: 11090
{	// Fields
	private const string ApiEndpoint = "https://companion-rust.facepunch.com/api/subscriptions";
	private const string CheckApi = "https://companion-rust.facepunch.com/api/subscriptions/check";
	private const string AddApi = "https://companion-rust.facepunch.com/api/subscriptions/add";
	private const string RemoveApi = "https://companion-rust.facepunch.com/api/subscriptions/remove";
	private static readonly HttpClient Http; // 0x2F00

	// Methods

	[AsyncStateMachineAttribute] // RVA: 0x957A0 Offset: 0x94BA0 VA: 0x1800957A0
	// RVA: 0x5829C0 Offset: 0x580FC0 VA: 0x1805829C0
	public static Task<CompanionSubscription.Status> CheckStatus() { }

	[AsyncStateMachineAttribute] // RVA: 0x957F0 Offset: 0x94BF0 VA: 0x1800957F0
	// RVA: 0x5828F0 Offset: 0x580EF0 VA: 0x1805828F0
	public static Task Add() { }

	[AsyncStateMachineAttribute] // RVA: 0x959E0 Offset: 0x94DE0 VA: 0x1800959E0
	// RVA: 0x582C90 Offset: 0x581290 VA: 0x180582C90
	public static Task Remove() { }

	// RVA: 0x582AA0 Offset: 0x5810A0 VA: 0x180582AA0
	private static StringContent GenerateRequest(IAuthTicket authTicket) { }

	// RVA: 0x582D60 Offset: 0x581360 VA: 0x180582D60
	private static void .cctor() { }

}

private class CompanionSubscription.Request // TypeDefIndex: 11091
{	// Fields
	public string SteamTicket; // 0x10
	public string ServerId; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class CompanionSubscription.Status // TypeDefIndex: 11092
{	// Fields
	public bool IsInstalled; // 0x10
	public bool IsSubscribed; // 0x11

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private struct CompanionSubscription.<CheckStatus>d__5 : IAsyncStateMachine // TypeDefIndex: 11093
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<CompanionSubscription.Status> <>t__builder; // 0x8
	private IAuthTicket <ticket>5__2; // 0x20
	private TaskAwaiter<IAuthTicket> <>u__1; // 0x28
	private TaskAwaiter<HttpResponseMessage> <>u__2; // 0x30
	private TaskAwaiter<string> <>u__3; // 0x38

	// Methods

	// RVA: 0xF47B0 Offset: 0xF3BB0 VA: 0x1800F47B0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF47C0 Offset: 0xF3BC0 VA: 0x1800F47C0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct CompanionSubscription.<Add>d__6 : IAsyncStateMachine // TypeDefIndex: 11094
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	private IAuthTicket <ticket>5__2; // 0x20
	private TaskAwaiter<IAuthTicket> <>u__1; // 0x28
	private TaskAwaiter<HttpResponseMessage> <>u__2; // 0x30

	// Methods

	// RVA: 0xF47A0 Offset: 0xF3BA0 VA: 0x1800F47A0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct CompanionSubscription.<Remove>d__7 : IAsyncStateMachine // TypeDefIndex: 11095
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	private IAuthTicket <ticket>5__2; // 0x20
	private TaskAwaiter<IAuthTicket> <>u__1; // 0x28
	private TaskAwaiter<HttpResponseMessage> <>u__2; // 0x30

	// Methods

	// RVA: 0xF4810 Offset: 0xF3C10 VA: 0x1800F4810 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

