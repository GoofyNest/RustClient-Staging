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

	// RVA: 0x231A050 Offset: 0x2318650 VA: 0x18231A050
	public static string UnEscapeURL(string s) { }

	// RVA: 0x231A080 Offset: 0x2318680 VA: 0x18231A080
	public static string UnEscapeURL(string s, Encoding e) { }

	// RVA: 0x231A170 Offset: 0x2318770 VA: 0x18231A170
	public void .ctor(string url) { }

	// RVA: 0x231A430 Offset: 0x2318A30 VA: 0x18231A430
	public void .ctor(string url, WWWForm form) { }

	// RVA: 0x231A1D0 Offset: 0x23187D0 VA: 0x18231A1D0
	public void .ctor(string url, byte[] postData, Dictionary<string, string> headers) { }

	// RVA: 0x231A4B0 Offset: 0x2318AB0 VA: 0x18231A4B0
	public string get_error() { }

	// RVA: 0x231A5C0 Offset: 0x2318BC0 VA: 0x18231A5C0
	public bool get_isDone() { }

	// RVA: 0x231A610 Offset: 0x2318C10 VA: 0x18231A610
	public string get_text() { }

	// RVA: 0x2319EF0 Offset: 0x23184F0 VA: 0x182319EF0
	private Texture2D CreateTextureFromDownloadedData(bool markNonReadable) { }

	// RVA: 0x231A690 Offset: 0x2318C90 VA: 0x18231A690
	public Texture2D get_texture() { }

	// RVA: 0x231A790 Offset: 0x2318D90 VA: 0x18231A790
	public string get_url() { }

	// RVA: 0x231A5E0 Offset: 0x2318BE0 VA: 0x18231A5E0 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x231A010 Offset: 0x2318610 VA: 0x18231A010 Slot: 8
	public void Dispose() { }

	// RVA: 0x231A090 Offset: 0x2318690 VA: 0x18231A090
	private bool WaitUntilDoneIfPossible() { }

}

