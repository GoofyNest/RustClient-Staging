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

	// RVA: 0x231A310 Offset: 0x2318910 VA: 0x18231A310
	public static string UnEscapeURL(string s) { }

	// RVA: 0x231A340 Offset: 0x2318940 VA: 0x18231A340
	public static string UnEscapeURL(string s, Encoding e) { }

	// RVA: 0x231A430 Offset: 0x2318A30 VA: 0x18231A430
	public void .ctor(string url) { }

	// RVA: 0x231A6F0 Offset: 0x2318CF0 VA: 0x18231A6F0
	public void .ctor(string url, WWWForm form) { }

	// RVA: 0x231A490 Offset: 0x2318A90 VA: 0x18231A490
	public void .ctor(string url, byte[] postData, Dictionary<string, string> headers) { }

	// RVA: 0x231A770 Offset: 0x2318D70 VA: 0x18231A770
	public string get_error() { }

	// RVA: 0x231A880 Offset: 0x2318E80 VA: 0x18231A880
	public bool get_isDone() { }

	// RVA: 0x231A8D0 Offset: 0x2318ED0 VA: 0x18231A8D0
	public string get_text() { }

	// RVA: 0x231A1B0 Offset: 0x23187B0 VA: 0x18231A1B0
	private Texture2D CreateTextureFromDownloadedData(bool markNonReadable) { }

	// RVA: 0x231A950 Offset: 0x2318F50 VA: 0x18231A950
	public Texture2D get_texture() { }

	// RVA: 0x231AA50 Offset: 0x2319050 VA: 0x18231AA50
	public string get_url() { }

	// RVA: 0x231A8A0 Offset: 0x2318EA0 VA: 0x18231A8A0 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x231A2D0 Offset: 0x23188D0 VA: 0x18231A2D0 Slot: 8
	public void Dispose() { }

	// RVA: 0x231A350 Offset: 0x2318950 VA: 0x18231A350
	private bool WaitUntilDoneIfPossible() { }

}

