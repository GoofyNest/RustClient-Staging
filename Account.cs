public static class Account // TypeDefIndex: 6172
{	// Fields
	public static RealTimeSince LastUpdated; // 0x0
	public static int UnreadNotices; // 0x4
	public static AccountNotice[] Notices; // 0x8

	// Properties
	public static bool IsReachable { get; }

	// Methods

	// RVA: 0x14A8510 Offset: 0x14A6B10 VA: 0x1814A8510
	public static bool get_IsReachable() { }

	[AsyncStateMachineAttribute] // RVA: 0x9F030 Offset: 0x9E430 VA: 0x18009F030
	// RVA: 0x14A83F0 Offset: 0x14A69F0 VA: 0x1814A83F0
	public static Task Refresh() { }

	[AsyncStateMachineAttribute] // RVA: 0x9F130 Offset: 0x9E530 VA: 0x18009F130
	// RVA: 0x14A8310 Offset: 0x14A6910 VA: 0x1814A8310
	public static Task ReadAllNotices() { }

	// RVA: 0x14A84C0 Offset: 0x14A6AC0 VA: 0x1814A84C0
	private static void .cctor() { }

}

public class Account.AccountJson // TypeDefIndex: 6173
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <SteamId>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <UnreadNotices>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private AccountNotice[] <Notices>k__BackingField; // 0x20

	// Properties
	public string SteamId { get; set; }
	public int UnreadNotices { get; set; }
	public AccountNotice[] Notices { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_SteamId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	public void set_SteamId(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	public int get_UnreadNotices() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79C6B0 Offset: 0x79ACB0 VA: 0x18079C6B0
	public void set_UnreadNotices(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public AccountNotice[] get_Notices() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_Notices(AccountNotice[] value) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private struct Account.<Refresh>d__6 : IAsyncStateMachine // TypeDefIndex: 6174
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	private IAuthTicket <ticket>5__2; // 0x20
	private TaskAwaiter<IAuthTicket> <>u__1; // 0x28
	private TaskAwaiter<string> <>u__2; // 0x30

	// Methods

	// RVA: 0x1F1D90 Offset: 0x1F1190 VA: 0x1801F1D90 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Account.<ReadAllNotices>d__7 : IAsyncStateMachine // TypeDefIndex: 6175
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	private IAuthTicket <ticket>5__2; // 0x20
	private TaskAwaiter<IAuthTicket> <>u__1; // 0x28
	private TaskAwaiter<string> <>u__2; // 0x30
	private TaskAwaiter <>u__3; // 0x38

	// Methods

	// RVA: 0x1F1D80 Offset: 0x1F1180 VA: 0x1801F1D80 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

