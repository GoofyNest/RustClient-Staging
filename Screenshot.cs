public struct Screenshot // TypeDefIndex: 5556
{	// Fields
	internal ScreenshotHandle Value; // 0x0

}

public class Screenshot : SingletonComponent<Screenshot> // TypeDefIndex: 11336
{	// Fields
	public string screenshotPath; // 0x18
	public int sizeMultiplier; // 0x20
	public static bool TakingScreenshot; // 0x0
	private bool takingScreenshot; // 0x24
	private string savePathName; // 0x28

	// Methods

	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	// RVA: 0x4A5560 Offset: 0x4A3B60 VA: 0x1804A5560
	public static void takescreenshot(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	// RVA: 0x4A5470 Offset: 0x4A3A70 VA: 0x1804A5470
	public static void takehiresscreenshot(ConsoleSystem.Arg arg) { }

	// RVA: 0x4A5390 Offset: 0x4A3990 VA: 0x1804A5390
	private void TakeScreenshotNormal() { }

	// RVA: 0x4A5300 Offset: 0x4A3900 VA: 0x1804A5300
	private void TakeHighResScreenshot() { }

	[IteratorStateMachineAttribute] // RVA: 0xA4F50 Offset: 0xA4350 VA: 0x1800A4F50
	// RVA: 0x4A5240 Offset: 0x4A3840 VA: 0x1804A5240
	private IEnumerator SaveScreenshot(string ext, int resolutionX, int resolutionY, bool withHud, bool withoutHud) { }

	// RVA: 0x4A5070 Offset: 0x4A3670 VA: 0x1804A5070
	private void GetScreenCallback(Texture2D texture) { }

	[IteratorStateMachineAttribute] // RVA: 0xA4FF0 Offset: 0xA43F0 VA: 0x1800A4FF0
	// RVA: 0x4A5180 Offset: 0x4A3780 VA: 0x1804A5180
	public static IEnumerator GetScreen(Camera camera, int resolutionX, int resolutionY, Action<Texture2D> finishedCallback, Action renderCallback, bool updateCamera = False) { }

	// RVA: 0x4A5410 Offset: 0x4A3A10 VA: 0x1804A5410
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

private sealed class Screenshot.<SaveScreenshot>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11337
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public int resolutionX; // 0x20
	public int resolutionY; // 0x24
	public Screenshot <>4__this; // 0x28
	public bool withHud; // 0x30
	public string ext; // 0x38
	public bool withoutHud; // 0x40
	private string <path>5__2; // 0x48
	private bool <oldNametags>5__3; // 0x50
	private int <i>5__4; // 0x54

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x4B2EF0 Offset: 0x4B14F0 VA: 0x1804B2EF0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4B3710 Offset: 0x4B1D10 VA: 0x1804B3710 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class Screenshot.<GetScreen>d__11 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11338
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Camera camera; // 0x20
	public int resolutionX; // 0x28
	public int resolutionY; // 0x2C
	public bool updateCamera; // 0x30
	public Action renderCallback; // 0x38
	public Action<Texture2D> finishedCallback; // 0x40
	private PostProcessLayer <post>5__2; // 0x48
	private RenderTexture <rt>5__3; // 0x50
	private float <screenSizeMultiple>5__4; // 0x58
	private float <originalDofBlur>5__5; // 0x5C
	private int <originalAA>5__6; // 0x60
	private RenderTexture <originalRT>5__7; // 0x68
	private int <originalMask>5__8; // 0x70
	private bool <originalBranding>5__9; // 0x74
	private bool <nvgEnabled>5__10; // 0x75

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x4B12A0 Offset: 0x4AF8A0 VA: 0x1804B12A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4B1D30 Offset: 0x4B0330 VA: 0x1804B1D30 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

