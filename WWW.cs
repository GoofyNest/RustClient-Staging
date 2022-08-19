public class WWW : CustomYieldInstruction, IDisposable // TypeDefIndex: 4755
{
// Namespace: UnityEngine
[ObsoleteAttribute] // RVA: 0xB4D70 Offset: 0xB4170 VA: 0x1800B4D70
public class WWW : CustomYieldInstruction, IDisposable // TypeDefIndex: 4755
	// Fields
	private UnityWebRequest _uwr; // 0x10

	// Properties
	public string error { get; }
	public bool isDone { get; }
	public string text { get; }
	public Texture2D texture { get; }
	public string url { get; }
	public override bool keepWaiting { get; }

	// Methods

	// RVA: 0x231A210 Offset: 0x2318810 VA: 0x18231A210
	public static string UnEscapeURL(string s) { }

	// RVA: 0x231A240 Offset: 0x2318840 VA: 0x18231A240
	public static string UnEscapeURL(string s, Encoding e) { }

	// RVA: 0x231A330 Offset: 0x2318930 VA: 0x18231A330
	public void .ctor(string url) { }

	// RVA: 0x231A5F0 Offset: 0x2318BF0 VA: 0x18231A5F0
	public void .ctor(string url, WWWForm form) { }

	// RVA: 0x231A390 Offset: 0x2318990 VA: 0x18231A390
	public void .ctor(string url, byte[] postData, Dictionary<string, string> headers) { }

	// RVA: 0x231A670 Offset: 0x2318C70 VA: 0x18231A670
	public string get_error() { }

	// RVA: 0x231A780 Offset: 0x2318D80 VA: 0x18231A780
	public bool get_isDone() { }

	// RVA: 0x231A7D0 Offset: 0x2318DD0 VA: 0x18231A7D0
	public string get_text() { }

	// RVA: 0x231A0B0 Offset: 0x23186B0 VA: 0x18231A0B0
	private Texture2D CreateTextureFromDownloadedData(bool markNonReadable) { }

	// RVA: 0x231A850 Offset: 0x2318E50 VA: 0x18231A850
	public Texture2D get_texture() { }

	// RVA: 0x231A950 Offset: 0x2318F50 VA: 0x18231A950
	public string get_url() { }

	// RVA: 0x231A7A0 Offset: 0x2318DA0 VA: 0x18231A7A0 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x231A1D0 Offset: 0x23187D0 VA: 0x18231A1D0 Slot: 8
	public void Dispose() { }

	// RVA: 0x231A250 Offset: 0x2318850 VA: 0x18231A250
	private bool WaitUntilDoneIfPossible() { }

}

