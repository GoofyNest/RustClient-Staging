public static class Account // TypeDefIndex: 6172
{	public static RealTimeSince LastUpdated; // 0x0
	public static int UnreadNotices; // 0x4
	public static AccountNotice[] Notices; // 0x8

	public static bool IsReachable { get; }


	public static bool get_IsReachable() { }

	[AsyncStateMachineAttribute] // RVA: 0x9F030 Offset: 0x9E430 VA: 0x18009F030
	public static Task Refresh() { }

	[AsyncStateMachineAttribute] // RVA: 0x9F130 Offset: 0x9E530 VA: 0x18009F130
	public static Task ReadAllNotices() { }

	private static void .cctor() { }

}

public class Account.AccountJson // TypeDefIndex: 6173
{	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <SteamId>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <UnreadNotices>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private AccountNotice[] <Notices>k__BackingField; // 0x20

	public string SteamId { get; set; }
	public int UnreadNotices { get; set; }
	public AccountNotice[] Notices { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public string get_SteamId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_SteamId(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_UnreadNotices() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_UnreadNotices(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public AccountNotice[] get_Notices() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_Notices(AccountNotice[] value) { }

	public void .ctor() { }

}

private struct Account.<Refresh>d__6 : IAsyncStateMachine // TypeDefIndex: 6174
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	private IAuthTicket <ticket>5__2; // 0x20
	private TaskAwaiter<IAuthTicket> <>u__1; // 0x28
	private TaskAwaiter<string> <>u__2; // 0x30


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Account.<ReadAllNotices>d__7 : IAsyncStateMachine // TypeDefIndex: 6175
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	private IAuthTicket <ticket>5__2; // 0x20
	private TaskAwaiter<IAuthTicket> <>u__1; // 0x28
	private TaskAwaiter<string> <>u__2; // 0x30
	private TaskAwaiter <>u__3; // 0x38


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

